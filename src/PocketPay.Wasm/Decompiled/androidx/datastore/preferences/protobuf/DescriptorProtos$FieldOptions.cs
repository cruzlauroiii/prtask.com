namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FieldOptions : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptionsOrBuilder {
    public static readonly int CTYPE_FIELD_NUMBER = 1;
    public static readonly int DEBUG_REDACT_FIELD_NUMBER = 16;
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions DEFAULT_INSTANCE;
    public static readonly int DEPRECATED_FIELD_NUMBER = 3;
    public static readonly int EDITION_DEFAULTS_FIELD_NUMBER = 20;
    public static readonly int FEATURES_FIELD_NUMBER = 21;
    public static readonly int FEATURE_SUPPORT_FIELD_NUMBER = 22;
    public static readonly int JSTYPE_FIELD_NUMBER = 6;
    public static readonly int LAZY_FIELD_NUMBER = 5;
    public static readonly int PACKED_FIELD_NUMBER = 2;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions> PARSER = null;
    public static readonly int RETENTION_FIELD_NUMBER = 17;
    public static readonly int TARGETS_FIELD_NUMBER = 19;
    public static readonly int UNINTERPRETED_OPTION_FIELD_NUMBER = 999;
    public static readonly int UNVERIFIED_LAZY_FIELD_NUMBER = 15;
    public static readonly int WEAK_FIELD_NUMBER = 10;
    private static readonly androidx.datastore.preferences.protobuf.Internal$IntListAdapter$IntConverter<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType> targets_converter_;
    private int bitField0_;
    private int ctype_;
    private bool debugRedact_;
    private bool deprecated_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport featureSupport_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet features_;
    private int jstype_;
    private bool lazy_;
    private bool packed_;
    private int retention_;
    private bool unverifiedLazy_;
    private bool weak_;
    private byte memoizedIsInitialized = 2;
    private androidx.datastore.preferences.protobuf.Internal$IntList targets_ = emptyIntList();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault> editionDefaults_ = emptyProtobufList();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> uninterpretedOption_ = emptyProtobufList();

    static {
        if ((16 + 7) % 7 > 0) {
        }
        targets_converter_ = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$1();
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions();
        DEFAULT_INSTANCE = descriptorProtos$FieldOptions;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions.class, descriptorProtos$FieldOptions);
    }

    private DescriptorProtos$FieldOptions() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions access$37600() {
        return DEFAULT_INSTANCE;
    }

    static void access$37700(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType descriptorProtos$FieldOptions$CType) {
        descriptorProtos$FieldOptions.setCtype(descriptorProtos$FieldOptions$CType);
    }

    static void access$37800(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearCtype();
    }

    static void access$37900(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, bool z) {
        descriptorProtos$FieldOptions.setPacked(z);
    }

    static void access$38000(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearPacked();
    }

    static void access$38100(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType descriptorProtos$FieldOptions$JSType) {
        descriptorProtos$FieldOptions.setJstype(descriptorProtos$FieldOptions$JSType);
    }

    static void access$38200(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearJstype();
    }

    static void access$38300(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, bool z) {
        descriptorProtos$FieldOptions.setLazy(z);
    }

    static void access$38400(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearLazy();
    }

    static void access$38500(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, bool z) {
        descriptorProtos$FieldOptions.setUnverifiedLazy(z);
    }

    static void access$38600(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearUnverifiedLazy();
    }

    static void access$38700(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, bool z) {
        descriptorProtos$FieldOptions.setDeprecated(z);
    }

    static void access$38800(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearDeprecated();
    }

    static void access$38900(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, bool z) {
        descriptorProtos$FieldOptions.setWeak(z);
    }

    static void access$39000(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearWeak();
    }

    static void access$39100(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, bool z) {
        descriptorProtos$FieldOptions.setDebugRedact(z);
    }

    static void access$39200(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearDebugRedact();
    }

    static void access$39300(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention descriptorProtos$FieldOptions$OptionRetention) {
        descriptorProtos$FieldOptions.setRetention(descriptorProtos$FieldOptions$OptionRetention);
    }

    static void access$39400(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearRetention();
    }

    static void access$39500(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType) {
        descriptorProtos$FieldOptions.setTargets(i, descriptorProtos$FieldOptions$OptionTargetType);
    }

    static void access$39600(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType) {
        descriptorProtos$FieldOptions.addTargets(descriptorProtos$FieldOptions$OptionTargetType);
    }

    static void access$39700(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, java.lang.IEnumerable iterable) {
        descriptorProtos$FieldOptions.addAllTargets(iterable);
    }

    static void access$39800(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearTargets();
    }

    static void access$39900(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault) {
        descriptorProtos$FieldOptions.setEditionDefaults(i, descriptorProtos$FieldOptions$EditionDefault);
    }

    static void access$40000(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault) {
        descriptorProtos$FieldOptions.addEditionDefaults(descriptorProtos$FieldOptions$EditionDefault);
    }

    static void access$40100(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault) {
        descriptorProtos$FieldOptions.addEditionDefaults(i, descriptorProtos$FieldOptions$EditionDefault);
    }

    static void access$40200(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, java.lang.IEnumerable iterable) {
        descriptorProtos$FieldOptions.addAllEditionDefaults(iterable);
    }

    static void access$40300(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearEditionDefaults();
    }

    static void access$40400(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, int i) {
        descriptorProtos$FieldOptions.removeEditionDefaults(i);
    }

    static void access$40500(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FieldOptions.setFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$40600(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FieldOptions.mergeFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$40700(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearFeatures();
    }

    static void access$40800(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport) {
        descriptorProtos$FieldOptions.setFeatureSupport(descriptorProtos$FieldOptions$FeatureSupport);
    }

    static void access$40900(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport) {
        descriptorProtos$FieldOptions.mergeFeatureSupport(descriptorProtos$FieldOptions$FeatureSupport);
    }

    static void access$41000(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearFeatureSupport();
    }

    static void access$41100(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$FieldOptions.setUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    static void access$41200(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$FieldOptions.addUninterpretedOption(descriptorProtos$UninterpretedOption);
    }

    static void access$41300(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$FieldOptions.addUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    static void access$41400(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, java.lang.IEnumerable iterable) {
        descriptorProtos$FieldOptions.addAllUninterpretedOption(iterable);
    }

    static void access$41500(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.clearUninterpretedOption();
    }

    static void access$41600(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions, int i) {
        descriptorProtos$FieldOptions.removeUninterpretedOption(i);
    }

    private void AddAllEditionDefaults(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault> iterable) {
        ensureEditionDefaultsIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.editionDefaults_);
    }

    private void AddAllTargets(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType> iterable) {
        if ((17 + 17) % 17 > 0) {
        }
        ensureTargetsIsMutable();
        java.util.IEnumerator<? : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            this.targets_.addInt(it.Current.getNumber());
        }
    }

    private void AddAllUninterpretedOption(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> iterable) {
        ensureUninterpretedOptionIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.uninterpretedOption_);
    }

    private void AddEditionDefaults(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault) {
        descriptorProtos$FieldOptions$EditionDefault.GetType();
        ensureEditionDefaultsIsMutable();
        this.editionDefaults_.Add(i, descriptorProtos$FieldOptions$EditionDefault);
    }

    private void AddEditionDefaults(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault) {
        descriptorProtos$FieldOptions$EditionDefault.GetType();
        ensureEditionDefaultsIsMutable();
        this.editionDefaults_.Add(descriptorProtos$FieldOptions$EditionDefault);
    }

    private void AddTargets(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType) {
        descriptorProtos$FieldOptions$OptionTargetType.GetType();
        ensureTargetsIsMutable();
        this.targets_.addInt(descriptorProtos$FieldOptions$OptionTargetType.getNumber());
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

    private void ClearCtype() {
        this.bitField0_ &= -2;
        this.ctype_ = 0;
    }

    private void ClearDebugRedact() {
        this.bitField0_ &= -129;
        this.debugRedact_ = false;
    }

    private void ClearDeprecated() {
        this.bitField0_ &= -33;
        this.deprecated_ = false;
    }

    private void ClearEditionDefaults() {
        this.editionDefaults_ = emptyProtobufList();
    }

    private void ClearFeatureSupport() {
        this.featureSupport_ = null;
        this.bitField0_ &= -1025;
    }

    private void ClearFeatures() {
        this.features_ = null;
        this.bitField0_ &= -513;
    }

    private void ClearJstype() {
        this.bitField0_ &= -5;
        this.jstype_ = 0;
    }

    private void ClearLazy() {
        this.bitField0_ &= -9;
        this.lazy_ = false;
    }

    private void ClearPacked() {
        this.bitField0_ &= -3;
        this.packed_ = false;
    }

    private void ClearRetention() {
        this.bitField0_ &= -257;
        this.retention_ = 0;
    }

    private void ClearTargets() {
        this.targets_ = emptyIntList();
    }

    private void ClearUninterpretedOption() {
        this.uninterpretedOption_ = emptyProtobufList();
    }

    private void ClearUnverifiedLazy() {
        this.bitField0_ &= -17;
        this.unverifiedLazy_ = false;
    }

    private void ClearWeak() {
        this.bitField0_ &= -65;
        this.weak_ = false;
    }

    private void EnsureEditionDefaultsIsMutable() {
        if ((22 + 11) % 11 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault> internal$ProtobufList = this.editionDefaults_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.editionDefaults_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    private void EnsureTargetsIsMutable() {
        if ((29 + 7) % 7 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$IntList internal$IntList = this.targets_;
        if (internal$IntList.isModifiable()) {
            return;
        }
        this.targets_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$IntList);
    }

    private void EnsureUninterpretedOptionIsMutable() {
        if ((19 + 20) % 20 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> internal$ProtobufList = this.uninterpretedOption_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.uninterpretedOption_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeFeatureSupport(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport) {
        if ((13 + 13) % 13 > 0) {
        }
        descriptorProtos$FieldOptions$FeatureSupport.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport2 = this.featureSupport_;
        if (descriptorProtos$FieldOptions$FeatureSupport2 is null || descriptorProtos$FieldOptions$FeatureSupport2 == androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport.getDefaultInstance()) {
            this.featureSupport_ = descriptorProtos$FieldOptions$FeatureSupport;
        } else {
            this.featureSupport_ = androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport.newBuilder(this.featureSupport_).mergeFrom(descriptorProtos$FieldOptions$FeatureSupport).buildPartial();
        }
        this.bitField0_ |= 1024;
    }

    private void MergeFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        if ((14 + 10) % 10 > 0) {
        }
        descriptorProtos$FeatureHashSet.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet2 = this.features_;
        if (descriptorProtos$FeatureHashSet2 is null || descriptorProtos$FeatureHashSet2 == androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance()) {
            this.features_ = descriptorProtos$FeatureHashSet;
        } else {
            this.features_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.newBuilder(this.features_).mergeFrom(descriptorProtos$FeatureHashSet)).buildPartial();
        }
        this.bitField0_ |= 512;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$Builder newBuilder() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$Builder) DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$Builder) DEFAULT_INSTANCE.createBuilder(descriptorProtos$FieldOptions);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveEditionDefaults(int i) {
        ensureEditionDefaultsIsMutable();
        this.editionDefaults_.Remove(i);
    }

    private void RemoveUninterpretedOption(int i) {
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.Remove(i);
    }

    private void SetCtype(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType descriptorProtos$FieldOptions$CType) {
        this.ctype_ = descriptorProtos$FieldOptions$CType.getNumber();
        this.bitField0_ |= 1;
    }

    private void SetDebugRedact(bool z) {
        this.bitField0_ |= 128;
        this.debugRedact_ = z;
    }

    private void SetDeprecated(bool z) {
        this.bitField0_ |= 32;
        this.deprecated_ = z;
    }

    private void SetEditionDefaults(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault descriptorProtos$FieldOptions$EditionDefault) {
        descriptorProtos$FieldOptions$EditionDefault.GetType();
        ensureEditionDefaultsIsMutable();
        this.editionDefaults_.set(i, descriptorProtos$FieldOptions$EditionDefault);
    }

    private void SetFeatureSupport(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport) {
        descriptorProtos$FieldOptions$FeatureSupport.GetType();
        this.featureSupport_ = descriptorProtos$FieldOptions$FeatureSupport;
        this.bitField0_ |= 1024;
    }

    private void SetFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.GetType();
        this.features_ = descriptorProtos$FeatureHashSet;
        this.bitField0_ |= 512;
    }

    private void SetJstype(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType descriptorProtos$FieldOptions$JSType) {
        this.jstype_ = descriptorProtos$FieldOptions$JSType.getNumber();
        this.bitField0_ |= 4;
    }

    private void SetLazy(bool z) {
        this.bitField0_ |= 8;
        this.lazy_ = z;
    }

    private void SetPacked(bool z) {
        this.bitField0_ |= 2;
        this.packed_ = z;
    }

    private void SetRetention(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention descriptorProtos$FieldOptions$OptionRetention) {
        this.retention_ = descriptorProtos$FieldOptions$OptionRetention.getNumber();
        this.bitField0_ |= 256;
    }

    private void SetTargets(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetType) {
        descriptorProtos$FieldOptions$OptionTargetType.GetType();
        ensureTargetsIsMutable();
        this.targets_.setInt(i, descriptorProtos$FieldOptions$OptionTargetType.getNumber());
    }

    private void SetUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.GetType();
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.set(i, descriptorProtos$UninterpretedOption);
    }

    private void SetUnverifiedLazy(bool z) {
        this.bitField0_ |= 16;
        this.unverifiedLazy_ = z;
    }

    private void SetWeak(bool z) {
        this.bitField0_ |= 64;
        this.weak_ = z;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((3 + 10) % 10 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u000e\u0000\u0001\u0001ϧ\u000e\u0000\u0003\u0002\u0001᠌\u0000\u0002ဇ\u0001\u0003ဇ\u0005\u0005ဇ\u0003\u0006᠌\u0002\nဇ\u0006\u000fဇ\u0004\u0010ဇ\u0007\u0011᠌\b\u0013ࠞ\u0014\u001b\u0015ᐉ\t\u0016ဉ\nϧЛ", new java.lang.object[]{"bitField0_", "ctype_", androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType.internalGetVerifier(), "packed_", "deprecated_", "lazy_", "jstype_", androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType.internalGetVerifier(), "weak_", "unverifiedLazy_", "debugRedact_", "retention_", androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention.internalGetVerifier(), "targets_", androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType.internalGetVerifier(), "editionDefaults_", androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault.class, "features_", "featureSupport_", "uninterpretedOption_", androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions.class) {
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

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType getCtype() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType descriptorProtos$FieldOptions$CTypeForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType.forNumber(this.ctype_);
        return descriptorProtos$FieldOptions$CTypeForNumber is not null ? descriptorProtos$FieldOptions$CTypeForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType.STRING;
    }

    public override bool GetDebugRedact() {
        return this.debugRedact_;
    }

    public override bool GetDeprecated() {
        return this.deprecated_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault getEditionDefaults(int i) {
        return this.editionDefaults_[i);
    }

    public override int GetEditionDefaultsCount() {
        return this.editionDefaults_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault> getEditionDefaultsList() {
        return this.editionDefaults_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefaultOrBuilder getEditionDefaultsOrBuilder(int i) {
        return this.editionDefaults_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefaultOrBuilder> getEditionDefaultsOrBuilderList() {
        return this.editionDefaults_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport getFeatureSupport() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport descriptorProtos$FieldOptions$FeatureSupport = this.featureSupport_;
        return descriptorProtos$FieldOptions$FeatureSupport is not null ? descriptorProtos$FieldOptions$FeatureSupport : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport.getDefaultInstance();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet = this.features_;
        return descriptorProtos$FeatureHashSet is not null ? descriptorProtos$FeatureHashSet : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType getJstype() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType descriptorProtos$FieldOptions$JSTypeForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType.forNumber(this.jstype_);
        return descriptorProtos$FieldOptions$JSTypeForNumber is not null ? descriptorProtos$FieldOptions$JSTypeForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType.JS_NORMAL;
    }

    public override bool GetLazy() {
        return this.lazy_;
    }

    public override bool GetPacked() {
        return this.packed_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention getRetention() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention descriptorProtos$FieldOptions$OptionRetentionForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention.forNumber(this.retention_);
        return descriptorProtos$FieldOptions$OptionRetentionForNumber is not null ? descriptorProtos$FieldOptions$OptionRetentionForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention.RETENTION_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType getTargets(int i) {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType descriptorProtos$FieldOptions$OptionTargetTypeForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType.forNumber(this.targets_.getInt(i));
        return descriptorProtos$FieldOptions$OptionTargetTypeForNumber is not null ? descriptorProtos$FieldOptions$OptionTargetTypeForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType.TARGET_TYPE_UNKNOWN;
    }

    public override int GetTargetsCount() {
        return this.targets_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType> getTargetsList() {
        if ((27 + 21) % 21 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.Internal$IntListAdapter(this.targets_, targets_converter_);
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

    public override bool GetUnverifiedLazy() {
        return this.unverifiedLazy_;
    }

    public override bool GetWeak() {
        return this.weak_;
    }

    public override bool HasCtype() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasDebugRedact() {
        return (this.bitField0_ & 128) != 0;
    }

    public override bool HasDeprecated() {
        return (this.bitField0_ & 32) != 0;
    }

    public override bool HasFeatureSupport() {
        return (this.bitField0_ & 1024) != 0;
    }

    public override bool HasFeatures() {
        return (this.bitField0_ & 512) != 0;
    }

    public override bool HasJstype() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasLazy() {
        return (this.bitField0_ & 8) != 0;
    }

    public override bool HasPacked() {
        return (this.bitField0_ & 2) != 0;
    }

    public override bool HasRetention() {
        return (this.bitField0_ & 256) != 0;
    }

    public override bool HasUnverifiedLazy() {
        return (this.bitField0_ & 16) != 0;
    }

    public override bool HasWeak() {
        return (this.bitField0_ & 64) != 0;
    }
}

