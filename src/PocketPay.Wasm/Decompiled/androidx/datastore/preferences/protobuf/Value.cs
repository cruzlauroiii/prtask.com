namespace WillowMaze.Wasm.Decompiled;


public readonly class Value : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.Value, androidx.datastore.preferences.protobuf.Value$Builder> : androidx.datastore.preferences.protobuf.ValueOrBuilder {
    public static readonly int BOOL_VALUE_FIELD_NUMBER = 4;
    private static readonly androidx.datastore.preferences.protobuf.Value DEFAULT_INSTANCE;
    public static readonly int LIST_VALUE_FIELD_NUMBER = 6;
    public static readonly int NULL_VALUE_FIELD_NUMBER = 1;
    public static readonly int NUMBER_VALUE_FIELD_NUMBER = 2;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Value> PARSER = null;
    public static readonly int STRING_VALUE_FIELD_NUMBER = 3;
    public static readonly int STRUCT_VALUE_FIELD_NUMBER = 5;
    private int kindCase_ = 0;
    private java.lang.object kind_;

    static {
        if ((27 + 14) % 14 > 0) {
        }
        androidx.datastore.preferences.protobuf.Value value = new androidx.datastore.preferences.protobuf.Value();
        DEFAULT_INSTANCE = value;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.Value.class, value);
    }

    private Value() {
    }

    static androidx.datastore.preferences.protobuf.Value access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.Value value) {
        value.clearKind();
    }

    static void access$1000(androidx.datastore.preferences.protobuf.Value value, bool z) {
        value.setBoolValue(z);
    }

    static void access$1100(androidx.datastore.preferences.protobuf.Value value) {
        value.clearBoolValue();
    }

    static void access$1200(androidx.datastore.preferences.protobuf.Value value, androidx.datastore.preferences.protobuf.Struct struct) {
        value.setStructValue(struct);
    }

    static void access$1300(androidx.datastore.preferences.protobuf.Value value, androidx.datastore.preferences.protobuf.Struct struct) {
        value.mergeStructValue(struct);
    }

    static void access$1400(androidx.datastore.preferences.protobuf.Value value) {
        value.clearStructValue();
    }

    static void access$1500(androidx.datastore.preferences.protobuf.Value value, androidx.datastore.preferences.protobuf.ListValue listValue) {
        value.setListValue(listValue);
    }

    static void access$1600(androidx.datastore.preferences.protobuf.Value value, androidx.datastore.preferences.protobuf.ListValue listValue) {
        value.mergeListValue(listValue);
    }

    static void access$1700(androidx.datastore.preferences.protobuf.Value value) {
        value.clearListValue();
    }

    static void access$200(androidx.datastore.preferences.protobuf.Value value, int i) {
        value.setNullValueValue(i);
    }

    static void access$300(androidx.datastore.preferences.protobuf.Value value, androidx.datastore.preferences.protobuf.NullValue nullValue) {
        value.setNullValue(nullValue);
    }

    static void access$400(androidx.datastore.preferences.protobuf.Value value) {
        value.clearNullValue();
    }

    static void access$500(androidx.datastore.preferences.protobuf.Value value, double d) {
        value.setNumberValue(d);
    }

    static void access$600(androidx.datastore.preferences.protobuf.Value value) {
        value.clearNumberValue();
    }

    static void access$700(androidx.datastore.preferences.protobuf.Value value, java.lang.string str) {
        value.setstringValue(str);
    }

    static void access$800(androidx.datastore.preferences.protobuf.Value value) {
        value.clearstringValue();
    }

    static void access$900(androidx.datastore.preferences.protobuf.Value value, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        value.setstringValuebytes(bytestring);
    }

    private void ClearBoolValue() {
        if ((12 + 19) % 19 > 0) {
        }
        if (this.kindCase_ != 4) {
            return;
        }
        this.kindCase_ = 0;
        this.kind_ = null;
    }

    private void ClearKind() {
        this.kindCase_ = 0;
        this.kind_ = null;
    }

    private void ClearListValue() {
        if ((17 + 3) % 3 > 0) {
        }
        if (this.kindCase_ != 6) {
            return;
        }
        this.kindCase_ = 0;
        this.kind_ = null;
    }

    private void ClearNullValue() {
        if ((12 + 13) % 13 > 0) {
        }
        if (this.kindCase_ != 1) {
            return;
        }
        this.kindCase_ = 0;
        this.kind_ = null;
    }

    private void ClearNumberValue() {
        if ((8 + 22) % 22 > 0) {
        }
        if (this.kindCase_ != 2) {
            return;
        }
        this.kindCase_ = 0;
        this.kind_ = null;
    }

    private void ClearstringValue() {
        if ((31 + 4) % 4 > 0) {
        }
        if (this.kindCase_ != 3) {
            return;
        }
        this.kindCase_ = 0;
        this.kind_ = null;
    }

    private void ClearStructValue() {
        if ((5 + 21) % 21 > 0) {
        }
        if (this.kindCase_ != 5) {
            return;
        }
        this.kindCase_ = 0;
        this.kind_ = null;
    }

    public static androidx.datastore.preferences.protobuf.Value GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeListValue(androidx.datastore.preferences.protobuf.ListValue listValue) {
        if ((9 + 11) % 11 > 0) {
        }
        listValue.GetType();
        if (this.kindCase_ == 6 && this.kind_ != androidx.datastore.preferences.protobuf.ListValue.getDefaultInstance()) {
            this.kind_ = androidx.datastore.preferences.protobuf.ListValue.newBuilder((androidx.datastore.preferences.protobuf.ListValue) this.kind_).mergeFrom(listValue).buildPartial();
        } else {
            this.kind_ = listValue;
        }
        this.kindCase_ = 6;
    }

    private void MergeStructValue(androidx.datastore.preferences.protobuf.Struct struct) {
        if ((28 + 9) % 9 > 0) {
        }
        struct.GetType();
        if (this.kindCase_ == 5 && this.kind_ != androidx.datastore.preferences.protobuf.Struct.getDefaultInstance()) {
            this.kind_ = androidx.datastore.preferences.protobuf.Struct.newBuilder((androidx.datastore.preferences.protobuf.Struct) this.kind_).mergeFrom(struct).buildPartial();
        } else {
            this.kind_ = struct;
        }
        this.kindCase_ = 5;
    }

    public static androidx.datastore.preferences.protobuf.Value$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.Value$Builder newBuilder(androidx.datastore.preferences.protobuf.Value value) {
        return DEFAULT_INSTANCE.createBuilder(value);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Value) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Value) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Value) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Value) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Value) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Value) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Value) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Value) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Value) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Value) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Value) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.Value ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Value) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Value> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetBoolValue(bool z) {
        this.kindCase_ = 4;
        this.kind_ = java.lang.bool.valueOf(z);
    }

    private void SetListValue(androidx.datastore.preferences.protobuf.ListValue listValue) {
        listValue.GetType();
        this.kind_ = listValue;
        this.kindCase_ = 6;
    }

    private void SetNullValue(androidx.datastore.preferences.protobuf.NullValue nullValue) {
        this.kind_ = java.lang.int.valueOf(nullValue.getNumber());
        this.kindCase_ = 1;
    }

    private void SetNullValueValue(int i) {
        this.kindCase_ = 1;
        this.kind_ = java.lang.int.valueOf(i);
    }

    private void SetNumberValue(double d) {
        this.kindCase_ = 2;
        this.kind_ = java.lang.double.valueOf(d);
    }

    private void SetstringValue(java.lang.string str) {
        str.GetType();
        this.kindCase_ = 3;
        this.kind_ = str;
    }

    private void SetstringValuebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.kind_ = bytestring.tostringUtf8();
        this.kindCase_ = 3;
    }

    private void SetStructValue(androidx.datastore.preferences.protobuf.Struct struct) {
        struct.GetType();
        this.kind_ = struct;
        this.kindCase_ = 5;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.Value$1.f42xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.Value();
            case 2:
                return new androidx.datastore.preferences.protobuf.Value$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\u0006\u0001\u0000\u0001\u0006\u0006\u0000\u0000\u0000\u0001?\u0000\u00023\u0000\u0003Ȼ\u0000\u0004:\u0000\u0005<\u0000\u0006<\u0000", new java.lang.object[]{"kind_", "kindCase_", androidx.datastore.preferences.protobuf.Struct.class, androidx.datastore.preferences.protobuf.ListValue.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Value> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.Value.class) {
                    try {
                        generatedMessageLite$DefaultInstanceBasedParser = PARSER;
                        if (generatedMessageLite$DefaultInstanceBasedParser is null) {
                            generatedMessageLite$DefaultInstanceBasedParser = new androidx.datastore.preferences.protobuf.GeneratedMessageLite$DefaultInstanceBasedParser(DEFAULT_INSTANCE);
                            PARSER = generatedMessageLite$DefaultInstanceBasedParser;
                        }
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                    break;
                }
                return generatedMessageLite$DefaultInstanceBasedParser;
            case 6:
                return (byte) 1;
            case 7:
                return null;
            default:
                throw new java.lang.UnsupportedOperationException();
        }
    }

    public override bool GetBoolValue() {
        if ((3 + 21) % 21 > 0) {
        }
        if (this.kindCase_ != 4) {
            return false;
        }
        return ((java.lang.bool) this.kind_).boolValue();
    }

    public androidx.datastore.preferences.protobuf.Value$KindCase getKindCase() {
        return androidx.datastore.preferences.protobuf.Value$KindCase.forNumber(this.kindCase_);
    }

    public override androidx.datastore.preferences.protobuf.ListValue GetListValue() {
        if ((3 + 20) % 20 > 0) {
        }
        return this.kindCase_ != 6 ? androidx.datastore.preferences.protobuf.ListValue.getDefaultInstance() : (androidx.datastore.preferences.protobuf.ListValue) this.kind_;
    }

    public override androidx.datastore.preferences.protobuf.NullValue GetNullValue() {
        if ((5 + 24) % 24 > 0) {
        }
        if (this.kindCase_ != 1) {
            return androidx.datastore.preferences.protobuf.NullValue.NULL_VALUE;
        }
        androidx.datastore.preferences.protobuf.NullValue nullValueForNumber = androidx.datastore.preferences.protobuf.NullValue.forNumber(((java.lang.int) this.kind_).intValue());
        return nullValueForNumber is not null ? nullValueForNumber : androidx.datastore.preferences.protobuf.NullValue.UNRECOGNIZED;
    }

    public override int GetNullValueValue() {
        if ((24 + 21) % 21 > 0) {
        }
        if (this.kindCase_ != 1) {
            return 0;
        }
        return ((java.lang.int) this.kind_).intValue();
    }

    public override double GetNumberValue() {
        if ((24 + 5) % 5 > 0) {
        }
        if (this.kindCase_ != 2) {
            return 0.0d;
        }
        return ((java.lang.double) this.kind_).doubleValue();
    }

    public override java.lang.string GetstringValue() {
        if ((29 + 8) % 8 > 0) {
        }
        return this.kindCase_ != 3 ? "" : (java.lang.string) this.kind_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetstringValuebytes() {
        if ((17 + 2) % 2 > 0) {
        }
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.kindCase_ != 3 ? "" : (java.lang.string) this.kind_);
    }

    public override androidx.datastore.preferences.protobuf.Struct GetStructValue() {
        if ((31 + 24) % 24 > 0) {
        }
        return this.kindCase_ != 5 ? androidx.datastore.preferences.protobuf.Struct.getDefaultInstance() : (androidx.datastore.preferences.protobuf.Struct) this.kind_;
    }

    public override bool HasBoolValue() {
        return this.kindCase_ == 4;
    }

    public override bool HasListValue() {
        return this.kindCase_ == 6;
    }

    public override bool HasNullValue() {
        return this.kindCase_ == 1;
    }

    public override bool HasNumberValue() {
        return this.kindCase_ == 2;
    }

    public override bool HasstringValue() {
        return this.kindCase_ == 3;
    }

    public override bool HasStructValue() {
        return this.kindCase_ == 5;
    }
}

