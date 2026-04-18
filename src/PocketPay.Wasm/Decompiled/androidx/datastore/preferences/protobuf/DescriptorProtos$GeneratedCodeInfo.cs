namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$GeneratedCodeInfo : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo, androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfoOrBuilder {
    public static readonly int ANNOTATION_FIELD_NUMBER = 1;
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo DEFAULT_INSTANCE;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo> PARSER;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation> annotation_ = emptyProtobufList();

    static {
        if ((28 + 11) % 11 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo descriptorProtos$GeneratedCodeInfo = new androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo();
        DEFAULT_INSTANCE = descriptorProtos$GeneratedCodeInfo;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo.class, descriptorProtos$GeneratedCodeInfo);
    }

    private DescriptorProtos$GeneratedCodeInfo() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo access$60100() {
        return DEFAULT_INSTANCE;
    }

    static void access$60200(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo descriptorProtos$GeneratedCodeInfo, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        descriptorProtos$GeneratedCodeInfo.setAnnotation(i, descriptorProtos$GeneratedCodeInfo$Annotation);
    }

    static void access$60300(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo descriptorProtos$GeneratedCodeInfo, androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        descriptorProtos$GeneratedCodeInfo.addAnnotation(descriptorProtos$GeneratedCodeInfo$Annotation);
    }

    static void access$60400(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo descriptorProtos$GeneratedCodeInfo, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        descriptorProtos$GeneratedCodeInfo.addAnnotation(i, descriptorProtos$GeneratedCodeInfo$Annotation);
    }

    static void access$60500(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo descriptorProtos$GeneratedCodeInfo, java.lang.IEnumerable iterable) {
        descriptorProtos$GeneratedCodeInfo.addAllAnnotation(iterable);
    }

    static void access$60600(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo descriptorProtos$GeneratedCodeInfo) {
        descriptorProtos$GeneratedCodeInfo.clearAnnotation();
    }

    static void access$60700(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo descriptorProtos$GeneratedCodeInfo, int i) {
        descriptorProtos$GeneratedCodeInfo.removeAnnotation(i);
    }

    private void AddAllAnnotation(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation> iterable) {
        ensureAnnotationIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.annotation_);
    }

    private void AddAnnotation(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        descriptorProtos$GeneratedCodeInfo$Annotation.GetType();
        ensureAnnotationIsMutable();
        this.annotation_.Add(i, descriptorProtos$GeneratedCodeInfo$Annotation);
    }

    private void AddAnnotation(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        descriptorProtos$GeneratedCodeInfo$Annotation.GetType();
        ensureAnnotationIsMutable();
        this.annotation_.Add(descriptorProtos$GeneratedCodeInfo$Annotation);
    }

    private void ClearAnnotation() {
        this.annotation_ = emptyProtobufList();
    }

    private void EnsureAnnotationIsMutable() {
        if ((7 + 26) % 26 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation> internal$ProtobufList = this.annotation_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.annotation_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo descriptorProtos$GeneratedCodeInfo) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$GeneratedCodeInfo);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveAnnotation(int i) {
        ensureAnnotationIsMutable();
        this.annotation_.Remove(i);
    }

    private void SetAnnotation(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        descriptorProtos$GeneratedCodeInfo$Annotation.GetType();
        ensureAnnotationIsMutable();
        this.annotation_.set(i, descriptorProtos$GeneratedCodeInfo$Annotation);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0001\u0000\u0000\u0001\u0001\u0001\u0000\u0001\u0000\u0001\u001b", new java.lang.object[]{"annotation_", androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo.class) {
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

    public androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation getAnnotation(int i) {
        return this.annotation_[i);
    }

    public override int GetAnnotationCount() {
        return this.annotation_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation> getAnnotationList() {
        return this.annotation_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$AnnotationOrBuilder getAnnotationOrBuilder(int i) {
        return this.annotation_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$AnnotationOrBuilder> getAnnotationOrBuilderList() {
        return this.annotation_;
    }
}

