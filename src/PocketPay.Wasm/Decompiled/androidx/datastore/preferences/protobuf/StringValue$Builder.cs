namespace WillowMaze.Wasm.Decompiled;


public readonly class stringValue$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.stringValue, androidx.datastore.preferences.protobuf.stringValue$Builder> : androidx.datastore.preferences.protobuf.stringValueOrBuilder {
    private stringValue$Builder() {
        super(androidx.datastore.preferences.protobuf.stringValue.access$000());
    }

    stringValue$Builder(androidx.datastore.preferences.protobuf.stringValue$1 stringValue$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.stringValue$Builder clearValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.stringValue.access$200((androidx.datastore.preferences.protobuf.stringValue) this.instance);
        return this;
    }

    public override java.lang.string GetValue() {
        return ((androidx.datastore.preferences.protobuf.stringValue) this.instance).getValue();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetValuebytes() {
        return ((androidx.datastore.preferences.protobuf.stringValue) this.instance).getValuebytes();
    }

    public androidx.datastore.preferences.protobuf.stringValue$Builder setValue(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.stringValue.access$100((androidx.datastore.preferences.protobuf.stringValue) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.stringValue$Builder setValuebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.stringValue.access$300((androidx.datastore.preferences.protobuf.stringValue) this.instance, bytestring);
        return this;
    }
}

