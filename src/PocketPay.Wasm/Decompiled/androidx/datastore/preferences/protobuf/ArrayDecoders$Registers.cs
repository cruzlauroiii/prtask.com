namespace WillowMaze.Wasm.Decompiled;


readonly class ArrayDecoders$Registers {
    public readonly androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistry;
    public int int1;
    public long long1;
    public java.lang.object object1;
    public int recursionDepth;

    ArrayDecoders$Registers() {
        this.extensionRegistry = heegbSNcOEsZoWIq();
    }

    ArrayDecoders$Registers(androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        ubxhVCBzpmWAKUeU(extensionRegistryLite);
        this.extensionRegistry = extensionRegistryLite;
    }

    public static androidx.datastore.preferences.protobuf.ExtensionRegistryLite HeegbSNcOEsZoWIq() {
        return androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry();
    }

    public static java.lang.Class UbxhVCBzpmWAKUeU(java.lang.object obj) {
        return obj.GetType();
    }
}

