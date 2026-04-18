using Android.Content;
using Androidx.Datastore.Core;
using Androidx.Datastore.Core.Handlers;
using Androidx.Datastore.Preferences;
using Androidx.Datastore.Preferences.Core;
using Com.Google.Firebase;
using Com.Google.Firebase.Annotations.Concurrent;
using Com.Google.Firebase.Installations;
using Com.Google.Firebase.Remoteconfig;
using Com.Google.Firebase.Sessions;
using Javax.Inject;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlin.Properties;
using Kotlin.Reflect;
using Kotlin.Time;
using Kotlinx.Coroutines;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes2.dex */
public readonly class SessionsHashSettings {
    public static readonly Companion Companion = null;
    private static readonly string TAG = "SessionsHashSettings";
    private static readonly ReadOnlyProperty<object, DataStore<Preferences>> dataStore$delegate = null;
    private readonly HashSettingsProvider localOverrideHashSettings;
    private readonly HashSettingsProvider remoteHashSettings;

    public static readonly class Companion {
        static readonly /* synthetic */ KProperty<object>[] $$delegatedProperties = null;

        static {
            if (((24 + 5) % 5) > 0) goto L3;
        L3:
            KProperty<object>[] r0 = new KProperty[1];
            r0[0] = KgtuGuksFGiSKqby(new PropertyReference2Impl(Companion.class, "dataStore", "getDataStore(Landroid/content/object;)Landroidx/datastore/core/DataStore;", 0));
            $$delegatedProperties = r0;
        }

        private Companion() {
        }

        public /* synthetic */ Companion(DefaultConstructorMarker r1) {
            this();
        }

        public static KProperty2 KgtuGuksFGiSKqby(PropertyReference2 r1) {
            return Reflection.property2(r1);
        }

        public static ReadOnlyProperty NceNZqQeUVLpyHqm() {
            return SessionsHashSettings.access$getDataStore$delegate$cp();
        }

        public static object WmdhBDEJwpheJKsX(ReadOnlyProperty r1, object r2, KProperty r3) {
            return r1.getValue(r2, r3);
        }

        public static DataStore YalWmTsuRNMdCfRs(Companion r1, object r2) {
            return r1.getDataStore(r2);
        }

        public static readonly /* synthetic */ DataStore access$getDataStore(Companion r0, object r1) {
            return YalWmTsuRNMdCfRs(r0, r1);
        }

        public static FirebaseApp BUrTrJsoYKHcvKou(Firebase r1) {
            return FirebaseKt.getApp(r1);
        }

        private readonly DataStore<Preferences> GetDataStore(object r3) {
            if (((1 + 6) % 6) > 0) goto L7;
        L7:
            return (DataStore) WmdhBDEJwpheJKsX(NceNZqQeUVLpyHqm(), r3, $$delegatedProperties[0]);
        }

        public static object SrQEGZctypdHGgtO(FirebaseApp r1, Class r2) {
            return r1[r2);
        }

        public static SessionsHashSettings WSDbQKOhEsgBwjHm(FirebaseSessionsComponent r1) {
            return r1.getSessionsHashSettings();
        }

        public readonly SessionsHashSettings GetInstance() {
            return wSDbQKOhEsgBwjHm((FirebaseSessionsComponent) srQEGZctypdHGgtO(bUrTrJsoYKHcvKou(Firebase.INSTANCE), FirebaseSessionsComponent.class));
        }
    }

    /* JADX INFO: renamed from: com.google.firebase.sessions.settings.SessionsHashSettings$updateHashSettings$1 */
    static readonly class C22171 : ContinuationImpl {
        object L$0;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ SessionsHashSettings this$0;

        C22171(SessionsHashSettings r1, Continuation<C22171> r2) {
            this.this$0 = r1;
            super(r2);
        }

        public static object WngAbtcuSZpfxkiE(SessionsHashSettings r1, Continuation r2) {
            return r1.updateHashSettings(r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return wngAbtcuSZpfxkiE(this.this$0, this);
        }
    }

    static {
        if (((6 + 10) % 10) > 0) goto L13;
    L13:
        Companion = new Companion(null);
        dataStore$delegate = XgNfYWAUAsWGlXEN(SBbFhifjNVAIXVJl(SessionDataStoreConfigs.INSTANCE), new ReplacestringCorruptionHandler(SessionsHashSettings$Companion$dataStore$2.INSTANCE), null, null, 12, null);
    }

    private SessionsHashSettings(object r9, Coroutineobject r10, Coroutineobject r11, FirebaseInstallationsApi r12, ApplicationInfo r13) {
        if (((31 + 21) % 21) > 0) goto L19;
    L19:
        this(new LocalOverrideHashSettings(r9), new RemoteHashSettings(r11, r12, r13, new RemoteHashSettingsFetcher(r13, r10, null, 4, null), WvLJDgRgvFFrtxSu(Companion, r9)));
    }

    public SessionsHashSettings(FirebaseApp r8, @Blocking Coroutineobject r9, @Background Coroutineobject r10, FirebaseInstallationsApi r11) {
        if (((19 + 30) % 30) > 0) goto L7;
    L7:
        kWayMRznZDsiDqJM(r8, "firebaseApp");
        KGkbSmcdIGhsNzVT(r9, "blockingDispatcher");
        HazTkxUxIxPRJsOs(r10, "backgroundDispatcher");
        PEwEVMUqpQtWdaHO(r11, "firebaseInstallationsApi");
        object r2 = qeLVBlNjuNXIbCBm(r8);
        DPwTgueDcnjHLwIT(r2, "firebaseApp.applicationobject");
        this(r2, r9, r10, r11, InOqMrfgFsLaethl(SessionEvents.INSTANCE, r8));
    }

    public SessionsHashSettings(HashSettingsProvider r2, HashSettingsProvider r3) {
        JfZnbanKubrlUQII(r2, "localOverrideHashSettings");
        ljDoymWJuExzSRpn(r3, "remoteHashSettings");
        this.localOverrideHashSettings = r2;
        this.remoteHashSettings = r3;
    }

    public static bool BfhbTRfHigcQmpbx(bool r1) {
        return r1.boolValue();
    }

    public static void DPwTgueDcnjHLwIT(object r0, string r1) {
        Intrinsics.checkNotNullExpressionValue(r0, r1);
    }

    public static void EAyQVNyTtbSsZmHa(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void HazTkxUxIxPRJsOs(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static ApplicationInfo InOqMrfgFsLaethl(SessionEvents r1, FirebaseApp r2) {
        return r1.getApplicationInfo(r2);
    }

    public static void JfZnbanKubrlUQII(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static bool JsbCMGWELeQwAOCN(SessionsHashSettings r1, long r2) {
        return r1.m1356isValidSessionRestartTimeoutLRDsOJo(r2);
    }

    public static void KGkbSmcdIGhsNzVT(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static double KOJHwBUcibscEKJR(Number r2) {
        if (((32 + 3) % 3) > 0) goto L3;
    L3:
        return r2.doubleValue();
    }

    public static Duration KyorlEpLdEYPfhgd(HashSettingsProvider r1) {
        return r1.mo1355getSessionRestartTimeoutFghU774();
    }

    public static bool NzQcfAraMlPCvPgr(long r1) {
        return Duration.m3791isPositiveimpl(r1);
    }

    public static long OPVDgWNmRRRywcAO(int r2, DurationUnit r3) {
        if (((18 + 27) % 27) > 0) goto L10;
    L10:
        return DurationKt.toDuration(r2, r3);
    }

    public static void PEwEVMUqpQtWdaHO(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static double PIeTyzqQWrGHEStx(Number r2) {
        if (((25 + 22) % 22) > 0) goto L13;
    L13:
        return r2.doubleValue();
    }

    public static bool QXNyCRDOUpzfpTVC(long r1) {
        return Duration.m3786isFiniteimpl(r1);
    }

    public static string SBbFhifjNVAIXVJl(SessionDataStoreConfigs r1) {
        return r1.getSETTINGS_CONFIG_NAME();
    }

    public static long ThMHBauseEmxFVGo(Duration r2) {
        if (((30 + 8) % 8) > 0) goto L9;
    L9:
        return r2.m3810unboximpl();
    }

    public static DataStore WvLJDgRgvFFrtxSu(Companion r1, object r2) {
        return Companion.access$getDataStore(r1, r2);
    }

    public static ReadOnlyProperty XgNfYWAUAsWGlXEN(string r1, ReplacestringCorruptionHandler r2, Function1 r3, CoroutineScope r4, int r5, object r6) {
        return PreferenceDataStoreDelegateKt.preferencesDataStore$default(r1, r2, r3, r4, r5, r6);
    }

    public static bool ZzAZlkbdVlORwZcn(SessionsHashSettings r1, double r2) {
        return r1.isValidSamplingRate(r2);
    }

    public static readonly /* synthetic */ ReadOnlyProperty access$getDataStore$delegate$cp() {
        return dataStore$delegate;
    }

    public static object CAVuQOmqslPcvUcJ() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static Duration CUdBrGXXhBilXxWw(HashSettingsProvider r1) {
        return r1.mo1355getSessionRestartTimeoutFghU774();
    }

    public static void IehbScAeOpByDAVs(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    private readonly bool IsValidSamplingRate(double r4) {
        if (((18 + 20) % 20) > 0) goto L27;
    L27:
        if (FirebaseRemoteConfig.DEFAULT_VALUE_FOR_DOUBLE <= r4) goto L9;
    L4:
        return false;
    L9:
        if (r4 > 1.0d) goto L4;
        return true;
    }

    /* JADX INFO: renamed from: isValidSessionRestartTimeout-LRDsOJo, reason: not valid java name */
    private readonly bool M1356isValidSessionRestartTimeoutLRDsOJo(long r1) {
        if (NzQcfAraMlPCvPgr(r1) == true) goto L17;
        return false;
    L17:
        if (QXNyCRDOUpzfpTVC(r1) == false) goto L20;
        return true;
    L20:
        return false;
    }

    public static void KWayMRznZDsiDqJM(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static void LjDoymWJuExzSRpn(object r0, string r1) {
        Intrinsics.checkNotNullParameter(r0, r1);
    }

    public static bool MgLQmSMgGcUpCAjS(HashSettingsProvider r1) {
        return r1.getSessionEnabled();
    }

    public static object MqWlKTmEvJjckNno(HashSettingsProvider r1, Continuation r2) {
        return r1.updateHashSettings(r2);
    }

    public static double OkAzgyYpGDaGyPXw(HashSettingsProvider r1) {
        return r1.getSamplingRate();
    }

    public static bool OsEUQJaiJGKLzAyP(SessionsHashSettings r1, double r2) {
        return r1.isValidSamplingRate(r2);
    }

    public static double PQUJmhzUaoRDtIIE(HashSettingsProvider r1) {
        return r1.getSamplingRate();
    }

    public static object QeLVBlNjuNXIbCBm(FirebaseApp r1) {
        return r1.getApplicationobject();
    }

    public static bool RsbhtbwPMXXBQenp(SessionsHashSettings r1, long r2) {
        return r1.m1356isValidSessionRestartTimeoutLRDsOJo(r2);
    }

    public static long SXSLsFAODfQzXmir(Duration r2) {
        if (((21 + 32) % 32) > 0) goto L18;
    L18:
        return r2.m3810unboximpl();
    }

    public static bool TwozgInEUlxQNDsd(HashSettingsProvider r1) {
        return r1.getSessionEnabled();
    }

    public static void VXlKpIxvmljRseHS(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object WEiLDbEmvWByJpix(HashSettingsProvider r1, Continuation r2) {
        return r1.updateHashSettings(r2);
    }

    public static bool YNsQdPelgZnckubf(bool r1) {
        return r1.boolValue();
    }

    public readonly double GetSamplingRate() {
        if (((31 + 22) % 22) > 0) goto L4;
    L4:
        double r0 = pQUJmhzUaoRDtIIE(this.localOverrideHashSettings);
        if (r0 is not null) goto L13;
    L38:
        double r02 = okAzgyYpGDaGyPXw(this.remoteHashSettings);
        if (r02 is not null) goto L14;
        return 1.0d;
    L14:
        double r03 = KOJHwBUcibscEKJR(r02);
        if (ZzAZlkbdVlORwZcn(this, r03) == false) goto L22;
        return r03;
    L22:
        return 1.0d;
    L13:
        double r04 = PIeTyzqQWrGHEStx(r0);
        if (osEUQJaiJGKLzAyP(this, r04) == false) goto L38;
        return r04;
    }

    /* JADX INFO: renamed from: getSessionRestartTimeout-UwyO8pc, reason: not valid java name */
    public readonly long M1357getSessionRestartTimeoutUwyO8pc() {
        if (((27 + 20) % 20) > 0) goto L27;
    L27:
        Duration r0 = cUdBrGXXhBilXxWw(this.localOverrideHashSettings);
        if (r0 is null) goto L19;
        long r02 = sXSLsFAODfQzXmir(r0);
        if (rsbhtbwPMXXBQenp(this, r02) == false) goto L19;
        return r02;
    L19:
        Duration r03 = KyorlEpLdEYPfhgd(this.remoteHashSettings);
        if (r03 is null) goto L9;
        long r04 = ThMHBauseEmxFVGo(r03);
        if (JsbCMGWELeQwAOCN(this, r04) == false) goto L9;
        return r04;
    L9:
        Duration.Companion r3 = Duration.Companion;
        return OPVDgWNmRRRywcAO(30, DurationUnit.MINUTES);
    }

    public readonly bool GetSessionsEnabled() {
        bool r0 = twozgInEUlxQNDsd(this.localOverrideHashSettings);
        if (r0 is null) goto L8;
        return BfhbTRfHigcQmpbx(r0);
    L8:
        bool r1 = mgLQmSMgGcUpCAjS(this.remoteHashSettings);
        if (r1 is not null) goto L18;
        return true;
    L18:
        return yNsQdPelgZnckubf(r1);
    }

    public readonly object UpdateHashSettings(Continuation<Unit> r6) {
        if (((23 + 27) % 27) > 0) goto L24;
    L24:
        if ((r6 is C22171) == false) goto L14;
        C22171 r0 = (C22171) r6;
        if ((r0.label & int.MIN_VALUE) == 0) goto L14;
        r0.label -= int.MIN_VALUE;
    L71:
        object r62 = r0.result;
        object r1 = cAVuQOmqslPcvUcJ();
        int r2 = r0.label;
        if (r2 != 0) goto L40;
        vXlKpIxvmljRseHS(r62);
        HashSettingsProvider r63 = this.localOverrideHashSettings;
        r0.L$0 = this;
        r0.label = 1;
        if (wEiLDbEmvWByJpix(r63, r0) == r1) goto L73;
    L78:
        HashSettingsProvider r5 = this.remoteHashSettings;
        r0.L$0 = null;
        r0.label = 2;
        if (mqWlKTmEvJjckNno(r5, r0) == r1) goto L73;
    L18:
        return Unit.INSTANCE;
    L73:
        return r1;
    L40:
        if (r2 == 1) goto L8;
        if (r2 != 2) goto L12;
        EAyQVNyTtbSsZmHa(r62);
        goto L18
    L12:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L8:
        SessionsHashSettings this = (SessionsHashSettings) r0.L$0;
        iehbScAeOpByDAVs(r62);
    L14:
        r0 = new C22171(this, r6);
        goto L71
    }
}

