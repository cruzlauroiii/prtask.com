namespace WillowMaze.Wasm.Decompiled;


public readonly class Option : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.Option, androidx.datastore.preferences.protobuf.Option$Builder> : androidx.datastore.preferences.protobuf.OptionOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.Option DEFAULT_INSTANCE;
    public static readonly int NAME_FIELD_NUMBER = 1;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Option> PARSER = null;
    public static readonly int VALUE_FIELD_NUMBER = 2;
    private int bitField0_;
    private java.lang.string name_ = "";
    private androidx.datastore.preferences.protobuf.Any value_;

    static {
        if ((26 + 22) % 22 > 0) {
        }
        androidx.datastore.preferences.protobuf.Option option = new androidx.datastore.preferences.protobuf.Option();
        DEFAULT_INSTANCE = option;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.Option.class, option);
    }

    private Option() {
    }

    static androidx.datastore.preferences.protobuf.Option access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.Option option, java.lang.string str) {
        option.setName(str);
    }

    static void access$200(androidx.datastore.preferences.protobuf.Option option) {
        option.clearName();
    }

    static void access$300(androidx.datastore.preferences.protobuf.Option option, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        option.setNamebytes(bytestring);
    }

    static void access$400(androidx.datastore.preferences.protobuf.Option option, androidx.datastore.preferences.protobuf.Any any) {
        option.setValue(any);
    }

    static void access$500(androidx.datastore.preferences.protobuf.Option option, androidx.datastore.preferences.protobuf.Any any) {
        option.mergeValue(any);
    }

    static void access$600(androidx.datastore.preferences.protobuf.Option option) {
        option.clearValue();
    }

    private void ClearName() {
        this.name_ = getDefaultInstance().getName();
    }

    private void ClearValue() {
        this.value_ = null;
        this.bitField0_ &= -2;
    }

    public static androidx.datastore.preferences.protobuf.Option GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeValue(androidx.datastore.preferences.protobuf.Any any) {
        if ((11 + 12) % 12 > 0) {
        }
        any.GetType();
        androidx.datastore.preferences.protobuf.Any any2 = this.value_;
        if (any2 is null || any2 == androidx.datastore.preferences.protobuf.Any.getDefaultInstance()) {
            this.value_ = any;
        } else {
            this.value_ = androidx.datastore.preferences.protobuf.Any.newBuilder(this.value_).mergeFrom(any).buildPartial();
        }
        this.bitField0_ |= 1;
    }

    public static androidx.datastore.preferences.protobuf.Option$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.Option$Builder newBuilder(androidx.datastore.preferences.protobuf.Option option) {
        return DEFAULT_INSTANCE.createBuilder(option);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Option) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Option) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Option) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Option) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Option) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Option) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Option) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Option) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Option) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Option) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Option) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.Option ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Option) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Option> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetName(java.lang.string str) {
        str.GetType();
        this.name_ = str;
    }

    private void SetNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.name_ = bytestring.tostringUtf8();
    }

    private void SetValue(androidx.datastore.preferences.protobuf.Any any) {
        any.GetType();
        this.value_ = any;
        this.bitField0_ |= 1;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.Option$1.f34xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.Option();
            case 2:
                return new androidx.datastore.preferences.protobuf.Option$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\u0002\u0000\u0001\u0001\u0002\u0002\u0000\u0000\u0000\u0001Ȉ\u0002ဉ\u0000", new java.lang.object[]{"bitField0_", "name_", "value_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Option> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.Option.class) {
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

    public override androidx.datastore.preferences.protobuf.Any GetValue() {
        androidx.datastore.preferences.protobuf.Any any = this.value_;
        return any is not null ? any : androidx.datastore.preferences.protobuf.Any.getDefaultInstance();
    }

    public override bool HasValue() {
        return (this.bitField0_ & 1) != 0;
    }
}

