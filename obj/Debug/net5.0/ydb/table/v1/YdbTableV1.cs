// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Ydb/Table/V1/ydb_table_v1.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ydb.Table.V1 {

  /// <summary>Holder for reflection information generated from Ydb/Table/V1/ydb_table_v1.proto</summary>
  public static partial class YdbTableV1Reflection {

    #region Descriptor
    /// <summary>File descriptor for Ydb/Table/V1/ydb_table_v1.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static YdbTableV1Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9ZZGIvVGFibGUvVjEveWRiX3RhYmxlX3YxLnByb3RvEgxZZGIuVGFibGUu",
            "VjEaGVlkYi9UYWJsZS95ZGJfdGFibGUucHJvdG8y0w0KDFRhYmxlU2Vydmlj",
            "ZRJSCg1DcmVhdGVTZXNzaW9uEh8uWWRiLlRhYmxlLkNyZWF0ZVNlc3Npb25S",
            "ZXF1ZXN0GiAuWWRiLlRhYmxlLkNyZWF0ZVNlc3Npb25SZXNwb25zZRJSCg1E",
            "ZWxldGVTZXNzaW9uEh8uWWRiLlRhYmxlLkRlbGV0ZVNlc3Npb25SZXF1ZXN0",
            "GiAuWWRiLlRhYmxlLkRlbGV0ZVNlc3Npb25SZXNwb25zZRJGCglLZWVwQWxp",
            "dmUSGy5ZZGIuVGFibGUuS2VlcEFsaXZlUmVxdWVzdBocLllkYi5UYWJsZS5L",
            "ZWVwQWxpdmVSZXNwb25zZRJMCgtDcmVhdGVUYWJsZRIdLllkYi5UYWJsZS5D",
            "cmVhdGVUYWJsZVJlcXVlc3QaHi5ZZGIuVGFibGUuQ3JlYXRlVGFibGVSZXNw",
            "b25zZRJGCglEcm9wVGFibGUSGy5ZZGIuVGFibGUuRHJvcFRhYmxlUmVxdWVz",
            "dBocLllkYi5UYWJsZS5Ecm9wVGFibGVSZXNwb25zZRJJCgpBbHRlclRhYmxl",
            "EhwuWWRiLlRhYmxlLkFsdGVyVGFibGVSZXF1ZXN0Gh0uWWRiLlRhYmxlLkFs",
            "dGVyVGFibGVSZXNwb25zZRJGCglDb3B5VGFibGUSGy5ZZGIuVGFibGUuQ29w",
            "eVRhYmxlUmVxdWVzdBocLllkYi5UYWJsZS5Db3B5VGFibGVSZXNwb25zZRJJ",
            "CgpDb3B5VGFibGVzEhwuWWRiLlRhYmxlLkNvcHlUYWJsZXNSZXF1ZXN0Gh0u",
            "WWRiLlRhYmxlLkNvcHlUYWJsZXNSZXNwb25zZRJSCg1EZXNjcmliZVRhYmxl",
            "Eh8uWWRiLlRhYmxlLkRlc2NyaWJlVGFibGVSZXF1ZXN0GiAuWWRiLlRhYmxl",
            "LkRlc2NyaWJlVGFibGVSZXNwb25zZRJbChBFeHBsYWluRGF0YVF1ZXJ5EiIu",
            "WWRiLlRhYmxlLkV4cGxhaW5EYXRhUXVlcnlSZXF1ZXN0GiMuWWRiLlRhYmxl",
            "LkV4cGxhaW5EYXRhUXVlcnlSZXNwb25zZRJbChBQcmVwYXJlRGF0YVF1ZXJ5",
            "EiIuWWRiLlRhYmxlLlByZXBhcmVEYXRhUXVlcnlSZXF1ZXN0GiMuWWRiLlRh",
            "YmxlLlByZXBhcmVEYXRhUXVlcnlSZXNwb25zZRJbChBFeGVjdXRlRGF0YVF1",
            "ZXJ5EiIuWWRiLlRhYmxlLkV4ZWN1dGVEYXRhUXVlcnlSZXF1ZXN0GiMuWWRi",
            "LlRhYmxlLkV4ZWN1dGVEYXRhUXVlcnlSZXNwb25zZRJhChJFeGVjdXRlU2No",
            "ZW1lUXVlcnkSJC5ZZGIuVGFibGUuRXhlY3V0ZVNjaGVtZVF1ZXJ5UmVxdWVz",
            "dBolLllkYi5UYWJsZS5FeGVjdXRlU2NoZW1lUXVlcnlSZXNwb25zZRJbChBC",
            "ZWdpblRyYW5zYWN0aW9uEiIuWWRiLlRhYmxlLkJlZ2luVHJhbnNhY3Rpb25S",
            "ZXF1ZXN0GiMuWWRiLlRhYmxlLkJlZ2luVHJhbnNhY3Rpb25SZXNwb25zZRJe",
            "ChFDb21taXRUcmFuc2FjdGlvbhIjLllkYi5UYWJsZS5Db21taXRUcmFuc2Fj",
            "dGlvblJlcXVlc3QaJC5ZZGIuVGFibGUuQ29tbWl0VHJhbnNhY3Rpb25SZXNw",
            "b25zZRJkChNSb2xsYmFja1RyYW5zYWN0aW9uEiUuWWRiLlRhYmxlLlJvbGxi",
            "YWNrVHJhbnNhY3Rpb25SZXF1ZXN0GiYuWWRiLlRhYmxlLlJvbGxiYWNrVHJh",
            "bnNhY3Rpb25SZXNwb25zZRJnChREZXNjcmliZVRhYmxlT3B0aW9ucxImLllk",
            "Yi5UYWJsZS5EZXNjcmliZVRhYmxlT3B0aW9uc1JlcXVlc3QaJy5ZZGIuVGFi",
            "bGUuRGVzY3JpYmVUYWJsZU9wdGlvbnNSZXNwb25zZRJOCg9TdHJlYW1SZWFk",
            "VGFibGUSGy5ZZGIuVGFibGUuUmVhZFRhYmxlUmVxdWVzdBocLllkYi5UYWJs",
            "ZS5SZWFkVGFibGVSZXNwb25zZTABEkkKCkJ1bGtVcHNlcnQSHC5ZZGIuVGFi",
            "bGUuQnVsa1Vwc2VydFJlcXVlc3QaHS5ZZGIuVGFibGUuQnVsa1Vwc2VydFJl",
            "c3BvbnNlEmoKFlN0cmVhbUV4ZWN1dGVTY2FuUXVlcnkSIi5ZZGIuVGFibGUu",
            "RXhlY3V0ZVNjYW5RdWVyeVJlcXVlc3QaKi5ZZGIuVGFibGUuRXhlY3V0ZVNj",
            "YW5RdWVyeVBhcnRpYWxSZXNwb25zZTABQhkKF2NvbS55YW5kZXgueWRiLnRh",
            "YmxlLnYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Ydb.Table.YdbTableReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
