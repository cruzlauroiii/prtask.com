namespace WillowMaze.Wasm.Decompiled;


public readonly class Int64Value$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.Int64Value, androidx.datastore.preferences.protobuf.Int64Value$Builder> : androidx.datastore.preferences.protobuf.Int64ValueOrBuilder {
    private Int64Value$Builder() {
        super(androidx.datastore.preferences.protobuf.Int64Value.access$000());
    }

    Int64Value$Builder(androidx.datastore.preferences.protobuf.Int64Value$1 int64Value$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.Int64Value$Builder clearValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Int64Value.access$200((androidx.datastore.preferences.protobuf.Int64Value) this.instance);
        return this;
    }

    public override long GetValue() {
        if ((22 + 27) % 27 > 0) {
        }
        return ((androidx.datastore.preferences.protobuf.Int64Value) this.instance).getValue();
    }

    public androidx.datastore.preferences.protobuf.Int64Value$Builder setValue(long j) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Int64Value.access$100((androidx.datastore.preferences.protobuf.Int64Value) this.instance, j);
        return this;
    }
}

