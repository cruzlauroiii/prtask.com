namespace WillowMaze.Wasm.Decompiled;


public readonly class floatValue : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.floatValue, androidx.datastore.preferences.protobuf.floatValue$Builder> : androidx.datastore.preferences.protobuf.floatValueOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.floatValue DEFAULT_INSTANCE;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.floatValue> PARSER = null;
    public static readonly int VALUE_FIELD_NUMBER = 1;
    private float value_;

    static {
        if ((6 + 25) % 25 > 0) {
        }
        androidx.datastore.preferences.protobuf.floatValue floatValue = new androidx.datastore.preferences.protobuf.floatValue();
        DEFAULT_INSTANCE = floatValue;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.floatValue.class, floatValue);
    }

    private floatValue() {
    }

    static androidx.datastore.preferences.protobuf.floatValue access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.floatValue floatValue, float f) {
        floatValue.setValue(f);
    }

    static void access$200(androidx.datastore.preferences.protobuf.floatValue floatValue) {
        floatValue.clearValue();
    }

    private void ClearValue() {
        this.value_ = 0.0f;
    }

    public static androidx.datastore.preferences.protobuf.floatValue GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.floatValue$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.floatValue$Builder newBuilder(androidx.datastore.preferences.protobuf.floatValue floatValue) {
        return DEFAULT_INSTANCE.createBuilder(floatValue);
    }

    public static androidx.datastore.preferences.protobuf.floatValue Of(float f) {
        return newBuilder().setValue(f).build();
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.floatValue) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.floatValue) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.floatValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.floatValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.floatValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.floatValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.floatValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.floatValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.floatValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.floatValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.floatValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.floatValue ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.floatValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.floatValue> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetValue(float f) {
        this.value_ = f;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.floatValue$1.f27xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.floatValue();
            case 2:
                return new androidx.datastore.preferences.protobuf.floatValue$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\u0001\u0000\u0000\u0001\u0001\u0001\u0000\u0000\u0000\u0001\u0001", new java.lang.object[]{"value_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.floatValue> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.floatValue.class) {
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

    public override float GetValue() {
        return this.value_;
    }
}

