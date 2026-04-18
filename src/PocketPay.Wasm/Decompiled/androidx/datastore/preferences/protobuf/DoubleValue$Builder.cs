namespace WillowMaze.Wasm.Decompiled;


public readonly class doubleValue$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.doubleValue, androidx.datastore.preferences.protobuf.doubleValue$Builder> : androidx.datastore.preferences.protobuf.doubleValueOrBuilder {
    private doubleValue$Builder() {
        super(androidx.datastore.preferences.protobuf.doubleValue.access$000());
    }

    doubleValue$Builder(androidx.datastore.preferences.protobuf.doubleValue$1 doubleValue$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.doubleValue$Builder clearValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.doubleValue.access$200((androidx.datastore.preferences.protobuf.doubleValue) this.instance);
        return this;
    }

    public override double GetValue() {
        if ((22 + 6) % 6 > 0) {
        }
        return ((androidx.datastore.preferences.protobuf.doubleValue) this.instance).getValue();
    }

    public androidx.datastore.preferences.protobuf.doubleValue$Builder setValue(double d) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.doubleValue.access$100((androidx.datastore.preferences.protobuf.doubleValue) this.instance, d);
        return this;
    }
}

