// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueNousTalentInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueNousTalentInfo.proto</summary>
  public static partial class RogueNousTalentInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueNousTalentInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueNousTalentInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlSb2d1ZU5vdXNUYWxlbnRJbmZvLnByb3RvGhVSb2d1ZVRhbGVudEluZm8u",
            "cHJvdG8iUQoTUm9ndWVOb3VzVGFsZW50SW5mbxIlCgtKT09HQ0hKSkVNSBgC",
            "IAEoCzIQLlJvZ3VlVGFsZW50SW5mbxITCgtPQUpNRUlLSk9GRhgMIAEoDUIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueTalentInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueNousTalentInfo), global::EggLink.DanhengServer.Proto.RogueNousTalentInfo.Parser, new[]{ "JOOGCHJJEMH", "OAJMEIKJOFF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueNousTalentInfo : pb::IMessage<RogueNousTalentInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueNousTalentInfo> _parser = new pb::MessageParser<RogueNousTalentInfo>(() => new RogueNousTalentInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueNousTalentInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueNousTalentInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueNousTalentInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueNousTalentInfo(RogueNousTalentInfo other) : this() {
      jOOGCHJJEMH_ = other.jOOGCHJJEMH_ != null ? other.jOOGCHJJEMH_.Clone() : null;
      oAJMEIKJOFF_ = other.oAJMEIKJOFF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueNousTalentInfo Clone() {
      return new RogueNousTalentInfo(this);
    }

    /// <summary>Field number for the "JOOGCHJJEMH" field.</summary>
    public const int JOOGCHJJEMHFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueTalentInfo jOOGCHJJEMH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTalentInfo JOOGCHJJEMH {
      get { return jOOGCHJJEMH_; }
      set {
        jOOGCHJJEMH_ = value;
      }
    }

    /// <summary>Field number for the "OAJMEIKJOFF" field.</summary>
    public const int OAJMEIKJOFFFieldNumber = 12;
    private uint oAJMEIKJOFF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OAJMEIKJOFF {
      get { return oAJMEIKJOFF_; }
      set {
        oAJMEIKJOFF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueNousTalentInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueNousTalentInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(JOOGCHJJEMH, other.JOOGCHJJEMH)) return false;
      if (OAJMEIKJOFF != other.OAJMEIKJOFF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (jOOGCHJJEMH_ != null) hash ^= JOOGCHJJEMH.GetHashCode();
      if (OAJMEIKJOFF != 0) hash ^= OAJMEIKJOFF.GetHashCode();
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
      if (jOOGCHJJEMH_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(JOOGCHJJEMH);
      }
      if (OAJMEIKJOFF != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(OAJMEIKJOFF);
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
      if (jOOGCHJJEMH_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(JOOGCHJJEMH);
      }
      if (OAJMEIKJOFF != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(OAJMEIKJOFF);
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
      if (jOOGCHJJEMH_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JOOGCHJJEMH);
      }
      if (OAJMEIKJOFF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OAJMEIKJOFF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueNousTalentInfo other) {
      if (other == null) {
        return;
      }
      if (other.jOOGCHJJEMH_ != null) {
        if (jOOGCHJJEMH_ == null) {
          JOOGCHJJEMH = new global::EggLink.DanhengServer.Proto.RogueTalentInfo();
        }
        JOOGCHJJEMH.MergeFrom(other.JOOGCHJJEMH);
      }
      if (other.OAJMEIKJOFF != 0) {
        OAJMEIKJOFF = other.OAJMEIKJOFF;
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
            if (jOOGCHJJEMH_ == null) {
              JOOGCHJJEMH = new global::EggLink.DanhengServer.Proto.RogueTalentInfo();
            }
            input.ReadMessage(JOOGCHJJEMH);
            break;
          }
          case 96: {
            OAJMEIKJOFF = input.ReadUInt32();
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
            if (jOOGCHJJEMH_ == null) {
              JOOGCHJJEMH = new global::EggLink.DanhengServer.Proto.RogueTalentInfo();
            }
            input.ReadMessage(JOOGCHJJEMH);
            break;
          }
          case 96: {
            OAJMEIKJOFF = input.ReadUInt32();
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