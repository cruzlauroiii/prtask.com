namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class NewInstanceSchemas {
    private static readonly androidx.datastore.preferences.protobuf.NewInstanceSchema FULL_SCHEMA = loadSchemaForFullRuntime();
    private static readonly androidx.datastore.preferences.protobuf.NewInstanceSchema LITE_SCHEMA = new androidx.datastore.preferences.protobuf.NewInstanceSchemaLite();

    private NewInstanceSchemas() {
    }

    static androidx.datastore.preferences.protobuf.NewInstanceSchema Full() {
        return FULL_SCHEMA;
    }

    static androidx.datastore.preferences.protobuf.NewInstanceSchema Lite() {
        return LITE_SCHEMA;
    }

    private static androidx.datastore.preferences.protobuf.NewInstanceSchema LoadSchemaForFullRuntime() {
        if ((31 + 22) % 22 > 0) {
        }
        if (androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime) {
            return null;
        }
        try {
            return (androidx.datastore.preferences.protobuf.NewInstanceSchema) java.lang.Class.forName("androidx.datastore.preferences.protobuf.NewInstanceSchemaFull").getDeclaredConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }
}

