// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerDetailInfo.proto</summary>
  public static partial class PlayerDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQbGF5ZXJEZXRhaWxJbmZvLnByb3RvGhJQbGF0Zm9ybVR5cGUucHJvdG8a",
            "HURpc3BsYXlBdmF0YXJEZXRhaWxJbmZvLnByb3RvGhdEaXNwbGF5UmVjb3Jk",
            "SW5mby5wcm90byKfAwoQUGxheWVyRGV0YWlsSW5mbxITCgtIT0JCREVGTEhD",
            "RxgJIAEoDRINCgVsZXZlbBgCIAEoDRITCgtCTkdHSEhFRENDRxgDIAEoCRIR",
            "CgloZWFkX2ljb24YByABKA0SEwoLSURCT0lNSkZPUEEYDiABKAgSEwoLRkpJ",
            "TFBPSlBIQk4YCyABKAkSEwoLd29ybGRfbGV2ZWwYCCABKA0SHwoIcGxhdGZv",
            "cm0YASABKA4yDS5QbGF0Zm9ybVR5cGUSCwoDdWlkGAwgASgNEhEKCXNpZ25h",
            "dHVyZRgFIAEoCRItCgtGRE9PRUNDRUhISBgPIAMoCzIYLkRpc3BsYXlBdmF0",
            "YXJEZXRhaWxJbmZvEicKC3JlY29yZF9pbmZvGAYgASgLMhIuRGlzcGxheVJl",
            "Y29yZEluZm8SEQoJaXNfYmFubmVkGA0gASgIEhAKCG5pY2tuYW1lGAogASgJ",
            "Ei0KC0RKUEFLREZOR0pOGHggAygLMhguRGlzcGxheUF2YXRhckRldGFpbElu",
            "Zm8SEwoLSk5GT1BKRU5ESlAYBCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PlatformTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.DisplayRecordInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerDetailInfo), global::EggLink.DanhengServer.Proto.PlayerDetailInfo.Parser, new[]{ "HOBBDEFLHCG", "Level", "BNGGHHEDCCG", "HeadIcon", "IDBOIMJFOPA", "FJILPOJPHBN", "WorldLevel", "Platform", "Uid", "Signature", "FDOOECCEHHH", "RecordInfo", "IsBanned", "Nickname", "DJPAKDFNGJN", "JNFOPJENDJP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerDetailInfo : pb::IMessage<PlayerDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerDetailInfo> _parser = new pb::MessageParser<PlayerDetailInfo>(() => new PlayerDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerDetailInfo(PlayerDetailInfo other) : this() {
      hOBBDEFLHCG_ = other.hOBBDEFLHCG_;
      level_ = other.level_;
      bNGGHHEDCCG_ = other.bNGGHHEDCCG_;
      headIcon_ = other.headIcon_;
      iDBOIMJFOPA_ = other.iDBOIMJFOPA_;
      fJILPOJPHBN_ = other.fJILPOJPHBN_;
      worldLevel_ = other.worldLevel_;
      platform_ = other.platform_;
      uid_ = other.uid_;
      signature_ = other.signature_;
      fDOOECCEHHH_ = other.fDOOECCEHHH_.Clone();
      recordInfo_ = other.recordInfo_ != null ? other.recordInfo_.Clone() : null;
      isBanned_ = other.isBanned_;
      nickname_ = other.nickname_;
      dJPAKDFNGJN_ = other.dJPAKDFNGJN_.Clone();
      jNFOPJENDJP_ = other.jNFOPJENDJP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerDetailInfo Clone() {
      return new PlayerDetailInfo(this);
    }

    /// <summary>Field number for the "HOBBDEFLHCG" field.</summary>
    public const int HOBBDEFLHCGFieldNumber = 9;
    private uint hOBBDEFLHCG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HOBBDEFLHCG {
      get { return hOBBDEFLHCG_; }
      set {
        hOBBDEFLHCG_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 2;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "BNGGHHEDCCG" field.</summary>
    public const int BNGGHHEDCCGFieldNumber = 3;
    private string bNGGHHEDCCG_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BNGGHHEDCCG {
      get { return bNGGHHEDCCG_; }
      set {
        bNGGHHEDCCG_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "head_icon" field.</summary>
    public const int HeadIconFieldNumber = 7;
    private uint headIcon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HeadIcon {
      get { return headIcon_; }
      set {
        headIcon_ = value;
      }
    }

    /// <summary>Field number for the "IDBOIMJFOPA" field.</summary>
    public const int IDBOIMJFOPAFieldNumber = 14;
    private bool iDBOIMJFOPA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IDBOIMJFOPA {
      get { return iDBOIMJFOPA_; }
      set {
        iDBOIMJFOPA_ = value;
      }
    }

    /// <summary>Field number for the "FJILPOJPHBN" field.</summary>
    public const int FJILPOJPHBNFieldNumber = 11;
    private string fJILPOJPHBN_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FJILPOJPHBN {
      get { return fJILPOJPHBN_; }
      set {
        fJILPOJPHBN_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 8;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.PlatformType platform_ = global::EggLink.DanhengServer.Proto.PlatformType.Editor;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PlatformType Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 12;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 5;
    private string signature_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "FDOOECCEHHH" field.</summary>
    public const int FDOOECCEHHHFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> _repeated_fDOOECCEHHH_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> fDOOECCEHHH_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> FDOOECCEHHH {
      get { return fDOOECCEHHH_; }
    }

    /// <summary>Field number for the "record_info" field.</summary>
    public const int RecordInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.DisplayRecordInfo recordInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DisplayRecordInfo RecordInfo {
      get { return recordInfo_; }
      set {
        recordInfo_ = value;
      }
    }

    /// <summary>Field number for the "is_banned" field.</summary>
    public const int IsBannedFieldNumber = 13;
    private bool isBanned_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsBanned {
      get { return isBanned_; }
      set {
        isBanned_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 10;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DJPAKDFNGJN" field.</summary>
    public const int DJPAKDFNGJNFieldNumber = 120;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> _repeated_dJPAKDFNGJN_codec
        = pb::FieldCodec.ForMessage(962, global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> dJPAKDFNGJN_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DisplayAvatarDetailInfo> DJPAKDFNGJN {
      get { return dJPAKDFNGJN_; }
    }

    /// <summary>Field number for the "JNFOPJENDJP" field.</summary>
    public const int JNFOPJENDJPFieldNumber = 4;
    private uint jNFOPJENDJP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JNFOPJENDJP {
      get { return jNFOPJENDJP_; }
      set {
        jNFOPJENDJP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HOBBDEFLHCG != other.HOBBDEFLHCG) return false;
      if (Level != other.Level) return false;
      if (BNGGHHEDCCG != other.BNGGHHEDCCG) return false;
      if (HeadIcon != other.HeadIcon) return false;
      if (IDBOIMJFOPA != other.IDBOIMJFOPA) return false;
      if (FJILPOJPHBN != other.FJILPOJPHBN) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if (Platform != other.Platform) return false;
      if (Uid != other.Uid) return false;
      if (Signature != other.Signature) return false;
      if(!fDOOECCEHHH_.Equals(other.fDOOECCEHHH_)) return false;
      if (!object.Equals(RecordInfo, other.RecordInfo)) return false;
      if (IsBanned != other.IsBanned) return false;
      if (Nickname != other.Nickname) return false;
      if(!dJPAKDFNGJN_.Equals(other.dJPAKDFNGJN_)) return false;
      if (JNFOPJENDJP != other.JNFOPJENDJP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HOBBDEFLHCG != 0) hash ^= HOBBDEFLHCG.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (BNGGHHEDCCG.Length != 0) hash ^= BNGGHHEDCCG.GetHashCode();
      if (HeadIcon != 0) hash ^= HeadIcon.GetHashCode();
      if (IDBOIMJFOPA != false) hash ^= IDBOIMJFOPA.GetHashCode();
      if (FJILPOJPHBN.Length != 0) hash ^= FJILPOJPHBN.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) hash ^= Platform.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      hash ^= fDOOECCEHHH_.GetHashCode();
      if (recordInfo_ != null) hash ^= RecordInfo.GetHashCode();
      if (IsBanned != false) hash ^= IsBanned.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      hash ^= dJPAKDFNGJN_.GetHashCode();
      if (JNFOPJENDJP != 0) hash ^= JNFOPJENDJP.GetHashCode();
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
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Platform);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (BNGGHHEDCCG.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(BNGGHHEDCCG);
      }
      if (JNFOPJENDJP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(JNFOPJENDJP);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Signature);
      }
      if (recordInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RecordInfo);
      }
      if (HeadIcon != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HeadIcon);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(WorldLevel);
      }
      if (HOBBDEFLHCG != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(HOBBDEFLHCG);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Nickname);
      }
      if (FJILPOJPHBN.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(FJILPOJPHBN);
      }
      if (Uid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Uid);
      }
      if (IsBanned != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsBanned);
      }
      if (IDBOIMJFOPA != false) {
        output.WriteRawTag(112);
        output.WriteBool(IDBOIMJFOPA);
      }
      fDOOECCEHHH_.WriteTo(output, _repeated_fDOOECCEHHH_codec);
      dJPAKDFNGJN_.WriteTo(output, _repeated_dJPAKDFNGJN_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Platform);
      }
      if (Level != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Level);
      }
      if (BNGGHHEDCCG.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(BNGGHHEDCCG);
      }
      if (JNFOPJENDJP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(JNFOPJENDJP);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Signature);
      }
      if (recordInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RecordInfo);
      }
      if (HeadIcon != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HeadIcon);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(WorldLevel);
      }
      if (HOBBDEFLHCG != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(HOBBDEFLHCG);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Nickname);
      }
      if (FJILPOJPHBN.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(FJILPOJPHBN);
      }
      if (Uid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Uid);
      }
      if (IsBanned != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsBanned);
      }
      if (IDBOIMJFOPA != false) {
        output.WriteRawTag(112);
        output.WriteBool(IDBOIMJFOPA);
      }
      fDOOECCEHHH_.WriteTo(ref output, _repeated_fDOOECCEHHH_codec);
      dJPAKDFNGJN_.WriteTo(ref output, _repeated_dJPAKDFNGJN_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HOBBDEFLHCG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HOBBDEFLHCG);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (BNGGHHEDCCG.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BNGGHHEDCCG);
      }
      if (HeadIcon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HeadIcon);
      }
      if (IDBOIMJFOPA != false) {
        size += 1 + 1;
      }
      if (FJILPOJPHBN.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FJILPOJPHBN);
      }
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
      }
      size += fDOOECCEHHH_.CalculateSize(_repeated_fDOOECCEHHH_codec);
      if (recordInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RecordInfo);
      }
      if (IsBanned != false) {
        size += 1 + 1;
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      size += dJPAKDFNGJN_.CalculateSize(_repeated_dJPAKDFNGJN_codec);
      if (JNFOPJENDJP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JNFOPJENDJP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.HOBBDEFLHCG != 0) {
        HOBBDEFLHCG = other.HOBBDEFLHCG;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.BNGGHHEDCCG.Length != 0) {
        BNGGHHEDCCG = other.BNGGHHEDCCG;
      }
      if (other.HeadIcon != 0) {
        HeadIcon = other.HeadIcon;
      }
      if (other.IDBOIMJFOPA != false) {
        IDBOIMJFOPA = other.IDBOIMJFOPA;
      }
      if (other.FJILPOJPHBN.Length != 0) {
        FJILPOJPHBN = other.FJILPOJPHBN;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.Platform != global::EggLink.DanhengServer.Proto.PlatformType.Editor) {
        Platform = other.Platform;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      fDOOECCEHHH_.Add(other.fDOOECCEHHH_);
      if (other.recordInfo_ != null) {
        if (recordInfo_ == null) {
          RecordInfo = new global::EggLink.DanhengServer.Proto.DisplayRecordInfo();
        }
        RecordInfo.MergeFrom(other.RecordInfo);
      }
      if (other.IsBanned != false) {
        IsBanned = other.IsBanned;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      dJPAKDFNGJN_.Add(other.dJPAKDFNGJN_);
      if (other.JNFOPJENDJP != 0) {
        JNFOPJENDJP = other.JNFOPJENDJP;
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
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 26: {
            BNGGHHEDCCG = input.ReadString();
            break;
          }
          case 32: {
            JNFOPJENDJP = input.ReadUInt32();
            break;
          }
          case 42: {
            Signature = input.ReadString();
            break;
          }
          case 50: {
            if (recordInfo_ == null) {
              RecordInfo = new global::EggLink.DanhengServer.Proto.DisplayRecordInfo();
            }
            input.ReadMessage(RecordInfo);
            break;
          }
          case 56: {
            HeadIcon = input.ReadUInt32();
            break;
          }
          case 64: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 72: {
            HOBBDEFLHCG = input.ReadUInt32();
            break;
          }
          case 82: {
            Nickname = input.ReadString();
            break;
          }
          case 90: {
            FJILPOJPHBN = input.ReadString();
            break;
          }
          case 96: {
            Uid = input.ReadUInt32();
            break;
          }
          case 104: {
            IsBanned = input.ReadBool();
            break;
          }
          case 112: {
            IDBOIMJFOPA = input.ReadBool();
            break;
          }
          case 122: {
            fDOOECCEHHH_.AddEntriesFrom(input, _repeated_fDOOECCEHHH_codec);
            break;
          }
          case 962: {
            dJPAKDFNGJN_.AddEntriesFrom(input, _repeated_dJPAKDFNGJN_codec);
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
            Platform = (global::EggLink.DanhengServer.Proto.PlatformType) input.ReadEnum();
            break;
          }
          case 16: {
            Level = input.ReadUInt32();
            break;
          }
          case 26: {
            BNGGHHEDCCG = input.ReadString();
            break;
          }
          case 32: {
            JNFOPJENDJP = input.ReadUInt32();
            break;
          }
          case 42: {
            Signature = input.ReadString();
            break;
          }
          case 50: {
            if (recordInfo_ == null) {
              RecordInfo = new global::EggLink.DanhengServer.Proto.DisplayRecordInfo();
            }
            input.ReadMessage(RecordInfo);
            break;
          }
          case 56: {
            HeadIcon = input.ReadUInt32();
            break;
          }
          case 64: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 72: {
            HOBBDEFLHCG = input.ReadUInt32();
            break;
          }
          case 82: {
            Nickname = input.ReadString();
            break;
          }
          case 90: {
            FJILPOJPHBN = input.ReadString();
            break;
          }
          case 96: {
            Uid = input.ReadUInt32();
            break;
          }
          case 104: {
            IsBanned = input.ReadBool();
            break;
          }
          case 112: {
            IDBOIMJFOPA = input.ReadBool();
            break;
          }
          case 122: {
            fDOOECCEHHH_.AddEntriesFrom(ref input, _repeated_fDOOECCEHHH_codec);
            break;
          }
          case 962: {
            dJPAKDFNGJN_.AddEntriesFrom(ref input, _repeated_dJPAKDFNGJN_codec);
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
