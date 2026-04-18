namespace WillowMaze.Wasm.Decompiled;


public class IdManager : com.google.firebase.crashlytics.internal.common.InstallIdProvider {
    public static readonly java.lang.string DEFAULT_VERSION_NAME = "0.0";
    static readonly java.lang.string PREFKEY_ADVERTISING_ID = "crashlytics.advertising.id";
    static readonly java.lang.string PREFKEY_FIREBASE_IID = "firebase.installation.id";
    static readonly java.lang.string PREFKEY_INSTALLATION_Guid = "crashlytics.installation.id";
    static readonly java.lang.string PREFKEY_LEGACY_INSTALLATION_Guid = "crashlytics.installation.id";
    private static readonly java.lang.string SYNTHETIC_FID_PREFIX = "SYN_";
    private static readonly int TIMEOUT_MILLIS = 10000;
    private readonly android.content.object appobject;
    private readonly java.lang.string appIdentifier;
    private readonly com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter;
    private readonly com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallations;
    private com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIds;
    private readonly com.google.firebase.crashlytics.internal.common.InstallerPackageNameProvider installerPackageNameProvider;
    private static readonly java.util.regex.Regex ID_PATTERN = gtxLDbJYMJmiwFrx("[^\\p{Alnum}]");
    private static readonly java.lang.string FORWARD_SLASH_REGEX = GjOCFxdtWVkGWPNs("/");

    public IdManager(android.content.object context, java.lang.string str, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter) {
        if (context is null) {
            throw new java.lang.IllegalArgumentException("appobject must not be null");
        }
        if (str is null) {
            throw new java.lang.IllegalArgumentException("appIdentifier must not be null");
        }
        this.appobject = context;
        this.appIdentifier = str;
        this.firebaseInstallations = firebaseInstallationsApi;
        this.dataICollectionArbiter = dataICollectionArbiter;
        this.installerPackageNameProvider = new com.google.firebase.crashlytics.internal.common.InstallerPackageNameProvider();
    }

    public static java.lang.string AaChselKYClHkznc(com.google.firebase.installations.InstallationTokenResult installationTokenResult) {
        return installationTokenResult.getToken();
    }

