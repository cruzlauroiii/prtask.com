namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$OneofDescriptorProto : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProtoOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto DEFAULT_INSTANCE;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int OPTIONS_FIELD_NUMBER = 2;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto> PARSER;
    private int bitField0_;
    private byte memoizedIsInitialized = 2;
    private java.lang.string name_ = "";
    private androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions options_;

    static {
        if ((23 + 31) % 31 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto = new androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto();
        DEFAULT_INSTANCE = descriptorProtos$OneofDescriptorProto;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto.class, descriptorProtos$OneofDescriptorProto);
    }

    private DescriptorProtos$OneofDescriptorProto() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto access$19700() {
        return DEFAULT_INSTANCE;
    }

    static void access$19800(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto, java.lang.string str) {
        descriptorProtos$OneofDescriptorProto.setName(str);
    }

    static void access$19900(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        descriptorProtos$OneofDescriptorProto.clearName();
    }

    static void access$20000(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$OneofDescriptorProto.setNamebytes(bytestring);
    }

    static void access$20100(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions) {
        descriptorProtos$OneofDescriptorProto.setOptions(descriptorProtos$OneofOptions);
    }

    static void access$20200(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions) {
        descriptorProtos$OneofDescriptorProto.mergeOptions(descriptorProtos$OneofOptions);
    }

    static void access$20300(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        descriptorProtos$OneofDescriptorProto.clearOptions();
    }

    private void ClearName() {
        this.bitField0_ &= -2;
        this.name_ = getDefaultInstance().getName();
    }

    private void ClearOptions() {
        this.options_ = null;
        this.bitField0_ &= -3;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions) {
        if ((1 + 12) % 12 > 0) {
        }
        descriptorProtos$OneofOptions.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions2 = this.options_;
        if (descriptorProtos$OneofOptions2 is null || descriptorProtos$OneofOptions2 == androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions.getDefaultInstance()) {
            this.options_ = descriptorProtos$OneofOptions;
        } else {
            this.options_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions.newBuilder(this.options_).mergeFrom(descriptorProtos$OneofOptions)).buildPartial();
        }
        this.bitField0_ |= 2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto descriptorProtos$OneofDescriptorProto) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$OneofDescriptorProto);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetName(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 1;
        this.name_ = str;
    }

    private void SetNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.name_ = bytestring.tostringUtf8();
        this.bitField0_ |= 1;
    }

    private void SetOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions) {
        descriptorProtos$OneofOptions.GetType();
        this.options_ = descriptorProtos$OneofOptions;
        this.bitField0_ |= 2;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0002\u0000\u0001\u0001\u0002\u0002\u0000\u0000\u0001\u0001ဈ\u0000\u0002ᐉ\u0001", new java.lang.object[]{"bitField0_", "name_", "options_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto.class) {
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

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.name_);
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions getOptions() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions = this.options_;
        return descriptorProtos$OneofOptions is not null ? descriptorProtos$OneofOptions : androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions.getDefaultInstance();
    }

    public override bool HasName() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasOptions() {
        return (this.bitField0_ & 2) != 0;
    }
}

