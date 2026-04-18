namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$GeneratedCodeInfo$Annotation : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation, androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$AnnotationOrBuilder {
    public static readonly int BEGIN_FIELD_NUMBER = 3;
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation DEFAULT_INSTANCE;
    public static readonly int END_FIELD_NUMBER = 4;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation> PARSER = null;
    public static readonly int PATH_FIELD_NUMBER = 1;
    public static readonly int SEMANTIC_FIELD_NUMBER = 5;
    public static readonly int SOURCE_FILE_FIELD_NUMBER = 2;
    private int begin_;
    private int bitField0_;
    private int end_;
    private int semantic_;
    private int pathMemoizedSerializedSize = -1;
    private androidx.datastore.preferences.protobuf.Internal$IntList path_ = emptyIntList();
    private java.lang.string sourcestring_ = "";

    static {
        if ((1 + 19) % 19 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation = new androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation();
        DEFAULT_INSTANCE = descriptorProtos$GeneratedCodeInfo$Annotation;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation.class, descriptorProtos$GeneratedCodeInfo$Annotation);
    }

    private DescriptorProtos$GeneratedCodeInfo$Annotation() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation access$58600() {
        return DEFAULT_INSTANCE;
    }

    static void access$58700(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation, int i, int i2) {
        descriptorProtos$GeneratedCodeInfo$Annotation.setPath(i, i2);
    }

    static void access$58800(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation, int i) {
        descriptorProtos$GeneratedCodeInfo$Annotation.addPath(i);
    }

    static void access$58900(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation, java.lang.IEnumerable iterable) {
        descriptorProtos$GeneratedCodeInfo$Annotation.addAllPath(iterable);
    }

    static void access$59000(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        descriptorProtos$GeneratedCodeInfo$Annotation.clearPath();
    }

    static void access$59100(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation, java.lang.string str) {
        descriptorProtos$GeneratedCodeInfo$Annotation.setSourcestring(str);
    }

    static void access$59200(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        descriptorProtos$GeneratedCodeInfo$Annotation.clearSourcestring();
    }

    static void access$59300(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$GeneratedCodeInfo$Annotation.setSourcestringbytes(bytestring);
    }

    static void access$59400(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation, int i) {
        descriptorProtos$GeneratedCodeInfo$Annotation.setBegin(i);
    }

    static void access$59500(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        descriptorProtos$GeneratedCodeInfo$Annotation.clearBegin();
    }

    static void access$59600(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation, int i) {
        descriptorProtos$GeneratedCodeInfo$Annotation.setEnd(i);
    }

    static void access$59700(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        descriptorProtos$GeneratedCodeInfo$Annotation.clearEnd();
    }

    static void access$59800(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation, androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic descriptorProtos$GeneratedCodeInfo$Annotation$Semantic) {
        descriptorProtos$GeneratedCodeInfo$Annotation.setSemantic(descriptorProtos$GeneratedCodeInfo$Annotation$Semantic);
    }

    static void access$59900(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        descriptorProtos$GeneratedCodeInfo$Annotation.clearSemantic();
    }

    private void AddAllPath(java.lang.IEnumerable<? : java.lang.int> iterable) {
        ensurePathIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.path_);
    }

    private void AddPath(int i) {
        ensurePathIsMutable();
        this.path_.addInt(i);
    }

    private void ClearBegin() {
        this.bitField0_ &= -3;
        this.begin_ = 0;
    }

    private void ClearEnd() {
        this.bitField0_ &= -5;
        this.end_ = 0;
    }

    private void ClearPath() {
        this.path_ = emptyIntList();
    }

    private void ClearSemantic() {
        this.bitField0_ &= -9;
        this.semantic_ = 0;
    }

    private void ClearSourcestring() {
        this.bitField0_ &= -2;
        this.sourcestring_ = getDefaultInstance().getSourcestring();
    }

    private void EnsurePathIsMutable() {
        if ((7 + 22) % 22 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$IntList internal$IntList = this.path_;
        if (internal$IntList.isModifiable()) {
            return;
        }
        this.path_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$IntList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation descriptorProtos$GeneratedCodeInfo$Annotation) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$GeneratedCodeInfo$Annotation);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetBegin(int i) {
        this.bitField0_ |= 2;
        this.begin_ = i;
    }

    private void SetEnd(int i) {
        this.bitField0_ |= 4;
        this.end_ = i;
    }

    private void SetPath(int i, int i2) {
        ensurePathIsMutable();
        this.path_.setInt(i, i2);
    }

    private void SetSemantic(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic descriptorProtos$GeneratedCodeInfo$Annotation$Semantic) {
        this.semantic_ = descriptorProtos$GeneratedCodeInfo$Annotation$Semantic.getNumber();
        this.bitField0_ |= 8;
    }

    private void SetSourcestring(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 1;
        this.sourcestring_ = str;
    }

    private void SetSourcestringbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.sourcestring_ = bytestring.tostringUtf8();
        this.bitField0_ |= 1;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((4 + 12) % 12 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0005\u0000\u0001\u0001\u0005\u0005\u0000\u0001\u0000\u0001'\u0002ဈ\u0000\u0003င\u0001\u0004င\u0002\u0005᠌\u0003", new java.lang.object[]{"bitField0_", "path_", "sourcestring_", "begin_", "end_", "semantic_", androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic.internalGetVerifier()});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation.class) {
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

    public override int GetBegin() {
        return this.begin_;
    }

    public override int GetEnd() {
        return this.end_;
    }

    public override int GetPath(int i) {
        return this.path_.getInt(i);
    }

    public override int GetPathCount() {
        return this.path_.Count;
    }

    public override java.util.List<java.lang.int> GetPathList() {
        return this.path_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic getSemantic() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic descriptorProtos$GeneratedCodeInfo$Annotation$SemanticForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic.forNumber(this.semantic_);
        return descriptorProtos$GeneratedCodeInfo$Annotation$SemanticForNumber is not null ? descriptorProtos$GeneratedCodeInfo$Annotation$SemanticForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic.NONE;
    }

    public override java.lang.string GetSourcestring() {
        return this.sourcestring_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetSourcestringbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.sourcestring_);
    }

    public override bool HasBegin() {
        return (this.bitField0_ & 2) != 0;
    }

    public override bool HasEnd() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasSemantic() {
        return (this.bitField0_ & 8) != 0;
    }

    public override bool HasSourcestring() {
        return (this.bitField0_ & 1) != 0;
    }
}

