// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueAccountByStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueAccountByStatus.proto</summary>
  public static partial class ChessRogueAccountByStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueAccountByStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueAccountByStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9DaGVzc1JvZ3VlQWNjb3VudEJ5U3RhdHVzLnByb3RvKvoBChlDaGVzc1Jv",
            "Z3VlQWNjb3VudEJ5U3RhdHVzEh8KG0NIRVNTX1JPR1VFX0FDQ09VTlRfQllf",
            "Tk9ORRAAEigKJENIRVNTX1JPR1VFX0FDQ09VTlRfQllfTk9STUFMX0ZJTklT",
            "SBABEiYKIkNIRVNTX1JPR1VFX0FDQ09VTlRfQllfTk9STUFMX1FVSVQQAhIh",
            "Ch1DSEVTU19ST0dVRV9BQ0NPVU5UX0JZX0RJQUxPRxADEiEKHUNIRVNTX1JP",
            "R1VFX0FDQ09VTlRfQllfRkFJTEVEEAQSJAogQ0hFU1NfUk9HVUVfQUNDT1VO",
            "VF9CWV9DVVNUT01fT1AQBUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.ChessRogueAccountByStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ChessRogueAccountByStatus {
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_NONE")] ChessRogueAccountByNone = 0,
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_NORMAL_FINISH")] ChessRogueAccountByNormalFinish = 1,
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_NORMAL_QUIT")] ChessRogueAccountByNormalQuit = 2,
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_DIALOG")] ChessRogueAccountByDialog = 3,
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_FAILED")] ChessRogueAccountByFailed = 4,
    [pbr::OriginalName("CHESS_ROGUE_ACCOUNT_BY_CUSTOM_OP")] ChessRogueAccountByCustomOp = 5,
  }

  #endregion

}

#endregion Designer generated code