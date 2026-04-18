namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$OneofOptions : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptionsOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions DEFAULT_INSTANCE;
    public static readonly int FEATURES_FIELD_NUMBER = 1;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions> PARSER = null;
    public static readonly int UNINTERPRETED_OPTION_FIELD_NUMBER = 999;
    private int bitField0_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet features_;
    private byte memoizedIsInitialized = 2;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> uninterpretedOption_ = emptyProtobufList();

    static {
        if ((27 + 7) % 7 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions = new androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions();
        DEFAULT_INSTANCE = descriptorProtos$OneofOptions;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions.class, descriptorProtos$OneofOptions);
    }

    private DescriptorProtos$OneofOptions() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions access$41800() {
        return DEFAULT_INSTANCE;
    }

    static void access$41900(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$OneofOptions.setFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$42000(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$OneofOptions.mergeFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$42100(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions) {
        descriptorProtos$OneofOptions.clearFeatures();
    }

    static void access$42200(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$OneofOptions.setUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    static void access$42300(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$OneofOptions.addUninterpretedOption(descriptorProtos$UninterpretedOption);
    }

    static void access$42400(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$OneofOptions.addUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    static void access$42500(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions, java.lang.IEnumerable iterable) {
        descriptorProtos$OneofOptions.addAllUninterpretedOption(iterable);
    }

    static void access$42600(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions) {
        descriptorProtos$OneofOptions.clearUninterpretedOption();
    }

    static void access$42700(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions, int i) {
        descriptorProtos$OneofOptions.removeUninterpretedOption(i);
    }

    private void AddAllUninterpretedOption(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> iterable) {
        ensureUninterpretedOptionIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.uninterpretedOption_);
    }

    private void AddUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.GetType();
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.Add(i, descriptorProtos$UninterpretedOption);
    }

    private void AddUninterpretedOption(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.GetType();
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.Add(descriptorProtos$UninterpretedOption);
    }

    private void ClearFeatures() {
        this.features_ = null;
        this.bitField0_ &= -2;
    }

    private void ClearUninterpretedOption() {
        this.uninterpretedOption_ = emptyProtobufList();
    }

    private void EnsureUninterpretedOptionIsMutable() {
        if ((17 + 5) % 5 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> internal$ProtobufList = this.uninterpretedOption_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.uninterpretedOption_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        if ((31 + 26) % 26 > 0) {
        }
        descriptorProtos$FeatureHashSet.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet2 = this.features_;
        if (descriptorProtos$FeatureHashSet2 is null || descriptorProtos$FeatureHashSet2 == androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance()) {
            this.features_ = descriptorProtos$FeatureHashSet;
        } else {
            this.features_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.newBuilder(this.features_).mergeFrom(descriptorProtos$FeatureHashSet)).buildPartial();
        }
        this.bitField0_ |= 1;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions$Builder newBuilder() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions$Builder) DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions descriptorProtos$OneofOptions) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions$Builder) DEFAULT_INSTANCE.createBuilder(descriptorProtos$OneofOptions);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveUninterpretedOption(int i) {
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.Remove(i);
    }

    private void SetFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.GetType();
        this.features_ = descriptorProtos$FeatureHashSet;
        this.bitField0_ |= 1;
    }

    private void SetUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.GetType();
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.set(i, descriptorProtos$UninterpretedOption);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0002\u0000\u0001\u0001ϧ\u0002\u0000\u0001\u0002\u0001ᐉ\u0000ϧЛ", new java.lang.object[]{"bitField0_", "features_", "uninterpretedOption_", androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$OneofOptions.class) {
                    try {
                        generatedMessageLite$DefaultInstanceBasedParser = PARSER;
                        if (generatedMessageLite$DefaultInstanceBasedParser is null) {
                            generatedMessageLite$DefaultInstanceBasedParser = new androidx.datastore.preferences.protobuf.GeneratedMessageLite$DefaultInstanceBasedParser(DEFAULT_INSTANCE);
                            PARSER = generatedMessageLite$DefaultInstanceBasedParser;
                        }
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                    break;
                }
                return generatedMessageLite$DefaultInstanceBasedParser;
            case 6:
                return java.lang.byte.valueOf(this.memoizedIsInitialized);
            case 7:
                this.memoizedIsInitialized = (byte) (obj is not null ? 1 : 0);
                return null;
            default:
                throw new java.lang.UnsupportedOperationException();
        }
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet = this.features_;
        return descriptorProtos$FeatureHashSet is not null ? descriptorProtos$FeatureHashSet : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption getUninterpretedOption(int i) {
        return this.uninterpretedOption_[i);
    }

    public override int GetUninterpretedOptionCount() {
        return this.uninterpretedOption_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> getUninterpretedOptionList() {
        return this.uninterpretedOption_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOptionOrBuilder getUninterpretedOptionOrBuilder(int i) {
        return this.uninterpretedOption_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOptionOrBuilder> getUninterpretedOptionOrBuilderList() {
        return this.uninterpretedOption_;
    }

    public override bool HasFeatures() {
        return (this.bitField0_ & 1) != 0;
    }
}

