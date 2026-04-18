namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FieldOptions$FeatureSupport : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupportOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport DEFAULT_INSTANCE;
    public static readonly int DEPRECATION_WARNING_FIELD_NUMBER = 3;
    public static readonly int EDITION_DEPRECATED_FIELD_NUMBER = 2;
    public static readonly int EDITION_INTRODUCED_FIELD_NUMBER = 1;
    public static readonly int EDITION_REMOVED_FIELD_NUMBER = 4;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport> PARSER;
    private int bitField0_;
    private java.lang.string deprecationWarning_ = "";
    private int editionDeprecated_;
    private int editionIntroduced_;
    private int editionRemoved_;

    static {
        if ((20 + 21) % 21 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport();
        DEFAULT_INSTANCE = descriptorProtos$FieldOptions$FeatureSupport;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport.class, descriptorProtos$FieldOptions$FeatureSupport);
    }

    private DescriptorProtos$FieldOptions$FeatureSupport() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport access$36500() {
        return DEFAULT_INSTANCE;
    }

    static void access$36600(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport, androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        descriptorProtos$FieldOptions$FeatureSupport.setEditionIntroduced(descriptorProtos$Edition);
    }

    static void access$36700(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport) {
        descriptorProtos$FieldOptions$FeatureSupport.clearEditionIntroduced();
    }

    static void access$36800(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport, androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        descriptorProtos$FieldOptions$FeatureSupport.setEditionDeprecated(descriptorProtos$Edition);
    }

    static void access$36900(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport) {
        descriptorProtos$FieldOptions$FeatureSupport.clearEditionDeprecated();
    }

    static void access$37000(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport, java.lang.string str) {
        descriptorProtos$FieldOptions$FeatureSupport.setDeprecationWarning(str);
    }

    static void access$37100(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport) {
        descriptorProtos$FieldOptions$FeatureSupport.clearDeprecationWarning();
    }

    static void access$37200(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$FieldOptions$FeatureSupport.setDeprecationWarningbytes(bytestring);
    }

    static void access$37300(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport, androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        descriptorProtos$FieldOptions$FeatureSupport.setEditionRemoved(descriptorProtos$Edition);
    }

    static void access$37400(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport) {
        descriptorProtos$FieldOptions$FeatureSupport.clearEditionRemoved();
    }

    private void ClearDeprecationWarning() {
        this.bitField0_ &= -5;
        this.deprecationWarning_ = getDefaultInstance().getDeprecationWarning();
    }

    private void ClearEditionDeprecated() {
        this.bitField0_ &= -3;
        this.editionDeprecated_ = 0;
    }

    private void ClearEditionIntroduced() {
        this.bitField0_ &= -2;
        this.editionIntroduced_ = 0;
    }

    private void ClearEditionRemoved() {
        this.bitField0_ &= -9;
        this.editionRemoved_ = 0;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$FieldOptions$FeatureSupport);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetDeprecationWarning(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 4;
        this.deprecationWarning_ = str;
    }

    private void SetDeprecationWarningbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.deprecationWarning_ = bytestring.tostringUtf8();
        this.bitField0_ |= 4;
    }

    private void SetEditionDeprecated(androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        this.editionDeprecated_ = descriptorProtos$Edition.getNumber();
        this.bitField0_ |= 2;
    }

    private void SetEditionIntroduced(androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        this.editionIntroduced_ = descriptorProtos$Edition.getNumber();
        this.bitField0_ |= 1;
    }

    private void SetEditionRemoved(androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        this.editionRemoved_ = descriptorProtos$Edition.getNumber();
        this.bitField0_ |= 8;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((3 + 15) % 15 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0004\u0000\u0001\u0001\u0004\u0004\u0000\u0000\u0000\u0001᠌\u0000\u0002᠌\u0001\u0003ဈ\u0002\u0004᠌\u0003", new java.lang.object[]{"bitField0_", "editionIntroduced_", androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.internalGetVerifier(), "editionDeprecated_", androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.internalGetVerifier(), "deprecationWarning_", "editionRemoved_", androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.internalGetVerifier()});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport.class) {
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

    public override java.lang.string GetDeprecationWarning() {
        return this.deprecationWarning_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetDeprecationWarningbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.deprecationWarning_);
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getEditionDeprecated() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$EditionForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.forNumber(this.editionDeprecated_);
        return descriptorProtos$EditionForNumber is not null ? descriptorProtos$EditionForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.EDITION_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getEditionIntroduced() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$EditionForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.forNumber(this.editionIntroduced_);
        return descriptorProtos$EditionForNumber is not null ? descriptorProtos$EditionForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.EDITION_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getEditionRemoved() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$EditionForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.forNumber(this.editionRemoved_);
        return descriptorProtos$EditionForNumber is not null ? descriptorProtos$EditionForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.EDITION_UNKNOWN;
    }

    public override bool HasDeprecationWarning() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasEditionDeprecated() {
        return (this.bitField0_ & 2) != 0;
    }

    public override bool HasEditionIntroduced() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasEditionRemoved() {
        return (this.bitField0_ & 8) != 0;
    }
}

