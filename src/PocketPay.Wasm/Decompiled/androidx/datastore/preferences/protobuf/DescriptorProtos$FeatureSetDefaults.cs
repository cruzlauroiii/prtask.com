namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FeatureHashSetDefaults : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaultsOrBuilder {
    public static readonly int DEFAULTS_FIELD_NUMBER = 1;
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults DEFAULT_INSTANCE;
    public static readonly int MAXIMUM_EDITION_FIELD_NUMBER = 5;
    public static readonly int MINIMUM_EDITION_FIELD_NUMBER = 4;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults> PARSER;
    private int bitField0_;
    private int maximumEdition_;
    private int minimumEdition_;
    private byte memoizedIsInitialized = 2;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault> defaults_ = emptyProtobufList();

    static {
        if ((9 + 29) % 29 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults();
        DEFAULT_INSTANCE = descriptorProtos$FeatureHashSetDefaults;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults.class, descriptorProtos$FeatureHashSetDefaults);
    }

    private DescriptorProtos$FeatureHashSetDefaults() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults access$54500() {
        return DEFAULT_INSTANCE;
    }

    static void access$54600(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) {
        descriptorProtos$FeatureHashSetDefaults.setDefaults(i, descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault);
    }

    static void access$54700(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) {
        descriptorProtos$FeatureHashSetDefaults.addDefaults(descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault);
    }

    static void access$54800(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) {
        descriptorProtos$FeatureHashSetDefaults.addDefaults(i, descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault);
    }

    static void access$54900(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults, java.lang.IEnumerable iterable) {
        descriptorProtos$FeatureHashSetDefaults.addAllDefaults(iterable);
    }

    static void access$55000(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults) {
        descriptorProtos$FeatureHashSetDefaults.clearDefaults();
    }

    static void access$55100(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults, int i) {
        descriptorProtos$FeatureHashSetDefaults.removeDefaults(i);
    }

    static void access$55200(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults, androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        descriptorProtos$FeatureHashSetDefaults.setMinimumEdition(descriptorProtos$Edition);
    }

    static void access$55300(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults) {
        descriptorProtos$FeatureHashSetDefaults.clearMinimumEdition();
    }

    static void access$55400(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults, androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        descriptorProtos$FeatureHashSetDefaults.setMaximumEdition(descriptorProtos$Edition);
    }

    static void access$55500(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults) {
        descriptorProtos$FeatureHashSetDefaults.clearMaximumEdition();
    }

    private void AddAllDefaults(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault> iterable) {
        ensureDefaultsIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.defaults_);
    }

    private void AddDefaults(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) {
        descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.GetType();
        ensureDefaultsIsMutable();
        this.defaults_.Add(i, descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault);
    }

    private void AddDefaults(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) {
        descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.GetType();
        ensureDefaultsIsMutable();
        this.defaults_.Add(descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault);
    }

    private void ClearDefaults() {
        this.defaults_ = emptyProtobufList();
    }

    private void ClearMaximumEdition() {
        this.bitField0_ &= -3;
        this.maximumEdition_ = 0;
    }

    private void ClearMinimumEdition() {
        this.bitField0_ &= -2;
        this.minimumEdition_ = 0;
    }

    private void EnsureDefaultsIsMutable() {
        if ((3 + 20) % 20 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault> internal$ProtobufList = this.defaults_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.defaults_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults descriptorProtos$FeatureHashSetDefaults) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$FeatureHashSetDefaults);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveDefaults(int i) {
        ensureDefaultsIsMutable();
        this.defaults_.Remove(i);
    }

    private void SetDefaults(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) {
        descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.GetType();
        ensureDefaultsIsMutable();
        this.defaults_.set(i, descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault);
    }

    private void SetMaximumEdition(androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        this.maximumEdition_ = descriptorProtos$Edition.getNumber();
        this.bitField0_ |= 2;
    }

    private void SetMinimumEdition(androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        this.minimumEdition_ = descriptorProtos$Edition.getNumber();
        this.bitField0_ |= 1;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((1 + 19) % 19 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0003\u0000\u0001\u0001\u0005\u0003\u0000\u0001\u0001\u0001Л\u0004᠌\u0000\u0005᠌\u0001", new java.lang.object[]{"bitField0_", "defaults_", androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.class, "minimumEdition_", androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.internalGetVerifier(), "maximumEdition_", androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.internalGetVerifier()});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults.class) {
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

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault getDefaults(int i) {
        return this.defaults_[i);
    }

    public override int GetDefaultsCount() {
        return this.defaults_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault> getDefaultsList() {
        return this.defaults_;
    }

    public override androidx.datastore.preferences.protobuf.InterfaceC0075xbca528ed GetDefaultsOrBuilder(int i) {
        return this.defaults_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.InterfaceC0075xbca528ed> getDefaultsOrBuilderList() {
        return this.defaults_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getMaximumEdition() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$EditionForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.forNumber(this.maximumEdition_);
        return descriptorProtos$EditionForNumber is not null ? descriptorProtos$EditionForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.EDITION_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getMinimumEdition() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$EditionForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.forNumber(this.minimumEdition_);
        return descriptorProtos$EditionForNumber is not null ? descriptorProtos$EditionForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.EDITION_UNKNOWN;
    }

    public override bool HasMaximumEdition() {
        return (this.bitField0_ & 2) != 0;
    }

    public override bool HasMinimumEdition() {
        return (this.bitField0_ & 1) != 0;
    }
}

