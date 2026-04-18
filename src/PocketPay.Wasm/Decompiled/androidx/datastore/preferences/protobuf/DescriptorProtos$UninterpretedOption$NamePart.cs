namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$UninterpretedOption$NamePart : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePartOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart DEFAULT_INSTANCE;
    public static readonly int IS_EXTENSION_FIELD_NUMBER = 2;
    public static readonly int NAME_PART_FIELD_NUMBER = 1;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart> PARSER;
    private int bitField0_;
    private bool isExtension_;
    private byte memoizedIsInitialized = 2;
    private java.lang.string namePart_ = "";

    static {
        if ((31 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart = new androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart();
        DEFAULT_INSTANCE = descriptorProtos$UninterpretedOption$NamePart;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart.class, descriptorProtos$UninterpretedOption$NamePart);
    }

    private DescriptorProtos$UninterpretedOption$NamePart() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart access$49200() {
        return DEFAULT_INSTANCE;
    }

    static void access$49300(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart, java.lang.string str) {
        descriptorProtos$UninterpretedOption$NamePart.setNamePart(str);
    }

    static void access$49400(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart) {
        descriptorProtos$UninterpretedOption$NamePart.clearNamePart();
    }

    static void access$49500(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$UninterpretedOption$NamePart.setNamePartbytes(bytestring);
    }

    static void access$49600(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart, bool z) {
        descriptorProtos$UninterpretedOption$NamePart.setIsExtension(z);
    }

    static void access$49700(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart) {
        descriptorProtos$UninterpretedOption$NamePart.clearIsExtension();
    }

    private void ClearIsExtension() {
        this.bitField0_ &= -3;
        this.isExtension_ = false;
    }

    private void ClearNamePart() {
        this.bitField0_ &= -2;
        this.namePart_ = getDefaultInstance().getNamePart();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$UninterpretedOption$NamePart);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetIsExtension(bool z) {
        this.bitField0_ |= 2;
        this.isExtension_ = z;
    }

    private void SetNamePart(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 1;
        this.namePart_ = str;
    }

    private void SetNamePartbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.namePart_ = bytestring.tostringUtf8();
        this.bitField0_ |= 1;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0002\u0000\u0001\u0001\u0002\u0002\u0000\u0000\u0002\u0001ᔈ\u0000\u0002ᔇ\u0001", new java.lang.object[]{"bitField0_", "namePart_", "isExtension_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart.class) {
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
                return java.lang.byte.valueOf(this.memoizedIsInitialized);
            case 7:
                this.memoizedIsInitialized = (byte) (obj is not null ? 1 : 0);
                return null;
            default:
                throw new java.lang.UnsupportedOperationException();
        }
    }

    public override bool GetIsExtension() {
        return this.isExtension_;
    }

    public override java.lang.string GetNamePart() {
        return this.namePart_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamePartbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.namePart_);
    }

    public override bool HasIsExtension() {
        return (this.bitField0_ & 2) != 0;
    }

    public override bool HasNamePart() {
        return (this.bitField0_ & 1) != 0;
    }
}

