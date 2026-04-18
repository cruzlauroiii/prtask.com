namespace WillowMaze.Wasm.Decompiled;


public readonly class UInt32Value$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.UInt32Value, androidx.datastore.preferences.protobuf.UInt32Value$Builder> : androidx.datastore.preferences.protobuf.UInt32ValueOrBuilder {
    private UInt32Value$Builder() {
        super(androidx.datastore.preferences.protobuf.UInt32Value.access$000());
    }

    UInt32Value$Builder(androidx.datastore.preferences.protobuf.UInt32Value$1 uInt32Value$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.UInt32Value$Builder clearValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.UInt32Value.access$200((androidx.datastore.preferences.protobuf.UInt32Value) this.instance);
        return this;
    }

    public override int GetValue() {
        return ((androidx.datastore.preferences.protobuf.UInt32Value) this.instance).getValue();
    }

    public androidx.datastore.preferences.protobuf.UInt32Value$Builder setValue(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.UInt32Value.access$100((androidx.datastore.preferences.protobuf.UInt32Value) this.instance, i);
        return this;
    }
}

