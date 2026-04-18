namespace WillowMaze.Wasm.Decompiled;


public readonly class EnumValue$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.EnumValue, androidx.datastore.preferences.protobuf.EnumValue$Builder> : androidx.datastore.preferences.protobuf.EnumValueOrBuilder {
    private EnumValue$Builder() {
        super(androidx.datastore.preferences.protobuf.EnumValue.access$000());
    }

    EnumValue$Builder(androidx.datastore.preferences.protobuf.EnumValue$1 enumValue$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder addAllOptions(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Option> iterable) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$900((androidx.datastore.preferences.protobuf.EnumValue) this.instance, iterable);
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder addOptions(int i, androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$800((androidx.datastore.preferences.protobuf.EnumValue) this.instance, i, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder addOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$800((androidx.datastore.preferences.protobuf.EnumValue) this.instance, i, option);
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder addOptions(androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$700((androidx.datastore.preferences.protobuf.EnumValue) this.instance, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder addOptions(androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$700((androidx.datastore.preferences.protobuf.EnumValue) this.instance, option);
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder clearName() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$200((androidx.datastore.preferences.protobuf.EnumValue) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder clearNumber() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$500((androidx.datastore.preferences.protobuf.EnumValue) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder clearOptions() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$1000((androidx.datastore.preferences.protobuf.EnumValue) this.instance);
        return this;
    }

    public override java.lang.string GetName() {
        return ((androidx.datastore.preferences.protobuf.EnumValue) this.instance).getName();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return ((androidx.datastore.preferences.protobuf.EnumValue) this.instance).getNamebytes();
    }

    public override int GetNumber() {
        return ((androidx.datastore.preferences.protobuf.EnumValue) this.instance).getNumber();
    }

    public override androidx.datastore.preferences.protobuf.Option GetOptions(int i) {
        return ((androidx.datastore.preferences.protobuf.EnumValue) this.instance).getOptions(i);
    }

    public override int GetOptionsCount() {
        return ((androidx.datastore.preferences.protobuf.EnumValue) this.instance).getOptionsCount();
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Option> GetOptionsList() {
        return java.util.ICollections.unmodifiableList(((androidx.datastore.preferences.protobuf.EnumValue) this.instance).getOptionsList());
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder removeOptions(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$1100((androidx.datastore.preferences.protobuf.EnumValue) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder setName(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$100((androidx.datastore.preferences.protobuf.EnumValue) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder setNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$300((androidx.datastore.preferences.protobuf.EnumValue) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder setNumber(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$400((androidx.datastore.preferences.protobuf.EnumValue) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder setOptions(int i, androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$600((androidx.datastore.preferences.protobuf.EnumValue) this.instance, i, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.EnumValue$Builder setOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.EnumValue.access$600((androidx.datastore.preferences.protobuf.EnumValue) this.instance, i, option);
        return this;
    }
}

