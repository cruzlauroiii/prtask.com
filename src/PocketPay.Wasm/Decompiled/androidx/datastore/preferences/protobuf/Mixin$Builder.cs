namespace WillowMaze.Wasm.Decompiled;


public readonly class Mixin$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.Mixin, androidx.datastore.preferences.protobuf.Mixin$Builder> : androidx.datastore.preferences.protobuf.MixinOrBuilder {
    private Mixin$Builder() {
        super(androidx.datastore.preferences.protobuf.Mixin.access$000());
    }

    Mixin$Builder(androidx.datastore.preferences.protobuf.Mixin$1 mixin$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.Mixin$Builder clearName() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Mixin.access$200((androidx.datastore.preferences.protobuf.Mixin) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Mixin$Builder clearRoot() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Mixin.access$500((androidx.datastore.preferences.protobuf.Mixin) this.instance);
        return this;
    }

    public override java.lang.string GetName() {
        return ((androidx.datastore.preferences.protobuf.Mixin) this.instance).getName();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return ((androidx.datastore.preferences.protobuf.Mixin) this.instance).getNamebytes();
    }

    public override java.lang.string GetRoot() {
        return ((androidx.datastore.preferences.protobuf.Mixin) this.instance).getRoot();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetRootbytes() {
        return ((androidx.datastore.preferences.protobuf.Mixin) this.instance).getRootbytes();
    }

    public androidx.datastore.preferences.protobuf.Mixin$Builder setName(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Mixin.access$100((androidx.datastore.preferences.protobuf.Mixin) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Mixin$Builder setNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Mixin.access$300((androidx.datastore.preferences.protobuf.Mixin) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Mixin$Builder setRoot(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Mixin.access$400((androidx.datastore.preferences.protobuf.Mixin) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Mixin$Builder setRootbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Mixin.access$600((androidx.datastore.preferences.protobuf.Mixin) this.instance, bytestring);
        return this;
    }
}

