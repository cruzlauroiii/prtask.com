namespace WillowMaze.Wasm.Decompiled;


class CrashlyticsController {
    static readonly java.lang.string APP_EXCEPTION_MARKER_PREFIX = ".ae";
    static readonly java.lang.string FIREBASE_APPLICATION_EXCEPTION = "_ae";
    static readonly java.lang.string FIREBASE_CRASH_TYPE = "fatal";
    static readonly int FIREBASE_CRASH_TYPE_FATAL = 1;
    static readonly java.lang.string FIREBASE_TIMESTAMP = "timestamp";
    private static readonly java.lang.string GENERATOR_FORMAT = "Crashlytics Android SDK/%s";
    private static readonly java.lang.string META_INF_FOLDER = "META-INF/";
    private static readonly java.lang.string VERSION_CONTROL_INFO_FILE = "version-control-info.textproto";
    private static readonly java.lang.string VERSION_CONTROL_INFO_KEY = "com.crashlytics.version-control-info";
    private readonly com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger;
    private readonly com.google.firebase.crashlytics.internal.common.AppData appData;
    readonly java.util.concurrent.atomic.Atomicbool checkForUnsentReportsCalled;
    private readonly android.content.object context;
    private com.google.firebase.crashlytics.internal.common.CrashlyticsUncaughtExceptionHandler crashHandler;
    private readonly com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashMarker;
    private readonly com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers;
    private readonly com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter;
    private readonly com.google.firebase.crashlytics.internal.persistence.stringStore fileStore;
    private readonly com.google.firebase.crashlytics.internal.common.IdManager idManager;
    private readonly com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager;
    private readonly com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent nativeComponent;
    readonly com.google.android.gms.tasks.TaskCompletionSource<java.lang.bool> reportActionProvided;
    private readonly com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator reportingCoordinator;
    private readonly com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber sessionsSubscriber;
    private com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider;
    readonly com.google.android.gms.tasks.TaskCompletionSource<java.lang.bool> unsentReportsAvailable;
    readonly com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> unsentReportsHandled;
    private readonly com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata;
    static readonly java.io.stringnameFilter APP_EXCEPTION_MARKER_FILTER = new com.google.firebase.crashlytics.internal.common.CrashlyticsController$$ExternalSyntheticLambda1();
    private static readonly java.nio.charset.Charset UTF_8 = dNwRBTkLgmJOFCuN("UTF-8");

    CrashlyticsController(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, com.google.firebase.crashlytics.internal.common.AppData appData, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger, com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers) {
        if ((11 + 4) % 4 > 0) {
        }
        this.settingsProvider = null;
        this.unsentReportsAvailable = new com.google.android.gms.tasks.TaskCompletionSource<>();
        this.reportActionProvided = new com.google.android.gms.tasks.TaskCompletionSource<>();
        this.unsentReportsHandled = new com.google.android.gms.tasks.TaskCompletionSource<>();
        this.checkForUnsentReportsCalled = new java.util.concurrent.atomic.Atomicbool(false);
        this.context = context;
        this.idManager = idManager;
        this.dataICollectionArbiter = dataICollectionArbiter;
        this.fileStore = fileStore;
        this.crashMarker = crashlyticsstringMarker;
        this.appData = appData;
        this.userMetadata = userMetadata;
        this.logstringManager = logstringManager;
        this.nativeComponent = crashlyticsNativeComponent;
        this.analyticsEventConsoleger = analyticsEventConsoleger;
        this.sessionsSubscriber = crashlyticsAppQualitySessionsSubscriber;
        this.reportingCoordinator = sessionReportingCoordinator;
        this.crashlyticsWorkers = crashlyticsWorkers;
    }

