﻿using System.Buffers;
using System.Net;
using System.Reflection;
using EggLink.DanhengServer.Enums;
using EggLink.DanhengServer.Game.Player;
using EggLink.DanhengServer.KcpSharp;
using EggLink.DanhengServer.Program;
using EggLink.DanhengServer.Server.Packet;
using EggLink.DanhengServer.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using KcpSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EggLink.DanhengServer.Server;
public partial class Connection
{
    public long? ConversationID => Conversation.ConversationId;
    private readonly KcpConversation Conversation;
    private readonly CancellationTokenSource CancelToken;
    public readonly IPEndPoint RemoteEndPoint;
    public SessionState State { get; set; } = SessionState.INACTIVE;
    private bool UseSecretKey { get; set; } = false;
    private byte[] SecretKey = new byte[0x1000];
    public Player? Player { get; set; }
    public uint ClientTime { get; private set; }
    public long LastPingTime { get; private set; }
    private uint LastClientSeq = 10;
    public static readonly List<int> BANNED_PACKETS = [];
    private static Logger Logger = new("GameServer");
#if DEBUG
    private static uint LogIndex = 0;
#endif
    public Connection(KcpConversation conversation, IPEndPoint remote)
    {
        Conversation = conversation;
        RemoteEndPoint = remote;
        CancelToken = new CancellationTokenSource();
        Start();
    }

    private async void Start()
    {
        Logger.Info($"New connection to {RemoteEndPoint} created with conversation id {Conversation.ConversationId}");
        State = SessionState.WAITING_FOR_TOKEN;
        await ReceiveLoop();
    }
    public async void Stop()
    {
        if (Player != null)
        {
            await Player.OnLogoutAsync();
        }
        Listener.UnregisterConnection(this);
        Conversation.Dispose();
        try
        {
            CancelToken.Cancel();
            CancelToken.Dispose();
        }
        catch { }

    }

    private void UpdateLastPingTime(uint clientTime)
    {
        ClientTime = clientTime;
        LastPingTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
    }

#if DEBUG
    public static void LogPacket(string sendOrRecv, ushort opcode, byte[] payload)
    {
        //Logger.DebugWriteLine($"{sendOrRecv}: {Enum.GetName(typeof(OpCode), opcode)}({opcode})\r\n{Convert.ToHexString(payload)}");
        Type? typ = AppDomain.CurrentDomain.GetAssemblies().
       SingleOrDefault(assembly => assembly.GetName().Name == "Shared").GetTypes().First(t => t.Name == $"{Enum.GetName(typeof(CmdId), opcode)}"); //get the type using the packet name
        MessageDescriptor? descriptor = (MessageDescriptor)typ.GetProperty("Descriptor", BindingFlags.Public | BindingFlags.Static).GetValue(null, null); // get the static property Descriptor
        IMessage? packet = descriptor.Parser.ParseFrom(payload);
        JsonFormatter? formatter = JsonFormatter.Default;
        string? asJson = formatter.Format(packet);
        Logger.Debug($"{sendOrRecv}: {Enum.GetName(typeof(CmdId), opcode)}({opcode})\r\n{asJson}");
    }

#endif
    private async Task ReceiveLoop()
    {
        while (!CancelToken.IsCancellationRequested)
        {
            // WaitToReceiveAsync call completes when there is at least one message is received or the transport is closed.
            KcpConversationReceiveResult result = await Conversation.WaitToReceiveAsync(CancelToken.Token);
            if (result.TransportClosed)
            {
                Logger.Debug("Connection was closed");
                break;
            }
            if (result.BytesReceived > Listener.MAX_MSG_SIZE)
            {
                // The message is too large.
                Logger.Error("Packet too large");
                Conversation.SetTransportClosed();
                break;
            }

            byte[] buffer = ArrayPool<byte>.Shared.Rent(result.BytesReceived);
            try
            {
                // TryReceive should not return false here, unless the transport is closed.
                // So we don't need to check for result.TransportClosed.
                if (!Conversation.TryReceive(buffer, out result))
                {
                    Logger.Error("Failed to receive packet");
                    break;
                }
                await ProcessMessageAsync(buffer.AsMemory(0, result.BytesReceived));
            }
            catch (Exception ex)
            {
                Logger.Error("Packet parse error", ex);
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(buffer);
            }
        }
        Stop();
    }

    // DO THE PROCESSING OF THE GAME PACKET
    private async Task ProcessMessageAsync(Memory<byte> data)
    {
        byte[] gamePacket = data.ToArray();

        // Decrypt and turn back into a packet
        //Crypto.Xor(gamePacket, UseSecretKey ? SecretKey : Crypto.DISPATCH_KEY);
        await using MemoryStream? ms = new(gamePacket);
        using BinaryReader? br = new(ms);

        // Handle
        try
        {
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                // Length
                if (br.BaseStream.Length - br.BaseStream.Position < 12)
                {
                    return;
                }
                // Packet sanity check
                uint Magic1 = br.ReadUInt32BE();
                if (Magic1 != 0x9D74C714)
                {
                    Logger.Error($"Bad Data Package Received: got 0x{Magic1:X}, expect 0x9D74C714");
                    return; // Bad packet
                }
                // Data
                ushort opcode = br.ReadUInt16BE();
                ushort headerLength = br.ReadUInt16BE();
                uint payloadLength = br.ReadUInt32BE();
                byte[] header = br.ReadBytes(headerLength);
                byte[] payload = br.ReadBytes((int)payloadLength);

                await HandlePacketAsync(opcode, header, payload);
            }

        }
        catch (Exception e)
        {
            Logger.Error(e.Message, e);
        }
        finally
        {
            await ms.DisposeAsync();
        }
    }

    private async Task<bool> HandlePacketAsync(ushort opcode, byte[] header, byte[] payload)
    {
        // Find the Handler for this opcode
        Handler? handler = EntryPoint.HandlerManager.GetHandler(opcode);
        if (handler != null)
        {
            // Handle
            // Make sure session is ready for packets
            SessionState state = State;
            switch ((int)opcode)
            {
                case CmdId.PlayerGetTokenCsReq:
                    {
                        if (state != SessionState.WAITING_FOR_TOKEN)
                        {
                            return true;
                        }
                        goto default;
                    }
                case CmdId.PlayerLoginCsReq:
                    {
                        if (state != SessionState.WAITING_FOR_LOGIN)
                        {
                            return true;
                        }
                        goto default;
                    }
                default:
                    break;
            }
            handler.OnHandle(header, payload);
            return true;
        }

        return false;
    }


    public async Task SendPacketAsync(BasePacket packet)
    {
        // Test
        if (packet.CmdId <= 0)
        {
            Logger.Debug("Tried to send packet with missing cmd id!");
            return;
        }

        // DO NOT REMOVE (unless we find a way to validate code before sending to client which I don't think we can)
        if (BANNED_PACKETS.Contains(packet.CmdId))
        {
            return;
        }

        // Header
        byte[] packetBytes = packet.BuildPacket();

        await Conversation.SendAsync(packetBytes, CancelToken.Token);
    }
}
