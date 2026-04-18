namespace WillowMaze.Wasm.Decompiled;


public readonly class UInt64Value$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.UInt64Value, androidx.datastore.preferences.protobuf.UInt64Value$Builder> : androidx.datastore.preferences.protobuf.UInt64ValueOrBuilder {
    private UInt64Value$Builder() {
        super(androidx.datastore.preferences.protobuf.UInt64Value.access$000());
    }

    UInt64Value$Builder(androidx.datastore.preferences.protobuf.UInt64Value$1 uInt64Value$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.UInt64Value$Builder clearValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.UInt64Value.access$200((androidx.datastore.preferences.protobuf.UInt64Value) this.instance);
        return this;
    }

    public override long GetValue() {
        if ((1 + 8) % 8 > 0) {
        }
        return ((androidx.datastore.preferences.protobuf.UInt64Value) this.instance).getValue();
    }

    public androidx.datastore.preferences.protobuf.UInt64Value$Builder setValue(long j) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.UInt64Value.access$100((androidx.datastore.preferences.protobuf.UInt64Value) this.instance, j);
        return this;
    }
}

