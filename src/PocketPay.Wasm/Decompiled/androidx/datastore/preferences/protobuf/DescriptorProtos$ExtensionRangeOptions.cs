namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$ExtensionRangeOptions : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptionsOrBuilder {
    public static readonly int DECLARATION_FIELD_NUMBER = 2;
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions DEFAULT_INSTANCE;
    public static readonly int FEATURES_FIELD_NUMBER = 50;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions> PARSER = null;
    public static readonly int UNINTERPRETED_OPTION_FIELD_NUMBER = 999;
    public static readonly int VERIFICATION_FIELD_NUMBER = 3;
    private int bitField0_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet features_;
    private byte memoizedIsInitialized = 2;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> uninterpretedOption_ = VJKdeGaOKkOFAjSl();
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration> declaration_ = UlTMswtVJrETKBEN();
    private int verification_ = 1;

    static {
        if ((27 + 22) % 22 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions = new androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions();
        DEFAULT_INSTANCE = descriptorProtos$ExtensionRangeOptions;
        cesYyUwDmSrofeUj(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions.class, descriptorProtos$ExtensionRangeOptions);
    }

    private DescriptorProtos$ExtensionRangeOptions() {
    }

    public static bool APxUJIGOqGpAXiCm(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static java.lang.byte AjUrUxbPZrDZganF(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static void BMfrePWHpUrNhUCL(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.ensureUninterpretedOptionIsMutable();
    }

    public static void EPnlweLkYdFnkvYu(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$ExtensionRangeOptions.addUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite ETJDlZWnMeHINEor(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bArr, extensionRegistryLite);
    }

    public static void EXSzBzzkMoNQOsjq(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$ExtensionRangeOptions.mergeFeatures(descriptorProtos$FeatureHashSet);
    }

    public static java.lang.Class FGAZuJcpfxaUqJop(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object GFNZGubYoLwNYvRO(androidx.datastore.preferences.protobuf.MessageLite messageLite, java.lang.string str, java.lang.object[] objArr) {
        return newMessageInfo(messageLite, str, objArr);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite GysRRFHLbqiYCith(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, inputStream);
    }

    public static void HCFssPMRGaJKoptu(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.clearFeatures();
    }

    public static void HClzVqwnVLQnmnTO(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.clearDeclaration();
    }

    public static void HbUKglYWhYQiTsxz(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static void HcujuPAxRBXsttbJ(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, java.lang.IEnumerable iterable) {
        descriptorProtos$ExtensionRangeOptions.addAllUninterpretedOption(iterable);
    }

    public static void IRawboDaJiAYwshc(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.clearUninterpretedOption();
    }

    public static void JRVOtDFCCIqmXZEb(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration descriptorProtos$ExtensionRangeOptions$Declaration) {
        descriptorProtos$ExtensionRangeOptions.addDeclaration(i, descriptorProtos$ExtensionRangeOptions$Declaration);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList JvFmVygZsoNtGOpW() {
        return emptyProtobufList();
    }

    public static java.lang.Class KUczkqDJbKhWPnvL(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite KrAZMCVyrbeLkCRh(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, codedStream);
    }

    public static java.lang.object LQwhUIWcPINufMjA(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static java.lang.Class MIlKQOyWAeiqJNFI(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite MnBxfEPZBvVYrhee(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, byte[] bArr) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bArr);
    }

    public static void PInfBxjbbkISGSkD(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState descriptorProtos$ExtensionRangeOptions$VerificationState) {
        descriptorProtos$ExtensionRangeOptions.setVerification(descriptorProtos$ExtensionRangeOptions$VerificationState);
    }

    public static void PpVNXaGSCUVdKtOw(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i) {
        descriptorProtos$ExtensionRangeOptions.removeDeclaration(i);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite QJwyLhGQIhnhQYPm(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, inputStream, extensionRegistryLite);
    }

    public static void QsYggTfDqwMNZObR(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.ensureDeclarationIsMutable();
    }

    public static java.lang.object RGAqimIhecCTaDEn(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static java.lang.object RKmOOZLQzNHnrbxM(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static void RLZZmSllesuLHwco(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$ExtensionRangeOptions.addUninterpretedOption(descriptorProtos$UninterpretedOption);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList RjRPLJAoWhIiaDyi() {
        return emptyProtobufList();
    }

    public static void SwYOUmgJxSHNjNEC(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$ExtensionRangeOptions.setFeatures(descriptorProtos$FeatureHashSet);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet TRihJprjslpLwOTt() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet TXnGvoEWKpGdeAKf() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.getDefaultInstance();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite TxRbXlMSnoinAhzg(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bytestring, extensionRegistryLite);
    }

    public static void UNAHvOtZSdZJTSOb(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.ensureUninterpretedOptionIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList UlTMswtVJrETKBEN() {
        return emptyProtobufList();
    }

    public static bool VAcHnNIGcROnxbzx(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, java.lang.object obj) {
        return internal$ProtobufList.Add(obj);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList VJKdeGaOKkOFAjSl() {
        return emptyProtobufList();
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList WZZiDXyaMcCYJSfC(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.Parser YOwfClOhDwUduGpg(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        return descriptorProtos$ExtensionRangeOptions.getParserForType();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite AAmLbMYmPGczMhBz(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return parseDelimitedFrom(generatedMessageLite, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier aDRUtDeNndMcyBQE() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState.internalGetVerifier();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite ANGKbxisKxZbmsnZ(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, codedStream, extensionRegistryLite);
    }

    public static void ATCwKfgwpzAHAjCw(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions access$14800() {
        return DEFAULT_INSTANCE;
    }

    static void access$14900(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        eQaJdErhNFfRVMSJ(descriptorProtos$ExtensionRangeOptions, i, descriptorProtos$UninterpretedOption);
    }

    static void access$15000(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        RLZZmSllesuLHwco(descriptorProtos$ExtensionRangeOptions, descriptorProtos$UninterpretedOption);
    }

    static void access$15100(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        EPnlweLkYdFnkvYu(descriptorProtos$ExtensionRangeOptions, i, descriptorProtos$UninterpretedOption);
    }

    static void access$15200(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, java.lang.IEnumerable iterable) {
        HcujuPAxRBXsttbJ(descriptorProtos$ExtensionRangeOptions, iterable);
    }

    static void access$15300(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        IRawboDaJiAYwshc(descriptorProtos$ExtensionRangeOptions);
    }

    static void access$15400(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i) {
        jREUazfyVgqjBuEE(descriptorProtos$ExtensionRangeOptions, i);
    }

    static void access$15500(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration descriptorProtos$ExtensionRangeOptions$Declaration) {
        wASPbLVnZhdDUNIh(descriptorProtos$ExtensionRangeOptions, i, descriptorProtos$ExtensionRangeOptions$Declaration);
    }

    static void access$15600(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration descriptorProtos$ExtensionRangeOptions$Declaration) {
        vrKZFxTtbLpUzBXm(descriptorProtos$ExtensionRangeOptions, descriptorProtos$ExtensionRangeOptions$Declaration);
    }

    static void access$15700(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration descriptorProtos$ExtensionRangeOptions$Declaration) {
        JRVOtDFCCIqmXZEb(descriptorProtos$ExtensionRangeOptions, i, descriptorProtos$ExtensionRangeOptions$Declaration);
    }

    static void access$15800(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, java.lang.IEnumerable iterable) {
        wWPjBRBBfncmTDnX(descriptorProtos$ExtensionRangeOptions, iterable);
    }

    static void access$15900(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        HClzVqwnVLQnmnTO(descriptorProtos$ExtensionRangeOptions);
    }

    static void access$16000(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i) {
        PpVNXaGSCUVdKtOw(descriptorProtos$ExtensionRangeOptions, i);
    }

    static void access$16100(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        SwYOUmgJxSHNjNEC(descriptorProtos$ExtensionRangeOptions, descriptorProtos$FeatureHashSet);
    }

    static void access$16200(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        EXSzBzzkMoNQOsjq(descriptorProtos$ExtensionRangeOptions, descriptorProtos$FeatureHashSet);
    }

    static void access$16300(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        HCFssPMRGaJKoptu(descriptorProtos$ExtensionRangeOptions);
    }

    static void access$16400(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState descriptorProtos$ExtensionRangeOptions$VerificationState) {
        PInfBxjbbkISGSkD(descriptorProtos$ExtensionRangeOptions, descriptorProtos$ExtensionRangeOptions$VerificationState);
    }

    static void access$16500(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        jKPBFcjXOZJIcJej(descriptorProtos$ExtensionRangeOptions);
    }

    private void AddAllDeclaration(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration> iterable) {
        qwHywfDDYCedGfZn(this);
        HbUKglYWhYQiTsxz(iterable, this.declaration_);
    }

    private void AddAllUninterpretedOption(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> iterable) {
        cKkqOXfqsbDGmwnJ(this);
        xaYcuNoglvEtyeOp(iterable, this.uninterpretedOption_);
    }

    private void AddDeclaration(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration descriptorProtos$ExtensionRangeOptions$Declaration) {
        iepCwnmwcQKnCuze(descriptorProtos$ExtensionRangeOptions$Declaration);
        nCByAVWawZqsspGH(this);
        aTCwKfgwpzAHAjCw(this.declaration_, i, descriptorProtos$ExtensionRangeOptions$Declaration);
    }

    private void AddDeclaration(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration descriptorProtos$ExtensionRangeOptions$Declaration) {
        ktlTUXjzRrmSIeLq(descriptorProtos$ExtensionRangeOptions$Declaration);
        QsYggTfDqwMNZObR(this);
        APxUJIGOqGpAXiCm(this.declaration_, descriptorProtos$ExtensionRangeOptions$Declaration);
    }

    private void AddUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        qlxgCmzScNDVSDKJ(descriptorProtos$UninterpretedOption);
        BMfrePWHpUrNhUCL(this);
        yDKGXIxJYIgqhvmA(this.uninterpretedOption_, i, descriptorProtos$UninterpretedOption);
    }

    private void AddUninterpretedOption(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        MIlKQOyWAeiqJNFI(descriptorProtos$UninterpretedOption);
        ufXJKkftqfIaTIpn(this);
        VAcHnNIGcROnxbzx(this.uninterpretedOption_, descriptorProtos$UninterpretedOption);
    }

    public static java.lang.object BpXuRicvoEaAbcXZ(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static void CKkqOXfqsbDGmwnJ(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.ensureUninterpretedOptionIsMutable();
    }

    public static int CNyzdxurLVealNfR(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static void CesYyUwDmSrofeUj(java.lang.Class cls, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(cls, generatedMessageLite);
    }

    private void ClearDeclaration() {
        this.declaration_ = JvFmVygZsoNtGOpW();
    }

    private void ClearFeatures() {
        this.features_ = null;
        this.bitField0_ &= -2;
    }

    private void ClearUninterpretedOption() {
        this.uninterpretedOption_ = RjRPLJAoWhIiaDyi();
    }

    private void ClearVerification() {
        this.bitField0_ &= -3;
        this.verification_ = 1;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState dRMIbpFqBmTfhgZl(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState.forNumber(i);
    }

    public static void DubNZUGODjDpVwgf(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.ensureUninterpretedOptionIsMutable();
    }

    public static void EQaJdErhNFfRVMSJ(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$ExtensionRangeOptions.setUninterpretedOption(i, descriptorProtos$UninterpretedOption);
    }

    private void EnsureDeclarationIsMutable() {
        if ((15 + 29) % 29 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration> internal$ProtobufList = this.declaration_;
        if (sEIeypjIAEEokkad(internal$ProtobufList)) {
            return;
        }
        this.declaration_ = WZZiDXyaMcCYJSfC(internal$ProtobufList);
    }

    private void EnsureUninterpretedOptionIsMutable() {
        if ((7 + 14) % 14 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> internal$ProtobufList = this.uninterpretedOption_;
        if (kNuGUupDBJWEfyJR(internal$ProtobufList)) {
            return;
        }
        this.uninterpretedOption_ = wcuJYfhSldqAjyZP(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite EpqkTVJHruDuTyjr(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, byteBuffer, extensionRegistryLite);
    }

    public static java.lang.object FtUtPKSjbtvqApPl(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite GpOaVGhEFlZghMPe(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder huFxfJGgNkXYZuUy(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        return descriptorProtos$ExtensionRangeOptions.createBuilder(generatedMessageLite);
    }

    public static java.lang.Class IepCwnmwcQKnCuze(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder ilYytnLkpYyMIQCK(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder descriptorProtos$FeatureHashSet$Builder, androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite) {
        return descriptorProtos$FeatureHashSet$Builder.mergeFrom(generatedMessageLite);
    }

    public static java.lang.object JIhupsPRuiSeydeK(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        return internal$ProtobufList.set(i, obj);
    }

    public static void JKPBFcjXOZJIcJej(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.clearVerification();
    }

    public static void JREUazfyVgqjBuEE(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i) {
        descriptorProtos$ExtensionRangeOptions.removeUninterpretedOption(i);
    }

    public static bool KNuGUupDBJWEfyJR(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    public static java.lang.Class KtlTUXjzRrmSIeLq(java.lang.object obj) {
        return obj.GetType();
    }

    private void MergeFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        if ((10 + 22) % 22 > 0) {
        }
        KUczkqDJbKhWPnvL(descriptorProtos$FeatureHashSet);
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet2 = this.features_;
        if (descriptorProtos$FeatureHashSet2 is null || descriptorProtos$FeatureHashSet2 == TRihJprjslpLwOTt()) {
            this.features_ = descriptorProtos$FeatureHashSet;
        } else {
            this.features_ = (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) pWBcnMHaLWjWmnQM((androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder) ilYytnLkpYyMIQCK(rwoFMFfbwdNPNoAj(this.features_), descriptorProtos$FeatureHashSet));
        }
        this.bitField0_ |= 1;
    }

    public static void NCByAVWawZqsspGH(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.ensureDeclarationIsMutable();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite NYlbgFXSwjpbSiqT(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.io.Stream inputStream) {
        return parseDelimitedFrom(generatedMessageLite, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Builder newBuilder() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Builder) ysqKNtXBqhUDOdVE(DEFAULT_INSTANCE);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Builder) huFxfJGgNkXYZuUy(DEFAULT_INSTANCE, descriptorProtos$ExtensionRangeOptions);
    }

    public static int OYjZQXRYyelVvDEm(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState descriptorProtos$ExtensionRangeOptions$VerificationState) {
        return descriptorProtos$ExtensionRangeOptions$VerificationState.getNumber();
    }

    public static java.lang.Class OdhrpUmFRNFRppVa(java.lang.object obj) {
        return obj.GetType();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage pWBcnMHaLWjWmnQM(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder descriptorProtos$FeatureHashSet$Builder) {
        return descriptorProtos$FeatureHashSet$Builder.buildPartial();
    }

    public static int PWchnmBepDVUsZYY(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke) {
        return generatedMessageLite$MethodToInvoke.ordinal();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) nYlbgFXSwjpbSiqT(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) aAmLbMYmPGczMhBz(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) gpOaVGhEFlZghMPe(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) TxRbXlMSnoinAhzg(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) KrAZMCVyrbeLkCRh(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) aNGKbxisKxZbmsnZ(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) GysRRFHLbqiYCith(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) QJwyLhGQIhnhQYPm(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) vumrUIDnkQHzjJQb(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) epqkTVJHruDuTyjr(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) MnBxfEPZBvVYrhee(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions) ETJDlZWnMeHINEor(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions> parser() {
        return YOwfClOhDwUduGpg(DEFAULT_INSTANCE);
    }

    public static java.lang.Class QRVxgQPqLQaTcmXD(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class QlxgCmzScNDVSDKJ(java.lang.object obj) {
        return obj.GetType();
    }

    public static void QwHywfDDYCedGfZn(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.ensureDeclarationIsMutable();
    }

    private void RemoveDeclaration(int i) {
        vOZKfMAgIHFjpLjT(this);
        uWtahToqwiVEwelL(this.declaration_, i);
    }

    private void RemoveUninterpretedOption(int i) {
        dubNZUGODjDpVwgf(this);
        bpXuRicvoEaAbcXZ(this.uninterpretedOption_, i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder rwoFMFfbwdNPNoAj(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.newBuilder(descriptorProtos$FeatureHashSet);
    }

    public static bool SEIeypjIAEEokkad(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.isModifiable();
    }

    private void SetDeclaration(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration descriptorProtos$ExtensionRangeOptions$Declaration) {
        qRVxgQPqLQaTcmXD(descriptorProtos$ExtensionRangeOptions$Declaration);
        xPuiARaqSReJThUL(this);
        jIhupsPRuiSeydeK(this.declaration_, i, descriptorProtos$ExtensionRangeOptions$Declaration);
    }

    private void SetFeatures(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        FGAZuJcpfxaUqJop(descriptorProtos$FeatureHashSet);
        this.features_ = descriptorProtos$FeatureHashSet;
        this.bitField0_ |= 1;
    }

    private void SetUninterpretedOption(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        odhrpUmFRNFRppVa(descriptorProtos$UninterpretedOption);
        UNAHvOtZSdZJTSOb(this);
        RGAqimIhecCTaDEn(this.uninterpretedOption_, i, descriptorProtos$UninterpretedOption);
    }

    private void SetVerification(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState descriptorProtos$ExtensionRangeOptions$VerificationState) {
        this.verification_ = oYjZQXRYyelVvDEm(descriptorProtos$ExtensionRangeOptions$VerificationState);
        this.bitField0_ |= 2;
    }

    public static int TeeucpSxGcxTRexQ(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return internal$ProtobufList.Count;
    }

    public static java.lang.object UWtahToqwiVEwelL(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList.Remove(i);
    }

    public static void UfXJKkftqfIaTIpn(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.ensureUninterpretedOptionIsMutable();
    }

    public static void VOZKfMAgIHFjpLjT(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.ensureDeclarationIsMutable();
    }

    public static void VrKZFxTtbLpUzBXm(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration descriptorProtos$ExtensionRangeOptions$Declaration) {
        descriptorProtos$ExtensionRangeOptions.addDeclaration(descriptorProtos$ExtensionRangeOptions$Declaration);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite VumrUIDnkQHzjJQb(androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLite, java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(generatedMessageLite, byteBuffer);
    }

    public static void WASPbLVnZhdDUNIh(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration descriptorProtos$ExtensionRangeOptions$Declaration) {
        descriptorProtos$ExtensionRangeOptions.setDeclaration(i, descriptorProtos$ExtensionRangeOptions$Declaration);
    }

    public static void WWPjBRBBfncmTDnX(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions, java.lang.IEnumerable iterable) {
        descriptorProtos$ExtensionRangeOptions.addAllDeclaration(iterable);
    }

    public static androidx.datastore.preferences.protobuf.Internal$ProtobufList wcuJYfhSldqAjyZP(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList) {
        return androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static void XPuiARaqSReJThUL(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        descriptorProtos$ExtensionRangeOptions.ensureDeclarationIsMutable();
    }

    public static void XaYcuNoglvEtyeOp(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, list);
    }

    public static void YDKGXIxJYIgqhvmA(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i, java.lang.object obj) {
        internal$ProtobufList.Add(i, obj);
    }

    public static java.lang.object YfSrbnLqFKDHUrGA(androidx.datastore.preferences.protobuf.Internal$ProtobufList internal$ProtobufList, int i) {
        return internal$ProtobufList[i);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder ysqKNtXBqhUDOdVE(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions descriptorProtos$ExtensionRangeOptions) {
        return descriptorProtos$ExtensionRangeOptions.createBuilder();
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((16 + 22) % 22 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[pWchnmBepDVUsZYY(generatedMessageLite$MethodToInvoke)]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Builder(null);
            case 3:
                return GFNZGubYoLwNYvRO(DEFAULT_INSTANCE, "\u0001\u0004\u0000\u0001\u0002ϧ\u0004\u0000\u0002\u0002\u0002\u001b\u0003᠌\u00012ᐉ\u0000ϧЛ", new java.lang.object[]{"bitField0_", "declaration_", androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration.class, "verification_", aDRUtDeNndMcyBQE(), "features_", "uninterpretedOption_", androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption.class});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions.class) {
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
                return AjUrUxbPZrDZganF(this.memoizedIsInitialized);
            case 7:
                this.memoizedIsInitialized = (byte) (obj is not null ? 1 : 0);
                return null;
            default:
                throw new java.lang.UnsupportedOperationException();
        }
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration getDeclaration(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration) yfSrbnLqFKDHUrGA(this.declaration_, i);
    }

    public override int GetDeclarationCount() {
        return cNyzdxurLVealNfR(this.declaration_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$Declaration> getDeclarationList() {
        return this.declaration_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$DeclarationOrBuilder getDeclarationOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$DeclarationOrBuilder) RKmOOZLQzNHnrbxM(this.declaration_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$DeclarationOrBuilder> getDeclarationOrBuilderList() {
        return this.declaration_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet = this.features_;
        return descriptorProtos$FeatureHashSet is not null ? descriptorProtos$FeatureHashSet : TXnGvoEWKpGdeAKf();
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption getUninterpretedOption(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) LQwhUIWcPINufMjA(this.uninterpretedOption_, i);
    }

    public override int GetUninterpretedOptionCount() {
        return teeucpSxGcxTRexQ(this.uninterpretedOption_);
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> getUninterpretedOptionList() {
        return this.uninterpretedOption_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOptionOrBuilder getUninterpretedOptionOrBuilder(int i) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOptionOrBuilder) ftUtPKSjbtvqApPl(this.uninterpretedOption_, i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOptionOrBuilder> getUninterpretedOptionOrBuilderList() {
        return this.uninterpretedOption_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState getVerification() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState descriptorProtos$ExtensionRangeOptions$VerificationStateDRMIbpFqBmTfhgZl = dRMIbpFqBmTfhgZl(this.verification_);
        return descriptorProtos$ExtensionRangeOptions$VerificationStateDRMIbpFqBmTfhgZl is not null ? descriptorProtos$ExtensionRangeOptions$VerificationStateDRMIbpFqBmTfhgZl : androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState.UNVERIFIED;
    }

    public override bool HasFeatures() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasVerification() {
        return (this.bitField0_ & 2) != 0;
    }
}