    public static java.lang.stringBuilder AJCGoloZaFvCQSAD(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void AJCGoloZaFvCQSAD(java.lang.stringBuilder sb, java.lang.object obj, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AJCGoloZaFvCQSAD(java.lang.stringBuilder sb, java.lang.object obj, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AJCGoloZaFvCQSAD(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task AjUwjZlxqhenNXgJ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void AjUwjZlxqhenNXgJ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AjUwjZlxqhenNXgJ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AjUwjZlxqhenNXgJ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AmcggvBJpqwWuKJT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void AmcggvBJpqwWuKJT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AmcggvBJpqwWuKJT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AmcggvBJpqwWuKJT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BAfKjTCEhZuimruO(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2) {
        crashlyticsController.setInternalKey(str, str2);
    }

    public static void BAfKjTCEhZuimruO(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, char c, float f, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BAfKjTCEhZuimruO(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, char c, java.lang.string str3, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BAfKjTCEhZuimruO(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, float f, byte b, char c, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger BKqZFLprYzrMkRRa() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void BKqZFLprYzrMkRRa(byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKqZFLprYzrMkRRa(byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BKqZFLprYzrMkRRa(short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string BLBqWGTWHIHUCCIu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2) {
        return fileStore.getSessionstring(str, str2);
    }

    public static void BLBqWGTWHIHUCCIu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, int i, java.lang.string str3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLBqWGTWHIHUCCIu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BLBqWGTWHIHUCCIu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, short s, bool z, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task BMTZhHbaPSxwfggM(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void BMTZhHbaPSxwfggM(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BMTZhHbaPSxwfggM(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BMTZhHbaPSxwfggM(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BNUSDCJBmiGLbVwn(java.lang.string str, java.nio.charset.Charset charset, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BNUSDCJBmiGLbVwn(java.lang.string str, java.nio.charset.Charset charset, short s, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BNUSDCJBmiGLbVwn(java.lang.string str, java.nio.charset.Charset charset, bool z, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static byte[] BNUSDCJBmiGLbVwn(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static com.google.firebase.crashlytics.internal.Consoleger BPZgDTJDAsETCOFx() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void BPZgDTJDAsETCOFx(byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BPZgDTJDAsETCOFx(java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BPZgDTJDAsETCOFx(java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long BTPgLfRXWKUPQjwo() {
        if ((27 + 18) % 18 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void BTPgLfRXWKUPQjwo(int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BTPgLfRXWKUPQjwo(java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BTPgLfRXWKUPQjwo(short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BWjAisNlXWfqbLNV(com.google.firebase.crashlytics.internal.common.CrashlyticsUncaughtExceptionHandler crashlyticsUncaughtExceptionHandler, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BWjAisNlXWfqbLNV(com.google.firebase.crashlytics.internal.common.CrashlyticsUncaughtExceptionHandler crashlyticsUncaughtExceptionHandler, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BWjAisNlXWfqbLNV(com.google.firebase.crashlytics.internal.common.CrashlyticsUncaughtExceptionHandler crashlyticsUncaughtExceptionHandler, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BWjAisNlXWfqbLNV(com.google.firebase.crashlytics.internal.common.CrashlyticsUncaughtExceptionHandler crashlyticsUncaughtExceptionHandler) {
        return crashlyticsUncaughtExceptionHandler.isHandlingException();
    }

    public static void BZewjcIMwCtGxVAT(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str) {
        crashlyticsController.openSession(str);
    }

    public static void BZewjcIMwCtGxVAT(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BZewjcIMwCtGxVAT(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BZewjcIMwCtGxVAT(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CJpXexpfwnqTlJCD(java.lang.bool bool, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CJpXexpfwnqTlJCD(java.lang.bool bool, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CJpXexpfwnqTlJCD(java.lang.bool bool, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool CJpXexpfwnqTlJCD(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.string CLVqVyaXPIJjwdAi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void CLVqVyaXPIJjwdAi(java.lang.stringBuilder sb, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CLVqVyaXPIJjwdAi(java.lang.stringBuilder sb, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CLVqVyaXPIJjwdAi(java.lang.stringBuilder sb, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CdBjefhtwwJtKGEz(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void CdBjefhtwwJtKGEz(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CdBjefhtwwJtKGEz(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CdBjefhtwwJtKGEz(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CgIBpVWIxsOmEptF(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void CgIBpVWIxsOmEptF(java.lang.stringBuilder sb, long j, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CgIBpVWIxsOmEptF(java.lang.stringBuilder sb, long j, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CgIBpVWIxsOmEptF(java.lang.stringBuilder sb, long j, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CteuSpSsyPHYMVbf(java.util.List list, java.lang.object obj, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CteuSpSsyPHYMVbf(java.util.List list, java.lang.object obj, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CteuSpSsyPHYMVbf(java.util.List list, java.lang.object obj, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CteuSpSsyPHYMVbf(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void DBDfbJMZHIrXaQGp(float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DBDfbJMZHIrXaQGp(int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DBDfbJMZHIrXaQGp(bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DBDfbJMZHIrXaQGp() {
        return firebaseCrashExists();
    }

    public static void DGXCpsoAxunoecgK(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DGXCpsoAxunoecgK(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DGXCpsoAxunoecgK(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] DGXCpsoAxunoecgK(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager) {
        return logstringManager.getbytesForConsole();
    }

    public static void DMOoJGGcIUHNxmim(int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DMOoJGGcIUHNxmim(short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DMOoJGGcIUHNxmim(short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DMOoJGGcIUHNxmim() {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.isRooted();
    }

    public static java.io.string DfzlefKbXQLEOkZc(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider) {
        return nativeSessionstringProvider.getMetadatastring();
    }

    public static void DfzlefKbXQLEOkZc(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DfzlefKbXQLEOkZc(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DfzlefKbXQLEOkZc(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DrlDFYHEMqfmqhUy(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void DrlDFYHEMqfmqhUy(android.content.object context, java.lang.string str, byte b, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DrlDFYHEMqfmqhUy(android.content.object context, java.lang.string str, java.lang.string str2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DrlDFYHEMqfmqhUy(android.content.object context, java.lang.string str, bool z, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EAgQWdhhJkrmRDXH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EAgQWdhhJkrmRDXH(java.lang.stringBuilder sb, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EAgQWdhhJkrmRDXH(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EAgQWdhhJkrmRDXH(java.lang.stringBuilder sb, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ECUCCqrkidGSEAUg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ECUCCqrkidGSEAUg(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ECUCCqrkidGSEAUg(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ECUCCqrkidGSEAUg(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger EHNeQzlNqqkFBiuI() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void EHNeQzlNqqkFBiuI(byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EHNeQzlNqqkFBiuI(float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EHNeQzlNqqkFBiuI(int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EdLwkkAacvppQEcW(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void EdLwkkAacvppQEcW(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EdLwkkAacvppQEcW(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EdLwkkAacvppQEcW(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static long EwUwMgEdDZEcXMRl() {
        if ((23 + 16) % 16 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void EwUwMgEdDZEcXMRl(byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EwUwMgEdDZEcXMRl(float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EwUwMgEdDZEcXMRl(float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static long FDGslXmdqDvcVajC(java.lang.string str) {
        if ((14 + 16) % 16 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static void FDGslXmdqDvcVajC(java.lang.string str, char c, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FDGslXmdqDvcVajC(java.lang.string str, float f, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FDGslXmdqDvcVajC(java.lang.string str, java.lang.string str2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger FDyZAWyvSZejeGfd() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void FDyZAWyvSZejeGfd(java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FDyZAWyvSZejeGfd(bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FDyZAWyvSZejeGfd(bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool FMCmcJFMFVugOjIw(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void FMCmcJFMFVugOjIw(bool z, byte b, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FMCmcJFMFVugOjIw(bool z, short s, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FMCmcJFMFVugOjIw(bool z, bool z2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger FMPAcJksslyqMhed() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void FMPAcJksslyqMhed(byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FMPAcJksslyqMhed(float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FMPAcJksslyqMhed(int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger FPlTPWvbOJXhFdRW() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void FPlTPWvbOJXhFdRW(char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FPlTPWvbOJXhFdRW(java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FPlTPWvbOJXhFdRW(bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string FqjzYoROfXXEzGSJ() {
        return android.os.Environment.getDataDirectory();
    }

    public static void FqjzYoROfXXEzGSJ(byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FqjzYoROfXXEzGSJ(char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FqjzYoROfXXEzGSJ(bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task GRDOianVetuqGKqu(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(executor, successContinuation);
    }

    public static void GRDOianVetuqGKqu(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GRDOianVetuqGKqu(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRDOianVetuqGKqu(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger GTSCtrVPiDgZpyuy() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void GTSCtrVPiDgZpyuy(int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GTSCtrVPiDgZpyuy(int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GTSCtrVPiDgZpyuy(short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger GgnjClWcmmSsRDOd() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void GgnjClWcmmSsRDOd(byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GgnjClWcmmSsRDOd(float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GgnjClWcmmSsRDOd(int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GmSKxsYXbbVQtnuR(java.util.List list, java.lang.object obj, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GmSKxsYXbbVQtnuR(java.util.List list, java.lang.object obj, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GmSKxsYXbbVQtnuR(java.util.List list, java.lang.object obj, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GmSKxsYXbbVQtnuR(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void GmSuWwGSSSIGnbrW(char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GmSuWwGSSSIGnbrW(java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GmSuWwGSSSIGnbrW(short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool GmSuWwGSSSIGnbrW() {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.isEmulator();
    }

    public static java.lang.string GmqMMdEyvjSligXH(java.io.string file) {
        return file.getName();
    }

    public static void GmqMMdEyvjSligXH(java.io.string file, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GmqMMdEyvjSligXH(java.io.string file, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GmqMMdEyvjSligXH(java.io.string file, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger GsQXpOdJlMJbnbWq() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void GsQXpOdJlMJbnbWq(float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GsQXpOdJlMJbnbWq(float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GsQXpOdJlMJbnbWq(int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger GsdqXeagwivIxigu() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void GsdqXeagwivIxigu(byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GsdqXeagwivIxigu(int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GsdqXeagwivIxigu(bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HDkHpipCvBchhEUs(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.getCurrentSessionId();
    }

    public static void HDkHpipCvBchhEUs(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HDkHpipCvBchhEUs(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HDkHpipCvBchhEUs(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HWSnEJNEtsPfOUgX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void HWSnEJNEtsPfOUgX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HWSnEJNEtsPfOUgX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HWSnEJNEtsPfOUgX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger HoDnrXGZMnojinmc() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void HoDnrXGZMnojinmc(short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HoDnrXGZMnojinmc(short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HoDnrXGZMnojinmc(bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task HprqxPtKYDpEpKST(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2) {
        return com.google.firebase.crashlytics.internal.concurrency.CrashlyticsTasks.race(task, task2);
    }

    public static void HprqxPtKYDpEpKST(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HprqxPtKYDpEpKST(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HprqxPtKYDpEpKST(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IInxiPVtnFBYQUFT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IInxiPVtnFBYQUFT(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IInxiPVtnFBYQUFT(java.lang.stringBuilder sb, java.lang.string str, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IInxiPVtnFBYQUFT(java.lang.stringBuilder sb, java.lang.string str, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IXUrYdnvkKLhDgMS(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool) {
        crashlyticsController.doOpenSession(str, bool);
    }

    public static void IXUrYdnvkKLhDgMS(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool, java.lang.string str2, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IXUrYdnvkKLhDgMS(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool, short s, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IXUrYdnvkKLhDgMS(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool, bool z, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IbSQDEqHMEHoMZCR(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IbSQDEqHMEHoMZCR(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IbSQDEqHMEHoMZCR(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool IbSQDEqHMEHoMZCR(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter) {
        return dataICollectionArbiter.isAutomaticDataICollectionEnabled();
    }

    public static void IcsggMalUKWhvZYg(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IcsggMalUKWhvZYg(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IcsggMalUKWhvZYg(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool IcsggMalUKWhvZYg(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static java.lang.string IfVEYpFrEIPOYkHM() {
        return com.google.firebase.crashlytics.internal.common.CrashlyticsCore.getVersion();
    }

    public static void IfVEYpFrEIPOYkHM(float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IfVEYpFrEIPOYkHM(short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IfVEYpFrEIPOYkHM(bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IlmCozsbKQCgmVbB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void IlmCozsbKQCgmVbB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IlmCozsbKQCgmVbB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IlmCozsbKQCgmVbB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IpJhKsDqczjUraGO(java.io.string file, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IpJhKsDqczjUraGO(java.io.string file, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IpJhKsDqczjUraGO(java.io.string file, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IpJhKsDqczjUraGO(java.io.string file) {
        return file.exists();
    }

    public static void IsfqiiGNnIbZXshx(java.io.Stream inputStream, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IsfqiiGNnIbZXshx(java.io.Stream inputStream, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IsfqiiGNnIbZXshx(java.io.Stream inputStream, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] IsfqiiGNnIbZXshx(java.io.Stream inputStream) {
        return readResource(inputStream);
    }

    public static void IxrriOIhoYRTuOyy(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, bool z) throws java.lang.Exception {
        crashlyticsController.handleUncaughtException(settingsProvider, thread, th, z);
    }

    public static void IxrriOIhoYRTuOyy(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, bool z, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IxrriOIhoYRTuOyy(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, bool z, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IxrriOIhoYRTuOyy(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, bool z, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.metadata.UserMetadata JGezKFmHIDbLvEDT(java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers) {
        return com.google.firebase.crashlytics.internal.metadata.UserMetadata.loadFromExistingSession(str, fileStore, crashlyticsWorkers);
    }

    public static void JGezKFmHIDbLvEDT(java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, int i, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JGezKFmHIDbLvEDT(java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, java.lang.string str2, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JGezKFmHIDbLvEDT(java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, short s, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool JPnbunsPlRNLRgQb(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void JPnbunsPlRNLRgQb(bool z, char c, java.lang.string str, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JPnbunsPlRNLRgQb(bool z, bool z2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JPnbunsPlRNLRgQb(bool z, bool z2, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JSjbZeRKiXTcAUfK(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata) {
        sessionReportingCoordinator.persistNonFatalEvent(th, thread, eventMetadata);
    }

    public static void JSjbZeRKiXTcAUfK(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JSjbZeRKiXTcAUfK(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JSjbZeRKiXTcAUfK(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.Exception th, java.lang.Thread thread, com.google.firebase.crashlytics.internal.metadata.EventMetadata eventMetadata, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool JXMHDRUTdbMHLoVx(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void JXMHDRUTdbMHLoVx(bool z, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JXMHDRUTdbMHLoVx(bool z, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JXMHDRUTdbMHLoVx(bool z, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JbOLIjfiNwOJImfR(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m353e(str);
    }

    public static void JbOLIjfiNwOJImfR(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JbOLIjfiNwOJImfR(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JbOLIjfiNwOJImfR(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JjrngDIffwupSiJV(java.util.List list, java.lang.object obj, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JjrngDIffwupSiJV(java.util.List list, java.lang.object obj, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JjrngDIffwupSiJV(java.util.List list, java.lang.object obj, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool JjrngDIffwupSiJV(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int JpfngapALqMOHwWI() {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.getDeviceState();
    }

    public static void JpfngapALqMOHwWI(char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JpfngapALqMOHwWI(float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JpfngapALqMOHwWI(java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JqNlulajWWcjGZPZ(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager) {
        logstringManager.clearConsole();
    }

    public static void JqNlulajWWcjGZPZ(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JqNlulajWWcjGZPZ(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JqNlulajWWcjGZPZ(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger JwHLltzYXnsVsVfQ() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void JwHLltzYXnsVsVfQ(char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JwHLltzYXnsVsVfQ(char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwHLltzYXnsVsVfQ(int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KDmaToOZhuVWCeDJ(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds) {
        return installIdProvider$InstallIds.getCrashlyticsInstallId();
    }

    public static void KDmaToOZhuVWCeDJ(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KDmaToOZhuVWCeDJ(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KDmaToOZhuVWCeDJ(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KOcVzhujtptsRsPP(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j) {
        crashlyticsController.doWriteAppExceptionMarker(j);
    }

    public static void KOcVzhujtptsRsPP(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KOcVzhujtptsRsPP(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KOcVzhujtptsRsPP(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger KSxKhDQHlPhCyFAh() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void KSxKhDQHlPhCyFAh(byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KSxKhDQHlPhCyFAh(float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KSxKhDQHlPhCyFAh(bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KkrtdCeENTDSIYCy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void KkrtdCeENTDSIYCy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KkrtdCeENTDSIYCy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KkrtdCeENTDSIYCy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KocKICszJJKWYCyL(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static void KocKICszJJKWYCyL(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KocKICszJJKWYCyL(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KocKICszJJKWYCyL(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LACbrZomYqxWLHdq(java.util.List list, java.lang.object obj, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LACbrZomYqxWLHdq(java.util.List list, java.lang.object obj, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LACbrZomYqxWLHdq(java.util.List list, java.lang.object obj, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LACbrZomYqxWLHdq(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int LPsoKxvztiFVFINq(android.os.StatFs statFs) {
        return statFs.getBlockCount();
    }

    public static void LPsoKxvztiFVFINq(android.os.StatFs statFs, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LPsoKxvztiFVFINq(android.os.StatFs statFs, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LPsoKxvztiFVFINq(android.os.StatFs statFs, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static long LQatazdFKMkZZdjC() {
        if ((20 + 8) % 8 > 0) {
        }
        return getCurrentTimestampSeconds();
    }

    public static void LQatazdFKMkZZdjC(float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LQatazdFKMkZZdjC(java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LQatazdFKMkZZdjC(bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.ClassLoader LftCGwOsgWZQDJTn(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void LftCGwOsgWZQDJTn(java.lang.Class cls, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LftCGwOsgWZQDJTn(java.lang.Class cls, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LftCGwOsgWZQDJTn(java.lang.Class cls, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LkcvmsuPMKHwXVUH(java.util.List list, java.lang.object obj, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LkcvmsuPMKHwXVUH(java.util.List list, java.lang.object obj, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LkcvmsuPMKHwXVUH(java.util.List list, java.lang.object obj, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LkcvmsuPMKHwXVUH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.firebase.crashlytics.internal.Consoleger LsKGoRfMDrhCMdXg() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void LsKGoRfMDrhCMdXg(float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LsKGoRfMDrhCMdXg(java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LsKGoRfMDrhCMdXg(short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static long LurYGiCEiMTFWfCs() {
        if ((28 + 22) % 22 > 0) {
        }
        return getCurrentTimestampSeconds();
    }

    public static void LurYGiCEiMTFWfCs(java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LurYGiCEiMTFWfCs(java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LurYGiCEiMTFWfCs(short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LvkMSKAENghILrmI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2) {
        crashlyticsController.doCloseSessions(z, settingsProvider, z2);
    }

    public static void LvkMSKAENghILrmI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LvkMSKAENghILrmI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LvkMSKAENghILrmI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task LyckKNCHLLajoAzg(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(successContinuation);
    }

    public static void LyckKNCHLLajoAzg(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.SuccessContinuation successContinuation, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LyckKNCHLLajoAzg(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.SuccessContinuation successContinuation, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LyckKNCHLLajoAzg(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.SuccessContinuation successContinuation, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task MKIfCBinKDTiWPiX(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static void MKIfCBinKDTiWPiX(java.lang.object obj, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MKIfCBinKDTiWPiX(java.lang.object obj, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MKIfCBinKDTiWPiX(java.lang.object obj, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MmnoEVCsPCbzsHzK(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        sessionReportingCoordinator.finalizeSessionWithNativeEvent(str, list, crashlyticsReport$ApplicationExitInfo);
    }

    public static void MmnoEVCsPCbzsHzK(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MmnoEVCsPCbzsHzK(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str2, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MmnoEVCsPCbzsHzK(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, bool z, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string MsAEcbzJIBApvuXM(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2) {
        return fileStore.getSessionstring(str, str2);
    }

    public static void MsAEcbzJIBApvuXM(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, int i, float f, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MsAEcbzJIBApvuXM(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, int i, java.lang.string str3, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MsAEcbzJIBApvuXM(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, int i, bool z, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger MwYYZEyiGFLxsipr() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void MwYYZEyiGFLxsipr(char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MwYYZEyiGFLxsipr(char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MwYYZEyiGFLxsipr(bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NDurSpneQnWZXWRe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void NDurSpneQnWZXWRe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NDurSpneQnWZXWRe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NDurSpneQnWZXWRe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NMFOiwmetepkNWSh(java.lang.string str) {
        return str.Length;
    }

    public static void NMFOiwmetepkNWSh(java.lang.string str, byte b, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NMFOiwmetepkNWSh(java.lang.string str, float f, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NMFOiwmetepkNWSh(java.lang.string str, java.lang.string str2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData NOJjMVgeIOXbVlWg(java.lang.string str, java.lang.string str2, bool z) {
        return com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData.create(str, str2, z);
    }

    public static void NOJjMVgeIOXbVlWg(java.lang.string str, java.lang.string str2, bool z, char c, java.lang.string str3, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NOJjMVgeIOXbVlWg(java.lang.string str, java.lang.string str2, bool z, char c, bool z2, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NOJjMVgeIOXbVlWg(java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger NTOtruTtcqyoCuQr() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void NTOtruTtcqyoCuQr(byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NTOtruTtcqyoCuQr(byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NTOtruTtcqyoCuQr(float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NxgHOSBNmSFEBOje(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m355i(str);
    }

    public static void NxgHOSBNmSFEBOje(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NxgHOSBNmSFEBOje(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NxgHOSBNmSFEBOje(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OKiaDjDNvnomytJj(java.io.string file, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OKiaDjDNvnomytJj(java.io.string file, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OKiaDjDNvnomytJj(java.io.string file, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool OKiaDjDNvnomytJj(java.io.string file) {
        return file.exists();
    }

    public static com.google.firebase.crashlytics.internal.Consoleger OTfccrguwtTOLPbZ() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void OTfccrguwtTOLPbZ(byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OTfccrguwtTOLPbZ(java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OTfccrguwtTOLPbZ(java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger ObKjDkKObxxeNrtI() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void ObKjDkKObxxeNrtI(int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ObKjDkKObxxeNrtI(int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ObKjDkKObxxeNrtI(short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OnsICcqwgrMRnIVZ(java.io.string file, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OnsICcqwgrMRnIVZ(java.io.string file, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OnsICcqwgrMRnIVZ(java.io.string file, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool OnsICcqwgrMRnIVZ(java.io.string file) {
        return file.exists();
    }

    public static void OoQpaFOjSeEbhWtq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void OoQpaFOjSeEbhWtq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OoQpaFOjSeEbhWtq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OoQpaFOjSeEbhWtq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PAPbTyJEoRWZuSAu(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PAPbTyJEoRWZuSAu(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PAPbTyJEoRWZuSAu(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PAPbTyJEoRWZuSAu(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.isHandlingException();
    }

    public static com.google.android.gms.tasks.Task PQCJNNRfHtsLKnzp(java.util.ICollection collection) {
        return com.google.android.gms.tasks.Tasks.whenAll((java.util.ICollection<? : com.google.android.gms.tasks.Task<object>>) collection);
    }

    public static void PQCJNNRfHtsLKnzp(java.util.ICollection collection, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PQCJNNRfHtsLKnzp(java.util.ICollection collection, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PQCJNNRfHtsLKnzp(java.util.ICollection collection, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string PUbWXgSuqCJiDrUf(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2) {
        return fileStore.getSessionstring(str, str2);
    }

    public static void PUbWXgSuqCJiDrUf(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PUbWXgSuqCJiDrUf(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PUbWXgSuqCJiDrUf(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, java.lang.string str2, bool z, int i, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PZwIQTPfggTyWIxT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PZwIQTPfggTyWIxT(java.lang.stringBuilder sb, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PZwIQTPfggTyWIxT(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PZwIQTPfggTyWIxT(java.lang.stringBuilder sb, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PbLOhShoypKqvbFK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void PbLOhShoypKqvbFK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PbLOhShoypKqvbFK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PbLOhShoypKqvbFK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PeLKGHURdGAUeavm(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, long j, java.lang.string str) {
        sessionReportingCoordinator.finalizeSessions(j, str);
    }

    public static void PeLKGHURdGAUeavm(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, long j, java.lang.string str, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PeLKGHURdGAUeavm(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, long j, java.lang.string str, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PeLKGHURdGAUeavm(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, long j, java.lang.string str, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static long PxnHAlzInEfBVDUg(long j) {
        if ((3 + 8) % 8 > 0) {
        }
        return getTimestampSeconds(j);
    }

    public static void PxnHAlzInEfBVDUg(long j, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PxnHAlzInEfBVDUg(long j, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PxnHAlzInEfBVDUg(long j, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PyXrDygrIfidHidh(java.lang.bool bool, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PyXrDygrIfidHidh(java.lang.bool bool, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PyXrDygrIfidHidh(java.lang.bool bool, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PyXrDygrIfidHidh(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static com.google.android.gms.tasks.Task QMcghhavQYRJmtzV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.waitForReportAction();
    }

    public static void QMcghhavQYRJmtzV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QMcghhavQYRJmtzV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QMcghhavQYRJmtzV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger QOIgnUTTbUpcaguu() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void QOIgnUTTbUpcaguu(int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QOIgnUTTbUpcaguu(int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QOIgnUTTbUpcaguu(short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QqgfIBrsqGuoPaYj(java.lang.string str, java.lang.string str2, byte b, bool z, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QqgfIBrsqGuoPaYj(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QqgfIBrsqGuoPaYj(java.lang.string str, java.lang.string str2, bool z, byte b, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QqgfIBrsqGuoPaYj(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static com.google.android.gms.tasks.Task QznrMjBfhZbNAowU(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable) {
        return crashlyticsWorker.submit(runnable);
    }

    public static void QznrMjBfhZbNAowU(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QznrMjBfhZbNAowU(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QznrMjBfhZbNAowU(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.Stream RErxsnCfWGcRkiKi(java.lang.ClassLoader classLoader, java.lang.string str) {
        return classLoader.getResourceAsStream(str);
    }

    public static void RErxsnCfWGcRkiKi(java.lang.ClassLoader classLoader, java.lang.string str, float f, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RErxsnCfWGcRkiKi(java.lang.ClassLoader classLoader, java.lang.string str, int i, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RErxsnCfWGcRkiKi(java.lang.ClassLoader classLoader, java.lang.string str, short s, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RWPFxaqeykbSzsbN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.getCurrentSessionId();
    }

    public static void RWPFxaqeykbSzsbN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RWPFxaqeykbSzsbN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RWPFxaqeykbSzsbN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RfwioAVSkbcDfUNB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void RfwioAVSkbcDfUNB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RfwioAVSkbcDfUNB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RfwioAVSkbcDfUNB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RiCjGiWIHyZLnkCT(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, char c, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RiCjGiWIHyZLnkCT(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, float f, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RiCjGiWIHyZLnkCT(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, java.lang.string str2, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool RiCjGiWIHyZLnkCT(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str) {
        return crashlyticsNativeComponent.hasCrashDataForSession(str);
    }

    public static void SEvSpZUbUhnNzQjK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void SEvSpZUbUhnNzQjK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SEvSpZUbUhnNzQjK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SEvSpZUbUhnNzQjK(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SnlpGVtBlnJoDJtZ(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SnlpGVtBlnJoDJtZ(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SnlpGVtBlnJoDJtZ(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool SnlpGVtBlnJoDJtZ(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker) {
        return crashlyticsstringMarker.Remove();
    }

    public static void SrHBNqiMAWihLkhS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void SrHBNqiMAWihLkhS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SrHBNqiMAWihLkhS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SrHBNqiMAWihLkhS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SumVcWrVVglvCLkk(java.util.IEnumerator it, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SumVcWrVVglvCLkk(java.util.IEnumerator it, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SumVcWrVVglvCLkk(java.util.IEnumerator it, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SumVcWrVVglvCLkk(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void TIeIjYzDZPJdgsQW(java.util.List list) {
        deletestrings(list);
    }

    public static void TIeIjYzDZPJdgsQW(java.util.List list, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIeIjYzDZPJdgsQW(java.util.List list, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIeIjYzDZPJdgsQW(java.util.List list, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger TgtPmtOQxNCPzneP() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void TgtPmtOQxNCPzneP(int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TgtPmtOQxNCPzneP(java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TgtPmtOQxNCPzneP(java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TnKXVOeBBnTRvRIL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void TnKXVOeBBnTRvRIL(java.lang.stringBuilder sb, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TnKXVOeBBnTRvRIL(java.lang.stringBuilder sb, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TnKXVOeBBnTRvRIL(java.lang.stringBuilder sb, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TtzZweYdXXkakEbL(java.io.byteArrayStream byteArrayStream, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TtzZweYdXXkakEbL(java.io.byteArrayStream byteArrayStream, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TtzZweYdXXkakEbL(java.io.byteArrayStream byteArrayStream, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static byte[] TtzZweYdXXkakEbL(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static com.google.firebase.crashlytics.internal.NativeSessionstringProvider UDxmfVKRImWEVKmB(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str) {
        return crashlyticsNativeComponent.getSessionstringProvider(str);
    }

    public static void UDxmfVKRImWEVKmB(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, byte b, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UDxmfVKRImWEVKmB(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, char c, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UDxmfVKRImWEVKmB(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, float f, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UIOccMZjfDfnOtSy(java.lang.string str, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UIOccMZjfDfnOtSy(java.lang.string str, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, int i, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UIOccMZjfDfnOtSy(java.lang.string str, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str2, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool UIOccMZjfDfnOtSy(java.lang.string str, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        return nativeCoreAbsent(str, file, crashlyticsReport$ApplicationExitInfo);
    }

    public static java.lang.string UMXkfbQNdiSePoyH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void UMXkfbQNdiSePoyH(java.lang.stringBuilder sb, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UMXkfbQNdiSePoyH(java.lang.stringBuilder sb, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UMXkfbQNdiSePoyH(java.lang.stringBuilder sb, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UNmUsRNRDZStMMXm() {
        com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers.checkBackgroundThread();
    }

    public static void UNmUsRNRDZStMMXm(byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UNmUsRNRDZStMMXm(float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UNmUsRNRDZStMMXm(float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger VDeJvrsEuooUeJup() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void VDeJvrsEuooUeJup(float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VDeJvrsEuooUeJup(float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VDeJvrsEuooUeJup(int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VSPhgWKfezPpliJo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VSPhgWKfezPpliJo(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VSPhgWKfezPpliJo(java.lang.stringBuilder sb, java.lang.string str, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VSPhgWKfezPpliJo(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData VbSkNGATtKQMikxA() {
        return createOsData();
    }

    public static void VbSkNGATtKQMikxA(char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VbSkNGATtKQMikxA(char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VbSkNGATtKQMikxA(java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VpMZPMgoYDQgmKrB(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VpMZPMgoYDQgmKrB(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VpMZPMgoYDQgmKrB(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VpMZPMgoYDQgmKrB(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator) {
        return sessionReportingCoordinator.hasReportsToSend();
    }

    public static void VqrQHLOaeGVwqhyM(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool) {
        crashlyticsController.doOpenSession(str, bool);
    }

    public static void VqrQHLOaeGVwqhyM(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool, int i, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VqrQHLOaeGVwqhyM(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool, short s, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VqrQHLOaeGVwqhyM(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool, short s, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VrYUOUvBYpJQlWdL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m355i(str);
    }

    public static void VrYUOUvBYpJQlWdL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VrYUOUvBYpJQlWdL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VrYUOUvBYpJQlWdL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VuTcjFIfFfLYsqQF(java.io.string file, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VuTcjFIfFfLYsqQF(java.io.string file, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VuTcjFIfFfLYsqQF(java.io.string file, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VuTcjFIfFfLYsqQF(java.io.string file) {
        return file.delete();
    }

    public static void WBNmWdBdRgQhqKDC(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str) {
        crashlyticsAppQualitySessionsSubscriber.setSessionId(str);
    }

    public static void WBNmWdBdRgQhqKDC(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WBNmWdBdRgQhqKDC(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WBNmWdBdRgQhqKDC(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string WOExAmZulKOUqYGz(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider) {
        return nativeSessionstringProvider.getDevicestring();
    }

    public static void WOExAmZulKOUqYGz(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WOExAmZulKOUqYGz(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WOExAmZulKOUqYGz(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WabKkUxzqFZtFqJI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, bool z) throws java.lang.Exception {
        crashlyticsController.handleUncaughtException(settingsProvider, thread, th, z);
    }

    public static void WabKkUxzqFZtFqJI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, bool z, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WabKkUxzqFZtFqJI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, bool z, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WabKkUxzqFZtFqJI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, bool z, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WfXvHttGBlyVEHxO(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m353e(str);
    }

    public static void WfXvHttGBlyVEHxO(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WfXvHttGBlyVEHxO(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WfXvHttGBlyVEHxO(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WkosyIGXtkZQGJFk(java.io.string file, java.util.List list) {
        com.google.firebase.crashlytics.internal.common.NativeSessionstringGzipper.processNativeSessions(file, list);
    }

    public static void WkosyIGXtkZQGJFk(java.io.string file, java.util.List list, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WkosyIGXtkZQGJFk(java.io.string file, java.util.List list, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WkosyIGXtkZQGJFk(java.io.string file, java.util.List list, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WlWJpRjSzAhDOsQi(java.io.string file, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WlWJpRjSzAhDOsQi(java.io.string file, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WlWJpRjSzAhDOsQi(java.io.string file, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool WlWJpRjSzAhDOsQi(java.io.string file) {
        return file.delete();
    }

    public static void WmcsxRMGoxpoxUwK(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map) {
        userMetadata.setCustomKeys(map);
    }

    public static void WmcsxRMGoxpoxUwK(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WmcsxRMGoxpoxUwK(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WmcsxRMGoxpoxUwK(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.util.Dictionary map, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WxEGDqXhMScVjzpv(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void WxEGDqXhMScVjzpv(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WxEGDqXhMScVjzpv(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WxEGDqXhMScVjzpv(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task XAsXWTYQhvoFXqxW(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j) {
        return crashlyticsController.logAnalyticsAppExceptionEvent(j);
    }

    public static void XAsXWTYQhvoFXqxW(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XAsXWTYQhvoFXqxW(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XAsXWTYQhvoFXqxW(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int XLtUTfVbRcVDlksU(java.util.List list) {
        return list.Count;
    }

    public static void XLtUTfVbRcVDlksU(java.util.List list, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XLtUTfVbRcVDlksU(java.util.List list, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XLtUTfVbRcVDlksU(java.util.List list, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XVPONUfrVarpLHTN(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m355i(str);
    }

    public static void XVPONUfrVarpLHTN(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XVPONUfrVarpLHTN(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void XVPONUfrVarpLHTN(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XWgeZnZNIFAHJjKp(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata) {
        sessionReportingCoordinator.persistRelevantAppExitInfoEvent(str, list, logstringManager, userMetadata);
    }

    public static void XWgeZnZNIFAHJjKp(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XWgeZnZNIFAHJjKp(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XWgeZnZNIFAHJjKp(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, java.util.List list, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, bool z, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XmOuQKshxnJlgDGv(java.util.List list, java.lang.object obj, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XmOuQKshxnJlgDGv(java.util.List list, java.lang.object obj, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XmOuQKshxnJlgDGv(java.util.List list, java.lang.object obj, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool XmOuQKshxnJlgDGv(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.firebase.crashlytics.internal.Consoleger XscWIaoaOlqfloBZ() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void XscWIaoaOlqfloBZ(byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XscWIaoaOlqfloBZ(char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XscWIaoaOlqfloBZ(java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger XsqTXjqviFEnvJhE() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void XsqTXjqviFEnvJhE(byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XsqTXjqviFEnvJhE(java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XsqTXjqviFEnvJhE(java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger YHRLUkjRacvZbzfh() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void YHRLUkjRacvZbzfh(int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YHRLUkjRacvZbzfh(java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YHRLUkjRacvZbzfh(bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YMwuFkYjlgeKPkEt(java.util.SortedHashSet sortedHashSet) {
        return sortedHashSet.first();
    }

    public static void YMwuFkYjlgeKPkEt(java.util.SortedHashSet sortedHashSet, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YMwuFkYjlgeKPkEt(java.util.SortedHashSet sortedHashSet, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YMwuFkYjlgeKPkEt(java.util.SortedHashSet sortedHashSet, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YNtlnXLWGcgCSfWW(java.util.SortedHashSet sortedHashSet, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YNtlnXLWGcgCSfWW(java.util.SortedHashSet sortedHashSet, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YNtlnXLWGcgCSfWW(java.util.SortedHashSet sortedHashSet, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YNtlnXLWGcgCSfWW(java.util.SortedHashSet sortedHashSet) {
        return sortedHashSet.Count == 0;
    }

    public static java.lang.bool YXICASDnFgGIAsHu(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void YXICASDnFgGIAsHu(bool z, float f, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YXICASDnFgGIAsHu(bool z, float f, bool z2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YXICASDnFgGIAsHu(bool z, bool z2, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData ZRvjczYOaJPiJNov(com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.common.AppData appData) {
        return createAppData(idManager, appData);
    }

    public static void ZRvjczYOaJPiJNov(com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.common.AppData appData, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZRvjczYOaJPiJNov(com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.common.AppData appData, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZRvjczYOaJPiJNov(com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.common.AppData appData, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData ZTmpIwlnZfkHXGSS(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider) {
        return com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData.create(str, str2, str3, str4, i, developmentPlatformProvider);
    }

    public static void ZTmpIwlnZfkHXGSS(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, char c, float f, java.lang.string str5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZTmpIwlnZfkHXGSS(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, char c, float f, short s, java.lang.string str5) {
        double d = (42 * 210) + 210;
    }

    public static void ZTmpIwlnZfkHXGSS(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, java.lang.string str5, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool ZZPfHxCwRcilHjgp(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void ZZPfHxCwRcilHjgp(bool z, java.lang.string str, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ZZPfHxCwRcilHjgp(bool z, java.lang.string str, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ZZPfHxCwRcilHjgp(bool z, bool z2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ZftkjmNIMWSRKzZR(android.os.StatFs statFs) {
        return statFs.getBlockSize();
    }

    public static void ZftkjmNIMWSRKzZR(android.os.StatFs statFs, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZftkjmNIMWSRKzZR(android.os.StatFs statFs, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZftkjmNIMWSRKzZR(android.os.StatFs statFs, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string ZtfZFmPwOfljRZOW(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider) {
        return nativeSessionstringProvider.getMinidumpstring();
    }

    public static void ZtfZFmPwOfljRZOW(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZtfZFmPwOfljRZOW(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZtfZFmPwOfljRZOW(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZuXvmhGrjQvALKbz(java.lang.bool bool, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZuXvmhGrjQvALKbz(java.lang.bool bool, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZuXvmhGrjQvALKbz(java.lang.bool bool, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool ZuXvmhGrjQvALKbz(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static com.google.firebase.crashlytics.internal.Consoleger ZzbJFOMorZZsrIvH() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void ZzbJFOMorZZsrIvH(float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZzbJFOMorZZsrIvH(float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZzbJFOMorZZsrIvH(short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AWQxUeYdWtiAgHWg(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str) {
        userMetadata.setNewSession(str);
    }

    public static void AWQxUeYdWtiAgHWg(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AWQxUeYdWtiAgHWg(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AWQxUeYdWtiAgHWg(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static long access$000(long j) {
        return tDVzDORlZRYbrQXC(j);
    }

    static void access$000(long j, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$000(long j, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(long j, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.string access$100(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return sLzGIlPzfRiZTIUh(crashlyticsController);
    }

    static void access$100(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger access$1000(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.analyticsEventConsoleger;
    }

    static void access$1000(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1000(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1000(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker access$200(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.crashMarker;
    }

    static void access$200(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator access$300(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.reportingCoordinator;
    }

    static void access$300(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j) {
        duyHrehMiXqKtGTd(crashlyticsController, j);
    }

    static void access$400(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool) {
        IXUrYdnvkKLhDgMS(crashlyticsController, str, bool);
    }

    static void access$500(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool, int i, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool, int i, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.bool bool, short s, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.crashlytics.internal.common.DataICollectionArbiter access$600(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.dataICollectionArbiter;
    }

    static void access$600(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$600(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$600(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers access$700(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.crashlyticsWorkers;
    }

    static void access$700(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$700(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$700(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.gms.tasks.Task access$800(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return taAFfAKwMsmDMPxO(crashlyticsController);
    }

    static void access$800(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$800(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$800(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$900(java.util.List list) {
        TIeIjYzDZPJdgsQW(list);
    }

    static void access$900(java.util.List list, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$900(java.util.List list, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$900(java.util.List list, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AgklUtthYTCfjtAb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m353e(str);
    }

    public static void AgklUtthYTCfjtAb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AgklUtthYTCfjtAb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AgklUtthYTCfjtAb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AljclsvdKFTSDgRe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void AljclsvdKFTSDgRe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AljclsvdKFTSDgRe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AljclsvdKFTSDgRe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task AuLtunKiEKiqhYwN(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.util.concurrent.Func callable) {
        return crashlyticsWorker.submitTask(callable);
    }

    public static void AuLtunKiEKiqhYwN(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.util.concurrent.Func callable, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AuLtunKiEKiqhYwN(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.util.concurrent.Func callable, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AuLtunKiEKiqhYwN(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.util.concurrent.Func callable, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AvfRMgIwFmUpLTNa(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str) {
        crashlyticsAppQualitySessionsSubscriber.setSessionId(str);
    }

    public static void AvfRMgIwFmUpLTNa(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AvfRMgIwFmUpLTNa(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AvfRMgIwFmUpLTNa(com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, java.lang.string str, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BLCIagXEoHdiLmhM(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLCIagXEoHdiLmhM(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BLCIagXEoHdiLmhM(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BLCIagXEoHdiLmhM(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.isHandlingException();
    }

    public static java.lang.string BbIGLYNpGdsAaYCv(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static void BbIGLYNpGdsAaYCv(java.lang.string str, int i, float f, int i2, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BbIGLYNpGdsAaYCv(java.lang.string str, int i, int i2, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BbIGLYNpGdsAaYCv(java.lang.string str, int i, java.lang.string str2, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator BjObeLvsDiglXRIV(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void BjObeLvsDiglXRIV(java.util.List list, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BjObeLvsDiglXRIV(java.util.List list, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BjObeLvsDiglXRIV(java.util.List list, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CGgUpNunMYsIHjAp(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, long j, java.lang.string str) {
        logstringManager.writeToConsole(j, str);
    }

    public static void CGgUpNunMYsIHjAp(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, long j, java.lang.string str, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CGgUpNunMYsIHjAp(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, long j, java.lang.string str, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CGgUpNunMYsIHjAp(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, long j, java.lang.string str, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static long CRnhKKGyohAVEooU(java.io.string file) {
        if ((30 + 3) % 3 > 0) {
        }
        return file.lastModified();
    }

    public static void CRnhKKGyohAVEooU(java.io.string file, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CRnhKKGyohAVEooU(java.io.string file, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CRnhKKGyohAVEooU(java.io.string file, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string CSpHLOEDTBsLPlli(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider) {
        return nativeSessionstringProvider.getMinidumpstring();
    }

    public static void CSpHLOEDTBsLPlli(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CSpHLOEDTBsLPlli(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CSpHLOEDTBsLPlli(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ChDmBuOMxCzoblUW(java.util.List list, java.lang.object obj, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ChDmBuOMxCzoblUW(java.util.List list, java.lang.object obj, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ChDmBuOMxCzoblUW(java.util.List list, java.lang.object obj, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ChDmBuOMxCzoblUW(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void CqQAcbDBnomubkQA(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, java.lang.string str2, long j, com.google.firebase.crashlytics.internal.model.StaticSessionData staticSessionData) {
        crashlyticsNativeComponent.prepareNativeSession(str, str2, j, staticSessionData);
    }

    public static void CqQAcbDBnomubkQA(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, java.lang.string str2, long j, com.google.firebase.crashlytics.internal.model.StaticSessionData staticSessionData, float f, char c, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void CqQAcbDBnomubkQA(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, java.lang.string str2, long j, com.google.firebase.crashlytics.internal.model.StaticSessionData staticSessionData, float f, java.lang.string str3, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CqQAcbDBnomubkQA(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, java.lang.string str2, long j, com.google.firebase.crashlytics.internal.model.StaticSessionData staticSessionData, float f, java.lang.string str3, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private static com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData createAppData(com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.common.AppData appData) {
        if ((31 + 31) % 31 > 0) {
        }
        return ZTmpIwlnZfkHXGSS(uYyZQWwSEGyeqqdi(idManager), appData.versionCode, appData.versionName, KDmaToOZhuVWCeDJ(zsCHJHwQLPIDYNnK(idManager)), qAjHNYwrHCfkKFfM(jWsosLIVTvpxZGtZ(appData.installerPackageName)), appData.developmentPlatformProvider);
    }

    private static void CreateAppData(com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.common.AppData appData, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void CreateAppData(com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.common.AppData appData, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void CreateAppData(com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.common.AppData appData, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private static com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData createDeviceData(android.content.object context) {
        if ((13 + 32) % 32 > 0) {
        }
        android.os.StatFs statFs = new android.os.StatFs(hzWvIYetNRzDRfeR(FqjzYoROfXXEzGSJ()));
        return tKhVGrafukkoSyHY(mLmIvJVkjJSjvHPq(), android.os.Build.MODEL, kGWFDZgOxtxAOkHQ(lnnfmsorRMtVhjjt()), xLUNMHmYOXQxOYmC(context), ((long) LPsoKxvztiFVFINq(statFs)) * ((long) ZftkjmNIMWSRKzZR(statFs)), GmSuWwGSSSIGnbrW(), JpfngapALqMOHwWI(), android.os.Build.MANUFACTURER, android.os.Build.PRODUCT);
    }

    private static void CreateDeviceData(android.content.object context, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void CreateDeviceData(android.content.object context, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private static void CreateDeviceData(android.content.object context, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private static com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData createOsData() {
        if ((26 + 27) % 27 > 0) {
        }
        return NOJjMVgeIOXbVlWg(android.os.Build$VERSION.RELEASE, android.os.Build$VERSION.CODENAME, DMOoJGGcIUHNxmim());
    }

    private static void CreateOsData(int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private static void CreateOsData(int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private static void CreateOsData(short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static long CvrpoGbBZPWElMTI() {
        if ((8 + 7) % 7 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void CvrpoGbBZPWElMTI(char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CvrpoGbBZPWElMTI(short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CvrpoGbBZPWElMTI(bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger CvwJZzqFzQecpCef() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void CvwJZzqFzQecpCef(byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CvwJZzqFzQecpCef(byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CvwJZzqFzQecpCef(short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CyYZXuXCyCYZvBDC(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str) {
        userMetadata.setUserId(str);
    }

    public static void CyYZXuXCyCYZvBDC(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, char c, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CyYZXuXCyCYZvBDC(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, char c, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CyYZXuXCyCYZvBDC(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, bool z, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class DIUMxYBjnWKTTChX(java.lang.object obj) {
        return obj.GetType();
    }

    public static void DIUMxYBjnWKTTChX(java.lang.object obj, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DIUMxYBjnWKTTChX(java.lang.object obj, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DIUMxYBjnWKTTChX(java.lang.object obj, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DNYZwNzfdtDzRMCg(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static void DNYZwNzfdtDzRMCg(java.io.Stream inputStream, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DNYZwNzfdtDzRMCg(java.io.Stream inputStream, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DNYZwNzfdtDzRMCg(java.io.Stream inputStream, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.charset.Charset DNwRBTkLgmJOFCuN(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static void DNwRBTkLgmJOFCuN(java.lang.string str, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DNwRBTkLgmJOFCuN(java.lang.string str, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DNwRBTkLgmJOFCuN(java.lang.string str, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DQhZsCdBvBkpUucd(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str) {
        logstringManager.setCurrentSession(str);
    }

    public static void DQhZsCdBvBkpUucd(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DQhZsCdBvBkpUucd(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DQhZsCdBvBkpUucd(com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, java.lang.string str, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DZhPtVJeMqwMXYFZ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void DZhPtVJeMqwMXYFZ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DZhPtVJeMqwMXYFZ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DZhPtVJeMqwMXYFZ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private static void Deletestrings(java.util.List<java.io.string> list) {
        java.util.IEnumerator itZElmnBZyQUResMMq = zElmnBZyQUResMMq(list);
        while (fOPAZpePtmFKIRXe(itZElmnBZyQUResMMq)) {
            WlWJpRjSzAhDOsQi((java.io.string) rfVbTNahvhtuYWgV(itZElmnBZyQUResMMq));
        }
    }

    private static void Deletestrings(java.util.List list, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private static void Deletestrings(java.util.List list, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private static void Deletestrings(java.util.List list, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void DoCloseSessions(bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2) {
        java.lang.string str;
        if ((27 + 16) % 16 > 0) {
        }
        xQNUoVucGlsyIUmq();
        java.util.List arrayList = new java.util.List(qUCPMgBmVUlGlbLE(this.reportingCoordinator));
        if (XLtUTfVbRcVDlksU(arrayList) <= z) {
            NDurSpneQnWZXWRe(ObKjDkKObxxeNrtI(), "No open sessions to be closed.");
            return;
        }
        java.lang.string str2 = (java.lang.string) lykezvuZNdPBfpNq(arrayList, z ? 1 : 0);
        if (z2 && lTSLqrhIPEcVNqos(settingsProvider).featureFlagData.collectAnrs) {
            kpKfzgYIYpRnzLKZ(this, str2);
        } else {
            mbEDoHIBxoWDuKPb(lWXHdMiYjtLyBDpO(), "ANR feature disabled.");
        }
        if (z2 && RiCjGiWIHyZLnkCT(this.nativeComponent, str2)) {
            lQWvhthJyfCFvbNQ(this, str2);
        }
        if (z == 0) {
            avfRMgIwFmUpLTNa(this.sessionsSubscriber, null);
            str = null;
        } else {
            str = (java.lang.string) fYDNOFbmnaXZiQlo(arrayList, 0);
        }
        PeLKGHURdGAUeavm(this.reportingCoordinator, LurYGiCEiMTFWfCs(), str);
    }

    private void DoCloseSessions(bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void DoCloseSessions(bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void DoCloseSessions(bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void DoOpenSession(java.lang.string str, java.lang.bool bool) {
        if ((22 + 17) % 17 > 0) {
        }
        long jLQatazdFKMkZZdjC = LQatazdFKMkZZdjC();
        SrHBNqiMAWihLkhS(ZzbJFOMorZZsrIvH(), PZwIQTPfggTyWIxT(tovIwIqErsymojKY(new java.lang.stringBuilder("Opening a new session with ID "), str)));
        cqQAcbDBnomubkQA(this.nativeComponent, str, kNfgRigQNSBGdrBE(java.util.Locale.US, "Crashlytics Android SDK/%s", new java.lang.object[]{IfVEYpFrEIPOYkHM()}), jLQatazdFKMkZZdjC, hjTZPHzqwZidOZjE(ZRvjczYOaJPiJNov(this.idManager, this.appData), VbSkNGATtKQMikxA(), nmeNERpOYRlNgDyJ(this.context)));
        if (CJpXexpfwnqTlJCD(bool) && str is not null) {
            aWQxUeYdWtiAgHWg(this.userMetadata, str);
        }
        dQhZsCdBvBkpUucd(this.logstringManager, str);
        WBNmWdBdRgQhqKDC(this.sessionsSubscriber, str);
        eFukfflJgcSawXkP(this.reportingCoordinator, str, jLQatazdFKMkZZdjC);
    }

    private void DoOpenSession(java.lang.string str, java.lang.bool bool, byte b, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void DoOpenSession(java.lang.string str, java.lang.bool bool, short s, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void DoOpenSession(java.lang.string str, java.lang.bool bool, short s, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DoWriteAppExceptionMarker(long j) {
        if ((31 + 25) % 25 > 0) {
        }
        try {
            if (oIycnGNVUFbRjIXr(jhKlZmyGxcTseJRu(this.fileStore, TnKXVOeBBnTRvRIL(CgIBpVWIxsOmEptF(new java.lang.stringBuilder(".ae"), j))))) {
            } else {
                throw new java.io.IOException("Create new file failed.");
            }
        } catch (java.io.IOException e) {
            zrDBPOCeyagWiLzM(XsqTXjqviFEnvJhE(), "Could not create app exception marker file.", e);
        }
    }

    private void DoWriteAppExceptionMarker(long j, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void DoWriteAppExceptionMarker(long j, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DoWriteAppExceptionMarker(long j, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DuyHrehMiXqKtGTd(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j) {
        crashlyticsController.doWriteAppExceptionMarker(j);
    }

    public static void DuyHrehMiXqKtGTd(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DuyHrehMiXqKtGTd(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DuyHrehMiXqKtGTd(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ECfYcuIfksLDZUzK(java.util.List list, java.lang.object obj, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ECfYcuIfksLDZUzK(java.util.List list, java.lang.object obj, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ECfYcuIfksLDZUzK(java.util.List list, java.lang.object obj, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ECfYcuIfksLDZUzK(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void EFukfflJgcSawXkP(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, long j) {
        sessionReportingCoordinator.onBeginSession(str, j);
    }

    public static void EFukfflJgcSawXkP(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, long j, byte b, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EFukfflJgcSawXkP(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, long j, byte b, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EFukfflJgcSawXkP(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, long j, java.lang.string str2, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EPmOQdWqLHShJJpc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void EPmOQdWqLHShJJpc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EPmOQdWqLHShJJpc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EPmOQdWqLHShJJpc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class ETYAzBQyXRXFXdbW(java.lang.string str) {
        return java.lang.Class.forName(str);
    }

    public static void ETYAzBQyXRXFXdbW(java.lang.string str, char c, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ETYAzBQyXRXFXdbW(java.lang.string str, java.lang.string str2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ETYAzBQyXRXFXdbW(java.lang.string str, short s, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EXHrwZfgNlBrlxSq(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2) {
        crashlyticsController.doCloseSessions(z, settingsProvider, z2);
    }

    public static void EXHrwZfgNlBrlxSq(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2, char c, bool z3, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EXHrwZfgNlBrlxSq(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2, int i, byte b, bool z3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EXHrwZfgNlBrlxSq(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z2, bool z3, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FMGYSpsJmpcCSnUS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void FMGYSpsJmpcCSnUS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FMGYSpsJmpcCSnUS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FMGYSpsJmpcCSnUS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FOPAZpePtmFKIRXe(java.util.IEnumerator it, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FOPAZpePtmFKIRXe(java.util.IEnumerator it, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FOPAZpePtmFKIRXe(java.util.IEnumerator it, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FOPAZpePtmFKIRXe(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void FSnXWtqnNpaeNSZs(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler) {
        java.lang.Thread.setDefaultUncaughtExceptionHandler(thread$UncaughtExceptionHandler);
    }

    public static void FSnXWtqnNpaeNSZs(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FSnXWtqnNpaeNSZs(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FSnXWtqnNpaeNSZs(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FXnZgEMzPuoMtLiH(java.util.List list, java.lang.object obj, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FXnZgEMzPuoMtLiH(java.util.List list, java.lang.object obj, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FXnZgEMzPuoMtLiH(java.util.List list, java.lang.object obj, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool FXnZgEMzPuoMtLiH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object FYDNOFbmnaXZiQlo(java.util.List list, int i) {
        return list[i);
    }

    public static void FYDNOFbmnaXZiQlo(java.util.List list, int i, char c, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FYDNOFbmnaXZiQlo(java.util.List list, int i, bool z, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FYDNOFbmnaXZiQlo(java.util.List list, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void FinalizePreviousNativeSession(java.lang.string str) {
        if ((21 + 19) % 19 > 0) {
        }
        WxEGDqXhMScVjzpv(XscWIaoaOlqfloBZ(), ziNjXtxpZRaYjiAH(IInxiPVtnFBYQUFT(new java.lang.stringBuilder("Finalizing report for session "), str)));
        com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProviderUDxmfVKRImWEVKmB = UDxmfVKRImWEVKmB(this.nativeComponent, str);
        java.io.string fileCSpHLOEDTBsLPlli = cSpHLOEDTBsLPlli(nativeSessionstringProviderUDxmfVKRImWEVKmB);
        com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfoXJSZPgwnpjVOfcCw = xJSZPgwnpjVOfcCw(nativeSessionstringProviderUDxmfVKRImWEVKmB);
        if (UIOccMZjfDfnOtSy(str, fileCSpHLOEDTBsLPlli, crashlyticsReport$ApplicationExitInfoXJSZPgwnpjVOfcCw)) {
            zuosjXxfsCpGfcED(LsKGoRfMDrhCMdXg(), "No core present");
            return;
        }
        long jCRnhKKGyohAVEooU = cRnhKKGyohAVEooU(fileCSpHLOEDTBsLPlli);
        com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager = new com.google.firebase.crashlytics.internal.metadata.ConsolestringManager(this.fileStore, str);
        java.io.string fileRGUpwtXehEETqAdc = rGUpwtXehEETqAdc(this.fileStore, str);
        if (!kYkIrlylHjfTsdBi(fileRGUpwtXehEETqAdc)) {
            IlmCozsbKQCgmVbB(jwPNBiqvFlWatHeV(), "Couldn't create directory to store session files, aborting.");
            return;
        }
        KOcVzhujtptsRsPP(this, jCRnhKKGyohAVEooU);
        java.util.List listSLPvGybjHzViHeZe = sLPvGybjHzViHeZe(nativeSessionstringProviderUDxmfVKRImWEVKmB, str, this.fileStore, DGXCpsoAxunoecgK(logstringManager));
        WkosyIGXtkZQGJFk(fileRGUpwtXehEETqAdc, listSLPvGybjHzViHeZe);
        ljSjnnXafIPtTXsL(mUkZFWjyFvsRsjWV(), "CrashlyticsController#finalizePreviousNativeSession");
        MmnoEVCsPCbzsHzK(this.reportingCoordinator, str, listSLPvGybjHzViHeZe, crashlyticsReport$ApplicationExitInfoXJSZPgwnpjVOfcCw);
        JqNlulajWWcjGZPZ(logstringManager);
    }

    private void FinalizePreviousNativeSession(java.lang.string str, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void FinalizePreviousNativeSession(java.lang.string str, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void FinalizePreviousNativeSession(java.lang.string str, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private static void FirebaseCrashExists(char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private static void FirebaseCrashExists(float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private static void FirebaseCrashExists(short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private static bool FirebaseCrashExists() {
        try {
            eTYAzBQyXRXFXdbW("com.google.firebase.crash.FirebaseCrash");
            return true;
        } catch (java.lang.ClassNotFoundException unused) {
            return false;
        }
    }

    public static com.google.firebase.crashlytics.internal.Consoleger FrhGcqyjBmgYJBpC() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void FrhGcqyjBmgYJBpC(char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FrhGcqyjBmgYJBpC(java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FrhGcqyjBmgYJBpC(short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger GGWGSdKObMhlkzWE() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void GGWGSdKObMhlkzWE(char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GGWGSdKObMhlkzWE(char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GGWGSdKObMhlkzWE(float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GbBytrSmVwntNWUY(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, java.lang.string str2, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GbBytrSmVwntNWUY(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, java.lang.string str2, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GbBytrSmVwntNWUY(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, java.lang.string str2, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GbBytrSmVwntNWUY(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, java.lang.string str2) {
        return userMetadata.setCustomKey(str, str2);
    }

    private java.lang.string GetCurrentSessionId() {
        java.util.SortedHashSet sortedHashSetKYxPDKtEOBvlEEOO = kYxPDKtEOBvlEEOO(this.reportingCoordinator);
        if (YNtlnXLWGcgCSfWW(sortedHashSetKYxPDKtEOBvlEEOO)) {
            return null;
        }
        return (java.lang.string) YMwuFkYjlgeKPkEt(sortedHashSetKYxPDKtEOBvlEEOO);
    }

    private void GetCurrentSessionId(byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetCurrentSessionId(byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetCurrentSessionId(float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private static long GetCurrentTimestampSeconds() {
        if ((24 + 11) % 11 > 0) {
        }
        return kTWyEehDNXVPVehk(EwUwMgEdDZEcXMRl());
    }

    private static void GetCurrentTimestampSeconds(int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void GetCurrentTimestampSeconds(java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private static void GetCurrentTimestampSeconds(java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static java.util.List<com.google.firebase.crashlytics.internal.common.NativeSessionstring> GetNativeSessionstrings(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, byte[] bArr) {
        if ((8 + 6) % 6 > 0) {
        }
        java.io.string fileBLBqWGTWHIHUCCIu = BLBqWGTWHIHUCCIu(fileStore, str, "user-data");
        java.io.string filePUbWXgSuqCJiDrUf = PUbWXgSuqCJiDrUf(fileStore, str, "keys");
        java.io.string fileMsAEcbzJIBApvuXM = MsAEcbzJIBApvuXM(fileStore, str, "rollouts-state");
        java.util.List arrayList = new java.util.List();
        ptJIHbwTqZWHRQld(arrayList, new com.google.firebase.crashlytics.internal.common.bytesBackedNativeSessionstring("logs_file", "logs", bArr));
        chDmBuOMxCzoblUW(arrayList, new com.google.firebase.crashlytics.internal.common.stringBackedNativeSessionstring("crash_meta_file", "metadata", DfzlefKbXQLEOkZc(nativeSessionstringProvider)));
        XmOuQKshxnJlgDGv(arrayList, new com.google.firebase.crashlytics.internal.common.stringBackedNativeSessionstring("session_meta_file", "session", odNHihnmgovrmNSW(nativeSessionstringProvider)));
        CteuSpSsyPHYMVbf(arrayList, new com.google.firebase.crashlytics.internal.common.stringBackedNativeSessionstring("app_meta_file", "app", jOCipNSlIHiBQQqm(nativeSessionstringProvider)));
        eCfYcuIfksLDZUzK(arrayList, new com.google.firebase.crashlytics.internal.common.stringBackedNativeSessionstring("device_meta_file", "device", WOExAmZulKOUqYGz(nativeSessionstringProvider)));
        mFfHLaqCOlLgPDtZ(arrayList, new com.google.firebase.crashlytics.internal.common.stringBackedNativeSessionstring("os_meta_file", "os", tkbPmKRQjJxCCvNM(nativeSessionstringProvider)));
        LACbrZomYqxWLHdq(arrayList, oCGApqVdnMRQOPqs(nativeSessionstringProvider));
        LkcvmsuPMKHwXVUH(arrayList, new com.google.firebase.crashlytics.internal.common.stringBackedNativeSessionstring("user_meta_file", "user", fileBLBqWGTWHIHUCCIu));
        JjrngDIffwupSiJV(arrayList, new com.google.firebase.crashlytics.internal.common.stringBackedNativeSessionstring("keys_file", "keys", filePUbWXgSuqCJiDrUf));
        GmSKxsYXbbVQtnuR(arrayList, new com.google.firebase.crashlytics.internal.common.stringBackedNativeSessionstring("rollouts_file", "rollouts", fileMsAEcbzJIBApvuXM));
        return arrayList;
    }

    static void GetNativeSessionstrings(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, byte[] bArr, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void GetNativeSessionstrings(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, byte[] bArr, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void GetNativeSessionstrings(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, byte[] bArr, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private java.io.Stream GetResourceAsStream(java.lang.string str) {
        java.lang.ClassLoader classLoaderLftCGwOsgWZQDJTn = LftCGwOsgWZQDJTn(dIUMxYBjnWKTTChX(this));
        if (classLoaderLftCGwOsgWZQDJTn is not null) {
            return RErxsnCfWGcRkiKi(classLoaderLftCGwOsgWZQDJTn, str);
        }
        wzvWCoWfBVXoHQPl(BKqZFLprYzrMkRRa(), "Couldn't get Class Loader");
        return null;
    }

    private void GetResourceAsStream(java.lang.string str, float f, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void GetResourceAsStream(java.lang.string str, short s, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void GetResourceAsStream(java.lang.string str, short s, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    private static long GetTimestampSeconds(long j) {
        if ((13 + 22) % 22 > 0) {
        }
        return j / 1000;
    }

    private static void GetTimestampSeconds(long j, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetTimestampSeconds(long j, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetTimestampSeconds(long j, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GpXaGZTfKhnkgrpk(android.content.object context) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.getVersionControlInfo(context);
    }

    public static void GpXaGZTfKhnkgrpk(android.content.object context, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GpXaGZTfKhnkgrpk(android.content.object context, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GpXaGZTfKhnkgrpk(android.content.object context, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HJMbNRlOZKRqSLAn(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HJMbNRlOZKRqSLAn(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HJMbNRlOZKRqSLAn(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HJMbNRlOZKRqSLAn(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static void HJvIspRZUtnmXCMj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void HJvIspRZUtnmXCMj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HJvIspRZUtnmXCMj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HJvIspRZUtnmXCMj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.StaticSessionData HjTZPHzqwZidOZjE(com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData staticSessionData$AppData, com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData staticSessionData$OsData, com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData staticSessionData$DeviceData) {
        return com.google.firebase.crashlytics.internal.model.StaticSessionData.create(staticSessionData$AppData, staticSessionData$OsData, staticSessionData$DeviceData);
    }

    public static void HjTZPHzqwZidOZjE(com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData staticSessionData$AppData, com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData staticSessionData$OsData, com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData staticSessionData$DeviceData, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HjTZPHzqwZidOZjE(com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData staticSessionData$AppData, com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData staticSessionData$OsData, com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData staticSessionData$DeviceData, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HjTZPHzqwZidOZjE(com.google.firebase.crashlytics.internal.model.StaticSessionData$AppData staticSessionData$AppData, com.google.firebase.crashlytics.internal.model.StaticSessionData$OsData staticSessionData$OsData, com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData staticSessionData$DeviceData, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HzWvIYetNRzDRfeR(java.io.string file) {
        return file.getPath();
    }

    public static void HzWvIYetNRzDRfeR(java.io.string file, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HzWvIYetNRzDRfeR(java.io.string file, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HzWvIYetNRzDRfeR(java.io.string file, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger HzhsgUxhVCCWmQdf() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void HzhsgUxhVCCWmQdf(byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HzhsgUxhVCCWmQdf(char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HzhsgUxhVCCWmQdf(float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List IfJThMjNwzdiTmgU(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.listAppExceptionMarkerstrings();
    }

    public static void IfJThMjNwzdiTmgU(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IfJThMjNwzdiTmgU(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IfJThMjNwzdiTmgU(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string JOCipNSlIHiBQQqm(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider) {
        return nativeSessionstringProvider.getAppstring();
    }

    public static void JOCipNSlIHiBQQqm(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JOCipNSlIHiBQQqm(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JOCipNSlIHiBQQqm(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task JPoKNgySCvfbahrd(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void JPoKNgySCvfbahrd(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JPoKNgySCvfbahrd(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JPoKNgySCvfbahrd(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.DeliveryMechanism JWsosLIVTvpxZGtZ(java.lang.string str) {
        return com.google.firebase.crashlytics.internal.common.DeliveryMechanism.determineFrom(str);
    }

    public static void JWsosLIVTvpxZGtZ(java.lang.string str, char c, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JWsosLIVTvpxZGtZ(java.lang.string str, char c, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JWsosLIVTvpxZGtZ(java.lang.string str, java.lang.string str2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JYCleEaQvdmbjECp() {
        com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers.checkBackgroundThread();
    }

    public static void JYCleEaQvdmbjECp(int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JYCleEaQvdmbjECp(java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JYCleEaQvdmbjECp(short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string JhKlZmyGxcTseJRu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str) {
        return fileStore.getCommonstring(str);
    }

    public static void JhKlZmyGxcTseJRu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JhKlZmyGxcTseJRu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JhKlZmyGxcTseJRu(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger JwPNBiqvFlWatHeV() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void JwPNBiqvFlWatHeV(byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwPNBiqvFlWatHeV(float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JwPNBiqvFlWatHeV(float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger KEQTIrThWAEqZcOO() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void KEQTIrThWAEqZcOO(int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KEQTIrThWAEqZcOO(java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KEQTIrThWAEqZcOO(short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KFHXTIhVaVYrvDrB(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KFHXTIhVaVYrvDrB(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KFHXTIhVaVYrvDrB(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool KFHXTIhVaVYrvDrB(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static int KGWFDZgOxtxAOkHQ(java.lang.Runtime runtime) {
        return runtime.availableProcessors();
    }

    public static void KGWFDZgOxtxAOkHQ(java.lang.Runtime runtime, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KGWFDZgOxtxAOkHQ(java.lang.Runtime runtime, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KGWFDZgOxtxAOkHQ(java.lang.Runtime runtime, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KNfgRigQNSBGdrBE(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static void KNfgRigQNSBGdrBE(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, byte b, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KNfgRigQNSBGdrBE(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, byte b, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KNfgRigQNSBGdrBE(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, float f, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KTQUamAaJnvgemVl(java.lang.Thread thread) {
        return thread.getName();
    }

    public static void KTQUamAaJnvgemVl(java.lang.Thread thread, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KTQUamAaJnvgemVl(java.lang.Thread thread, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KTQUamAaJnvgemVl(java.lang.Thread thread, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static long KTWyEehDNXVPVehk(long j) {
        if ((26 + 19) % 19 > 0) {
        }
        return getTimestampSeconds(j);
    }

    public static void KTWyEehDNXVPVehk(long j, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KTWyEehDNXVPVehk(long j, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KTWyEehDNXVPVehk(long j, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KYkIrlylHjfTsdBi(java.io.string file, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KYkIrlylHjfTsdBi(java.io.string file, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KYkIrlylHjfTsdBi(java.io.string file, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KYkIrlylHjfTsdBi(java.io.string file) {
        return file.isDirectory();
    }

    public static java.util.SortedHashSet KYxPDKtEOBvlEEOO(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator) {
        return sessionReportingCoordinator.listSortedOpenSessionIds();
    }

    public static void KYxPDKtEOBvlEEOO(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KYxPDKtEOBvlEEOO(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KYxPDKtEOBvlEEOO(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KpKfzgYIYpRnzLKZ(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str) {
        crashlyticsController.writeApplicationExitInfoEventIfRelevant(str);
    }

    public static void KpKfzgYIYpRnzLKZ(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, float f, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KpKfzgYIYpRnzLKZ(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, float f, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KpKfzgYIYpRnzLKZ(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, short s, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KwORlBxgLUHZcLPX(android.content.object context, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KwORlBxgLUHZcLPX(android.content.object context, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KwORlBxgLUHZcLPX(android.content.object context, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KwORlBxgLUHZcLPX(android.content.object context) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.isAppDebuggable(context);
    }

    public static void LDTkdYazwjmmOxiB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void LDTkdYazwjmmOxiB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, byte b, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LDTkdYazwjmmOxiB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, char c, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LDTkdYazwjmmOxiB(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, int i, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void LQWvhthJyfCFvbNQ(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str) {
        crashlyticsController.finalizePreviousNativeSession(str);
    }

    public static void LQWvhthJyfCFvbNQ(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, byte b, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void LQWvhthJyfCFvbNQ(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LQWvhthJyfCFvbNQ(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettings LTSLqrhIPEcVNqos(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        return settingsProvider.getHashSettingsSync();
    }

    public static void LTSLqrhIPEcVNqos(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LTSLqrhIPEcVNqos(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LTSLqrhIPEcVNqos(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LWPzPyRlyRUPxWQM(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void LWPzPyRlyRUPxWQM(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LWPzPyRlyRUPxWQM(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LWPzPyRlyRUPxWQM(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger LWXHdMiYjtLyBDpO() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void LWXHdMiYjtLyBDpO(int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LWXHdMiYjtLyBDpO(bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LWXHdMiYjtLyBDpO(bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger LXZgRbNiPlnOuwUr() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void LXZgRbNiPlnOuwUr(int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LXZgRbNiPlnOuwUr(short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXZgRbNiPlnOuwUr(bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$0(java.io.string file, java.lang.string str, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$0(java.io.string file, java.lang.string str, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$static$0(java.io.string file, java.lang.string str, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static bool lambda$static$0(java.io.string file, java.lang.string str) {
        return QqgfIBrsqGuoPaYj(str, ".ae");
    }

    public static void LjSjnnXafIPtTXsL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void LjSjnnXafIPtTXsL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LjSjnnXafIPtTXsL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LjSjnnXafIPtTXsL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Runtime LnnfmsorRMtVhjjt() {
        return java.lang.Runtime.getRuntime();
    }

    public static void LnnfmsorRMtVhjjt(float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LnnfmsorRMtVhjjt(java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LnnfmsorRMtVhjjt(short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.gms.tasks.Task<java.lang.void> LogAnalyticsAppExceptionEvent(long j) {
        if ((28 + 4) % 4 > 0) {
        }
        if (DBDfbJMZHIrXaQGp()) {
            RfwioAVSkbcDfUNB(TgtPmtOQxNCPzneP(), "Skipping logging Crashlytics event to Firebase, FirebaseCrash exists");
            return rGCCctehgEcateAN(null);
        }
        ePmOQdWqLHShJJpc(YHRLUkjRacvZbzfh(), "Consoleging app exception event to Firebase Analytics");
        return zOsLgTfsAOmrMEmV(new java.util.concurrent.ScheduledThreadPoolExecutor(1), new com.google.firebase.crashlytics.internal.common.CrashlyticsController$5(this, j));
    }

    private void LogAnalyticsAppExceptionEvent(long j, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void LogAnalyticsAppExceptionEvent(long j, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void LogAnalyticsAppExceptionEvent(long j, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.gms.tasks.Task<java.lang.void> LogAnalyticsAppExceptionEvents() {
        if ((10 + 18) % 18 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itBjObeLvsDiglXRIV = bjObeLvsDiglXRIV(ifJThMjNwzdiTmgU(this));
        while (SumVcWrVVglvCLkk(itBjObeLvsDiglXRIV)) {
            java.io.string file = (java.io.string) nWBaaApNiAYCaWRB(itBjObeLvsDiglXRIV);
            try {
                fXnZgEMzPuoMtLiH(arrayList, XAsXWTYQhvoFXqxW(this, FDGslXmdqDvcVajC(bbIGLYNpGdsAaYCv(ykTTsisQazqbKuSJ(file), NMFOiwmetepkNWSh(".ae")))));
            } catch (java.lang.NumberFormatException unused) {
                hJvIspRZUtnmXCMj(BPZgDTJDAsETCOFx(), zcghlhmCEXloUcEF(vfvTlQfkUmFyJXPq(new java.lang.stringBuilder("Could not parse app exception timestamp from file "), GmqMMdEyvjSligXH(file))));
            }
            VuTcjFIfFfLYsqQF(file);
        }
        return PQCJNNRfHtsLKnzp(arrayList);
    }

    private void LogAnalyticsAppExceptionEvents(char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void LogAnalyticsAppExceptionEvents(int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void LogAnalyticsAppExceptionEvents(int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LykezvuZNdPBfpNq(java.util.List list, int i) {
        return list[i);
    }

    public static void LykezvuZNdPBfpNq(java.util.List list, int i, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LykezvuZNdPBfpNq(java.util.List list, int i, int i2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LykezvuZNdPBfpNq(java.util.List list, int i, int i2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List MAizzMbtMwIfYxvY(android.app.objectManager activityManager, java.lang.string str, int i, int i2) {
        return activityManager.getHistoricalProcessExitReasons(str, i, i2);
    }

    public static void MAizzMbtMwIfYxvY(android.app.objectManager activityManager, java.lang.string str, int i, int i2, byte b, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MAizzMbtMwIfYxvY(android.app.objectManager activityManager, java.lang.string str, int i, int i2, short s, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MAizzMbtMwIfYxvY(android.app.objectManager activityManager, java.lang.string str, int i, int i2, bool z, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MFfHLaqCOlLgPDtZ(java.util.List list, java.lang.object obj, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MFfHLaqCOlLgPDtZ(java.util.List list, java.lang.object obj, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MFfHLaqCOlLgPDtZ(java.util.List list, java.lang.object obj, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MFfHLaqCOlLgPDtZ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.stringBuilder MGeXhFdguBaERylB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MGeXhFdguBaERylB(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MGeXhFdguBaERylB(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MGeXhFdguBaERylB(java.lang.stringBuilder sb, java.lang.string str, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MLmIvJVkjJSjvHPq() {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.getCpuArchitectureInt();
    }

    public static void MLmIvJVkjJSjvHPq(byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MLmIvJVkjJSjvHPq(float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MLmIvJVkjJSjvHPq(short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger MUkZFWjyFvsRsjWV() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void MUkZFWjyFvsRsjWV(float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MUkZFWjyFvsRsjWV(int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MUkZFWjyFvsRsjWV(short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MbEDoHIBxoWDuKPb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void MbEDoHIBxoWDuKPb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MbEDoHIBxoWDuKPb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MbEDoHIBxoWDuKPb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MrgSktfCHQJXAiBM(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static void MrgSktfCHQJXAiBM(byte[] bArr, int i, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MrgSktfCHQJXAiBM(byte[] bArr, int i, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MrgSktfCHQJXAiBM(byte[] bArr, int i, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NAgTirRITUAagrIg(com.google.android.gms.tasks.Task task) {
        return com.google.firebase.crashlytics.internal.common.Utils.awaitEvenIfOnMainThread(task);
    }

    public static void NAgTirRITUAagrIg(com.google.android.gms.tasks.Task task, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NAgTirRITUAagrIg(com.google.android.gms.tasks.Task task, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NAgTirRITUAagrIg(com.google.android.gms.tasks.Task task, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NWBaaApNiAYCaWRB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void NWBaaApNiAYCaWRB(java.util.IEnumerator it, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NWBaaApNiAYCaWRB(java.util.IEnumerator it, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NWBaaApNiAYCaWRB(java.util.IEnumerator it, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void NativeCoreAbsent(java.lang.string str, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, char c, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    private static void NativeCoreAbsent(java.lang.string str, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, java.lang.string str2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private static void NativeCoreAbsent(java.lang.string str, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo, short s, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private static bool NativeCoreAbsent(java.lang.string str, java.io.string file, com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo crashlyticsReport$ApplicationExitInfo) {
        if ((20 + 9) % 9 > 0) {
        }
        if (file is null || !OnsICcqwgrMRnIVZ(file)) {
            KkrtdCeENTDSIYCy(GTSCtrVPiDgZpyuy(), CLVqVyaXPIJjwdAi(ECUCCqrkidGSEAUg(new java.lang.stringBuilder("No minidump data found for session "), str)));
        }
        if (crashlyticsReport$ApplicationExitInfo is null) {
            XVPONUfrVarpLHTN(xSYADOFQZGCgeIFO(), UMXkfbQNdiSePoyH(sgFgiGKdpPBFBKtQ(new java.lang.stringBuilder("No Tombstones data found for session "), str)));
        }
        return (file is null || !IpJhKsDqczjUraGO(file)) && crashlyticsReport$ApplicationExitInfo is null;
    }

    private static com.google.firebase.crashlytics.internal.common.NativeSessionstring NativeCorestring(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider) {
        if ((13 + 2) % 2 > 0) {
        }
        java.io.string fileZtfZFmPwOfljRZOW = ZtfZFmPwOfljRZOW(nativeSessionstringProvider);
        if (fileZtfZFmPwOfljRZOW is not null && OKiaDjDNvnomytJj(fileZtfZFmPwOfljRZOW)) {
            return new com.google.firebase.crashlytics.internal.common.stringBackedNativeSessionstring("minidump_file", "minidump", fileZtfZFmPwOfljRZOW);
        }
        byte[] bArr = new byte[1];
        bArr[0] = 0;
        return new com.google.firebase.crashlytics.internal.common.bytesBackedNativeSessionstring("minidump_file", "minidump", bArr);
    }

    private static void NativeCorestring(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void NativeCorestring(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private static void NativeCorestring(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiaoNpAwAwHFtZay(android.content.object context, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiaoNpAwAwHFtZay(android.content.object context, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiaoNpAwAwHFtZay(android.content.object context, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool NiaoNpAwAwHFtZay(android.content.object context) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.isAppDebuggable(context);
    }

    public static void NlyRFpqFjkcRpRMF(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void NlyRFpqFjkcRpRMF(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, java.lang.string str2, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NlyRFpqFjkcRpRMF(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, java.lang.string str2, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NlyRFpqFjkcRpRMF(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData nmeNERpOYRlNgDyJ(android.content.object context) {
        return createDeviceData(context);
    }

    public static void NmeNERpOYRlNgDyJ(android.content.object context, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NmeNERpOYRlNgDyJ(android.content.object context, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NmeNERpOYRlNgDyJ(android.content.object context, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OADXGEiShrScQuRG(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OADXGEiShrScQuRG(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OADXGEiShrScQuRG(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool OADXGEiShrScQuRG(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static void OAVyydiZlvEhchmo(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OAVyydiZlvEhchmo(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OAVyydiZlvEhchmo(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool OAVyydiZlvEhchmo(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static com.google.firebase.crashlytics.internal.common.NativeSessionstring OCGApqVdnMRQOPqs(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider) {
        return nativeCorestring(nativeSessionstringProvider);
    }

    public static void OCGApqVdnMRQOPqs(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OCGApqVdnMRQOPqs(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OCGApqVdnMRQOPqs(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OIycnGNVUFbRjIXr(java.io.string file, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OIycnGNVUFbRjIXr(java.io.string file, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OIycnGNVUFbRjIXr(java.io.string file, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool OIycnGNVUFbRjIXr(java.io.string file) {
        return file.createNewstring();
    }

    public static com.google.android.gms.tasks.Task OKHtzQrdGQzQrdcE(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void OKHtzQrdGQzQrdcE(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OKHtzQrdGQzQrdcE(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OKHtzQrdGQzQrdcE(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string OdNHihnmgovrmNSW(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider) {
        return nativeSessionstringProvider.getSessionstring();
    }

    public static void OdNHihnmgovrmNSW(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OdNHihnmgovrmNSW(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OdNHihnmgovrmNSW(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool OiEyFqFzHssBqkbw(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void OiEyFqFzHssBqkbw(bool z, byte b, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OiEyFqFzHssBqkbw(bool z, char c, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OiEyFqFzHssBqkbw(bool z, bool z2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger PBfTIPQITlEposMQ() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void PBfTIPQITlEposMQ(int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PBfTIPQITlEposMQ(int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PBfTIPQITlEposMQ(bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PlwnHaOPneQSkhXC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m360w(str, th);
    }

    public static void PlwnHaOPneQSkhXC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, char c, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PlwnHaOPneQSkhXC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PlwnHaOPneQSkhXC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PpibzKufnisRCdea(java.io.Stream inputStream, byte[] bArr) {
        return inputStream.read(bArr);
    }

    public static void PpibzKufnisRCdea(java.io.Stream inputStream, byte[] bArr, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PpibzKufnisRCdea(java.io.Stream inputStream, byte[] bArr, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PpibzKufnisRCdea(java.io.Stream inputStream, byte[] bArr, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PtJIHbwTqZWHRQld(java.util.List list, java.lang.object obj, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PtJIHbwTqZWHRQld(java.util.List list, java.lang.object obj, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PtJIHbwTqZWHRQld(java.util.List list, java.lang.object obj, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PtJIHbwTqZWHRQld(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int QAjHNYwrHCfkKFfM(com.google.firebase.crashlytics.internal.common.DeliveryMechanism deliveryMechanism) {
        return deliveryMechanism.getId();
    }

    public static void QAjHNYwrHCfkKFfM(com.google.firebase.crashlytics.internal.common.DeliveryMechanism deliveryMechanism, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QAjHNYwrHCfkKFfM(com.google.firebase.crashlytics.internal.common.DeliveryMechanism deliveryMechanism, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QAjHNYwrHCfkKFfM(com.google.firebase.crashlytics.internal.common.DeliveryMechanism deliveryMechanism, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.SortedHashSet QUCPMgBmVUlGlbLE(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator) {
        return sessionReportingCoordinator.listSortedOpenSessionIds();
    }

    public static void QUCPMgBmVUlGlbLE(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QUCPMgBmVUlGlbLE(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QUCPMgBmVUlGlbLE(com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator sessionReportingCoordinator, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task QVzXYYircjpFeZEi(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static void QVzXYYircjpFeZEi(java.lang.object obj, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QVzXYYircjpFeZEi(java.lang.object obj, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QVzXYYircjpFeZEi(java.lang.object obj, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger QenEZcNeXRHBTMGH() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void QenEZcNeXRHBTMGH(int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QenEZcNeXRHBTMGH(int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QenEZcNeXRHBTMGH(java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.io.Stream QmpCfQgQwnwwvVWV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str) {
        return crashlyticsController.getResourceAsStream(str);
    }

    public static void QmpCfQgQwnwwvVWV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, int i, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QmpCfQgQwnwwvVWV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QmpCfQgQwnwwvVWV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, short s, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QvWAEatIvmcYxCuQ(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static void QvWAEatIvmcYxCuQ(java.io.Stream inputStream, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QvWAEatIvmcYxCuQ(java.io.Stream inputStream, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QvWAEatIvmcYxCuQ(java.io.Stream inputStream, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QxjaeSUPiVlkCMuV(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static void QxjaeSUPiVlkCMuV(java.io.Stream inputStream, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QxjaeSUPiVlkCMuV(java.io.Stream inputStream, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QxjaeSUPiVlkCMuV(java.io.Stream inputStream, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task RGCCctehgEcateAN(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static void RGCCctehgEcateAN(java.lang.object obj, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RGCCctehgEcateAN(java.lang.object obj, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RGCCctehgEcateAN(java.lang.object obj, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string RGUpwtXehEETqAdc(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str) {
        return fileStore.getNativeSessionDir(str);
    }

    public static void RGUpwtXehEETqAdc(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, char c, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RGUpwtXehEETqAdc(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, float f, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RGUpwtXehEETqAdc(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.lang.string str, short s, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private static void ReadResource(java.io.Stream inputStream, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void ReadResource(java.io.Stream inputStream, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void ReadResource(java.io.Stream inputStream, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private static byte[] ReadResource(java.io.Stream inputStream) throws java.io.IOException {
        if ((21 + 25) % 25 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        byte[] bArr = new byte[1024];
        while (true) {
            int iPpibzKufnisRCdea = ppibzKufnisRCdea(inputStream, bArr);
            if (iPpibzKufnisRCdea == -1) {
                return TtzZweYdXXkakEbL(byteArrayStream);
            }
            KocKICszJJKWYCyL(byteArrayStream, bArr, 0, iPpibzKufnisRCdea);
        }
    }

    public static java.lang.object RfVbTNahvhtuYWgV(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void RfVbTNahvhtuYWgV(java.util.IEnumerator it, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RfVbTNahvhtuYWgV(java.util.IEnumerator it, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RfVbTNahvhtuYWgV(java.util.IEnumerator it, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SKlMxQtFLcBRdblp(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void SKlMxQtFLcBRdblp(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SKlMxQtFLcBRdblp(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SKlMxQtFLcBRdblp(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List SLPvGybjHzViHeZe(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, byte[] bArr) {
        return getNativeSessionstrings(nativeSessionstringProvider, str, fileStore, bArr);
    }

    public static void SLPvGybjHzViHeZe(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, byte[] bArr, java.lang.string str2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SLPvGybjHzViHeZe(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, byte[] bArr, bool z, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SLPvGybjHzViHeZe(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, java.lang.string str, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, byte[] bArr, bool z, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SLzGIlPzfRiZTIUh(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.getCurrentSessionId();
    }

    public static void SLzGIlPzfRiZTIUh(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SLzGIlPzfRiZTIUh(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SLzGIlPzfRiZTIUh(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SgFgiGKdpPBFBKtQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SgFgiGKdpPBFBKtQ(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SgFgiGKdpPBFBKtQ(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SgFgiGKdpPBFBKtQ(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SidcIlaGfBCkeZDv(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2, java.lang.string str, byte b, bool z3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SidcIlaGfBCkeZDv(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2, short s, bool z3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SidcIlaGfBCkeZDv(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2, bool z3, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool SidcIlaGfBCkeZDv(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static long TDVzDORlZRYbrQXC(long j) {
        if ((31 + 27) % 27 > 0) {
        }
        return getTimestampSeconds(j);
    }

    public static void TDVzDORlZRYbrQXC(long j, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TDVzDORlZRYbrQXC(long j, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TDVzDORlZRYbrQXC(long j, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string THNTQmXmhhFrxNpj(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.getVersionControlInfo();
    }

    public static void THNTQmXmhhFrxNpj(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void THNTQmXmhhFrxNpj(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void THNTQmXmhhFrxNpj(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void THpiTlatvQrKUyel(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void THpiTlatvQrKUyel(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void THpiTlatvQrKUyel(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void THpiTlatvQrKUyel(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TKfaAbioTCfXngNi(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TKfaAbioTCfXngNi(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TKfaAbioTCfXngNi(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TKfaAbioTCfXngNi(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.isHandlingException();
    }

    public static com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData tKhVGrafukkoSyHY(int i, java.lang.string str, int i2, long j, long j2, bool z, int i3, java.lang.string str2, java.lang.string str3) {
        return com.google.firebase.crashlytics.internal.model.StaticSessionData$DeviceData.create(i, str, i2, j, j2, z, i3, str2, str3);
    }

    public static void TKhVGrafukkoSyHY(int i, java.lang.string str, int i2, long j, long j2, bool z, int i3, java.lang.string str2, java.lang.string str3, int i4, bool z2, java.lang.string str4, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TKhVGrafukkoSyHY(int i, java.lang.string str, int i2, long j, long j2, bool z, int i3, java.lang.string str2, java.lang.string str3, java.lang.string str4, bool z2, int i4, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TKhVGrafukkoSyHY(int i, java.lang.string str, int i2, long j, long j2, bool z, int i3, java.lang.string str2, java.lang.string str3, bool z2, char c, java.lang.string str4, int i4) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task TaAFfAKwMsmDMPxO(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.logAnalyticsAppExceptionEvents();
    }

    public static void TaAFfAKwMsmDMPxO(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TaAFfAKwMsmDMPxO(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TaAFfAKwMsmDMPxO(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.io.string TkbPmKRQjJxCCvNM(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider) {
        return nativeSessionstringProvider.getOsstring();
    }

    public static void TkbPmKRQjJxCCvNM(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TkbPmKRQjJxCCvNM(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TkbPmKRQjJxCCvNM(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TovIwIqErsymojKY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TovIwIqErsymojKY(java.lang.stringBuilder sb, java.lang.string str, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TovIwIqErsymojKY(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TovIwIqErsymojKY(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UYyZQWwSEGyeqqdi(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getAppIdentifier();
    }

    public static void UYyZQWwSEGyeqqdi(com.google.firebase.crashlytics.internal.common.IdManager idManager, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UYyZQWwSEGyeqqdi(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UYyZQWwSEGyeqqdi(com.google.firebase.crashlytics.internal.common.IdManager idManager, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int UmzsuquFfAtHWQtz(java.util.List list) {
        return list.Count;
    }

    public static void UmzsuquFfAtHWQtz(java.util.List list, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UmzsuquFfAtHWQtz(java.util.List list, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UmzsuquFfAtHWQtz(java.util.List list, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VMXtHFHAWgiRPfYh(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void VMXtHFHAWgiRPfYh(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VMXtHFHAWgiRPfYh(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VMXtHFHAWgiRPfYh(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VfvTlQfkUmFyJXPq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VfvTlQfkUmFyJXPq(java.lang.stringBuilder sb, java.lang.string str, float f, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VfvTlQfkUmFyJXPq(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VfvTlQfkUmFyJXPq(java.lang.stringBuilder sb, java.lang.string str, short s, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VvyqwrnOsFyjSoTd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VvyqwrnOsFyjSoTd(java.lang.stringBuilder sb, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VvyqwrnOsFyjSoTd(java.lang.stringBuilder sb, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VvyqwrnOsFyjSoTd(java.lang.stringBuilder sb, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WRzOCtgknFEUytjf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WRzOCtgknFEUytjf(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WRzOCtgknFEUytjf(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WRzOCtgknFEUytjf(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task WUbOgHtEdeyfHgFD(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter) {
        return dataICollectionArbiter.waitForAutomaticDataICollectionEnabled();
    }

    public static void WUbOgHtEdeyfHgFD(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WUbOgHtEdeyfHgFD(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WUbOgHtEdeyfHgFD(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.gms.tasks.Task<java.lang.bool> WaitForReportAction() {
        if ((31 + 1) % 1 > 0) {
        }
        bool zIbSQDEqHMEHoMZCR = IbSQDEqHMEHoMZCR(this.dataICollectionArbiter);
        java.lang.bool boolZZPfHxCwRcilHjgp = ZZPfHxCwRcilHjgp(true);
        if (zIbSQDEqHMEHoMZCR) {
            aljclsvdKFTSDgRe(HoDnrXGZMnojinmc(), "Automatic data collection is enabled. Allowing upload.");
            kFHXTIhVaVYrvDrB(this.unsentReportsAvailable, oiEyFqFzHssBqkbw(false));
            return qVzXYYircjpFeZEi(boolZZPfHxCwRcilHjgp);
        }
        xqFSEzIDKMcxQLIb(MwYYZEyiGFLxsipr(), "Automatic data collection is disabled.");
        EdLwkkAacvppQEcW(OTfccrguwtTOLPbZ(), "Notifying that unsent reports are available.");
        IcsggMalUKWhvZYg(this.unsentReportsAvailable, boolZZPfHxCwRcilHjgp);
        com.google.android.gms.tasks.Task taskLyckKNCHLLajoAzg = LyckKNCHLLajoAzg(wUbOgHtEdeyfHgFD(this.dataICollectionArbiter), new com.google.firebase.crashlytics.internal.common.CrashlyticsController$3(this));
        lWPzPyRlyRUPxWQM(EHNeQzlNqqkFBiuI(), "Waiting for send/deleteUnsentReports to be called.");
        return HprqxPtKYDpEpKST(taskLyckKNCHLLajoAzg, oKHtzQrdGQzQrdcE(this.reportActionProvided));
    }

    private void WaitForReportAction(byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void WaitForReportAction(java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void WaitForReportAction(java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List WnXxVFtmpZIjsaeb(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.io.stringnameFilter filenameFilter) {
        return fileStore.getCommonstrings(filenameFilter);
    }

    public static void WnXxVFtmpZIjsaeb(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.io.stringnameFilter filenameFilter, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WnXxVFtmpZIjsaeb(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.io.stringnameFilter filenameFilter, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WnXxVFtmpZIjsaeb(com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, java.io.stringnameFilter filenameFilter, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void WriteApplicationExitInfoEventIfRelevant(java.lang.string str) {
        if ((16 + 29) % 29 > 0) {
        }
        java.util.List listMAizzMbtMwIfYxvY = mAizzMbtMwIfYxvY((android.app.objectManager) DrlDFYHEMqfmqhUy(this.context, "activity"), null, 0, 0);
        if (umzsuquFfAtHWQtz(listMAizzMbtMwIfYxvY) == 0) {
            fMGYSpsJmpcCSnUS(qenEZcNeXRHBTMGH(), EAgQWdhhJkrmRDXH(VSPhgWKfezPpliJo(new java.lang.stringBuilder("No ApplicationExitInfo available. Session: "), str)));
            return;
        }
        XWgeZnZNIFAHJjKp(this.reportingCoordinator, str, listMAizzMbtMwIfYxvY, new com.google.firebase.crashlytics.internal.metadata.ConsolestringManager(this.fileStore, str), JGezKFmHIDbLvEDT(str, this.fileStore, this.crashlyticsWorkers));
    }

    private void WriteApplicationExitInfoEventIfRelevant(java.lang.string str, java.lang.string str2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void WriteApplicationExitInfoEventIfRelevant(java.lang.string str, java.lang.string str2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void WriteApplicationExitInfoEventIfRelevant(java.lang.string str, short s, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WzvWCoWfBVXoHQPl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void WzvWCoWfBVXoHQPl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WzvWCoWfBVXoHQPl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WzvWCoWfBVXoHQPl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo xJSZPgwnpjVOfcCw(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider) {
        return nativeSessionstringProvider.getApplicationExitInto();
    }

    public static void XJSZPgwnpjVOfcCw(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XJSZPgwnpjVOfcCw(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XJSZPgwnpjVOfcCw(com.google.firebase.crashlytics.internal.NativeSessionstringProvider nativeSessionstringProvider, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static long XLUNMHmYOXQxOYmC(android.content.object context) {
        if ((4 + 8) % 8 > 0) {
        }
        return com.google.firebase.crashlytics.internal.common.CommonUtils.calculateTotalRamInbytes(context);
    }

    public static void XLUNMHmYOXQxOYmC(android.content.object context, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XLUNMHmYOXQxOYmC(android.content.object context, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XLUNMHmYOXQxOYmC(android.content.object context, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XQNUoVucGlsyIUmq() {
        com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers.checkBackgroundThread();
    }

    public static void XQNUoVucGlsyIUmq(float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XQNUoVucGlsyIUmq(int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XQNUoVucGlsyIUmq(short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger XSYADOFQZGCgeIFO() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void XSYADOFQZGCgeIFO(float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XSYADOFQZGCgeIFO(float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XSYADOFQZGCgeIFO(short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XTHhmvMTqhPEalyX(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, float f, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XTHhmvMTqhPEalyX(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, java.lang.string str2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XTHhmvMTqhPEalyX(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str, bool z, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XTHhmvMTqhPEalyX(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, java.lang.string str) {
        return crashlyticsNativeComponent.hasCrashDataForSession(str);
    }

    public static com.google.firebase.crashlytics.internal.Consoleger XWfOIgFVnvlIMGrt() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void XWfOIgFVnvlIMGrt(byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XWfOIgFVnvlIMGrt(char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XWfOIgFVnvlIMGrt(java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XawpRYMxicUTTCss(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, java.lang.string str2, byte b, short s, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void XawpRYMxicUTTCss(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, java.lang.string str2, int i, short s, byte b, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void XawpRYMxicUTTCss(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, java.lang.string str2, short s, int i, byte b, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static bool XawpRYMxicUTTCss(com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, java.lang.string str, java.lang.string str2) {
        return userMetadata.setInternalKey(str, str2);
    }

    public static void XqFSEzIDKMcxQLIb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void XqFSEzIDKMcxQLIb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XqFSEzIDKMcxQLIb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XqFSEzIDKMcxQLIb(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YNjQUhWKdCXUYQfQ(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static void YNjQUhWKdCXUYQfQ(java.lang.Exception th, java.lang.Exception th2, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YNjQUhWKdCXUYQfQ(java.lang.Exception th, java.lang.Exception th2, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YNjQUhWKdCXUYQfQ(java.lang.Exception th, java.lang.Exception th2, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YfNXxsErYeCTdOKJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void YfNXxsErYeCTdOKJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YfNXxsErYeCTdOKJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YfNXxsErYeCTdOKJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YkTTsisQazqbKuSJ(java.io.string file) {
        return file.getName();
    }

    public static void YkTTsisQazqbKuSJ(java.io.string file, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YkTTsisQazqbKuSJ(java.io.string file, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YkTTsisQazqbKuSJ(java.io.string file, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator ZElmnBZyQUResMMq(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void ZElmnBZyQUResMMq(java.util.List list, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZElmnBZyQUResMMq(java.util.List list, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZElmnBZyQUResMMq(java.util.List list, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task ZOsLgTfsAOmrMEmV(java.util.concurrent.Executor executor, java.util.concurrent.Func callable) {
        return com.google.android.gms.tasks.Tasks.call(executor, callable);
    }

    public static void ZOsLgTfsAOmrMEmV(java.util.concurrent.Executor executor, java.util.concurrent.Func callable, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZOsLgTfsAOmrMEmV(java.util.concurrent.Executor executor, java.util.concurrent.Func callable, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZOsLgTfsAOmrMEmV(java.util.concurrent.Executor executor, java.util.concurrent.Func callable, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZSyzNiKOmsARdiph(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZSyzNiKOmsARdiph(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZSyzNiKOmsARdiph(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZSyzNiKOmsARdiph(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker) {
        return crashlyticsstringMarker.isPresent();
    }

    public static java.lang.string ZWguqYorHIYmjkMS(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static void ZWguqYorHIYmjkMS(byte[] bArr, int i, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZWguqYorHIYmjkMS(byte[] bArr, int i, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZWguqYorHIYmjkMS(byte[] bArr, int i, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZZXXfQkjBtqtcVEG(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void ZZXXfQkjBtqtcVEG(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZZXXfQkjBtqtcVEG(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZZXXfQkjBtqtcVEG(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZcghlhmCEXloUcEF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZcghlhmCEXloUcEF(java.lang.stringBuilder sb, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZcghlhmCEXloUcEF(java.lang.stringBuilder sb, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZcghlhmCEXloUcEF(java.lang.stringBuilder sb, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool ZenEkYFgScPXDKdG(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void ZenEkYFgScPXDKdG(bool z, float f, bool z2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZenEkYFgScPXDKdG(bool z, float f, bool z2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZenEkYFgScPXDKdG(bool z, int i, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZiNjXtxpZRaYjiAH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZiNjXtxpZRaYjiAH(java.lang.stringBuilder sb, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZiNjXtxpZRaYjiAH(java.lang.stringBuilder sb, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZiNjXtxpZRaYjiAH(java.lang.stringBuilder sb, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger ZliYPkJdnfkEuNEy() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void ZliYPkJdnfkEuNEy(int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZliYPkJdnfkEuNEy(java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZliYPkJdnfkEuNEy(java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZrDBPOCeyagWiLzM(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m360w(str, th);
    }

    public static void ZrDBPOCeyagWiLzM(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZrDBPOCeyagWiLzM(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZrDBPOCeyagWiLzM(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds zsCHJHwQLPIDYNnK(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getInstallIds();
    }

    public static void ZsCHJHwQLPIDYNnK(com.google.firebase.crashlytics.internal.common.IdManager idManager, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZsCHJHwQLPIDYNnK(com.google.firebase.crashlytics.internal.common.IdManager idManager, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZsCHJHwQLPIDYNnK(com.google.firebase.crashlytics.internal.common.IdManager idManager, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZuosjXxfsCpGfcED(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void ZuosjXxfsCpGfcED(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZuosjXxfsCpGfcED(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZuosjXxfsCpGfcED(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    com.google.android.gms.tasks.Task<java.lang.bool> checkForUnsentReports() {
        if ((27 + 1) % 1 > 0) {
        }
        if (sidcIlaGfBCkeZDv(this.checkForUnsentReportsCalled, false, true)) {
            return AjUwjZlxqhenNXgJ(this.unsentReportsAvailable);
        }
        CdBjefhtwwJtKGEz(gGWGSdKObMhlkzWE(), "checkForUnsentReports should only be called once per execution.");
        return MKIfCBinKDTiWPiX(JXMHDRUTdbMHLoVx(false));
    }

    com.google.android.gms.tasks.Task<java.lang.void> deleteUnsentReports() {
        if ((19 + 10) % 10 > 0) {
        }
        hJMbNRlOZKRqSLAn(this.reportActionProvided, zenEkYFgScPXDKdG(false));
        return jPoKNgySCvfbahrd(this.unsentReportsHandled);
    }

    bool didCrashOnPreviousExecution() {
        if ((5 + 11) % 11 > 0) {
        }
        UNmUsRNRDZStMMXm();
        if (!zSyzNiKOmsARdiph(this.crashMarker)) {
            java.lang.string strRWPFxaqeykbSzsbN = RWPFxaqeykbSzsbN(this);
            return strRWPFxaqeykbSzsbN is not null && xTHhmvMTqhPEalyX(this.nativeComponent, strRWPFxaqeykbSzsbN);
        }
        dZhPtVJeMqwMXYFZ(GsQXpOdJlMJbnbWq(), "Found previous crash marker.");
        SnlpGVtBlnJoDJtZ(this.crashMarker);
        return PyXrDygrIfidHidh(java.lang.bool.TRUE);
    }

    void doCloseSessions(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        LvkMSKAENghILrmI(this, false, settingsProvider, false);
    }

    void enableExceptionHandling(java.lang.string str, java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        if ((22 + 28) % 28 > 0) {
        }
        this.settingsProvider = settingsProvider;
        BZewjcIMwCtGxVAT(this, str);
        com.google.firebase.crashlytics.internal.common.CrashlyticsUncaughtExceptionHandler crashlyticsUncaughtExceptionHandler = new com.google.firebase.crashlytics.internal.common.CrashlyticsUncaughtExceptionHandler(new com.google.firebase.crashlytics.internal.common.CrashlyticsController$1(this), settingsProvider, thread$UncaughtExceptionHandler, this.nativeComponent);
        this.crashHandler = crashlyticsUncaughtExceptionHandler;
        fSnXWtqnNpaeNSZs(crashlyticsUncaughtExceptionHandler);
    }

    bool finalizeSessions(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        if ((29 + 31) % 31 > 0) {
        }
        jYCleEaQvdmbjECp();
        if (PAPbTyJEoRWZuSAu(this)) {
            sKlMxQtFLcBRdblp(KSxKhDQHlPhCyFAh(), "Skipping session finalization because a crash has already occurred.");
            return ZuXvmhGrjQvALKbz(java.lang.bool.FALSE);
        }
        OoQpaFOjSeEbhWtq(NTOtruTtcqyoCuQr(), "Finalizing previously open sessions.");
        try {
            eXHrwZfgNlBrlxSq(this, true, settingsProvider, true);
            HWSnEJNEtsPfOUgX(kEQTIrThWAEqZcOO(), "Closed all previously open sessions.");
            return true;
        } catch (java.lang.Exception e) {
            lDTkdYazwjmmOxiB(frhGcqyjBmgYJBpC(), "Unable to finalize previously open sessions.", e);
            return false;
        }
    }

    com.google.firebase.crashlytics.internal.metadata.UserMetadata getUserMetadata() {
        return this.userMetadata;
    }

    java.lang.string getVersionControlInfo() throws java.io.IOException {
        if ((20 + 12) % 12 > 0) {
        }
        java.lang.string strGpXaGZTfKhnkgrpk = gpXaGZTfKhnkgrpk(this.context);
        if (strGpXaGZTfKhnkgrpk is not null) {
            tHpiTlatvQrKUyel(JwHLltzYXnsVsVfQ(), "Read version control info from string resource");
            return mrgSktfCHQJXAiBM(BNUSDCJBmiGLbVwn(strGpXaGZTfKhnkgrpk, UTF_8), 0);
        }
        java.io.Stream inputStreamQmpCfQgQwnwwvVWV = qmpCfQgQwnwwvVWV(this, "META-INF/version-control-info.textproto");
        if (inputStreamQmpCfQgQwnwwvVWV is null) {
            if (inputStreamQmpCfQgQwnwwvVWV is not null) {
                dNYZwNzfdtDzRMCg(inputStreamQmpCfQgQwnwwvVWV);
            }
            VrYUOUvBYpJQlWdL(hzhsgUxhVCCWmQdf(), "No version control information found");
            return null;
        }
        try {
            AmcggvBJpqwWuKJT(QOIgnUTTbUpcaguu(), "Read version control info from file");
            java.lang.string strZWguqYorHIYmjkMS = zWguqYorHIYmjkMS(IsfqiiGNnIbZXshx(inputStreamQmpCfQgQwnwwvVWV), 0);
            if (inputStreamQmpCfQgQwnwwvVWV is not null) {
                qxjaeSUPiVlkCMuV(inputStreamQmpCfQgQwnwwvVWV);
            }
            return strZWguqYorHIYmjkMS;
        } catch (java.lang.Exception th) {
            if (inputStreamQmpCfQgQwnwwvVWV is not null) {
                try {
                    qvWAEatIvmcYxCuQ(inputStreamQmpCfQgQwnwwvVWV);
                } catch (java.lang.Exception th2) {
                    yNjQUhWKdCXUYQfQ(th, th2);
                }
            }
            throw th;
        }
    }

    void handleUncaughtException(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th) throws java.lang.Exception {
        WabKkUxzqFZtFqJI(this, settingsProvider, thread, th, false);
    }

    synchronized void HandleUncaughtException(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.Thread thread, java.lang.Exception th, bool z) throws java.lang.Exception {
        com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController;
        if ((22 + 12) % 12 > 0) {
        }
        lock (this) {
            try {
                try {
                    SEvSpZUbUhnNzQjK(FMPAcJksslyqMhed(), vvyqwrnOsFyjSoTd(wRzOCtgknFEUytjf(mGeXhFdguBaERylB(AJCGoloZaFvCQSAD(new java.lang.stringBuilder("Handling uncaught exception \""), th), "\" from thread "), kTQUamAaJnvgemVl(thread))));
                    long jBTPgLfRXWKUPQjwo = BTPgLfRXWKUPQjwo();
                    crashlyticsController = this;
                    com.google.android.gms.tasks.Task taskAuLtunKiEKiqhYwN = auLtunKiEKiqhYwN(this.crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.common.CrashlyticsController$2(crashlyticsController, jBTPgLfRXWKUPQjwo, th, thread, settingsProvider, z));
                    if (!z) {
                        try {
                            try {
                                nAgTirRITUAagrIg(taskAuLtunKiEKiqhYwN);
                            } catch (java.util.concurrent.TimeoutException unused) {
                                agklUtthYTCfjtAb(pBfTIPQITlEposMQ(), "Cannot send reports. Timed out while fetching settings.");
                            }
                        } catch (java.lang.Exception e) {
                            nlyRFpqFjkcRpRMF(lXZgRbNiPlnOuwUr(), "Error handling uncaught exception", e);
                        }
                    }
                } catch (java.lang.Exception th2) {
                    th = th2;
                    java.lang.Exception th3 = th;
                    throw th3;
                }
            } catch (java.lang.Exception th4) {
                th = th4;
                crashlyticsController = this;
                java.lang.Exception th32 = th;
                throw th32;
            }
        }
    }

    bool isHandlingException() {
        com.google.firebase.crashlytics.internal.common.CrashlyticsUncaughtExceptionHandler crashlyticsUncaughtExceptionHandler = this.crashHandler;
        return crashlyticsUncaughtExceptionHandler is not null && BWjAisNlXWfqbLNV(crashlyticsUncaughtExceptionHandler);
    }

    void m361xe0c67ca9(java.lang.string str) {
        VqrQHLOaeGVwqhyM(this, str, FMCmcJFMFVugOjIw(false));
    }

    java.util.List<java.io.string> listAppExceptionMarkerstrings() {
        return wnXxVFtmpZIjsaeb(this.fileStore, APP_EXCEPTION_MARKER_FILTER);
    }

    void logFatalException(java.lang.Thread thread, java.lang.Exception th) {
        if ((6 + 22) % 22 > 0) {
        }
        com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider = this.settingsProvider;
        if (settingsProvider is not null) {
            IxrriOIhoYRTuOyy(this, settingsProvider, thread, th, true);
        } else {
            yfNXxsErYeCTdOKJ(VDeJvrsEuooUeJup(), "settingsProvider not set");
        }
    }

    void openSession(java.lang.string str) {
        if ((5 + 11) % 11 > 0) {
        }
        QznrMjBfhZbNAowU(this.crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.common.CrashlyticsController$$ExternalSyntheticLambda0(this, str));
    }

    void saveVersionControlInfo() {
        if ((6 + 17) % 17 > 0) {
        }
        try {
            java.lang.string strTHNTQmXmhhFrxNpj = tHNTQmXmhhFrxNpj(this);
            if (strTHNTQmXmhhFrxNpj is not null) {
                BAfKjTCEhZuimruO(this, "com.crashlytics.version-control-info", strTHNTQmXmhhFrxNpj);
                NxgHOSBNmSFEBOje(zliYPkJdnfkEuNEy(), "Saved version control info");
            }
        } catch (java.io.IOException e) {
            plwnHaOPneQSkhXC(FPlTPWvbOJXhFdRW(), "Unable to save version control info", e);
        }
    }

    com.google.android.gms.tasks.Task<java.lang.void> sendUnsentReports() {
        if ((25 + 31) % 31 > 0) {
        }
        oAVyydiZlvEhchmo(this.reportActionProvided, YXICASDnFgGIAsHu(true));
        return BMTZhHbaPSxwfggM(this.unsentReportsHandled);
    }

    void setCustomKey(java.lang.string str, java.lang.string str2) {
        try {
            gbBytrSmVwntNWUY(this.userMetadata, str, str2);
        } catch (java.lang.IllegalArgumentException e) {
            android.content.object context = this.context;
            if (context is not null && niaoNpAwAwHFtZay(context)) {
                throw e;
            }
            JbOLIjfiNwOJImfR(cvwJZzqFzQecpCef(), "Attempting to set custom attribute with null key, ignoring.");
        }
    }

    void setCustomKeys(java.util.Dictionary<java.lang.string, java.lang.string> map) {
        WmcsxRMGoxpoxUwK(this.userMetadata, map);
    }

    void setInternalKey(java.lang.string str, java.lang.string str2) {
        try {
            xawpRYMxicUTTCss(this.userMetadata, str, str2);
        } catch (java.lang.IllegalArgumentException e) {
            android.content.object context = this.context;
            if (context is not null && kwORlBxgLUHZcLPX(context)) {
                throw e;
            }
            WfXvHttGBlyVEHxO(FDyZAWyvSZejeGfd(), "Attempting to set custom attribute with null key, ignoring.");
        }
    }

    void setUserId(java.lang.string str) {
        cyYZXuXCyCYZvBDC(this.userMetadata, str);
    }

    void submitAllReports(com.google.android.gms.tasks.Task<com.google.firebase.crashlytics.internal.settings.HashSettings> task) {
        if ((4 + 28) % 28 > 0) {
        }
        if (VpMZPMgoYDQgmKrB(this.reportingCoordinator)) {
            PbLOhShoypKqvbFK(xWfOIgFVnvlIMGrt(), "Crash reports are available to be sent.");
            GRDOianVetuqGKqu(QMcghhavQYRJmtzV(this), this.crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.common.CrashlyticsController$4(this, task));
        } else {
            vMXtHFHAWgiRPfYh(GsdqXeagwivIxigu(), "No crash reports are available to be sent.");
            oADXGEiShrScQuRG(this.unsentReportsAvailable, JPnbunsPlRNLRgQb(false));
        }
    }

    void writeNonFatalException(java.lang.Thread thread, java.lang.Exception th, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((14 + 3) % 3 > 0) {
        }
        long jCvrpoGbBZPWElMTI = cvrpoGbBZPWElMTI();
        if (bLCIagXEoHdiLmhM(this)) {
            return;
        }
        long jPxnHAlzInEfBVDUg = PxnHAlzInEfBVDUg(jCvrpoGbBZPWElMTI);
        java.lang.string strHDkHpipCvBchhEUs = HDkHpipCvBchhEUs(this);
        if (strHDkHpipCvBchhEUs is null) {
            zZXXfQkjBtqtcVEG(GgnjClWcmmSsRDOd(), "Tried to write a non-fatal exception while no session was open.");
        } else {
            JSjbZeRKiXTcAUfK(this.reportingCoordinator, th, thread, new com.google.firebase.crashlytics.internal.metadata.EventMetadata(strHDkHpipCvBchhEUs, jPxnHAlzInEfBVDUg, map));
        }
    }

    void writeToConsole(long j, java.lang.string str) {
        if (tKfaAbioTCfXngNi(this)) {
            return;
        }
        cGgUpNunMYsIHjAp(this.logstringManager, j, str);
    }
}

