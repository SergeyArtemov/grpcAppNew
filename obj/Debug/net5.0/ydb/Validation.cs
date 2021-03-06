// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Ydb/validation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ydb {

  /// <summary>Holder for reflection information generated from Ydb/validation.proto</summary>
  public static partial class ValidationReflection {

    #region Descriptor
    /// <summary>File descriptor for Ydb/validation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValidationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRZZGIvdmFsaWRhdGlvbi5wcm90bxIDWWRiGiBnb29nbGUvcHJvdG9idWYv",
            "ZGVzY3JpcHRvci5wcm90byKbAQoFTGltaXQSIQoFcmFuZ2UYASABKAsyEC5Z",
            "ZGIuTGltaXQuUmFuZ2VIABIMCgJsdBgCIAEoDUgAEgwKAmxlGAMgASgNSAAS",
            "DAoCZXEYBCABKA1IABIMCgJnZRgFIAEoDUgAEgwKAmd0GAYgASgNSAAaIQoF",
            "UmFuZ2USCwoDbWluGAEgASgNEgsKA21heBgCIAEoDUIGCgRraW5kIjMKBk1h",
            "cEtleRIaCgZsZW5ndGgYASABKAsyCi5ZZGIuTGltaXQSDQoFdmFsdWUYAiAB",
            "KAk6MQoIcmVxdWlyZWQSHS5nb29nbGUucHJvdG9idWYuRmllbGRPcHRpb25z",
            "GOKsBSABKAg6OQoEc2l6ZRIdLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlv",
            "bnMY46wFIAEoCzIKLllkYi5MaW1pdDo7CgZsZW5ndGgSHS5nb29nbGUucHJv",
            "dG9idWYuRmllbGRPcHRpb25zGOSsBSABKAsyCi5ZZGIuTGltaXQ6PQoHbWFw",
            "X2tleRIdLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlvbnMY5awFIAEoCzIL",
            "LllkYi5NYXBLZXk6LgoFdmFsdWUSHS5nb29nbGUucHJvdG9idWYuRmllbGRP",
            "cHRpb25zGOasBSABKAlCEwoOY29tLnlhbmRleC55ZGL4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { ValidationExtensions.Required, ValidationExtensions.Size, ValidationExtensions.Length, ValidationExtensions.MapKey, ValidationExtensions.Value }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Ydb.Limit), global::Ydb.Limit.Parser, new[]{ "Range", "Lt", "Le", "Eq", "Ge", "Gt" }, new[]{ "Kind" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Ydb.Limit.Types.Range), global::Ydb.Limit.Types.Range.Parser, new[]{ "Min", "Max" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Ydb.MapKey), global::Ydb.MapKey.Parser, new[]{ "Length", "Value" }, null, null, null, null)
          }));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of Ydb/validation.proto</summary>
  public static partial class ValidationExtensions {
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Required =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(87650, pb::FieldCodec.ForBool(701200, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Ydb.Limit> Size =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Ydb.Limit>(87651, pb::FieldCodec.ForMessage(701210, global::Ydb.Limit.Parser));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Ydb.Limit> Length =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Ydb.Limit>(87652, pb::FieldCodec.ForMessage(701218, global::Ydb.Limit.Parser));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Ydb.MapKey> MapKey =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Ydb.MapKey>(87653, pb::FieldCodec.ForMessage(701226, global::Ydb.MapKey.Parser));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Value =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(87654, pb::FieldCodec.ForString(701234, ""));
  }

  #region Messages
  public sealed partial class Limit : pb::IMessage<Limit>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Limit> _parser = new pb::MessageParser<Limit>(() => new Limit());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Limit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ydb.ValidationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Limit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Limit(Limit other) : this() {
      switch (other.KindCase) {
        case KindOneofCase.Range:
          Range = other.Range.Clone();
          break;
        case KindOneofCase.Lt:
          Lt = other.Lt;
          break;
        case KindOneofCase.Le:
          Le = other.Le;
          break;
        case KindOneofCase.Eq:
          Eq = other.Eq;
          break;
        case KindOneofCase.Ge:
          Ge = other.Ge;
          break;
        case KindOneofCase.Gt:
          Gt = other.Gt;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Limit Clone() {
      return new Limit(this);
    }

    /// <summary>Field number for the "range" field.</summary>
    public const int RangeFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Ydb.Limit.Types.Range Range {
      get { return kindCase_ == KindOneofCase.Range ? (global::Ydb.Limit.Types.Range) kind_ : null; }
      set {
        kind_ = value;
        kindCase_ = value == null ? KindOneofCase.None : KindOneofCase.Range;
      }
    }

    /// <summary>Field number for the "lt" field.</summary>
    public const int LtFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Lt {
      get { return kindCase_ == KindOneofCase.Lt ? (uint) kind_ : 0; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.Lt;
      }
    }

    /// <summary>Field number for the "le" field.</summary>
    public const int LeFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Le {
      get { return kindCase_ == KindOneofCase.Le ? (uint) kind_ : 0; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.Le;
      }
    }

    /// <summary>Field number for the "eq" field.</summary>
    public const int EqFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Eq {
      get { return kindCase_ == KindOneofCase.Eq ? (uint) kind_ : 0; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.Eq;
      }
    }

    /// <summary>Field number for the "ge" field.</summary>
    public const int GeFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Ge {
      get { return kindCase_ == KindOneofCase.Ge ? (uint) kind_ : 0; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.Ge;
      }
    }

    /// <summary>Field number for the "gt" field.</summary>
    public const int GtFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Gt {
      get { return kindCase_ == KindOneofCase.Gt ? (uint) kind_ : 0; }
      set {
        kind_ = value;
        kindCase_ = KindOneofCase.Gt;
      }
    }

    private object kind_;
    /// <summary>Enum of possible cases for the "kind" oneof.</summary>
    public enum KindOneofCase {
      None = 0,
      Range = 1,
      Lt = 2,
      Le = 3,
      Eq = 4,
      Ge = 5,
      Gt = 6,
    }
    private KindOneofCase kindCase_ = KindOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KindOneofCase KindCase {
      get { return kindCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearKind() {
      kindCase_ = KindOneofCase.None;
      kind_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Limit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Limit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Range, other.Range)) return false;
      if (Lt != other.Lt) return false;
      if (Le != other.Le) return false;
      if (Eq != other.Eq) return false;
      if (Ge != other.Ge) return false;
      if (Gt != other.Gt) return false;
      if (KindCase != other.KindCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (kindCase_ == KindOneofCase.Range) hash ^= Range.GetHashCode();
      if (kindCase_ == KindOneofCase.Lt) hash ^= Lt.GetHashCode();
      if (kindCase_ == KindOneofCase.Le) hash ^= Le.GetHashCode();
      if (kindCase_ == KindOneofCase.Eq) hash ^= Eq.GetHashCode();
      if (kindCase_ == KindOneofCase.Ge) hash ^= Ge.GetHashCode();
      if (kindCase_ == KindOneofCase.Gt) hash ^= Gt.GetHashCode();
      hash ^= (int) kindCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (kindCase_ == KindOneofCase.Range) {
        output.WriteRawTag(10);
        output.WriteMessage(Range);
      }
      if (kindCase_ == KindOneofCase.Lt) {
        output.WriteRawTag(16);
        output.WriteUInt32(Lt);
      }
      if (kindCase_ == KindOneofCase.Le) {
        output.WriteRawTag(24);
        output.WriteUInt32(Le);
      }
      if (kindCase_ == KindOneofCase.Eq) {
        output.WriteRawTag(32);
        output.WriteUInt32(Eq);
      }
      if (kindCase_ == KindOneofCase.Ge) {
        output.WriteRawTag(40);
        output.WriteUInt32(Ge);
      }
      if (kindCase_ == KindOneofCase.Gt) {
        output.WriteRawTag(48);
        output.WriteUInt32(Gt);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (kindCase_ == KindOneofCase.Range) {
        output.WriteRawTag(10);
        output.WriteMessage(Range);
      }
      if (kindCase_ == KindOneofCase.Lt) {
        output.WriteRawTag(16);
        output.WriteUInt32(Lt);
      }
      if (kindCase_ == KindOneofCase.Le) {
        output.WriteRawTag(24);
        output.WriteUInt32(Le);
      }
      if (kindCase_ == KindOneofCase.Eq) {
        output.WriteRawTag(32);
        output.WriteUInt32(Eq);
      }
      if (kindCase_ == KindOneofCase.Ge) {
        output.WriteRawTag(40);
        output.WriteUInt32(Ge);
      }
      if (kindCase_ == KindOneofCase.Gt) {
        output.WriteRawTag(48);
        output.WriteUInt32(Gt);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (kindCase_ == KindOneofCase.Range) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Range);
      }
      if (kindCase_ == KindOneofCase.Lt) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Lt);
      }
      if (kindCase_ == KindOneofCase.Le) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Le);
      }
      if (kindCase_ == KindOneofCase.Eq) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Eq);
      }
      if (kindCase_ == KindOneofCase.Ge) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Ge);
      }
      if (kindCase_ == KindOneofCase.Gt) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Gt);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Limit other) {
      if (other == null) {
        return;
      }
      switch (other.KindCase) {
        case KindOneofCase.Range:
          if (Range == null) {
            Range = new global::Ydb.Limit.Types.Range();
          }
          Range.MergeFrom(other.Range);
          break;
        case KindOneofCase.Lt:
          Lt = other.Lt;
          break;
        case KindOneofCase.Le:
          Le = other.Le;
          break;
        case KindOneofCase.Eq:
          Eq = other.Eq;
          break;
        case KindOneofCase.Ge:
          Ge = other.Ge;
          break;
        case KindOneofCase.Gt:
          Gt = other.Gt;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            global::Ydb.Limit.Types.Range subBuilder = new global::Ydb.Limit.Types.Range();
            if (kindCase_ == KindOneofCase.Range) {
              subBuilder.MergeFrom(Range);
            }
            input.ReadMessage(subBuilder);
            Range = subBuilder;
            break;
          }
          case 16: {
            Lt = input.ReadUInt32();
            break;
          }
          case 24: {
            Le = input.ReadUInt32();
            break;
          }
          case 32: {
            Eq = input.ReadUInt32();
            break;
          }
          case 40: {
            Ge = input.ReadUInt32();
            break;
          }
          case 48: {
            Gt = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            global::Ydb.Limit.Types.Range subBuilder = new global::Ydb.Limit.Types.Range();
            if (kindCase_ == KindOneofCase.Range) {
              subBuilder.MergeFrom(Range);
            }
            input.ReadMessage(subBuilder);
            Range = subBuilder;
            break;
          }
          case 16: {
            Lt = input.ReadUInt32();
            break;
          }
          case 24: {
            Le = input.ReadUInt32();
            break;
          }
          case 32: {
            Eq = input.ReadUInt32();
            break;
          }
          case 40: {
            Ge = input.ReadUInt32();
            break;
          }
          case 48: {
            Gt = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Limit message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Range : pb::IMessage<Range>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Range> _parser = new pb::MessageParser<Range>(() => new Range());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Range> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Ydb.Limit.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Range() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Range(Range other) : this() {
          min_ = other.min_;
          max_ = other.max_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Range Clone() {
          return new Range(this);
        }

        /// <summary>Field number for the "min" field.</summary>
        public const int MinFieldNumber = 1;
        private uint min_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint Min {
          get { return min_; }
          set {
            min_ = value;
          }
        }

        /// <summary>Field number for the "max" field.</summary>
        public const int MaxFieldNumber = 2;
        private uint max_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint Max {
          get { return max_; }
          set {
            max_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Range);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Range other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Min != other.Min) return false;
          if (Max != other.Max) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Min != 0) hash ^= Min.GetHashCode();
          if (Max != 0) hash ^= Max.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (Min != 0) {
            output.WriteRawTag(8);
            output.WriteUInt32(Min);
          }
          if (Max != 0) {
            output.WriteRawTag(16);
            output.WriteUInt32(Max);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (Min != 0) {
            output.WriteRawTag(8);
            output.WriteUInt32(Min);
          }
          if (Max != 0) {
            output.WriteRawTag(16);
            output.WriteUInt32(Max);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Min != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Min);
          }
          if (Max != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Max);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Range other) {
          if (other == null) {
            return;
          }
          if (other.Min != 0) {
            Min = other.Min;
          }
          if (other.Max != 0) {
            Max = other.Max;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
                Min = input.ReadUInt32();
                break;
              }
              case 16: {
                Max = input.ReadUInt32();
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 8: {
                Min = input.ReadUInt32();
                break;
              }
              case 16: {
                Max = input.ReadUInt32();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  public sealed partial class MapKey : pb::IMessage<MapKey>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MapKey> _parser = new pb::MessageParser<MapKey>(() => new MapKey());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MapKey> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ydb.ValidationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapKey() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapKey(MapKey other) : this() {
      length_ = other.length_ != null ? other.length_.Clone() : null;
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MapKey Clone() {
      return new MapKey(this);
    }

    /// <summary>Field number for the "length" field.</summary>
    public const int LengthFieldNumber = 1;
    private global::Ydb.Limit length_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Ydb.Limit Length {
      get { return length_; }
      set {
        length_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private string value_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MapKey);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MapKey other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Length, other.Length)) return false;
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (length_ != null) hash ^= Length.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (length_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Length);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (length_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Length);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (length_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Length);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MapKey other) {
      if (other == null) {
        return;
      }
      if (other.length_ != null) {
        if (length_ == null) {
          Length = new global::Ydb.Limit();
        }
        Length.MergeFrom(other.Length);
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            if (length_ == null) {
              Length = new global::Ydb.Limit();
            }
            input.ReadMessage(Length);
            break;
          }
          case 18: {
            Value = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (length_ == null) {
              Length = new global::Ydb.Limit();
            }
            input.ReadMessage(Length);
            break;
          }
          case 18: {
            Value = input.ReadString();
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
