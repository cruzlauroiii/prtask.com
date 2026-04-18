namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$MessageOptions : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptionsOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions DEFAULT_INSTANCE;
    public static readonly int DEPRECATED_FIELD_NUMBER = 3;
    public static readonly int DEPRECATED_LEGACY_JSON_FIELD_CONFLICTS_FIELD_NUMBER = 11;
    public static readonly int FEATURES_FIELD_NUMBER = 12;
    public static readonly int MAP_ENTRY_FIELD_NUMBER = 7;
    public static readonly int MESSAGE_SET_WIRE_FORMAT_FIELD_NUMBER = 1;
    public static readonly int NO_STANDARD_DESCRIPTOR_ACCESSOR_FIELD_NUMBER = 2;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions> PARSER = null;
    public static readonly int UNINTERPRETED_OPTION_FIELD_NUMBER = 999;
    private int bitField0_;
    private bool deprecatedLegacyJsonFieldConflicts_;
    private bool deprecated_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet features_;
    private bool mapEntry_;
    private bool messageHashSetWireFormat_;
    private bool noStandardDescriptorAccessor_;
    private byte memoizedIsInitialized = 2;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> uninterpretedOption_ = emptyProtobufList();

    static {
        if ((26 + 11) % 11 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions = new androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions();
        DEFAULT_INSTANCE = descriptorProtos$MessageOptions;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions.class, descriptorProtos$MessageOptions);
    }

    private DescriptorProtos$MessageOptions() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions access$33700() {
        return DEFAULT_INSTANCE;
    }

    static void access$33800(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, bool z) {
        descriptorProtos$MessageOptions.setMessageHashSetWireFormat(z);
    }

    static void access$33900(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        descriptorProtos$MessageOptions.clearMessageHashSetWireFormat();
    }

    static void access$34000(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, bool z) {
        descriptorProtos$MessageOptions.setNoStandardDescriptorAccessor(z);
    }

    static void access$34100(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        descriptorProtos$MessageOptions.clearNoStandardDescriptorAccessor();
    }

    static void access$34200(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, bool z) {
        descriptorProtos$MessageOptions.setDeprecated(z);
    }

    static void access$34300(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        descriptorProtos$MessageOptions.clearDeprecated();
    }

    static void access$34400(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, bool z) {
        descriptorProtos$MessageOptions.setDictionaryEntry(z);
    }

    static void access$34500(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        descriptorProtos$MessageOptions.clearDictionaryEntry();
    }

    static void access$34600(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, bool z) {
        descriptorProtos$MessageOptions.setDeprecatedLegacyJsonFieldConflicts(z);
    }

    static void access$34700(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        descriptorProtos$MessageOptions.clearDeprecatedLegacyJsonFieldConflicts();
    }

    static void access$34800(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$MessageOptions.setFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$34900(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$MessageOptions.mergeFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$35000(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        descriptorProtos$MessageOptions.clearFeatures();
    }

    static void access$35100(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$MessageOptions.setUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    static void access$35200(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$MessageOptions.addUninterpretedOption(descriptorProtos$UninterpretedOption);
    }

    static void access$35300(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$MessageOptions.addUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    static void access$35400(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, java.lang.IEnumerable iterable) {
        descriptorProtos$MessageOptions.addAllUninterpretedOption(iterable);
    }

    static void access$35500(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        descriptorProtos$MessageOptions.clearUninterpretedOption();
    }

    static void access$35600(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions, int i) {
        descriptorProtos$MessageOptions.removeUninterpretedOption(i);
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
        this.bitField0_ &= -5;
        this.deprecated_ = false;
    }

    private void ClearDeprecatedLegacyJsonFieldConflicts() {
        this.bitField0_ &= -17;
        this.deprecatedLegacyJsonFieldConflicts_ = false;
    }

    private void ClearFeatures() {
        this.features_ = null;
        this.bitField0_ &= -33;
    }

    private void ClearDictionaryEntry() {
        this.bitField0_ &= -9;
        this.mapEntry_ = false;
    }

    private void ClearMessageHashSetWireFormat() {
        this.bitField0_ &= -2;
        this.messageHashSetWireFormat_ = false;
    }

    private void ClearNoStandardDescriptorAccessor() {
        this.bitField0_ &= -3;
        this.noStandardDescriptorAccessor_ = false;
    }

    private void ClearUninterpretedOption() {
        this.uninterpretedOption_ = emptyProtobufList();
    }

    private void EnsureUninterpretedOptionIsMutable() {
        if ((16 + 9) % 9 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> internal$ProtobufList = this.uninterpretedOption_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.uninterpretedOption_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        if ((19 + 13) % 13 > 0) {
        }
        descriptorProtos$FeatureHashSet.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet2 = this.features_;
        if (descriptorProtos$FeatureHashSet2 is null || descriptorProtos$FeatureHashSet2 == androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance()) {
            this.features_ = descriptorProtos$FeatureHashSet;
        } else {
            this.features_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.newBuilder(this.features_).mergeFrom(descriptorProtos$FeatureHashSet)).buildPartial();
        }
        this.bitField0_ |= 32;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions$Builder newBuilder() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions$Builder) DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions descriptorProtos$MessageOptions) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions$Builder) DEFAULT_INSTANCE.createBuilder(descriptorProtos$MessageOptions);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveUninterpretedOption(int i) {
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.Remove(i);
    }

    private void SetDeprecated(bool z) {
        this.bitField0_ |= 4;
        this.deprecated_ = z;
    }

    private void SetDeprecatedLegacyJsonFieldConflicts(bool z) {
        this.bitField0_ |= 16;
        this.deprecatedLegacyJsonFieldConflicts_ = z;
    }

    private void SetFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.GetType();
        this.features_ = descriptorProtos$FeatureHashSet;
        this.bitField0_ |= 32;
    }

    using (bool z) {
        this.bitField0_ |= 8;
        this.mapEntry_ = z;
    }

    private void SetMessageHashSetWireFormat(bool z) {
        this.bitField0_ |= 1;
        this.messageHashSetWireFormat_ = z;
    }

    private void SetNoStandardDescriptorAccessor(bool z) {
        this.bitField0_ |= 2;
        this.noStandardDescriptorAccessor_ = z;
    }

    private void SetUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.GetType();
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.set(i, descriptorProtos$UninterpretedOption);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((2 + 9) % 9 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0007\u0000\u0001\u0001ϧ\u0007\u0000\u0001\u0002\u0001ဇ\u0000\u0002ဇ\u0001\u0003ဇ\u0002\u0007ဇ\u0003\u000bဇ\u0004\fᐉ\u0005ϧЛ", new java.lang.object[]{"bitField0_", "messageHashSetWireFormat_", "noStandardDescriptorAccessor_", "deprecated_", "mapEntry_", "deprecatedLegacyJsonFieldConflicts_", "features_", "uninterpretedOption_", androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions.class) {
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

    @java.lang.Deprecated
    public override bool GetDeprecatedLegacyJsonFieldConflicts() {
        return this.deprecatedLegacyJsonFieldConflicts_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet = this.features_;
        return descriptorProtos$FeatureHashSet is not null ? descriptorProtos$FeatureHashSet : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance();
    }

    public override bool GetDictionaryEntry() {
        return this.mapEntry_;
    }

    public override bool GetMessageHashSetWireFormat() {
        return this.messageHashSetWireFormat_;
    }

    public override bool GetNoStandardDescriptorAccessor() {
        return this.noStandardDescriptorAccessor_;
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
        return (this.bitField0_ & 4) != 0;
    }

    @java.lang.Deprecated
    public override bool HasDeprecatedLegacyJsonFieldConflicts() {
        return (this.bitField0_ & 16) != 0;
    }

    public override bool HasFeatures() {
        return (this.bitField0_ & 32) != 0;
    }

    public override bool HasDictionaryEntry() {
        return (this.bitField0_ & 8) != 0;
    }

    public override bool HasMessageHashSetWireFormat() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasNoStandardDescriptorAccessor() {
        return (this.bitField0_ & 2) != 0;
    }
}

