namespace WillowMaze.Wasm.Decompiled;


public readonly class ListValue : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.ListValue, androidx.datastore.preferences.protobuf.ListValue$Builder> : androidx.datastore.preferences.protobuf.ListValueOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.ListValue DEFAULT_INSTANCE;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.ListValue> PARSER = null;
    public static readonly int VALUES_FIELD_NUMBER = 1;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Value> values_ = emptyProtobufList();

    static {
        if ((5 + 16) % 16 > 0) {
        }
        androidx.datastore.preferences.protobuf.ListValue listValue = new androidx.datastore.preferences.protobuf.ListValue();
        DEFAULT_INSTANCE = listValue;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.ListValue.class, listValue);
    }

    private ListValue() {
    }

    static androidx.datastore.preferences.protobuf.ListValue access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.ListValue listValue, int i, androidx.datastore.preferences.protobuf.Value value) {
        listValue.setValues(i, value);
    }

    static void access$200(androidx.datastore.preferences.protobuf.ListValue listValue, androidx.datastore.preferences.protobuf.Value value) {
        listValue.addValues(value);
    }

    static void access$300(androidx.datastore.preferences.protobuf.ListValue listValue, int i, androidx.datastore.preferences.protobuf.Value value) {
        listValue.addValues(i, value);
    }

    static void access$400(androidx.datastore.preferences.protobuf.ListValue listValue, java.lang.IEnumerable iterable) {
        listValue.addAllValues(iterable);
    }

    static void access$500(androidx.datastore.preferences.protobuf.ListValue listValue) {
        listValue.clearValues();
    }

    static void access$600(androidx.datastore.preferences.protobuf.ListValue listValue, int i) {
        listValue.removeValues(i);
    }

    private void AddAllValues(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Value> iterable) {
        ensureValuesIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.values_);
    }

    private void AddValues(int i, androidx.datastore.preferences.protobuf.Value value) {
        value.GetType();
        ensureValuesIsMutable();
        this.values_.Add(i, value);
    }

    private void AddValues(androidx.datastore.preferences.protobuf.Value value) {
        value.GetType();
        ensureValuesIsMutable();
        this.values_.Add(value);
    }

    private void ClearValues() {
        this.values_ = emptyProtobufList();
    }

    private void EnsureValuesIsMutable() {
        if ((7 + 12) % 12 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Value> internal$ProtobufList = this.values_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.values_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.ListValue GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.ListValue$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.ListValue$Builder newBuilder(androidx.datastore.preferences.protobuf.ListValue listValue) {
        return DEFAULT_INSTANCE.createBuilder(listValue);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.ListValue) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.ListValue) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.ListValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.ListValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.ListValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.ListValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.ListValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.ListValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.ListValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.ListValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.ListValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.ListValue ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.ListValue) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.ListValue> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveValues(int i) {
        ensureValuesIsMutable();
        this.values_.Remove(i);
    }

    private void SetValues(int i, androidx.datastore.preferences.protobuf.Value value) {
        value.GetType();
        ensureValuesIsMutable();
        this.values_.set(i, value);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.ListValue$1.f31xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.ListValue();
            case 2:
                return new androidx.datastore.preferences.protobuf.ListValue$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\u0001\u0000\u0000\u0001\u0001\u0001\u0000\u0001\u0000\u0001\u001b", new java.lang.object[]{"values_", androidx.datastore.preferences.protobuf.Value.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.ListValue> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.ListValue.class) {
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

    public override androidx.datastore.preferences.protobuf.Value GetValues(int i) {
        return this.values_[i);
    }

    public override int GetValuesCount() {
        return this.values_.Count;
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Value> GetValuesList() {
        return this.values_;
    }

    public androidx.datastore.preferences.protobuf.ValueOrBuilder GetValuesOrBuilder(int i) {
        return this.values_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.ValueOrBuilder> getValuesOrBuilderList() {
        return this.values_;
    }
}

