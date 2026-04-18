namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$SourceCodeInfo : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfoOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo DEFAULT_INSTANCE;
    public static readonly int LOCATION_FIELD_NUMBER = 1;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo> PARSER;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location> location_ = emptyProtobufList();

    static {
        if ((23 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo = new androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo();
        DEFAULT_INSTANCE = descriptorProtos$SourceCodeInfo;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.class, descriptorProtos$SourceCodeInfo);
    }

    private DescriptorProtos$SourceCodeInfo() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo access$57800() {
        return DEFAULT_INSTANCE;
    }

    static void access$57900(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        descriptorProtos$SourceCodeInfo.setLocation(i, descriptorProtos$SourceCodeInfo$Location);
    }

    static void access$58000(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        descriptorProtos$SourceCodeInfo.addLocation(descriptorProtos$SourceCodeInfo$Location);
    }

    static void access$58100(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        descriptorProtos$SourceCodeInfo.addLocation(i, descriptorProtos$SourceCodeInfo$Location);
    }

    static void access$58200(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo, java.lang.IEnumerable iterable) {
        descriptorProtos$SourceCodeInfo.addAllLocation(iterable);
    }

    static void access$58300(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo) {
        descriptorProtos$SourceCodeInfo.clearLocation();
    }

    static void access$58400(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo, int i) {
        descriptorProtos$SourceCodeInfo.removeLocation(i);
    }

    private void AddAllLocation(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location> iterable) {
        ensureLocationIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.location_);
    }

    private void AddLocation(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        descriptorProtos$SourceCodeInfo$Location.GetType();
        ensureLocationIsMutable();
        this.location_.Add(i, descriptorProtos$SourceCodeInfo$Location);
    }

    private void AddLocation(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        descriptorProtos$SourceCodeInfo$Location.GetType();
        ensureLocationIsMutable();
        this.location_.Add(descriptorProtos$SourceCodeInfo$Location);
    }

    private void ClearLocation() {
        this.location_ = emptyProtobufList();
    }

    private void EnsureLocationIsMutable() {
        if ((14 + 1) % 1 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location> internal$ProtobufList = this.location_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.location_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$SourceCodeInfo);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveLocation(int i) {
        ensureLocationIsMutable();
        this.location_.Remove(i);
    }

    private void SetLocation(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        descriptorProtos$SourceCodeInfo$Location.GetType();
        ensureLocationIsMutable();
        this.location_.set(i, descriptorProtos$SourceCodeInfo$Location);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0001\u0000\u0000\u0001\u0001\u0001\u0000\u0001\u0000\u0001\u001b", new java.lang.object[]{"location_", androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.class) {
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

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location getLocation(int i) {
        return this.location_[i);
    }

    public override int GetLocationCount() {
        return this.location_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location> getLocationList() {
        return this.location_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$LocationOrBuilder getLocationOrBuilder(int i) {
        return this.location_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$LocationOrBuilder> getLocationOrBuilderList() {
        return this.location_;
    }
}

