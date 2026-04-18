namespace WillowMaze.Wasm.Decompiled;


public readonly class FieldMask : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.FieldMask, androidx.datastore.preferences.protobuf.FieldMask$Builder> : androidx.datastore.preferences.protobuf.FieldMaskOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.FieldMask DEFAULT_INSTANCE;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.FieldMask> PARSER = null;
    public static readonly int PATHS_FIELD_NUMBER = 1;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> paths_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();

    static {
        if ((8 + 9) % 9 > 0) {
        }
        androidx.datastore.preferences.protobuf.FieldMask fieldMask = new androidx.datastore.preferences.protobuf.FieldMask();
        DEFAULT_INSTANCE = fieldMask;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.FieldMask.class, fieldMask);
    }

    private FieldMask() {
    }

    static androidx.datastore.preferences.protobuf.FieldMask access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.FieldMask fieldMask, int i, java.lang.string str) {
        fieldMask.setPaths(i, str);
    }

    static void access$200(androidx.datastore.preferences.protobuf.FieldMask fieldMask, java.lang.string str) {
        fieldMask.addPaths(str);
    }

    static void access$300(androidx.datastore.preferences.protobuf.FieldMask fieldMask, java.lang.IEnumerable iterable) {
        fieldMask.addAllPaths(iterable);
    }

    static void access$400(androidx.datastore.preferences.protobuf.FieldMask fieldMask) {
        fieldMask.clearPaths();
    }

    static void access$500(androidx.datastore.preferences.protobuf.FieldMask fieldMask, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        fieldMask.addPathsbytes(bytestring);
    }

    private void AddAllPaths(java.lang.IEnumerable<java.lang.string> iterable) {
        ensurePathsIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.paths_);
    }

    private void AddPaths(java.lang.string str) {
        str.GetType();
        ensurePathsIsMutable();
        this.paths_.Add(str);
    }

    private void AddPathsbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        ensurePathsIsMutable();
        this.paths_.Add(bytestring.tostringUtf8());
    }

    private void ClearPaths() {
        this.paths_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();
    }

    private void EnsurePathsIsMutable() {
        if ((27 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> internal$ProtobufList = this.paths_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.paths_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.FieldMask$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.FieldMask$Builder newBuilder(androidx.datastore.preferences.protobuf.FieldMask fieldMask) {
        return DEFAULT_INSTANCE.createBuilder(fieldMask);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.FieldMask) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.FieldMask) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.FieldMask) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.FieldMask) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.FieldMask) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.FieldMask) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.FieldMask) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.FieldMask) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.FieldMask) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.FieldMask) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.FieldMask) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.FieldMask ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.FieldMask) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.FieldMask> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetPaths(int i, java.lang.string str) {
        str.GetType();
        ensurePathsIsMutable();
        this.paths_.set(i, str);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.FieldMask$1.f26xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.FieldMask();
            case 2:
                return new androidx.datastore.preferences.protobuf.FieldMask$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\u0001\u0000\u0000\u0001\u0001\u0001\u0000\u0001\u0000\u0001Ț", new java.lang.object[]{"paths_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.FieldMask> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.FieldMask.class) {
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

    public override java.lang.string GetPaths(int i) {
        return this.paths_[i);
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetPathsbytes(int i) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.paths_[i));
    }

    public override int GetPathsCount() {
        return this.paths_.Count;
    }

    public override java.util.List<java.lang.string> GetPathsList() {
        return this.paths_;
    }
}

