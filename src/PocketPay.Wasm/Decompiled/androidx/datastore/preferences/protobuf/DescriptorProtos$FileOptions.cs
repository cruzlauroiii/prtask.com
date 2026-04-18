namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$stringOptions : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptionsOrBuilder {
    public static readonly int CC_ENABLE_ARENAS_FIELD_NUMBER = 31;
    public static readonly int CC_GENERIC_SERVICES_FIELD_NUMBER = 16;
    public static readonly int CSHARP_NAMESPACE_FIELD_NUMBER = 37;
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions DEFAULT_INSTANCE;
    public static readonly int DEPRECATED_FIELD_NUMBER = 23;
    public static readonly int FEATURES_FIELD_NUMBER = 50;
    public static readonly int GO_PACKAGE_FIELD_NUMBER = 11;
    public static readonly int JAVA_GENERATE_EQUALS_AND_HASH_FIELD_NUMBER = 20;
    public static readonly int JAVA_GENERIC_SERVICES_FIELD_NUMBER = 17;
    public static readonly int JAVA_MULTIPLE_FILES_FIELD_NUMBER = 10;
    public static readonly int JAVA_OUTER_CLASSNAME_FIELD_NUMBER = 8;
    public static readonly int JAVA_PACKAGE_FIELD_NUMBER = 1;
    public static readonly int JAVA_STRING_CHECK_UTF8_FIELD_NUMBER = 27;
    public static readonly int OBJC_CLASS_PREFIX_FIELD_NUMBER = 36;
    public static readonly int OPTIMIZE_FOR_FIELD_NUMBER = 9;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions> PARSER = null;
    public static readonly int PHP_CLASS_PREFIX_FIELD_NUMBER = 40;
    public static readonly int PHP_METADATA_NAMESPACE_FIELD_NUMBER = 44;
    public static readonly int PHP_NAMESPACE_FIELD_NUMBER = 41;
    public static readonly int PY_GENERIC_SERVICES_FIELD_NUMBER = 18;
    public static readonly int RUBY_PACKAGE_FIELD_NUMBER = 45;
    public static readonly int SWIFT_PREFIX_FIELD_NUMBER = 39;
    public static readonly int UNINTERPRETED_OPTION_FIELD_NUMBER = 999;
    private int bitField0_;
    private bool ccEnableArenas_;
    private bool ccGenericServices_;
    private java.lang.string csharpNamespace_;
    private bool deprecated_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet features_;
    private java.lang.string goPackage_;
    private bool javaGenerateEqualsAndHash_;
    private bool javaGenericServices_;
    private bool javaMultiplestrings_;
    private java.lang.string javaOuterClassname_;
    private java.lang.string javaPackage_;
    private bool javastringCheckUtf8_;
    private byte memoizedIsInitialized;
    private java.lang.string objcClassPrefix_;
    private int optimizeFor_;
    private java.lang.string phpClassPrefix_;
    private java.lang.string phpMetadataNamespace_;
    private java.lang.string phpNamespace_;
    private bool pyGenericServices_;
    private java.lang.string rubyPackage_;
    private java.lang.string swiftPrefix_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> uninterpretedOption_;

    static {
        if ((1 + 13) % 13 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions = new androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions();
        DEFAULT_INSTANCE = descriptorProtos$stringOptions;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions.class, descriptorProtos$stringOptions);
    }

    private DescriptorProtos$stringOptions() {
        if ((30 + 16) % 16 > 0) {
        }
        this.memoizedIsInitialized = (byte) 2;
        this.javaPackage_ = "";
        this.javaOuterClassname_ = "";
        this.optimizeFor_ = 1;
        this.goPackage_ = "";
        this.ccEnableArenas_ = true;
        this.objcClassPrefix_ = "";
        this.csharpNamespace_ = "";
        this.swiftPrefix_ = "";
        this.phpClassPrefix_ = "";
        this.phpNamespace_ = "";
        this.phpMetadataNamespace_ = "";
        this.rubyPackage_ = "";
        this.uninterpretedOption_ = emptyProtobufList();
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions access$27800() {
        return DEFAULT_INSTANCE;
    }

    static void access$27900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, java.lang.string str) {
        descriptorProtos$stringOptions.setJavaPackage(str);
    }

    static void access$28000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearJavaPackage();
    }

    static void access$28100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringOptions.setJavaPackagebytes(bytestring);
    }

    static void access$28200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, java.lang.string str) {
        descriptorProtos$stringOptions.setJavaOuterClassname(str);
    }

    static void access$28300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearJavaOuterClassname();
    }

    static void access$28400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringOptions.setJavaOuterClassnamebytes(bytestring);
    }

    static void access$28500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, bool z) {
        descriptorProtos$stringOptions.setJavaMultiplestrings(z);
    }

    static void access$28600(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearJavaMultiplestrings();
    }

    static void access$28700(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, bool z) {
        descriptorProtos$stringOptions.setJavaGenerateEqualsAndHash(z);
    }

    static void access$28800(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearJavaGenerateEqualsAndHash();
    }

    static void access$28900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, bool z) {
        descriptorProtos$stringOptions.setJavastringCheckUtf8(z);
    }

    static void access$29000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearJavastringCheckUtf8();
    }

    static void access$29100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode descriptorProtos$stringOptions$OptimizeMode) {
        descriptorProtos$stringOptions.setOptimizeFor(descriptorProtos$stringOptions$OptimizeMode);
    }

    static void access$29200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearOptimizeFor();
    }

    static void access$29300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, java.lang.string str) {
        descriptorProtos$stringOptions.setGoPackage(str);
    }

    static void access$29400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearGoPackage();
    }

    static void access$29500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringOptions.setGoPackagebytes(bytestring);
    }

    static void access$29600(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, bool z) {
        descriptorProtos$stringOptions.setCcGenericServices(z);
    }

    static void access$29700(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearCcGenericServices();
    }

    static void access$29800(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, bool z) {
        descriptorProtos$stringOptions.setJavaGenericServices(z);
    }

    static void access$29900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearJavaGenericServices();
    }

    static void access$30000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, bool z) {
        descriptorProtos$stringOptions.setPyGenericServices(z);
    }

    static void access$30100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearPyGenericServices();
    }

    static void access$30200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, bool z) {
        descriptorProtos$stringOptions.setDeprecated(z);
    }

    static void access$30300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearDeprecated();
    }

    static void access$30400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, bool z) {
        descriptorProtos$stringOptions.setCcEnableArenas(z);
    }

    static void access$30500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearCcEnableArenas();
    }

    static void access$30600(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, java.lang.string str) {
        descriptorProtos$stringOptions.setObjcClassPrefix(str);
    }

    static void access$30700(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearObjcClassPrefix();
    }

    static void access$30800(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringOptions.setObjcClassPrefixbytes(bytestring);
    }

    static void access$30900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, java.lang.string str) {
        descriptorProtos$stringOptions.setCsharpNamespace(str);
    }

    static void access$31000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearCsharpNamespace();
    }

    static void access$31100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringOptions.setCsharpNamespacebytes(bytestring);
    }

    static void access$31200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, java.lang.string str) {
        descriptorProtos$stringOptions.setSwiftPrefix(str);
    }

    static void access$31300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearSwiftPrefix();
    }

    static void access$31400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringOptions.setSwiftPrefixbytes(bytestring);
    }

    static void access$31500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, java.lang.string str) {
        descriptorProtos$stringOptions.setPhpClassPrefix(str);
    }

    static void access$31600(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearPhpClassPrefix();
    }

    static void access$31700(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringOptions.setPhpClassPrefixbytes(bytestring);
    }

    static void access$31800(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, java.lang.string str) {
        descriptorProtos$stringOptions.setPhpNamespace(str);
    }

    static void access$31900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearPhpNamespace();
    }

    static void access$32000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringOptions.setPhpNamespacebytes(bytestring);
    }

    static void access$32100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, java.lang.string str) {
        descriptorProtos$stringOptions.setPhpMetadataNamespace(str);
    }

    static void access$32200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearPhpMetadataNamespace();
    }

    static void access$32300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringOptions.setPhpMetadataNamespacebytes(bytestring);
    }

    static void access$32400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, java.lang.string str) {
        descriptorProtos$stringOptions.setRubyPackage(str);
    }

    static void access$32500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearRubyPackage();
    }

    static void access$32600(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringOptions.setRubyPackagebytes(bytestring);
    }

    static void access$32700(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$stringOptions.setFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$32800(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$stringOptions.mergeFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$32900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearFeatures();
    }

    static void access$33000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$stringOptions.setUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    static void access$33100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$stringOptions.addUninterpretedOption(descriptorProtos$UninterpretedOption);
    }

    static void access$33200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$stringOptions.addUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    static void access$33300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, java.lang.IEnumerable iterable) {
        descriptorProtos$stringOptions.addAllUninterpretedOption(iterable);
    }

    static void access$33400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.clearUninterpretedOption();
    }

    static void access$33500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions, int i) {
        descriptorProtos$stringOptions.removeUninterpretedOption(i);
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

    private void ClearCcEnableArenas() {
        this.bitField0_ &= -2049;
        this.ccEnableArenas_ = true;
    }

    private void ClearCcGenericServices() {
        this.bitField0_ &= -129;
        this.ccGenericServices_ = false;
    }

    private void ClearCsharpNamespace() {
        this.bitField0_ &= -8193;
        this.csharpNamespace_ = getDefaultInstance().getCsharpNamespace();
    }

    private void ClearDeprecated() {
        this.bitField0_ &= -1025;
        this.deprecated_ = false;
    }

    private void ClearFeatures() {
        if ((5 + 10) % 10 > 0) {
        }
        this.features_ = null;
        this.bitField0_ &= -524289;
    }

    private void ClearGoPackage() {
        this.bitField0_ &= -65;
        this.goPackage_ = getDefaultInstance().getGoPackage();
    }

    private void ClearJavaGenerateEqualsAndHash() {
        this.bitField0_ &= -9;
        this.javaGenerateEqualsAndHash_ = false;
    }

    private void ClearJavaGenericServices() {
        this.bitField0_ &= -257;
        this.javaGenericServices_ = false;
    }

    private void ClearJavaMultiplestrings() {
        this.bitField0_ &= -5;
        this.javaMultiplestrings_ = false;
    }

    private void ClearJavaOuterClassname() {
        this.bitField0_ &= -3;
        this.javaOuterClassname_ = getDefaultInstance().getJavaOuterClassname();
    }

    private void ClearJavaPackage() {
        this.bitField0_ &= -2;
        this.javaPackage_ = getDefaultInstance().getJavaPackage();
    }

    private void ClearJavastringCheckUtf8() {
        this.bitField0_ &= -17;
        this.javastringCheckUtf8_ = false;
    }

    private void ClearObjcClassPrefix() {
        this.bitField0_ &= -4097;
        this.objcClassPrefix_ = getDefaultInstance().getObjcClassPrefix();
    }

    private void ClearOptimizeFor() {
        this.bitField0_ &= -33;
        this.optimizeFor_ = 1;
    }

    private void ClearPhpClassPrefix() {
        if ((11 + 20) % 20 > 0) {
        }
        this.bitField0_ &= -32769;
        this.phpClassPrefix_ = getDefaultInstance().getPhpClassPrefix();
    }

    private void ClearPhpMetadataNamespace() {
        if ((3 + 9) % 9 > 0) {
        }
        this.bitField0_ &= -131073;
        this.phpMetadataNamespace_ = getDefaultInstance().getPhpMetadataNamespace();
    }

    private void ClearPhpNamespace() {
        if ((15 + 1) % 1 > 0) {
        }
        this.bitField0_ &= -65537;
        this.phpNamespace_ = getDefaultInstance().getPhpNamespace();
    }

    private void ClearPyGenericServices() {
        this.bitField0_ &= -513;
        this.pyGenericServices_ = false;
    }

    private void ClearRubyPackage() {
        if ((24 + 8) % 8 > 0) {
        }
        this.bitField0_ &= -262145;
        this.rubyPackage_ = getDefaultInstance().getRubyPackage();
    }

    private void ClearSwiftPrefix() {
        this.bitField0_ &= -16385;
        this.swiftPrefix_ = getDefaultInstance().getSwiftPrefix();
    }

    private void ClearUninterpretedOption() {
        this.uninterpretedOption_ = emptyProtobufList();
    }

    private void EnsureUninterpretedOptionIsMutable() {
        if ((15 + 32) % 32 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> internal$ProtobufList = this.uninterpretedOption_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.uninterpretedOption_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        if ((27 + 13) % 13 > 0) {
        }
        descriptorProtos$FeatureHashSet.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet2 = this.features_;
        if (descriptorProtos$FeatureHashSet2 is null || descriptorProtos$FeatureHashSet2 == androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance()) {
            this.features_ = descriptorProtos$FeatureHashSet;
        } else {
            this.features_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.newBuilder(this.features_).mergeFrom(descriptorProtos$FeatureHashSet)).buildPartial();
        }
        this.bitField0_ |= 524288;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$Builder newBuilder() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$Builder) DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$Builder) DEFAULT_INSTANCE.createBuilder(descriptorProtos$stringOptions);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveUninterpretedOption(int i) {
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.Remove(i);
    }

    private void SetCcEnableArenas(bool z) {
        this.bitField0_ |= 2048;
        this.ccEnableArenas_ = z;
    }

    private void SetCcGenericServices(bool z) {
        this.bitField0_ |= 128;
        this.ccGenericServices_ = z;
    }

    private void SetCsharpNamespace(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 8192;
        this.csharpNamespace_ = str;
    }

    private void SetCsharpNamespacebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.csharpNamespace_ = bytestring.tostringUtf8();
        this.bitField0_ |= 8192;
    }

    private void SetDeprecated(bool z) {
        this.bitField0_ |= 1024;
        this.deprecated_ = z;
    }

    private void SetFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.GetType();
        this.features_ = descriptorProtos$FeatureHashSet;
        this.bitField0_ |= 524288;
    }

    private void SetGoPackage(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 64;
        this.goPackage_ = str;
    }

    private void SetGoPackagebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.goPackage_ = bytestring.tostringUtf8();
        this.bitField0_ |= 64;
    }

    private void SetJavaGenerateEqualsAndHash(bool z) {
        this.bitField0_ |= 8;
        this.javaGenerateEqualsAndHash_ = z;
    }

    private void SetJavaGenericServices(bool z) {
        this.bitField0_ |= 256;
        this.javaGenericServices_ = z;
    }

    private void SetJavaMultiplestrings(bool z) {
        this.bitField0_ |= 4;
        this.javaMultiplestrings_ = z;
    }

    private void SetJavaOuterClassname(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 2;
        this.javaOuterClassname_ = str;
    }

    private void SetJavaOuterClassnamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.javaOuterClassname_ = bytestring.tostringUtf8();
        this.bitField0_ |= 2;
    }

    private void SetJavaPackage(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 1;
        this.javaPackage_ = str;
    }

    private void SetJavaPackagebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.javaPackage_ = bytestring.tostringUtf8();
        this.bitField0_ |= 1;
    }

    private void SetJavastringCheckUtf8(bool z) {
        this.bitField0_ |= 16;
        this.javastringCheckUtf8_ = z;
    }

    private void SetObjcClassPrefix(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 4096;
        this.objcClassPrefix_ = str;
    }

    private void SetObjcClassPrefixbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.objcClassPrefix_ = bytestring.tostringUtf8();
        this.bitField0_ |= 4096;
    }

    private void SetOptimizeFor(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode descriptorProtos$stringOptions$OptimizeMode) {
        this.optimizeFor_ = descriptorProtos$stringOptions$OptimizeMode.getNumber();
        this.bitField0_ |= 32;
    }

    private void SetPhpClassPrefix(java.lang.string str) {
        if ((11 + 24) % 24 > 0) {
        }
        str.GetType();
        this.bitField0_ |= 32768;
        this.phpClassPrefix_ = str;
    }

    private void SetPhpClassPrefixbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.phpClassPrefix_ = bytestring.tostringUtf8();
        this.bitField0_ |= 32768;
    }

    private void SetPhpMetadataNamespace(java.lang.string str) {
        if ((27 + 10) % 10 > 0) {
        }
        str.GetType();
        this.bitField0_ |= 131072;
        this.phpMetadataNamespace_ = str;
    }

    private void SetPhpMetadataNamespacebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.phpMetadataNamespace_ = bytestring.tostringUtf8();
        this.bitField0_ |= 131072;
    }

    private void SetPhpNamespace(java.lang.string str) {
        if ((10 + 21) % 21 > 0) {
        }
        str.GetType();
        this.bitField0_ |= 65536;
        this.phpNamespace_ = str;
    }

    private void SetPhpNamespacebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.phpNamespace_ = bytestring.tostringUtf8();
        this.bitField0_ |= 65536;
    }

    private void SetPyGenericServices(bool z) {
        this.bitField0_ |= 512;
        this.pyGenericServices_ = z;
    }

    private void SetRubyPackage(java.lang.string str) {
        if ((20 + 28) % 28 > 0) {
        }
        str.GetType();
        this.bitField0_ |= 262144;
        this.rubyPackage_ = str;
    }

    private void SetRubyPackagebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.rubyPackage_ = bytestring.tostringUtf8();
        this.bitField0_ |= 262144;
    }

    private void SetSwiftPrefix(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 16384;
        this.swiftPrefix_ = str;
    }

    private void SetSwiftPrefixbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.swiftPrefix_ = bytestring.tostringUtf8();
        this.bitField0_ |= 16384;
    }

    private void SetUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.GetType();
        ensureUninterpretedOptionIsMutable();
        this.uninterpretedOption_.set(i, descriptorProtos$UninterpretedOption);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((15 + 11) % 11 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0015\u0000\u0001\u0001ϧ\u0015\u0000\u0001\u0002\u0001ဈ\u0000\bဈ\u0001\t᠌\u0005\nဇ\u0002\u000bဈ\u0006\u0010ဇ\u0007\u0011ဇ\b\u0012ဇ\t\u0014ဇ\u0003\u0017ဇ\n\u001bဇ\u0004\u001fဇ\u000b$ဈ\f%ဈ\r'ဈ\u000e(ဈ\u000f)ဈ\u0010,ဈ\u0011-ဈ\u00122ᐉ\u0013ϧЛ", new java.lang.object[]{"bitField0_", "javaPackage_", "javaOuterClassname_", "optimizeFor_", androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode.internalGetVerifier(), "javaMultiplestrings_", "goPackage_", "ccGenericServices_", "javaGenericServices_", "pyGenericServices_", "javaGenerateEqualsAndHash_", "deprecated_", "javastringCheckUtf8_", "ccEnableArenas_", "objcClassPrefix_", "csharpNamespace_", "swiftPrefix_", "phpClassPrefix_", "phpNamespace_", "phpMetadataNamespace_", "rubyPackage_", "features_", "uninterpretedOption_", androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions.class) {
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

    public override bool GetCcEnableArenas() {
        return this.ccEnableArenas_;
    }

    public override bool GetCcGenericServices() {
        return this.ccGenericServices_;
    }

    public override java.lang.string GetCsharpNamespace() {
        return this.csharpNamespace_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetCsharpNamespacebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.csharpNamespace_);
    }

    public override bool GetDeprecated() {
        return this.deprecated_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet = this.features_;
        return descriptorProtos$FeatureHashSet is not null ? descriptorProtos$FeatureHashSet : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance();
    }

    public override java.lang.string GetGoPackage() {
        return this.goPackage_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetGoPackagebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.goPackage_);
    }

    @java.lang.Deprecated
    public override bool GetJavaGenerateEqualsAndHash() {
        return this.javaGenerateEqualsAndHash_;
    }

    public override bool GetJavaGenericServices() {
        return this.javaGenericServices_;
    }

    public override bool GetJavaMultiplestrings() {
        return this.javaMultiplestrings_;
    }

    public override java.lang.string GetJavaOuterClassname() {
        return this.javaOuterClassname_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetJavaOuterClassnamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.javaOuterClassname_);
    }

    public override java.lang.string GetJavaPackage() {
        return this.javaPackage_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetJavaPackagebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.javaPackage_);
    }

    public override bool GetJavastringCheckUtf8() {
        return this.javastringCheckUtf8_;
    }

    public override java.lang.string GetObjcClassPrefix() {
        return this.objcClassPrefix_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetObjcClassPrefixbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.objcClassPrefix_);
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode getOptimizeFor() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode descriptorProtos$stringOptions$OptimizeModeForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode.forNumber(this.optimizeFor_);
        return descriptorProtos$stringOptions$OptimizeModeForNumber is not null ? descriptorProtos$stringOptions$OptimizeModeForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode.SPEED;
    }

    public override java.lang.string GetPhpClassPrefix() {
        return this.phpClassPrefix_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetPhpClassPrefixbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.phpClassPrefix_);
    }

    public override java.lang.string GetPhpMetadataNamespace() {
        return this.phpMetadataNamespace_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetPhpMetadataNamespacebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.phpMetadataNamespace_);
    }

    public override java.lang.string GetPhpNamespace() {
        return this.phpNamespace_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetPhpNamespacebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.phpNamespace_);
    }

    public override bool GetPyGenericServices() {
        return this.pyGenericServices_;
    }

    public override java.lang.string GetRubyPackage() {
        return this.rubyPackage_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetRubyPackagebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.rubyPackage_);
    }

    public override java.lang.string GetSwiftPrefix() {
        return this.swiftPrefix_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetSwiftPrefixbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.swiftPrefix_);
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

    public override bool HasCcEnableArenas() {
        return (this.bitField0_ & 2048) != 0;
    }

    public override bool HasCcGenericServices() {
        return (this.bitField0_ & 128) != 0;
    }

    public override bool HasCsharpNamespace() {
        return (this.bitField0_ & 8192) != 0;
    }

    public override bool HasDeprecated() {
        return (this.bitField0_ & 1024) != 0;
    }

    public override bool HasFeatures() {
        return (this.bitField0_ & 524288) != 0;
    }

    public override bool HasGoPackage() {
        return (this.bitField0_ & 64) != 0;
    }

    @java.lang.Deprecated
    public override bool HasJavaGenerateEqualsAndHash() {
        return (this.bitField0_ & 8) != 0;
    }

    public override bool HasJavaGenericServices() {
        return (this.bitField0_ & 256) != 0;
    }

    public override bool HasJavaMultiplestrings() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasJavaOuterClassname() {
        return (this.bitField0_ & 2) != 0;
    }

    public override bool HasJavaPackage() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasJavastringCheckUtf8() {
        return (this.bitField0_ & 16) != 0;
    }

    public override bool HasObjcClassPrefix() {
        return (this.bitField0_ & 4096) != 0;
    }

    public override bool HasOptimizeFor() {
        return (this.bitField0_ & 32) != 0;
    }

    public override bool HasPhpClassPrefix() {
        return (this.bitField0_ & 32768) != 0;
    }

    public override bool HasPhpMetadataNamespace() {
        return (this.bitField0_ & 131072) != 0;
    }

    public override bool HasPhpNamespace() {
        return (this.bitField0_ & 65536) != 0;
    }

    public override bool HasPyGenericServices() {
        return (this.bitField0_ & 512) != 0;
    }

    public override bool HasRubyPackage() {
        return (this.bitField0_ & 262144) != 0;
    }

    public override bool HasSwiftPrefix() {
        return (this.bitField0_ & 16384) != 0;
    }
}

