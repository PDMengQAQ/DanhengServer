// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetChallengeScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetChallengeScRsp.proto</summary>
  public static partial class GetChallengeScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetChallengeScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetChallengeScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHZXRDaGFsbGVuZ2VTY1JzcC5wcm90bxoUQ2hhbGxlbmdlR3JvdXAucHJv",
            "dG8aEVBCQU9NS0JCQkZDLnByb3RvGg9DaGFsbGVuZ2UucHJvdG8irwEKEUdl",
            "dENoYWxsZW5nZVNjUnNwEiEKC01HR01HTU5LREpLGAsgAygLMgwuUEJBT01L",
            "QkJCRkMSLQoUY2hhbGxlbmdlX2dyb3VwX2xpc3QYAiADKAsyDy5DaGFsbGVu",
            "Z2VHcm91cBIPCgdyZXRjb2RlGA4gASgNEiIKDmNoYWxsZW5nZV9saXN0GAog",
            "AygLMgouQ2hhbGxlbmdlEhMKC05LSEdGSU9BR1BLGAggASgNQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChallengeGroupReflection.Descriptor, global::EggLink.DanhengServer.Proto.PBAOMKBBBFCReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChallengeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetChallengeScRsp), global::EggLink.DanhengServer.Proto.GetChallengeScRsp.Parser, new[]{ "MGGMGMNKDJK", "ChallengeGroupList", "Retcode", "ChallengeList", "NKHGFIOAGPK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetChallengeScRsp : pb::IMessage<GetChallengeScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetChallengeScRsp> _parser = new pb::MessageParser<GetChallengeScRsp>(() => new GetChallengeScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetChallengeScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetChallengeScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChallengeScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChallengeScRsp(GetChallengeScRsp other) : this() {
      mGGMGMNKDJK_ = other.mGGMGMNKDJK_.Clone();
      challengeGroupList_ = other.challengeGroupList_.Clone();
      retcode_ = other.retcode_;
      challengeList_ = other.challengeList_.Clone();
      nKHGFIOAGPK_ = other.nKHGFIOAGPK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetChallengeScRsp Clone() {
      return new GetChallengeScRsp(this);
    }

    /// <summary>Field number for the "MGGMGMNKDJK" field.</summary>
    public const int MGGMGMNKDJKFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PBAOMKBBBFC> _repeated_mGGMGMNKDJK_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.PBAOMKBBBFC.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PBAOMKBBBFC> mGGMGMNKDJK_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PBAOMKBBBFC>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PBAOMKBBBFC> MGGMGMNKDJK {
      get { return mGGMGMNKDJK_; }
    }

    /// <summary>Field number for the "challenge_group_list" field.</summary>
    public const int ChallengeGroupListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChallengeGroup> _repeated_challengeGroupList_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.ChallengeGroup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeGroup> challengeGroupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChallengeGroup> ChallengeGroupList {
      get { return challengeGroupList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "challenge_list" field.</summary>
    public const int ChallengeListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Challenge> _repeated_challengeList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.Challenge.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Challenge> challengeList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Challenge>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Challenge> ChallengeList {
      get { return challengeList_; }
    }

    /// <summary>Field number for the "NKHGFIOAGPK" field.</summary>
    public const int NKHGFIOAGPKFieldNumber = 8;
    private uint nKHGFIOAGPK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NKHGFIOAGPK {
      get { return nKHGFIOAGPK_; }
      set {
        nKHGFIOAGPK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetChallengeScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetChallengeScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!mGGMGMNKDJK_.Equals(other.mGGMGMNKDJK_)) return false;
      if(!challengeGroupList_.Equals(other.challengeGroupList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!challengeList_.Equals(other.challengeList_)) return false;
      if (NKHGFIOAGPK != other.NKHGFIOAGPK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= mGGMGMNKDJK_.GetHashCode();
      hash ^= challengeGroupList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= challengeList_.GetHashCode();
      if (NKHGFIOAGPK != 0) hash ^= NKHGFIOAGPK.GetHashCode();
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
      challengeGroupList_.WriteTo(output, _repeated_challengeGroupList_codec);
      if (NKHGFIOAGPK != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NKHGFIOAGPK);
      }
      challengeList_.WriteTo(output, _repeated_challengeList_codec);
      mGGMGMNKDJK_.WriteTo(output, _repeated_mGGMGMNKDJK_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      challengeGroupList_.WriteTo(ref output, _repeated_challengeGroupList_codec);
      if (NKHGFIOAGPK != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NKHGFIOAGPK);
      }
      challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
      mGGMGMNKDJK_.WriteTo(ref output, _repeated_mGGMGMNKDJK_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      size += mGGMGMNKDJK_.CalculateSize(_repeated_mGGMGMNKDJK_codec);
      size += challengeGroupList_.CalculateSize(_repeated_challengeGroupList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += challengeList_.CalculateSize(_repeated_challengeList_codec);
      if (NKHGFIOAGPK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NKHGFIOAGPK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetChallengeScRsp other) {
      if (other == null) {
        return;
      }
      mGGMGMNKDJK_.Add(other.mGGMGMNKDJK_);
      challengeGroupList_.Add(other.challengeGroupList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      challengeList_.Add(other.challengeList_);
      if (other.NKHGFIOAGPK != 0) {
        NKHGFIOAGPK = other.NKHGFIOAGPK;
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
          case 18: {
            challengeGroupList_.AddEntriesFrom(input, _repeated_challengeGroupList_codec);
            break;
          }
          case 64: {
            NKHGFIOAGPK = input.ReadUInt32();
            break;
          }
          case 82: {
            challengeList_.AddEntriesFrom(input, _repeated_challengeList_codec);
            break;
          }
          case 90: {
            mGGMGMNKDJK_.AddEntriesFrom(input, _repeated_mGGMGMNKDJK_codec);
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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
          case 18: {
            challengeGroupList_.AddEntriesFrom(ref input, _repeated_challengeGroupList_codec);
            break;
          }
          case 64: {
            NKHGFIOAGPK = input.ReadUInt32();
            break;
          }
          case 82: {
            challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
            break;
          }
          case 90: {
            mGGMGMNKDJK_.AddEntriesFrom(ref input, _repeated_mGGMGMNKDJK_codec);
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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
