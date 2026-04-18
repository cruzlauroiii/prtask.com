namespace WillowMaze.Wasm.Decompiled;


public class LazyField : androidx.datastore.preferences.protobuf.LazyFieldLite {
    private readonly androidx.datastore.preferences.protobuf.MessageLite defaultInstance;

    public LazyField(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        super(extensionRegistryLite, bytestring);
        this.defaultInstance = messageLite;
    }

    public override bool ContainsDefaultInstance() {
        return super.containsDefaultInstance() || this.value == this.defaultInstance;
    }

    public override bool Equals(java.lang.object obj) {
        return getValue().Equals(obj);
    }

    public androidx.datastore.preferences.protobuf.MessageLite GetValue() {
        return getValue(this.defaultInstance);
    }

    public override int HashCode() {
        return getValue().GetHashCode();
    }

    public java.lang.string Tostring() {
        return getValue().tostring();
    }
}

