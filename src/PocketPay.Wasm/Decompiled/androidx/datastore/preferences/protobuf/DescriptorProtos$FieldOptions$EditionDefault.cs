namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FieldOptions$EditionDefault : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefaultOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault DEFAULT_INSTANCE;
    public static readonly int EDITION_FIELD_NUMBER = 3;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault> PARSER = null;
    public static readonly int VALUE_FIELD_NUMBER = 2;
    private int bitField0_;
    private int edition_;
    private java.lang.string value_ = "";

    static {
        if ((7 + 12) % 12 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault();
        DEFAULT_INSTANCE = descriptorProtos$FieldOptions$EditionDefault;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault.class, descriptorProtos$FieldOptions$EditionDefault);
    }

    private DescriptorProtos$FieldOptions$EditionDefault() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault access$35800() {
        return DEFAULT_INSTANCE;
    }

    static void access$35900(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault, androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        descriptorProtos$FieldOptions$EditionDefault.setEdition(descriptorProtos$Edition);
    }

    static void access$36000(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault) {
        descriptorProtos$FieldOptions$EditionDefault.clearEdition();
    }

    static void access$36100(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault, java.lang.string str) {
        descriptorProtos$FieldOptions$EditionDefault.setValue(str);
    }

    static void access$36200(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault) {
        descriptorProtos$FieldOptions$EditionDefault.clearValue();
    }

    static void access$36300(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$FieldOptions$EditionDefault.setValuebytes(bytestring);
    }

    private void ClearEdition() {
        this.bitField0_ &= -2;
        this.edition_ = 0;
    }

    private void ClearValue() {
        this.bitField0_ &= -3;
        this.value_ = getDefaultInstance().getValue();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$FieldOptions$EditionDefault);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetEdition(androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        this.edition_ = descriptorProtos$Edition.getNumber();
        this.bitField0_ |= 1;
    }

    private void SetValue(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 2;
        this.value_ = str;
    }

    private void SetValuebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.value_ = bytestring.tostringUtf8();
        this.bitField0_ |= 2;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0002\u0000\u0001\u0002\u0003\u0002\u0000\u0000\u0000\u0002ဈ\u0001\u0003᠌\u0000", new java.lang.object[]{"bitField0_", "value_", "edition_", androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.internalGetVerifier()});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault.class) {
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

    public androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getEdition() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$EditionForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.forNumber(this.edition_);
        return descriptorProtos$EditionForNumber is not null ? descriptorProtos$EditionForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.EDITION_UNKNOWN;
    }

    public override java.lang.string GetValue() {
        return this.value_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetValuebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.value_);
    }

    public override bool HasEdition() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasValue() {
        return (this.bitField0_ & 2) != 0;
    }
}

