namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$EnumOptions : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptionsOrBuilder {
    public static readonly int ALLOW_ALIAS_FIELD_NUMBER = 2;
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions DEFAULT_INSTANCE;
    public static readonly int DEPRECATED_FIELD_NUMBER = 3;
    public static readonly int DEPRECATED_LEGACY_JSON_FIELD_CONFLICTS_FIELD_NUMBER = 6;
    public static readonly int FEATURES_FIELD_NUMBER = 7;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions> PARSER = null;
    public static readonly int UNINTERPRETED_OPTION_FIELD_NUMBER = 999;
    private bool allowAlias_;
    private int bitField0_;
    private bool deprecatedLegacyJsonFieldConflicts_;
    private bool deprecated_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet features_;
    private byte memoizedIsInitialized = 2;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> uninterpretedOption_ = USZvWXEpCXRbCVoY();

    static {
        if ((10 + 23) % 23 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions = new androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions();
        DEFAULT_INSTANCE = descriptorProtos$EnumOptions;
        fdSzqqIOFIJhCdBD(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions.class, descriptorProtos$EnumOptions);
    }

    private DescriptorProtos$EnumOptions() {
    }

    public static int CQtdvqkOKkpGoWFN(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke) {
        return generatedMessageLite$MethodToInvoke.ordinal();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder CWpKrwJDBPlykoFh(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.newBuilder(descriptorProtos$FeatureHashSet);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite CkMvMugPhHfOFgfz(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite DBCjJSbVYJmBxXKw(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder EnAknloBnHELDLGe(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder descriptorProtos$FeatureHashSet$Builder, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        return descriptorProtos$FeatureHashSet$Builder.mergeFrom(generatedMessageLite);
    }

    public static bool HcGOlxQIYQUkagKU(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static void ICzXidbCPhniQiUe(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumOptions.ensureUninterpretedOptionIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite IfJKhyRunJfpkjQV(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, byte[] bArr) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bArr);
    }

    public static void JPBPkWebqErkRRiW(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, java.lang.IEnumerable iterable) {
        descriptorProtos$EnumOptions.addAllUninterpretedOption(iterable);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite KJBgNFwmsKMMFkFY(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite LUmJCuSgCRhuuwdO(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parseDelimitedFrom(generatedMessageLite, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList MGjHgReTGfxBpbED(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static void MdQzOnLJwZeleMeM(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$EnumOptions.setFeatures(descriptorProtos$FeatureHashSet);
    }

    public static java.lang.Class MrPNmhZJrcUoEWTL(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite NbXrkBjdPUzyXiar(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, byteBuffer, extensionRegistryLite);
    }

    public static void OQQHiMWUFsbGfCEQ(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumOptions.ensureUninterpretedOptionIsMutable();
    }

    public static java.lang.byte OxfvYTZbbNdeaMRm(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static void OydFFQjXPsgpNRuk(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumOptions.ensureUninterpretedOptionIsMutable();
    }

    public static void QKNVqoWVNTpIfOMd(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, int i) {
        descriptorProtos$EnumOptions.removeUninterpretedOption(i);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder QwwMKWGqDQedQBcS(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        return descriptorProtos$EnumOptions.createBuilder(generatedMessageLite);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite SEvvKwbMWULQdJYP(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream) {
        return parseDelimitedFrom(generatedMessageLite, inputStream);
    }

    public static int UNNuAcFlmJYpSAgs(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList USZvWXEpCXRbCVoY() {
        return emptyProtobufList();
    }

    public static java.lang.object VBwEbbidaBJXRnBC(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite VugtLmgXUixmLyCb(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, codedStream);
    }

    public static void XOooYtzxxJbHjwJZ(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, bool z) {
        descriptorProtos$EnumOptions.setDeprecatedLegacyJsonFieldConflicts(z);
    }

    public static void XQbGcGJpHdYqkscV(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumOptions.clearDeprecatedLegacyJsonFieldConflicts();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite ZgFxqRXmoljsuRav(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, inputStream, extensionRegistryLite);
    }

    public static bool ARRoAdowrnVZqYOm(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions access$42900() {
        return DEFAULT_INSTANCE;
    }

    static void access$43000(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, bool z) {
        mhChbfGTjQFeEyfD(descriptorProtos$EnumOptions, z);
    }

    static void access$43100(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        kdIIZKaGsddwXeWt(descriptorProtos$EnumOptions);
    }

    static void access$43200(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, bool z) {
        knPVXvikywDaTuIJ(descriptorProtos$EnumOptions, z);
    }

    static void access$43300(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        xbUhGPqQysYKOrNd(descriptorProtos$EnumOptions);
    }

    static void access$43400(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, bool z) {
        XOooYtzxxJbHjwJZ(descriptorProtos$EnumOptions, z);
    }

    static void access$43500(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        XQbGcGJpHdYqkscV(descriptorProtos$EnumOptions);
    }

    static void access$43600(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        MdQzOnLJwZeleMeM(descriptorProtos$EnumOptions, descriptorProtos$FeatureHashSet);
    }

    static void access$43700(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        bIrkPQVgwojPBpky(descriptorProtos$EnumOptions, descriptorProtos$FeatureHashSet);
    }

    static void access$43800(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        uYSoPqCOwHVsATIf(descriptorProtos$EnumOptions);
    }

    static void access$43900(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        lXPVGCYTbkzQGTIp(descriptorProtos$EnumOptions, i, descriptorProtos$UninterpretedOption);
    }

    static void access$44000(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        ijtwcHzAPrlVLfOp(descriptorProtos$EnumOptions, descriptorProtos$UninterpretedOption);
    }

    static void access$44100(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        lVCVTqryGiRWGpiS(descriptorProtos$EnumOptions, i, descriptorProtos$UninterpretedOption);
    }

    static void access$44200(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, java.lang.IEnumerable iterable) {
        JPBPkWebqErkRRiW(descriptorProtos$EnumOptions, iterable);
    }

    static void access$44300(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        ykPDzaYrFELgcQxM(descriptorProtos$EnumOptions);
    }

    static void access$44400(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, int i) {
        QKNVqoWVNTpIfOMd(descriptorProtos$EnumOptions, i);
    }

    private void AddAllUninterpretedOption(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> iterable) {
        OydFFQjXPsgpNRuk(this);
        hMjMvSVjzXUtFtPm(iterable, this.uninterpretedOption_);
    }

    private void AddUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        sALBeQWUPiBwFaNd(descriptorProtos$UninterpretedOption);
        ICzXidbCPhniQiUe(this);
        eqlObpLxHQPZmRzk(this.uninterpretedOption_, i, descriptorProtos$UninterpretedOption);
    }

    private void AddUninterpretedOption(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        tbbMBrfMBCeUcRrM(descriptorProtos$UninterpretedOption);
        mFMZjrCGHucQaNVL(this);
        aRRoAdowrnVZqYOm(this.uninterpretedOption_, descriptorProtos$UninterpretedOption);
    }

    public static void BIrkPQVgwojPBpky(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$EnumOptions.mergeFeatures(descriptorProtos$FeatureHashSet);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet bRoOAkHLVbyiPUon() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance();
    }

    public static java.lang.object CFCIzJJSHPFmtAmw(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder cXBdyFhloRqYWBXu(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        return descriptorProtos$EnumOptions.createBuilder();
    }

    private void ClearAllowAlias() {
        this.bitField0_ &= -2;
        this.allowAlias_ = false;
    }

    private void ClearDeprecated() {
        this.bitField0_ &= -3;
        this.deprecated_ = false;
    }

    private void ClearDeprecatedLegacyJsonFieldConflicts() {
        this.bitField0_ &= -5;
        this.deprecatedLegacyJsonFieldConflicts_ = false;
    }

    private void ClearFeatures() {
        this.features_ = null;
        this.bitField0_ &= -9;
    }

    private void ClearUninterpretedOption() {
        this.uninterpretedOption_ = dAhECxNgkvJbhBOr();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList dAhECxNgkvJbhBOr() {
        return emptyProtobufList();
    }

    public static java.lang.object DmGPigDnUBYhtkxb(androidx.datastore.preferences.protobuf.MessageLite messageLite, java.lang.string str, java.lang.object[] objArr) {
        return newMessageInfo(messageLite, str, objArr);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite ECFlzbXMskCvZtcA(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bytestring);
    }

    public static java.lang.Class EmBdBjijJMHGWemn(java.lang.object obj) {
        return obj.GetType();
    }

    private void EnsureUninterpretedOptionIsMutable() {
        if ((32 + 15) % 15 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> internal$ProtobufList = this.uninterpretedOption_;
        if (HcGOlxQIYQUkagKU(internal$ProtobufList)) {
            return;
        }
        this.uninterpretedOption_ = MGjHgReTGfxBpbED(internal$ProtobufList);
    }

    public static void EqlObpLxHQPZmRzk(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static void FdSzqqIOFIJhCdBD(java.lang.Class cls, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(cls, generatedMessageLite);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite FrNGMZVYDKhwlaWw(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static void HMjMvSVjzXUtFtPm(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static androidx.datastore.preferences.protobuf.Parser IMOefAxYBkjXfGQv(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        return descriptorProtos$EnumOptions.getParserForType();
    }

    public static void IjtwcHzAPrlVLfOp(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$EnumOptions.addUninterpretedOption(descriptorProtos$UninterpretedOption);
    }

    public static void JNqXRAmgJAwLNgFh(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumOptions.ensureUninterpretedOptionIsMutable();
    }

    public static void KdIIZKaGsddwXeWt(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumOptions.clearAllowAlias();
    }

    public static void KnPVXvikywDaTuIJ(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, bool z) {
        descriptorProtos$EnumOptions.setDeprecated(z);
    }

    public static void LVCVTqryGiRWGpiS(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$EnumOptions.addUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    public static void LXPVGCYTbkzQGTIp(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$EnumOptions.setUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    public static void MFMZjrCGHucQaNVL(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumOptions.ensureUninterpretedOptionIsMutable();
    }

    private void MergeFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        if ((18 + 11) % 11 > 0) {
        }
        uVQJCwlTUtBqqZxU(descriptorProtos$FeatureHashSet);
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet2 = this.features_;
        if (descriptorProtos$FeatureHashSet2 is null || descriptorProtos$FeatureHashSet2 == bRoOAkHLVbyiPUon()) {
            this.features_ = descriptorProtos$FeatureHashSet;
        } else {
            this.features_ = (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) zVvCIbuUoCKpRaKe((androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder) EnAknloBnHELDLGe(CWpKrwJDBPlykoFh(this.features_), descriptorProtos$FeatureHashSet));
        }
        this.bitField0_ |= 8;
    }

    public static void MhChbfGTjQFeEyfD(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions, bool z) {
        descriptorProtos$EnumOptions.setAllowAlias(z);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite MtjQuviaOWhvcgfL(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions$Builder newBuilder() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions$Builder) cXBdyFhloRqYWBXu(DEFAULT_INSTANCE);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions$Builder) QwwMKWGqDQedQBcS(DEFAULT_INSTANCE, descriptorProtos$EnumOptions);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) SEvvKwbMWULQdJYP(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) LUmJCuSgCRhuuwdO(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) eCFlzbXMskCvZtcA(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) DBCjJSbVYJmBxXKw(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) VugtLmgXUixmLyCb(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) KJBgNFwmsKMMFkFY(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) CkMvMugPhHfOFgfz(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) ZgFxqRXmoljsuRav(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) mtjQuviaOWhvcgfL(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) NbXrkBjdPUzyXiar(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) IfJKhyRunJfpkjQV(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions) frNGMZVYDKhwlaWw(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions> parser() {
        return iMOefAxYBkjXfGQv(DEFAULT_INSTANCE);
    }

    public static java.lang.object QNtKoLEHWtOwmGPA(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    private void RemoveUninterpretedOption(int i) {
        OQQHiMWUFsbGfCEQ(this);
        cFCIzJJSHPFmtAmw(this.uninterpretedOption_, i);
    }

    public static java.lang.Class SALBeQWUPiBwFaNd(java.lang.object obj) {
        return obj.GetType();
    }

    private void SetAllowAlias(bool z) {
        this.bitField0_ |= 1;
        this.allowAlias_ = z;
    }

    private void SetDeprecated(bool z) {
        this.bitField0_ |= 2;
        this.deprecated_ = z;
    }

    private void SetDeprecatedLegacyJsonFieldConflicts(bool z) {
        this.bitField0_ |= 4;
        this.deprecatedLegacyJsonFieldConflicts_ = z;
    }

    private void SetFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        MrPNmhZJrcUoEWTL(descriptorProtos$FeatureHashSet);
        this.features_ = descriptorProtos$FeatureHashSet;
        this.bitField0_ |= 8;
    }

    private void SetUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        emBdBjijJMHGWemn(descriptorProtos$UninterpretedOption);
        jNqXRAmgJAwLNgFh(this);
        VBwEbbidaBJXRnBC(this.uninterpretedOption_, i, descriptorProtos$UninterpretedOption);
    }

    public static java.lang.Class TbbMBrfMBCeUcRrM(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class UVQJCwlTUtBqqZxU(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet uWHEzGKqbKSBiZzT() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance();
    }

    public static void UYSoPqCOwHVsATIf(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumOptions.clearFeatures();
    }

    public static java.lang.object XWttXlXdyCdyyOKX(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static void XbUhGPqQysYKOrNd(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumOptions.clearDeprecated();
    }

    public static void YkPDzaYrFELgcQxM(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions descriptorProtos$EnumOptions) {
        descriptorProtos$EnumOptions.clearUninterpretedOption();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage zVvCIbuUoCKpRaKe(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder descriptorProtos$FeatureHashSet$Builder) {
        return descriptorProtos$FeatureHashSet$Builder.buildPartial();
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((26 + 21) % 21 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[CQtdvqkOKkpGoWFN(generatedMessageLite$MethodToInvoke)]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions$Builder(null);
            case 3:
                return dmGPigDnUBYhtkxb(DEFAULT_INSTANCE, "\u0001\u0005\u0000\u0001\u0002ϧ\u0005\u0000\u0001\u0002\u0002ဇ\u0000\u0003ဇ\u0001\u0006ဇ\u0002\u0007ᐉ\u0003ϧЛ", new java.lang.object[]{"bitField0_", "allowAlias_", "deprecated_", "deprecatedLegacyJsonFieldConflicts_", "features_", "uninterpretedOption_", androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions.class) {
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
                return OxfvYTZbbNdeaMRm(this.memoizedIsInitialized);
            case 7:
                this.memoizedIsInitialized = (byte) (obj is not null ? 1 : 0);
                return null;
            default:
                throw new java.lang.UnsupportedOperationException();
        }
    }

    public override bool GetAllowAlias() {
        return this.allowAlias_;
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
        return descriptorProtos$FeatureHashSet is not null ? descriptorProtos$FeatureHashSet : uWHEzGKqbKSBiZzT();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption getUninterpretedOption(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) qNtKoLEHWtOwmGPA(this.uninterpretedOption_, i);
    }

    public override int GetUninterpretedOptionCount() {
        return UNNuAcFlmJYpSAgs(this.uninterpretedOption_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> getUninterpretedOptionList() {
        return this.uninterpretedOption_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOptionOrBuilder getUninterpretedOptionOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOptionOrBuilder) xWttXlXdyCdyyOKX(this.uninterpretedOption_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOptionOrBuilder> getUninterpretedOptionOrBuilderList() {
        return this.uninterpretedOption_;
    }

    public override bool HasAllowAlias() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasDeprecated() {
        return (this.bitField0_ & 2) != 0;
    }

    @java.lang.Deprecated
    public override bool HasDeprecatedLegacyJsonFieldConflicts() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasFeatures() {
        return (this.bitField0_ & 8) != 0;
    }
}

