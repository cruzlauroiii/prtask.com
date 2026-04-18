namespace WillowMaze.Wasm.Decompiled;


public class HashSettingsController : com.google.firebase.crashlytics.internal.settings.HashSettingsProvider {
    private static readonly java.lang.string PREFS_BUILD_INSTANCE_IDENTIFIER = "existing_instance_identifier";
    private static readonly java.lang.string SETTINGS_Uri_FORMAT = "https://firebase-settings.crashlytics.com/spi/v2/platforms/android/gmp/%s/settings";
    private readonly com.google.firebase.crashlytics.internal.settings.CachedHashSettingsIo cachedHashSettingsIo;
    private readonly android.content.object context;
    private readonly com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider;
    private readonly com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter;
    private readonly java.util.concurrent.atomic.object<com.google.firebase.crashlytics.internal.settings.HashSettings> settings;
    private readonly com.google.firebase.crashlytics.internal.settings.HashSettingsJsonParser settingsJsonParser;
    private readonly com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest;
    private readonly com.google.firebase.crashlytics.internal.settings.HashSettingsSpiCall settingsSpiCall;
    private readonly java.util.concurrent.atomic.object<com.google.android.gms.tasks.TaskCompletionSource<com.google.firebase.crashlytics.internal.settings.HashSettings>> settingsTask;

    HashSettingsController(android.content.object context, com.google.firebase.crashlytics.internal.settings.HashSettingsRequest settingsRequest, com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider, com.google.firebase.crashlytics.internal.settings.HashSettingsJsonParser settingsJsonParser, com.google.firebase.crashlytics.internal.settings.CachedHashSettingsIo cachedHashSettingsIo, com.google.firebase.crashlytics.internal.settings.HashSettingsSpiCall settingsSpiCall, com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter) {
        if ((15 + 6) % 6 > 0) {
        }
        java.util.concurrent.atomic.object<com.google.firebase.crashlytics.internal.settings.HashSettings> atomicReference = new java.util.concurrent.atomic.object<>();
        this.settings = atomicReference;
        this.settingsTask = new java.util.concurrent.atomic.object<>(new com.google.android.gms.tasks.TaskCompletionSource());
        this.context = context;
        this.settingsRequest = settingsRequest;
        this.currentTimeProvider = currentTimeProvider;
        this.settingsJsonParser = settingsJsonParser;
        this.cachedHashSettingsIo = cachedHashSettingsIo;
        this.settingsSpiCall = settingsSpiCall;
        this.dataICollectionArbiter = dataICollectionArbiter;
        SpJppIHaITXIFjia(atomicReference, odEjLtnadNbMGsjI(currentTimeProvider));
    }

