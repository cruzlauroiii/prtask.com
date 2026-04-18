namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$stringDescriptorHashSet : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet, androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSetOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet DEFAULT_INSTANCE;
    public static readonly int FILE_FIELD_NUMBER = 1;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet> PARSER;
    private byte memoizedIsInitialized = 2;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto> file_ = emptyProtobufList();

    static {
        if ((31 + 26) % 26 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet descriptorProtos$stringDescriptorHashSet = new androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet();
        DEFAULT_INSTANCE = descriptorProtos$stringDescriptorHashSet;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet.class, descriptorProtos$stringDescriptorHashSet);
    }

    private DescriptorProtos$stringDescriptorHashSet() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet descriptorProtos$stringDescriptorHashSet, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorHashSet.setstring(i, descriptorProtos$stringDescriptorProto);
    }

    static void access$200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet descriptorProtos$stringDescriptorHashSet, androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorHashSet.addstring(descriptorProtos$stringDescriptorProto);
    }

    static void access$300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet descriptorProtos$stringDescriptorHashSet, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorHashSet.addstring(i, descriptorProtos$stringDescriptorProto);
    }

    static void access$400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet descriptorProtos$stringDescriptorHashSet, java.lang.IEnumerable iterable) {
        descriptorProtos$stringDescriptorHashSet.addAllstring(iterable);
    }

    static void access$500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet descriptorProtos$stringDescriptorHashSet) {
        descriptorProtos$stringDescriptorHashSet.clearstring();
    }

    static void access$600(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet descriptorProtos$stringDescriptorHashSet, int i) {
        descriptorProtos$stringDescriptorHashSet.removestring(i);
    }

    private void AddAllstring(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto> iterable) {
        ensurestringIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.file_);
    }

    private void Addstring(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.GetType();
        ensurestringIsMutable();
        this.file_.Add(i, descriptorProtos$stringDescriptorProto);
    }

    private void Addstring(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.GetType();
        ensurestringIsMutable();
        this.file_.Add(descriptorProtos$stringDescriptorProto);
    }

    private void Clearstring() {
        this.file_ = emptyProtobufList();
    }

    private void EnsurestringIsMutable() {
        if ((10 + 32) % 32 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto> internal$ProtobufList = this.file_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.file_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet descriptorProtos$stringDescriptorHashSet) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$stringDescriptorHashSet);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void Removestring(int i) {
        ensurestringIsMutable();
        this.file_.Remove(i);
    }

    private void Setstring(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.GetType();
        ensurestringIsMutable();
        this.file_.set(i, descriptorProtos$stringDescriptorProto);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0001\u0000\u0000\u0001\u0001\u0001\u0000\u0001\u0001\u0001Л", new java.lang.object[]{"file_", androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorHashSet.class) {
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

    public androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto getstring(int i) {
        return this.file_[i);
    }

    public override int GetstringCount() {
        return this.file_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto> getstringList() {
        return this.file_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProtoOrBuilder getstringOrBuilder(int i) {
        return this.file_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProtoOrBuilder> getstringOrBuilderList() {
        return this.file_;
    }
}

