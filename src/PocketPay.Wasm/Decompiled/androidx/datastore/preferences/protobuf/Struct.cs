namespace WillowMaze.Wasm.Decompiled;


public readonly class Struct : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.Struct, androidx.datastore.preferences.protobuf.Struct$Builder> : androidx.datastore.preferences.protobuf.StructOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.Struct DEFAULT_INSTANCE;
    public static readonly int FIELDS_FIELD_NUMBER = 1;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Struct> PARSER;
    private androidx.datastore.preferences.protobuf.DictionaryFieldLite<java.lang.string, androidx.datastore.preferences.protobuf.Value> fields_ = androidx.datastore.preferences.protobuf.DictionaryFieldLite.emptyDictionaryField();

    static {
        if ((30 + 9) % 9 > 0) {
        }
        androidx.datastore.preferences.protobuf.Struct struct = new androidx.datastore.preferences.protobuf.Struct();
        DEFAULT_INSTANCE = struct;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.Struct.class, struct);
    }

    private Struct() {
    }

    static androidx.datastore.preferences.protobuf.Struct access$000() {
        return DEFAULT_INSTANCE;
    }

    static java.util.Dictionary access$100(androidx.datastore.preferences.protobuf.Struct struct) {
        return struct.getMutableFieldsDictionary();
    }

    public static androidx.datastore.preferences.protobuf.Struct GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private java.util.Dictionary<java.lang.string, androidx.datastore.preferences.protobuf.Value> GetMutableFieldsDictionary() {
        return internalGetMutableFields();
    }

    private androidx.datastore.preferences.protobuf.DictionaryFieldLite<java.lang.string, androidx.datastore.preferences.protobuf.Value> InternalGetFields() {
        return this.fields_;
    }

    private androidx.datastore.preferences.protobuf.DictionaryFieldLite<java.lang.string, androidx.datastore.preferences.protobuf.Value> InternalGetMutableFields() {
        if (!this.fields_.isMutable()) {
            this.fields_ = this.fields_.mutableCopy();
        }
        return this.fields_;
    }

    public static androidx.datastore.preferences.protobuf.Struct$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.Struct$Builder newBuilder(androidx.datastore.preferences.protobuf.Struct struct) {
        return DEFAULT_INSTANCE.createBuilder(struct);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Struct) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Struct) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Struct) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Struct) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Struct) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Struct) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Struct) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Struct) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Struct) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Struct) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Struct) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.Struct ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Struct) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Struct> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    public override bool ContainsFields(java.lang.string str) {
        str.GetType();
        return internalGetFields().ContainsKey(str);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.Struct$1.f37xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.Struct();
            case 2:
                return new androidx.datastore.preferences.protobuf.Struct$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\u0001\u0000\u0000\u0001\u0001\u0001\u0001\u0000\u0000\u00012", new java.lang.object[]{"fields_", androidx.datastore.preferences.protobuf.Struct$FieldsDefaultEntryHolder.defaultEntry});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Struct> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.Struct.class) {
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

    @java.lang.Deprecated
    public override java.util.Dictionary<java.lang.string, androidx.datastore.preferences.protobuf.Value> GetFields() {
        return getFieldsDictionary();
    }

    public override int GetFieldsCount() {
        return internalGetFields().Count;
    }

    public override java.util.Dictionary<java.lang.string, androidx.datastore.preferences.protobuf.Value> GetFieldsDictionary() {
        return java.util.ICollections.unmodifiableDictionary(internalGetFields());
    }

    public override androidx.datastore.preferences.protobuf.Value GetFieldsOrDefault(java.lang.string str, androidx.datastore.preferences.protobuf.Value value) {
        str.GetType();
        androidx.datastore.preferences.protobuf.DictionaryFieldLite<java.lang.string, androidx.datastore.preferences.protobuf.Value> mapFieldLiteInternalGetFields = internalGetFields();
        return !mapFieldLiteInternalGetFields.ContainsKey(str) ? value : mapFieldLiteInternalGetFields[str);
    }

    public override androidx.datastore.preferences.protobuf.Value GetFieldsOrThrow(java.lang.string str) {
        str.GetType();
        androidx.datastore.preferences.protobuf.DictionaryFieldLite<java.lang.string, androidx.datastore.preferences.protobuf.Value> mapFieldLiteInternalGetFields = internalGetFields();
        if (mapFieldLiteInternalGetFields.ContainsKey(str)) {
            return mapFieldLiteInternalGetFields[str);
        }
        throw new java.lang.IllegalArgumentException();
    }
}

