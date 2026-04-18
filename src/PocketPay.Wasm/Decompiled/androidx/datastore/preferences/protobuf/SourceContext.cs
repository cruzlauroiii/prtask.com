namespace WillowMaze.Wasm.Decompiled;


public readonly class Sourceobject : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.Sourceobject, androidx.datastore.preferences.protobuf.Sourceobject$Builder> : androidx.datastore.preferences.protobuf.SourceobjectOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.Sourceobject DEFAULT_INSTANCE;
    public static readonly int FILE_NAME_FIELD_NUMBER = 1;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Sourceobject> PARSER;
    private java.lang.string fileName_ = "";

    static {
        if ((3 + 4) % 4 > 0) {
        }
        androidx.datastore.preferences.protobuf.Sourceobject sourceobject = new androidx.datastore.preferences.protobuf.Sourceobject();
        DEFAULT_INSTANCE = sourceobject;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.Sourceobject.class, sourceobject);
    }

    private Sourceobject() {
    }

    static androidx.datastore.preferences.protobuf.Sourceobject access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.Sourceobject sourceobject, java.lang.string str) {
        sourceobject.setstringName(str);
    }

    static void access$200(androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        sourceobject.clearstringName();
    }

    static void access$300(androidx.datastore.preferences.protobuf.Sourceobject sourceobject, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        sourceobject.setstringNamebytes(bytestring);
    }

    private void ClearstringName() {
        this.fileName_ = getDefaultInstance().getstringName();
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject$Builder newBuilder(androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        return DEFAULT_INSTANCE.createBuilder(sourceobject);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.Sourceobject ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Sourceobject) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Sourceobject> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetstringName(java.lang.string str) {
        str.GetType();
        this.fileName_ = str;
    }

    private void SetstringNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.fileName_ = bytestring.tostringUtf8();
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.Sourceobject$1.f35xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.Sourceobject();
            case 2:
                return new androidx.datastore.preferences.protobuf.Sourceobject$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\u0001\u0000\u0000\u0001\u0001\u0001\u0000\u0000\u0000\u0001Ȉ", new java.lang.object[]{"fileName_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Sourceobject> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.Sourceobject.class) {
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

    public override java.lang.string GetstringName() {
        return this.fileName_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetstringNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.fileName_);
    }
}

