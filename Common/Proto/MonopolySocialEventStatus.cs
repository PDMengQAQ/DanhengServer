// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolySocialEventStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolySocialEventStatus.proto</summary>
  public static partial class MonopolySocialEventStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolySocialEventStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolySocialEventStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Nb25vcG9seVNvY2lhbEV2ZW50U3RhdHVzLnByb3RvKnoKGU1vbm9wb2x5",
            "U29jaWFsRXZlbnRTdGF0dXMSJQohTU9OT1BPTFlfU09DSUFMX0VWRU5UX1NU",
            "QVRVU19OT05FEAASNgoyTU9OT1BPTFlfU09DSUFMX0VWRU5UX1NUQVRVU19X",
            "QUlUSU5HX1NFTEVDVF9GUklFTkQQAUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.MonopolySocialEventStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MonopolySocialEventStatus {
    [pbr::OriginalName("MONOPOLY_SOCIAL_EVENT_STATUS_NONE")] None = 0,
    [pbr::OriginalName("MONOPOLY_SOCIAL_EVENT_STATUS_WAITING_SELECT_FRIEND")] WaitingSelectFriend = 1,
  }

  #endregion

}

#endregion Designer generated code