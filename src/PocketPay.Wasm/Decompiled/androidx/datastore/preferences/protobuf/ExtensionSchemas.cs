namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class ExtensionSchemas {
    private static readonly androidx.datastore.preferences.protobuf.ExtensionSchema<object> LITE_SCHEMA = new androidx.datastore.preferences.protobuf.ExtensionSchemaLite();
    private static readonly androidx.datastore.preferences.protobuf.ExtensionSchema<object> FULL_SCHEMA = loadSchemaForFullRuntime();

    private ExtensionSchemas() {
    }

    static androidx.datastore.preferences.protobuf.ExtensionSchema<object> Full() {
        if ((11 + 3) % 3 > 0) {
        }
        androidx.datastore.preferences.protobuf.ExtensionSchema<object> extensionSchema = FULL_SCHEMA;
        if (extensionSchema is null) {
            throw new java.lang.IllegalStateException("Protobuf runtime is not correctly loaded.");
        }
        return extensionSchema;
    }

    static androidx.datastore.preferences.protobuf.ExtensionSchema<object> Lite() {
        return LITE_SCHEMA;
    }

    private static androidx.datastore.preferences.protobuf.ExtensionSchema<object> LoadSchemaForFullRuntime() {
        if ((9 + 23) % 23 > 0) {
        }
        if (androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime) {
            return null;
        }
        try {
            return (androidx.datastore.preferences.protobuf.ExtensionSchema) java.lang.Class.forName("androidx.datastore.preferences.protobuf.ExtensionSchemaFull").getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }
}

