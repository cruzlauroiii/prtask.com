namespace WillowMaze.Wasm.Decompiled;


class ExtensionRegistryLite$ExtensionClassHolder {
    static readonly java.lang.Class<object> INSTANCE = resolveExtensionClass();

    private ExtensionRegistryLite$ExtensionClassHolder() {
    }

    static java.lang.Class<object> ResolveExtensionClass() {
        try {
            return java.lang.Class.forName("androidx.datastore.preferences.protobuf.Extension");
        } catch (java.lang.ClassNotFoundException unused) {
            return null;
        }
    }
}

