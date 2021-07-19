// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Ydb/PersQueue/ErrorCode/persqueue_error_codes_v1.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ydb.PersQueue.ErrorCode {

  /// <summary>Holder for reflection information generated from Ydb/PersQueue/ErrorCode/persqueue_error_codes_v1.proto</summary>
  public static partial class PersqueueErrorCodesV1Reflection {

    #region Descriptor
    /// <summary>File descriptor for Ydb/PersQueue/ErrorCode/persqueue_error_codes_v1.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PersqueueErrorCodesV1Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZZZGIvUGVyc1F1ZXVlL0Vycm9yQ29kZS9wZXJzcXVldWVfZXJyb3JfY29k",
            "ZXNfdjEucHJvdG8SF1lkYi5QZXJzUXVldWUuRXJyb3JDb2RlKoYFCglFcnJv",
            "ckNvZGUSBgoCT0sQABISCgxJTklUSUFMSVpJTkcQocIeEg4KCE9WRVJMT0FE",
            "EKLCHhIRCgtCQURfUkVRVUVTVBCjwh4SEgoMV1JPTkdfQ09PS0lFEKTCHhIW",
            "ChBTT1VSQ0VJRF9ERUxFVEVEELjCHhIjCh1XUklURV9FUlJPUl9QQVJUSVRJ",
            "T05fSVNfRlVMTBClwh4SHgoYV1JJVEVfRVJST1JfRElTS19JU19GVUxMEK/C",
            "HhIcChZXUklURV9FUlJPUl9CQURfT0ZGU0VUELPCHhIjCh1DUkVBVEVfU0VT",
            "U0lPTl9BTFJFQURZX0xPQ0tFRBCmwh4SHwoZREVMRVRFX1NFU1NJT05fTk9f",
            "U0VTU0lPThCnwh4SHAoWUkVBRF9FUlJPUl9JTl9QUk9HUkVTUxCowh4SGwoV",
            "UkVBRF9FUlJPUl9OT19TRVNTSU9OEKnCHhIhChtSRUFEX0VSUk9SX1RPT19T",
            "TUFMTF9PRkZTRVQQq8IeEh8KGVJFQURfRVJST1JfVE9PX0JJR19PRkZTRVQQ",
            "rMIeEicKIVNFVF9PRkZTRVRfRVJST1JfQ09NTUlUX1RPX0ZVVFVSRRCtwh4S",
            "FwoRVEFCTEVUX0lTX0RST1BQRUQQrsIeEhMKDVJFQURfTk9UX0RPTkUQsMIe",
            "EhMKDVVOS05PV05fVE9QSUMQscIeEhMKDUFDQ0VTU19ERU5JRUQQssIeEhYK",
            "EENMVVNURVJfRElTQUJMRUQQtMIeEhwKFldST05HX1BBUlRJVElPTl9OVU1C",
            "RVIQtcIeEiIKHFBSRUZFUlJFRF9DTFVTVEVSX01JU01BVENIRUQQtsIeEgsK",
            "BUVSUk9SEITDHkIkCiJjb20ueWFuZGV4LnlkYi5wZXJzcXVldWUuZXJyb3Jj",
            "b2RlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Ydb.PersQueue.ErrorCode.ErrorCode), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///500000..500999
  /// </summary>
  public enum ErrorCode {
    [pbr::OriginalName("OK")] Ok = 0,
    [pbr::OriginalName("INITIALIZING")] Initializing = 500001,
    [pbr::OriginalName("OVERLOAD")] Overload = 500002,
    [pbr::OriginalName("BAD_REQUEST")] BadRequest = 500003,
    [pbr::OriginalName("WRONG_COOKIE")] WrongCookie = 500004,
    [pbr::OriginalName("SOURCEID_DELETED")] SourceidDeleted = 500024,
    [pbr::OriginalName("WRITE_ERROR_PARTITION_IS_FULL")] WriteErrorPartitionIsFull = 500005,
    [pbr::OriginalName("WRITE_ERROR_DISK_IS_FULL")] WriteErrorDiskIsFull = 500015,
    [pbr::OriginalName("WRITE_ERROR_BAD_OFFSET")] WriteErrorBadOffset = 500019,
    [pbr::OriginalName("CREATE_SESSION_ALREADY_LOCKED")] CreateSessionAlreadyLocked = 500006,
    [pbr::OriginalName("DELETE_SESSION_NO_SESSION")] DeleteSessionNoSession = 500007,
    [pbr::OriginalName("READ_ERROR_IN_PROGRESS")] ReadErrorInProgress = 500008,
    [pbr::OriginalName("READ_ERROR_NO_SESSION")] ReadErrorNoSession = 500009,
    [pbr::OriginalName("READ_ERROR_TOO_SMALL_OFFSET")] ReadErrorTooSmallOffset = 500011,
    [pbr::OriginalName("READ_ERROR_TOO_BIG_OFFSET")] ReadErrorTooBigOffset = 500012,
    [pbr::OriginalName("SET_OFFSET_ERROR_COMMIT_TO_FUTURE")] SetOffsetErrorCommitToFuture = 500013,
    [pbr::OriginalName("TABLET_IS_DROPPED")] TabletIsDropped = 500014,
    [pbr::OriginalName("READ_NOT_DONE")] ReadNotDone = 500016,
    [pbr::OriginalName("UNKNOWN_TOPIC")] UnknownTopic = 500017,
    [pbr::OriginalName("ACCESS_DENIED")] AccessDenied = 500018,
    [pbr::OriginalName("CLUSTER_DISABLED")] ClusterDisabled = 500020,
    [pbr::OriginalName("WRONG_PARTITION_NUMBER")] WrongPartitionNumber = 500021,
    [pbr::OriginalName("PREFERRED_CLUSTER_MISMATCHED")] PreferredClusterMismatched = 500022,
    [pbr::OriginalName("ERROR")] Error = 500100,
  }

  #endregion

}

#endregion Designer generated code
