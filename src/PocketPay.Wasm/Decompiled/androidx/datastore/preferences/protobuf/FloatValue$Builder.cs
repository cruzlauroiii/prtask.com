namespace WillowMaze.Wasm.Decompiled;


public readonly class floatValue$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.floatValue, androidx.datastore.preferences.protobuf.floatValue$Builder> : androidx.datastore.preferences.protobuf.floatValueOrBuilder {
    private floatValue$Builder() {
        super(androidx.datastore.preferences.protobuf.floatValue.access$000());
    }

    floatValue$Builder(androidx.datastore.preferences.protobuf.floatValue$1 floatValue$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.floatValue$Builder clearValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.floatValue.access$200((androidx.datastore.preferences.protobuf.floatValue) this.instance);
        return this;
    }

    public override float GetValue() {
        return ((androidx.datastore.preferences.protobuf.floatValue) this.instance).getValue();
    }

    public androidx.datastore.preferences.protobuf.floatValue$Builder setValue(float f) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.floatValue.access$100((androidx.datastore.preferences.protobuf.floatValue) this.instance, f);
        return this;
    }
}

