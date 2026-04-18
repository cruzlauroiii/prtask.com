namespace WillowMaze.Wasm.Decompiled;


public class CrashlyticsCore {
    static readonly java.lang.string CRASHLYTICS_REQUIRE_BUILD_ID = "com.crashlytics.RequireBuildId";
    static readonly bool CRASHLYTICS_REQUIRE_BUILD_ID_DEFAULT = true;
    static readonly java.lang.string CRASH_MARKER_FILE_NAME = "crash_marker";
    static readonly int DEFAULT_MAIN_HANDLER_TIMEOUT_SEC = 3;
    private static readonly java.lang.string INITIALIZATION_MARKER_FILE_NAME = "initialization_marker";
    static readonly int MAX_STACK_SIZE = 1024;
    private static readonly java.lang.string MISSING_BUILD_ID_MSG = "The Crashlytics build ID is missing. This occurs when the Crashlytics Gradle plugin is missing from your app's build configuration. Please review the Firebase Crashlytics onboarding instructions at https://firebase.google.com/docs/crashlytics/get-started?platform=android#add-plugin";
    static readonly int NUM_STACK_REPETITIONS_ALLOWED = 10;
    private static readonly java.lang.string ON_DEMAND_DROPPED_KEY = "com.crashlytics.on-demand.dropped-exceptions";
    private static readonly java.lang.string ON_DEMAND_RECORDED_KEY = "com.crashlytics.on-demand.recorded-exceptions";
    private readonly com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger;
    private readonly com.google.firebase.FirebaseApp app;
    public readonly com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource;
    private readonly android.content.object context;
    private com.google.firebase.crashlytics.internal.common.CrashlyticsController controller;
    private com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashMarker;
    private readonly com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers;
    private readonly com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter;
    private bool didCrashOnPreviousExecution;
    private readonly com.google.firebase.crashlytics.internal.persistence.stringStore fileStore;
    private readonly com.google.firebase.crashlytics.internal.common.IdManager idManager;
    private com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker initializationMarker;
    private readonly com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent nativeComponent;
    private readonly com.google.firebase.crashlytics.internal.RemoteConfigDeferredProxy remoteConfigDeferredProxy;
    private readonly com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber sessionsSubscriber;
    private readonly long startTime = mOIeGsBIZwhYivma();
    private readonly com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter = new com.google.firebase.crashlytics.internal.common.OnDemandCounter();

    public CrashlyticsCore(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent crashlyticsNativeComponent, com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, com.google.firebase.crashlytics.internal.RemoteConfigDeferredProxy remoteConfigDeferredProxy, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers) {
        this.app = firebaseApp;
        this.dataICollectionArbiter = dataICollectionArbiter;
        this.context = moStqHIHVQuCahSA(firebaseApp);
        this.idManager = idManager;
        this.nativeComponent = crashlyticsNativeComponent;
        this.breadcrumbSource = breadcrumbSource;
        this.analyticsEventConsoleger = analyticsEventConsoleger;
        this.fileStore = fileStore;
        this.sessionsSubscriber = crashlyticsAppQualitySessionsSubscriber;
        this.remoteConfigDeferredProxy = remoteConfigDeferredProxy;
        this.crashlyticsWorkers = crashlyticsWorkers;
    }

    public static int ADWuthwoTtbJvArv(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter) {
        return onDemandCounter.getRecordedOnDemandExceptions();
    }