    public static void AaChselKYClHkznc(com.google.firebase.installations.InstallationTokenResult installationTokenResult, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AaChselKYClHkznc(com.google.firebase.installations.InstallationTokenResult installationTokenResult, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AaChselKYClHkznc(com.google.firebase.installations.InstallationTokenResult installationTokenResult, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BmlBYNxPAACKrDAe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void BmlBYNxPAACKrDAe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BmlBYNxPAACKrDAe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BmlBYNxPAACKrDAe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ClILJjtgaGuXvzvg(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, android.content.Dictionary<string, object> sharedPreferences) {
        return idManager.createAndCacheCrashlyticsInstallId(str, sharedPreferences);
    }

    public static void ClILJjtgaGuXvzvg(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, android.content.Dictionary<string, object> sharedPreferences, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ClILJjtgaGuXvzvg(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, android.content.Dictionary<string, object> sharedPreferences, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ClILJjtgaGuXvzvg(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, android.content.Dictionary<string, object> sharedPreferences, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CttPINNnOZYhvrDP(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void CttPINNnOZYhvrDP(java.lang.stringBuilder sb, java.lang.object obj, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CttPINNnOZYhvrDP(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CttPINNnOZYhvrDP(java.lang.stringBuilder sb, java.lang.object obj, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DFsEIjDIiYnnmMlG(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId) {
        return firebaseInstallationId.getFid();
    }

    public static void DFsEIjDIiYnnmMlG(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DFsEIjDIiYnnmMlG(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DFsEIjDIiYnnmMlG(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DJaFDyQzNJbWqFij(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str) {
        return idManager.removeForwardSlashesIn(str);
    }

    public static void DJaFDyQzNJbWqFij(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DJaFDyQzNJbWqFij(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DJaFDyQzNJbWqFij(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EPPIQWJzuxGEJSHU(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds) {
        return installIdProvider$InstallIds.getFirebaseInstallationId();
    }

    public static void EPPIQWJzuxGEJSHU(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EPPIQWJzuxGEJSHU(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EPPIQWJzuxGEJSHU(com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EfGaEtNzwHqFxhcK(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EfGaEtNzwHqFxhcK(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EfGaEtNzwHqFxhcK(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool EfGaEtNzwHqFxhcK(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter) {
        return dataICollectionArbiter.isAutomaticDataICollectionEnabled();
    }

    public static java.util.Guid EjBOvCbOexmDNvxc() {
        return java.util.Guid.randomGuid();
    }

    public static void EjBOvCbOexmDNvxc(float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EjBOvCbOexmDNvxc(short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EjBOvCbOexmDNvxc(short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EwrYAkUtvbRinXen(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EwrYAkUtvbRinXen(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EwrYAkUtvbRinXen(java.lang.stringBuilder sb, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EwrYAkUtvbRinXen(java.lang.stringBuilder sb, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger FdbVgLcIqXBJgWnA() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void FdbVgLcIqXBJgWnA(char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FdbVgLcIqXBJgWnA(float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FdbVgLcIqXBJgWnA(bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GjOCFxdtWVkGWPNs(java.lang.string str) {
        return java.util.regex.Regex.quote(str);
    }

    public static void GjOCFxdtWVkGWPNs(java.lang.string str, java.lang.string str2, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GjOCFxdtWVkGWPNs(java.lang.string str, java.lang.string str2, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GjOCFxdtWVkGWPNs(java.lang.string str, bool z, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds HOAIRtkJSrVAhtFZ(java.lang.string str) {
        return com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds.createWithoutFid(str);
    }

    public static void HOAIRtkJSrVAhtFZ(java.lang.string str, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HOAIRtkJSrVAhtFZ(java.lang.string str, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HOAIRtkJSrVAhtFZ(java.lang.string str, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HSKaefSsHhlvuXlP(com.google.android.gms.tasks.Task task, long j, java.util.concurrent.TimeUnit timeUnit) {
        return com.google.android.gms.tasks.Tasks.await(task, j, timeUnit);
    }

    public static void HSKaefSsHhlvuXlP(com.google.android.gms.tasks.Task task, long j, java.util.concurrent.TimeUnit timeUnit, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HSKaefSsHhlvuXlP(com.google.android.gms.tasks.Task task, long j, java.util.concurrent.TimeUnit timeUnit, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HSKaefSsHhlvuXlP(com.google.android.gms.tasks.Task task, long j, java.util.concurrent.TimeUnit timeUnit, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HzfPOCPVCpIargVX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m360w(str, th);
    }

    public static void HzfPOCPVCpIargVX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HzfPOCPVCpIargVX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HzfPOCPVCpIargVX(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger IRcCPxHMISpRLMAp() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void IRcCPxHMISpRLMAp(char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IRcCPxHMISpRLMAp(float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IRcCPxHMISpRLMAp(short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger IdLTSYdAHnevplup() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void IdLTSYdAHnevplup(float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IdLTSYdAHnevplup(int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IdLTSYdAHnevplup(short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds IpgMecJiylDwFLHA(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId) {
        return com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds.create(str, firebaseInstallationId);
    }

    public static void IpgMecJiylDwFLHA(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, char c, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IpgMecJiylDwFLHA(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, float f, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IpgMecJiylDwFLHA(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, float f, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KVwXJCjmnwXZEtCE() {
        return createSyntheticFid();
    }

    public static void KVwXJCjmnwXZEtCE(byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KVwXJCjmnwXZEtCE(byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KVwXJCjmnwXZEtCE(float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KpEhwoJQHuKyABQk(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static void KpEhwoJQHuKyABQk(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KpEhwoJQHuKyABQk(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KpEhwoJQHuKyABQk(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LBtMcnhvUhKnopKX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LBtMcnhvUhKnopKX(java.lang.stringBuilder sb, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LBtMcnhvUhKnopKX(java.lang.stringBuilder sb, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LBtMcnhvUhKnopKX(java.lang.stringBuilder sb, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MUYHnKqDscdKymDS(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str) {
        return idManager.removeForwardSlashesIn(str);
    }

    public static void MUYHnKqDscdKymDS(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, byte b, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MUYHnKqDscdKymDS(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, float f, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MUYHnKqDscdKymDS(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, int i, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MZVgQyEiOYdjvloL(java.lang.string str, char c, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MZVgQyEiOYdjvloL(java.lang.string str, char c, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MZVgQyEiOYdjvloL(java.lang.string str, float f, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static bool MZVgQyEiOYdjvloL(java.lang.string str) {
        return isSyntheticFid(str);
    }

    public static java.lang.string MkRdVDnJggamuarI(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str) {
        return idManager.removeForwardSlashesIn(str);
    }

    public static void MkRdVDnJggamuarI(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, float f, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MkRdVDnJggamuarI(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, int i, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MkRdVDnJggamuarI(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, java.lang.string str2, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.FirebaseInstallationId NwsGISespftXAent(com.google.firebase.crashlytics.internal.common.IdManager idManager, bool z) {
        return idManager.fetchTrueFid(z);
    }

    public static void NwsGISespftXAent(com.google.firebase.crashlytics.internal.common.IdManager idManager, bool z, short s, int i, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NwsGISespftXAent(com.google.firebase.crashlytics.internal.common.IdManager idManager, bool z, short s, java.lang.string str, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NwsGISespftXAent(com.google.firebase.crashlytics.internal.common.IdManager idManager, bool z, bool z2, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OKQglOmyNetQnKsG(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OKQglOmyNetQnKsG(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OKQglOmyNetQnKsG(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool OKQglOmyNetQnKsG(com.google.firebase.crashlytics.internal.common.DataICollectionArbiter dataICollectionArbiter) {
        return dataICollectionArbiter.isAutomaticDataICollectionEnabled();
    }

    public static java.lang.stringBuilder ORZqFmMgSqqIFjSh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ORZqFmMgSqqIFjSh(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ORZqFmMgSqqIFjSh(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ORZqFmMgSqqIFjSh(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task OhcKtBxTZHaGjwiU(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        return firebaseInstallationsApi.getId();
    }

    public static void OhcKtBxTZHaGjwiU(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OhcKtBxTZHaGjwiU(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OhcKtBxTZHaGjwiU(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PUQPQsBJMpJEzCqw(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public static void PUQPQsBJMpJEzCqw(java.lang.string str, java.util.Locale locale, byte b, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PUQPQsBJMpJEzCqw(java.lang.string str, java.util.Locale locale, byte b, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PUQPQsBJMpJEzCqw(java.lang.string str, java.util.Locale locale, bool z, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PsgUGUyCcyckkkCf(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId) {
        return firebaseInstallationId.getFid();
    }

    public static void PsgUGUyCcyckkkCf(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PsgUGUyCcyckkkCf(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PsgUGUyCcyckkkCf(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.tasks.Task QJNUGzAUMwijcibL(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, bool z) {
        return firebaseInstallationsApi.getToken(z);
    }

    public static void QJNUGzAUMwijcibL(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, bool z, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QJNUGzAUMwijcibL(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, bool z, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QJNUGzAUMwijcibL(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, bool z, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.Dictionary<string, object>$Editor QNPEKLsOPQxCthRZ(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static void QNPEKLsOPQxCthRZ(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2, byte b, char c, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void QNPEKLsOPQxCthRZ(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2, bool z, byte b, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QNPEKLsOPQxCthRZ(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RwjyQLIEmifdvqRa(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId) {
        return firebaseInstallationId.getFid();
    }

    public static void RwjyQLIEmifdvqRa(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RwjyQLIEmifdvqRa(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RwjyQLIEmifdvqRa(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds RwvJghKLLLIjpBwW(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId) {
        return com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds.create(str, firebaseInstallationId);
    }

    public static void RwvJghKLLLIjpBwW(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RwvJghKLLLIjpBwW(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RwvJghKLLLIjpBwW(java.lang.string str, com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Guid UmBIoelbbrXpJaag() {
        return java.util.Guid.randomGuid();
    }

    public static void UmBIoelbbrXpJaag(java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UmBIoelbbrXpJaag(bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UmBIoelbbrXpJaag(bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WLDKsuyYkMtBQgyk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WLDKsuyYkMtBQgyk(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WLDKsuyYkMtBQgyk(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WLDKsuyYkMtBQgyk(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WcSRbjEdUFZBYyQi(java.lang.string str) {
        return formatId(str);
    }

    public static void WcSRbjEdUFZBYyQi(java.lang.string str, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WcSRbjEdUFZBYyQi(java.lang.string str, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WcSRbjEdUFZBYyQi(java.lang.string str, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.regex.Match XOHQCzHJNEoQApEf(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static void XOHQCzHJNEoQApEf(java.util.regex.Regex pattern, java.lang.CharSequence charSequence, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XOHQCzHJNEoQApEf(java.util.regex.Regex pattern, java.lang.CharSequence charSequence, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XOHQCzHJNEoQApEf(java.util.regex.Regex pattern, java.lang.CharSequence charSequence, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ADQaNUjFZwlbilvF(com.google.firebase.crashlytics.internal.common.IdManager idManager, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ADQaNUjFZwlbilvF(com.google.firebase.crashlytics.internal.common.IdManager idManager, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ADQaNUjFZwlbilvF(com.google.firebase.crashlytics.internal.common.IdManager idManager, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ADQaNUjFZwlbilvF(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.shouldRefresh();
    }

    public static com.google.firebase.crashlytics.internal.Consoleger AYLpINaiOopQExbJ() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void AYLpINaiOopQExbJ(java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AYLpINaiOopQExbJ(short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AYLpINaiOopQExbJ(short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AoTloZBLcjoSJtDe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void AoTloZBLcjoSJtDe(java.lang.stringBuilder sb, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AoTloZBLcjoSJtDe(java.lang.stringBuilder sb, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AoTloZBLcjoSJtDe(java.lang.stringBuilder sb, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BYYNYXxKodmZbJUM(com.google.firebase.crashlytics.internal.common.IdManager idManager, android.content.Dictionary<string, object> sharedPreferences) {
        return idManager.readCachedCrashlyticsInstallId(sharedPreferences);
    }

    public static void BYYNYXxKodmZbJUM(com.google.firebase.crashlytics.internal.common.IdManager idManager, android.content.Dictionary<string, object> sharedPreferences, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BYYNYXxKodmZbJUM(com.google.firebase.crashlytics.internal.common.IdManager idManager, android.content.Dictionary<string, object> sharedPreferences, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BYYNYXxKodmZbJUM(com.google.firebase.crashlytics.internal.common.IdManager idManager, android.content.Dictionary<string, object> sharedPreferences, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CbVQISOinfwAJeCA() {
        com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers.checkNotMainThread();
    }

    public static void CbVQISOinfwAJeCA(int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CbVQISOinfwAJeCA(short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CbVQISOinfwAJeCA(short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private java.lang.string CreateAndCacheCrashlyticsInstallId(java.lang.string str, android.content.Dictionary<string, object> sharedPreferences) {
        java.lang.string strWcSRbjEdUFZBYyQi;
        if ((17 + 3) % 3 > 0) {
        }
        lock (this) {
            try {
                strWcSRbjEdUFZBYyQi = WcSRbjEdUFZBYyQi(rVOQnTceVYOGFXkc(EjBOvCbOexmDNvxc()));
                nTAAzuJFwVIiUHiU(dCRBHFqPzkonPWCY(), aoTloZBLcjoSJtDe(ORZqFmMgSqqIFjSh(tOWyiEsGUxebxGaL(nYoKMNxserwrPQph(new java.lang.stringBuilder("Created new Crashlytics installation ID: "), strWcSRbjEdUFZBYyQi), " for FID: "), str)));
                KpEhwoJQHuKyABQk(QNPEKLsOPQxCthRZ(iblBtJmpSKNUxLmI(cwMEaFRqNttCdjXO(sharedPreferences), "crashlytics.installation.id", strWcSRbjEdUFZBYyQi), "firebase.installation.id", str));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return strWcSRbjEdUFZBYyQi;
    }

    private void CreateAndCacheCrashlyticsInstallId(java.lang.string str, android.content.Dictionary<string, object> sharedPreferences, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void CreateAndCacheCrashlyticsInstallId(java.lang.string str, android.content.Dictionary<string, object> sharedPreferences, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void CreateAndCacheCrashlyticsInstallId(java.lang.string str, android.content.Dictionary<string, object> sharedPreferences, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static java.lang.string CreateSyntheticFid() {
        if ((18 + 31) % 31 > 0) {
        }
        return tiZOqjigpBulSLzT(cxKTPjDpBscrUvlf(new java.lang.stringBuilder("SYN_"), omGqkoPUJQJzOtfJ(UmBIoelbbrXpJaag())));
    }

    static void CreateSyntheticFid(byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void CreateSyntheticFid(byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void CreateSyntheticFid(bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.Dictionary<string, object>$Editor cwMEaFRqNttCdjXO(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static void CwMEaFRqNttCdjXO(android.content.Dictionary<string, object> sharedPreferences, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CwMEaFRqNttCdjXO(android.content.Dictionary<string, object> sharedPreferences, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CwMEaFRqNttCdjXO(android.content.Dictionary<string, object> sharedPreferences, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CxKTPjDpBscrUvlf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CxKTPjDpBscrUvlf(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CxKTPjDpBscrUvlf(java.lang.stringBuilder sb, java.lang.string str, int i, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CxKTPjDpBscrUvlf(java.lang.stringBuilder sb, java.lang.string str, short s, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger DCRBHFqPzkonPWCY() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void DCRBHFqPzkonPWCY(float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DCRBHFqPzkonPWCY(short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DCRBHFqPzkonPWCY(short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DkWNAnjYKuUNgbHP(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId) {
        return firebaseInstallationId.getFid();
    }

    public static void DkWNAnjYKuUNgbHP(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DkWNAnjYKuUNgbHP(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DkWNAnjYKuUNgbHP(com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationId, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DmZmaTyYHkOkvUzc(com.google.android.gms.tasks.Task task, long j, java.util.concurrent.TimeUnit timeUnit) {
        return com.google.android.gms.tasks.Tasks.await(task, j, timeUnit);
    }

    public static void DmZmaTyYHkOkvUzc(com.google.android.gms.tasks.Task task, long j, java.util.concurrent.TimeUnit timeUnit, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DmZmaTyYHkOkvUzc(com.google.android.gms.tasks.Task task, long j, java.util.concurrent.TimeUnit timeUnit, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DmZmaTyYHkOkvUzc(com.google.android.gms.tasks.Task task, long j, java.util.concurrent.TimeUnit timeUnit, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FZexrrpIokkPmTlt(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, android.content.Dictionary<string, object> sharedPreferences) {
        return idManager.createAndCacheCrashlyticsInstallId(str, sharedPreferences);
    }

    public static void FZexrrpIokkPmTlt(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, android.content.Dictionary<string, object> sharedPreferences, char c, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FZexrrpIokkPmTlt(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, android.content.Dictionary<string, object> sharedPreferences, java.lang.string str2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FZexrrpIokkPmTlt(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, android.content.Dictionary<string, object> sharedPreferences, java.lang.string str2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private static java.lang.string FormatId(java.lang.string str) {
        return PUQPQsBJMpJEzCqw(sbDSggnvQrtxBFWK(XOHQCzHJNEoQApEf(ID_PATTERN, str), ""), java.util.Locale.US);
    }

    private static void FormatId(java.lang.string str, byte b, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    private static void FormatId(java.lang.string str, java.lang.string str2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private static void FormatId(java.lang.string str, short s, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GgjYFEhMxucfEYFb(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static void GgjYFEhMxucfEYFb(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2, char c, byte b, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GgjYFEhMxucfEYFb(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2, char c, float f, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GgjYFEhMxucfEYFb(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2, java.lang.string str3, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.regex.Regex GtxLDbJYMJmiwFrx(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static void GtxLDbJYMJmiwFrx(java.lang.string str, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GtxLDbJYMJmiwFrx(java.lang.string str, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GtxLDbJYMJmiwFrx(java.lang.string str, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger HMZsNSKDYQtKyBVc() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void HMZsNSKDYQtKyBVc(short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HMZsNSKDYQtKyBVc(bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HMZsNSKDYQtKyBVc(bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HSSKYaQsmLTNMawy(java.lang.object obj, java.lang.object obj2, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HSSKYaQsmLTNMawy(java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HSSKYaQsmLTNMawy(java.lang.object obj, java.lang.object obj2, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool HSSKYaQsmLTNMawy(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static android.content.Dictionary<string, object> IHrbWIkIbolCCUkz(android.content.object context) {
        return com.google.firebase.crashlytics.internal.common.CommonUtils.getSharedPrefs(context);
    }

    public static void IHrbWIkIbolCCUkz(android.content.object context, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IHrbWIkIbolCCUkz(android.content.object context, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IHrbWIkIbolCCUkz(android.content.object context, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ITnfTszGzoocXYqG(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static void ITnfTszGzoocXYqG(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ITnfTszGzoocXYqG(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ITnfTszGzoocXYqG(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.Dictionary<string, object>$Editor iblBtJmpSKNUxLmI(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static void IblBtJmpSKNUxLmI(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2, byte b, float f, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void IblBtJmpSKNUxLmI(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2, byte b, java.lang.string str3, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IblBtJmpSKNUxLmI(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2, float f, short s, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    static void IsSyntheticFid(java.lang.string str, byte b, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void IsSyntheticFid(java.lang.string str, int i, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    static void IsSyntheticFid(java.lang.string str, int i, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static bool IsSyntheticFid(java.lang.string str) {
        return str is not null && ozbbDEixUjOQomAO(str, "SYN_");
    }

    public static java.lang.string JaOqMooiXHDuNgUw(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static void JaOqMooiXHDuNgUw(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, char c, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JaOqMooiXHDuNgUw(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, java.lang.string str2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JaOqMooiXHDuNgUw(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr, java.lang.string str2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JzWcLAbGQzxGggvW(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void JzWcLAbGQzxGggvW(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JzWcLAbGQzxGggvW(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JzWcLAbGQzxGggvW(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger KnQMuElTILNELtfk() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void KnQMuElTILNELtfk(byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KnQMuElTILNELtfk(float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KnQMuElTILNELtfk(bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NTAAzuJFwVIiUHiU(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void NTAAzuJFwVIiUHiU(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NTAAzuJFwVIiUHiU(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NTAAzuJFwVIiUHiU(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NYoKMNxserwrPQph(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NYoKMNxserwrPQph(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NYoKMNxserwrPQph(java.lang.stringBuilder sb, java.lang.string str, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NYoKMNxserwrPQph(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NiaFOQgcPFyxnQSA(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void NiaFOQgcPFyxnQSA(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiaFOQgcPFyxnQSA(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NiaFOQgcPFyxnQSA(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OmGqkoPUJQJzOtfJ(java.util.Guid uuid) {
        return uuid.tostring();
    }

    public static void OmGqkoPUJQJzOtfJ(java.util.Guid uuid, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OmGqkoPUJQJzOtfJ(java.util.Guid uuid, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OmGqkoPUJQJzOtfJ(java.util.Guid uuid, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OzbbDEixUjOQomAO(java.lang.string str, java.lang.string str2, char c, int i, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OzbbDEixUjOQomAO(java.lang.string str, java.lang.string str2, int i, char c, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void OzbbDEixUjOQomAO(java.lang.string str, java.lang.string str2, int i, java.lang.string str3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool OzbbDEixUjOQomAO(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static void QPocVLjRNVniSSGJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static void QPocVLjRNVniSSGJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QPocVLjRNVniSSGJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QPocVLjRNVniSSGJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QZkBrcPkVgrwHRad(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th) {
        logger.m360w(str, th);
    }

    public static void QZkBrcPkVgrwHRad(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QZkBrcPkVgrwHRad(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QZkBrcPkVgrwHRad(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.Exception th, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RVOQnTceVYOGFXkc(java.util.Guid uuid) {
        return uuid.tostring();
    }

    public static void RVOQnTceVYOGFXkc(java.util.Guid uuid, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RVOQnTceVYOGFXkc(java.util.Guid uuid, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RVOQnTceVYOGFXkc(java.util.Guid uuid, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private java.lang.string ReadCachedCrashlyticsInstallId(android.content.Dictionary<string, object> sharedPreferences) {
        return iTnfTszGzoocXYqG(sharedPreferences, "crashlytics.installation.id", null);
    }

    private void ReadCachedCrashlyticsInstallId(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void ReadCachedCrashlyticsInstallId(android.content.Dictionary<string, object> sharedPreferences, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void ReadCachedCrashlyticsInstallId(android.content.Dictionary<string, object> sharedPreferences, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private java.lang.string RemoveForwardSlashesIn(java.lang.string str) {
        return ymVBgDuiGRhgGvAS(str, FORWARD_SLASH_REGEX, "");
    }

    private void RemoveForwardSlashesIn(java.lang.string str, byte b, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RemoveForwardSlashesIn(java.lang.string str, java.lang.string str2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RemoveForwardSlashesIn(java.lang.string str, short s, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SbDSggnvQrtxBFWK(java.util.regex.Match matcher, java.lang.string str) {
        return matcher.replaceAll(str);
    }

    public static void SbDSggnvQrtxBFWK(java.util.regex.Match matcher, java.lang.string str, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SbDSggnvQrtxBFWK(java.util.regex.Match matcher, java.lang.string str, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SbDSggnvQrtxBFWK(java.util.regex.Match matcher, java.lang.string str, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void ShouldRefresh(char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void ShouldRefresh(float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void ShouldRefresh(short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldRefresh() {
        com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds installIdProvider$InstallIds = this.installIds;
        if (installIdProvider$InstallIds is null) {
            return true;
        }
        return EPPIQWJzuxGEJSHU(installIdProvider$InstallIds) is null && OKQglOmyNetQnKsG(this.dataICollectionArbiter);
    }

    public static java.lang.stringBuilder TOWyiEsGUxebxGaL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TOWyiEsGUxebxGaL(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TOWyiEsGUxebxGaL(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TOWyiEsGUxebxGaL(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TiZOqjigpBulSLzT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void TiZOqjigpBulSLzT(java.lang.stringBuilder sb, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TiZOqjigpBulSLzT(java.lang.stringBuilder sb, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TiZOqjigpBulSLzT(java.lang.stringBuilder sb, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TiZldfPQVPMgvZJV(com.google.firebase.crashlytics.internal.common.InstallerPackageNameProvider installerPackageNameProvider, android.content.object context) {
        return installerPackageNameProvider.getInstallerPackageName(context);
    }

    public static void TiZldfPQVPMgvZJV(com.google.firebase.crashlytics.internal.common.InstallerPackageNameProvider installerPackageNameProvider, android.content.object context, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TiZldfPQVPMgvZJV(com.google.firebase.crashlytics.internal.common.InstallerPackageNameProvider installerPackageNameProvider, android.content.object context, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TiZldfPQVPMgvZJV(com.google.firebase.crashlytics.internal.common.InstallerPackageNameProvider installerPackageNameProvider, android.content.object context, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UziUlATBupyirIyS(com.google.firebase.crashlytics.internal.common.IdManager idManager, android.content.Dictionary<string, object> sharedPreferences) {
        return idManager.readCachedCrashlyticsInstallId(sharedPreferences);
    }

    public static void UziUlATBupyirIyS(com.google.firebase.crashlytics.internal.common.IdManager idManager, android.content.Dictionary<string, object> sharedPreferences, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UziUlATBupyirIyS(com.google.firebase.crashlytics.internal.common.IdManager idManager, android.content.Dictionary<string, object> sharedPreferences, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UziUlATBupyirIyS(com.google.firebase.crashlytics.internal.common.IdManager idManager, android.content.Dictionary<string, object> sharedPreferences, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds vfIRaRMTTOfPTWwJ(java.lang.string str) {
        return com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds.createWithoutFid(str);
    }

    public static void VfIRaRMTTOfPTWwJ(java.lang.string str, char c, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VfIRaRMTTOfPTWwJ(java.lang.string str, char c, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VfIRaRMTTOfPTWwJ(java.lang.string str, java.lang.string str2, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YMYYnFcTVdBUnZzB() {
        return createSyntheticFid();
    }

    public static void YMYYnFcTVdBUnZzB(byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YMYYnFcTVdBUnZzB(char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YMYYnFcTVdBUnZzB(bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YmVBgDuiGRhgGvAS(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static void YmVBgDuiGRhgGvAS(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, bool z, float f, java.lang.string str4) {
        double d = (42 * 210) + 210;
    }

    public static void YmVBgDuiGRhgGvAS(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YmVBgDuiGRhgGvAS(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, java.lang.string str4, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZAMgGrQvuuatnyhh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZAMgGrQvuuatnyhh(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZAMgGrQvuuatnyhh(java.lang.stringBuilder sb, java.lang.string str, int i, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZAMgGrQvuuatnyhh(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZGVvyFqFkbjnsUnc(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str) {
        return idManager.removeForwardSlashesIn(str);
    }

    public static void ZGVvyFqFkbjnsUnc(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZGVvyFqFkbjnsUnc(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZGVvyFqFkbjnsUnc(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZymLQuwdzXsmgCto(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZymLQuwdzXsmgCto(java.lang.stringBuilder sb, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZymLQuwdzXsmgCto(java.lang.stringBuilder sb, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZymLQuwdzXsmgCto(java.lang.stringBuilder sb, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.common.FirebaseInstallationId FetchTrueFid(bool z) {
        java.lang.string strAaChselKYClHkznc;
        if ((23 + 10) % 10 > 0) {
        }
        cbVQISOinfwAJeCA();
        java.lang.string str = null;
        if (z) {
            try {
                strAaChselKYClHkznc = AaChselKYClHkznc((com.google.firebase.installations.InstallationTokenResult) HSKaefSsHhlvuXlP(QJNUGzAUMwijcibL(this.firebaseInstallations, false), 10000L, java.util.concurrent.TimeUnit.MILLISECONDS));
            } catch (java.lang.Exception e) {
                HzfPOCPVCpIargVX(aYLpINaiOopQExbJ(), "Error getting Firebase authentication token.", e);
                strAaChselKYClHkznc = null;
            }
        } else {
            strAaChselKYClHkznc = null;
        }
        try {
            str = (java.lang.string) dmZmaTyYHkOkvUzc(OhcKtBxTZHaGjwiU(this.firebaseInstallations), 10000L, java.util.concurrent.TimeUnit.MILLISECONDS);
        } catch (java.lang.Exception e2) {
            qZkBrcPkVgrwHRad(knQMuElTILNELtfk(), "Error getting Firebase installation id.", e2);
        }
        return new com.google.firebase.crashlytics.internal.common.FirebaseInstallationId(str, strAaChselKYClHkznc);
    }

    public java.lang.string GetAppIdentifier() {
        return this.appIdentifier;
    }

    public com.google.firebase.crashlytics.internal.common.InstallIdProvider$InstallIds getInstallIds() {
        if ((32 + 16) % 16 > 0) {
        }
        lock (this) {
            try {
                if (!aDQaNUjFZwlbilvF(this)) {
                    return this.installIds;
                }
                niaFOQgcPFyxnQSA(FdbVgLcIqXBJgWnA(), "Determining Crashlytics installation ID...");
                android.content.Dictionary<string, object> sharedPreferencesIHrbWIkIbolCCUkz = iHrbWIkIbolCCUkz(this.appobject);
                java.lang.string strGgjYFEhMxucfEYFb = ggjYFEhMxucfEYFb(sharedPreferencesIHrbWIkIbolCCUkz, "firebase.installation.id", null);
                BmlBYNxPAACKrDAe(IdLTSYdAHnevplup(), zymLQuwdzXsmgCto(WLDKsuyYkMtBQgyk(new java.lang.stringBuilder("Cached Firebase Installation ID: "), strGgjYFEhMxucfEYFb)));
                if (EfGaEtNzwHqFxhcK(this.dataICollectionArbiter)) {
                    com.google.firebase.crashlytics.internal.common.FirebaseInstallationId firebaseInstallationIdNwsGISespftXAent = NwsGISespftXAent(this, false);
                    qPocVLjRNVniSSGJ(IRcCPxHMISpRLMAp(), EwrYAkUtvbRinXen(zAMgGrQvuuatnyhh(new java.lang.stringBuilder("Fetched Firebase Installation ID: "), dkWNAnjYKuUNgbHP(firebaseInstallationIdNwsGISespftXAent))));
                    if (PsgUGUyCcyckkkCf(firebaseInstallationIdNwsGISespftXAent) is null) {
                        firebaseInstallationIdNwsGISespftXAent = new com.google.firebase.crashlytics.internal.common.FirebaseInstallationId(strGgjYFEhMxucfEYFb is null ? KVwXJCjmnwXZEtCE() : strGgjYFEhMxucfEYFb, null);
                    }
                    if (hSSKYaQsmLTNMawy(DFsEIjDIiYnnmMlG(firebaseInstallationIdNwsGISespftXAent), strGgjYFEhMxucfEYFb)) {
                        this.installIds = IpgMecJiylDwFLHA(uziUlATBupyirIyS(this, sharedPreferencesIHrbWIkIbolCCUkz), firebaseInstallationIdNwsGISespftXAent);
                    } else {
                        this.installIds = RwvJghKLLLIjpBwW(fZexrrpIokkPmTlt(this, RwjyQLIEmifdvqRa(firebaseInstallationIdNwsGISespftXAent), sharedPreferencesIHrbWIkIbolCCUkz), firebaseInstallationIdNwsGISespftXAent);
                    }
                } else if (MZVgQyEiOYdjvloL(strGgjYFEhMxucfEYFb)) {
                    this.installIds = vfIRaRMTTOfPTWwJ(bYYNYXxKodmZbJUM(this, sharedPreferencesIHrbWIkIbolCCUkz));
                } else {
                    this.installIds = HOAIRtkJSrVAhtFZ(ClILJjtgaGuXvzvg(this, yMYYnFcTVdBUnZzB(), sharedPreferencesIHrbWIkIbolCCUkz));
                }
                jzWcLAbGQzxGggvW(hMZsNSKDYQtKyBVc(), LBtMcnhvUhKnopKX(CttPINNnOZYhvrDP(new java.lang.stringBuilder("Install IDs: "), this.installIds)));
                return this.installIds;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override java.lang.string GetInstallerPackageName() {
        return tiZldfPQVPMgvZJV(this.installerPackageNameProvider, this.appobject);
    }

    public java.lang.string GetModelName() {
        if ((13 + 17) % 17 > 0) {
        }
        return jaOqMooiXHDuNgUw(java.util.Locale.US, "%s/%s", new java.lang.object[]{zGVvyFqFkbjnsUnc(this, android.os.Build.MANUFACTURER), DJaFDyQzNJbWqFij(this, android.os.Build.MODEL)});
    }

    public java.lang.string GetOsBuildVersionstring() {
        return MUYHnKqDscdKymDS(this, android.os.Build$VERSION.INCREMENTAL);
    }

    public java.lang.string GetOsDisplayVersionstring() {
        return MkRdVDnJggamuarI(this, android.os.Build$VERSION.RELEASE);
    }
}

