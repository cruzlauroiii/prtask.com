namespace WillowMaze.Wasm.Decompiled;


public readonly class Option$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.Option, androidx.datastore.preferences.protobuf.Option$Builder> : androidx.datastore.preferences.protobuf.OptionOrBuilder {
    private Option$Builder() {
        super(androidx.datastore.preferences.protobuf.Option.access$000());
    }

    Option$Builder(androidx.datastore.preferences.protobuf.Option$1 option$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.Option$Builder clearName() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Option.access$200((androidx.datastore.preferences.protobuf.Option) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Option$Builder clearValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Option.access$600((androidx.datastore.preferences.protobuf.Option) this.instance);
        return this;
    }

    public override java.lang.string GetName() {
        return ((androidx.datastore.preferences.protobuf.Option) this.instance).getName();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return ((androidx.datastore.preferences.protobuf.Option) this.instance).getNamebytes();
    }

    public override androidx.datastore.preferences.protobuf.Any GetValue() {
        return ((androidx.datastore.preferences.protobuf.Option) this.instance).getValue();
    }

    public override bool HasValue() {
        return ((androidx.datastore.preferences.protobuf.Option) this.instance).hasValue();
    }

    public androidx.datastore.preferences.protobuf.Option$Builder mergeValue(androidx.datastore.preferences.protobuf.Any any) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Option.access$500((androidx.datastore.preferences.protobuf.Option) this.instance, any);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Option$Builder setName(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Option.access$100((androidx.datastore.preferences.protobuf.Option) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Option$Builder setNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Option.access$300((androidx.datastore.preferences.protobuf.Option) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Option$Builder setValue(androidx.datastore.preferences.protobuf.Any$Builder any$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Option.access$400((androidx.datastore.preferences.protobuf.Option) this.instance, any$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Option$Builder setValue(androidx.datastore.preferences.protobuf.Any any) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Option.access$400((androidx.datastore.preferences.protobuf.Option) this.instance, any);
        return this;
    }
}

