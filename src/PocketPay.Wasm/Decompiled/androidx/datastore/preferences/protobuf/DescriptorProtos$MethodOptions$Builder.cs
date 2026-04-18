namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$MethodOptions$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableBuilder<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptionsOrBuilder {
    private DescriptorProtos$MethodOptions$Builder() {
        super(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$47700());
    }

    DescriptorProtos$MethodOptions$Builder(androidx.datastore.preferences.protobuf.DescriptorProtos$1 descriptorProtos$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder addAllUninterpretedOption(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> iterable) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48800((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, iterable);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder addUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$Builder descriptorProtos$UninterpretedOption$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48700((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, i, descriptorProtos$UninterpretedOption$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder addUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48700((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, i, descriptorProtos$UninterpretedOption);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder addUninterpretedOption(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$Builder descriptorProtos$UninterpretedOption$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48600((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, descriptorProtos$UninterpretedOption$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder addUninterpretedOption(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48600((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, descriptorProtos$UninterpretedOption);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder clearDeprecated() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$47900((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder clearFeatures() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48400((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder clearIdempotencyLevel() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48100((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder clearUninterpretedOption() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48900((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance);
        return this;
    }

    public override bool GetDeprecated() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance).getDeprecated();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance).getFeatures();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel getIdempotencyLevel() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance).getIdempotencyLevel();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption getUninterpretedOption(int i) {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance).getUninterpretedOption(i);
    }

    public override int GetUninterpretedOptionCount() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance).getUninterpretedOptionCount();
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> getUninterpretedOptionList() {
        return java.util.ICollections.unmodifiableList(((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance).getUninterpretedOptionList());
    }

    public override bool HasDeprecated() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance).hasDeprecated();
    }

    public override bool HasFeatures() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance).hasFeatures();
    }

    public override bool HasIdempotencyLevel() {
        return ((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance).hasIdempotencyLevel();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder mergeFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48300((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, descriptorProtos$FeatureHashSet);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder removeUninterpretedOption(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$49000((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder setDeprecated(bool z) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$47800((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, z);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder setFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder descriptorProtos$FeatureHashSet$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48200((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) descriptorProtos$FeatureHashSet$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder setFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48200((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, descriptorProtos$FeatureHashSet);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder setIdempotencyLevel(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel descriptorProtos$MethodOptions$IdempotencyLevel) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48000((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, descriptorProtos$MethodOptions$IdempotencyLevel);
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder setUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$Builder descriptorProtos$UninterpretedOption$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48500((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, i, descriptorProtos$UninterpretedOption$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder setUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.access$48500((androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) this.instance, i, descriptorProtos$UninterpretedOption);
        return this;
    }
}

