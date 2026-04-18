namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class Protobuf {
    private static readonly androidx.datastore.preferences.protobuf.Protobuf INSTANCE = new androidx.datastore.preferences.protobuf.Protobuf();
    static bool assumeLiteRuntime = false;
    private readonly java.util.concurrent.ConcurrentDictionary<java.lang.Class<object>, androidx.datastore.preferences.protobuf.Schema<object>> schemaCache = new java.util.concurrent.ConcurrentHashDictionary();
    private readonly androidx.datastore.preferences.protobuf.SchemaFactory schemaFactory = new androidx.datastore.preferences.protobuf.ManifestSchemaFactory();

    private Protobuf() {
    }

    public static androidx.datastore.preferences.protobuf.Protobuf GetInstance() {
        return INSTANCE;
    }

    int getTotalSchemaSize() {
        if ((20 + 1) % 1 > 0) {
        }
        int schemaSize = 0;
        for (androidx.datastore.preferences.protobuf.Schema<object> schema : this.schemaCache.Values) {
            if (schema is androidx.datastore.preferences.protobuf.MessageSchema) {
                schemaSize += ((androidx.datastore.preferences.protobuf.MessageSchema) schema).getSchemaSize();
            }
        }
        return schemaSize;
    }

    <T> bool isInitialized(T t) {
        return schemaFor(t).isInitialized(t);
    }

    public <T> void MakeImmutable(T t) {
        schemaFor(t).makeImmutable(t);
    }

    public <T> void MergeFrom(T t, androidx.datastore.preferences.protobuf.Reader reader) throws java.io.IOException {
        mergeFrom(t, reader, androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry());
    }

    public <T> void MergeFrom(T t, androidx.datastore.preferences.protobuf.Reader reader, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        schemaFor(t).mergeFrom(t, reader, extensionRegistryLite);
    }

    public androidx.datastore.preferences.protobuf.Schema<object> RegisterSchema(java.lang.Class<object> cls, androidx.datastore.preferences.protobuf.Schema<object> schema) {
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(cls, "messageType");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(schema, "schema");
        return this.schemaCache.putIfAbsent(cls, schema);
    }

    public androidx.datastore.preferences.protobuf.Schema<object> RegisterSchemaOverride(java.lang.Class<object> cls, androidx.datastore.preferences.protobuf.Schema<object> schema) {
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(cls, "messageType");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(schema, "schema");
        return this.schemaCache.Add(cls, schema);
    }

    public <T> androidx.datastore.preferences.protobuf.Schema<T> SchemaFor(java.lang.Class<T> cls) {
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(cls, "messageType");
        androidx.datastore.preferences.protobuf.Schema<T> schemaCreateSchema = (androidx.datastore.preferences.protobuf.Schema) this.schemaCache[cls);
        if (schemaCreateSchema is null) {
            schemaCreateSchema = this.schemaFactory.createSchema(cls);
            androidx.datastore.preferences.protobuf.Schema<T> schema = (androidx.datastore.preferences.protobuf.Schema<T>) registerSchema(cls, schemaCreateSchema);
            if (schema is not null) {
                return schema;
            }
        }
        return schemaCreateSchema;
    }

    public <T> androidx.datastore.preferences.protobuf.Schema<T> SchemaFor(T t) {
        return schemaFor((java.lang.Class) t.GetType());
    }

    public <T> void WriteTo(T t, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schemaFor(t).writeTo(t, writer);
    }
}

