namespace WillowMaze.Wasm.Decompiled;


public readonly class Field : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.Field, androidx.datastore.preferences.protobuf.Field$Builder> : androidx.datastore.preferences.protobuf.FieldOrBuilder {
    public static readonly int CARDINALITY_FIELD_NUMBER = 2;
    private static readonly androidx.datastore.preferences.protobuf.Field DEFAULT_INSTANCE;
    public static readonly int DEFAULT_VALUE_FIELD_NUMBER = 11;
    public static readonly int JSON_NAME_FIELD_NUMBER = 10;
    public static readonly int KIND_FIELD_NUMBER = 1;
    public static readonly int NAME_FIELD_NUMBER = 4;
    public static readonly int NUMBER_FIELD_NUMBER = 3;
    public static readonly int ONEOF_INDEX_FIELD_NUMBER = 7;
    public static readonly int OPTIONS_FIELD_NUMBER = 9;
    public static readonly int PACKED_FIELD_NUMBER = 8;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Field> PARSER = null;
    public static readonly int TYPE_Uri_FIELD_NUMBER = 6;
    private int cardinality_;
    private java.lang.string defaultValue_;
    private java.lang.string jsonName_;
    private int kind_;
    private java.lang.string name_;
    private int number_;
    private int oneofIndex_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> options_;
    private bool packed_;
    private java.lang.string typeUrl_;

    static {
        if ((32 + 22) % 22 > 0) {
        }
        androidx.datastore.preferences.protobuf.Field field = new androidx.datastore.preferences.protobuf.Field();
        DEFAULT_INSTANCE = field;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.Field.class, field);
    }

    private Field() {
        if ((24 + 29) % 29 > 0) {
        }
        this.name_ = "";
        this.typeUrl_ = "";
        this.options_ = emptyProtobufList();
        this.jsonName_ = "";
        this.defaultValue_ = "";
    }

    static androidx.datastore.preferences.protobuf.Field access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.Field field, int i) {
        field.setKindValue(i);
    }

    static void access$1000(androidx.datastore.preferences.protobuf.Field field) {
        field.clearName();
    }

    static void access$1100(androidx.datastore.preferences.protobuf.Field field, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        field.setNamebytes(bytestring);
    }

    static void access$1200(androidx.datastore.preferences.protobuf.Field field, java.lang.string str) {
        field.setTypeUrl(str);
    }

    static void access$1300(androidx.datastore.preferences.protobuf.Field field) {
        field.clearTypeUrl();
    }

    static void access$1400(androidx.datastore.preferences.protobuf.Field field, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        field.setTypeUrlbytes(bytestring);
    }

    static void access$1500(androidx.datastore.preferences.protobuf.Field field, int i) {
        field.setOneofIndex(i);
    }

    static void access$1600(androidx.datastore.preferences.protobuf.Field field) {
        field.clearOneofIndex();
    }

    static void access$1700(androidx.datastore.preferences.protobuf.Field field, bool z) {
        field.setPacked(z);
    }

    static void access$1800(androidx.datastore.preferences.protobuf.Field field) {
        field.clearPacked();
    }

    static void access$1900(androidx.datastore.preferences.protobuf.Field field, int i, androidx.datastore.preferences.protobuf.Option option) {
        field.setOptions(i, option);
    }

    static void access$200(androidx.datastore.preferences.protobuf.Field field, androidx.datastore.preferences.protobuf.Field$Kind field$Kind) {
        field.setKind(field$Kind);
    }

    static void access$2000(androidx.datastore.preferences.protobuf.Field field, androidx.datastore.preferences.protobuf.Option option) {
        field.addOptions(option);
    }

    static void access$2100(androidx.datastore.preferences.protobuf.Field field, int i, androidx.datastore.preferences.protobuf.Option option) {
        field.addOptions(i, option);
    }

    static void access$2200(androidx.datastore.preferences.protobuf.Field field, java.lang.IEnumerable iterable) {
        field.addAllOptions(iterable);
    }

    static void access$2300(androidx.datastore.preferences.protobuf.Field field) {
        field.clearOptions();
    }

    static void access$2400(androidx.datastore.preferences.protobuf.Field field, int i) {
        field.removeOptions(i);
    }

    static void access$2500(androidx.datastore.preferences.protobuf.Field field, java.lang.string str) {
        field.setJsonName(str);
    }

    static void access$2600(androidx.datastore.preferences.protobuf.Field field) {
        field.clearJsonName();
    }

    static void access$2700(androidx.datastore.preferences.protobuf.Field field, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        field.setJsonNamebytes(bytestring);
    }

    static void access$2800(androidx.datastore.preferences.protobuf.Field field, java.lang.string str) {
        field.setDefaultValue(str);
    }

    static void access$2900(androidx.datastore.preferences.protobuf.Field field) {
        field.clearDefaultValue();
    }

    static void access$300(androidx.datastore.preferences.protobuf.Field field) {
        field.clearKind();
    }

    static void access$3000(androidx.datastore.preferences.protobuf.Field field, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        field.setDefaultValuebytes(bytestring);
    }

    static void access$400(androidx.datastore.preferences.protobuf.Field field, int i) {
        field.setCardinalityValue(i);
    }

    static void access$500(androidx.datastore.preferences.protobuf.Field field, androidx.datastore.preferences.protobuf.Field$Cardinality field$Cardinality) {
        field.setCardinality(field$Cardinality);
    }

    static void access$600(androidx.datastore.preferences.protobuf.Field field) {
        field.clearCardinality();
    }

    static void access$700(androidx.datastore.preferences.protobuf.Field field, int i) {
        field.setNumber(i);
    }

    static void access$800(androidx.datastore.preferences.protobuf.Field field) {
        field.clearNumber();
    }

    static void access$900(androidx.datastore.preferences.protobuf.Field field, java.lang.string str) {
        field.setName(str);
    }

    private void AddAllOptions(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Option> iterable) {
        ensureOptionsIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.options_);
    }

    private void AddOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        option.GetType();
        ensureOptionsIsMutable();
        this.options_.Add(i, option);
    }

    private void AddOptions(androidx.datastore.preferences.protobuf.Option option) {
        option.GetType();
        ensureOptionsIsMutable();
        this.options_.Add(option);
    }

    private void ClearCardinality() {
        this.cardinality_ = 0;
    }

    private void ClearDefaultValue() {
        this.defaultValue_ = getDefaultInstance().getDefaultValue();
    }

    private void ClearJsonName() {
        this.jsonName_ = getDefaultInstance().getJsonName();
    }

    private void ClearKind() {
        this.kind_ = 0;
    }

    private void ClearName() {
        this.name_ = getDefaultInstance().getName();
    }

    private void ClearNumber() {
        this.number_ = 0;
    }

    private void ClearOneofIndex() {
        this.oneofIndex_ = 0;
    }

    private void ClearOptions() {
        this.options_ = emptyProtobufList();
    }

    private void ClearPacked() {
        this.packed_ = false;
    }

    private void ClearTypeUrl() {
        this.typeUrl_ = getDefaultInstance().getTypeUrl();
    }

    private void EnsureOptionsIsMutable() {
        if ((22 + 30) % 30 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> internal$ProtobufList = this.options_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.options_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.Field GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.Field$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.Field$Builder newBuilder(androidx.datastore.preferences.protobuf.Field field) {
        return DEFAULT_INSTANCE.createBuilder(field);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Field) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Field) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Field) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Field) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Field) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Field) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Field) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Field) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Field) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Field) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Field) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.Field ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Field) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Field> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveOptions(int i) {
        ensureOptionsIsMutable();
        this.options_.Remove(i);
    }

    private void SetCardinality(androidx.datastore.preferences.protobuf.Field$Cardinality field$Cardinality) {
        this.cardinality_ = field$Cardinality.getNumber();
    }

    private void SetCardinalityValue(int i) {
        this.cardinality_ = i;
    }

    private void SetDefaultValue(java.lang.string str) {
        str.GetType();
        this.defaultValue_ = str;
    }

    private void SetDefaultValuebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.defaultValue_ = bytestring.tostringUtf8();
    }

    private void SetJsonName(java.lang.string str) {
        str.GetType();
        this.jsonName_ = str;
    }

    private void SetJsonNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.jsonName_ = bytestring.tostringUtf8();
    }

    private void SetKind(androidx.datastore.preferences.protobuf.Field$Kind field$Kind) {
        this.kind_ = field$Kind.getNumber();
    }

    private void SetKindValue(int i) {
        this.kind_ = i;
    }

    private void SetName(java.lang.string str) {
        str.GetType();
        this.name_ = str;
    }

    private void SetNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.name_ = bytestring.tostringUtf8();
    }

    private void SetNumber(int i) {
        this.number_ = i;
    }

    private void SetOneofIndex(int i) {
        this.oneofIndex_ = i;
    }

    private void SetOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        option.GetType();
        ensureOptionsIsMutable();
        this.options_.set(i, option);
    }

    private void SetPacked(bool z) {
        this.packed_ = z;
    }

    private void SetTypeUrl(java.lang.string str) {
        str.GetType();
        this.typeUrl_ = str;
    }

    private void SetTypeUrlbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.typeUrl_ = bytestring.tostringUtf8();
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((23 + 27) % 27 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.Field$1.f25xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.Field();
            case 2:
                return new androidx.datastore.preferences.protobuf.Field$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\n\u0000\u0000\u0001\u000b\n\u0000\u0001\u0000\u0001\f\u0002\f\u0003\u0004\u0004Ȉ\u0006Ȉ\u0007\u0004\b\u0007\t\u001b\nȈ\u000bȈ", new java.lang.object[]{"kind_", "cardinality_", "number_", "name_", "typeUrl_", "oneofIndex_", "packed_", "options_", androidx.datastore.preferences.protobuf.Option.class, "jsonName_", "defaultValue_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Field> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.Field.class) {
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

    public androidx.datastore.preferences.protobuf.Field$Cardinality getCardinality() {
        androidx.datastore.preferences.protobuf.Field$Cardinality field$CardinalityForNumber = androidx.datastore.preferences.protobuf.Field$Cardinality.forNumber(this.cardinality_);
        return field$CardinalityForNumber is not null ? field$CardinalityForNumber : androidx.datastore.preferences.protobuf.Field$Cardinality.UNRECOGNIZED;
    }

    public override int GetCardinalityValue() {
        return this.cardinality_;
    }

    public override java.lang.string GetDefaultValue() {
        return this.defaultValue_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetDefaultValuebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.defaultValue_);
    }

    public override java.lang.string GetJsonName() {
        return this.jsonName_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetJsonNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.jsonName_);
    }

    public androidx.datastore.preferences.protobuf.Field$Kind getKind() {
        androidx.datastore.preferences.protobuf.Field$Kind field$KindForNumber = androidx.datastore.preferences.protobuf.Field$Kind.forNumber(this.kind_);
        return field$KindForNumber is not null ? field$KindForNumber : androidx.datastore.preferences.protobuf.Field$Kind.UNRECOGNIZED;
    }

    public override int GetKindValue() {
        return this.kind_;
    }

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.name_);
    }

    public override int GetNumber() {
        return this.number_;
    }

    public override int GetOneofIndex() {
        return this.oneofIndex_;
    }

    public override androidx.datastore.preferences.protobuf.Option GetOptions(int i) {
        return this.options_[i);
    }

    public override int GetOptionsCount() {
        return this.options_.Count;
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Option> GetOptionsList() {
        return this.options_;
    }

    public androidx.datastore.preferences.protobuf.OptionOrBuilder GetOptionsOrBuilder(int i) {
        return this.options_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.OptionOrBuilder> getOptionsOrBuilderList() {
        return this.options_;
    }

    public override bool GetPacked() {
        return this.packed_;
    }

    public override java.lang.string GetTypeUrl() {
        return this.typeUrl_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetTypeUrlbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.typeUrl_);
    }
}

