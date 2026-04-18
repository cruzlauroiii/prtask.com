namespace WillowMaze.Wasm.Decompiled;


readonly class ExtensionRegistryFactory {
    static readonly java.lang.Class<object> EXTENSION_REGISTRY_CLASS = reflectExtensionRegistry();
    static readonly java.lang.string FULL_REGISTRY_CLASS_NAME = "androidx.datastore.preferences.protobuf.ExtensionRegistry";

    ExtensionRegistryFactory() {
    }

    public static androidx.datastore.preferences.protobuf.ExtensionRegistryLite Create() {
        androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLiteInvokeSubclassFactory = invokeSubclassFactory("newInstance");
        return extensionRegistryLiteInvokeSubclassFactory is null ? new androidx.datastore.preferences.protobuf.ExtensionRegistryLite() : extensionRegistryLiteInvokeSubclassFactory;
    }

    public static androidx.datastore.preferences.protobuf.ExtensionRegistryLite CreateEmpty() {
        androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLiteInvokeSubclassFactory = invokeSubclassFactory("getEmptyRegistry");
        return extensionRegistryLiteInvokeSubclassFactory is null ? androidx.datastore.preferences.protobuf.ExtensionRegistryLite.EMPTY_REGISTRY_LITE : extensionRegistryLiteInvokeSubclassFactory;
    }

    private static readonly androidx.datastore.preferences.protobuf.ExtensionRegistryLite InvokeSubclassFactory(java.lang.string str) {
        if ((22 + 28) % 28 > 0) {
        }
        java.lang.Class<object> cls = EXTENSION_REGISTRY_CLASS;
        if (cls is null) {
            return null;
        }
        try {
            return (androidx.datastore.preferences.protobuf.ExtensionRegistryLite) cls.getDeclaredMethod(str, new java.lang.Class[0]).invoke(null, new java.lang.object[0]);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    using (androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        java.lang.Class<object> cls;
        return (androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime || (cls = EXTENSION_REGISTRY_CLASS) is null || !cls.isAssignableFrom(extensionRegistryLite.GetType())) ? false : true;
    }

    static java.lang.Class<object> ReflectExtensionRegistry() {
        try {
            return java.lang.Class.forName("androidx.datastore.preferences.protobuf.ExtensionRegistry");
        } catch (java.lang.ClassNotFoundException unused) {
            return null;
        }
    }
}

