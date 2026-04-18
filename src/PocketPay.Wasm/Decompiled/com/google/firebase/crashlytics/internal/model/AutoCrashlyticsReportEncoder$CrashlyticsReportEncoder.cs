namespace WillowMaze.Wasm.Decompiled;


readonly class AutoCrashlyticsReportEncoder$CrashlyticsReportEncoder : com.google.firebase.encoders.objectEncoder<com.google.firebase.crashlytics.internal.model.CrashlyticsReport> {
    static readonly com.google.firebase.crashlytics.internal.model.AutoCrashlyticsReportEncoder$CrashlyticsReportEncoder INSTANCE = new com.google.firebase.crashlytics.internal.model.AutoCrashlyticsReportEncoder$CrashlyticsReportEncoder();
    private static readonly com.google.firebase.encoders.FieldDescriptor SDKVERSION_DESCRIPTOR = pRUnIQIJwmWCNHss("sdkVersion");
    private static readonly com.google.firebase.encoders.FieldDescriptor GMPAPPID_DESCRIPTOR = SeEXyZrOUvCDoOpk("gmpAppId");
    private static readonly com.google.firebase.encoders.FieldDescriptor PLATFORM_DESCRIPTOR = twPCKmRjgWjejusc("platform");
    private static readonly com.google.firebase.encoders.FieldDescriptor INSTALLATIONGuid_DESCRIPTOR = LHQmMVSEkytuouBD("installationUuid");
    private static readonly com.google.firebase.encoders.FieldDescriptor FIREBASEINSTALLATIONID_DESCRIPTOR = gQJYtPYCndIujJEh("firebaseInstallationId");
    private static readonly com.google.firebase.encoders.FieldDescriptor FIREBASEAUTHENTICATIONTOKEN_DESCRIPTOR = dHPbKBElwxnsavFs("firebaseAuthenticationToken");
    private static readonly com.google.firebase.encoders.FieldDescriptor APPQUALITYSESSIONID_DESCRIPTOR = JttfbNskFvJzDKjM("appQualitySessionId");
    private static readonly com.google.firebase.encoders.FieldDescriptor BUILDVERSION_DESCRIPTOR = dguqeRpbTpiPoagU("buildVersion");
    private static readonly com.google.firebase.encoders.FieldDescriptor DISPLAYVERSION_DESCRIPTOR = ugoEntkjCGOKthFc("displayVersion");
    private static readonly com.google.firebase.encoders.FieldDescriptor SESSION_DESCRIPTOR = xlKIVBsEvzoNEdCg("session");
    private static readonly com.google.firebase.encoders.FieldDescriptor NDKPAYLOAD_DESCRIPTOR = OhnVAFWaiefLoHuz("ndkPayload");
    private static readonly com.google.firebase.encoders.FieldDescriptor APPEXITINFO_DESCRIPTOR = bOnIiwFAiGALIYMA("appExitInfo");

    private AutoCrashlyticsReportEncoder$CrashlyticsReportEncoder() {
    }

    public static com.google.firebase.encoders.objectEncoderobject DTJFzbMreNTIIAJJ(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void DTJFzbMreNTIIAJJ(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DTJFzbMreNTIIAJJ(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DTJFzbMreNTIIAJJ(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject EUnsaRmahVGqNTxK(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) {
        return objectEncoderobject.Add(fieldDescriptor, i);
    }

    public static void EUnsaRmahVGqNTxK(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EUnsaRmahVGqNTxK(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EUnsaRmahVGqNTxK(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FrGimUyzhnXXeLtp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getGmpAppId();
    }

    public static void FrGimUyzhnXXeLtp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FrGimUyzhnXXeLtp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FrGimUyzhnXXeLtp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int IzcOlWixAQhOzglM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getPlatform();
    }

    public static void IzcOlWixAQhOzglM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IzcOlWixAQhOzglM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IzcOlWixAQhOzglM(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor JttfbNskFvJzDKjM(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void JttfbNskFvJzDKjM(java.lang.string str, int i, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JttfbNskFvJzDKjM(java.lang.string str, short s, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JttfbNskFvJzDKjM(java.lang.string str, bool z, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor LHQmMVSEkytuouBD(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void LHQmMVSEkytuouBD(java.lang.string str, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LHQmMVSEkytuouBD(java.lang.string str, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LHQmMVSEkytuouBD(java.lang.string str, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LfgmGNrYGHcDIjQL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getFirebaseAuthenticationToken();
    }

    public static void LfgmGNrYGHcDIjQL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LfgmGNrYGHcDIjQL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LfgmGNrYGHcDIjQL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject LiBQxUWpOddxvPHY(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void LiBQxUWpOddxvPHY(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LiBQxUWpOddxvPHY(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LiBQxUWpOddxvPHY(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject MMqYKdYouDaqZivt(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void MMqYKdYouDaqZivt(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MMqYKdYouDaqZivt(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MMqYKdYouDaqZivt(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NmBhxzhYwlDvmVov(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getDisplayVersion();
    }

    public static void NmBhxzhYwlDvmVov(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NmBhxzhYwlDvmVov(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NmBhxzhYwlDvmVov(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OSrKcyWZGigNZzCp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getFirebaseInstallationId();
    }

    public static void OSrKcyWZGigNZzCp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OSrKcyWZGigNZzCp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OSrKcyWZGigNZzCp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor OhnVAFWaiefLoHuz(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void OhnVAFWaiefLoHuz(java.lang.string str, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OhnVAFWaiefLoHuz(java.lang.string str, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OhnVAFWaiefLoHuz(java.lang.string str, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session QrgiOhXNUvpJhZAB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getSession();
    }

    public static void QrgiOhXNUvpJhZAB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QrgiOhXNUvpJhZAB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QrgiOhXNUvpJhZAB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RSuNJsBqyqnIQLyw(com.google.firebase.crashlytics.internal.model.AutoCrashlyticsReportEncoder$CrashlyticsReportEncoder autoCrashlyticsReportEncoder$CrashlyticsReportEncoder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        autoCrashlyticsReportEncoder$CrashlyticsReportEncoder.encode(crashlyticsReport, objectEncoderobject);
    }

    public static void RSuNJsBqyqnIQLyw(com.google.firebase.crashlytics.internal.model.AutoCrashlyticsReportEncoder$CrashlyticsReportEncoder autoCrashlyticsReportEncoder$CrashlyticsReportEncoder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RSuNJsBqyqnIQLyw(com.google.firebase.crashlytics.internal.model.AutoCrashlyticsReportEncoder$CrashlyticsReportEncoder autoCrashlyticsReportEncoder$CrashlyticsReportEncoder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RSuNJsBqyqnIQLyw(com.google.firebase.crashlytics.internal.model.AutoCrashlyticsReportEncoder$CrashlyticsReportEncoder autoCrashlyticsReportEncoder$CrashlyticsReportEncoder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.encoders.objectEncoderobject objectEncoderobject, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject RkYyTWvwLiQNEatO(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void RkYyTWvwLiQNEatO(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RkYyTWvwLiQNEatO(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RkYyTWvwLiQNEatO(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor SeEXyZrOUvCDoOpk(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void SeEXyZrOUvCDoOpk(java.lang.string str, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SeEXyZrOUvCDoOpk(java.lang.string str, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SeEXyZrOUvCDoOpk(java.lang.string str, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject UvHTOzgDIRYYAAPb(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void UvHTOzgDIRYYAAPb(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UvHTOzgDIRYYAAPb(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UvHTOzgDIRYYAAPb(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject XGgZAByKXIjcPhKN(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void XGgZAByKXIjcPhKN(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XGgZAByKXIjcPhKN(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XGgZAByKXIjcPhKN(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor BOnIiwFAiGALIYMA(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void BOnIiwFAiGALIYMA(java.lang.string str, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BOnIiwFAiGALIYMA(java.lang.string str, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BOnIiwFAiGALIYMA(java.lang.string str, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo cdspxWEoqXwsFSRX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getAppExitInfo();
    }

    public static void CdspxWEoqXwsFSRX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CdspxWEoqXwsFSRX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CdspxWEoqXwsFSRX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor DHPbKBElwxnsavFs(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void DHPbKBElwxnsavFs(java.lang.string str, byte b, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DHPbKBElwxnsavFs(java.lang.string str, java.lang.string str2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DHPbKBElwxnsavFs(java.lang.string str, short s, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor DguqeRpbTpiPoagU(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void DguqeRpbTpiPoagU(java.lang.string str, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DguqeRpbTpiPoagU(java.lang.string str, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DguqeRpbTpiPoagU(java.lang.string str, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FErKBFgeqODtymwm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getSdkVersion();
    }

    public static void FErKBFgeqODtymwm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FErKBFgeqODtymwm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FErKBFgeqODtymwm(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor GQJYtPYCndIujJEh(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void GQJYtPYCndIujJEh(java.lang.string str, java.lang.string str2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GQJYtPYCndIujJEh(java.lang.string str, java.lang.string str2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GQJYtPYCndIujJEh(java.lang.string str, short s, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject HbhjGgRDGGPwvmpj(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void HbhjGgRDGGPwvmpj(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HbhjGgRDGGPwvmpj(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HbhjGgRDGGPwvmpj(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject IBehZEEvDOwtZKCs(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void IBehZEEvDOwtZKCs(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IBehZEEvDOwtZKCs(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IBehZEEvDOwtZKCs(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject IMzcipmKFJxDzeJb(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void IMzcipmKFJxDzeJb(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IMzcipmKFJxDzeJb(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IMzcipmKFJxDzeJb(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MffeKcTpkiHgROVc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getBuildVersion();
    }

    public static void MffeKcTpkiHgROVc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MffeKcTpkiHgROVc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MffeKcTpkiHgROVc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NpqKTSCpfbHobpPB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getAppQualitySessionId();
    }

    public static void NpqKTSCpfbHobpPB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NpqKTSCpfbHobpPB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NpqKTSCpfbHobpPB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject OHAPbgjtAixwGtIr(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void OHAPbgjtAixwGtIr(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OHAPbgjtAixwGtIr(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OHAPbgjtAixwGtIr(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor PRUnIQIJwmWCNHss(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void PRUnIQIJwmWCNHss(java.lang.string str, byte b, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PRUnIQIJwmWCNHss(java.lang.string str, int i, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PRUnIQIJwmWCNHss(java.lang.string str, java.lang.string str2, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor TwPCKmRjgWjejusc(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void TwPCKmRjgWjejusc(java.lang.string str, byte b, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TwPCKmRjgWjejusc(java.lang.string str, byte b, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TwPCKmRjgWjejusc(java.lang.string str, short s, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.objectEncoderobject UQSvHAPZfcZByneO(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) {
        return objectEncoderobject.Add(fieldDescriptor, obj);
    }

    public static void UQSvHAPZfcZByneO(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UQSvHAPZfcZByneO(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UQSvHAPZfcZByneO(com.google.firebase.encoders.objectEncoderobject objectEncoderobject, com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor UgoEntkjCGOKthFc(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void UgoEntkjCGOKthFc(java.lang.string str, float f, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UgoEntkjCGOKthFc(java.lang.string str, int i, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UgoEntkjCGOKthFc(java.lang.string str, java.lang.string str2, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XNexMChObYMvnAJP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getInstallationUuid();
    }

    public static void XNexMChObYMvnAJP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XNexMChObYMvnAJP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XNexMChObYMvnAJP(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.FieldDescriptor XlKIVBsEvzoNEdCg(java.lang.string str) {
        return com.google.firebase.encoders.FieldDescriptor.of(str);
    }

    public static void XlKIVBsEvzoNEdCg(java.lang.string str, float f, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XlKIVBsEvzoNEdCg(java.lang.string str, java.lang.string str2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XlKIVBsEvzoNEdCg(java.lang.string str, short s, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$stringsPayload zhDakZogbPdwQPmF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport) {
        return crashlyticsReport.getNdkPayload();
    }

    public static void ZhDakZogbPdwQPmF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZhDakZogbPdwQPmF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZhDakZogbPdwQPmF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public void Encode(com.google.firebase.crashlytics.internal.model.CrashlyticsReport crashlyticsReport, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        uQSvHAPZfcZByneO(objectEncoderobject, SDKVERSION_DESCRIPTOR, fErKBFgeqODtymwm(crashlyticsReport));
        LiBQxUWpOddxvPHY(objectEncoderobject, GMPAPPID_DESCRIPTOR, FrGimUyzhnXXeLtp(crashlyticsReport));
        EUnsaRmahVGqNTxK(objectEncoderobject, PLATFORM_DESCRIPTOR, IzcOlWixAQhOzglM(crashlyticsReport));
        iMzcipmKFJxDzeJb(objectEncoderobject, INSTALLATIONGuid_DESCRIPTOR, xNexMChObYMvnAJP(crashlyticsReport));
        MMqYKdYouDaqZivt(objectEncoderobject, FIREBASEINSTALLATIONID_DESCRIPTOR, OSrKcyWZGigNZzCp(crashlyticsReport));
        oHAPbgjtAixwGtIr(objectEncoderobject, FIREBASEAUTHENTICATIONTOKEN_DESCRIPTOR, LfgmGNrYGHcDIjQL(crashlyticsReport));
        XGgZAByKXIjcPhKN(objectEncoderobject, APPQUALITYSESSIONID_DESCRIPTOR, npqKTSCpfbHobpPB(crashlyticsReport));
        hbhjGgRDGGPwvmpj(objectEncoderobject, BUILDVERSION_DESCRIPTOR, mffeKcTpkiHgROVc(crashlyticsReport));
        UvHTOzgDIRYYAAPb(objectEncoderobject, DISPLAYVERSION_DESCRIPTOR, NmBhxzhYwlDvmVov(crashlyticsReport));
        RkYyTWvwLiQNEatO(objectEncoderobject, SESSION_DESCRIPTOR, QrgiOhXNUvpJhZAB(crashlyticsReport));
        iBehZEEvDOwtZKCs(objectEncoderobject, NDKPAYLOAD_DESCRIPTOR, zhDakZogbPdwQPmF(crashlyticsReport));
        DTJFzbMreNTIIAJJ(objectEncoderobject, APPEXITINFO_DESCRIPTOR, cdspxWEoqXwsFSRX(crashlyticsReport));
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.objectEncoderobject objectEncoderobject) throws java.io.IOException {
        RSuNJsBqyqnIQLyw(this, (com.google.firebase.crashlytics.internal.model.CrashlyticsReport) obj, objectEncoderobject);
    }
}