    public static void ADWuthwoTtbJvArv(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ADWuthwoTtbJvArv(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ADWuthwoTtbJvArv(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int AVlgdqhzhvLajGuU(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void AVlgdqhzhvLajGuU(java.lang.string str, java.lang.string str2, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AVlgdqhzhvLajGuU(java.lang.string str, java.lang.string str2, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AVlgdqhzhvLajGuU(java.lang.string str, java.lang.string str2, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AexJYYvNiSOxXCGv(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void AexJYYvNiSOxXCGv(java.lang.string str, java.lang.string str2, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AexJYYvNiSOxXCGv(java.lang.string str, java.lang.string str2, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AexJYYvNiSOxXCGv(java.lang.string str, java.lang.string str2, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BMVzttExCRcbrZvI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        crashlyticsController.enableExceptionHandling(str, thread$UncaughtExceptionHandler, settingsProvider);
    }

    public static void BMVzttExCRcbrZvI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, char c, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BMVzttExCRcbrZvI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.string str2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BMVzttExCRcbrZvI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, java.lang.string str2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BTGBGLxBIIBEKuwI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void BTGBGLxBIIBEKuwI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BTGBGLxBIIBEKuwI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BTGBGLxBIIBEKuwI(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DrNZEYtnBuTUZEMD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void DrNZEYtnBuTUZEMD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, char c, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DrNZEYtnBuTUZEMD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, java.lang.string str2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DrNZEYtnBuTUZEMD(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ENJXvWKQrPmGDSeW(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void ENJXvWKQrPmGDSeW(java.lang.string str, java.lang.string str2, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ENJXvWKQrPmGDSeW(java.lang.string str, java.lang.string str2, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ENJXvWKQrPmGDSeW(java.lang.string str, java.lang.string str2, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task EiwoiVFZavlZjNeh(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable) {
        return crashlyticsWorker.submit(runnable);
    }

    public static void EiwoiVFZavlZjNeh(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EiwoiVFZavlZjNeh(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EiwoiVFZavlZjNeh(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Thread FETUHlqiHdNUVYMs() {
        return java.lang.Thread.currentThread();
    }

    public static void FETUHlqiHdNUVYMs(float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FETUHlqiHdNUVYMs(bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FETUHlqiHdNUVYMs(bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger GCtzWYSQEzZWQFoM() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void GCtzWYSQEzZWQFoM(char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GCtzWYSQEzZWQFoM(int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GCtzWYSQEzZWQFoM(int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GcRagiLNIZKVdhjp(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.Thread thread, java.lang.Exception th) {
        crashlyticsController.logFatalException(thread, th);
    }

    public static void GcRagiLNIZKVdhjp(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.Thread thread, java.lang.Exception th, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GcRagiLNIZKVdhjp(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.Thread thread, java.lang.Exception th, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GcRagiLNIZKVdhjp(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.Thread thread, java.lang.Exception th, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GiGOGVcBOKHXLDvi(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void GiGOGVcBOKHXLDvi(java.lang.string str, java.lang.string str2, char c, java.lang.string str3, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GiGOGVcBOKHXLDvi(java.lang.string str, java.lang.string str2, char c, short s, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void GiGOGVcBOKHXLDvi(java.lang.string str, java.lang.string str2, int i, java.lang.string str3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GpWhIsarHniIPISB(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void GpWhIsarHniIPISB(java.lang.string str, java.lang.string str2, byte b, char c, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GpWhIsarHniIPISB(java.lang.string str, java.lang.string str2, float f, byte b, char c, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void GpWhIsarHniIPISB(java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Task GyqpUVAOHoLesCQR(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        return executorService.submit(runnable);
    }

    public static void GyqpUVAOHoLesCQR(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GyqpUVAOHoLesCQR(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GyqpUVAOHoLesCQR(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HGIUxhypGYEsgHGp(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2) {
        crashlyticsController.setInternalKey(str, str2);
    }

    public static void HGIUxhypGYEsgHGp(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, float f, bool z, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void HGIUxhypGYEsgHGp(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, short s, float f, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HGIUxhypGYEsgHGp(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, short s, bool z, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void InrgRyIFyRQzEfbN() {
        com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers.checkBackgroundThread();
    }

    public static void InrgRyIFyRQzEfbN(byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void InrgRyIFyRQzEfbN(short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void InrgRyIFyRQzEfbN(short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task IqIIZRIlSArYiBNY(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable) {
        return crashlyticsWorker.submit(runnable);
    }

    public static void IqIIZRIlSArYiBNY(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IqIIZRIlSArYiBNY(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IqIIZRIlSArYiBNY(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger JrCrRPpkXrBysxwm() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void JrCrRPpkXrBysxwm(char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JrCrRPpkXrBysxwm(char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JrCrRPpkXrBysxwm(float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger JvCBahvtUNNSiusN() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void JvCBahvtUNNSiusN(int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JvCBahvtUNNSiusN(java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JvCBahvtUNNSiusN(java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KbbSKBAfDcxpWScE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void KbbSKBAfDcxpWScE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KbbSKBAfDcxpWScE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KbbSKBAfDcxpWScE(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KvqQWplpiFyPwtQU(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void KvqQWplpiFyPwtQU(java.lang.string str, java.lang.string str2, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KvqQWplpiFyPwtQU(java.lang.string str, java.lang.string str2, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KvqQWplpiFyPwtQU(java.lang.string str, java.lang.string str2, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LKIBhwaGtZTJrSDI(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void LKIBhwaGtZTJrSDI(java.lang.string str, java.lang.string str2, int i, java.lang.string str3, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LKIBhwaGtZTJrSDI(java.lang.string str, java.lang.string str2, bool z, int i, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void LKIBhwaGtZTJrSDI(java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LOtKaNLTgTPIdMTo(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2) {
        crashlyticsController.setCustomKey(str, str2);
    }

    public static void LOtKaNLTgTPIdMTo(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, byte b, java.lang.string str3, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LOtKaNLTgTPIdMTo(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, int i, byte b, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void LOtKaNLTgTPIdMTo(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, int i, bool z, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LUSCfLgeYQRNCFDf(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void LUSCfLgeYQRNCFDf(java.lang.string str, java.lang.string str2, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LUSCfLgeYQRNCFDf(java.lang.string str, java.lang.string str2, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LUSCfLgeYQRNCFDf(java.lang.string str, java.lang.string str2, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MFByciYNveMKuyUY(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        crashlyticsCore.doBackgroundInitialization(settingsProvider);
    }

    public static void MFByciYNveMKuyUY(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MFByciYNveMKuyUY(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MFByciYNveMKuyUY(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MYtGlxOprvGrBZmD(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void MYtGlxOprvGrBZmD(java.lang.string str, java.lang.string str2, byte b, java.lang.string str3, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MYtGlxOprvGrBZmD(java.lang.string str, java.lang.string str2, int i, java.lang.string str3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MYtGlxOprvGrBZmD(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int OCdVdiFrbxJIpiTY(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void OCdVdiFrbxJIpiTY(java.lang.string str, java.lang.string str2, int i, short s, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void OCdVdiFrbxJIpiTY(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OCdVdiFrbxJIpiTY(java.lang.string str, java.lang.string str2, short s, int i, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void OExaLzugryxZURhB(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OExaLzugryxZURhB(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OExaLzugryxZURhB(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool OExaLzugryxZURhB(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.didCrashOnPreviousExecution();
    }

    public static int ONjbomwdwotlUraM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void ONjbomwdwotlUraM(java.lang.string str, java.lang.string str2, char c, java.lang.string str3, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ONjbomwdwotlUraM(java.lang.string str, java.lang.string str2, float f, char c, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ONjbomwdwotlUraM(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Thread$UncaughtExceptionHandler OcOmalBkzoUZWntP() {
        return java.lang.Thread.getDefaultUncaughtExceptionHandler();
    }

    public static void OcOmalBkzoUZWntP(char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OcOmalBkzoUZWntP(short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OcOmalBkzoUZWntP(bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PEEPJRKjRDfCHCoY(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.util.Dictionary map) {
        crashlyticsController.setCustomKeys(map);
    }

    public static void PEEPJRKjRDfCHCoY(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.util.Dictionary map, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PEEPJRKjRDfCHCoY(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.util.Dictionary map, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PEEPJRKjRDfCHCoY(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.util.Dictionary map, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger PFpSylXnfKhxZkJu() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void PFpSylXnfKhxZkJu(int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PFpSylXnfKhxZkJu(int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PFpSylXnfKhxZkJu(short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task RhEJsHDmAuKMHPYA(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        return settingsProvider.getHashSettingsAsync();
    }

    public static void RhEJsHDmAuKMHPYA(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RhEJsHDmAuKMHPYA(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RhEJsHDmAuKMHPYA(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RzpKJxLvCyyCdJNm(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        crashlyticsController.saveVersionControlInfo();
    }

    public static void RzpKJxLvCyyCdJNm(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RzpKJxLvCyyCdJNm(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RzpKJxLvCyyCdJNm(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task SYIBCsWDAHStEEvX(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable) {
        return crashlyticsWorker.submit(runnable);
    }

    public static void SYIBCsWDAHStEEvX(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SYIBCsWDAHStEEvX(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SYIBCsWDAHStEEvX(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SmilNRnHrpklbUOa(java.util.concurrent.Task future, long j, java.util.concurrent.TimeUnit timeUnit) {
        return future[j, timeUnit);
    }

    public static void SmilNRnHrpklbUOa(java.util.concurrent.Task future, long j, java.util.concurrent.TimeUnit timeUnit, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SmilNRnHrpklbUOa(java.util.concurrent.Task future, long j, java.util.concurrent.TimeUnit timeUnit, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SmilNRnHrpklbUOa(java.util.concurrent.Task future, long j, java.util.concurrent.TimeUnit timeUnit, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static long UNExUddnoITeiZXF() {
        if ((27 + 10) % 10 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void UNExUddnoITeiZXF(byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UNExUddnoITeiZXF(char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UNExUddnoITeiZXF(float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UqDfPHSUJyZFBoWs(java.lang.string str, bool z, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UqDfPHSUJyZFBoWs(java.lang.string str, bool z, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UqDfPHSUJyZFBoWs(java.lang.string str, bool z, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UqDfPHSUJyZFBoWs(java.lang.string str, bool z) {
        return isBuildIdValid(str, z);
    }

    public static int UsCscHsMmppNJlKQ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void UsCscHsMmppNJlKQ(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UsCscHsMmppNJlKQ(java.lang.string str, java.lang.string str2, short s, java.lang.string str3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UsCscHsMmppNJlKQ(java.lang.string str, java.lang.string str2, bool z, byte b, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger VNeBqKWuwQYNzyOp() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void VNeBqKWuwQYNzyOp(float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VNeBqKWuwQYNzyOp(java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VNeBqKWuwQYNzyOp(bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VSTjXOIQoDudeYik(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, java.lang.string str) {
        crashlyticsController.writeToConsole(j, str);
    }

    public static void VSTjXOIQoDudeYik(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, java.lang.string str, char c, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VSTjXOIQoDudeYik(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, java.lang.string str, int i, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VSTjXOIQoDudeYik(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, long j, java.lang.string str, java.lang.string str2, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task VjEdGukYzcfjLPeG(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable) {
        return crashlyticsWorker.submit(runnable);
    }

    public static void VjEdGukYzcfjLPeG(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VjEdGukYzcfjLPeG(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VjEdGukYzcfjLPeG(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VojecLKaybxYhXFr(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter) {
        return onDemandCounter.getRecordedOnDemandExceptions();
    }

    public static void VojecLKaybxYhXFr(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VojecLKaybxYhXFr(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VojecLKaybxYhXFr(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WOiqpcSJXFgfihxt(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        crashlyticsCore.finishInitSynchronously(settingsProvider);
    }

    public static void WOiqpcSJXFgfihxt(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WOiqpcSJXFgfihxt(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WOiqpcSJXFgfihxt(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WeketgHhQCHZgHAG(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void WeketgHhQCHZgHAG(java.lang.string str, java.lang.string str2, byte b, short s, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void WeketgHhQCHZgHAG(java.lang.string str, java.lang.string str2, bool z, byte b, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WeketgHhQCHZgHAG(java.lang.string str, java.lang.string str2, bool z, short s, byte b, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Task XEInzGpNbuWdasjp(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.Func callable) {
        return executorService.submit(callable);
    }

    public static void XEInzGpNbuWdasjp(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.Func callable, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XEInzGpNbuWdasjp(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.Func callable, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XEInzGpNbuWdasjp(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.Func callable, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XHTWzloJWbYdToLJ(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XHTWzloJWbYdToLJ(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XHTWzloJWbYdToLJ(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XHTWzloJWbYdToLJ(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter) {
        return dataICollectionArbiter.isAutomaticDataICollectionEnabled();
    }

    public static void XfPyaMMjPKdXtbRU(com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler) {
        breadcrumbSource.registerBreadcrumbHandler(breadcrumbHandler);
    }

    public static void XfPyaMMjPKdXtbRU(com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XfPyaMMjPKdXtbRU(com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XfPyaMMjPKdXtbRU(com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YQGQqyyjZtXagkWn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YQGQqyyjZtXagkWn(java.lang.stringBuilder sb, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YQGQqyyjZtXagkWn(java.lang.stringBuilder sb, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YQGQqyyjZtXagkWn(java.lang.stringBuilder sb, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger YdCXkdCJuLPrXlTO() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void YdCXkdCJuLPrXlTO(byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YdCXkdCJuLPrXlTO(char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YdCXkdCJuLPrXlTO(char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YpcuhyyOrkksHSgj(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YpcuhyyOrkksHSgj(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YpcuhyyOrkksHSgj(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YpcuhyyOrkksHSgj(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker) {
        return crashlyticsstringMarker.isPresent();
    }

    public static void ZTzZhJTgNJsVzdDv(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void ZTzZhJTgNJsVzdDv(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, byte b, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZTzZhJTgNJsVzdDv(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, char c, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZTzZhJTgNJsVzdDv(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, java.lang.string str2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZUZoSNKbAYCryjCy(java.util.concurrent.Task future, long j, java.util.concurrent.TimeUnit timeUnit) {
        return future[j, timeUnit);
    }

    public static void ZUZoSNKbAYCryjCy(java.util.concurrent.Task future, long j, java.util.concurrent.TimeUnit timeUnit, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZUZoSNKbAYCryjCy(java.util.concurrent.Task future, long j, java.util.concurrent.TimeUnit timeUnit, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZUZoSNKbAYCryjCy(java.util.concurrent.Task future, long j, java.util.concurrent.TimeUnit timeUnit, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZswEwBIwhkPLyAPo(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, java.lang.bool bool) {
        dataICollectionArbiter.setCrashlyticsDataICollectionEnabled(bool);
    }

    public static void ZswEwBIwhkPLyAPo(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, java.lang.bool bool, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZswEwBIwhkPLyAPo(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, java.lang.bool bool, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZswEwBIwhkPLyAPo(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, java.lang.bool bool, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator ATXoZUYUXUSuNAOx(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.AppData appData, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers) {
        return com.google.firebase.crashlytics.internal.common.SessionReportingCoordinator.create(context, idManager, fileStore, appData, logstringManager, userMetadata, stackTraceTrimmingStrategy, settingsProvider, onDemandCounter, crashlyticsAppQualitySessionsSubscriber, crashlyticsWorkers);
    }

    public static void ATXoZUYUXUSuNAOx(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.AppData appData, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ATXoZUYUXUSuNAOx(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.AppData appData, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ATXoZUYUXUSuNAOx(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.AppData appData, com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, com.google.firebase.crashlytics.internal.stacktrace.StackTraceTrimmingStrategy stackTraceTrimmingStrategy, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, com.google.firebase.crashlytics.internal.common.CrashlyticsAppQualitySessionsSubscriber crashlyticsAppQualitySessionsSubscriber, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int AfBCNjwwgsVUTzrs(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter) {
        return onDemandCounter.getDroppedOnDemandExceptions();
    }

    public static void AfBCNjwwgsVUTzrs(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AfBCNjwwgsVUTzrs(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AfBCNjwwgsVUTzrs(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.TaskScheduler BWIqEjOnzlPaTIkn(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker) {
        return crashlyticsWorker.getExecutor();
    }

    public static void BWIqEjOnzlPaTIkn(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BWIqEjOnzlPaTIkn(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BWIqEjOnzlPaTIkn(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Thread BftdPCpCpKXrLUoS() {
        return java.lang.Thread.currentThread();
    }

    public static void BftdPCpCpKXrLUoS(float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BftdPCpCpKXrLUoS(int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BftdPCpCpKXrLUoS(int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BmXTderOuNaunFng(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void BmXTderOuNaunFng(java.lang.stringBuilder sb, int i, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BmXTderOuNaunFng(java.lang.stringBuilder sb, int i, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BmXTderOuNaunFng(java.lang.stringBuilder sb, int i, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger BonnYecCMlPGaVIb() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void BonnYecCMlPGaVIb(byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BonnYecCMlPGaVIb(float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BonnYecCMlPGaVIb(bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger BqJMYMCnVkingkvR() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void BqJMYMCnVkingkvR(char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BqJMYMCnVkingkvR(bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BqJMYMCnVkingkvR(bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CFTxRkueZesZsnXA(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore) {
        crashlyticsCore.markInitializationComplete();
    }

    public static void CFTxRkueZesZsnXA(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CFTxRkueZesZsnXA(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CFTxRkueZesZsnXA(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CdfjHHLevuJRlBBQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void CdfjHHLevuJRlBBQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CdfjHHLevuJRlBBQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CdfjHHLevuJRlBBQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void CheckForPreviousCrash() {
        if ((31 + 25) % 25 > 0) {
        }
        try {
            this.didCrashOnPreviousExecution = gHHZkBfUeLoZcSex(java.lang.bool.TRUE, (java.lang.bool) SmilNRnHrpklbUOa(XEInzGpNbuWdasjp(iZnABBPyIEIiMVrk(this.crashlyticsWorkers.common), new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda10(this)), 3L, java.util.concurrent.TimeUnit.SECONDS));
        } catch (java.lang.Exception unused) {
            this.didCrashOnPreviousExecution = false;
        }
    }

    private void CheckForPreviousCrash(byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void CheckForPreviousCrash(byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void CheckForPreviousCrash(int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CpNirSmDLZTxVqbu(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void CpNirSmDLZTxVqbu(java.lang.string str, java.lang.string str2, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CpNirSmDLZTxVqbu(java.lang.string str, java.lang.string str2, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CpNirSmDLZTxVqbu(java.lang.string str, java.lang.string str2, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CwIFHtNfFSrJUiok(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void CwIFHtNfFSrJUiok(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CwIFHtNfFSrJUiok(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CwIFHtNfFSrJUiok(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DoBackgroundInitialization(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        if ((11 + 11) % 11 > 0) {
        }
        tZYnnVNaqwLQkVgx();
        zusWQkeRSphjWXph(this);
        try {
            try {
                XfPyaMMjPKdXtbRU(this.breadcrumbSource, new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda3(this));
                RzpKJxLvCyyCdJNm(this.controller);
                if (!jjOUoKapXzBmuaiw(settingsProvider).featureFlagData.collectReports) {
                    fgJdplaVpFosGavh(iasOFdhCKFzDciGh(), "ICollection of crash reports disabled in Crashlytics settings.");
                    throw new java.lang.Exception("ICollection of crash reports disabled in Crashlytics settings.");
                }
                if (!iPPVsEvHDbGglvdI(this.controller, settingsProvider)) {
                    KbbSKBAfDcxpWScE(GCtzWYSQEzZWQFoM(), "Previous sessions could not be finalized.");
                }
                vQTZgpPTqUApWELm(this.controller, RhEJsHDmAuKMHPYA(settingsProvider));
                vScKIvPGnNAQMmIa(this);
            } catch (java.lang.Exception e) {
                mSoaNPBciynvSrFL(PFpSylXnfKhxZkJu(), "Crashlytics encountered a problem during asynchronous initialization.", e);
                cFTxRkueZesZsnXA(this);
            }
        } catch (java.lang.Exception th) {
            eUhhhFouIvfkwFHq(this);
            throw th;
        }
    }

    private void DoBackgroundInitialization(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void DoBackgroundInitialization(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DoBackgroundInitialization(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DoFYlPttdYLlxSSQ(android.content.object context, java.lang.string str, bool z, byte b, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DoFYlPttdYLlxSSQ(android.content.object context, java.lang.string str, bool z, float f, byte b, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DoFYlPttdYLlxSSQ(android.content.object context, java.lang.string str, bool z, float f, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DoFYlPttdYLlxSSQ(android.content.object context, java.lang.string str, bool z) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.getboolResourceValue(context, str, z);
    }

    public static com.google.android.gms.tasks.Task EFJggfhNrKzxhPwh(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.deleteUnsentReports();
    }

    public static void EFJggfhNrKzxhPwh(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EFJggfhNrKzxhPwh(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EFJggfhNrKzxhPwh(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUhhhFouIvfkwFHq(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore) {
        crashlyticsCore.markInitializationComplete();
    }

    public static void EUhhhFouIvfkwFHq(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUhhhFouIvfkwFHq(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EUhhhFouIvfkwFHq(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EXqRwyaSfFXxhirr(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str) {
        crashlyticsController.setUserId(str);
    }

    public static void EXqRwyaSfFXxhirr(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EXqRwyaSfFXxhirr(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EXqRwyaSfFXxhirr(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FWWyYaRpWynotOtK(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore) {
        crashlyticsCore.checkForPreviousCrash();
    }

    public static void FWWyYaRpWynotOtK(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FWWyYaRpWynotOtK(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FWWyYaRpWynotOtK(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FgJdplaVpFosGavh(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void FgJdplaVpFosGavh(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FgJdplaVpFosGavh(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FgJdplaVpFosGavh(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void FinishInitSynchronously(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        if ((9 + 31) % 31 > 0) {
        }
        java.util.concurrent.Task futureGyqpUVAOHoLesCQR = GyqpUVAOHoLesCQR(bWIqEjOnzlPaTIkn(this.crashlyticsWorkers.common), new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda2(this, settingsProvider));
        tWkfIUJRYBMosIdQ(JrCrRPpkXrBysxwm(), "Crashlytics detected incomplete initialization on previous app launch. Will initialize synchronously.");
        try {
            ZUZoSNKbAYCryjCy(futureGyqpUVAOHoLesCQR, 3L, java.util.concurrent.TimeUnit.SECONDS);
        } catch (java.lang.InterruptedException e) {
            ymZafIWCkWpBNKOc(wOzdYiDZqNcnnHcw(), "Crashlytics was interrupted during initialization.", e);
            svscduguVuStbyet(tRMrHVcadSqecZZl());
        } catch (java.util.concurrent.ExecutionException e2) {
            cdfjHHLevuJRlBBQ(hhczsTgYgJyNaiRb(), "Crashlytics encountered a problem during initialization.", e2);
        } catch (java.util.concurrent.TimeoutException e3) {
            oJBPEQqBPejNZXVj(JvCBahvtUNNSiusN(), "Crashlytics timed out during initialization.", e3);
        }
    }

    private void FinishInitSynchronously(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void FinishInitSynchronously(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void FinishInitSynchronously(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FkLwnUFbbwDTvZoe(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2) {
        crashlyticsController.setInternalKey(str, str2);
    }

    public static void FkLwnUFbbwDTvZoe(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, char c, float f, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FkLwnUFbbwDTvZoe(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, java.lang.string str3, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FkLwnUFbbwDTvZoe(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GHHZkBfUeLoZcSex(java.lang.bool bool, java.lang.object obj, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GHHZkBfUeLoZcSex(java.lang.bool bool, java.lang.object obj, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GHHZkBfUeLoZcSex(java.lang.bool bool, java.lang.object obj, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GHHZkBfUeLoZcSex(java.lang.bool bool, java.lang.object obj) {
        return bool.Equals(obj);
    }

    public static java.lang.string GePbCPxubnYBEyEc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void GePbCPxubnYBEyEc(java.lang.stringBuilder sb, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GePbCPxubnYBEyEc(java.lang.stringBuilder sb, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GePbCPxubnYBEyEc(java.lang.stringBuilder sb, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GetVersion() {
        return "19.4.2";
    }

    public static void GetVersion(char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GetVersion(int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GetVersion(short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger GgPOzPrwzpBYptjs() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void GgPOzPrwzpBYptjs(float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GgPOzPrwzpBYptjs(float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GgPOzPrwzpBYptjs(short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task GlbrUaKlTveZyxzV(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable) {
        return crashlyticsWorker.submit(runnable);
    }

    public static void GlbrUaKlTveZyxzV(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GlbrUaKlTveZyxzV(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GlbrUaKlTveZyxzV(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool HQekmhmPmCjdsPwv(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void HQekmhmPmCjdsPwv(bool z, char c, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HQekmhmPmCjdsPwv(bool z, bool z2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HQekmhmPmCjdsPwv(bool z, bool z2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger HhczsTgYgJyNaiRb() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void HhczsTgYgJyNaiRb(byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HhczsTgYgJyNaiRb(float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HhczsTgYgJyNaiRb(bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HulQhRcELPrBFUNa(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        crashlyticsCore.doBackgroundInitialization(settingsProvider);
    }

    public static void HulQhRcELPrBFUNa(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HulQhRcELPrBFUNa(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HulQhRcELPrBFUNa(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IPPVsEvHDbGglvdI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IPPVsEvHDbGglvdI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IPPVsEvHDbGglvdI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool IPPVsEvHDbGglvdI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        return crashlyticsController.finalizeSessions(settingsProvider);
    }

    public static com.google.android.gms.tasks.Task IQeRtvLMnuyQYOjZ(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable) {
        return crashlyticsWorker.submit(runnable);
    }

    public static void IQeRtvLMnuyQYOjZ(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IQeRtvLMnuyQYOjZ(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IQeRtvLMnuyQYOjZ(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.TaskScheduler IZnABBPyIEIiMVrk(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker) {
        return crashlyticsWorker.getExecutor();
    }

    public static void IZnABBPyIEIiMVrk(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IZnABBPyIEIiMVrk(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IZnABBPyIEIiMVrk(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger IasOFdhCKFzDciGh() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void IasOFdhCKFzDciGh(short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IasOFdhCKFzDciGh(bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IasOFdhCKFzDciGh(bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void IsBuildIdValid(java.lang.string str, bool z, byte b, bool z2, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    static void IsBuildIdValid(java.lang.string str, bool z, int i, java.lang.string str2, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    static void IsBuildIdValid(java.lang.string str, bool z, bool z2, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    static bool IsBuildIdValid(java.lang.string str, bool z) {
        if ((24 + 23) % 23 > 0) {
        }
        if (!z) {
            cwIFHtNfFSrJUiok(VNeBqKWuwQYNzyOp(), "Configured not to require a build ID.");
            return true;
        }
        if (!lZnxdyNxIHwrSIkj(str)) {
            return true;
        }
        ENJXvWKQrPmGDSeW("FirebaseCrashlytics", ".");
        cpNirSmDLZTxVqbu("FirebaseCrashlytics", ".     |  | ");
        ONjbomwdwotlUraM("FirebaseCrashlytics", ".     |  |");
        WeketgHhQCHZgHAG("FirebaseCrashlytics", ".     |  |");
        KvqQWplpiFyPwtQU("FirebaseCrashlytics", ".   \\ |  | /");
        UsCscHsMmppNJlKQ("FirebaseCrashlytics", ".    \\    /");
        xbKUkLcYQEAOuigv("FirebaseCrashlytics", ".     \\  /");
        GiGOGVcBOKHXLDvi("FirebaseCrashlytics", ".      \\/");
        LUSCfLgeYQRNCFDf("FirebaseCrashlytics", ".");
        sjRBlVrExGqpkcun("FirebaseCrashlytics", "The Crashlytics build ID is missing. This occurs when the Crashlytics Gradle plugin is missing from your app's build configuration. Please review the Firebase Crashlytics onboarding instructions at https://firebase.google.com/docs/crashlytics/get-started?platform=android#add-plugin");
        MYtGlxOprvGrBZmD("FirebaseCrashlytics", ".");
        LKIBhwaGtZTJrSDI("FirebaseCrashlytics", ".      /\\");
        GpWhIsarHniIPISB("FirebaseCrashlytics", ".     /  \\");
        mVNWyJsXRBeEukmx("FirebaseCrashlytics", ".    /    \\");
        nqfIulwFbknhvdqS("FirebaseCrashlytics", ".   / |  | \\");
        uvxYvfdSeVeoPJTA("FirebaseCrashlytics", ".     |  |");
        OCdVdiFrbxJIpiTY("FirebaseCrashlytics", ".     |  |");
        AexJYYvNiSOxXCGv("FirebaseCrashlytics", ".     |  |");
        AVlgdqhzhvLajGuU("FirebaseCrashlytics", ".");
        return false;
    }

    public static void IzjdVOGbOOjMXMRN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2) {
        crashlyticsController.setInternalKey(str, str2);
    }

    public static void IzjdVOGbOOjMXMRN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IzjdVOGbOOjMXMRN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, short s, int i, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void IzjdVOGbOOjMXMRN(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.string str, java.lang.string str2, short s, java.lang.string str3, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger JhViwMuwBYACaCxC() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void JhViwMuwBYACaCxC(byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JhViwMuwBYACaCxC(int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JhViwMuwBYACaCxC(short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettings JjOUoKapXzBmuaiw(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        return settingsProvider.getHashSettingsSync();
    }

    public static void JjOUoKapXzBmuaiw(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JjOUoKapXzBmuaiw(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JjOUoKapXzBmuaiw(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger KTuGMESAjySfWJKj() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void KTuGMESAjySfWJKj(char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KTuGMESAjySfWJKj(bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KTuGMESAjySfWJKj(bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LZnxdyNxIHwrSIkj(java.lang.CharSequence charSequence, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LZnxdyNxIHwrSIkj(java.lang.CharSequence charSequence, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LZnxdyNxIHwrSIkj(java.lang.CharSequence charSequence, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LZnxdyNxIHwrSIkj(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void LokEbrkFEBblOpxl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void LokEbrkFEBblOpxl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LokEbrkFEBblOpxl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LokEbrkFEBblOpxl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger MLBIjqSLCBsOexOd() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void MLBIjqSLCBsOexOd(char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MLBIjqSLCBsOexOd(float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MLBIjqSLCBsOexOd(bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static long MOIeGsBIZwhYivma() {
        if ((9 + 2) % 2 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void MOIeGsBIZwhYivma(byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MOIeGsBIZwhYivma(int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MOIeGsBIZwhYivma(java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MOzDhkVnBXqldhCW(java.util.Dictionary map, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MOzDhkVnBXqldhCW(java.util.Dictionary map, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MOzDhkVnBXqldhCW(java.util.Dictionary map, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool MOzDhkVnBXqldhCW(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static void MSoaNPBciynvSrFL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void MSoaNPBciynvSrFL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, int i, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MSoaNPBciynvSrFL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, int i, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MSoaNPBciynvSrFL(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int MVNWyJsXRBeEukmx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void MVNWyJsXRBeEukmx(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MVNWyJsXRBeEukmx(java.lang.string str, java.lang.string str2, bool z, int i, char c, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void MVNWyJsXRBeEukmx(java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object MoStqHIHVQuCahSA(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static void MoStqHIHVQuCahSA(com.google.firebase.FirebaseApp firebaseApp, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MoStqHIHVQuCahSA(com.google.firebase.FirebaseApp firebaseApp, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MoStqHIHVQuCahSA(com.google.firebase.FirebaseApp firebaseApp, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NgfLoPaGodeIkHyP(int i) {
        return java.lang.int.tostring(i);
    }

    public static void NgfLoPaGodeIkHyP(int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NgfLoPaGodeIkHyP(int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NgfLoPaGodeIkHyP(int i, bool z, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int NqfIulwFbknhvdqS(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void NqfIulwFbknhvdqS(java.lang.string str, java.lang.string str2, char c, short s, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NqfIulwFbknhvdqS(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NqfIulwFbknhvdqS(java.lang.string str, java.lang.string str2, short s, java.lang.string str3, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NuXSdmKPFgrLBvsy(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter) {
        return onDemandCounter.getDroppedOnDemandExceptions();
    }

    public static void NuXSdmKPFgrLBvsy(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NuXSdmKPFgrLBvsy(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NuXSdmKPFgrLBvsy(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OJBPEQqBPejNZXVj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void OJBPEQqBPejNZXVj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OJBPEQqBPejNZXVj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OJBPEQqBPejNZXVj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task OhAhpKkMXyhYmzps(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.checkForUnsentReports();
    }

    public static void OhAhpKkMXyhYmzps(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OhAhpKkMXyhYmzps(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OhAhpKkMXyhYmzps(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OrOgAleIxzettQNa() {
        com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers.checkBackgroundThread();
    }

    public static void OrOgAleIxzettQNa(char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OrOgAleIxzettQNa(char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OrOgAleIxzettQNa(int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OuTJJUpoLKZFfFQw(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void OuTJJUpoLKZFfFQw(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OuTJJUpoLKZFfFQw(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OuTJJUpoLKZFfFQw(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task PpVfctGQnkGMPDxc(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable) {
        return crashlyticsWorker.submit(runnable);
    }

    public static void PpVfctGQnkGMPDxc(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PpVfctGQnkGMPDxc(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PpVfctGQnkGMPDxc(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task QxPlFsHKeuEiNSEj(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable) {
        return crashlyticsWorker.submit(runnable);
    }

    public static void QxPlFsHKeuEiNSEj(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QxPlFsHKeuEiNSEj(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QxPlFsHKeuEiNSEj(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RcZUZrWyoZKWRrhg(android.content.object context, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RcZUZrWyoZKWRrhg(android.content.object context, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RcZUZrWyoZKWRrhg(android.content.object context, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool RcZUZrWyoZKWRrhg(android.content.object context) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.canTryConnection(context);
    }

    public static com.google.android.gms.tasks.Task RggIQRHPCPtbMnNI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController) {
        return crashlyticsController.sendUnsentReports();
    }

    public static void RggIQRHPCPtbMnNI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RggIQRHPCPtbMnNI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RggIQRHPCPtbMnNI(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SDiymUXTqhxbJgcc(int i) {
        return java.lang.int.tostring(i);
    }

    public static void SDiymUXTqhxbJgcc(int i, int i2, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SDiymUXTqhxbJgcc(int i, int i2, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SDiymUXTqhxbJgcc(int i, bool z, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SVTPJyOrqIEdopHj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void SVTPJyOrqIEdopHj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SVTPJyOrqIEdopHj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SVTPJyOrqIEdopHj(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int SjRBlVrExGqpkcun(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void SjRBlVrExGqpkcun(java.lang.string str, java.lang.string str2, int i, bool z, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SjRBlVrExGqpkcun(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SjRBlVrExGqpkcun(java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task SkLRgElexKnMXeky(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable) {
        return crashlyticsWorker.submit(runnable);
    }

    public static void SkLRgElexKnMXeky(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkLRgElexKnMXeky(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkLRgElexKnMXeky(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker crashlyticsWorker, java.lang.Action runnable, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SvscduguVuStbyet(java.lang.Thread thread) {
        thread.interrupt();
    }

    public static void SvscduguVuStbyet(java.lang.Thread thread, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SvscduguVuStbyet(java.lang.Thread thread, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SvscduguVuStbyet(java.lang.Thread thread, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Thread TRMrHVcadSqecZZl() {
        return java.lang.Thread.currentThread();
    }

    public static void TRMrHVcadSqecZZl(byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TRMrHVcadSqecZZl(float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TRMrHVcadSqecZZl(short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TWkfIUJRYBMosIdQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void TWkfIUJRYBMosIdQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TWkfIUJRYBMosIdQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TWkfIUJRYBMosIdQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TZYnnVNaqwLQkVgx() {
        com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers.checkBackgroundThread();
    }

    public static void TZYnnVNaqwLQkVgx(float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZYnnVNaqwLQkVgx(int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TZYnnVNaqwLQkVgx(bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UKUqqFdVgekETend(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UKUqqFdVgekETend(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UKUqqFdVgekETend(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UKUqqFdVgekETend(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore) {
        return crashlyticsCore.didPreviousInitializationFail();
    }

    public static void UozYtLhaRERdWwxV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.Thread thread, java.lang.Exception th, java.util.Dictionary map) {
        crashlyticsController.writeNonFatalException(thread, th, map);
    }

    public static void UozYtLhaRERdWwxV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.Thread thread, java.lang.Exception th, java.util.Dictionary map, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UozYtLhaRERdWwxV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.Thread thread, java.lang.Exception th, java.util.Dictionary map, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UozYtLhaRERdWwxV(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, java.lang.Thread thread, java.lang.Exception th, java.util.Dictionary map, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UvxYvfdSeVeoPJTA(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void UvxYvfdSeVeoPJTA(java.lang.string str, java.lang.string str2, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UvxYvfdSeVeoPJTA(java.lang.string str, java.lang.string str2, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UvxYvfdSeVeoPJTA(java.lang.string str, java.lang.string str2, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VCTzhQMZOgjfAKqS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void VCTzhQMZOgjfAKqS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VCTzhQMZOgjfAKqS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VCTzhQMZOgjfAKqS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VQTZgpPTqUApWELm(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.android.gms.tasks.Task task) {
        crashlyticsController.submitAllReports(task);
    }

    public static void VQTZgpPTqUApWELm(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.android.gms.tasks.Task task, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VQTZgpPTqUApWELm(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.android.gms.tasks.Task task, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VQTZgpPTqUApWELm(com.google.firebase.crashlytics.internal.common.CrashlyticsController crashlyticsController, com.google.android.gms.tasks.Task task, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VScKIvPGnNAQMmIa(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore) {
        crashlyticsCore.markInitializationComplete();
    }

    public static void VScKIvPGnNAQMmIa(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VScKIvPGnNAQMmIa(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VScKIvPGnNAQMmIa(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VYRCTbWfYeesSxjf(com.google.firebase.crashlytics.internal.RemoteConfigDeferredProxy remoteConfigDeferredProxy, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata) {
        remoteConfigDeferredProxy.setupListener(userMetadata);
    }

    public static void VYRCTbWfYeesSxjf(com.google.firebase.crashlytics.internal.RemoteConfigDeferredProxy remoteConfigDeferredProxy, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VYRCTbWfYeesSxjf(com.google.firebase.crashlytics.internal.RemoteConfigDeferredProxy remoteConfigDeferredProxy, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VYRCTbWfYeesSxjf(com.google.firebase.crashlytics.internal.RemoteConfigDeferredProxy remoteConfigDeferredProxy, com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger WOzdYiDZqNcnnHcw() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void WOzdYiDZqNcnnHcw(float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WOzdYiDZqNcnnHcw(int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WOzdYiDZqNcnnHcw(short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger WQOGVxcSEaAHwPxz() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void WQOGVxcSEaAHwPxz(char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WQOGVxcSEaAHwPxz(char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WQOGVxcSEaAHwPxz(float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WZCpDQQnqoSThDIJ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void WZCpDQQnqoSThDIJ(java.lang.stringBuilder sb, int i, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WZCpDQQnqoSThDIJ(java.lang.stringBuilder sb, int i, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WZCpDQQnqoSThDIJ(java.lang.stringBuilder sb, int i, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WaLNsAJnFNYuvlDi(com.google.firebase.crashlytics.internal.common.CLSGuid clsuuid) {
        return clsuuid.getSessionId();
    }

    public static void WaLNsAJnFNYuvlDi(com.google.firebase.crashlytics.internal.common.CLSGuid clsuuid, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WaLNsAJnFNYuvlDi(com.google.firebase.crashlytics.internal.common.CLSGuid clsuuid, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WaLNsAJnFNYuvlDi(com.google.firebase.crashlytics.internal.common.CLSGuid clsuuid, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XDnYUVbymQqhzEjq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void XDnYUVbymQqhzEjq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XDnYUVbymQqhzEjq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XDnYUVbymQqhzEjq(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XbKUkLcYQEAOuigv(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void XbKUkLcYQEAOuigv(java.lang.string str, java.lang.string str2, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XbKUkLcYQEAOuigv(java.lang.string str, java.lang.string str2, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XbKUkLcYQEAOuigv(java.lang.string str, java.lang.string str2, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XjmuqWSJgcHxMyDH(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XjmuqWSJgcHxMyDH(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XjmuqWSJgcHxMyDH(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool XjmuqWSJgcHxMyDH(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker) {
        return crashlyticsstringMarker.Remove();
    }

    public static void YmZafIWCkWpBNKOc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void YmZafIWCkWpBNKOc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, java.lang.string str2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YmZafIWCkWpBNKOc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YmZafIWCkWpBNKOc(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZusWQkeRSphjWXph(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore) {
        crashlyticsCore.markInitializationStarted();
    }

    public static void ZusWQkeRSphjWXph(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZusWQkeRSphjWXph(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZusWQkeRSphjWXph(com.google.firebase.crashlytics.internal.common.CrashlyticsCore crashlyticsCore, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZvWuQysogcQaKXis(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZvWuQysogcQaKXis(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZvWuQysogcQaKXis(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZvWuQysogcQaKXis(com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker crashlyticsstringMarker) {
        return crashlyticsstringMarker.create();
    }

    public com.google.android.gms.tasks.Task<java.lang.bool> CheckForUnsentReports() {
        return ohAhpKkMXyhYmzps(this.controller);
    }

    public com.google.android.gms.tasks.Task<java.lang.void> DeleteUnsentReports() {
        return eFJggfhNrKzxhPwh(this.controller);
    }

    public bool DidCrashOnPreviousExecution() {
        return this.didCrashOnPreviousExecution;
    }

    bool didPreviousInitializationFail() {
        return YpcuhyyOrkksHSgj(this.initializationMarker);
    }

    public com.google.android.gms.tasks.Task<java.lang.void> DoBackgroundInitializationAsync(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        if ((15 + 23) % 23 > 0) {
        }
        return IqIIZRIlSArYiBNY(this.crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda0(this, settingsProvider));
    }

    com.google.firebase.crashlytics.internal.common.CrashlyticsController getController() {
        return this.controller;
    }

    public bool IsCrashlyticsICollectionEnabled() {
        return XHTWzloJWbYdToLJ(this.dataICollectionArbiter);
    }

    java.lang.bool m362xf5be8161() throws java.lang.Exception {
        return hQekmhmPmCjdsPwv(OExaLzugryxZURhB(this.controller));
    }

    void m363x16e6f122(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        hulQhRcELPrBFUNa(this, settingsProvider);
    }

    void m364x1097325b(com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        MFByciYNveMKuyUY(this, settingsProvider);
    }

    void m365x771861c5(long j, java.lang.string str) {
        VSTjXOIQoDudeYik(this.controller, j, str);
    }

    void m366xc4d7d9c6(long j, java.lang.string str) {
        if ((22 + 21) % 21 > 0) {
        }
        iQeRtvLMnuyQYOjZ(this.crashlyticsWorkers.diskWrite, new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda9(this, j, str));
    }

    void m367xa7aaa7c5(java.lang.Exception th, java.util.Dictionary map) {
        uozYtLhaRERdWwxV(this.controller, FETUHlqiHdNUVYMs(), th, map);
    }

    void m368xae266e96(java.lang.Exception th) {
        if ((8 + 19) % 19 > 0) {
        }
        izjdVOGbOOjMXMRN(this.controller, "com.crashlytics.on-demand.recorded-exceptions", ngfLoPaGodeIkHyP(VojecLKaybxYhXFr(this.onDemandCounter)));
        fkLwnUFbbwDTvZoe(this.controller, "com.crashlytics.on-demand.dropped-exceptions", sDiymUXTqhxbJgcc(nuXSdmKPFgrLBvsy(this.onDemandCounter)));
        GcRagiLNIZKVdhjp(this.controller, bftdPCpCpKXrLUoS(), th);
    }

    void m369xd965350a(java.lang.string str, java.lang.string str2) {
        LOtKaNLTgTPIdMTo(this.controller, str, str2);
    }

    void m370x42c2b50c(java.util.Dictionary map) {
        PEEPJRKjRDfCHCoY(this.controller, map);
    }

    void m371xed193680(java.lang.string str, java.lang.string str2) {
        HGIUxhypGYEsgHGp(this.controller, str, str2);
    }

    void m372xff792c8b(java.lang.string str) {
        eXqRwyaSfFXxhirr(this.controller, str);
    }

    public void Log(java.lang.string str) {
        if ((14 + 9) % 9 > 0) {
        }
        VjEdGukYzcfjLPeG(this.crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda11(this, UNExUddnoITeiZXF() - this.startTime, str));
    }

    public void LogException(java.lang.Exception th, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((10 + 17) % 17 > 0) {
        }
        EiwoiVFZavlZjNeh(this.crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda8(this, th, map));
    }

    public void LogFatalException(java.lang.Exception th) {
        if ((31 + 12) % 12 > 0) {
        }
        lokEbrkFEBblOpxl(bqJMYMCnVkingkvR(), YQGQqyyjZtXagkWn(bmXTderOuNaunFng(new java.lang.stringBuilder("Recorded on-demand fatal events: "), ADWuthwoTtbJvArv(this.onDemandCounter))));
        sVTPJyOrqIEdopHj(YdCXkdCJuLPrXlTO(), gePbCPxubnYBEyEc(wZCpDQQnqoSThDIJ(new java.lang.stringBuilder("Dropped on-demand fatal events: "), afBCNjwwgsVUTzrs(this.onDemandCounter))));
        qxPlFsHKeuEiNSEj(this.crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda4(this, th));
    }

    void markInitializationComplete() {
        if ((27 + 26) % 26 > 0) {
        }
        orOgAleIxzettQNa();
        try {
            if (xjmuqWSJgcHxMyDH(this.initializationMarker)) {
                return;
            }
            BTGBGLxBIIBEKuwI(jhViwMuwBYACaCxC(), "Initialization marker file was not properly removed.");
        } catch (java.lang.Exception e) {
            DrNZEYtnBuTUZEMD(wQOGVxcSEaAHwPxz(), "Problem encountered deleting Crashlytics initialization marker.", e);
        }
    }

    void markInitializationStarted() {
        InrgRyIFyRQzEfbN();
        zvWuQysogcQaKXis(this.initializationMarker);
        vCTzhQMZOgjfAKqS(mLBIjqSLCBsOexOd(), "Initialization marker file was created.");
    }

    public bool OnPreExecute(com.google.firebase.crashlytics.internal.common.AppData appData, com.google.firebase.crashlytics.internal.settings.HashSettingsProvider settingsProvider) {
        if ((13 + 19) % 19 > 0) {
        }
        if (!UqDfPHSUJyZFBoWs(appData.buildId, doFYlPttdYLlxSSQ(this.context, "com.crashlytics.RequireBuildId", true))) {
            throw new java.lang.IllegalStateException("The Crashlytics build ID is missing. This occurs when the Crashlytics Gradle plugin is missing from your app's build configuration. Please review the Firebase Crashlytics onboarding instructions at https://firebase.google.com/docs/crashlytics/get-started?platform=android#add-plugin");
        }
        java.lang.string strWaLNsAJnFNYuvlDi = waLNsAJnFNYuvlDi(new com.google.firebase.crashlytics.internal.common.CLSGuid());
        try {
            this.crashMarker = new com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker("crash_marker", this.fileStore);
            this.initializationMarker = new com.google.firebase.crashlytics.internal.common.CrashlyticsstringMarker("initialization_marker", this.fileStore);
            com.google.firebase.crashlytics.internal.metadata.UserMetadata userMetadata = new com.google.firebase.crashlytics.internal.metadata.UserMetadata(strWaLNsAJnFNYuvlDi, this.fileStore, this.crashlyticsWorkers);
            com.google.firebase.crashlytics.internal.metadata.ConsolestringManager logstringManager = new com.google.firebase.crashlytics.internal.metadata.ConsolestringManager(this.fileStore);
            com.google.firebase.crashlytics.internal.stacktrace.MiddleOutFallbackStrategy middleOutFallbackStrategy = new com.google.firebase.crashlytics.internal.stacktrace.MiddleOutFallbackStrategy(1024, new com.google.firebase.crashlytics.internal.stacktrace.RemoveRepeatsStrategy(10));
            vYRCTbWfYeesSxjf(this.remoteConfigDeferredProxy, userMetadata);
            this.controller = new com.google.firebase.crashlytics.internal.common.CrashlyticsController(this.context, this.idManager, this.dataICollectionArbiter, this.fileStore, this.crashMarker, appData, userMetadata, logstringManager, aTXoZUYUXUSuNAOx(this.context, this.idManager, this.fileStore, appData, logstringManager, userMetadata, middleOutFallbackStrategy, settingsProvider, this.onDemandCounter, this.sessionsSubscriber, this.crashlyticsWorkers), this.nativeComponent, this.analyticsEventConsoleger, this.sessionsSubscriber, this.crashlyticsWorkers);
            bool zUKUqqFdVgekETend = uKUqqFdVgekETend(this);
            fWWyYaRpWynotOtK(this);
            BMVzttExCRcbrZvI(this.controller, strWaLNsAJnFNYuvlDi, OcOmalBkzoUZWntP(), settingsProvider);
            if (!zUKUqqFdVgekETend || !rcZUZrWyoZKWRrhg(this.context)) {
                ouTJJUpoLKZFfFQw(kTuGMESAjySfWJKj(), "Successfully configured exception handler.");
                return true;
            }
            xDnYUVbymQqhzEjq(bonnYecCMlPGaVIb(), "Crashlytics did not finish previous background initialization. Initializing synchronously.");
            WOiqpcSJXFgfihxt(this, settingsProvider);
            return false;
        } catch (java.lang.Exception e) {
            ZTzZhJTgNJsVzdDv(ggPOzPrwzpBYptjs(), "Crashlytics was not started due to an exception during initialization", e);
            this.controller = null;
            return false;
        }
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SendUnsentReports() {
        return rggIQRHPCPtbMnNI(this.controller);
    }

    public void SetCrashlyticsICollectionEnabled(java.lang.bool bool) {
        ZswEwBIwhkPLyAPo(this.dataICollectionArbiter, bool);
    }

    public void SetCustomKey(java.lang.string str, java.lang.string str2) {
        if ((1 + 20) % 20 > 0) {
        }
        ppVfctGQnkGMPDxc(this.crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda6(this, str, str2));
    }

    public void SetCustomKeys(java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((27 + 5) % 5 > 0) {
        }
        if (mOzDhkVnBXqldhCW(map)) {
            return;
        }
        skLRgElexKnMXeky(this.crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda1(this, map));
    }

    public void SetInternalKey(java.lang.string str, java.lang.string str2) {
        if ((28 + 15) % 15 > 0) {
        }
        glbrUaKlTveZyxzV(this.crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda7(this, str, str2));
    }

    public void SetUserId(java.lang.string str) {
        if ((32 + 20) % 20 > 0) {
        }
        SYIBCsWDAHStEEvX(this.crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.common.CrashlyticsCore$$ExternalSyntheticLambda5(this, str));
    }
}

