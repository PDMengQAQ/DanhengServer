// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetSecretKeyInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetSecretKeyInfoScRsp.proto</summary>
  public static partial class GetSecretKeyInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetSecretKeyInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetSecretKeyInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHZXRTZWNyZXRLZXlJbmZvU2NSc3AucHJvdG8aEURHQUtHUFBCSklHLnBy",
            "b3RvImAKFUdldFNlY3JldEtleUluZm9TY1JzcBITCgtKSElIQ0tFT0dNThgM",
            "IAEoDBIhCgtNQ1BQTUlBRkRCRRgFIAMoCzIMLkRHQUtHUFBCSklHEg8KB3Jl",
            "dGNvZGUYASABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DGAKGPPBJIGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetSecretKeyInfoScRsp), global::EggLink.DanhengServer.Proto.GetSecretKeyInfoScRsp.Parser, new[]{ "JHIHCKEOGMN", "MCPPMIAFDBE", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetSecretKeyInfoScRsp : pb::IMessage<GetSecretKeyInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetSecretKeyInfoScRsp> _parser = new pb::MessageParser<GetSecretKeyInfoScRsp>(() => new GetSecretKeyInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetSecretKeyInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetSecretKeyInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSecretKeyInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSecretKeyInfoScRsp(GetSecretKeyInfoScRsp other) : this() {
      jHIHCKEOGMN_ = other.jHIHCKEOGMN_;
      mCPPMIAFDBE_ = other.mCPPMIAFDBE_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSecretKeyInfoScRsp Clone() {
      return new GetSecretKeyInfoScRsp(this);
    }

    /// <summary>Field number for the "JHIHCKEOGMN" field.</summary>
    public const int JHIHCKEOGMNFieldNumber = 12;
    private pb::ByteString jHIHCKEOGMN_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString JHIHCKEOGMN {
      get { return jHIHCKEOGMN_; }
      set {
        jHIHCKEOGMN_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MCPPMIAFDBE" field.</summary>
    public const int MCPPMIAFDBEFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DGAKGPPBJIG> _repeated_mCPPMIAFDBE_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.DGAKGPPBJIG.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DGAKGPPBJIG> mCPPMIAFDBE_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DGAKGPPBJIG>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DGAKGPPBJIG> MCPPMIAFDBE {
      get { return mCPPMIAFDBE_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetSecretKeyInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetSecretKeyInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JHIHCKEOGMN != other.JHIHCKEOGMN) return false;
      if(!mCPPMIAFDBE_.Equals(other.mCPPMIAFDBE_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (JHIHCKEOGMN.Length != 0) hash ^= JHIHCKEOGMN.GetHashCode();
      hash ^= mCPPMIAFDBE_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      mCPPMIAFDBE_.WriteTo(output, _repeated_mCPPMIAFDBE_codec);
      if (JHIHCKEOGMN.Length != 0) {
        output.WriteRawTag(98);
        output.WriteBytes(JHIHCKEOGMN);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      mCPPMIAFDBE_.WriteTo(ref output, _repeated_mCPPMIAFDBE_codec);
      if (JHIHCKEOGMN.Length != 0) {
        output.WriteRawTag(98);
        output.WriteBytes(JHIHCKEOGMN);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (JHIHCKEOGMN.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(JHIHCKEOGMN);
      }
      size += mCPPMIAFDBE_.CalculateSize(_repeated_mCPPMIAFDBE_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetSecretKeyInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.JHIHCKEOGMN.Length != 0) {
        JHIHCKEOGMN = other.JHIHCKEOGMN;
      }
      mCPPMIAFDBE_.Add(other.mCPPMIAFDBE_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42: {
            mCPPMIAFDBE_.AddEntriesFrom(input, _repeated_mCPPMIAFDBE_codec);
            break;
          }
          case 98: {
            JHIHCKEOGMN = input.ReadBytes();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 42: {
            mCPPMIAFDBE_.AddEntriesFrom(ref input, _repeated_mCPPMIAFDBE_codec);
            break;
          }
          case 98: {
            JHIHCKEOGMN = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code