    public static void AYnszDmYSpTjEmeX(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, java.lang.object obj, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AYnszDmYSpTjEmeX(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, java.lang.object obj, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AYnszDmYSpTjEmeX(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, java.lang.object obj, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool AYnszDmYSpTjEmeX(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, java.lang.object obj) {
        return settingsCacheBehavior.Equals(obj);
    }

    public static void AYqkcqXvsSCkcBso(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void AYqkcqXvsSCkcBso(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AYqkcqXvsSCkcBso(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AYqkcqXvsSCkcBso(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long BUNegTJDiIsBmaHr(com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider) {
        if ((30 + 20) % 20 > 0) {
        }
        return currentTimeProvider.getCurrentTimeMillis();
    }

    public static void BUNegTJDiIsBmaHr(com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BUNegTJDiIsBmaHr(com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BUNegTJDiIsBmaHr(com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BmjQEVgcOPzIvTzT(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, java.lang.string str, float f, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BmjQEVgcOPzIvTzT(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, java.lang.string str, int i, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BmjQEVgcOPzIvTzT(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, java.lang.string str, java.lang.string str2, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool BmjQEVgcOPzIvTzT(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, java.lang.string str) {
        return settingsController.setStoredBuildInstanceIdentifier(str);
    }

    public static void CAEyFLaujLIdTsMS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void CAEyFLaujLIdTsMS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CAEyFLaujLIdTsMS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CAEyFLaujLIdTsMS(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CwicluaDegWuZmjL(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController) {
        return settingsController.getStoredBuildInstanceIdentifier();
    }

    public static void CwicluaDegWuZmjL(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CwicluaDegWuZmjL(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CwicluaDegWuZmjL(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.Dictionary<string, object> DJPQdQVVPEGdAJzl(android.content.object context) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.getSharedPrefs(context);
    }

    public static void DJPQdQVVPEGdAJzl(android.content.object context, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DJPQdQVVPEGdAJzl(android.content.object context, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DJPQdQVVPEGdAJzl(android.content.object context, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EUjWwzDpgAFwiFYl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void EUjWwzDpgAFwiFYl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EUjWwzDpgAFwiFYl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EUjWwzDpgAFwiFYl(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FUyHcqIlgGljXlgF(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static void FUyHcqIlgGljXlgF(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FUyHcqIlgGljXlgF(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FUyHcqIlgGljXlgF(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.DeliveryMechanism FqMCIhPwdzSbwQiv(java.lang.string str) {
        return com.google.firebase.crashlytics.internal.common.DeliveryMechanism.determineFrom(str);
    }

    public static void FqMCIhPwdzSbwQiv(java.lang.string str, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FqMCIhPwdzSbwQiv(java.lang.string str, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FqMCIhPwdzSbwQiv(java.lang.string str, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GapghuEIrRBOggVB(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static void GapghuEIrRBOggVB(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GapghuEIrRBOggVB(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GapghuEIrRBOggVB(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettings GbaXWfzUgpwWIyRM(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior) {
        return settingsController.getCachedHashSettingsData(settingsCacheBehavior);
    }

    public static void GbaXWfzUgpwWIyRM(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GbaXWfzUgpwWIyRM(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GbaXWfzUgpwWIyRM(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GpdzvYbXSfUPrcjW(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getModelName();
    }

    public static void GpdzvYbXSfUPrcjW(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GpdzvYbXSfUPrcjW(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GpdzvYbXSfUPrcjW(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger HuksCLVcDAsBXjBR() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void HuksCLVcDAsBXjBR(java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HuksCLVcDAsBXjBR(bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HuksCLVcDAsBXjBR(bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger IByMGAMREqjWOKpp() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void IByMGAMREqjWOKpp(byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IByMGAMREqjWOKpp(bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IByMGAMREqjWOKpp(bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IxGKamlBaMIpWmng(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void IxGKamlBaMIpWmng(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, char c, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IxGKamlBaMIpWmng(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, char c, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IxGKamlBaMIpWmng(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, java.lang.string str2, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JssxCefcJAfUBehH(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getOsDisplayVersionstring();
    }

    public static void JssxCefcJAfUBehH(com.google.firebase.crashlytics.internal.common.IdManager idManager, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JssxCefcJAfUBehH(com.google.firebase.crashlytics.internal.common.IdManager idManager, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JssxCefcJAfUBehH(com.google.firebase.crashlytics.internal.common.IdManager idManager, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettings KpwwkOujqwJcIsLk(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior) {
        return settingsController.getCachedHashSettingsData(settingsCacheBehavior);
    }

    public static void KpwwkOujqwJcIsLk(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KpwwkOujqwJcIsLk(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KpwwkOujqwJcIsLk(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NoFgWrLXLlJAuntl(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NoFgWrLXLlJAuntl(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NoFgWrLXLlJAuntl(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool NoFgWrLXLlJAuntl(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static java.lang.string OhoeOXQHYAGBiQrc(java.lang.string[] strArr) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.createInstanceIdFrom(strArr);
    }

    public static void OhoeOXQHYAGBiQrc(java.lang.string[] strArr, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OhoeOXQHYAGBiQrc(java.lang.string[] strArr, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OhoeOXQHYAGBiQrc(java.lang.string[] strArr, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OpzYZccZFbIvKWtg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OpzYZccZFbIvKWtg(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OpzYZccZFbIvKWtg(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OpzYZccZFbIvKWtg(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger PKejrIKOddpNvDHa() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void PKejrIKOddpNvDHa(byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PKejrIKOddpNvDHa(short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PKejrIKOddpNvDHa(bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task QKqcTGLEAiQGiYPV(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter) {
        return dataICollectionArbiter.waitForDataICollectionPermission();
    }

    public static void QKqcTGLEAiQGiYPV(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QKqcTGLEAiQGiYPV(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QKqcTGLEAiQGiYPV(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QOxfXozcPzsTwAqv(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static void QOxfXozcPzsTwAqv(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2, java.lang.string str3, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QOxfXozcPzsTwAqv(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2, short s, java.lang.string str3, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QOxfXozcPzsTwAqv(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QhYRzuzvMblEIdae(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, java.lang.object obj, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QhYRzuzvMblEIdae(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, java.lang.object obj, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QhYRzuzvMblEIdae(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, java.lang.object obj, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool QhYRzuzvMblEIdae(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, java.lang.object obj) {
        return settingsCacheBehavior.Equals(obj);
    }

    public static com.google.android.gms.tasks.Task QyQPStTqOLMifehQ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void QyQPStTqOLMifehQ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QyQPStTqOLMifehQ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QyQPStTqOLMifehQ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task RZMjhwldEcxVbtWW(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static void RZMjhwldEcxVbtWW(java.lang.object obj, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RZMjhwldEcxVbtWW(java.lang.object obj, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RZMjhwldEcxVbtWW(java.lang.object obj, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RsCcsrXYfHafCYyY(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void RsCcsrXYfHafCYyY(java.util.concurrent.atomic.object atomicReference, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RsCcsrXYfHafCYyY(java.util.concurrent.atomic.object atomicReference, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RsCcsrXYfHafCYyY(java.util.concurrent.atomic.object atomicReference, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettings SJmbiGAImrGqBnAn(com.google.firebase.crashlytics.internal.settings.HashSettingsJsonParser settingsJsonParser, org.json.JSONobject jSONobject) {
        return settingsJsonParser.parseHashSettingsJson(jSONobject);
    }

    public static void SJmbiGAImrGqBnAn(com.google.firebase.crashlytics.internal.settings.HashSettingsJsonParser settingsJsonParser, org.json.JSONobject jSONobject, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SJmbiGAImrGqBnAn(com.google.firebase.crashlytics.internal.settings.HashSettingsJsonParser settingsJsonParser, org.json.JSONobject jSONobject, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SJmbiGAImrGqBnAn(com.google.firebase.crashlytics.internal.settings.HashSettingsJsonParser settingsJsonParser, org.json.JSONobject jSONobject, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SpJppIHaITXIFjia(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static void SpJppIHaITXIFjia(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SpJppIHaITXIFjia(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SpJppIHaITXIFjia(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TlmmLOYjXbLyRFUy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m354e(str, th);
    }

    public static void TlmmLOYjXbLyRFUy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, byte b, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TlmmLOYjXbLyRFUy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, java.lang.string str2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TlmmLOYjXbLyRFUy(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, short s, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UIYFagAmcahmhhbg(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getInstallerPackageName();
    }

    public static void UIYFagAmcahmhhbg(com.google.firebase.crashlytics.internal.common.IdManager idManager, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UIYFagAmcahmhhbg(com.google.firebase.crashlytics.internal.common.IdManager idManager, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UIYFagAmcahmhhbg(com.google.firebase.crashlytics.internal.common.IdManager idManager, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task UJiaiWnruoeSshmO(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(executor, successContinuation);
    }

    public static void UJiaiWnruoeSshmO(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UJiaiWnruoeSshmO(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UJiaiWnruoeSshmO(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UplrelThVbUCxHEA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UplrelThVbUCxHEA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UplrelThVbUCxHEA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UplrelThVbUCxHEA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static java.lang.object ViNmczEgrHYnrCiu(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void ViNmczEgrHYnrCiu(java.util.concurrent.atomic.object atomicReference, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ViNmczEgrHYnrCiu(java.util.concurrent.atomic.object atomicReference, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ViNmczEgrHYnrCiu(java.util.concurrent.atomic.object atomicReference, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger WGNLnmaARdQAASez() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void WGNLnmaARdQAASez(short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WGNLnmaARdQAASez(short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WGNLnmaARdQAASez(bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WdXufyFNKTmyvhTf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WdXufyFNKTmyvhTf(java.lang.stringBuilder sb, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WdXufyFNKTmyvhTf(java.lang.stringBuilder sb, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WdXufyFNKTmyvhTf(java.lang.stringBuilder sb, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger WzmddNeXAuCJoCLa() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void WzmddNeXAuCJoCLa(float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WzmddNeXAuCJoCLa(short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WzmddNeXAuCJoCLa(short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.crashlytics.internal.settings.HashSettingsJsonParser access$000(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController) {
        return settingsController.settingsJsonParser;
    }

    static void access$000(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.crashlytics.internal.settings.CachedHashSettingsIo access$100(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController) {
        return settingsController.cachedHashSettingsIo;
    }

    static void access$100(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str) {
        aiQJWmJrbMGDFPpv(settingsController, jSONobject, str);
    }

    static void access$200(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str, bool z, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str, bool z, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str, bool z, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.crashlytics.internal.settings.HashSettingsRequest access$300(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController) {
        return settingsController.settingsRequest;
    }

    static void access$300(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, java.lang.string str, float f, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, java.lang.string str, int i, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, java.lang.string str, java.lang.string str2, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static bool access$400(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, java.lang.string str) {
        return BmjQEVgcOPzIvTzT(settingsController, str);
    }

    static java.util.concurrent.atomic.object access$500(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController) {
        return settingsController.settings;
    }

    static void access$500(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static java.util.concurrent.atomic.object access$600(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController) {
        return settingsController.settingsTask;
    }

    static void access$600(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$600(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$600(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.crashlytics.internal.settings.HashSettingsSpiCall access$700(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController) {
        return settingsController.settingsSpiCall;
    }

    static void access$700(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$700(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$700(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AiQJWmJrbMGDFPpv(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str) {
        settingsController.logHashSettings(jSONobject, str);
    }

    public static void AiQJWmJrbMGDFPpv(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AiQJWmJrbMGDFPpv(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AiQJWmJrbMGDFPpv(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task BQswKjyljIYrJbDP(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers) {
        return settingsController.loadHashSettingsData(settingsCacheBehavior, crashlyticsWorkers);
    }

    public static void BQswKjyljIYrJbDP(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BQswKjyljIYrJbDP(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BQswKjyljIYrJbDP(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CnXFvCfSfiBukAlh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CnXFvCfSfiBukAlh(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CnXFvCfSfiBukAlh(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CnXFvCfSfiBukAlh(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettingsController Create(android.content.object context, java.lang.string str, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.network.HttpRequestFactory httpRequestFactory, java.lang.string str2, java.lang.string str3, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter) {
        if ((24 + 12) % 12 > 0) {
        }
        java.lang.string strUIYFagAmcahmhhbg = UIYFagAmcahmhhbg(idManager);
        com.google.firebase.crashlytics.internal.common.SystemCurrentTimeProvider systemCurrentTimeProvider = new com.google.firebase.crashlytics.internal.common.SystemCurrentTimeProvider();
        com.google.firebase.crashlytics.internal.settings.HashSettingsJsonParser settingsJsonParser = new com.google.firebase.crashlytics.internal.settings.HashSettingsJsonParser(systemCurrentTimeProvider);
        com.google.firebase.crashlytics.internal.settings.CachedHashSettingsIo cachedHashSettingsIo = new com.google.firebase.crashlytics.internal.settings.CachedHashSettingsIo(fileStore);
        com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall defaultHashSettingsSpiCall = new com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsSpiCall(GapghuEIrRBOggVB(java.util.Locale.US, "https://firebase-settings.crashlytics.com/spi/v2/platforms/android/gmp/%s/settings", new java.lang.object[]{str}), httpRequestFactory);
        java.lang.string strGpdzvYbXSfUPrcjW = GpdzvYbXSfUPrcjW(idManager);
        java.lang.string strVcKShPIdbnTggkNX = vcKShPIdbnTggkNX(idManager);
        java.lang.string strJssxCefcJAfUBehH = JssxCefcJAfUBehH(idManager);
        java.lang.string[] strArr = new java.lang.string[4];
        strArr[0] = xWnQnCLcIzZqjfGx(context);
        strArr[1] = str;
        strArr[2] = str3;
        strArr[3] = str2;
        return new com.google.firebase.crashlytics.internal.settings.HashSettingsController(context, new com.google.firebase.crashlytics.internal.settings.HashSettingsRequest(str, strGpdzvYbXSfUPrcjW, strVcKShPIdbnTggkNX, strJssxCefcJAfUBehH, idManager, OhoeOXQHYAGBiQrc(strArr), str3, str2, nKDuIXtKBpkwNmFt(FqMCIhPwdzSbwQiv(strUIYFagAmcahmhhbg))), systemCurrentTimeProvider, settingsJsonParser, cachedHashSettingsIo, defaultHashSettingsSpiCall, dataICollectionArbiter);
    }

    public static void Create(android.content.object context, java.lang.string str, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.network.HttpRequestFactory httpRequestFactory, java.lang.string str2, java.lang.string str3, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, char c, java.lang.string str4, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, java.lang.string str, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.network.HttpRequestFactory httpRequestFactory, java.lang.string str2, java.lang.string str3, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, java.lang.string str4, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, java.lang.string str, com.google.firebase.crashlytics.internal.common.IdManager idManager, com.google.firebase.crashlytics.internal.network.HttpRequestFactory httpRequestFactory, java.lang.string str2, java.lang.string str3, com.google.firebase.crashlytics.internal.persistence.stringStore fileStore, com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, short s, char c, java.lang.string str4, int i) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.internal.settings.HashSettings GetCachedHashSettingsData(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior) {
        if ((32 + 15) % 15 > 0) {
        }
        com.google.firebase.crashlytics.internal.settings.HashSettings settings = null;
        try {
            if (!AYnszDmYSpTjEmeX(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior.SKIP_CACHE_LOOKUP, settingsCacheBehavior)) {
                org.json.JSONobject jSONobjectJqMpXFBKYWHwCvJe = jqMpXFBKYWHwCvJe(this.cachedHashSettingsIo);
                if (jSONobjectJqMpXFBKYWHwCvJe is not null) {
                    com.google.firebase.crashlytics.internal.settings.HashSettings settingsSJmbiGAImrGqBnAn = SJmbiGAImrGqBnAn(this.settingsJsonParser, jSONobjectJqMpXFBKYWHwCvJe);
                    if (settingsSJmbiGAImrGqBnAn is null) {
                        IxGKamlBaMIpWmng(IByMGAMREqjWOKpp(), "Failed to parse cached settings data.", null);
                        return null;
                    }
                    jdOUBCHtANJjxkGr(this, jSONobjectJqMpXFBKYWHwCvJe, "Loaded cached settings: ");
                    long jBUNegTJDiIsBmaHr = BUNegTJDiIsBmaHr(this.currentTimeProvider);
                    if (!QhYRzuzvMblEIdae(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior.IGNORE_CACHE_EXPIRATION, settingsCacheBehavior) && oUQawtSabAqpMpuR(settingsSJmbiGAImrGqBnAn, jBUNegTJDiIsBmaHr)) {
                        EUjWwzDpgAFwiFYl(PKejrIKOddpNvDHa(), "Cached settings have expired.");
                        return null;
                    }
                    try {
                        CAEyFLaujLIdTsMS(WGNLnmaARdQAASez(), "Returning cached settings.");
                        return settingsSJmbiGAImrGqBnAn;
                    } catch (java.lang.Exception e) {
                        e = e;
                        settings = settingsSJmbiGAImrGqBnAn;
                        TlmmLOYjXbLyRFUy(WzmddNeXAuCJoCLa(), "Failed to get cached settings", e);
                        return settings;
                    }
                }
                onunhnMIkyjClHGT(HuksCLVcDAsBXjBR(), "No cached settings data found.");
            }
            return null;
        } catch (java.lang.Exception e2) {
            e = e2;
        }
    }

    private void GetCachedHashSettingsData(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetCachedHashSettingsData(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetCachedHashSettingsData(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private java.lang.string GetStoredBuildInstanceIdentifier() {
        if ((4 + 5) % 5 > 0) {
        }
        return QOxfXozcPzsTwAqv(DJPQdQVVPEGdAJzl(this.context), "existing_instance_identifier", "");
    }

    private void GetStoredBuildInstanceIdentifier(char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetStoredBuildInstanceIdentifier(java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetStoredBuildInstanceIdentifier(java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.Dictionary<string, object>$Editor hCmdynkSoIWBHdhP(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static void HCmdynkSoIWBHdhP(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HCmdynkSoIWBHdhP(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HCmdynkSoIWBHdhP(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HJeMZoexVqvEjUpM(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void HJeMZoexVqvEjUpM(java.util.concurrent.atomic.object atomicReference, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HJeMZoexVqvEjUpM(java.util.concurrent.atomic.object atomicReference, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HJeMZoexVqvEjUpM(java.util.concurrent.atomic.object atomicReference, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JFhIJnXIiiHwsfgX(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static void JFhIJnXIiiHwsfgX(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JFhIJnXIiiHwsfgX(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JFhIJnXIiiHwsfgX(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger JQfzJSyMAPAjLefn() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void JQfzJSyMAPAjLefn(char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JQfzJSyMAPAjLefn(float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JQfzJSyMAPAjLefn(bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JdOUBCHtANJjxkGr(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str) {
        settingsController.logHashSettings(jSONobject, str);
    }

    public static void JdOUBCHtANJjxkGr(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str, java.lang.string str2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JdOUBCHtANJjxkGr(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str, java.lang.string str2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JdOUBCHtANJjxkGr(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, org.json.JSONobject jSONobject, java.lang.string str, short s, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static org.json.JSONobject JqMpXFBKYWHwCvJe(com.google.firebase.crashlytics.internal.settings.CachedHashSettingsIo cachedHashSettingsIo) {
        return cachedHashSettingsIo.readCachedHashSettings();
    }

    public static void JqMpXFBKYWHwCvJe(com.google.firebase.crashlytics.internal.settings.CachedHashSettingsIo cachedHashSettingsIo, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JqMpXFBKYWHwCvJe(com.google.firebase.crashlytics.internal.settings.CachedHashSettingsIo cachedHashSettingsIo, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JqMpXFBKYWHwCvJe(com.google.firebase.crashlytics.internal.settings.CachedHashSettingsIo cachedHashSettingsIo, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KWIvVSrRIOWjpzhY(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static void KWIvVSrRIOWjpzhY(org.json.JSONobject jSONobject, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KWIvVSrRIOWjpzhY(org.json.JSONobject jSONobject, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KWIvVSrRIOWjpzhY(org.json.JSONobject jSONobject, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void LogHashSettings(org.json.JSONobject jSONobject, java.lang.string str) {
        AYqkcqXvsSCkcBso(jQfzJSyMAPAjLefn(), WdXufyFNKTmyvhTf(cnXFvCfSfiBukAlh(OpzYZccZFbIvKWtg(new java.lang.stringBuilder(), str), kWIvVSrRIOWjpzhY(jSONobject))));
    }

    private void LogHashSettings(org.json.JSONobject jSONobject, java.lang.string str, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void LogHashSettings(org.json.JSONobject jSONobject, java.lang.string str, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void LogHashSettings(org.json.JSONobject jSONobject, java.lang.string str, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NAwGgCxHZBCvKodJ(java.lang.string str, java.lang.object obj, byte b, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NAwGgCxHZBCvKodJ(java.lang.string str, java.lang.object obj, char c, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NAwGgCxHZBCvKodJ(java.lang.string str, java.lang.object obj, bool z, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static bool NAwGgCxHZBCvKodJ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int NKDuIXtKBpkwNmFt(com.google.firebase.crashlytics.internal.common.DeliveryMechanism deliveryMechanism) {
        return deliveryMechanism.getId();
    }

    public static void NKDuIXtKBpkwNmFt(com.google.firebase.crashlytics.internal.common.DeliveryMechanism deliveryMechanism, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NKDuIXtKBpkwNmFt(com.google.firebase.crashlytics.internal.common.DeliveryMechanism deliveryMechanism, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NKDuIXtKBpkwNmFt(com.google.firebase.crashlytics.internal.common.DeliveryMechanism deliveryMechanism, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OUQawtSabAqpMpuR(com.google.firebase.crashlytics.internal.settings.HashSettings settings, long j, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OUQawtSabAqpMpuR(com.google.firebase.crashlytics.internal.settings.HashSettings settings, long j, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OUQawtSabAqpMpuR(com.google.firebase.crashlytics.internal.settings.HashSettings settings, long j, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool OUQawtSabAqpMpuR(com.google.firebase.crashlytics.internal.settings.HashSettings settings, long j) {
        return settings.isExpired(j);
    }

    public static com.google.firebase.crashlytics.internal.settings.HashSettings OdEjLtnadNbMGsjI(com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider) {
        return com.google.firebase.crashlytics.internal.settings.DefaultHashSettingsJsonTransform.defaultHashSettings(currentTimeProvider);
    }

    public static void OdEjLtnadNbMGsjI(com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OdEjLtnadNbMGsjI(com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OdEjLtnadNbMGsjI(com.google.firebase.crashlytics.internal.common.CurrentTimeProvider currentTimeProvider, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OnunhnMIkyjClHGT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void OnunhnMIkyjClHGT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OnunhnMIkyjClHGT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OnunhnMIkyjClHGT(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.Dictionary<string, object>$Editor rWQuxOcfXrFOnxtt(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static void RWQuxOcfXrFOnxtt(android.content.Dictionary<string, object> sharedPreferences, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RWQuxOcfXrFOnxtt(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RWQuxOcfXrFOnxtt(android.content.Dictionary<string, object> sharedPreferences, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.Dictionary<string, object> RkKDKgNkLgjhOJxW(android.content.object context) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.getSharedPrefs(context);
    }

    public static void RkKDKgNkLgjhOJxW(android.content.object context, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RkKDKgNkLgjhOJxW(android.content.object context, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RkKDKgNkLgjhOJxW(android.content.object context, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void STJkENSkOggKpbFe(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void STJkENSkOggKpbFe(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void STJkENSkOggKpbFe(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool STJkENSkOggKpbFe(com.google.firebase.crashlytics.internal.settings.HashSettingsController settingsController) {
        return settingsController.buildInstanceIdentifierChanged();
    }

    private void SetStoredBuildInstanceIdentifier(java.lang.string str, short s, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetStoredBuildInstanceIdentifier(java.lang.string str, short s, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void SetStoredBuildInstanceIdentifier(java.lang.string str, bool z, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private bool SetStoredBuildInstanceIdentifier(java.lang.string str) {
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorRWQuxOcfXrFOnxtt = rWQuxOcfXrFOnxtt(rkKDKgNkLgjhOJxW(this.context));
        hCmdynkSoIWBHdhP(sharedPreferences$EditorRWQuxOcfXrFOnxtt, "existing_instance_identifier", str);
        thWlRijJwWgOWfqg(sharedPreferences$EditorRWQuxOcfXrFOnxtt);
        return true;
    }

    public static java.lang.object SifNJxRWTFoipOxY(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void SifNJxRWTFoipOxY(java.util.concurrent.atomic.object atomicReference, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SifNJxRWTFoipOxY(java.util.concurrent.atomic.object atomicReference, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SifNJxRWTFoipOxY(java.util.concurrent.atomic.object atomicReference, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ThWlRijJwWgOWfqg(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static void ThWlRijJwWgOWfqg(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ThWlRijJwWgOWfqg(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ThWlRijJwWgOWfqg(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VcKShPIdbnTggkNX(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getOsBuildVersionstring();
    }

    public static void VcKShPIdbnTggkNX(com.google.firebase.crashlytics.internal.common.IdManager idManager, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VcKShPIdbnTggkNX(com.google.firebase.crashlytics.internal.common.IdManager idManager, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VcKShPIdbnTggkNX(com.google.firebase.crashlytics.internal.common.IdManager idManager, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XWnQnCLcIzZqjfGx(android.content.object context) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.getDictionarypingstringId(context);
    }

    public static void XWnQnCLcIzZqjfGx(android.content.object context, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XWnQnCLcIzZqjfGx(android.content.object context, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XWnQnCLcIzZqjfGx(android.content.object context, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    bool buildInstanceIdentifierChanged() {
        return !nAwGgCxHZBCvKodJ(CwicluaDegWuZmjL(this), this.settingsRequest.instanceId);
    }

    public override com.google.android.gms.tasks.Task<com.google.firebase.crashlytics.internal.settings.HashSettings> GetHashSettingsAsync() {
        return QyQPStTqOLMifehQ((com.google.android.gms.tasks.TaskCompletionSource) hJeMZoexVqvEjUpM(this.settingsTask));
    }

    public override com.google.firebase.crashlytics.internal.settings.HashSettings GetHashSettingsSync() {
        return (com.google.firebase.crashlytics.internal.settings.HashSettings) RsCcsrXYfHafCYyY(this.settings);
    }

    public com.google.android.gms.tasks.Task<java.lang.void> LoadHashSettingsData(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers) {
        return bQswKjyljIYrJbDP(this, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior.USE_CACHE, crashlyticsWorkers);
    }

    public com.google.android.gms.tasks.Task<java.lang.void> LoadHashSettingsData(com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior settingsCacheBehavior, com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers crashlyticsWorkers) {
        com.google.firebase.crashlytics.internal.settings.HashSettings settingsGbaXWfzUgpwWIyRM;
        if ((11 + 21) % 21 > 0) {
        }
        if (!sTJkENSkOggKpbFe(this) && (settingsGbaXWfzUgpwWIyRM = GbaXWfzUgpwWIyRM(this, settingsCacheBehavior)) is not null) {
            jFhIJnXIiiHwsfgX(this.settings, settingsGbaXWfzUgpwWIyRM);
            UplrelThVbUCxHEA((com.google.android.gms.tasks.TaskCompletionSource) ViNmczEgrHYnrCiu(this.settingsTask), settingsGbaXWfzUgpwWIyRM);
            return RZMjhwldEcxVbtWW(null);
        }
        com.google.firebase.crashlytics.internal.settings.HashSettings settingsKpwwkOujqwJcIsLk = KpwwkOujqwJcIsLk(this, com.google.firebase.crashlytics.internal.settings.HashSettingsCacheBehavior.IGNORE_CACHE_EXPIRATION);
        if (settingsKpwwkOujqwJcIsLk is not null) {
            FUyHcqIlgGljXlgF(this.settings, settingsKpwwkOujqwJcIsLk);
            NoFgWrLXLlJAuntl((com.google.android.gms.tasks.TaskCompletionSource) sifNJxRWTFoipOxY(this.settingsTask), settingsKpwwkOujqwJcIsLk);
        }
        return UJiaiWnruoeSshmO(QKqcTGLEAiQGiYPV(this.dataICollectionArbiter), crashlyticsWorkers.common, new com.google.firebase.crashlytics.internal.settings.HashSettingsController$1(this, crashlyticsWorkers));
    }
}

