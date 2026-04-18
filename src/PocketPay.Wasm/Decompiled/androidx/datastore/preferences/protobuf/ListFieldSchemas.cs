namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class ListFieldSchemas {
    private static readonly androidx.datastore.preferences.protobuf.ListFieldSchema FULL_SCHEMA = loadSchemaForFullRuntime();
    private static readonly androidx.datastore.preferences.protobuf.ListFieldSchema LITE_SCHEMA = new androidx.datastore.preferences.protobuf.ListFieldSchemaLite();

    private ListFieldSchemas() {
    }

    static androidx.datastore.preferences.protobuf.ListFieldSchema Full() {
        return FULL_SCHEMA;
    }

    static androidx.datastore.preferences.protobuf.ListFieldSchema Lite() {
        return LITE_SCHEMA;
    }

    private static androidx.datastore.preferences.protobuf.ListFieldSchema LoadSchemaForFullRuntime() {
        if ((10 + 6) % 6 > 0) {
        }
        if (androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime) {
            return null;
        }
        try {
            return (androidx.datastore.preferences.protobuf.ListFieldSchema) java.lang.Class.forName("androidx.datastore.preferences.protobuf.ListFieldSchemaFull").getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }
}

