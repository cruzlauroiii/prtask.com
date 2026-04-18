namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$SourceCodeInfo$Location : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$LocationOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location DEFAULT_INSTANCE;
    public static readonly int LEADING_COMMENTS_FIELD_NUMBER = 3;
    public static readonly int LEADING_DETACHED_COMMENTS_FIELD_NUMBER = 6;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location> PARSER = null;
    public static readonly int PATH_FIELD_NUMBER = 1;
    public static readonly int SPAN_FIELD_NUMBER = 2;
    public static readonly int TRAILING_COMMENTS_FIELD_NUMBER = 4;
    private int bitField0_;
    private int pathMemoizedSerializedSize = -1;
    private int spanMemoizedSerializedSize = -1;
    private androidx.datastore.preferences.protobuf.Internal$IntList path_ = emptyIntList();
    private androidx.datastore.preferences.protobuf.Internal$IntList span_ = emptyIntList();
    private java.lang.string leadingComments_ = "";
    private java.lang.string trailingComments_ = "";
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> leadingDetachedComments_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();

    static {
        if ((19 + 11) % 11 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location = new androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location();
        DEFAULT_INSTANCE = descriptorProtos$SourceCodeInfo$Location;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location.class, descriptorProtos$SourceCodeInfo$Location);
    }

    private DescriptorProtos$SourceCodeInfo$Location() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location access$55700() {
        return DEFAULT_INSTANCE;
    }

    static void access$55800(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, int i, int i2) {
        descriptorProtos$SourceCodeInfo$Location.setPath(i, i2);
    }

    static void access$55900(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, int i) {
        descriptorProtos$SourceCodeInfo$Location.addPath(i);
    }

    static void access$56000(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, java.lang.IEnumerable iterable) {
        descriptorProtos$SourceCodeInfo$Location.addAllPath(iterable);
    }

    static void access$56100(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        descriptorProtos$SourceCodeInfo$Location.clearPath();
    }

    static void access$56200(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, int i, int i2) {
        descriptorProtos$SourceCodeInfo$Location.setSpan(i, i2);
    }

    static void access$56300(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, int i) {
        descriptorProtos$SourceCodeInfo$Location.addSpan(i);
    }

    static void access$56400(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, java.lang.IEnumerable iterable) {
        descriptorProtos$SourceCodeInfo$Location.addAllSpan(iterable);
    }

    static void access$56500(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        descriptorProtos$SourceCodeInfo$Location.clearSpan();
    }

    static void access$56600(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, java.lang.string str) {
        descriptorProtos$SourceCodeInfo$Location.setLeadingComments(str);
    }

    static void access$56700(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        descriptorProtos$SourceCodeInfo$Location.clearLeadingComments();
    }

    static void access$56800(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$SourceCodeInfo$Location.setLeadingCommentsbytes(bytestring);
    }

    static void access$56900(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, java.lang.string str) {
        descriptorProtos$SourceCodeInfo$Location.setTrailingComments(str);
    }

    static void access$57000(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        descriptorProtos$SourceCodeInfo$Location.clearTrailingComments();
    }

    static void access$57100(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$SourceCodeInfo$Location.setTrailingCommentsbytes(bytestring);
    }

    static void access$57200(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, int i, java.lang.string str) {
        descriptorProtos$SourceCodeInfo$Location.setLeadingDetachedComments(i, str);
    }

    static void access$57300(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, java.lang.string str) {
        descriptorProtos$SourceCodeInfo$Location.addLeadingDetachedComments(str);
    }

    static void access$57400(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, java.lang.IEnumerable iterable) {
        descriptorProtos$SourceCodeInfo$Location.addAllLeadingDetachedComments(iterable);
    }

    static void access$57500(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        descriptorProtos$SourceCodeInfo$Location.clearLeadingDetachedComments();
    }

    static void access$57600(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$SourceCodeInfo$Location.addLeadingDetachedCommentsbytes(bytestring);
    }

    private void AddAllLeadingDetachedComments(java.lang.IEnumerable<java.lang.string> iterable) {
        ensureLeadingDetachedCommentsIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.leadingDetachedComments_);
    }

    private void AddAllPath(java.lang.IEnumerable<? : java.lang.int> iterable) {
        ensurePathIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.path_);
    }

    private void AddAllSpan(java.lang.IEnumerable<? : java.lang.int> iterable) {
        ensureSpanIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.span_);
    }

    private void AddLeadingDetachedComments(java.lang.string str) {
        str.GetType();
        ensureLeadingDetachedCommentsIsMutable();
        this.leadingDetachedComments_.Add(str);
    }

    private void AddLeadingDetachedCommentsbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        ensureLeadingDetachedCommentsIsMutable();
        this.leadingDetachedComments_.Add(bytestring.tostringUtf8());
    }

    private void AddPath(int i) {
        ensurePathIsMutable();
        this.path_.addInt(i);
    }

    private void AddSpan(int i) {
        ensureSpanIsMutable();
        this.span_.addInt(i);
    }

    private void ClearLeadingComments() {
        this.bitField0_ &= -2;
        this.leadingComments_ = getDefaultInstance().getLeadingComments();
    }

    private void ClearLeadingDetachedComments() {
        this.leadingDetachedComments_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();
    }

    private void ClearPath() {
        this.path_ = emptyIntList();
    }

    private void ClearSpan() {
        this.span_ = emptyIntList();
    }

    private void ClearTrailingComments() {
        this.bitField0_ &= -3;
        this.trailingComments_ = getDefaultInstance().getTrailingComments();
    }

    private void EnsureLeadingDetachedCommentsIsMutable() {
        if ((30 + 31) % 31 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> internal$ProtobufList = this.leadingDetachedComments_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.leadingDetachedComments_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    private void EnsurePathIsMutable() {
        if ((1 + 24) % 24 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$IntList internal$IntList = this.path_;
        if (internal$IntList.isModifiable()) {
            return;
        }
        this.path_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$IntList);
    }

    private void EnsureSpanIsMutable() {
        if ((28 + 13) % 13 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$IntList internal$IntList = this.span_;
        if (internal$IntList.isModifiable()) {
            return;
        }
        this.span_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$IntList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$SourceCodeInfo$Location);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetLeadingComments(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 1;
        this.leadingComments_ = str;
    }

    private void SetLeadingCommentsbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.leadingComments_ = bytestring.tostringUtf8();
        this.bitField0_ |= 1;
    }

    private void SetLeadingDetachedComments(int i, java.lang.string str) {
        str.GetType();
        ensureLeadingDetachedCommentsIsMutable();
        this.leadingDetachedComments_.set(i, str);
    }

    private void SetPath(int i, int i2) {
        ensurePathIsMutable();
        this.path_.setInt(i, i2);
    }

    private void SetSpan(int i, int i2) {
        ensureSpanIsMutable();
        this.span_.setInt(i, i2);
    }

    private void SetTrailingComments(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 2;
        this.trailingComments_ = str;
    }

    private void SetTrailingCommentsbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.trailingComments_ = bytestring.tostringUtf8();
        this.bitField0_ |= 2;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((31 + 19) % 19 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0005\u0000\u0001\u0001\u0006\u0005\u0000\u0003\u0000\u0001'\u0002'\u0003ဈ\u0000\u0004ဈ\u0001\u0006\u001a", new java.lang.object[]{"bitField0_", "path_", "span_", "leadingComments_", "trailingComments_", "leadingDetachedComments_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location.class) {
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

    public override java.lang.string GetLeadingComments() {
        return this.leadingComments_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetLeadingCommentsbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.leadingComments_);
    }

    public override java.lang.string GetLeadingDetachedComments(int i) {
        return this.leadingDetachedComments_[i);
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetLeadingDetachedCommentsbytes(int i) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.leadingDetachedComments_[i));
    }

    public override int GetLeadingDetachedCommentsCount() {
        return this.leadingDetachedComments_.Count;
    }

    public override java.util.List<java.lang.string> GetLeadingDetachedCommentsList() {
        return this.leadingDetachedComments_;
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

    public override int GetSpan(int i) {
        return this.span_.getInt(i);
    }

    public override int GetSpanCount() {
        return this.span_.Count;
    }

    public override java.util.List<java.lang.int> GetSpanList() {
        return this.span_;
    }

    public override java.lang.string GetTrailingComments() {
        return this.trailingComments_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetTrailingCommentsbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.trailingComments_);
    }

    public override bool HasLeadingComments() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasTrailingComments() {
        return (this.bitField0_ & 2) != 0;
    }
}

