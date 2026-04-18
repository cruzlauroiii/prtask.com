namespace WillowMaze.Wasm.Decompiled;


public readonly class Value$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.Value, androidx.datastore.preferences.protobuf.Value$Builder> : androidx.datastore.preferences.protobuf.ValueOrBuilder {
    private Value$Builder() {
        super(androidx.datastore.preferences.protobuf.Value.access$000());
    }

    Value$Builder(androidx.datastore.preferences.protobuf.Value$1 value$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.Value$Builder clearBoolValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$1100((androidx.datastore.preferences.protobuf.Value) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder clearKind() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$100((androidx.datastore.preferences.protobuf.Value) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder clearListValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$1700((androidx.datastore.preferences.protobuf.Value) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder clearNullValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$400((androidx.datastore.preferences.protobuf.Value) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder clearNumberValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$600((androidx.datastore.preferences.protobuf.Value) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder clearstringValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$800((androidx.datastore.preferences.protobuf.Value) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder clearStructValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$1400((androidx.datastore.preferences.protobuf.Value) this.instance);
        return this;
    }

    public override bool GetBoolValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).getBoolValue();
    }

    public androidx.datastore.preferences.protobuf.Value$KindCase getKindCase() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).getKindCase();
    }

    public override androidx.datastore.preferences.protobuf.ListValue GetListValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).getListValue();
    }

    public override androidx.datastore.preferences.protobuf.NullValue GetNullValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).getNullValue();
    }

    public override int GetNullValueValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).getNullValueValue();
    }

    public override double GetNumberValue() {
        if ((8 + 4) % 4 > 0) {
        }
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).getNumberValue();
    }

    public override java.lang.string GetstringValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).getstringValue();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetstringValuebytes() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).getstringValuebytes();
    }

    public override androidx.datastore.preferences.protobuf.Struct GetStructValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).getStructValue();
    }

    public override bool HasBoolValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).hasBoolValue();
    }

    public override bool HasListValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).hasListValue();
    }

    public override bool HasNullValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).hasNullValue();
    }

    public override bool HasNumberValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).hasNumberValue();
    }

    public override bool HasstringValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).hasstringValue();
    }

    public override bool HasStructValue() {
        return ((androidx.datastore.preferences.protobuf.Value) this.instance).hasStructValue();
    }

    public androidx.datastore.preferences.protobuf.Value$Builder mergeListValue(androidx.datastore.preferences.protobuf.ListValue listValue) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$1600((androidx.datastore.preferences.protobuf.Value) this.instance, listValue);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder mergeStructValue(androidx.datastore.preferences.protobuf.Struct struct) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$1300((androidx.datastore.preferences.protobuf.Value) this.instance, struct);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder setBoolValue(bool z) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$1000((androidx.datastore.preferences.protobuf.Value) this.instance, z);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder setListValue(androidx.datastore.preferences.protobuf.ListValue$Builder listValue$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$1500((androidx.datastore.preferences.protobuf.Value) this.instance, listValue$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder setListValue(androidx.datastore.preferences.protobuf.ListValue listValue) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$1500((androidx.datastore.preferences.protobuf.Value) this.instance, listValue);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder setNullValue(androidx.datastore.preferences.protobuf.NullValue nullValue) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$300((androidx.datastore.preferences.protobuf.Value) this.instance, nullValue);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder setNullValueValue(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$200((androidx.datastore.preferences.protobuf.Value) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder setNumberValue(double d) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$500((androidx.datastore.preferences.protobuf.Value) this.instance, d);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder setstringValue(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$700((androidx.datastore.preferences.protobuf.Value) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder setstringValuebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$900((androidx.datastore.preferences.protobuf.Value) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder setStructValue(androidx.datastore.preferences.protobuf.Struct$Builder struct$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$1200((androidx.datastore.preferences.protobuf.Value) this.instance, struct$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Value$Builder setStructValue(androidx.datastore.preferences.protobuf.Struct struct) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Value.access$1200((androidx.datastore.preferences.protobuf.Value) this.instance, struct);
        return this;
    }
}

