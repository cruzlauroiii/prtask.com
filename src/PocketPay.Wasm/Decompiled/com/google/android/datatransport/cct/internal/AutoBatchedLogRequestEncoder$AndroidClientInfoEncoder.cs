namespace WillowMaze.Wasm.Decompiled;


readonly class AutoBatchedConsoleRequestEncoder$AndroidClientInfoEncoder : com.google.firebase.encoders.objectEncoder<com.google.android.datatransport.cct.internal.AndroidClientInfo> {
    static readonly com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$AndroidClientInfoEncoder INSTANCE = new com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$AndroidClientInfoEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor SDKVERSION_DESCRIPTOR = RhUPSitYnfyqAIlu("sdkVersion");
    private static readonly com.google.firebase.encoders.FieldDescriptor MODEL_DESCRIPTOR = fELKRgXpYqXWyWMu("model");
    private static readonly com.google.firebase.encoders.FieldDescriptor HARDWARE_DESCRIPTOR = yGqNMZCtXBSQnNpW("hardware");
    private static readonly com.google.firebase.encoders.FieldDescriptor DEVICE_DESCRIPTOR = WxGWvwMIgHaooIKJ("device");
    private static readonly com.google.firebase.encoders.FieldDescriptor PRODUCT_DESCRIPTOR = YREvCMUXZZheCdKm("product");
    private static readonly com.google.firebase.encoders.FieldDescriptor OSBUILD_DESCRIPTOR = jYhkfTycfLckKkOn("osBuild");
    private static readonly com.google.firebase.encoders.FieldDescriptor MANUFACTURER_DESCRIPTOR = pRWvmUKhPoXzjWPb("manufacturer");
    private static readonly com.google.firebase.encoders.FieldDescriptor FINGERPRINT_DESCRIPTOR = mMGHoPWBweVbQGMk("fingerprint");
    private static readonly com.google.firebase.encoders.FieldDescriptor LOCALE_DESCRIPTOR = EPptpahTbswHrCic("locale");
    private static readonly com.google.firebase.encoders.FieldDescriptor COUNTRY_DESCRIPTOR = wrBOVOBxulIBkEXp("country");
    private static readonly com.google.firebase.encoders.FieldDescriptor MCCMNC_DESCRIPTOR = RudTtRaGNSVcrznf("mccMnc");
    private static readonly com.google.firebase.encoders.FieldDescriptor APPLICATIONBUILD_DESCRIPTOR = MlDHNGoxVxBzgszs("applicationBuild");

    private AutoBatchedConsoleRequestEncoder$AndroidClientInfoEncoder() {
    }

    public static java.lang.string CMnnfUoEqRUDjEen(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getCountry();
    }

    public static java.lang.string DUTkAWQKKdXrGmha(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getProduct();
    }

    public static java.lang.string DzWkHiFdIdrDaovS(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getLocale();
    }

    public static com.google.firebase.encoders.FieldDescriptor EPptpahTbswHrCic(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject EjvYKHTuesKWTFVc(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject FpXUYeMeyUxqcwOR(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject JHPAVTMLqUoFijOq(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static java.lang.string MCCHzxElRIWikVkR(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getOsBuild();
    }

    public static com.google.firebase.encoders.FieldDescriptor MlDHNGoxVxBzgszs(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject RUQtLPZAQZuKTzDq(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor RhUPSitYnfyqAIlu(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor RudTtRaGNSVcrznf(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject SJNbBixvXgitDWIo(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static java.lang.int SKsGPkMjPlRCDfiV(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getSdkVersion();
    }

    public static java.lang.string SUZYNJaznuArDGKN(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getMccMnc();
    }

    public static java.lang.string ThqKkgbGbCCZLFII(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getApplicationBuild();
    }

    public static void UrvIeCzhDZHRbItj(com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder$AndroidClientInfoEncoder autoBatchedConsoleRequestEncoder$AndroidClientInfoEncoder, com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoBatchedConsoleRequestEncoder$AndroidClientInfoEncoder.encode(androidClientInfo, objectEncoderobject);
    }

    public static com.google.firebase.encoders.FieldDescriptor WxGWvwMIgHaooIKJ(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor YREvCMUXZZheCdKm(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static java.lang.string ZftwXDMDGVYPTcNz(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getDevice();
    }

    public static com.google.firebase.encoders.objectEncoderobject ZgCzuFhMCUrCbasa(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject ZmvAFRxxfTfeJWnC(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static java.lang.string BkqYKMhzvStuNUBt(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getHardware();
    }

    public static java.lang.string ECYxJvBCOcJQMWYm(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getManufacturer();
    }

    public static com.google.firebase.encoders.FieldDescriptor FELKRgXpYqXWyWMu(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static java.lang.string FqcVnlPYNNVuNKVu(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getModel();
    }

    public static com.google.firebase.encoders.objectEncoderobject HbmnUhvfcYPabppQ(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor JYhkfTycfLckKkOn(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor MMGHoPWBweVbQGMk(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor PRWvmUKhPoXzjWPb(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.objectEncoderobject QESNrWeDfshcgwFf(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject QZJKurfunAMlgwCu(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.objectEncoderobject REzQZRpMJoBfupdY(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static java.lang.string VpFLtpsxWRugnlUj(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        return androidClientInfo.getFingerprint();
    }

    public static com.google.firebase.encoders.objectEncoderobject WmbuosNAdFhSqzEN(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static com.google.firebase.encoders.FieldDescriptor WrBOVOBxulIBkEXp(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static com.google.firebase.encoders.FieldDescriptor YGqNMZCtXBSQnNpW(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public void Encode(com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        hbmnUhvfcYPabppQ(objectEncoderobject, SDKVERSION_DESCRIPTOR, SKsGPkMjPlRCDfiV(androidClientInfo));
        ZgCzuFhMCUrCbasa(objectEncoderobject, MODEL_DESCRIPTOR, fqcVnlPYNNVuNKVu(androidClientInfo));
        EjvYKHTuesKWTFVc(objectEncoderobject, HARDWARE_DESCRIPTOR, bkqYKMhzvStuNUBt(androidClientInfo));
        qESNrWeDfshcgwFf(objectEncoderobject, DEVICE_DESCRIPTOR, ZftwXDMDGVYPTcNz(androidClientInfo));
        wmbuosNAdFhSqzEN(objectEncoderobject, PRODUCT_DESCRIPTOR, DUTkAWQKKdXrGmha(androidClientInfo));
        FpXUYeMeyUxqcwOR(objectEncoderobject, OSBUILD_DESCRIPTOR, MCCHzxElRIWikVkR(androidClientInfo));
        JHPAVTMLqUoFijOq(objectEncoderobject, MANUFACTURER_DESCRIPTOR, eCYxJvBCOcJQMWYm(androidClientInfo));
        ZmvAFRxxfTfeJWnC(objectEncoderobject, FINGERPRINT_DESCRIPTOR, vpFLtpsxWRugnlUj(androidClientInfo));
        RUQtLPZAQZuKTzDq(objectEncoderobject, LOCALE_DESCRIPTOR, DzWkHiFdIdrDaovS(androidClientInfo));
        qZJKurfunAMlgwCu(objectEncoderobject, COUNTRY_DESCRIPTOR, CMnnfUoEqRUDjEen(androidClientInfo));
        rEzQZRpMJoBfupdY(objectEncoderobject, MCCMNC_DESCRIPTOR, SUZYNJaznuArDGKN(androidClientInfo));
        SJNbBixvXgitDWIo(objectEncoderobject, APPLICATIONBUILD_DESCRIPTOR, ThqKkgbGbCCZLFII(androidClientInfo));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        UrvIeCzhDZHRbItj(this, (com.google.android.datatransport.cct.internal.AndroidClientInfo) obj, objectEncoderobject);
    }
}

