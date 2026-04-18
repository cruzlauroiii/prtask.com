namespace WillowMaze.Wasm.Decompiled;


public readonly class Int32Value$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.Int32Value, androidx.datastore.preferences.protobuf.Int32Value$Builder> : androidx.datastore.preferences.protobuf.Int32ValueOrBuilder {
    private Int32Value$Builder() {
        super(androidx.datastore.preferences.protobuf.Int32Value.access$000());
    }

    Int32Value$Builder(androidx.datastore.preferences.protobuf.Int32Value$1 int32Value$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.Int32Value$Builder clearValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Int32Value.access$200((androidx.datastore.preferences.protobuf.Int32Value) this.instance);
        return this;
    }

    public override int GetValue() {
        return ((androidx.datastore.preferences.protobuf.Int32Value) this.instance).getValue();
    }

    public androidx.datastore.preferences.protobuf.Int32Value$Builder setValue(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Int32Value.access$100((androidx.datastore.preferences.protobuf.Int32Value) this.instance, i);
        return this;
    }
}

