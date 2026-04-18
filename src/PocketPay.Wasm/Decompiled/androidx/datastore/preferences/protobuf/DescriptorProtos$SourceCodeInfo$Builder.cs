namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$SourceCodeInfo$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfoOrBuilder {
    private DescriptorProtos$SourceCodeInfo$Builder() {
        super(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.access$57800());
    }

    DescriptorProtos$SourceCodeInfo$Builder(androidx.datastore.preferences.protobuf.DescriptorProtos$1 descriptorProtos$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder addAllLocation(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location> iterable) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.access$58200((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance, iterable);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder addLocation(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location$Builder descriptorProtos$SourceCodeInfo$Location$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.access$58100((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance, i, descriptorProtos$SourceCodeInfo$Location$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder addLocation(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.access$58100((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance, i, descriptorProtos$SourceCodeInfo$Location);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder addLocation(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location$Builder descriptorProtos$SourceCodeInfo$Location$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.access$58000((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance, descriptorProtos$SourceCodeInfo$Location$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder addLocation(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.access$58000((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance, descriptorProtos$SourceCodeInfo$Location);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder clearLocation() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.access$58300((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location getLocation(int i) {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance).getLocation(i);
    }

    public override int GetLocationCount() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance).getLocationCount();
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location> getLocationList() {
        return java.util.ICollections.unmodifiableList(((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance).getLocationList());
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder removeLocation(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.access$58400((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder setLocation(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location$Builder descriptorProtos$SourceCodeInfo$Location$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.access$57900((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance, i, descriptorProtos$SourceCodeInfo$Location$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Builder setLocation(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo$Location descriptorProtos$SourceCodeInfo$Location) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.access$57900((androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo) this.instance, i, descriptorProtos$SourceCodeInfo$Location);
        return this;
    }
}

