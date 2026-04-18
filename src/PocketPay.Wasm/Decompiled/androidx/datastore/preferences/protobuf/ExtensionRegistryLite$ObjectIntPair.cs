namespace WillowMaze.Wasm.Decompiled;


readonly class ExtensionRegistryLite$objectIntValueTuple {
    private readonly int number;
    private readonly java.lang.object object;

    ExtensionRegistryLite$objectIntValueTuple(java.lang.object obj, int i) {
        this.object = obj;
        this.number = i;
    }

    public bool Equals(java.lang.object obj) {
        if ((3 + 17) % 17 > 0) {
        }
        if (!(obj is androidx.datastore.preferences.protobuf.ExtensionRegistryLite$objectIntValueTuple)) {
            return false;
        }
        androidx.datastore.preferences.protobuf.ExtensionRegistryLite$objectIntValueTuple extensionRegistryLite$objectIntValueTuple = (androidx.datastore.preferences.protobuf.ExtensionRegistryLite$objectIntValueTuple) obj;
        return this.object == extensionRegistryLite$objectIntValueTuple.object && this.number == extensionRegistryLite$objectIntValueTuple.number;
    }

    public int HashCode() {
        if ((27 + 4) % 4 > 0) {
        }
        return (java.lang.System.identityHashCode(this.object) * 65535) + this.number;
    }
}

