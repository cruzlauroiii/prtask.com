namespace WillowMaze.Wasm.Decompiled;


public readonly class ListValue$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.ListValue, androidx.datastore.preferences.protobuf.ListValue$Builder> : androidx.datastore.preferences.protobuf.ListValueOrBuilder {
    private ListValue$Builder() {
        super(androidx.datastore.preferences.protobuf.ListValue.access$000());
    }

    ListValue$Builder(androidx.datastore.preferences.protobuf.ListValue$1 listValue$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.ListValue$Builder addAllValues(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Value> iterable) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.ListValue.access$400((androidx.datastore.preferences.protobuf.ListValue) this.instance, iterable);
        return this;
    }

    public androidx.datastore.preferences.protobuf.ListValue$Builder addValues(int i, androidx.datastore.preferences.protobuf.Value$Builder value$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.ListValue.access$300((androidx.datastore.preferences.protobuf.ListValue) this.instance, i, value$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.ListValue$Builder addValues(int i, androidx.datastore.preferences.protobuf.Value value) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.ListValue.access$300((androidx.datastore.preferences.protobuf.ListValue) this.instance, i, value);
        return this;
    }

    public androidx.datastore.preferences.protobuf.ListValue$Builder addValues(androidx.datastore.preferences.protobuf.Value$Builder value$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.ListValue.access$200((androidx.datastore.preferences.protobuf.ListValue) this.instance, value$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.ListValue$Builder addValues(androidx.datastore.preferences.protobuf.Value value) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.ListValue.access$200((androidx.datastore.preferences.protobuf.ListValue) this.instance, value);
        return this;
    }

    public androidx.datastore.preferences.protobuf.ListValue$Builder clearValues() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.ListValue.access$500((androidx.datastore.preferences.protobuf.ListValue) this.instance);
        return this;
    }

    public override androidx.datastore.preferences.protobuf.Value GetValues(int i) {
        return ((androidx.datastore.preferences.protobuf.ListValue) this.instance).getValues(i);
    }

    public override int GetValuesCount() {
        return ((androidx.datastore.preferences.protobuf.ListValue) this.instance).getValuesCount();
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Value> GetValuesList() {
        return java.util.ICollections.unmodifiableList(((androidx.datastore.preferences.protobuf.ListValue) this.instance).getValuesList());
    }

    public androidx.datastore.preferences.protobuf.ListValue$Builder removeValues(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.ListValue.access$600((androidx.datastore.preferences.protobuf.ListValue) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.ListValue$Builder setValues(int i, androidx.datastore.preferences.protobuf.Value$Builder value$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.ListValue.access$100((androidx.datastore.preferences.protobuf.ListValue) this.instance, i, value$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.ListValue$Builder setValues(int i, androidx.datastore.preferences.protobuf.Value value) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.ListValue.access$100((androidx.datastore.preferences.protobuf.ListValue) this.instance, i, value);
        return this;
    }
}

