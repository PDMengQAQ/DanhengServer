// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SubmitEmotionItemCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SubmitEmotionItemCsReq.proto</summary>
  public static partial class SubmitEmotionItemCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SubmitEmotionItemCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SubmitEmotionItemCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTdWJtaXRFbW90aW9uSXRlbUNzUmVxLnByb3RvGg5JdGVtTGlzdC5wcm90",
            "byJgChZTdWJtaXRFbW90aW9uSXRlbUNzUmVxEhMKC05JRE5HUE9MSE5FGAgg",
            "ASgNEhMKC0hMT0NLRUxGRkZKGAogASgNEhwKCWl0ZW1fbGlzdBgGIAEoCzIJ",
            "Lkl0ZW1MaXN0Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SubmitEmotionItemCsReq), global::EggLink.DanhengServer.Proto.SubmitEmotionItemCsReq.Parser, new[]{ "NIDNGPOLHNE", "HLOCKELFFFJ", "ItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SubmitEmotionItemCsReq : pb::IMessage<SubmitEmotionItemCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SubmitEmotionItemCsReq> _parser = new pb::MessageParser<SubmitEmotionItemCsReq>(() => new SubmitEmotionItemCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SubmitEmotionItemCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SubmitEmotionItemCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubmitEmotionItemCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubmitEmotionItemCsReq(SubmitEmotionItemCsReq other) : this() {
      nIDNGPOLHNE_ = other.nIDNGPOLHNE_;
      hLOCKELFFFJ_ = other.hLOCKELFFFJ_;
      itemList_ = other.itemList_ != null ? other.itemList_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SubmitEmotionItemCsReq Clone() {
      return new SubmitEmotionItemCsReq(this);
    }

    /// <summary>Field number for the "NIDNGPOLHNE" field.</summary>
    public const int NIDNGPOLHNEFieldNumber = 8;
    private uint nIDNGPOLHNE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NIDNGPOLHNE {
      get { return nIDNGPOLHNE_; }
      set {
        nIDNGPOLHNE_ = value;
      }
    }

    /// <summary>Field number for the "HLOCKELFFFJ" field.</summary>
    public const int HLOCKELFFFJFieldNumber = 10;
    private uint hLOCKELFFFJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HLOCKELFFFJ {
      get { return hLOCKELFFFJ_; }
      set {
        hLOCKELFFFJ_ = value;
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ItemList itemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList ItemList {
      get { return itemList_; }
      set {
        itemList_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SubmitEmotionItemCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SubmitEmotionItemCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NIDNGPOLHNE != other.NIDNGPOLHNE) return false;
      if (HLOCKELFFFJ != other.HLOCKELFFFJ) return false;
      if (!object.Equals(ItemList, other.ItemList)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NIDNGPOLHNE != 0) hash ^= NIDNGPOLHNE.GetHashCode();
      if (HLOCKELFFFJ != 0) hash ^= HLOCKELFFFJ.GetHashCode();
      if (itemList_ != null) hash ^= ItemList.GetHashCode();
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
      if (itemList_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ItemList);
      }
      if (NIDNGPOLHNE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NIDNGPOLHNE);
      }
      if (HLOCKELFFFJ != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HLOCKELFFFJ);
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
      if (itemList_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ItemList);
      }
      if (NIDNGPOLHNE != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NIDNGPOLHNE);
      }
      if (HLOCKELFFFJ != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HLOCKELFFFJ);
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
      if (NIDNGPOLHNE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NIDNGPOLHNE);
      }
      if (HLOCKELFFFJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HLOCKELFFFJ);
      }
      if (itemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SubmitEmotionItemCsReq other) {
      if (other == null) {
        return;
      }
      if (other.NIDNGPOLHNE != 0) {
        NIDNGPOLHNE = other.NIDNGPOLHNE;
      }
      if (other.HLOCKELFFFJ != 0) {
        HLOCKELFFFJ = other.HLOCKELFFFJ;
      }
      if (other.itemList_ != null) {
        if (itemList_ == null) {
          ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        ItemList.MergeFrom(other.ItemList);
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
          case 50: {
            if (itemList_ == null) {
              ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ItemList);
            break;
          }
          case 64: {
            NIDNGPOLHNE = input.ReadUInt32();
            break;
          }
          case 80: {
            HLOCKELFFFJ = input.ReadUInt32();
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
          case 50: {
            if (itemList_ == null) {
              ItemList = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ItemList);
            break;
          }
          case 64: {
            NIDNGPOLHNE = input.ReadUInt32();
            break;
          }
          case 80: {
            HLOCKELFFFJ = input.ReadUInt32();
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