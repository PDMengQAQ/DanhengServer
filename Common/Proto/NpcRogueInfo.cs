// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NpcRogueInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NpcRogueInfo.proto</summary>
  public static partial class NpcRogueInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for NpcRogueInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NpcRogueInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJOcGNSb2d1ZUluZm8ucHJvdG8ijQIKDE5wY1JvZ3VlSW5mbxIzCgtIQ0dP",
            "RUhMUENNRBgBIAMoCzIeLk5wY1JvZ3VlSW5mby5IQ0dPRUhMUENNREVudHJ5",
            "EhMKC0FHQkZESUlLUEtGGA0gASgIEhcKD2ZpbmlzaF9kaWFsb2d1ZRgFIAEo",
            "CBIUCgxyb2d1ZV9ucGNfaWQYBiABKA0SEQoJdW5pcXVlX2lkGA8gASgNEhMK",
            "C0lOSlBGQUxNREhKGAwgASgNEhMKC0dFTk1JRk9DTUpBGBUgASgNEhMKC01O",
            "SU5EQk1BSktMGAcgASgIGjIKEEhDR09FSExQQ01ERW50cnkSCwoDa2V5GAEg",
            "ASgNEg0KBXZhbHVlGAIgASgNOgI4AUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NpcRogueInfo), global::EggLink.DanhengServer.Proto.NpcRogueInfo.Parser, new[]{ "HCGOEHLPCMD", "AGBFDIIKPKF", "FinishDialogue", "RogueNpcId", "UniqueId", "INJPFALMDHJ", "GENMIFOCMJA", "MNINDBMAJKL" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NpcRogueInfo : pb::IMessage<NpcRogueInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NpcRogueInfo> _parser = new pb::MessageParser<NpcRogueInfo>(() => new NpcRogueInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NpcRogueInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NpcRogueInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NpcRogueInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NpcRogueInfo(NpcRogueInfo other) : this() {
      hCGOEHLPCMD_ = other.hCGOEHLPCMD_.Clone();
      aGBFDIIKPKF_ = other.aGBFDIIKPKF_;
      finishDialogue_ = other.finishDialogue_;
      rogueNpcId_ = other.rogueNpcId_;
      uniqueId_ = other.uniqueId_;
      iNJPFALMDHJ_ = other.iNJPFALMDHJ_;
      gENMIFOCMJA_ = other.gENMIFOCMJA_;
      mNINDBMAJKL_ = other.mNINDBMAJKL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NpcRogueInfo Clone() {
      return new NpcRogueInfo(this);
    }

    /// <summary>Field number for the "HCGOEHLPCMD" field.</summary>
    public const int HCGOEHLPCMDFieldNumber = 1;
    private static readonly pbc::MapField<uint, uint>.Codec _map_hCGOEHLPCMD_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 10);
    private readonly pbc::MapField<uint, uint> hCGOEHLPCMD_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> HCGOEHLPCMD {
      get { return hCGOEHLPCMD_; }
    }

    /// <summary>Field number for the "AGBFDIIKPKF" field.</summary>
    public const int AGBFDIIKPKFFieldNumber = 13;
    private bool aGBFDIIKPKF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AGBFDIIKPKF {
      get { return aGBFDIIKPKF_; }
      set {
        aGBFDIIKPKF_ = value;
      }
    }

    /// <summary>Field number for the "finish_dialogue" field.</summary>
    public const int FinishDialogueFieldNumber = 5;
    private bool finishDialogue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FinishDialogue {
      get { return finishDialogue_; }
      set {
        finishDialogue_ = value;
      }
    }

    /// <summary>Field number for the "rogue_npc_id" field.</summary>
    public const int RogueNpcIdFieldNumber = 6;
    private uint rogueNpcId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RogueNpcId {
      get { return rogueNpcId_; }
      set {
        rogueNpcId_ = value;
      }
    }

    /// <summary>Field number for the "unique_id" field.</summary>
    public const int UniqueIdFieldNumber = 15;
    private uint uniqueId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UniqueId {
      get { return uniqueId_; }
      set {
        uniqueId_ = value;
      }
    }

    /// <summary>Field number for the "INJPFALMDHJ" field.</summary>
    public const int INJPFALMDHJFieldNumber = 12;
    private uint iNJPFALMDHJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint INJPFALMDHJ {
      get { return iNJPFALMDHJ_; }
      set {
        iNJPFALMDHJ_ = value;
      }
    }

    /// <summary>Field number for the "GENMIFOCMJA" field.</summary>
    public const int GENMIFOCMJAFieldNumber = 21;
    private uint gENMIFOCMJA_;
    /// <summary>
    ///repeated KELFICDMDDG CEEFGPGODAA = 9;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GENMIFOCMJA {
      get { return gENMIFOCMJA_; }
      set {
        gENMIFOCMJA_ = value;
      }
    }

    /// <summary>Field number for the "MNINDBMAJKL" field.</summary>
    public const int MNINDBMAJKLFieldNumber = 7;
    private bool mNINDBMAJKL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MNINDBMAJKL {
      get { return mNINDBMAJKL_; }
      set {
        mNINDBMAJKL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NpcRogueInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NpcRogueInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!HCGOEHLPCMD.Equals(other.HCGOEHLPCMD)) return false;
      if (AGBFDIIKPKF != other.AGBFDIIKPKF) return false;
      if (FinishDialogue != other.FinishDialogue) return false;
      if (RogueNpcId != other.RogueNpcId) return false;
      if (UniqueId != other.UniqueId) return false;
      if (INJPFALMDHJ != other.INJPFALMDHJ) return false;
      if (GENMIFOCMJA != other.GENMIFOCMJA) return false;
      if (MNINDBMAJKL != other.MNINDBMAJKL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= HCGOEHLPCMD.GetHashCode();
      if (AGBFDIIKPKF != false) hash ^= AGBFDIIKPKF.GetHashCode();
      if (FinishDialogue != false) hash ^= FinishDialogue.GetHashCode();
      if (RogueNpcId != 0) hash ^= RogueNpcId.GetHashCode();
      if (UniqueId != 0) hash ^= UniqueId.GetHashCode();
      if (INJPFALMDHJ != 0) hash ^= INJPFALMDHJ.GetHashCode();
      if (GENMIFOCMJA != 0) hash ^= GENMIFOCMJA.GetHashCode();
      if (MNINDBMAJKL != false) hash ^= MNINDBMAJKL.GetHashCode();
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
      hCGOEHLPCMD_.WriteTo(output, _map_hCGOEHLPCMD_codec);
      if (FinishDialogue != false) {
        output.WriteRawTag(40);
        output.WriteBool(FinishDialogue);
      }
      if (RogueNpcId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RogueNpcId);
      }
      if (MNINDBMAJKL != false) {
        output.WriteRawTag(56);
        output.WriteBool(MNINDBMAJKL);
      }
      if (INJPFALMDHJ != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(INJPFALMDHJ);
      }
      if (AGBFDIIKPKF != false) {
        output.WriteRawTag(104);
        output.WriteBool(AGBFDIIKPKF);
      }
      if (UniqueId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(UniqueId);
      }
      if (GENMIFOCMJA != 0) {
        output.WriteRawTag(168, 1);
        output.WriteUInt32(GENMIFOCMJA);
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
      hCGOEHLPCMD_.WriteTo(ref output, _map_hCGOEHLPCMD_codec);
      if (FinishDialogue != false) {
        output.WriteRawTag(40);
        output.WriteBool(FinishDialogue);
      }
      if (RogueNpcId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RogueNpcId);
      }
      if (MNINDBMAJKL != false) {
        output.WriteRawTag(56);
        output.WriteBool(MNINDBMAJKL);
      }
      if (INJPFALMDHJ != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(INJPFALMDHJ);
      }
      if (AGBFDIIKPKF != false) {
        output.WriteRawTag(104);
        output.WriteBool(AGBFDIIKPKF);
      }
      if (UniqueId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(UniqueId);
      }
      if (GENMIFOCMJA != 0) {
        output.WriteRawTag(168, 1);
        output.WriteUInt32(GENMIFOCMJA);
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
      size += hCGOEHLPCMD_.CalculateSize(_map_hCGOEHLPCMD_codec);
      if (AGBFDIIKPKF != false) {
        size += 1 + 1;
      }
      if (FinishDialogue != false) {
        size += 1 + 1;
      }
      if (RogueNpcId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RogueNpcId);
      }
      if (UniqueId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UniqueId);
      }
      if (INJPFALMDHJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(INJPFALMDHJ);
      }
      if (GENMIFOCMJA != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(GENMIFOCMJA);
      }
      if (MNINDBMAJKL != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NpcRogueInfo other) {
      if (other == null) {
        return;
      }
      hCGOEHLPCMD_.MergeFrom(other.hCGOEHLPCMD_);
      if (other.AGBFDIIKPKF != false) {
        AGBFDIIKPKF = other.AGBFDIIKPKF;
      }
      if (other.FinishDialogue != false) {
        FinishDialogue = other.FinishDialogue;
      }
      if (other.RogueNpcId != 0) {
        RogueNpcId = other.RogueNpcId;
      }
      if (other.UniqueId != 0) {
        UniqueId = other.UniqueId;
      }
      if (other.INJPFALMDHJ != 0) {
        INJPFALMDHJ = other.INJPFALMDHJ;
      }
      if (other.GENMIFOCMJA != 0) {
        GENMIFOCMJA = other.GENMIFOCMJA;
      }
      if (other.MNINDBMAJKL != false) {
        MNINDBMAJKL = other.MNINDBMAJKL;
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
          case 10: {
            hCGOEHLPCMD_.AddEntriesFrom(input, _map_hCGOEHLPCMD_codec);
            break;
          }
          case 40: {
            FinishDialogue = input.ReadBool();
            break;
          }
          case 48: {
            RogueNpcId = input.ReadUInt32();
            break;
          }
          case 56: {
            MNINDBMAJKL = input.ReadBool();
            break;
          }
          case 96: {
            INJPFALMDHJ = input.ReadUInt32();
            break;
          }
          case 104: {
            AGBFDIIKPKF = input.ReadBool();
            break;
          }
          case 120: {
            UniqueId = input.ReadUInt32();
            break;
          }
          case 168: {
            GENMIFOCMJA = input.ReadUInt32();
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
          case 10: {
            hCGOEHLPCMD_.AddEntriesFrom(ref input, _map_hCGOEHLPCMD_codec);
            break;
          }
          case 40: {
            FinishDialogue = input.ReadBool();
            break;
          }
          case 48: {
            RogueNpcId = input.ReadUInt32();
            break;
          }
          case 56: {
            MNINDBMAJKL = input.ReadBool();
            break;
          }
          case 96: {
            INJPFALMDHJ = input.ReadUInt32();
            break;
          }
          case 104: {
            AGBFDIIKPKF = input.ReadBool();
            break;
          }
          case 120: {
            UniqueId = input.ReadUInt32();
            break;
          }
          case 168: {
            GENMIFOCMJA = input.ReadUInt32();
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