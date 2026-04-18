using Android.Os;
using Android.Util;
using Androidx.Datastore.Core;
using Androidx.Datastore.Preferences.Core;
using Com.Google.Firebase.Installations;
using Com.Google.Firebase.Sessions;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlin.Text;
using Kotlin.Time;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Sync;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes2.dex */
public readonly class RemoteHashSettings : HashSettingsProvider {
    private static readonly Companion Companion = null;

    [System.Obsolete]
    public static readonly string FORWARD_SLASH_STRING = "/";

    [System.Obsolete]
    public static readonly string TAG = "SessionConfigFetcher";
    private readonly ApplicationInfo appInfo;
    private readonly Coroutineobject backgroundDispatcher;
    private readonly CrashlyticsHashSettingsFetcher configsFetcher;
    private readonly Mutex fetchInProgress;
    private readonly FirebaseInstallationsApi firebaseInstallationsApi;
    private readonly Lazy settingsCache$delegate;

    private static readonly class Companion {
        private Companion() {
        }

        public /* synthetic */ Companion(DefaultConstructorMarker r1) {
            this();
        }
    }

    /* JADX INFO: renamed from: com.google.firebase.sessions.settings.RemoteHashSettings$updateHashSettings$1 */
    static readonly class C22151 : ContinuationImpl {
        object L$0;
        object L$1;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ RemoteHashSettings this$0;

        C22151(RemoteHashSettings r1, Continuation<C22151> r2) {
            this.this$0 = r1;
            super(r2);
        }

        public static object DEXUMijJbKymJLlN(RemoteHashSettings r1, Continuation r2) {
            return r1.updateHashSettings(r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return dEXUMijJbKymJLlN(this.this$0, this);
        }
    }

    static {
        if (((3 + 4) % 4) > 0) goto L10;
    L10:
        Companion = new Companion(null);
    }

    public RemoteHashSettings(Coroutineobject r2, FirebaseInstallationsApi r3, ApplicationInfo r4, CrashlyticsHashSettingsFetcher r5, DataStore<Preferences> r6) {
        yKVMVZSmzKAGMyml(r2, "backgroundDispatcher");
        rBCAkslSHCHvLJZi(r3, "firebaseInstallationsApi");
        dEMLkBmzpuqGSxOM(r4, "appInfo");
        DnozOuRlphuCcUlA(r5, "configsFetcher");
        dQeuknxQuHhbUMYx(r6, "dataStore");
        this.backgroundDispatcher = r2;
        this.firebaseInstallationsApi = r3;
        this.appInfo = r4;
        this.configsFetcher = r5;
        this.settingsCache$delegate = DRwZitfFCmUFSruv(new RemoteHashSettings$settingsCache$2(r6));
        this.fetchInProgress = VxqqrbwCGRdZhcJX(false, 1, null);
    }

    public static void BDPDeazMuFKqzsBv(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static void BRunRfRiOzaBKGXF(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static double CFPjmGZLUeYmbWdq(HashSettingsCache r1) {
        return r1.sessionSamplingRate();
    }

    public static string CvZGVtwLeXHQQXxI(RemoteHashSettings r1, string r2) {
        return r1.removeForwardSlashesIn(r2);
    }

    public static Lazy DRwZitfFCmUFSruv(Function0 r1) {
        return LazyKt.lazy(r1);
    }

    public static void DnozOuRlphuCcUlA(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static string EtvlpPRlOIvwvbEJ(string r1, object[] r2) {
        return string.format(r1, r2);
    }

    public static Dictionary ExzFlLFNMpGdhAPe(ValueTuple[] r1) {
        return DictionarysKt.mapOf(r1);
    }

    public static bool EyqcfsfWnsQgKNBt(HashSettingsCache r1) {
        return r1.hasCacheExpired$com_google_firebase_firebase_sessions();
    }

    public static object[] ForXjCqONemSjLyb(object[] r1, int r2) {
        return Arrays.copyOf(r1, r2);
    }

    public static object FrQSJxSIYfJIbtvs(CrashlyticsHashSettingsFetcher r1, Dictionary r2, Function2 r3, Function2 r4, Continuation r5) {
        return r1.doConfigFetch(r2, r3, r4, r5);
    }

    public static void GFnOqbPfMUJPyevR(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static int GhwgXbcOsdnDsGyA(string r1, string r2) {
        return Console.w(r1, r2);
    }

    public static string GlUjujFLDokdbNqX(Regex r1, CharSequence r2, string r3) {
        return r1.Replace(r2, r3);
    }

    public static HashSettingsCache HgbmkACgBKYReQjx(RemoteHashSettings r1) {
        return r1.getHashSettingsCache();
    }

    public static HashSettingsCache HsspfgWsqrBgjUHE(RemoteHashSettings r1) {
        return r1.getHashSettingsCache();
    }

    public static void HxstuNGpwfInEZzh(Mutex r0, object r1) {
        r0.unlock(r1);
    }

    public static object JAutaRBJkYLRuPjJ(InstallationId.Companion r1, FirebaseInstallationsApi r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static bool JcaUjdvqjDbZeNmd(HashSettingsCache r1) {
        return r1.hasCacheExpired$com_google_firebase_firebase_sessions();
    }

    public static HashSettingsCache JonrOCCImysCCiyQ(RemoteHashSettings r1) {
        return r1.getHashSettingsCache();
    }

    public static bool KKrjZSVrwsIePgPD(HashSettingsCache r1) {
        return r1.sessionsEnabled();
    }

    public static ValueTuple NNLHikcuvJUOzKCC(object r1, object r2) {
        return TuplesKt.m928to(r1, r2);
    }

    public static HashSettingsCache OSultgwjBAHbUzcy(RemoteHashSettings r1) {
        return r1.getHashSettingsCache();
    }

    public static CoroutineScope QfkRqLAPcoxDJbMz(Coroutineobject r1) {
        return CoroutineScopeKt.CoroutineScope(r1);
    }

    public static string QnbvVZhUXcxmPYjP(RemoteHashSettings r1, string r2) {
        return r1.removeForwardSlashesIn(r2);
    }

    public static string TiHMBIWHKKDAYqzf(ApplicationInfo r1) {
        return r1.getSessionSdkVersion();
    }

    public static string ViZWfPdsBJlHpiNc(InstallationId r1) {
        return r1.getFid();
    }

    public static Mutex VxqqrbwCGRdZhcJX(bool r1, int r2, object r3) {
        return MutexKt.Mutex$default(r1, r2, r3);
    }

    public static HashSettingsCache YvUTVTLMMOHJpIYu(RemoteHashSettings r1) {
        return r1.getHashSettingsCache();
    }

    public static readonly /* synthetic */ HashSettingsCache access$getHashSettingsCache(RemoteHashSettings r0) {
        return YvUTVTLMMOHJpIYu(r0);
    }

    public static void BLCxwqiWhlMVlATa(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static void DEMLkBmzpuqGSxOM(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void DQeuknxQuHhbUMYx(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static object EkVNPrAuXtdynmXp(Mutex r1, object r2, Continuation r3) {
        return r1.lock(r2, r3);
    }

    public static string FDQGxaEeGXEujYol(RemoteHashSettings r1, string r2) {
        return r1.removeForwardSlashesIn(r2);
    }

    public static int FNHTTBhIWayJuymH(HashSettingsCache r1) {
        return r1.sessionRestartTimeout();
    }

    public static void GEfWAAEtHSUCFjkc(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    private readonly HashSettingsCache GetHashSettingsCache() {
        return (HashSettingsCache) rhkUSjkAkNVBlmEm(this.settingsCache$delegate);
    }

    public static ValueTuple IpYIIhnczpYkwNNi(object r1, object r2) {
        return TuplesKt.m928to(r1, r2);
    }

    public static void JhBEpyYWwXSRfNXk(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static Job JonrvpbcdiRogCBv(CoroutineScope r1, Coroutineobject r2, CoroutineStart r3, Function2 r4, int r5, object r6) {
        return BuildersKt.launch$default(r1, r2, r3, r4, r5, r6);
    }

    public static Duration KxcdjgjwAxeaOyuz(long r1) {
        return Duration.m3762boximpl(r1);
    }

    public static int LFSQDzdpFDYxmsXn(string r1, string r2) {
        return Console.d(r1, r2);
    }

    public static object LWPurKKzyFHFZTPU() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static long NMpLusXqEzxHtgDt(int r2, DurationUnit r3) {
        if (((15 + 10) % 10) > 0) goto L5;
    L5:
        return DurationKt.toDuration(r2, r3);
    }

    public static int ONaHnEkLEygKFUhC(int r1) {
        return r1.intValue();
    }

    public static ValueTuple PWbcWcGwPOQLwHiI(object r1, object r2) {
        return TuplesKt.m928to(r1, r2);
    }

    public static bool PgTKhZKyBoowGEyt(HashSettingsCache r1) {
        return r1.hasCacheExpired$com_google_firebase_firebase_sessions();
    }

    public static void QQlboZapcKEczUYx(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static void QTAXzwDUVjfcGqBd(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void QwCEsLjQeszbPVLT(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void RBCAkslSHCHvLJZi(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static ValueTuple ROTGoQHnkqNqUiLu(object r1, object r2) {
        return TuplesKt.m928to(r1, r2);
    }

    private readonly string RemoveForwardSlashesIn(string r2) {
        string r22 = r2;
        return GlUjujFLDokdbNqX(new Regex(FORWARD_SLASH_STRING), r22, "");
    }

    public static object RhkUSjkAkNVBlmEm(Lazy r1) {
        return r1.getValue();
    }

    public static ValueTuple RzCbWdopAhVMyFHJ(object r1, object r2) {
        return TuplesKt.m928to(r1, r2);
    }

    public static bool SNVZdnxIPtPpcNUj(Mutex r1) {
        return r1.isLocked();
    }

    public static HashSettingsCache TFDwryAOhagTVdHn(RemoteHashSettings r1) {
        return r1.getHashSettingsCache();
    }

    public static int UMrQFrIrCMbmcjOp(string r1, string r2) {
        return Console.d(r1, r2);
    }

    public static void WlAOyqVCTFsqFMkP(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void YKVMVZSmzKAGMyml(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static HashSettingsCache YwbLcTijDzzHoEiP(RemoteHashSettings r1) {
        return r1.getHashSettingsCache();
    }

    public static bool ZDGifOqQTVHDgExX(object r1, object r2) {
        return Intrinsics.areEqual(r1, r2);
    }

    public readonly void clearCachedHashSettings$com_google_firebase_firebase_sessions() {
        if (((11 + 19) % 19) > 0) goto L14;
    L14:
        jonrvpbcdiRogCBv(QfkRqLAPcoxDJbMz(this.backgroundDispatcher), null, null, new RemoteHashSettings$clearCachedHashSettings$1(this, null), 3, null);
    }

    @Override // com.google.firebase.sessions.settings.HashSettingsProvider
    public double GetSamplingRate() {
        return CFPjmGZLUeYmbWdq(HgbmkACgBKYReQjx(this));
    }

    @Override // com.google.firebase.sessions.settings.HashSettingsProvider
    public bool GetSessionEnabled() {
        return KKrjZSVrwsIePgPD(ywbLcTijDzzHoEiP(this));
    }

    @Override // com.google.firebase.sessions.settings.HashSettingsProvider
    /* JADX INFO: renamed from: getSessionRestartTimeout-FghU774 */
    public Duration Mo1355getSessionRestartTimeoutFghU774() {
        if (((18 + 31) % 31) > 0) goto L26;
    L26:
        int r2 = fNHTTBhIWayJuymH(OSultgwjBAHbUzcy(this));
        if (r2 is null) goto L30;
        Duration.Companion r0 = Duration.Companion;
        return kxcdjgjwAxeaOyuz(nMpLusXqEzxHtgDt(oNaHnEkLEygKFUhC(r2), DurationUnit.SECONDS));
    L30:
        return null;
    }

    @Override // com.google.firebase.sessions.settings.HashSettingsProvider
    public bool IsHashSettingsStale() {
        return EyqcfsfWnsQgKNBt(JonrOCCImysCCiyQ(this));
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r13v0, types: [com.google.firebase.sessions.settings.RemoteHashSettings, java.lang.object] */
    /* JADX WARN: Type inference failed for: r13v1, types: [kotlinx.coroutines.sync.Mutex] */
    /* JADX WARN: Type inference failed for: r13v14 */
    /* JADX WARN: Type inference failed for: r13v20 */
    /* JADX WARN: Type inference failed for: r13v3, types: [com.google.firebase.sessions.settings.RemoteHashSettings, java.lang.object] */
    /* JADX WARN: Type inference failed for: r13v5 */
    /* JADX WARN: Type inference failed for: r2v15 */
    /* JADX WARN: Type inference failed for: r2v7 */
    /* JADX WARN: Type inference failed for: r2v8, types: [com.google.firebase.sessions.settings.RemoteHashSettings] */
    @Override // com.google.firebase.sessions.settings.HashSettingsProvider
    public object UpdateHashSettings(Continuation<Unit> r14) {
        if (((3 + 24) % 24) > 0) goto L44;
    L44:
        if ((r14 is C22151) == true) goto L67;
    L14:
        C22151 r0 = new C22151(this, r14);
    L84:
        object r142 = r0.result;
        object r1 = lWPurKKzyFHFZTPU();
        int r2 = r0.label;
        if (r2 == 0) goto L13;
        if (r2 == 1) goto L136;
        if (r2 == 2) goto L126;
        if (r2 == 3) goto L139;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L139:
        Mutex r13 = (Mutex) r0.L$0;
        qwCEsLjQeszbPVLT(r142);     // Catch: Exception -> L65
    L114:
        Unit r143 = Unit.INSTANCE;     // Catch: Exception -> L65
        GFnOqbPfMUJPyevR(r13, null);
        return Unit.INSTANCE;
    L126:
        r13 = (Mutex) r0.L$1;
        RemoteHashSettings r22 = (RemoteHashSettings) r0.L$0;
        gEfWAAEtHSUCFjkc(r142);     // Catch: Exception -> L65
        ?? r23 = r22;
    L143:
        string r144 = ViZWfPdsBJlHpiNc((InstallationId) r142);     // Catch: Exception -> L65
        if (zDGifOqQTVHDgExX(r144, "") == false) goto L111;
        GhwgXbcOsdnDsGyA(TAG, "Error getting Firebase Installation ID. Skipping this Session Event.");     // Catch: Exception -> L65
        Unit r145 = Unit.INSTANCE;     // Catch: Exception -> L65
        BDPDeazMuFKqzsBv(r13, null);
        return r145;
    L111:
        stringCompanionobject r9 = stringCompanionobject.INSTANCE;     // Catch: Exception -> L65
        string r92 = EtvlpPRlOIvwvbEJ("%s/%s", ForXjCqONemSjLyb(new object[]{Build.MANUFACTURER, Build.MODEL}, 2));     // Catch: Exception -> L65
        qQlboZapcKEczUYx(r92, "format(...)");     // Catch: Exception -> L65
        string r5 = Build.VERSION.INCREMENTAL;     // Catch: Exception -> L65
        jhBEpyYWwXSRfNXk(r5, "INCREMENTAL");     // Catch: Exception -> L65
        string r52 = Build.VERSION.RELEASE;     // Catch: Exception -> L65
        bLCxwqiWhlMVlATa(r52, "RELEASE");     // Catch: Exception -> L65
        Dictionary r146 = ExzFlLFNMpGdhAPe(new ValueTuple[]{rzCbWdopAhVMyFHJ("X-Crashlytics-Installation-ID", r144), ipYIIhnczpYkwNNi("X-Crashlytics-Device-Model", fDQGxaEeGXEujYol(r23, r92)), NNLHikcuvJUOzKCC("X-Crashlytics-OS-Build-Version", QnbvVZhUXcxmPYjP(r23, r5)), pWbcWcGwPOQLwHiI("X-Crashlytics-OS-Display-Version", CvZGVtwLeXHQQXxI(r23, r52)), rOTGoQHnkqNqUiLu("X-Crashlytics-API-Client-Version", TiHMBIWHKKDAYqzf(r23.appInfo))});     // Catch: Exception -> L65
        uMrQFrIrCMbmcjOp(TAG, "Fetching settings from server.");     // Catch: Exception -> L65
        CrashlyticsHashSettingsFetcher r3 = r23.configsFetcher;     // Catch: Exception -> L65
        RemoteHashSettings$updateHashSettings$2$1 r53 = new RemoteHashSettings$updateHashSettings$2$1(r23, null);     // Catch: Exception -> L65
        RemoteHashSettings$updateHashSettings$2$2 r24 = new RemoteHashSettings$updateHashSettings$2$2(null);     // Catch: Exception -> L65
        r0.L$0 = r13;     // Catch: Exception -> L65
        r0.L$1 = null;     // Catch: Exception -> L65
        r0.label = 3;     // Catch: Exception -> L65
        if (FrQSJxSIYfJIbtvs(r3, r146, r53, r24, r0) != r1) goto L114;
    L113:
        return r1;
    L136:
        Mutex r132 = (Mutex) r0.L$1;
        RemoteHashSettings r25 = (RemoteHashSettings) r0.L$0;
        wlAOyqVCTFsqFMkP(r142);
        Mutex r147 = r132;
        ?? r133 = r25;
    L153:
    L30:
        th = move-exception;
        Mutex r12 = r147;
        th = th;
        RemoteHashSettings this = r12;
    L85:
        BRunRfRiOzaBKGXF(this, null);
        throw th;
    L21:
        if (pgTKhZKyBoowGEyt(HsspfgWsqrBgjUHE(r133)) == true) goto L102;
        lFSQDzdpFDYxmsXn(TAG, "Remote settings cache not expired. Using cached values.");     // Catch: Exception -> L30
        Unit r134 = Unit.INSTANCE;     // Catch: Exception -> L30
        HxstuNGpwfInEZzh(r147, null);
        return r134;
    L102:
        InstallationId.Companion r26 = InstallationId.Companion;     // Catch: Exception -> L30
        FirebaseInstallationsApi r8 = r133.firebaseInstallationsApi;     // Catch: Exception -> L30
        r0.L$0 = r133;     // Catch: Exception -> L30
        r0.L$1 = r147;     // Catch: Exception -> L30
        r0.label = 2;     // Catch: Exception -> L30
        object r27 = JAutaRBJkYLRuPjJ(r26, r8, r0);     // Catch: Exception -> L30
        if (r27 == r1) goto L113;
        r23 = r133;
        r13 = r147;
        r142 = r27;
        goto L143
    L13:
        qTAXzwDUVjfcGqBd(r142);
        if (sNVZdnxIPtPpcNUj(this.fetchInProgress) == false) goto L76;
    L54:
        r147 = this.fetchInProgress;
        r0.L$0 = this;
        r0.L$1 = r147;
        r0.label = 1;
        this = this;
        if (ekVNPrAuXtdynmXp(r147, null, r0) == r1) goto L113;
    L76:
        if (JcaUjdvqjDbZeNmd(tFDwryAOhagTVdHn(this)) == true) goto L54;
        return Unit.INSTANCE;
    L65:
        th = th;
        goto L85
    L67:
        r0 = (C22151) r14;
        if ((r0.label & int.MIN_VALUE) == 0) goto L14;
        r0.label -= int.MIN_VALUE;
        goto L84
    }
}

