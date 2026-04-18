namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$OneofDescriptorProto$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProtoOrBuilder {
    private DescriptorProtos$OneofDescriptorProto$Builder() {
        super(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto.access$19700());
    }

    DescriptorProtos$OneofDescriptorProto$Builder(androidx.datastore.preferences.protobuf.DescriptorProtos$1 descriptorProtos$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder clearName() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto.access$19900((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder clearOptions() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto.access$20300((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance);
        return this;
    }

    public override java.lang.string GetName() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance).getName();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance).getNamebytes();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions getOptions() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance).getOptions();
    }

    public override bool HasName() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance).hasName();
    }

    public override bool HasOptions() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance).hasOptions();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder mergeOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto.access$20200((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance, descriptorProtos$OneofOptions);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder setName(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto.access$19800((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder setNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto.access$20000((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder setOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions$Builder descriptorProtos$OneofOptions$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto.access$20100((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance, (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) descriptorProtos$OneofOptions$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto$Builder setOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto.access$20100((androidx.datastore.preferences.protobuf.DescriptorProtos$OneofDescriptorProto) this.instance, descriptorProtos$OneofOptions);
        return this;
    }
}

