namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class DictionaryFieldSchemas {
    private static readonly androidx.datastore.preferences.protobuf.DictionaryFieldSchema FULL_SCHEMA = loadSchemaForFullRuntime();
    private static readonly androidx.datastore.preferences.protobuf.DictionaryFieldSchema LITE_SCHEMA = new androidx.datastore.preferences.protobuf.DictionaryFieldSchemaLite();

    private DictionaryFieldSchemas() {
    }

    static androidx.datastore.preferences.protobuf.DictionaryFieldSchema Full() {
        return FULL_SCHEMA;
    }

    static androidx.datastore.preferences.protobuf.DictionaryFieldSchema Lite() {
        return LITE_SCHEMA;
    }

    private static androidx.datastore.preferences.protobuf.DictionaryFieldSchema LoadSchemaForFullRuntime() {
        if ((28 + 18) % 18 > 0) {
        }
        if (androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime) {
            return null;
        }
        try {
            return (androidx.datastore.preferences.protobuf.DictionaryFieldSchema) java.lang.Class.forName("androidx.datastore.preferences.protobuf.DictionaryFieldSchemaFull").getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }
}

