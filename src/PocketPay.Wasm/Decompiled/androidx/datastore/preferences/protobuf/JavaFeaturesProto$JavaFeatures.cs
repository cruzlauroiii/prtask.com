namespace WillowMaze.Wasm.Decompiled;


public readonly class JavaFeaturesProto$JavaFeatures : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures, androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Builder> : androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeaturesOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures DEFAULT_INSTANCE;
    public static readonly int LEGACY_CLOSED_ENUM_FIELD_NUMBER = 1;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures> PARSER = null;
    public static readonly int UTF8_VALIDATION_FIELD_NUMBER = 2;
    private int bitField0_;
    private bool legacyClosedEnum_;
    private int utf8Validation_;

    static {
        if ((7 + 6) % 6 > 0) {
        }
        androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures javaFeaturesProto$JavaFeatures = new androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures();
        DEFAULT_INSTANCE = javaFeaturesProto$JavaFeatures;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures.class, javaFeaturesProto$JavaFeatures);
    }

    private JavaFeaturesProto$JavaFeatures() {
    }

    static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures javaFeaturesProto$JavaFeatures, bool z) {
        javaFeaturesProto$JavaFeatures.setLegacyClosedEnum(z);
    }

    static void access$200(androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures javaFeaturesProto$JavaFeatures) {
        javaFeaturesProto$JavaFeatures.clearLegacyClosedEnum();
    }

    static void access$300(androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures javaFeaturesProto$JavaFeatures, androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation javaFeaturesProto$JavaFeatures$Utf8Validation) {
        javaFeaturesProto$JavaFeatures.setUtf8Validation(javaFeaturesProto$JavaFeatures$Utf8Validation);
    }

    static void access$400(androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures javaFeaturesProto$JavaFeatures) {
        javaFeaturesProto$JavaFeatures.clearUtf8Validation();
    }

    private void ClearLegacyClosedEnum() {
        this.bitField0_ &= -2;
        this.legacyClosedEnum_ = false;
    }

    private void ClearUtf8Validation() {
        this.bitField0_ &= -3;
        this.utf8Validation_ = 0;
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Builder newBuilder(androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures javaFeaturesProto$JavaFeatures) {
        return DEFAULT_INSTANCE.createBuilder(javaFeaturesProto$JavaFeatures);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetLegacyClosedEnum(bool z) {
        this.bitField0_ |= 1;
        this.legacyClosedEnum_ = z;
    }

    private void SetUtf8Validation(androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation javaFeaturesProto$JavaFeatures$Utf8Validation) {
        this.utf8Validation_ = javaFeaturesProto$JavaFeatures$Utf8Validation.getNumber();
        this.bitField0_ |= 2;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.JavaFeaturesProto$1.f30xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures();
            case 2:
                return new androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0002\u0000\u0001\u0001\u0002\u0002\u0000\u0000\u0000\u0001ဇ\u0000\u0002᠌\u0001", new java.lang.object[]{"bitField0_", "legacyClosedEnum_", "utf8Validation_", androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation.internalGetVerifier()});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures.class) {
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

    public override bool GetLegacyClosedEnum() {
        return this.legacyClosedEnum_;
    }

    public androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation getUtf8Validation() {
        androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation javaFeaturesProto$JavaFeatures$Utf8ValidationForNumber = androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation.forNumber(this.utf8Validation_);
        return javaFeaturesProto$JavaFeatures$Utf8ValidationForNumber is not null ? javaFeaturesProto$JavaFeatures$Utf8ValidationForNumber : androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation.UTF8_VALIDATION_UNKNOWN;
    }

    public override bool HasLegacyClosedEnum() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasUtf8Validation() {
        return (this.bitField0_ & 2) != 0;
    }
}

