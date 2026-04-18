namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault, androidx.datastore.preferences.protobuf.C0074x40880362> : androidx.datastore.preferences.protobuf.InterfaceC0075xbca528ed {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault DEFAULT_INSTANCE;
    public static readonly int EDITION_FIELD_NUMBER = 3;
    public static readonly int FIXED_FEATURES_FIELD_NUMBER = 5;
    public static readonly int OVERRIDABLE_FEATURES_FIELD_NUMBER = 4;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault> PARSER;
    private int bitField0_;
    private int edition_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet fixedFeatures_;
    private byte memoizedIsInitialized = 2;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet overridableFeatures_;

    static {
        if ((28 + 30) % 30 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault();
        DEFAULT_INSTANCE = descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.class, descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault);
    }

    private DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault access$53500() {
        return DEFAULT_INSTANCE;
    }

    static void access$53600(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault, androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.setEdition(descriptorProtos$Edition);
    }

    static void access$53700(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) {
        descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.clearEdition();
    }

    static void access$53800(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.setOverridableFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$53900(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.mergeOverridableFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$54000(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) {
        descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.clearOverridableFeatures();
    }

    static void access$54100(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.setFixedFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$54200(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.mergeFixedFeatures(descriptorProtos$FeatureHashSet);
    }

    static void access$54300(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) {
        descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.clearFixedFeatures();
    }

    private void ClearEdition() {
        this.bitField0_ &= -2;
        this.edition_ = 0;
    }

    private void ClearFixedFeatures() {
        this.fixedFeatures_ = null;
        this.bitField0_ &= -5;
    }

    private void ClearOverridableFeatures() {
        this.overridableFeatures_ = null;
        this.bitField0_ &= -3;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeFixedFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        if ((2 + 5) % 5 > 0) {
        }
        descriptorProtos$FeatureHashSet.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet2 = this.fixedFeatures_;
        if (descriptorProtos$FeatureHashSet2 is null || descriptorProtos$FeatureHashSet2 == androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance()) {
            this.fixedFeatures_ = descriptorProtos$FeatureHashSet;
        } else {
            this.fixedFeatures_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.newBuilder(this.fixedFeatures_).mergeFrom(descriptorProtos$FeatureHashSet)).buildPartial();
        }
        this.bitField0_ |= 4;
    }

    private void MergeOverridableFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        if ((5 + 24) % 24 > 0) {
        }
        descriptorProtos$FeatureHashSet.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet2 = this.overridableFeatures_;
        if (descriptorProtos$FeatureHashSet2 is null || descriptorProtos$FeatureHashSet2 == androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance()) {
            this.overridableFeatures_ = descriptorProtos$FeatureHashSet;
        } else {
            this.overridableFeatures_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.newBuilder(this.overridableFeatures_).mergeFrom(descriptorProtos$FeatureHashSet)).buildPartial();
        }
        this.bitField0_ |= 2;
    }

    public static androidx.datastore.preferences.protobuf.C0074x40880362 NewBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.C0074x40880362 NewBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetEdition(androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        this.edition_ = descriptorProtos$Edition.getNumber();
        this.bitField0_ |= 1;
    }

    private void SetFixedFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.GetType();
        this.fixedFeatures_ = descriptorProtos$FeatureHashSet;
        this.bitField0_ |= 4;
    }

    private void SetOverridableFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.GetType();
        this.overridableFeatures_ = descriptorProtos$FeatureHashSet;
        this.bitField0_ |= 2;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault();
            case 2:
                return new androidx.datastore.preferences.protobuf.C0074x40880362(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0003\u0000\u0001\u0003\u0005\u0003\u0000\u0000\u0002\u0003᠌\u0000\u0004ᐉ\u0001\u0005ᐉ\u0002", new java.lang.object[]{"bitField0_", "edition_", androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.internalGetVerifier(), "overridableFeatures_", "fixedFeatures_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetDefaults$FeatureHashSetEditionDefault.class) {
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

    public androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getEdition() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$EditionForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.forNumber(this.edition_);
        return descriptorProtos$EditionForNumber is not null ? descriptorProtos$EditionForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.EDITION_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFixedFeatures() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet = this.fixedFeatures_;
        return descriptorProtos$FeatureHashSet is not null ? descriptorProtos$FeatureHashSet : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getOverridableFeatures() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet = this.overridableFeatures_;
        return descriptorProtos$FeatureHashSet is not null ? descriptorProtos$FeatureHashSet : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance();
    }

    public override bool HasEdition() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasFixedFeatures() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasOverridableFeatures() {
        return (this.bitField0_ & 2) != 0;
    }
}

