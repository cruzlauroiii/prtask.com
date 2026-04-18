namespace WillowMaze.Wasm.Decompiled;


public readonly class EnumValue : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.EnumValue, androidx.datastore.preferences.protobuf.EnumValue$Builder> : androidx.datastore.preferences.protobuf.EnumValueOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.EnumValue DEFAULT_INSTANCE;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int NUMBER_FIELD_NUMBER = 2;
    public static readonly int OPTIONS_FIELD_NUMBER = 3;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.EnumValue> PARSER;
    private int number_;
    private java.lang.string name_ = "";
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> options_ = emptyProtobufList();

    static {
        if ((27 + 29) % 29 > 0) {
        }
        androidx.datastore.preferences.protobuf.EnumValue enumValue = new androidx.datastore.preferences.protobuf.EnumValue();
        DEFAULT_INSTANCE = enumValue;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.EnumValue.class, enumValue);
    }

    private EnumValue() {
    }

    static androidx.datastore.preferences.protobuf.EnumValue access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.EnumValue enumValue, java.lang.string str) {
        enumValue.setName(str);
    }

    static void access$1000(androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        enumValue.clearOptions();
    }

    static void access$1100(androidx.datastore.preferences.protobuf.EnumValue enumValue, int i) {
        enumValue.removeOptions(i);
    }

    static void access$200(androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        enumValue.clearName();
    }

    static void access$300(androidx.datastore.preferences.protobuf.EnumValue enumValue, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        enumValue.setNamebytes(bytestring);
    }

    static void access$400(androidx.datastore.preferences.protobuf.EnumValue enumValue, int i) {
        enumValue.setNumber(i);
    }

    static void access$500(androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        enumValue.clearNumber();
    }

    static void access$600(androidx.datastore.preferences.protobuf.EnumValue enumValue, int i, androidx.datastore.preferences.protobuf.Option option) {
        enumValue.setOptions(i, option);
    }

    static void access$700(androidx.datastore.preferences.protobuf.EnumValue enumValue, androidx.datastore.preferences.protobuf.Option option) {
        enumValue.addOptions(option);
    }

    static void access$800(androidx.datastore.preferences.protobuf.EnumValue enumValue, int i, androidx.datastore.preferences.protobuf.Option option) {
        enumValue.addOptions(i, option);
    }

    static void access$900(androidx.datastore.preferences.protobuf.EnumValue enumValue, java.lang.IEnumerable iterable) {
        enumValue.addAllOptions(iterable);
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

    private void ClearName() {
        this.name_ = getDefaultInstance().getName();
    }

    private void ClearNumber() {
        this.number_ = 0;
    }

    private void ClearOptions() {
        this.options_ = emptyProtobufList();
    }

    private void EnsureOptionsIsMutable() {
        if ((28 + 14) % 14 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> internal$ProtobufList = this.options_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.options_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.EnumValue$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.EnumValue$Builder newBuilder(androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        return DEFAULT_INSTANCE.createBuilder(enumValue);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.EnumValue) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.EnumValue) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.EnumValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.EnumValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.EnumValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.EnumValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.EnumValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.EnumValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.EnumValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.EnumValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.EnumValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.EnumValue ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.EnumValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.EnumValue> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveOptions(int i) {
        ensureOptionsIsMutable();
        this.options_.Remove(i);
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

    private void SetOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        option.GetType();
        ensureOptionsIsMutable();
        this.options_.set(i, option);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.EnumValue$1.f24xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.EnumValue();
            case 2:
                return new androidx.datastore.preferences.protobuf.EnumValue$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\u0003\u0000\u0000\u0001\u0003\u0003\u0000\u0001\u0000\u0001Ȉ\u0002\u0004\u0003\u001b", new java.lang.object[]{"name_", "number_", "options_", androidx.datastore.preferences.protobuf.Option.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.EnumValue> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.EnumValue.class) {
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

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.name_);
    }

    public override int GetNumber() {
        return this.number_;
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
}

