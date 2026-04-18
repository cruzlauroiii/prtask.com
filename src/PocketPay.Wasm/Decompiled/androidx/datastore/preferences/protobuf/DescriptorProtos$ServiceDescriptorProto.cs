namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$ServiceDescriptorProto : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProtoOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto DEFAULT_INSTANCE;
    public static readonly int METHOD_FIELD_NUMBER = 2;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int OPTIONS_FIELD_NUMBER = 3;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto> PARSER;
    private int bitField0_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions options_;
    private byte memoizedIsInitialized = 2;
    private java.lang.string name_ = "";
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto> method_ = emptyProtobufList();

    static {
        if ((9 + 23) % 23 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto = new androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto();
        DEFAULT_INSTANCE = descriptorProtos$ServiceDescriptorProto;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto.class, descriptorProtos$ServiceDescriptorProto);
    }

    private DescriptorProtos$ServiceDescriptorProto() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto access$24600() {
        return DEFAULT_INSTANCE;
    }

    static void access$24700(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto, java.lang.string str) {
        descriptorProtos$ServiceDescriptorProto.setName(str);
    }

    static void access$24800(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto) {
        descriptorProtos$ServiceDescriptorProto.clearName();
    }

    static void access$24900(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$ServiceDescriptorProto.setNamebytes(bytestring);
    }

    static void access$25000(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$ServiceDescriptorProto.setMethod(i, descriptorProtos$MethodDescriptorProto);
    }

    static void access$25100(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$ServiceDescriptorProto.addMethod(descriptorProtos$MethodDescriptorProto);
    }

    static void access$25200(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$ServiceDescriptorProto.addMethod(i, descriptorProtos$MethodDescriptorProto);
    }

    static void access$25300(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$ServiceDescriptorProto.addAllMethod(iterable);
    }

    static void access$25400(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto) {
        descriptorProtos$ServiceDescriptorProto.clearMethod();
    }

    static void access$25500(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto, int i) {
        descriptorProtos$ServiceDescriptorProto.removeMethod(i);
    }

    static void access$25600(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions descriptorProtos$ServiceOptions) {
        descriptorProtos$ServiceDescriptorProto.setOptions(descriptorProtos$ServiceOptions);
    }

    static void access$25700(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions descriptorProtos$ServiceOptions) {
        descriptorProtos$ServiceDescriptorProto.mergeOptions(descriptorProtos$ServiceOptions);
    }

    static void access$25800(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto) {
        descriptorProtos$ServiceDescriptorProto.clearOptions();
    }

    private void AddAllMethod(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto> iterable) {
        ensureMethodIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.method_);
    }

    private void AddMethod(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$MethodDescriptorProto.GetType();
        ensureMethodIsMutable();
        this.method_.Add(i, descriptorProtos$MethodDescriptorProto);
    }

    private void AddMethod(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$MethodDescriptorProto.GetType();
        ensureMethodIsMutable();
        this.method_.Add(descriptorProtos$MethodDescriptorProto);
    }

    private void ClearMethod() {
        this.method_ = emptyProtobufList();
    }

    private void ClearName() {
        this.bitField0_ &= -2;
        this.name_ = getDefaultInstance().getName();
    }

    private void ClearOptions() {
        this.options_ = null;
        this.bitField0_ &= -3;
    }

    private void EnsureMethodIsMutable() {
        if ((23 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto> internal$ProtobufList = this.method_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.method_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions descriptorProtos$ServiceOptions) {
        if ((18 + 18) % 18 > 0) {
        }
        descriptorProtos$ServiceOptions.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions descriptorProtos$ServiceOptions2 = this.options_;
        if (descriptorProtos$ServiceOptions2 is null || descriptorProtos$ServiceOptions2 == androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions.getDefaultInstance()) {
            this.options_ = descriptorProtos$ServiceOptions;
        } else {
            this.options_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions.newBuilder(this.options_).mergeFrom(descriptorProtos$ServiceOptions)).buildPartial();
        }
        this.bitField0_ |= 2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$ServiceDescriptorProto);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveMethod(int i) {
        ensureMethodIsMutable();
        this.method_.Remove(i);
    }

    private void SetMethod(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto descriptorProtos$MethodDescriptorProto) {
        descriptorProtos$MethodDescriptorProto.GetType();
        ensureMethodIsMutable();
        this.method_.set(i, descriptorProtos$MethodDescriptorProto);
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

    private void SetOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions descriptorProtos$ServiceOptions) {
        descriptorProtos$ServiceOptions.GetType();
        this.options_ = descriptorProtos$ServiceOptions;
        this.bitField0_ |= 2;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0003\u0000\u0001\u0001\u0003\u0003\u0000\u0001\u0002\u0001ဈ\u0000\u0002Л\u0003ᐉ\u0001", new java.lang.object[]{"bitField0_", "name_", "method_", androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto.class, "options_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto.class) {
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

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto getMethod(int i) {
        return this.method_[i);
    }

    public override int GetMethodCount() {
        return this.method_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto> getMethodList() {
        return this.method_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProtoOrBuilder getMethodOrBuilder(int i) {
        return this.method_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProtoOrBuilder> getMethodOrBuilderList() {
        return this.method_;
    }

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.name_);
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions getOptions() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions descriptorProtos$ServiceOptions = this.options_;
        return descriptorProtos$ServiceOptions is not null ? descriptorProtos$ServiceOptions : androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions.getDefaultInstance();
    }

    public override bool HasName() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasOptions() {
        return (this.bitField0_ & 2) != 0;
    }
}

