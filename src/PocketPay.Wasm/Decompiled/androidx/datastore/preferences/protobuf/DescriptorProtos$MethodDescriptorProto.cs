namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$MethodDescriptorProto : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProtoOrBuilder {
    public static readonly int CLIENT_STREAMING_FIELD_NUMBER = 5;
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto DEFAULT_INSTANCE;
    public static readonly int INPUT_TYPE_FIELD_NUMBER = 2;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int OPTIONS_FIELD_NUMBER = 4;
    public static readonly int OUTPUT_TYPE_FIELD_NUMBER = 3;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto> PARSER = null;
    public static readonly int SERVER_STREAMING_FIELD_NUMBER = 6;
    private int bitField0_;
    private bool clientStreaming_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions options_;
    private bool serverStreaming_;
    private byte memoizedIsInitialized = 2;
    private java.lang.string name_ = "";
    private java.lang.string inputType_ = "";
    private java.lang.string outputType_ = "";

    static {
        if ((23 + 24) % 24 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto = new androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto();
        DEFAULT_INSTANCE = descriptorProtos$MethodDescriptorProto;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto.class, descriptorProtos$MethodDescriptorProto);
    }

    private DescriptorProtos$MethodDescriptorProto() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto access$26000() {
        return DEFAULT_INSTANCE;
    }

    static void access$26100(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto, java.lang.string str) {
        descriptorProtos$MethodDescriptorProto.setName(str);
    }

    static void access$26200(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$MethodDescriptorProto.clearName();
    }

    static void access$26300(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$MethodDescriptorProto.setNamebytes(bytestring);
    }

    static void access$26400(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto, java.lang.string str) {
        descriptorProtos$MethodDescriptorProto.setInputType(str);
    }

    static void access$26500(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$MethodDescriptorProto.clearInputType();
    }

    static void access$26600(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$MethodDescriptorProto.setInputTypebytes(bytestring);
    }

    static void access$26700(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto, java.lang.string str) {
        descriptorProtos$MethodDescriptorProto.setOutputType(str);
    }

    static void access$26800(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$MethodDescriptorProto.clearOutputType();
    }

    static void access$26900(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$MethodDescriptorProto.setOutputTypebytes(bytestring);
    }

    static void access$27000(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions) {
        descriptorProtos$MethodDescriptorProto.setOptions(descriptorProtos$MethodOptions);
    }

    static void access$27100(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions) {
        descriptorProtos$MethodDescriptorProto.mergeOptions(descriptorProtos$MethodOptions);
    }

    static void access$27200(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$MethodDescriptorProto.clearOptions();
    }

    static void access$27300(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto, bool z) {
        descriptorProtos$MethodDescriptorProto.setClientStreaming(z);
    }

    static void access$27400(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$MethodDescriptorProto.clearClientStreaming();
    }

    static void access$27500(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto, bool z) {
        descriptorProtos$MethodDescriptorProto.setServerStreaming(z);
    }

    static void access$27600(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$MethodDescriptorProto.clearServerStreaming();
    }

    private void ClearClientStreaming() {
        this.bitField0_ &= -17;
        this.clientStreaming_ = false;
    }

    private void ClearInputType() {
        this.bitField0_ &= -3;
        this.inputType_ = getDefaultInstance().getInputType();
    }

    private void ClearName() {
        this.bitField0_ &= -2;
        this.name_ = getDefaultInstance().getName();
    }

    private void ClearOptions() {
        this.options_ = null;
        this.bitField0_ &= -9;
    }

    private void ClearOutputType() {
        this.bitField0_ &= -5;
        this.outputType_ = getDefaultInstance().getOutputType();
    }

    private void ClearServerStreaming() {
        this.bitField0_ &= -33;
        this.serverStreaming_ = false;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions) {
        if ((18 + 22) % 22 > 0) {
        }
        descriptorProtos$MethodOptions.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions2 = this.options_;
        if (descriptorProtos$MethodOptions2 is null || descriptorProtos$MethodOptions2 == androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.getDefaultInstance()) {
            this.options_ = descriptorProtos$MethodOptions;
        } else {
            this.options_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.newBuilder(this.options_).mergeFrom(descriptorProtos$MethodOptions)).buildPartial();
        }
        this.bitField0_ |= 8;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$MethodDescriptorProto);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetClientStreaming(bool z) {
        this.bitField0_ |= 16;
        this.clientStreaming_ = z;
    }

    private void SetInputType(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 2;
        this.inputType_ = str;
    }

    private void SetInputTypebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.inputType_ = bytestring.tostringUtf8();
        this.bitField0_ |= 2;
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

    private void SetOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions) {
        descriptorProtos$MethodOptions.GetType();
        this.options_ = descriptorProtos$MethodOptions;
        this.bitField0_ |= 8;
    }

    private void SetOutputType(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 4;
        this.outputType_ = str;
    }

    private void SetOutputTypebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.outputType_ = bytestring.tostringUtf8();
        this.bitField0_ |= 4;
    }

    private void SetServerStreaming(bool z) {
        this.bitField0_ |= 32;
        this.serverStreaming_ = z;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((30 + 5) % 5 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0006\u0000\u0001\u0001\u0006\u0006\u0000\u0000\u0001\u0001ဈ\u0000\u0002ဈ\u0001\u0003ဈ\u0002\u0004ᐉ\u0003\u0005ဇ\u0004\u0006ဇ\u0005", new java.lang.object[]{"bitField0_", "name_", "inputType_", "outputType_", "options_", "clientStreaming_", "serverStreaming_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto.class) {
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

    public override bool GetClientStreaming() {
        return this.clientStreaming_;
    }

    public override java.lang.string GetInputType() {
        return this.inputType_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetInputTypebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.inputType_);
    }

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.name_);
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions getOptions() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions = this.options_;
        return descriptorProtos$MethodOptions is not null ? descriptorProtos$MethodOptions : androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.getDefaultInstance();
    }

    public override java.lang.string GetOutputType() {
        return this.outputType_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetOutputTypebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.outputType_);
    }

    public override bool GetServerStreaming() {
        return this.serverStreaming_;
    }

    public override bool HasClientStreaming() {
        return (this.bitField0_ & 16) != 0;
    }

    public override bool HasInputType() {
        return (this.bitField0_ & 2) != 0;
    }

    public override bool HasName() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasOptions() {
        return (this.bitField0_ & 8) != 0;
    }

    public override bool HasOutputType() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasServerStreaming() {
        return (this.bitField0_ & 32) != 0;
    }
}

