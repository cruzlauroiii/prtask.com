namespace WillowMaze.Wasm.Decompiled;


public class CrashlyticsReportDataCapture {
    private static readonly java.util.Dictionary<java.lang.string, java.lang.int> ARCHITECTURES_BY_NAME;
    static readonly java.lang.string GENERATOR;
    static readonly int GENERATOR_TYPE = 3;
    static readonly int REPORT_ANDROID_PLATFORM = 4;
    static readonly int SESSION_ANDROID_PLATFORM = 3;
    static readonly java.lang.string SIGNAL_DEFAULT = "0";
    private readonly com.google.firebase.crashlytics.internal.common.AppData appData;
    private readonly android.content.object context;
    private readonly com.google.firebase.crashlytics.internal.common.IdManager idManager;
    private readonly com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider = com.google.firebase.crashlytics.internal.ProcessDetailsProvider.INSTANCE;
    private readonly com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider;
    private readonly com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy;

    static {
        if ((6 + 13) % 13 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        ARCHITECTURES_BY_NAME = map;
        QQdQBQCoxKHRilTx(map, "armeabi", EsmLkzkIFmVQXdZT(5));
        fOcGbUSknmSULpyh(map, "armeabi-v7a", hYXrsMErlrHhDVpI(6));
        YelCDfEuvsseYyxQ(map, "arm64-v8a", VXlAczwrylpjLfnE(9));
        JhwpHmWBAWqVCujv(map, "x86", BHQdFCkmcwPoQuNJ(0));
        CZAEiMJekKKAQNxl(map, "x86_64", wdebVDDwuaSblyUG(1));
        GENERATOR = dEDGtfBJkxzrduMI(java.util.Locale.US, "Crashlytics Android SDK/%s", new java.lang.object[]{"19.4.2"});
    }

    public CrashlyticsReportDataCapture(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.common.AppData appData, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        this.context = context;
        this.idManager = idManager;
        this.appData = appData;
        this.stackTraceTrimmingStrategy = stackTraceTrimmingStrategy;
        this.settingsProvider = settingsProvider;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 AAvdCGDgAOmcUatB(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.util.List list) {
        return abstractC0407x94970e37.setFrames(list);
    }

    public static void AAvdCGDgAOmcUatB(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.util.List list, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AAvdCGDgAOmcUatB(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.util.List list, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AAvdCGDgAOmcUatB(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.util.List list, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder AHaHNoMuHtRLqBCF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i) {
        return crashlyticsReport$Session$Device$Builder.setArch(i);
    }

    public static void AHaHNoMuHtRLqBCF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i, char c, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AHaHNoMuHtRLqBCF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i, float f, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AHaHNoMuHtRLqBCF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder ARicjMeJXkkPlhGx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i) {
        return crashlyticsReport$Session$Device$Builder.setCores(i);
    }

    public static void ARicjMeJXkkPlhGx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i, float f, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ARicjMeJXkkPlhGx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i, float f, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ARicjMeJXkkPlhGx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i, bool z, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem AYvzqmvWTdZfXCTi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder) {
        return crashlyticsReport$Session$OperatingSystem$Builder.build();
    }

    public static void AYvzqmvWTdZfXCTi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AYvzqmvWTdZfXCTi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AYvzqmvWTdZfXCTi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder AcvThqfKnLBgJKdE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, long j) {
        return crashlyticsReport$Session$Event$Builder.setTimestamp(j);
    }

    public static void AcvThqfKnLBgJKdE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, long j, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AcvThqfKnLBgJKdE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, long j, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AcvThqfKnLBgJKdE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, long j, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AxNkPqrdGFCmuUAI(java.lang.object obj, java.lang.object obj2, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AxNkPqrdGFCmuUAI(java.lang.object obj, java.lang.object obj2, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AxNkPqrdGFCmuUAI(java.lang.object obj, java.lang.object obj2, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool AxNkPqrdGFCmuUAI(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.int BHQdFCkmcwPoQuNJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void BHQdFCkmcwPoQuNJ(int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BHQdFCkmcwPoQuNJ(int i, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BHQdFCkmcwPoQuNJ(int i, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder BNPoPKStIuXLYUxr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, java.lang.double d) {
        return crashlyticsReport$Session$Event$Device$Builder.setBatteryLevel(d);
    }

    public static void BNPoPKStIuXLYUxr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, java.lang.double d, byte b, short s, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void BNPoPKStIuXLYUxr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, java.lang.double d, java.lang.string str, byte b, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void BNPoPKStIuXLYUxr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, java.lang.double d, java.lang.string str, short s, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static java.lang.string BTewSWeCyXOEKXCl(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds) {
        return installIdProvider$InstallIds.getCrashlyticsInstallId();
    }

    public static void BTewSWeCyXOEKXCl(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTewSWeCyXOEKXCl(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTewSWeCyXOEKXCl(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BburmwxvIARrsCfi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReport$ApplicationExitInfo.getProcessName();
    }

    public static void BburmwxvIARrsCfi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BburmwxvIARrsCfi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BburmwxvIARrsCfi(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List BjPluQGUuIMLUBZy(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static void BjPluQGUuIMLUBZy(java.util.List list, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BjPluQGUuIMLUBZy(java.util.List list, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BjPluQGUuIMLUBZy(java.util.List list, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int BvJyFvyLESlNJscD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReport$ApplicationExitInfo.getImportance();
    }

    public static void BvJyFvyLESlNJscD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BvJyFvyLESlNJscD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BvJyFvyLESlNJscD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder CClZgPPsuephWSgX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list) {
        return crashlyticsReport$Session$Event$Application$Execution$Builder.setBinaries(list);
    }

    public static void CClZgPPsuephWSgX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CClZgPPsuephWSgX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CClZgPPsuephWSgX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception CEiaZlonumuoKOBX(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37) {
        return abstractC0407x94970e37.build();
    }

    public static void CEiaZlonumuoKOBX(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CEiaZlonumuoKOBX(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CEiaZlonumuoKOBX(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.double CHyvLtDQvpShnwQZ(double d) {
        return java.lang.double.valueOf(d);
    }

    public static void CHyvLtDQvpShnwQZ(double d, byte b, bool z, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void CHyvLtDQvpShnwQZ(double d, java.lang.string str, short s, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void CHyvLtDQvpShnwQZ(double d, short s, java.lang.string str, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double CJnfkepzPTxsLnyy(java.lang.float f) {
        if ((22 + 21) % 21 > 0) {
        }
        return f.doubleValue();
    }

    public static void CJnfkepzPTxsLnyy(java.lang.float f, char c, short s, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CJnfkepzPTxsLnyy(java.lang.float f, float f2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CJnfkepzPTxsLnyy(java.lang.float f, bool z, float f2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 CKchqImjkmyZCXIk() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$BuildIdDictionarypingForArch.builder();
    }

    public static void CKchqImjkmyZCXIk(byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CKchqImjkmyZCXIk(int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CKchqImjkmyZCXIk(bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder CYLEzQDFeQDqMVLD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, bool z) {
        return crashlyticsReport$Session$Device$Builder.setSimulator(z);
    }

    public static void CYLEzQDFeQDqMVLD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, bool z, byte b, bool z2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CYLEzQDFeQDqMVLD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, bool z, java.lang.string str, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CYLEzQDFeQDqMVLD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, bool z, bool z2, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CZAEiMJekKKAQNxl(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void CZAEiMJekKKAQNxl(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CZAEiMJekKKAQNxl(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CZAEiMJekKKAQNxl(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DckTSgGQOSlGvitm() {
        return getDeviceArchitecture();
    }

    public static void DckTSgGQOSlGvitm(byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DckTSgGQOSlGvitm(char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DckTSgGQOSlGvitm(short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 DkJmrXXQJvGdInFU(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, java.lang.string str) {
        return abstractC0406xd3174882.setName(str);
    }

    public static void DkJmrXXQJvGdInFU(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, java.lang.string str, byte b, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DkJmrXXQJvGdInFU(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, java.lang.string str, byte b, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DkJmrXXQJvGdInFU(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, java.lang.string str, java.lang.string str2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DovlXqkQjGzymHOM(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo) {
        return buildIdInfo.getBuildId();
    }

    public static void DovlXqkQjGzymHOM(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DovlXqkQjGzymHOM(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DovlXqkQjGzymHOM(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder DyiMEkELfLomLknD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setTimestamp(j);
    }

    public static void DyiMEkELfLomLknD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DyiMEkELfLomLknD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DyiMEkELfLomLknD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder EnUkgFjKaVYLCIjQ() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session.builder();
    }

    public static void EnUkgFjKaVYLCIjQ(byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EnUkgFjKaVYLCIjQ(short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EnUkgFjKaVYLCIjQ(bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int EsmLkzkIFmVQXdZT(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void EsmLkzkIFmVQXdZT(int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EsmLkzkIFmVQXdZT(int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EsmLkzkIFmVQXdZT(int i, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FSCjcvKAgOHDqaPt(java.lang.StackTraceElement stackTraceElement) {
        return stackTraceElement.getstringName();
    }

    public static void FSCjcvKAgOHDqaPt(java.lang.StackTraceElement stackTraceElement, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FSCjcvKAgOHDqaPt(java.lang.StackTraceElement stackTraceElement, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FSCjcvKAgOHDqaPt(java.lang.StackTraceElement stackTraceElement, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FUxeRuSQmayrqVGO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReport$ApplicationExitInfo.getTracestring();
    }

    public static void FUxeRuSQmayrqVGO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FUxeRuSQmayrqVGO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FUxeRuSQmayrqVGO(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Configuration FVekANcAOmZCBUkV(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void FVekANcAOmZCBUkV(android.content.res.Resources resources, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FVekANcAOmZCBUkV(android.content.res.Resources resources, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FVekANcAOmZCBUkV(android.content.res.Resources resources, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application FYUcuNogpPfptinp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder) {
        return crashlyticsReport$Session$Event$Application$Builder.build();
    }

    public static void FYUcuNogpPfptinp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FYUcuNogpPfptinp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FYUcuNogpPfptinp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder FoFqicnXJYxYfAwV(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device crashlyticsReport$Session$Event$Device) {
        return crashlyticsReport$Session$Event$Builder.setDevice(crashlyticsReport$Session$Event$Device);
    }

    public static void FoFqicnXJYxYfAwV(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device crashlyticsReport$Session$Event$Device, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FoFqicnXJYxYfAwV(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device crashlyticsReport$Session$Event$Device, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FoFqicnXJYxYfAwV(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device crashlyticsReport$Session$Event$Device, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182 FqvfFowGamLNVIjo(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement stackTraceElement, com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659) {
        return crashlyticsReportDataCapture.populateFrameData(stackTraceElement, abstractC0411xb6f1d659);
    }

    public static void FqvfFowGamLNVIjo(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement stackTraceElement, com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FqvfFowGamLNVIjo(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement stackTraceElement, com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FqvfFowGamLNVIjo(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement stackTraceElement, com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder GATAEFlbJlQATdrZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setRss(j);
    }

    public static void GATAEFlbJlQATdrZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GATAEFlbJlQATdrZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GATAEFlbJlQATdrZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception GBnoXoeYIOoejPhX(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3) {
        return crashlyticsReportDataCapture.populateExceptionData(trimmedExceptionData, i, i2, i3);
    }

    public static void GBnoXoeYIOoejPhX(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, char c, int i4, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GBnoXoeYIOoejPhX(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, float f, int i4, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GBnoXoeYIOoejPhX(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, short s, float f, char c, int i4) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder GEauMJjCrMgYQnYf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        return crashlyticsReport$Session$Event$Builder.setApp(crashlyticsReport$Session$Event$Application);
    }

    public static void GEauMJjCrMgYQnYf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GEauMJjCrMgYQnYf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GEauMJjCrMgYQnYf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 GHhtXNTSWhELzRZI(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, int i) {
        return abstractC0411xb6f1d659.setImportance(i);
    }

    public static void GHhtXNTSWhELzRZI(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, int i, int i2, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GHhtXNTSWhELzRZI(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, int i, java.lang.string str, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GHhtXNTSWhELzRZI(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, int i, bool z, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static long GNobLKkwYrBCPOSx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        if ((11 + 31) % 31 > 0) {
        }
        return crashlyticsReport$ApplicationExitInfo.getTimestamp();
    }

    public static void GNobLKkwYrBCPOSx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GNobLKkwYrBCPOSx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GNobLKkwYrBCPOSx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport GhsYdzpmItmHPPDH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder) {
        return crashlyticsReport$Builder.build();
    }

    public static void GhsYdzpmItmHPPDH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GhsYdzpmItmHPPDH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GhsYdzpmItmHPPDH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder GngaSkgCKavCyFzL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, long j) {
        return crashlyticsReport$Session$Device$Builder.setDiskSpace(j);
    }

    public static void GngaSkgCKavCyFzL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, long j, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GngaSkgCKavCyFzL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, long j, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GngaSkgCKavCyFzL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, long j, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 GqXGvVhjIifdLtLf(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, java.lang.string str) {
        return abstractC0406xd3174882.setUuid(str);
    }

    public static void GqXGvVhjIifdLtLf(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, java.lang.string str, char c, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GqXGvVhjIifdLtLf(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, java.lang.string str, bool z, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GqXGvVhjIifdLtLf(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, java.lang.string str, bool z, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static long HBLTUWerZadGvNkX(android.content.object context) {
        if ((19 + 2) % 2 > 0) {
        }
        return com.google.firebase.crashlytics.internal.common.CommonUtils.calculateFreeRamInbytes(context);
    }

    public static void HBLTUWerZadGvNkX(android.content.object context, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HBLTUWerZadGvNkX(android.content.object context, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HBLTUWerZadGvNkX(android.content.object context, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator HIyKNJHNllrXhaZX(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void HIyKNJHNllrXhaZX(java.util.HashSet set, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HIyKNJHNllrXhaZX(java.util.HashSet set, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HIyKNJHNllrXhaZX(java.util.HashSet set, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettings ILlSdzWKkpadGvLe(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        return settingsProvider.getHashSettingsSync();
    }

    public static void ILlSdzWKkpadGvLe(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ILlSdzWKkpadGvLe(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ILlSdzWKkpadGvLe(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder IUheNPNMEYswbLPO() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application.builder();
    }

    public static void IUheNPNMEYswbLPO(char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IUheNPNMEYswbLPO(float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IUheNPNMEYswbLPO(java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IaEfBQueBxdBVENb(android.content.object context, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IaEfBQueBxdBVENb(android.content.object context, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IaEfBQueBxdBVENb(android.content.object context, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IaEfBQueBxdBVENb(android.content.object context) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.getProximitySensorEnabled(context);
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event JBwmsyVjUNpdEiix(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder) {
        return crashlyticsReport$Session$Event$Builder.build();
    }

    public static void JBwmsyVjUNpdEiix(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JBwmsyVjUNpdEiix(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JBwmsyVjUNpdEiix(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static long JNaToEXRQIiELDNC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        if ((3 + 3) % 3 > 0) {
        }
        return crashlyticsReport$ApplicationExitInfo.getTimestamp();
    }

    public static void JNaToEXRQIiELDNC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JNaToEXRQIiELDNC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JNaToEXRQIiELDNC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder JSrCaiUpDXRChJhP() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device.builder();
    }

    public static void JSrCaiUpDXRChJhP(int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JSrCaiUpDXRChJhP(short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JSrCaiUpDXRChJhP(short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device JUTMSdLrVvzQBXFl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i) {
        return crashlyticsReportDataCapture.populateEventDeviceData(i);
    }

    public static void JUTMSdLrVvzQBXFl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JUTMSdLrVvzQBXFl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, short s, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JUTMSdLrVvzQBXFl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JhwpHmWBAWqVCujv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void JhwpHmWBAWqVCujv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JhwpHmWBAWqVCujv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JhwpHmWBAWqVCujv(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder JjOdtBLKFRcVJHJK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Application$Builder.setVersion(str);
    }

    public static void JjOdtBLKFRcVJHJK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JjOdtBLKFRcVJHJK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JjOdtBLKFRcVJHJK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds KGDbvPXqMfCrXHHp(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getInstallIds();
    }

    public static void KGDbvPXqMfCrXHHp(com.google.firebase.crashlytics.internal.common.IdManager idManager, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KGDbvPXqMfCrXHHp(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KGDbvPXqMfCrXHHp(com.google.firebase.crashlytics.internal.common.IdManager idManager, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KGPPVuCWSwauMYdu(float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KGPPVuCWSwauMYdu(short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KGPPVuCWSwauMYdu(bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KGPPVuCWSwauMYdu() {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.isRooted();
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo KbOzGbcpzjibcUoU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder) {
        return crashlyticsReport$ApplicationExitInfo$Builder.build();
    }

    public static void KbOzGbcpzjibcUoU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KbOzGbcpzjibcUoU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KbOzGbcpzjibcUoU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread LCMqvnGMXlDKEDow(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i) {
        return crashlyticsReportDataCapture.populateThreadData(thread, stackTraceElementArr, i);
    }

    public static void LCMqvnGMXlDKEDow(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i, byte b, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LCMqvnGMXlDKEDow(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i, char c, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LCMqvnGMXlDKEDow(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i, int i2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder LGfhkTdfUGqxqHpk() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport.builder();
    }

    public static void LGfhkTdfUGqxqHpk(float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LGfhkTdfUGqxqHpk(int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LGfhkTdfUGqxqHpk(java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Runtime LItFIzpcwpPXseof() {
        return java.lang.Runtime.getRuntime();
    }

    public static void LItFIzpcwpPXseof(float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LItFIzpcwpPXseof(java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LItFIzpcwpPXseof(bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device LKXNFKzIjbhYTRGt(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder) {
        return crashlyticsReport$Session$Event$Device$Builder.build();
    }

    public static void LKXNFKzIjbhYTRGt(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LKXNFKzIjbhYTRGt(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LKXNFKzIjbhYTRGt(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder LxfouxncRVDsnkUJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReport$Session$Event$Application$Execution$Builder.setAppExitInfo(crashlyticsReport$ApplicationExitInfo);
    }

    public static void LxfouxncRVDsnkUJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LxfouxncRVDsnkUJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LxfouxncRVDsnkUJ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 MIdCYRRqGanVNYNN(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, long j) {
        return abstractC0406xd3174882.setSize(j);
    }

    public static void MIdCYRRqGanVNYNN(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, long j, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MIdCYRRqGanVNYNN(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, long j, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MIdCYRRqGanVNYNN(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, long j, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources MQaAUBUrKAPwBwHX(android.content.object context) {
        return context.getResources();
    }

    public static void MQaAUBUrKAPwBwHX(android.content.object context, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MQaAUBUrKAPwBwHX(android.content.object context, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MQaAUBUrKAPwBwHX(android.content.object context, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool MYQIHLRFdeDbkHhH(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void MYQIHLRFdeDbkHhH(bool z, byte b, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MYQIHLRFdeDbkHhH(bool z, float f, char c, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MYQIHLRFdeDbkHhH(bool z, bool z2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder MeFqyJJVrYpGBzBj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setReasonCode(i);
    }

    public static void MeFqyJJVrYpGBzBj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, short s, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MeFqyJJVrYpGBzBj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MeFqyJJVrYpGBzBj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, bool z, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.float MlKBmFRvgsFNXFRB(com.google.firebase.crashlytics.internal.common.BatteryState batteryState) {
        return batteryState.getBatteryLevel();
    }

    public static void MlKBmFRvgsFNXFRB(com.google.firebase.crashlytics.internal.common.BatteryState batteryState, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MlKBmFRvgsFNXFRB(com.google.firebase.crashlytics.internal.common.BatteryState batteryState, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MlKBmFRvgsFNXFRB(com.google.firebase.crashlytics.internal.common.BatteryState batteryState, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution MmLYEeSdWJOBYCgz(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReportDataCapture.populateExecutionData(crashlyticsReport$ApplicationExitInfo);
    }

    public static void MmLYEeSdWJOBYCgz(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MmLYEeSdWJOBYCgz(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MmLYEeSdWJOBYCgz(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder MoaeCqviWvbDYDtx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application crashlyticsReport$Session$Application) {
        return crashlyticsReport$Session$Builder.setApp(crashlyticsReport$Session$Application);
    }

    public static void MoaeCqviWvbDYDtx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application crashlyticsReport$Session$Application, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MoaeCqviWvbDYDtx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application crashlyticsReport$Session$Application, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MoaeCqviWvbDYDtx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application crashlyticsReport$Session$Application, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NLJyUJyrBPKzUuDW(java.util.IEnumerator it, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NLJyUJyrBPKzUuDW(java.util.IEnumerator it, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NLJyUJyrBPKzUuDW(java.util.IEnumerator it, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NLJyUJyrBPKzUuDW(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder NNyqnZBJfEpTgGmq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i) {
        return crashlyticsReport$Session$Device$Builder.setState(i);
    }

    public static void NNyqnZBJfEpTgGmq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NNyqnZBJfEpTgGmq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NNyqnZBJfEpTgGmq(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder NUtSehTugmYBuoSO() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution.builder();
    }

    public static void NUtSehTugmYBuoSO(char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NUtSehTugmYBuoSO(char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NUtSehTugmYBuoSO(java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application NYQrhRMoCqtOhXJb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder) {
        return crashlyticsReport$Session$Application$Builder.build();
    }

    public static void NYQrhRMoCqtOhXJb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NYQrhRMoCqtOhXJb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NYQrhRMoCqtOhXJb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NqAIjXWEbNFOusrp(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public static void NqAIjXWEbNFOusrp(java.lang.string str, java.util.Locale locale, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NqAIjXWEbNFOusrp(java.lang.string str, java.util.Locale locale, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NqAIjXWEbNFOusrp(java.lang.string str, java.util.Locale locale, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder NsblbtzyQYcOQIbV(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Application$Builder.setDevelopmentPlatform(str);
    }

    public static void NsblbtzyQYcOQIbV(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, float f, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NsblbtzyQYcOQIbV(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, float f, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NsblbtzyQYcOQIbV(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, short s, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution NxliqrDNWxKrcqsd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder) {
        return crashlyticsReport$Session$Event$Application$Execution$Builder.build();
    }

    public static void NxliqrDNWxKrcqsd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NxliqrDNWxKrcqsd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NxliqrDNWxKrcqsd(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder OOaBdpMoWhxElHZB() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event.builder();
    }

    public static void OOaBdpMoWhxElHZB(float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OOaBdpMoWhxElHZB(bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OOaBdpMoWhxElHZB(bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session OUGRdLkxqxnafEkR(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, long j) {
        return crashlyticsReportDataCapture.populateSessionData(str, j);
    }

    public static void OUGRdLkxqxnafEkR(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, long j, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OUGRdLkxqxnafEkR(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, long j, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OUGRdLkxqxnafEkR(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, long j, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal OVYKzuQWvmoQHubb(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture) {
        return crashlyticsReportDataCapture.populateSignalData();
    }

    public static void OVYKzuQWvmoQHubb(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OVYKzuQWvmoQHubb(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OVYKzuQWvmoQHubb(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal OcoMkgEEBItjOfho(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e) {
        return abstractC0408xc880190e.build();
    }

    public static void OcoMkgEEBItjOfho(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OcoMkgEEBItjOfho(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OcoMkgEEBItjOfho(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 OdRhwXOAUSKAJzCI(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, long j) {
        return abstractC0411xb6f1d659.setOffset(j);
    }

    public static void OdRhwXOAUSKAJzCI(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, long j, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OdRhwXOAUSKAJzCI(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, long j, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OdRhwXOAUSKAJzCI(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, long j, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder OoNQLycABilrJvxD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application) {
        return crashlyticsReport$Session$Event$Builder.setApp(crashlyticsReport$Session$Event$Application);
    }

    public static void OoNQLycABilrJvxD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OoNQLycABilrJvxD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OoNQLycABilrJvxD(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application crashlyticsReport$Session$Event$Application, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder OuNCFwdCZSWeSZEY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Device$Builder.setModelClass(str);
    }

    public static void OuNCFwdCZSWeSZEY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OuNCFwdCZSWeSZEY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OuNCFwdCZSWeSZEY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 PWauzXuppxZtcGFD(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, int i) {
        return abstractC0409x324f3670.setImportance(i);
    }

    public static void PWauzXuppxZtcGFD(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, int i, int i2, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PWauzXuppxZtcGFD(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, int i, java.lang.string str, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PWauzXuppxZtcGFD(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, int i, short s, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder PiGxwriYSgaouyeS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Application$Builder.setDevelopmentPlatformVersion(str);
    }

    public static void PiGxwriYSgaouyeS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, float f, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PiGxwriYSgaouyeS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PiGxwriYSgaouyeS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, short s, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 QIIJGMobOOLlNvXi(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str) {
        return abstractC0404x11189392.setArch(str);
    }

    public static void QIIJGMobOOLlNvXi(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str, int i, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QIIJGMobOOLlNvXi(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str, java.lang.string str2, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QIIJGMobOOLlNvXi(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str, bool z, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder QJNauAsmcCKPIUpv(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list) {
        return crashlyticsReport$Session$Event$Application$Builder.setAppProcessDetails(list);
    }

    public static void QJNauAsmcCKPIUpv(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QJNauAsmcCKPIUpv(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QJNauAsmcCKPIUpv(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.util.List list, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QQdQBQCoxKHRilTx(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void QQdQBQCoxKHRilTx(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QQdQBQCoxKHRilTx(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QQdQBQCoxKHRilTx(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception QuPcAtQRBWzYpGjt(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2) {
        return crashlyticsReportDataCapture.populateExceptionData(trimmedExceptionData, i, i2);
    }

    public static void QuPcAtQRBWzYpGjt(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QuPcAtQRBWzYpGjt(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, bool z, char c, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void QuPcAtQRBWzYpGjt(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, bool z, short s, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e RIgkYSrJCRyIoDnn() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal.builder();
    }

    public static void RIgkYSrJCRyIoDnn(char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RIgkYSrJCRyIoDnn(int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RIgkYSrJCRyIoDnn(short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int RUcjlIMdiEsPzxBH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReport$ApplicationExitInfo.getPid();
    }

    public static void RUcjlIMdiEsPzxBH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RUcjlIMdiEsPzxBH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RUcjlIMdiEsPzxBH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder RZKRKztcoXyOucAD() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device.builder();
    }

    public static void RZKRKztcoXyOucAD(char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RZKRKztcoXyOucAD(float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RZKRKztcoXyOucAD(int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder RiVkKdyYpiwUslGb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Application$Builder.setDisplayVersion(str);
    }

    public static void RiVkKdyYpiwUslGb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, float f, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RiVkKdyYpiwUslGb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, short s, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RiVkKdyYpiwUslGb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, short s, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder RorEwoStripKtZed(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Device$Builder.setManufacturer(str);
    }

    public static void RorEwoStripKtZed(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str, java.lang.string str2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RorEwoStripKtZed(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str, short s, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RorEwoStripKtZed(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str, short s, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool SEJgqYkQzknfJltc(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void SEJgqYkQzknfJltc(bool z, byte b, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SEJgqYkQzknfJltc(bool z, byte b, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SEJgqYkQzknfJltc(bool z, char c, byte b, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder SGzeTcgnhsjtAZXl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, bool z) {
        return crashlyticsReport$Session$OperatingSystem$Builder.setJailbroken(z);
    }

    public static void SGzeTcgnhsjtAZXl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, bool z, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SGzeTcgnhsjtAZXl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, bool z, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SGzeTcgnhsjtAZXl(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, bool z, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SSBfkFhBkGoNPgqR(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider) {
        return developmentPlatformProvider.getDevelopmentPlatformVersion();
    }

    public static void SSBfkFhBkGoNPgqR(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SSBfkFhBkGoNPgqR(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SSBfkFhBkGoNPgqR(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SfzNzmBUhoyiycfV(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void SfzNzmBUhoyiycfV(java.util.IEnumerator it, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SfzNzmBUhoyiycfV(java.util.IEnumerator it, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SfzNzmBUhoyiycfV(java.util.IEnumerator it, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 TERigGuIxkYoBhnR(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception crashlyticsReport$Session$Event$Application$Execution$Exception) {
        return abstractC0407x94970e37.setCausedBy(crashlyticsReport$Session$Event$Application$Execution$Exception);
    }

    public static void TERigGuIxkYoBhnR(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception crashlyticsReport$Session$Event$Application$Execution$Exception, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TERigGuIxkYoBhnR(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception crashlyticsReport$Session$Event$Application$Execution$Exception, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TERigGuIxkYoBhnR(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception crashlyticsReport$Session$Event$Application$Execution$Exception, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder TgnvaYOCvoJplpRa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Device$Builder.setModel(str);
    }

    public static void TgnvaYOCvoJplpRa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str, java.lang.string str2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TgnvaYOCvoJplpRa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str, java.lang.string str2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TgnvaYOCvoJplpRa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, java.lang.string str, short s, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List TkulkXpojILNLtbT(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement[] stackTraceElementArr, int i) {
        return crashlyticsReportDataCapture.populateFramesList(stackTraceElementArr, i);
    }

    public static void TkulkXpojILNLtbT(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement[] stackTraceElementArr, int i, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TkulkXpojILNLtbT(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement[] stackTraceElementArr, int i, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TkulkXpojILNLtbT(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement[] stackTraceElementArr, int i, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder TlsyFelbBnZtjkBK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Event$Builder.setType(str);
    }

    public static void TlsyFelbBnZtjkBK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, java.lang.string str, byte b, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TlsyFelbBnZtjkBK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, java.lang.string str, java.lang.string str2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TlsyFelbBnZtjkBK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, java.lang.string str, short s, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder UAXijVHeumfMeXLR() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution.builder();
    }

    public static void UAXijVHeumfMeXLR(byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UAXijVHeumfMeXLR(byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UAXijVHeumfMeXLR(java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder UPdwiTrbTVjzNDlN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution crashlyticsReport$Session$Event$Application$Execution) {
        return crashlyticsReport$Session$Event$Application$Builder.setExecution(crashlyticsReport$Session$Event$Application$Execution);
    }

    public static void UPdwiTrbTVjzNDlN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution crashlyticsReport$Session$Event$Application$Execution, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UPdwiTrbTVjzNDlN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution crashlyticsReport$Session$Event$Application$Execution, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UPdwiTrbTVjzNDlN(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution crashlyticsReport$Session$Event$Application$Execution, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device UarVBDgrxHtiDgqj(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i) {
        return crashlyticsReportDataCapture.populateEventDeviceData(i);
    }

    public static void UarVBDgrxHtiDgqj(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UarVBDgrxHtiDgqj(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UarVBDgrxHtiDgqj(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData UdbFGPLBOGgsNFVM(java.lang.Exception th, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy) {
        return com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData.makeTrimmedExceptionData(th, stackTraceTrimmingStrategy);
    }

    public static void UdbFGPLBOGgsNFVM(java.lang.Exception th, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UdbFGPLBOGgsNFVM(java.lang.Exception th, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UdbFGPLBOGgsNFVM(java.lang.Exception th, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List UpZkQpgqpZejdxkN(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture) {
        return crashlyticsReportDataCapture.populateBinaryImagesList();
    }

    public static void UpZkQpgqpZejdxkN(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UpZkQpgqpZejdxkN(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UpZkQpgqpZejdxkN(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator UqaUJCTxjEiyNCAJ(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void UqaUJCTxjEiyNCAJ(java.util.List list, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UqaUJCTxjEiyNCAJ(java.util.List list, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UqaUJCTxjEiyNCAJ(java.util.List list, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab VBlZgytkLLzkXqUh(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture) {
        return crashlyticsReportDataCapture.populateBinaryImageData();
    }

    public static void VBlZgytkLLzkXqUh(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VBlZgytkLLzkXqUh(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VBlZgytkLLzkXqUh(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder VKhvJMOcjGJoodPf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, bool z) {
        return crashlyticsReport$Session$Event$Device$Builder.setProximityOn(z);
    }

    public static void VKhvJMOcjGJoodPf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, bool z, int i, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VKhvJMOcjGJoodPf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, bool z, int i, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VKhvJMOcjGJoodPf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, bool z, int i, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int VXlAczwrylpjLfnE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void VXlAczwrylpjLfnE(int i, char c, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VXlAczwrylpjLfnE(int i, int i2, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VXlAczwrylpjLfnE(int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VdOvTEoClKBIyysA(java.lang.StackTraceElement stackTraceElement) {
        return stackTraceElement.getLineNumber();
    }

    public static void VdOvTEoClKBIyysA(java.lang.StackTraceElement stackTraceElement, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VdOvTEoClKBIyysA(java.lang.StackTraceElement stackTraceElement, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VdOvTEoClKBIyysA(java.lang.StackTraceElement stackTraceElement, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal VrrCubLqFrWcdoxl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture) {
        return crashlyticsReportDataCapture.populateSignalData();
    }

    public static void VrrCubLqFrWcdoxl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VrrCubLqFrWcdoxl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VrrCubLqFrWcdoxl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder WExxkTYixiKslRbK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Builder.setIdentifier(str);
    }

    public static void WExxkTYixiKslRbK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str, char c, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WExxkTYixiKslRbK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str, char c, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WExxkTYixiKslRbK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str, java.lang.string str2, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder WODFjqigDuYHscHb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setProcessName(str);
    }

    public static void WODFjqigDuYHscHb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WODFjqigDuYHscHb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WODFjqigDuYHscHb(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WOLVKpOljNbOnrGO(java.io.string file) {
        return file.getPath();
    }

    public static void WOLVKpOljNbOnrGO(java.io.string file, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WOLVKpOljNbOnrGO(java.io.string file, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WOLVKpOljNbOnrGO(java.io.string file, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int WOmHZgTQcKSKMBmQ(java.lang.Runtime runtime) {
        return runtime.availableProcessors();
    }

    public static void WOmHZgTQcKSKMBmQ(java.lang.Runtime runtime, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WOmHZgTQcKSKMBmQ(java.lang.Runtime runtime, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WOmHZgTQcKSKMBmQ(java.lang.Runtime runtime, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 WSFizigANtsxttKB(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, java.lang.string str) {
        return abstractC0411xb6f1d659.setstring(str);
    }

    public static void WSFizigANtsxttKB(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, java.lang.string str, float f, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WSFizigANtsxttKB(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, java.lang.string str, java.lang.string str2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WSFizigANtsxttKB(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, java.lang.string str, short s, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application WhxkOhvMwkRZRtaH(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i2, int i3, bool z) {
        return crashlyticsReportDataCapture.populateEventApplicationData(i, trimmedExceptionData, thread, i2, i3, z);
    }

    public static void WhxkOhvMwkRZRtaH(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i2, int i3, bool z, float f, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WhxkOhvMwkRZRtaH(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i2, int i3, bool z, java.lang.string str, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WhxkOhvMwkRZRtaH(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i2, int i3, bool z, short s, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device WigprDpcYVGIymUE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder) {
        return crashlyticsReport$Session$Device$Builder.build();
    }

    public static void WigprDpcYVGIymUE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WigprDpcYVGIymUE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WigprDpcYVGIymUE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder XFEBLNaWhebEVQsr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device crashlyticsReport$Session$Device) {
        return crashlyticsReport$Session$Builder.setDevice(crashlyticsReport$Session$Device);
    }

    public static void XFEBLNaWhebEVQsr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device crashlyticsReport$Session$Device, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XFEBLNaWhebEVQsr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device crashlyticsReport$Session$Device, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XFEBLNaWhebEVQsr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device crashlyticsReport$Session$Device, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XbaEIkPuuuXRAoPX(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider) {
        return developmentPlatformProvider.getDevelopmentPlatform();
    }

    public static void XbaEIkPuuuXRAoPX(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XbaEIkPuuuXRAoPX(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XbaEIkPuuuXRAoPX(com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long XfyABHAvSRXBDjKX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        if ((10 + 24) % 24 > 0) {
        }
        return crashlyticsReport$ApplicationExitInfo.getPss();
    }

    public static void XfyABHAvSRXBDjKX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XfyABHAvSRXBDjKX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XfyABHAvSRXBDjKX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder XgzcAOpqDANNrjvY() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo.builder();
    }

    public static void XgzcAOpqDANNrjvY(int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XgzcAOpqDANNrjvY(java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XgzcAOpqDANNrjvY(short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder YBSzufQthclslEFG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, long j) {
        return crashlyticsReport$Session$Device$Builder.setRam(j);
    }

    public static void YBSzufQthclslEFG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, long j, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YBSzufQthclslEFG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, long j, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YBSzufQthclslEFG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device$Builder crashlyticsReport$Session$Device$Builder, long j, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder YWYVwhUnPIgdTQej(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, java.lang.string str) {
        return crashlyticsReport$Session$OperatingSystem$Builder.setVersion(str);
    }

    public static void YWYVwhUnPIgdTQej(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, java.lang.string str, byte b, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YWYVwhUnPIgdTQej(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, java.lang.string str, char c, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YWYVwhUnPIgdTQej(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, java.lang.string str, java.lang.string str2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List YajqMcUvFqiWaaGm(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture) {
        return crashlyticsReportDataCapture.populateBinaryImagesList();
    }

    public static void YajqMcUvFqiWaaGm(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YajqMcUvFqiWaaGm(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YajqMcUvFqiWaaGm(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YdHVIlejLzLlMebg(android.os.StatFs statFs) {
        return statFs.getBlockSize();
    }

    public static void YdHVIlejLzLlMebg(android.os.StatFs statFs, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YdHVIlejLzLlMebg(android.os.StatFs statFs, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YdHVIlejLzLlMebg(android.os.StatFs statFs, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YelCDfEuvsseYyxQ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void YelCDfEuvsseYyxQ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YelCDfEuvsseYyxQ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YelCDfEuvsseYyxQ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string YmWoeSBLkKsvStqm() {
        return android.os.Environment.getDataDirectory();
    }

    public static void YmWoeSBLkKsvStqm(byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YmWoeSBLkKsvStqm(java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YmWoeSBLkKsvStqm(short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder YwkdPJVexOvuhxXA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setPss(j);
    }

    public static void YwkdPJVexOvuhxXA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YwkdPJVexOvuhxXA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YwkdPJVexOvuhxXA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, long j, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder ZKZHyqecRwbbJUrK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device crashlyticsReport$Session$Event$Device) {
        return crashlyticsReport$Session$Event$Builder.setDevice(crashlyticsReport$Session$Event$Device);
    }

    public static void ZKZHyqecRwbbJUrK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device crashlyticsReport$Session$Event$Device, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZKZHyqecRwbbJUrK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device crashlyticsReport$Session$Event$Device, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZKZHyqecRwbbJUrK(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device crashlyticsReport$Session$Event$Device, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 ZTdgmyacywQzNLwV(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, long j) {
        return abstractC0406xd3174882.setBaseAddress(j);
    }

    public static void ZTdgmyacywQzNLwV(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, long j, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZTdgmyacywQzNLwV(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, long j, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZTdgmyacywQzNLwV(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, long j, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZUxIlufZApBEObwn(com.google.firebase.crashlytics.internal.common.BatteryState batteryState) {
        return batteryState.getBatteryVelocity();
    }

    public static void ZUxIlufZApBEObwn(com.google.firebase.crashlytics.internal.common.BatteryState batteryState, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZUxIlufZApBEObwn(com.google.firebase.crashlytics.internal.common.BatteryState batteryState, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZUxIlufZApBEObwn(com.google.firebase.crashlytics.internal.common.BatteryState batteryState, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List AGYkWAMhJzBdsuGA(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement[] stackTraceElementArr, int i) {
        return crashlyticsReportDataCapture.populateFramesList(stackTraceElementArr, i);
    }

    public static void AGYkWAMhJzBdsuGA(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement[] stackTraceElementArr, int i, float f, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AGYkWAMhJzBdsuGA(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement[] stackTraceElementArr, int i, float f, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AGYkWAMhJzBdsuGA(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.StackTraceElement[] stackTraceElementArr, int i, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AQBfaTGChSpehQMx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void AQBfaTGChSpehQMx(java.lang.stringBuilder sb, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AQBfaTGChSpehQMx(java.lang.stringBuilder sb, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AQBfaTGChSpehQMx(java.lang.stringBuilder sb, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution acPJEVClgEwoNzDw(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, int i2, bool z) {
        return crashlyticsReportDataCapture.populateExecutionData(trimmedExceptionData, thread, i, i2, z);
    }

    public static void AcPJEVClgEwoNzDw(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, int i2, bool z, byte b, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AcPJEVClgEwoNzDw(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, int i2, bool z, java.lang.string str, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AcPJEVClgEwoNzDw(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, int i2, bool z, bool z2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo addBuildIdInfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        java.util.List listPOZCOmtYhXyyzQdi;
        if ((23 + 30) % 30 > 0) {
        }
        if (ILlSdzWKkpadGvLe(this.settingsProvider).featureFlagData.collectBuildIds && dwppgXWefCcZMAJh(this.appData.buildIdInfoList) > 0) {
            java.util.List arrayList = new java.util.List();
            java.util.IEnumerator itUqaUJCTxjEiyNCAJ = UqaUJCTxjEiyNCAJ(this.appData.buildIdInfoList);
            while (cadCAogVxkWvslub(itUqaUJCTxjEiyNCAJ)) {
                com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo = (com.google.firebase.crashlytics.internal.common.BuildIdInfo) sGaWWcZKXttfBqnz(itUqaUJCTxjEiyNCAJ);
                dJWJwiDFomkbXbUH(arrayList, hzAJmlvZbNIKxdwx(oTzbJMmxxLEDtoKw(QIIJGMobOOLlNvXi(diyEeDUUlHDtmdnX(CKchqImjkmyZCXIk(), jdnUHFQYVrZoCPQc(buildIdInfo)), bCfVDRIapyjLhGCm(buildIdInfo)), DovlXqkQjGzymHOM(buildIdInfo))));
            }
            listPOZCOmtYhXyyzQdi = pOZCOmtYhXyyzQdi(arrayList);
        } else {
            listPOZCOmtYhXyyzQdi = null;
        }
        return KbOzGbcpzjibcUoU(xkAqSurKaqCKdgTW(jQnVgTenPEAwTGtY(GATAEFlbJlQATdrZ(YwkdPJVexOvuhxXA(iJoiIYumlCAUAKVE(DyiMEkELfLomLknD(MeFqyJJVrYpGBzBj(WODFjqigDuYHscHb(vLcfbtovgvEFbKoB(XgzcAOpqDANNrjvY(), BvJyFvyLESlNJscD(crashlyticsReport$ApplicationExitInfo)), BburmwxvIARrsCfi(crashlyticsReport$ApplicationExitInfo)), ahfjhuPdJdNbwKMZ(crashlyticsReport$ApplicationExitInfo)), JNaToEXRQIiELDNC(crashlyticsReport$ApplicationExitInfo)), RUcjlIMdiEsPzxBH(crashlyticsReport$ApplicationExitInfo)), XfyABHAvSRXBDjKX(crashlyticsReport$ApplicationExitInfo)), hmbVeHCHyxMMQuAG(crashlyticsReport$ApplicationExitInfo)), FUxeRuSQmayrqVGO(crashlyticsReport$ApplicationExitInfo)), listPOZCOmtYhXyyzQdi));
    }

    private void AddBuildIdInfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void AddBuildIdInfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void AddBuildIdInfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int AhfjhuPdJdNbwKMZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReport$ApplicationExitInfo.getReasonCode();
    }

    public static void AhfjhuPdJdNbwKMZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AhfjhuPdJdNbwKMZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AhfjhuPdJdNbwKMZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder aoWwmSxYEjEdmnUU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal crashlyticsReport$Session$Event$Application$Execution$Signal) {
        return crashlyticsReport$Session$Event$Application$Execution$Builder.setSignal(crashlyticsReport$Session$Event$Application$Execution$Signal);
    }

    public static void AoWwmSxYEjEdmnUU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal crashlyticsReport$Session$Event$Application$Execution$Signal, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AoWwmSxYEjEdmnUU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal crashlyticsReport$Session$Event$Application$Execution$Signal, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AoWwmSxYEjEdmnUU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal crashlyticsReport$Session$Event$Application$Execution$Signal, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder azwHNcocfhbmMqSa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.lang.bool bool) {
        return crashlyticsReport$Session$Event$Application$Builder.setBackground(bool);
    }

    public static void AzwHNcocfhbmMqSa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.lang.bool bool, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AzwHNcocfhbmMqSa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.lang.bool bool, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AzwHNcocfhbmMqSa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.lang.bool bool, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List BCYRgtnSrjZtXXjQ(java.lang.object obj) {
        return java.util.ICollections.singletonList(obj);
    }

    public static void BCYRgtnSrjZtXXjQ(java.lang.object obj, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BCYRgtnSrjZtXXjQ(java.lang.object obj, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BCYRgtnSrjZtXXjQ(java.lang.object obj, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BCfVDRIapyjLhGCm(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo) {
        return buildIdInfo.getArch();
    }

    public static void BCfVDRIapyjLhGCm(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BCfVDRIapyjLhGCm(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BCfVDRIapyjLhGCm(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int BijiqLgaRMuOzpgZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReport$ApplicationExitInfo.getImportance();
    }

    public static void BijiqLgaRMuOzpgZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BijiqLgaRMuOzpgZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BijiqLgaRMuOzpgZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int BilymzayVrtSrGwS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails) {
        return crashlyticsReport$Session$Event$Application$ProcessDetails.getImportance();
    }

    public static void BilymzayVrtSrGwS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BilymzayVrtSrGwS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BilymzayVrtSrGwS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int BkUywAVwCQZeDNPA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReport$ApplicationExitInfo.getImportance();
    }

    public static void BkUywAVwCQZeDNPA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BkUywAVwCQZeDNPA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BkUywAVwCQZeDNPA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device btWdbonkAIlvmAkv(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture) {
        return crashlyticsReportDataCapture.populateSessionDeviceData();
    }

    public static void BtWdbonkAIlvmAkv(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BtWdbonkAIlvmAkv(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BtWdbonkAIlvmAkv(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder buildReportData() {
        if ((14 + 10) % 10 > 0) {
        }
        return iwJEwmYGVHMolMxA(xdspJhXifBplqJTr(rgnOAezKKlBxQSTZ(kDPcBQJwwfqYrxGj(bwOTUFZcBNhSvXjC(yQVrDNmLGLUOUOjL(rCiolnEIZXeCcNId(dhqaawdMyxTJpycG(LGfhkTdfUGqxqHpk(), "19.4.2"), this.appData.googleAppId), BTewSWeCyXOEKXCl(hNnBsYiyDIYMVNEB(this.idManager))), fInUuUBfYWbzTNxM(KGDbvPXqMfCrXHHp(this.idManager))), nThNxfHDEVUttRCM(pSNuZhfsCbwVJbiD(this.idManager))), this.appData.versionCode), this.appData.versionName), 4);
    }

    private void BuildReportData(char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void BuildReportData(short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void BuildReportData(bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.BatteryState BvJftwPOzDbudrqB(android.content.object context) {
        return com.google.firebase.crashlytics.internal.common.BatteryState[context);
    }

    public static void BvJftwPOzDbudrqB(android.content.object context, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BvJftwPOzDbudrqB(android.content.object context, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BvJftwPOzDbudrqB(android.content.object context, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder bwOTUFZcBNhSvXjC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str) {
        return crashlyticsReport$Builder.setFirebaseInstallationId(str);
    }

    public static void BwOTUFZcBNhSvXjC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BwOTUFZcBNhSvXjC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BwOTUFZcBNhSvXjC(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CadCAogVxkWvslub(java.util.IEnumerator it, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CadCAogVxkWvslub(java.util.IEnumerator it, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CadCAogVxkWvslub(java.util.IEnumerator it, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool CadCAogVxkWvslub(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application ctSZaWLdZLbvWogF(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture) {
        return crashlyticsReportDataCapture.populateSessionApplicationData();
    }

    public static void CtSZaWLdZLbvWogF(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CtSZaWLdZLbvWogF(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CtSZaWLdZLbvWogF(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder cyKsHaCGrHyiWIRc() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event.builder();
    }

    public static void CyKsHaCGrHyiWIRc(float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CyKsHaCGrHyiWIRc(int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CyKsHaCGrHyiWIRc(int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DEDGtfBJkxzrduMI(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static void DEDGtfBJkxzrduMI(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, byte b, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DEDGtfBJkxzrduMI(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, byte b, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DEDGtfBJkxzrduMI(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, bool z, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DJWJwiDFomkbXbUH(java.util.List list, java.lang.object obj, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DJWJwiDFomkbXbUH(java.util.List list, java.lang.object obj, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DJWJwiDFomkbXbUH(java.util.List list, java.lang.object obj, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DJWJwiDFomkbXbUH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder dRSvwaRlQeiJmhjp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session) {
        return crashlyticsReport$Builder.setSession(crashlyticsReport$Session);
    }

    public static void DRSvwaRlQeiJmhjp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DRSvwaRlQeiJmhjp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DRSvwaRlQeiJmhjp(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session crashlyticsReport$Session, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder dhqaawdMyxTJpycG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str) {
        return crashlyticsReport$Builder.setSdkVersion(str);
    }

    public static void DhqaawdMyxTJpycG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, byte b, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DhqaawdMyxTJpycG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, byte b, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DhqaawdMyxTJpycG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, java.lang.string str2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 DiyEeDUUlHDtmdnX(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str) {
        return abstractC0404x11189392.setLibraryName(str);
    }

    public static void DiyEeDUUlHDtmdnX(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str, char c, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DiyEeDUUlHDtmdnX(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str, java.lang.string str2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DiyEeDUUlHDtmdnX(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str, short s, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder dwDmxMnHztLLeRvu(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Application$Builder.setInstallationUuid(str);
    }

    public static void DwDmxMnHztLLeRvu(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DwDmxMnHztLLeRvu(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DwDmxMnHztLLeRvu(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DwppgXWefCcZMAJh(java.util.List list) {
        return list.Count;
    }

    public static void DwppgXWefCcZMAJh(java.util.List list, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DwppgXWefCcZMAJh(java.util.List list, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DwppgXWefCcZMAJh(java.util.List list, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder eOHKfgShaXljxRUz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, int i) {
        return crashlyticsReport$Session$OperatingSystem$Builder.setPlatform(i);
    }

    public static void EOHKfgShaXljxRUz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, int i, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EOHKfgShaXljxRUz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, int i, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EOHKfgShaXljxRUz(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception efNGNTuTdfzbUUcR(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3) {
        return crashlyticsReportDataCapture.populateExceptionData(trimmedExceptionData, i, i2, i3);
    }

    public static void EfNGNTuTdfzbUUcR(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EfNGNTuTdfzbUUcR(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EfNGNTuTdfzbUUcR(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 EitEUdwPJIlenYIa() {
        return com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182.builder();
    }

    public static void EitEUdwPJIlenYIa(char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EitEUdwPJIlenYIa(char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EitEUdwPJIlenYIa(java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static long EnsureNonNegative(long j) {
        if ((25 + 3) % 3 > 0) {
        }
        if (j <= 0) {
            return 0L;
        }
        return j;
    }

    private static void EnsureNonNegative(long j, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private static void EnsureNonNegative(long j, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private static void EnsureNonNegative(long j, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EqomRvCOWdirWvHe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EqomRvCOWdirWvHe(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EqomRvCOWdirWvHe(java.lang.stringBuilder sb, java.lang.string str, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EqomRvCOWdirWvHe(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution evRRXLgTkkLLSUlW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder) {
        return crashlyticsReport$Session$Event$Application$Execution$Builder.build();
    }

    public static void EvRRXLgTkkLLSUlW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EvRRXLgTkkLLSUlW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EvRRXLgTkkLLSUlW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FInUuUBfYWbzTNxM(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds) {
        return installIdProvider$InstallIds.getFirebaseInstallationId();
    }

    public static void FInUuUBfYWbzTNxM(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FInUuUBfYWbzTNxM(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FInUuUBfYWbzTNxM(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder fLCkSIIoMLhvbycZ() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application.builder();
    }

    public static void FLCkSIIoMLhvbycZ(char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FLCkSIIoMLhvbycZ(char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FLCkSIIoMLhvbycZ(bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FOcGbUSknmSULpyh(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void FOcGbUSknmSULpyh(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FOcGbUSknmSULpyh(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FOcGbUSknmSULpyh(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder fTtcRnWkYHJulBda(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, int i) {
        return crashlyticsReport$Session$Event$Device$Builder.setOrientation(i);
    }

    public static void FTtcRnWkYHJulBda(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, int i, byte b, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FTtcRnWkYHJulBda(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, int i, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FTtcRnWkYHJulBda(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, int i, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FUcUzKhzEOOvobPw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FUcUzKhzEOOvobPw(java.lang.stringBuilder sb, java.lang.string str, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FUcUzKhzEOOvobPw(java.lang.stringBuilder sb, java.lang.string str, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FUcUzKhzEOOvobPw(java.lang.stringBuilder sb, java.lang.string str, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder ffiodAheUWVMHMVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, int i) {
        return crashlyticsReport$Session$Event$Application$Builder.setUiOrientation(i);
    }

    public static void FfiodAheUWVMHMVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, int i, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FfiodAheUWVMHMVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, int i, float f, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FfiodAheUWVMHMVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, int i, bool z, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder gAzhcNsBUXqNuMqU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, int i) {
        return crashlyticsReport$Session$Event$Device$Builder.setBatteryVelocity(i);
    }

    public static void GAzhcNsBUXqNuMqU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, int i, char c, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GAzhcNsBUXqNuMqU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, int i, float f, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GAzhcNsBUXqNuMqU(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, int i, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Configuration GdOpLEtIeByWNDfA(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void GdOpLEtIeByWNDfA(android.content.res.Resources resources, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GdOpLEtIeByWNDfA(android.content.res.Resources resources, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GdOpLEtIeByWNDfA(android.content.res.Resources resources, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private static int GetDeviceArchitecture() {
        java.lang.int num;
        if ((7 + 14) % 14 > 0) {
        }
        java.lang.string str = android.os.Build.CPU_ABI;
        if (xQtkCGDsjiYRaqWl(str) || (num = (java.lang.int) vvpujswClEroxWmt(ARCHITECTURES_BY_NAME, NqAIjXWEbNFOusrp(str, java.util.Locale.US))) is null) {
            return 7;
        }
        return lnvvvGxOoWXHcqTT(num);
    }

    private static void GetDeviceArchitecture(float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void GetDeviceArchitecture(java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetDeviceArchitecture(short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GmrhCDmUDbDDHubU(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getAppIdentifier();
    }

    public static void GmrhCDmUDbDDHubU(com.google.firebase.crashlytics.internal.common.IdManager idManager, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GmrhCDmUDbDDHubU(com.google.firebase.crashlytics.internal.common.IdManager idManager, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GmrhCDmUDbDDHubU(com.google.firebase.crashlytics.internal.common.IdManager idManager, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 GvpmxMnzqnBkVmss(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, java.lang.string str) {
        return abstractC0411xb6f1d659.setSymbol(str);
    }

    public static void GvpmxMnzqnBkVmss(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, java.lang.string str, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GvpmxMnzqnBkVmss(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, java.lang.string str, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GvpmxMnzqnBkVmss(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, java.lang.string str, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HFLuOIqQPoudIcHk(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void HFLuOIqQPoudIcHk(java.util.Dictionary$Entry map$Entry, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HFLuOIqQPoudIcHk(java.util.Dictionary$Entry map$Entry, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HFLuOIqQPoudIcHk(java.util.Dictionary$Entry map$Entry, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List HITnPVWybvsrNnTX(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, android.content.object context) {
        return processDetailsProvider.getAppProcessDetails(context);
    }

    public static void HITnPVWybvsrNnTX(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, android.content.object context, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HITnPVWybvsrNnTX(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, android.content.object context, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HITnPVWybvsrNnTX(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, android.content.object context, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds hNnBsYiyDIYMVNEB(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getInstallIds();
    }

    public static void HNnBsYiyDIYMVNEB(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HNnBsYiyDIYMVNEB(com.google.firebase.crashlytics.internal.common.IdManager idManager, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HNnBsYiyDIYMVNEB(com.google.firebase.crashlytics.internal.common.IdManager idManager, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int HYXrsMErlrHhDVpI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HYXrsMErlrHhDVpI(int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HYXrsMErlrHhDVpI(int i, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HYXrsMErlrHhDVpI(int i, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails hcoWdSVBFQrKXduW(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReportDataCapture.processDetailsFromApplicationExitInfo(crashlyticsReport$ApplicationExitInfo);
    }

    public static void HcoWdSVBFQrKXduW(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HcoWdSVBFQrKXduW(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HcoWdSVBFQrKXduW(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static long HmbVeHCHyxMMQuAG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        if ((32 + 9) % 9 > 0) {
        }
        return crashlyticsReport$ApplicationExitInfo.getRss();
    }

    public static void HmbVeHCHyxMMQuAG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HmbVeHCHyxMMQuAG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HmbVeHCHyxMMQuAG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder hxQUEodwWtactcAF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Event$Builder.setType(str);
    }

    public static void HxQUEodwWtactcAF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, java.lang.string str, int i, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HxQUEodwWtactcAF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, java.lang.string str, int i, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HxQUEodwWtactcAF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, java.lang.string str, java.lang.string str2, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$BuildIdDictionarypingForArch hzAJmlvZbNIKxdwx(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392) {
        return abstractC0404x11189392.build();
    }

    public static void HzAJmlvZbNIKxdwx(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HzAJmlvZbNIKxdwx(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HzAJmlvZbNIKxdwx(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder iJoiIYumlCAUAKVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setPid(i);
    }

    public static void IJoiIYumlCAUAKVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IJoiIYumlCAUAKVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IJoiIYumlCAUAKVE(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder icVKKJghlpwcmEct(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.lang.bool bool) {
        return crashlyticsReport$Session$Event$Application$Builder.setBackground(bool);
    }

    public static void IcVKKJghlpwcmEct(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.lang.bool bool, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IcVKKJghlpwcmEct(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.lang.bool bool, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IcVKKJghlpwcmEct(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, java.lang.bool bool, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 InBpZkxLxwbDyRHY(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, java.lang.string str) {
        return abstractC0409x324f3670.setName(str);
    }

    public static void InBpZkxLxwbDyRHY(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, java.lang.string str, char c, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void InBpZkxLxwbDyRHY(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, java.lang.string str, short s, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void InBpZkxLxwbDyRHY(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, java.lang.string str, short s, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder iwJEwmYGVHMolMxA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, int i) {
        return crashlyticsReport$Builder.setPlatform(i);
    }

    public static void IwJEwmYGVHMolMxA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IwJEwmYGVHMolMxA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, int i, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IwJEwmYGVHMolMxA(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, int i, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IwTONwDdTsiqSOlM(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IwTONwDdTsiqSOlM(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IwTONwDdTsiqSOlM(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.StackTraceElement[] IwTONwDdTsiqSOlM(com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, java.lang.StackTraceElement[] stackTraceElementArr) {
        return stackTraceTrimmingStrategy.getTrimmedStackTrace(stackTraceElementArr);
    }

    public static java.lang.stringBuilder IyEwPcDPhbYXXNOZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IyEwPcDPhbYXXNOZ(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IyEwPcDPhbYXXNOZ(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IyEwPcDPhbYXXNOZ(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder jCWxehfRhDsWLRke(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list) {
        return crashlyticsReport$Session$Event$Application$Execution$Builder.setThreads(list);
    }

    public static void JCWxehfRhDsWLRke(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JCWxehfRhDsWLRke(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JCWxehfRhDsWLRke(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder jQnVgTenPEAwTGtY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setTracestring(str);
    }

    public static void JQnVgTenPEAwTGtY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, java.lang.string str2, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JQnVgTenPEAwTGtY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, short s, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JQnVgTenPEAwTGtY(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.lang.string str, short s, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails jbuTGTAVkWwcIgTh(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, android.content.object context) {
        return processDetailsProvider.getCurrentProcessDetails(context);
    }

    public static void JbuTGTAVkWwcIgTh(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, android.content.object context, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JbuTGTAVkWwcIgTh(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, android.content.object context, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JbuTGTAVkWwcIgTh(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, android.content.object context, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JdnUHFQYVrZoCPQc(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo) {
        return buildIdInfo.getLibraryName();
    }

    public static void JdnUHFQYVrZoCPQc(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JdnUHFQYVrZoCPQc(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JdnUHFQYVrZoCPQc(com.google.firebase.crashlytics.internal.common.BuildIdInfo buildIdInfo, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JkklcJuVsIrLiydl(java.util.List list, java.lang.object obj, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JkklcJuVsIrLiydl(java.util.List list, java.lang.object obj, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JkklcJuVsIrLiydl(java.util.List list, java.lang.object obj, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JkklcJuVsIrLiydl(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string JrJcrTiSDPAnqARL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReport$ApplicationExitInfo.getProcessName();
    }

    public static void JrJcrTiSDPAnqARL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JrJcrTiSDPAnqARL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JrJcrTiSDPAnqARL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder kDPcBQJwwfqYrxGj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str) {
        return crashlyticsReport$Builder.setFirebaseAuthenticationToken(str);
    }

    public static void KDPcBQJwwfqYrxGj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, int i, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KDPcBQJwwfqYrxGj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, short s, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KDPcBQJwwfqYrxGj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, bool z, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder kGYAAdoiGbsvkxhx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Builder.setGenerator(str);
    }

    public static void KGYAAdoiGbsvkxhx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KGYAAdoiGbsvkxhx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KGYAAdoiGbsvkxhx(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, java.lang.string str, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo kObptlybKcaMzFhW(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReportDataCapture.addBuildIdInfo(crashlyticsReport$ApplicationExitInfo);
    }

    public static void KObptlybKcaMzFhW(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KObptlybKcaMzFhW(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KObptlybKcaMzFhW(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 KUrbAJnAVhuieZwb() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception.builder();
    }

    public static void KUrbAJnAVhuieZwb(float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KUrbAJnAVhuieZwb(int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KUrbAJnAVhuieZwb(java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string KfECuIVUhfjUpjZu() {
        return android.os.Environment.getDataDirectory();
    }

    public static void KfECuIVUhfjUpjZu(short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KfECuIVUhfjUpjZu(short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KfECuIVUhfjUpjZu(bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event kiHzeSiTAuiMAikg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder) {
        return crashlyticsReport$Session$Event$Builder.build();
    }

    public static void KiHzeSiTAuiMAikg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KiHzeSiTAuiMAikg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KiHzeSiTAuiMAikg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application kyFAnspGEDqippdg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder) {
        return crashlyticsReport$Session$Event$Application$Builder.build();
    }

    public static void KyFAnspGEDqippdg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KyFAnspGEDqippdg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KyFAnspGEDqippdg(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LnvvvGxOoWXHcqTT(java.lang.int num) {
        return num.intValue();
    }

    public static void LnvvvGxOoWXHcqTT(java.lang.int num, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LnvvvGxOoWXHcqTT(java.lang.int num, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LnvvvGxOoWXHcqTT(java.lang.int num, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread mAUbafDOtQBQxcvl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr) {
        return crashlyticsReportDataCapture.populateThreadData(thread, stackTraceElementArr);
    }

    public static void MAUbafDOtQBQxcvl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MAUbafDOtQBQxcvl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MAUbafDOtQBQxcvl(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Dictionary MFlZjZCXdhloNJsj() {
        return java.lang.Thread.getAllStackTraces();
    }

    public static void MFlZjZCXdhloNJsj(char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MFlZjZCXdhloNJsj(int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MFlZjZCXdhloNJsj(bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder mGsPfjyuzeMRFEKh() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application.builder();
    }

    public static void MGsPfjyuzeMRFEKh(byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MGsPfjyuzeMRFEKh(byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MGsPfjyuzeMRFEKh(float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 MRCVtqQHSQeQDPZU() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread.builder();
    }

    public static void MRCVtqQHSQeQDPZU(byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MRCVtqQHSQeQDPZU(byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MRCVtqQHSQeQDPZU(java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder mVwBdAVoIHbZPzaf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception crashlyticsReport$Session$Event$Application$Execution$Exception) {
        return crashlyticsReport$Session$Event$Application$Execution$Builder.setException(crashlyticsReport$Session$Event$Application$Execution$Exception);
    }

    public static void MVwBdAVoIHbZPzaf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception crashlyticsReport$Session$Event$Application$Execution$Exception, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MVwBdAVoIHbZPzaf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception crashlyticsReport$Session$Event$Application$Execution$Exception, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MVwBdAVoIHbZPzaf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception crashlyticsReport$Session$Event$Application$Execution$Exception, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources MWMBrPDmUtvNkrsq(android.content.object context) {
        return context.getResources();
    }

    public static void MWMBrPDmUtvNkrsq(android.content.object context, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MWMBrPDmUtvNkrsq(android.content.object context, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MWMBrPDmUtvNkrsq(android.content.object context, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder mWTmhfGcHCnuUtit(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list) {
        return crashlyticsReport$Session$Event$Application$Execution$Builder.setBinaries(list);
    }

    public static void MWTmhfGcHCnuUtit(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MWTmhfGcHCnuUtit(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MWTmhfGcHCnuUtit(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, java.util.List list, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static long MiadRGwROMKddUiM(long j) {
        if ((8 + 6) % 6 > 0) {
        }
        return ensureNonNegative(j);
    }

    public static void MiadRGwROMKddUiM(long j, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MiadRGwROMKddUiM(long j, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MiadRGwROMKddUiM(long j, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NMcFIPtyQHubltlb(java.lang.StackTraceElement stackTraceElement, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NMcFIPtyQHubltlb(java.lang.StackTraceElement stackTraceElement, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NMcFIPtyQHubltlb(java.lang.StackTraceElement stackTraceElement, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool NMcFIPtyQHubltlb(java.lang.StackTraceElement stackTraceElement) {
        return stackTraceElement.isNativeMethod();
    }

    public static java.lang.string NSEMlfLHKENGHzpw(java.lang.StackTraceElement stackTraceElement) {
        return stackTraceElement.getMethodName();
    }

    public static void NSEMlfLHKENGHzpw(java.lang.StackTraceElement stackTraceElement, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NSEMlfLHKENGHzpw(java.lang.StackTraceElement stackTraceElement, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NSEMlfLHKENGHzpw(java.lang.StackTraceElement stackTraceElement, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NSlFCCtrwBhZrLiw(char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NSlFCCtrwBhZrLiw(char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NSlFCCtrwBhZrLiw(int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NSlFCCtrwBhZrLiw() {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.isEmulator();
    }

    public static java.lang.string NThNxfHDEVUttRCM(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds) {
        return installIdProvider$InstallIds.getFirebaseAuthenticationToken();
    }

    public static void NThNxfHDEVUttRCM(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NThNxfHDEVUttRCM(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NThNxfHDEVUttRCM(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder npBZYPQzYDlizUMZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, long j) {
        return crashlyticsReport$Session$Event$Device$Builder.setDiskUsed(j);
    }

    public static void NpBZYPQzYDlizUMZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, long j, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NpBZYPQzYDlizUMZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, long j, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NpBZYPQzYDlizUMZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, long j, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder oIsycBFGhMqfUHjH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, long j) {
        return crashlyticsReport$Session$Event$Builder.setTimestamp(j);
    }

    public static void OIsycBFGhMqfUHjH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, long j, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OIsycBFGhMqfUHjH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, long j, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OIsycBFGhMqfUHjH(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Builder crashlyticsReport$Session$Event$Builder, long j, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder oPKwvHpOpItJweAr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, java.lang.string str) {
        return crashlyticsReport$Session$OperatingSystem$Builder.setBuildVersion(str);
    }

    public static void OPKwvHpOpItJweAr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, java.lang.string str, float f, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OPKwvHpOpItJweAr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, java.lang.string str, float f, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OPKwvHpOpItJweAr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder crashlyticsReport$Session$OperatingSystem$Builder, java.lang.string str, bool z, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OTkceSrHmBYvAudn(java.util.List list, java.lang.object obj, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OTkceSrHmBYvAudn(java.util.List list, java.lang.object obj, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OTkceSrHmBYvAudn(java.util.List list, java.lang.object obj, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OTkceSrHmBYvAudn(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 OTzbJMmxxLEDtoKw(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str) {
        return abstractC0404x11189392.setBuildId(str);
    }

    public static void OTzbJMmxxLEDtoKw(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str, char c, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OTzbJMmxxLEDtoKw(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str, int i, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OTzbJMmxxLEDtoKw(com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 abstractC0404x11189392, java.lang.string str, int i, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application olDTtrIAQDQOdmFr(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReportDataCapture.populateEventApplicationData(i, crashlyticsReport$ApplicationExitInfo);
    }

    public static void OlDTtrIAQDQOdmFr(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, byte b, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OlDTtrIAQDQOdmFr(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OlDTtrIAQDQOdmFr(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, short s, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e OmWjNOridMnclnbL(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, java.lang.string str) {
        return abstractC0408xc880190e.setCode(str);
    }

    public static void OmWjNOridMnclnbL(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, java.lang.string str, float f, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OmWjNOridMnclnbL(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, java.lang.string str, float f, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OmWjNOridMnclnbL(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, java.lang.string str, int i, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 PBoHjlFFqqZUYUyi(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.lang.string str) {
        return abstractC0407x94970e37.setReason(str);
    }

    public static void PBoHjlFFqqZUYUyi(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.lang.string str, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PBoHjlFFqqZUYUyi(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.lang.string str, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PBoHjlFFqqZUYUyi(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.lang.string str, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder pNcdBiZGeSKlzkTh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails) {
        return crashlyticsReport$Session$Event$Application$Builder.setCurrentProcessDetails(crashlyticsReport$Session$Event$Application$ProcessDetails);
    }

    public static void PNcdBiZGeSKlzkTh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PNcdBiZGeSKlzkTh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PNcdBiZGeSKlzkTh(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List POZCOmtYhXyyzQdi(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static void POZCOmtYhXyyzQdi(java.util.List list, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void POZCOmtYhXyyzQdi(java.util.List list, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void POZCOmtYhXyyzQdi(java.util.List list, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder pRkZTfRLatsIZPEr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, long j) {
        return crashlyticsReport$Session$Event$Device$Builder.setRamUsed(j);
    }

    public static void PRkZTfRLatsIZPEr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, long j, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PRkZTfRLatsIZPEr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, long j, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PRkZTfRLatsIZPEr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device$Builder crashlyticsReport$Session$Event$Device$Builder, long j, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds pSNuZhfsCbwVJbiD(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getInstallIds();
    }

    public static void PSNuZhfsCbwVJbiD(com.google.firebase.crashlytics.internal.common.IdManager idManager, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PSNuZhfsCbwVJbiD(com.google.firebase.crashlytics.internal.common.IdManager idManager, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PSNuZhfsCbwVJbiD(com.google.firebase.crashlytics.internal.common.IdManager idManager, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 PnjIlEPJMTavgbti(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, int i) {
        return abstractC0407x94970e37.setOverflowCount(i);
    }

    public static void PnjIlEPJMTavgbti(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PnjIlEPJMTavgbti(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, int i, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PnjIlEPJMTavgbti(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, int i, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab PopulateBinaryImageData() {
        if ((28 + 14) % 14 > 0) {
        }
        return tbecpqPBxkcNVPxL(GqXGvVhjIifdLtLf(DkJmrXXQJvGdInFU(MIdCYRRqGanVNYNN(ZTdgmyacywQzNLwV(yjdeCiqNNuvpEUjI(), 0L), 0L), this.appData.packageName), this.appData.buildId));
    }

    private void PopulateBinaryImageData(char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void PopulateBinaryImageData(float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void PopulateBinaryImageData(float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private java.util.List<com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab> PopulateBinaryImagesList() {
        return bCYRgtnSrjZtXXjQ(VBlZgytkLLzkXqUh(this));
    }

    private void PopulateBinaryImagesList(char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void PopulateBinaryImagesList(int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void PopulateBinaryImagesList(int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application populateEventApplicationData(int i, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        if ((10 + 20) % 20 > 0) {
        }
        return kyFAnspGEDqippdg(ucuXBitjPcFfxVPf(ffiodAheUWVMHMVE(pNcdBiZGeSKlzkTh(icVKKJghlpwcmEct(mGsPfjyuzeMRFEKh(), MYQIHLRFdeDbkHhH(bkUywAVwCQZeDNPA(crashlyticsReport$ApplicationExitInfo) != 100)), hcoWdSVBFQrKXduW(this, crashlyticsReport$ApplicationExitInfo)), i), MmLYEeSdWJOBYCgz(this, crashlyticsReport$ApplicationExitInfo)));
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application populateEventApplicationData(int i, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i2, int i3, bool z) {
        java.lang.bool boolSEJgqYkQzknfJltc;
        if ((31 + 1) % 1 > 0) {
        }
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetailsJbuTGTAVkWwcIgTh = jbuTGTAVkWwcIgTh(this.processDetailsProvider, this.context);
        if (bilymzayVrtSrGwS(crashlyticsReport$Session$Event$Application$ProcessDetailsJbuTGTAVkWwcIgTh) <= 0) {
            boolSEJgqYkQzknfJltc = null;
        } else {
            boolSEJgqYkQzknfJltc = SEJgqYkQzknfJltc(rrkIwygciwRPRfxG(crashlyticsReport$Session$Event$Application$ProcessDetailsJbuTGTAVkWwcIgTh) != 100);
        }
        return FYUcuNogpPfptinp(UPdwiTrbTVjzNDlN(zrYvBPaUBqyBsuqj(QJNauAsmcCKPIUpv(xcsIAYnsqvsyYAWI(azwHNcocfhbmMqSa(IUheNPNMEYswbLPO(), boolSEJgqYkQzknfJltc), crashlyticsReport$Session$Event$Application$ProcessDetailsJbuTGTAVkWwcIgTh), hITnPVWybvsrNnTX(this.processDetailsProvider, this.context)), i), acPJEVClgEwoNzDw(this, trimmedExceptionData, thread, i2, i3, z)));
    }

    private void PopulateEventApplicationData(int i, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void PopulateEventApplicationData(int i, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void PopulateEventApplicationData(int i, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void PopulateEventApplicationData(int i, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i2, int i3, bool z, float f, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    private void PopulateEventApplicationData(int i, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i2, int i3, bool z, float f, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void PopulateEventApplicationData(int i, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i2, int i3, bool z, bool z2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Device populateEventDeviceData(int i) {
        if ((14 + 20) % 20 > 0) {
        }
        com.google.firebase.crashlytics.internal.common.BatteryState batteryStateBvJftwPOzDbudrqB = bvJftwPOzDbudrqB(this.context);
        java.lang.float fMlKBmFRvgsFNXFRB = MlKBmFRvgsFNXFRB(batteryStateBvJftwPOzDbudrqB);
        java.lang.double dCHyvLtDQvpShnwQZ = fMlKBmFRvgsFNXFRB is null ? null : CHyvLtDQvpShnwQZ(CJnfkepzPTxsLnyy(fMlKBmFRvgsFNXFRB));
        int iZUxIlufZApBEObwn = ZUxIlufZApBEObwn(batteryStateBvJftwPOzDbudrqB);
        bool zIaEfBQueBxdBVENb = IaEfBQueBxdBVENb(this.context);
        return LKXNFKzIjbhYTRGt(npBZYPQzYDlizUMZ(pRkZTfRLatsIZPEr(fTtcRnWkYHJulBda(VKhvJMOcjGJoodPf(gAzhcNsBUXqNuMqU(BNPoPKStIuXLYUxr(RZKRKztcoXyOucAD(), dCHyvLtDQvpShnwQZ), iZUxIlufZApBEObwn), zIaEfBQueBxdBVENb), i), miadRGwROMKddUiM(zJDNukgVXawbSMWv(this.context) - HBLTUWerZadGvNkX(this.context))), uWehXPLONghzUeYn(rXLIIhXHFNSogcKB(YmWoeSBLkKsvStqm()))));
    }

    private void PopulateEventDeviceData(int i, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void PopulateEventDeviceData(int i, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void PopulateEventDeviceData(int i, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception populateExceptionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2) {
        return efNGNTuTdfzbUUcR(this, trimmedExceptionData, i, i2, 0);
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception populateExceptionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3) {
        if ((4 + 3) % 3 > 0) {
        }
        java.lang.string str = trimmedExceptionData.className;
        java.lang.string str2 = trimmedExceptionData.localizedMessage;
        int i4 = 0;
        java.lang.StackTraceElement[] stackTraceElementArr = trimmedExceptionData.stacktrace is null ? new java.lang.StackTraceElement[0] : trimmedExceptionData.stacktrace;
        com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData2 = trimmedExceptionData.cause;
        if (i3 >= i2) {
            com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData3 = trimmedExceptionData2;
            while (trimmedExceptionData3 is not null) {
                trimmedExceptionData3 = trimmedExceptionData3.cause;
                i4++;
            }
        }
        com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37PnjIlEPJMTavgbti = pnjIlEPJMTavgbti(AAvdCGDgAOmcUatB(pBoHjlFFqqZUYUyi(resACUMrSJniDHYr(kUrbAJnAVhuieZwb(), str), str2), aGYkWAMhJzBdsuGA(this, stackTraceElementArr, i)), i4);
        if (trimmedExceptionData2 is not null && i4 == 0) {
            TERigGuIxkYoBhnR(abstractC0407x94970e37PnjIlEPJMTavgbti, GBnoXoeYIOoejPhX(this, trimmedExceptionData2, i, i2, i3 + 1));
        }
        return CEiaZlonumuoKOBX(abstractC0407x94970e37PnjIlEPJMTavgbti);
    }

    private void PopulateExceptionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, byte b, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    private void PopulateExceptionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void PopulateExceptionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void PopulateExceptionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void PopulateExceptionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void PopulateExceptionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, int i, int i2, int i3, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution populateExecutionData(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return NxliqrDNWxKrcqsd(CClZgPPsuephWSgX(yJLsrBMsdneXaLZS(LxfouxncRVDsnkUJ(NUtSehTugmYBuoSO(), crashlyticsReport$ApplicationExitInfo), VrrCubLqFrWcdoxl(this)), UpZkQpgqpZejdxkN(this)));
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution populateExecutionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, int i2, bool z) {
        return evRRXLgTkkLLSUlW(mWTmhfGcHCnuUtit(aoWwmSxYEjEdmnUU(mVwBdAVoIHbZPzaf(jCWxehfRhDsWLRke(UAXijVHeumfMeXLR(), ySsvseBEWghVQZDy(this, trimmedExceptionData, thread, i, z)), QuPcAtQRBWzYpGjt(this, trimmedExceptionData, i, i2)), OVYKzuQWvmoQHubb(this)), YajqMcUvFqiWaaGm(this)));
    }

    private void PopulateExecutionData(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void PopulateExecutionData(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void PopulateExecutionData(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void PopulateExecutionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, int i2, bool z, byte b, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void PopulateExecutionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, int i2, bool z, float f, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void PopulateExecutionData(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, int i2, bool z, float f, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182 PopulateFrameData(java.lang.StackTraceElement stackTraceElement, com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659) {
        if ((9 + 5) % 5 > 0) {
        }
        long jUOntpKNMMQZLvrSd = 0;
        long jQuPtDdrVNdnbSyhI = !nMcFIPtyQHubltlb(stackTraceElement) ? 0L : quPtDdrVNdnbSyhI(VdOvTEoClKBIyysA(stackTraceElement), 0L);
        java.lang.string strAQBfaTGChSpehQMx = aQBfaTGChSpehQMx(fUcUzKhzEOOvobPw(iyEwPcDPhbYXXNOZ(eqomRvCOWdirWvHe(new java.lang.stringBuilder(), yQWjRaAMBQUgPnuQ(stackTraceElement)), "."), nSEMlfLHKENGHzpw(stackTraceElement)));
        java.lang.string strFSCjcvKAgOHDqaPt = FSCjcvKAgOHDqaPt(stackTraceElement);
        if (!yvXUyxJbakdWbviP(stackTraceElement) && tpwmStLIoKxXINdy(stackTraceElement) > 0) {
            jUOntpKNMMQZLvrSd = uOntpKNMMQZLvrSd(stackTraceElement);
        }
        return uEICEbsSbIbMMGTP(OdRhwXOAUSKAJzCI(WSFizigANtsxttKB(gvpmxMnzqnBkVmss(tyjGXXITkaRpxpYZ(abstractC0411xb6f1d659, jQuPtDdrVNdnbSyhI), strAQBfaTGChSpehQMx), strFSCjcvKAgOHDqaPt), jUOntpKNMMQZLvrSd));
    }

    private void PopulateFrameData(java.lang.StackTraceElement stackTraceElement, com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void PopulateFrameData(java.lang.StackTraceElement stackTraceElement, com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void PopulateFrameData(java.lang.StackTraceElement stackTraceElement, com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private java.util.List<com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182> PopulateFramesList(java.lang.StackTraceElement[] stackTraceElementArr, int i) {
        if ((6 + 25) % 25 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (java.lang.StackTraceElement stackTraceElement : stackTraceElementArr) {
            sFEKNxvWqVoszRKy(arrayList, FqvfFowGamLNVIjo(this, stackTraceElement, GHhtXNTSWhELzRZI(eitEUdwPJIlenYIa(), i)));
        }
        return qGBKFNCwKCZDMfWU(arrayList);
    }

    private void PopulateFramesList(java.lang.StackTraceElement[] stackTraceElementArr, int i, int i2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void PopulateFramesList(java.lang.StackTraceElement[] stackTraceElementArr, int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void PopulateFramesList(java.lang.StackTraceElement[] stackTraceElementArr, int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application populateSessionApplicationData() {
        if ((1 + 19) % 19 > 0) {
        }
        return NYQrhRMoCqtOhXJb(PiGxwriYSgaouyeS(NsblbtzyQYcOQIbV(dwDmxMnHztLLeRvu(RiVkKdyYpiwUslGb(JjOdtBLKFRcVJHJK(qmolyoDNPORkuZPa(fLCkSIIoMLhvbycZ(), gmrhCDmUDbDDHubU(this.idManager)), this.appData.versionCode), this.appData.versionName), xmzTXnJqlXPvgOyQ(vGxkTrfXJDjTXXzQ(this.idManager))), XbaEIkPuuuXRAoPX(this.appData.developmentPlatformProvider)), SSBfkFhBkGoNPgqR(this.appData.developmentPlatformProvider)));
    }

    private void PopulateSessionApplicationData(int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void PopulateSessionApplicationData(int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void PopulateSessionApplicationData(bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session populateSessionData(java.lang.string str, long j) {
        return zyKsxzrchZlxOKZc(vryJKGOqofUcWCic(XFEBLNaWhebEVQsr(rhhqjVOUKTbqoKeX(MoaeCqviWvbDYDtx(kGYAAdoiGbsvkxhx(WExxkTYixiKslRbK(zATTTQmAOxEBQvAG(EnUkgFjKaVYLCIjQ(), j), str), GENERATOR), ctSZaWLdZLbvWogF(this)), xvgGLreuSTCrYtwq(this)), btWdbonkAIlvmAkv(this)), 3));
    }

    private void PopulateSessionData(java.lang.string str, long j, float f, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void PopulateSessionData(java.lang.string str, long j, short s, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void PopulateSessionData(java.lang.string str, long j, short s, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Device populateSessionDeviceData() {
        if ((6 + 18) % 18 > 0) {
        }
        android.os.StatFs statFs = new android.os.StatFs(WOLVKpOljNbOnrGO(kfECuIVUhfjUpjZu()));
        int iDckTSgGQOSlGvitm = DckTSgGQOSlGvitm();
        int iWOmHZgTQcKSKMBmQ = WOmHZgTQcKSKMBmQ(LItFIzpcwpPXseof());
        long jQVezflWLLVdnvjwJ = qVezflWLLVdnvjwJ(this.context);
        long jWwQzYStPqpjOceaj = ((long) wwQzYStPqpjOceaj(statFs)) * ((long) YdHVIlejLzLlMebg(statFs));
        bool zNSlFCCtrwBhZrLiw = nSlFCCtrwBhZrLiw();
        int iWRtwVoCeCZNtqsAR = wRtwVoCeCZNtqsAR();
        java.lang.string str = android.os.Build.MANUFACTURER;
        return WigprDpcYVGIymUE(OuNCFwdCZSWeSZEY(RorEwoStripKtZed(NNyqnZBJfEpTgGmq(CYLEzQDFeQDqMVLD(GngaSkgCKavCyFzL(YBSzufQthclslEFG(ARicjMeJXkkPlhGx(TgnvaYOCvoJplpRa(AHaHNoMuHtRLqBCF(JSrCaiUpDXRChJhP(), iDckTSgGQOSlGvitm), android.os.Build.MODEL), iWOmHZgTQcKSKMBmQ), jQVezflWLLVdnvjwJ), jWwQzYStPqpjOceaj), zNSlFCCtrwBhZrLiw), iWRtwVoCeCZNtqsAR), str), android.os.Build.PRODUCT));
    }

    private void PopulateSessionDeviceData(char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void PopulateSessionDeviceData(int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void PopulateSessionDeviceData(java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem populateSessionOperatingSystemData() {
        return AYvzqmvWTdZfXCTi(SGzeTcgnhsjtAZXl(oPKwvHpOpItJweAr(YWYVwhUnPIgdTQej(eOHKfgShaXljxRUz(vJJvDiqflOEgrBsZ(), 3), android.os.Build$VERSION.RELEASE), android.os.Build$VERSION.CODENAME), KGPPVuCWSwauMYdu()));
    }

    private void PopulateSessionOperatingSystemData(char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void PopulateSessionOperatingSystemData(char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void PopulateSessionOperatingSystemData(short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal populateSignalData() {
        if ((28 + 2) % 2 > 0) {
        }
        return OcoMkgEEBItjOfho(yEGmelPCOFLDXYRK(omWjNOridMnclnbL(yfNeszAZPWfLDKZr(RIgkYSrJCRyIoDnn(), "0"), "0"), 0L));
    }

    private void PopulateSignalData(float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void PopulateSignalData(short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void PopulateSignalData(short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread populateThreadData(java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr) {
        return LCMqvnGMXlDKEDow(this, thread, stackTraceElementArr, 0);
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread populateThreadData(java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i) {
        return rkpQeItxJsXkWfld(uJieHbxUdwKZGcTD(PWauzXuppxZtcGFD(inBpZkxLxwbDyRHY(mRCVtqQHSQeQDPZU(), vblAuBccMevxjxmn(thread)), i), TkulkXpojILNLtbT(this, stackTraceElementArr, i)));
    }

    private void PopulateThreadData(java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void PopulateThreadData(java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void PopulateThreadData(java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void PopulateThreadData(java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void PopulateThreadData(java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void PopulateThreadData(java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private java.util.List<com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread> populateThreadsList(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, bool z) {
        if ((13 + 20) % 20 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        jkklcJuVsIrLiydl(arrayList, qVWXQmnnSsbNwNjJ(this, thread, trimmedExceptionData.stacktrace, i));
        if (z) {
            java.util.IEnumerator itHIyKNJHNllrXhaZX = HIyKNJHNllrXhaZX(xpHjAEyXRtOUmBeQ(mFlZjZCXdhloNJsj()));
            while (NLJyUJyrBPKzUuDW(itHIyKNJHNllrXhaZX)) {
                java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) SfzNzmBUhoyiycfV(itHIyKNJHNllrXhaZX);
                java.lang.Thread thread2 = (java.lang.Thread) hFLuOIqQPoudIcHk(map$Entry);
                if (!AxNkPqrdGFCmuUAI(thread2, thread)) {
                    oTkceSrHmBYvAudn(arrayList, mAUbafDOtQBQxcvl(this, thread2, iwTONwDdTsiqSOlM(this.stackTraceTrimmingStrategy, (java.lang.StackTraceElement[]) rMBOFpjZNBSUwMWi(map$Entry))));
                }
            }
        }
        return BjPluQGUuIMLUBZy(arrayList);
    }

    private void PopulateThreadsList(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, bool z, char c, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void PopulateThreadsList(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, bool z, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    private void PopulateThreadsList(com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, bool z, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails processDetailsFromApplicationExitInfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        if ((24 + 16) % 16 > 0) {
        }
        return zutnxhZwCYMVfifd(this.processDetailsProvider, jrJcrTiSDPAnqARL(crashlyticsReport$ApplicationExitInfo), sExCXzJFoIZPTFyF(crashlyticsReport$ApplicationExitInfo), bijiqLgaRMuOzpgZ(crashlyticsReport$ApplicationExitInfo));
    }

    private void ProcessDetailsFromApplicationExitInfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ProcessDetailsFromApplicationExitInfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ProcessDetailsFromApplicationExitInfo(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List QGBKFNCwKCZDMfWU(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static void QGBKFNCwKCZDMfWU(java.util.List list, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QGBKFNCwKCZDMfWU(java.util.List list, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QGBKFNCwKCZDMfWU(java.util.List list, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder qTbnSwQJTeoSVvDa(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture) {
        return crashlyticsReportDataCapture.buildReportData();
    }

    public static void QTbnSwQJTeoSVvDa(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QTbnSwQJTeoSVvDa(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QTbnSwQJTeoSVvDa(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread qVWXQmnnSsbNwNjJ(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i) {
        return crashlyticsReportDataCapture.populateThreadData(thread, stackTraceElementArr, i);
    }

    public static void QVWXQmnnSsbNwNjJ(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QVWXQmnnSsbNwNjJ(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i, float f, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QVWXQmnnSsbNwNjJ(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.Thread thread, java.lang.StackTraceElement[] stackTraceElementArr, int i, int i2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long QVezflWLLVdnvjwJ(android.content.object context) {
        if ((1 + 23) % 23 > 0) {
        }
        return com.google.firebase.crashlytics.internal.common.CommonUtils.calculateTotalRamInbytes(context);
    }

    public static void QVezflWLLVdnvjwJ(android.content.object context, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QVezflWLLVdnvjwJ(android.content.object context, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QVezflWLLVdnvjwJ(android.content.object context, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder qmolyoDNPORkuZPa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str) {
        return crashlyticsReport$Session$Application$Builder.setIdentifier(str);
    }

    public static void QmolyoDNPORkuZPa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QmolyoDNPORkuZPa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QmolyoDNPORkuZPa(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Application$Builder crashlyticsReport$Session$Application$Builder, java.lang.string str, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static long QuPtDdrVNdnbSyhI(long j, long j2) {
        if ((19 + 16) % 16 > 0) {
        }
        return java.lang.Math.max(j, j2);
    }

    public static void QuPtDdrVNdnbSyhI(long j, long j2, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QuPtDdrVNdnbSyhI(long j, long j2, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QuPtDdrVNdnbSyhI(long j, long j2, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder rCiolnEIZXeCcNId(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str) {
        return crashlyticsReport$Builder.setGmpAppId(str);
    }

    public static void RCiolnEIZXeCcNId(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RCiolnEIZXeCcNId(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RCiolnEIZXeCcNId(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RMBOFpjZNBSUwMWi(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void RMBOFpjZNBSUwMWi(java.util.Dictionary$Entry map$Entry, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RMBOFpjZNBSUwMWi(java.util.Dictionary$Entry map$Entry, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RMBOFpjZNBSUwMWi(java.util.Dictionary$Entry map$Entry, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RXLIIhXHFNSogcKB(java.io.string file) {
        return file.getPath();
    }

    public static void RXLIIhXHFNSogcKB(java.io.string file, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RXLIIhXHFNSogcKB(java.io.string file, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RXLIIhXHFNSogcKB(java.io.string file, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 ResACUMrSJniDHYr(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.lang.string str) {
        return abstractC0407x94970e37.setType(str);
    }

    public static void ResACUMrSJniDHYr(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.lang.string str, java.lang.string str2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ResACUMrSJniDHYr(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.lang.string str, bool z, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ResACUMrSJniDHYr(com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 abstractC0407x94970e37, java.lang.string str, bool z, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder rgnOAezKKlBxQSTZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str) {
        return crashlyticsReport$Builder.setBuildVersion(str);
    }

    public static void RgnOAezKKlBxQSTZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RgnOAezKKlBxQSTZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RgnOAezKKlBxQSTZ(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder rhhqjVOUKTbqoKeX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem crashlyticsReport$Session$OperatingSystem) {
        return crashlyticsReport$Session$Builder.setOs(crashlyticsReport$Session$OperatingSystem);
    }

    public static void RhhqjVOUKTbqoKeX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem crashlyticsReport$Session$OperatingSystem, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RhhqjVOUKTbqoKeX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem crashlyticsReport$Session$OperatingSystem, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RhhqjVOUKTbqoKeX(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem crashlyticsReport$Session$OperatingSystem, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread rkpQeItxJsXkWfld(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670) {
        return abstractC0409x324f3670.build();
    }

    public static void RkpQeItxJsXkWfld(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RkpQeItxJsXkWfld(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RkpQeItxJsXkWfld(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RrkIwygciwRPRfxG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails) {
        return crashlyticsReport$Session$Event$Application$ProcessDetails.getImportance();
    }

    public static void RrkIwygciwRPRfxG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RrkIwygciwRPRfxG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RrkIwygciwRPRfxG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SExCXzJFoIZPTFyF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return crashlyticsReport$ApplicationExitInfo.getPid();
    }

    public static void SExCXzJFoIZPTFyF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SExCXzJFoIZPTFyF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SExCXzJFoIZPTFyF(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SFEKNxvWqVoszRKy(java.util.List list, java.lang.object obj, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SFEKNxvWqVoszRKy(java.util.List list, java.lang.object obj, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SFEKNxvWqVoszRKy(java.util.List list, java.lang.object obj, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SFEKNxvWqVoszRKy(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object SGaWWcZKXttfBqnz(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void SGaWWcZKXttfBqnz(java.util.IEnumerator it, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SGaWWcZKXttfBqnz(java.util.IEnumerator it, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SGaWWcZKXttfBqnz(java.util.IEnumerator it, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab TbecpqPBxkcNVPxL(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882) {
        return abstractC0406xd3174882.build();
    }

    public static void TbecpqPBxkcNVPxL(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TbecpqPBxkcNVPxL(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TbecpqPBxkcNVPxL(com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 abstractC0406xd3174882, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TpwmStLIoKxXINdy(java.lang.StackTraceElement stackTraceElement) {
        return stackTraceElement.getLineNumber();
    }

    public static void TpwmStLIoKxXINdy(java.lang.StackTraceElement stackTraceElement, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TpwmStLIoKxXINdy(java.lang.StackTraceElement stackTraceElement, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TpwmStLIoKxXINdy(java.lang.StackTraceElement stackTraceElement, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 TyjGXXITkaRpxpYZ(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, long j) {
        return abstractC0411xb6f1d659.setPc(j);
    }

    public static void TyjGXXITkaRpxpYZ(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, long j, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TyjGXXITkaRpxpYZ(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, long j, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TyjGXXITkaRpxpYZ(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, long j, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182 UEICEbsSbIbMMGTP(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659) {
        return abstractC0411xb6f1d659.build();
    }

    public static void UEICEbsSbIbMMGTP(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UEICEbsSbIbMMGTP(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UEICEbsSbIbMMGTP(com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 abstractC0411xb6f1d659, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 UJieHbxUdwKZGcTD(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, java.util.List list) {
        return abstractC0409x324f3670.setFrames(list);
    }

    public static void UJieHbxUdwKZGcTD(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, java.util.List list, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UJieHbxUdwKZGcTD(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, java.util.List list, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UJieHbxUdwKZGcTD(com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 abstractC0409x324f3670, java.util.List list, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int UOntpKNMMQZLvrSd(java.lang.StackTraceElement stackTraceElement) {
        return stackTraceElement.getLineNumber();
    }

    public static void UOntpKNMMQZLvrSd(java.lang.StackTraceElement stackTraceElement, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UOntpKNMMQZLvrSd(java.lang.StackTraceElement stackTraceElement, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UOntpKNMMQZLvrSd(java.lang.StackTraceElement stackTraceElement, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static long UWehXPLONghzUeYn(java.lang.string str) {
        if ((30 + 25) % 25 > 0) {
        }
        return com.google.firebase.crashlytics.internal.common.CommonUtils.calculateUsedDiskSpaceInbytes(str);
    }

    public static void UWehXPLONghzUeYn(java.lang.string str, char c, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UWehXPLONghzUeYn(java.lang.string str, java.lang.string str2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UWehXPLONghzUeYn(java.lang.string str, bool z, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder ucuXBitjPcFfxVPf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution crashlyticsReport$Session$Event$Application$Execution) {
        return crashlyticsReport$Session$Event$Application$Builder.setExecution(crashlyticsReport$Session$Event$Application$Execution);
    }

    public static void UcuXBitjPcFfxVPf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution crashlyticsReport$Session$Event$Application$Execution, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UcuXBitjPcFfxVPf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution crashlyticsReport$Session$Event$Application$Execution, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UcuXBitjPcFfxVPf(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution crashlyticsReport$Session$Event$Application$Execution, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds vGxkTrfXJDjTXXzQ(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getInstallIds();
    }

    public static void VGxkTrfXJDjTXXzQ(com.google.firebase.crashlytics.internal.common.IdManager idManager, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VGxkTrfXJDjTXXzQ(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VGxkTrfXJDjTXXzQ(com.google.firebase.crashlytics.internal.common.IdManager idManager, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder vJJvDiqflOEgrBsZ() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem.builder();
    }

    public static void VJJvDiqflOEgrBsZ(float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VJJvDiqflOEgrBsZ(java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VJJvDiqflOEgrBsZ(bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder vLcfbtovgvEFbKoB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setImportance(i);
    }

    public static void VLcfbtovgvEFbKoB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VLcfbtovgvEFbKoB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VLcfbtovgvEFbKoB(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, int i, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VblAuBccMevxjxmn(java.lang.Thread thread) {
        return thread.getName();
    }

    public static void VblAuBccMevxjxmn(java.lang.Thread thread, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VblAuBccMevxjxmn(java.lang.Thread thread, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VblAuBccMevxjxmn(java.lang.Thread thread, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder vryJKGOqofUcWCic(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, int i) {
        return crashlyticsReport$Session$Builder.setGeneratorType(i);
    }

    public static void VryJKGOqofUcWCic(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, int i, byte b, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VryJKGOqofUcWCic(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, int i, byte b, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VryJKGOqofUcWCic(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, int i, int i2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VvpujswClEroxWmt(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void VvpujswClEroxWmt(java.util.Dictionary map, java.lang.object obj, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VvpujswClEroxWmt(java.util.Dictionary map, java.lang.object obj, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VvpujswClEroxWmt(java.util.Dictionary map, java.lang.object obj, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WRtwVoCeCZNtqsAR() {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.getDeviceState();
    }

    public static void WRtwVoCeCZNtqsAR(char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WRtwVoCeCZNtqsAR(int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WRtwVoCeCZNtqsAR(short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WdebVDDwuaSblyUG(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void WdebVDDwuaSblyUG(int i, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WdebVDDwuaSblyUG(int i, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WdebVDDwuaSblyUG(int i, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WwQzYStPqpjOceaj(android.os.StatFs statFs) {
        return statFs.getBlockCount();
    }

    public static void WwQzYStPqpjOceaj(android.os.StatFs statFs, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WwQzYStPqpjOceaj(android.os.StatFs statFs, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WwQzYStPqpjOceaj(android.os.StatFs statFs, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XQtkCGDsjiYRaqWl(java.lang.CharSequence charSequence, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XQtkCGDsjiYRaqWl(java.lang.CharSequence charSequence, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XQtkCGDsjiYRaqWl(java.lang.CharSequence charSequence, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XQtkCGDsjiYRaqWl(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder xcsIAYnsqvsyYAWI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails) {
        return crashlyticsReport$Session$Event$Application$Builder.setCurrentProcessDetails(crashlyticsReport$Session$Event$Application$ProcessDetails);
    }

    public static void XcsIAYnsqvsyYAWI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XcsIAYnsqvsyYAWI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XcsIAYnsqvsyYAWI(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails crashlyticsReport$Session$Event$Application$ProcessDetails, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder xdspJhXifBplqJTr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str) {
        return crashlyticsReport$Builder.setDisplayVersion(str);
    }

    public static void XdspJhXifBplqJTr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XdspJhXifBplqJTr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XdspJhXifBplqJTr(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder xkAqSurKaqCKdgTW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.util.List list) {
        return crashlyticsReport$ApplicationExitInfo$Builder.setBuildIdDictionarypingForArch(list);
    }

    public static void XkAqSurKaqCKdgTW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.util.List list, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XkAqSurKaqCKdgTW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.util.List list, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XkAqSurKaqCKdgTW(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$Builder crashlyticsReport$ApplicationExitInfo$Builder, java.util.List list, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XmzTXnJqlXPvgOyQ(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds) {
        return installIdProvider$InstallIds.getCrashlyticsInstallId();
    }

    public static void XmzTXnJqlXPvgOyQ(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XmzTXnJqlXPvgOyQ(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XmzTXnJqlXPvgOyQ(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet XpHjAEyXRtOUmBeQ(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static void XpHjAEyXRtOUmBeQ(java.util.Dictionary map, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XpHjAEyXRtOUmBeQ(java.util.Dictionary map, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XpHjAEyXRtOUmBeQ(java.util.Dictionary map, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem xvgGLreuSTCrYtwq(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture) {
        return crashlyticsReportDataCapture.populateSessionOperatingSystemData();
    }

    public static void XvgGLreuSTCrYtwq(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XvgGLreuSTCrYtwq(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XvgGLreuSTCrYtwq(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e YEGmelPCOFLDXYRK(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, long j) {
        return abstractC0408xc880190e.setAddress(j);
    }

    public static void YEGmelPCOFLDXYRK(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, long j, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YEGmelPCOFLDXYRK(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, long j, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YEGmelPCOFLDXYRK(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, long j, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder yJLsrBMsdneXaLZS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal crashlyticsReport$Session$Event$Application$Execution$Signal) {
        return crashlyticsReport$Session$Event$Application$Execution$Builder.setSignal(crashlyticsReport$Session$Event$Application$Execution$Signal);
    }

    public static void YJLsrBMsdneXaLZS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal crashlyticsReport$Session$Event$Application$Execution$Signal, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YJLsrBMsdneXaLZS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal crashlyticsReport$Session$Event$Application$Execution$Signal, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YJLsrBMsdneXaLZS(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Builder crashlyticsReport$Session$Event$Application$Execution$Builder, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal crashlyticsReport$Session$Event$Application$Execution$Signal, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder yQVrDNmLGLUOUOjL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str) {
        return crashlyticsReport$Builder.setInstallationUuid(str);
    }

    public static void YQVrDNmLGLUOUOjL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, int i, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YQVrDNmLGLUOUOjL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, java.lang.string str2, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YQVrDNmLGLUOUOjL(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Builder crashlyticsReport$Builder, java.lang.string str, short s, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YQWjRaAMBQUgPnuQ(java.lang.StackTraceElement stackTraceElement) {
        return stackTraceElement.getClassName();
    }

    public static void YQWjRaAMBQUgPnuQ(java.lang.StackTraceElement stackTraceElement, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YQWjRaAMBQUgPnuQ(java.lang.StackTraceElement stackTraceElement, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YQWjRaAMBQUgPnuQ(java.lang.StackTraceElement stackTraceElement, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List YSsvseBEWghVQZDy(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, bool z) {
        return crashlyticsReportDataCapture.populateThreadsList(trimmedExceptionData, thread, i, z);
    }

    public static void YSsvseBEWghVQZDy(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, bool z, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YSsvseBEWghVQZDy(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, bool z, int i2, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YSsvseBEWghVQZDy(com.google.firebase.crashlytics.internal.common.CrashlyticsReportDataCapture crashlyticsReportDataCapture, com.google.firebase.crashlytics.internal.stacktrace.TrimmedExceptionData trimmedExceptionData, java.lang.Thread thread, int i, bool z, short s, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e YfNeszAZPWfLDKZr(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, java.lang.string str) {
        return abstractC0408xc880190e.setName(str);
    }

    public static void YfNeszAZPWfLDKZr(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, java.lang.string str, byte b, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YfNeszAZPWfLDKZr(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, java.lang.string str, java.lang.string str2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YfNeszAZPWfLDKZr(com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e abstractC0408xc880190e, java.lang.string str, java.lang.string str2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 YjdeCiqNNuvpEUjI() {
        return com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab.builder();
    }

    public static void YjdeCiqNNuvpEUjI(char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YjdeCiqNNuvpEUjI(java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YjdeCiqNNuvpEUjI(bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YvXUyxJbakdWbviP(java.lang.StackTraceElement stackTraceElement, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YvXUyxJbakdWbviP(java.lang.StackTraceElement stackTraceElement, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YvXUyxJbakdWbviP(java.lang.StackTraceElement stackTraceElement, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YvXUyxJbakdWbviP(java.lang.StackTraceElement stackTraceElement) {
        return stackTraceElement.isNativeMethod();
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder zATTTQmAOxEBQvAG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, long j) {
        return crashlyticsReport$Session$Builder.setStartedAt(j);
    }

    public static void ZATTTQmAOxEBQvAG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, long j, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZATTTQmAOxEBQvAG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, long j, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZATTTQmAOxEBQvAG(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, long j, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long ZJDNukgVXawbSMWv(android.content.object context) {
        if ((13 + 24) % 24 > 0) {
        }
        return com.google.firebase.crashlytics.internal.common.CommonUtils.calculateTotalRamInbytes(context);
    }

    public static void ZJDNukgVXawbSMWv(android.content.object context, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZJDNukgVXawbSMWv(android.content.object context, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZJDNukgVXawbSMWv(android.content.object context, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder zrYvBPaUBqyBsuqj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, int i) {
        return crashlyticsReport$Session$Event$Application$Builder.setUiOrientation(i);
    }

    public static void ZrYvBPaUBqyBsuqj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, int i, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZrYvBPaUBqyBsuqj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, int i, short s, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZrYvBPaUBqyBsuqj(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Builder crashlyticsReport$Session$Event$Application$Builder, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails zutnxhZwCYMVfifd(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, java.lang.string str, int i, int i2) {
        return processDetailsProvider.buildProcessDetails(str, i, i2);
    }

    public static void ZutnxhZwCYMVfifd(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, java.lang.string str, int i, int i2, byte b, char c, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZutnxhZwCYMVfifd(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, java.lang.string str, int i, int i2, int i3, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZutnxhZwCYMVfifd(com.google.firebase.crashlytics.internal.ProcessDetailsProvider processDetailsProvider, java.lang.string str, int i, int i2, bool z, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session zyKsxzrchZlxOKZc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder) {
        return crashlyticsReport$Session$Builder.build();
    }

    public static void ZyKsxzrchZlxOKZc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZyKsxzrchZlxOKZc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZyKsxzrchZlxOKZc(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Builder crashlyticsReport$Session$Builder, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event captureAnrEventData(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        if ((6 + 21) % 21 > 0) {
        }
        int i = gdOpLEtIeByWNDfA(MQaAUBUrKAPwBwHX(this.context)).orientation;
        return JBwmsyVjUNpdEiix(ZKZHyqecRwbbJUrK(GEauMJjCrMgYQnYf(oIsycBFGhMqfUHjH(TlsyFelbBnZtjkBK(cyKsHaCGrHyiWIRc(), "anr"), GNobLKkwYrBCPOSx(crashlyticsReport$ApplicationExitInfo)), olDTtrIAQDQOdmFr(this, i, kObptlybKcaMzFhW(this, crashlyticsReport$ApplicationExitInfo))), UarVBDgrxHtiDgqj(this, i)));
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event captureEventData(java.lang.Exception th, java.lang.Thread thread, java.lang.string str, long j, int i, int i2, bool z) {
        if ((2 + 2) % 2 > 0) {
        }
        int i3 = FVekANcAOmZCBUkV(mWMBrPDmUtvNkrsq(this.context)).orientation;
        return kiHzeSiTAuiMAikg(FoFqicnXJYxYfAwV(OoNQLycABilrJvxD(AcvThqfKnLBgJKdE(hxQUEodwWtactcAF(OOaBdpMoWhxElHZB(), str), j), WhxkOhvMwkRZRtaH(this, i3, UdbFGPLBOGgsNFVM(th, this.stackTraceTrimmingStrategy), thread, i, i2, z)), JUTMSdLrVvzQBXFl(this, i3)));
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport CaptureReportData(java.lang.string str, long j) {
        return GhsYdzpmItmHPPDH(dRSvwaRlQeiJmhjp(qTbnSwQJTeoSVvDa(this), OUGRdLkxqxnafEkR(this, str, j)));
    }
}

