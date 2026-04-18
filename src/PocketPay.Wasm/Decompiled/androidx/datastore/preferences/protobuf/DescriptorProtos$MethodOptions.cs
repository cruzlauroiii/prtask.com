namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$MethodOptions : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptionsOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions DEFAULT_INSTANCE;
    public static readonly int DEPRECATED_FIELD_NUMBER = 33;
    public static readonly int FEATURES_FIELD_NUMBER = 35;
    public static readonly int IDEMPOTENCY_LEVEL_FIELD_NUMBER = 34;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions> PARSER = null;
    public static readonly int UNINTERPRETED_OPTION_FIELD_NUMBER = 999;
    private int bitField0_;
    private bool deprecated_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet features_;
    private int idempotencyLevel_;
    private byte memoizedIsInitialized = 2;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> uninterpretedOption_ = emptyProtobufList();

    static {
        if ((5 + 24) % 24 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions = new androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions();
        DEFAULT_INSTANCE = descriptorProtos$MethodOptions;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.class, descriptorProtos$MethodOptions);
    }

    private DescriptorProtos$MethodOptions() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions access$47700() {
        return DEFAULT_INSTANCE;
    }

    static void access$47800(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions, bool z) {
        descriptorProtos$MethodOptions.setDeprecated(z);
    }

    static void access$47900(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions) {
        descriptorProtos$MethodOptions.clearDeprecated();
    }

    static void access$48000(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel descriptorProtos$MethodOptions$IdempotencyLevel) {
        descriptorProtos$MethodOptions.setIdempotencyLevel(descriptorProtos$MethodOptions$IdempotencyLevel);
    }

    static void access$48100(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions) {
        descriptorProtos$MethodOptions.clearIdempotencyLevel();
    }

    static void access$48200(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$MethodOptions.setFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$48300(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$MethodOptions.mergeFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$48400(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions) {
        descriptorProtos$MethodOptions.clearFeatures();
    }

    static void access$48500(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$MethodOptions.setUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    static void access$48600(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$MethodOptions.addUninterpretedOption(descriptorProtos$UninterpretedOption);
    }

    static void access$48700(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$MethodOptions.addUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    static void access$48800(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions, java.lang.IEnumerable iterable) {
        descriptorProtos$MethodOptions.addAllUninterpretedOption(iterable);
    }

    static void access$48900(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions) {
        descriptorProtos$MethodOptions.clearUninterpretedOption();
    }

    static void access$49000(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions, int i) {
        descriptorProtos$MethodOptions.removeUninterpretedOption(i);
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

    private void ClearDeprecated() {
        this.bitField0_ &= -2;
        this.deprecated_ = false;
    }

    private void ClearFeatures() {
        this.features_ = null;
        this.bitField0_ &= -5;
    }

    private void ClearIdempotencyLevel() {
        this.bitField0_ &= -3;
        this.idempotencyLevel_ = 0;
    }

    private void ClearUninterpretedOption() {
        this.uninterpretedOption_ = emptyProtobufList();
    }

    private void EnsureUninterpretedOptionIsMutable() {
        if ((24 + 13) % 13 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> internal$ProtobufList = this.uninterpretedOption_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.uninterpretedOption_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        if ((29 + 10) % 10 > 0) {
        }
        descriptorProtos$FeatureHashSet.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet2 = this.features_;
        if (descriptorProtos$FeatureHashSet2 is null || descriptorProtos$FeatureHashSet2 == androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance()) {
            this.features_ = descriptorProtos$FeatureHashSet;
        } else {
            this.features_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.newBuilder(this.features_).mergeFrom(descriptorProtos$FeatureHashSet)).buildPartial();
        }
        this.bitField0_ |= 4;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder newBuilder() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder) DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions descriptorProtos$MethodOptions) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder) DEFAULT_INSTANCE.createBuilder(descriptorProtos$MethodOptions);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveUninterpretedOption(int i) {
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.Remove(i);
    }

    private void SetDeprecated(bool z) {
        this.bitField0_ |= 1;
        this.deprecated_ = z;
    }

    private void SetFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.GetType();
        this.features_ = descriptorProtos$FeatureHashSet;
        this.bitField0_ |= 4;
    }

    private void SetIdempotencyLevel(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel descriptorProtos$MethodOptions$IdempotencyLevel) {
        this.idempotencyLevel_ = descriptorProtos$MethodOptions$IdempotencyLevel.getNumber();
        this.bitField0_ |= 2;
    }

    private void SetUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.GetType();
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.set(i, descriptorProtos$UninterpretedOption);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((3 + 22) % 22 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0004\u0000\u0001!ϧ\u0004\u0000\u0001\u0002!ဇ\u0000\"᠌\u0001#ᐉ\u0002ϧЛ", new java.lang.object[]{"bitField0_", "deprecated_", "idempotencyLevel_", androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel.internalGetVerifier(), "features_", "uninterpretedOption_", androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions.class) {
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

    public override bool GetDeprecated() {
        return this.deprecated_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet = this.features_;
        return descriptorProtos$FeatureHashSet is not null ? descriptorProtos$FeatureHashSet : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel getIdempotencyLevel() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel descriptorProtos$MethodOptions$IdempotencyLevelForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel.forNumber(this.idempotencyLevel_);
        return descriptorProtos$MethodOptions$IdempotencyLevelForNumber is not null ? descriptorProtos$MethodOptions$IdempotencyLevelForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel.IDEMPOTENCY_UNKNOWN;
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

    public override bool HasDeprecated() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasFeatures() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasIdempotencyLevel() {
        return (this.bitField0_ & 2) != 0;
    }
}

