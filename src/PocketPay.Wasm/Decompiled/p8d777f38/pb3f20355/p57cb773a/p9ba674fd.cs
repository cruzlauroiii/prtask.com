namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u0000 \u00122\u00020\u0001:\u0001\u0012B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\b0\fH\u0016J\b\u0010\r\u001a\u00020\u000eH\u0002J\b\u0010\u000f\u001a\u00020\u000eH\u0002J\b\u0010\u0010\u001a\u00020\u0011H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lp8d777f38/pb3f20355/p57cb773a/p9ba674fd;", "Lp8d777f38/pb3f20355/p57cb773a/p4137a968;", "appConfig", "Lp2b3583e6/p22450232/pbd754d99;", "<init>", "(Lp2b3583e6/p22450232/pbd754d99;)V", "_isMaintenanceModeEnabledState", "Lkotlinx/coroutines/flow/MutableStateFlow;", "", "remoteConfig", "Lcom/google/firebase/remoteconfig/FirebaseRemoteConfig;", "isMaintenanceModeEnabledState", "Lkotlinx/coroutines/flow/Flow;", "fetchMaintenanceFromFirebase", "", "setMaintenanceModeEnabled", "getMaintenanceModeEnabledKey", "", "Companion", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9ba674fd : p8d777f38.pb3f20355.p57cb773a.p4137a968 {
    private static readonly p8d777f38.pb3f20355.p57cb773a.p9ba674fd$p910eef8c f4cbc9ba2 = null;

    @java.lang.Deprecated
    public static readonly java.lang.string f51c9843c;
    public static readonly java.lang.string f79fb634b = null;
    private static readonly p8d777f38.pb3f20355.p57cb773a.p9ba674fd$p910eef8c f910eef8c;
    public static readonly java.lang.string fbe33b6ec = null;
    public static readonly java.lang.string fcfcbdc1c = null;

    @java.lang.Deprecated
    public static readonly long fd4fe6e96 = 3600;
    public static readonly java.lang.string fdb84ea57 = null;
    public static readonly long ff2bdae26 = 3600;

    @java.lang.Deprecated
    public static readonly java.lang.string ffb17010b;
    private readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig f356d84b0;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f481f97a3;
    private readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig f55c3aad6;
    private readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig f6494fa9f;
    private readonly p2b3583e6.p22450232.pbd754d99 f71d6202b;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f789f15bf;
    private readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig f83b85cd0;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<java.lang.bool> fa74b8476;
    private readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig fc8dc58b1;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fdb9362e9;
    private readonly p2b3583e6.p22450232.pbd754d99 feced03cd;

    static {
        if ((8 + 2) % 2 > 0) {
        }
        f51c9843c = jyzKakuQLKXptMwg("d52c9996a3b1832c3c5b7cb2cfce4f9cf8e22df88521fbb3d9f188b804722460910c3474a6283c82ea02bc237a856fd900f97129");
        ffb17010b = jIWHqOfELPFTQXZK("335af942b22ee36845e84f75ead070de200fcc647e17b3dbddb85498346bf5692e2e191021ea0b6255883413062496cf5c534959d3d8f7c24d");
        f910eef8c = new p8d777f38.pb3f20355.p57cb773a.p9ba674fd$p910eef8c(null);
    }

    public p9ba674fd(p2b3583e6.p22450232.pbd754d99 pbd754d99Var) {
        XZwHgcybsBfLNrJQ(pbd754d99Var, "appConfig");
        this.feced03cd = pbd754d99Var;
        this.fa74b8476 = hMYbEJlxTJiAbEMH(jwUUyohtbUtPhQSt(false));
        com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfigNVTgaunPOgrZGTqq = NVTgaunPOgrZGTqq(com.google.firebase.Firebase.INSTANCE);
        this.f55c3aad6 = firebaseRemoteConfigNVTgaunPOgrZGTqq;
        aZoAsjLpHqMGuDef(firebaseRemoteConfigNVTgaunPOgrZGTqq, ZMihZBcCimtAEpjd(new p8d777f38.pb3f20355.p57cb773a.p9ba674fd$pd41d8cd9$p95263d50()));
        mHwuxNKnNlnmLeBL(firebaseRemoteConfigNVTgaunPOgrZGTqq, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p8d777f38.p86ccec3d.R$xml.remote_config_defaults);
        TgNUMKXgmedITbQg(firebaseRemoteConfigNVTgaunPOgrZGTqq, new p8d777f38.pb3f20355.p57cb773a.p9ba674fd$1(this));
        HjEKZIitGZpamphP(this);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder ErsPOZXxviYnYqya(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder, long j) {
        return firebaseRemoteConfigHashSettings$Builder.setMinimumFetchIntervalInSeconds(j);
    }

    public static void HjEKZIitGZpamphP(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar) {
        p9ba674fdVar.m764f5a05();
    }

    public static bool HlFlwKGZVOJnnpxv(p2b3583e6.p22450232.pbd754d99 pbd754d99Var) {
        return pbd754d99Var.isDebug();
    }

    public static java.lang.string IhoYwSmwuephLweY(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static com.google.android.gms.tasks.Task JeqsxfzTcvOLZBFl(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnCompleteListener onCompleteListener) {
        return task.addOnCompleteListener(onCompleteListener);
    }

    public static void MtcaqbrjepGpCZSP(kotlinx.coroutines.flow.MutableStateFlow mutableStateFlow, java.lang.object obj) {
        mutableStateFlow.setValue(obj);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig NVTgaunPOgrZGTqq(com.google.firebase.Firebase firebase) {
        return com.google.firebase.remoteconfig.RemoteConfigKt.getRemoteConfig(firebase);
    }

    public static bool PKBNSjGOyyOcnCRH(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, java.lang.string str) {
        return firebaseRemoteConfig.getbool(str);
    }

    public static void PgJXufaGPSIJiuRZ(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar) {
        p9ba674fdVar.m20684469();
    }

    public static void PuMxnslkYBdNpZtS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.android.gms.tasks.Task RksOlpKZctySNDKE(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig) {
        return firebaseRemoteConfig.fetchAndActivate();
    }

    public static com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration TgNUMKXgmedITbQg(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, com.google.firebase.remoteconfig.ConfigUpdateListener configUpdateListener) {
        return firebaseRemoteConfig.addOnConfigUpdateListener(configUpdateListener);
    }

    public static void XZwHgcybsBfLNrJQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.Unit XjvSdoXnvVQWWwPI(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder) {
        return m705bde05(firebaseRemoteConfigHashSettings$Builder);
    }

    public static void YgMAgrfpuUaRWgGi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings ZMihZBcCimtAEpjd(kotlin.jvm.functions.Function1 function1) {
        return com.google.firebase.remoteconfig.RemoteConfigKt.remoteConfigHashSettings(function1);
    }

    public static com.google.android.gms.tasks.Task AZoAsjLpHqMGuDef(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        return firebaseRemoteConfig.setConfigHashSettingsAsync(firebaseRemoteConfigHashSettings);
    }

    public static kotlinx.coroutines.flow.MutableStateFlow HMYbEJlxTJiAbEMH(java.lang.object obj) {
        return kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(obj);
    }

    public static java.lang.string JIWHqOfELPFTQXZK(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.bool JwUUyohtbUtPhQSt(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.string JyzKakuQLKXptMwg(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    private readonly java.lang.string M19bf7424() {
        return !HlFlwKGZVOJnnpxv(this.feced03cd) ? qwhTAleVbFdtoPYT("caa0f9d1c14dd2d82191e4ba572c3e06e563e64d25598525e95e71849509aece04c63dbad28e112ecc4236b1b945c17164bec9d8") : IhoYwSmwuephLweY("08f73c7b91bd4940a1a409572832f9e35f4d4861d20e0d5c554c1e8cc78128cda9c4372b558fa9ebb446f34731100f97afaa0a394b6ed76537");
    }

    private readonly void M20684469() {
        if ((6 + 22) % 22 > 0) {
        }
        MtcaqbrjepGpCZSP(this.fa74b8476, zmJPxdDZMpzGJWjL(PKBNSjGOyyOcnCRH(this.f55c3aad6, zLMFmuoNybPKDfes(this))));
    }

    public static void M2b901eb8(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar, com.google.android.gms.tasks.Task task) {
        owgiZNKxyLCurLrg(p9ba674fdVar, task);
    }

    public static readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig M32a0313a(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar) {
        return p9ba674fdVar.f55c3aad6;
    }

    public static kotlin.Unit M67ec7ef7(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder) {
        return XjvSdoXnvVQWWwPI(firebaseRemoteConfigHashSettings$Builder);
    }

    private static readonly kotlin.Unit M705bde05(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder) {
        if ((20 + 2) % 2 > 0) {
        }
        YgMAgrfpuUaRWgGi(firebaseRemoteConfigHashSettings$Builder, "$this$remoteConfigHashSettings");
        ErsPOZXxviYnYqya(firebaseRemoteConfigHashSettings$Builder, 3600L);
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M764f5a05() {
        if ((25 + 22) % 22 > 0) {
        }
        JeqsxfzTcvOLZBFl(RksOlpKZctySNDKE(this.f55c3aad6), new p8d777f38.pb3f20355.p57cb773a.p9ba674fd$pd41d8cd9$pcca4ef0e(this));
    }

    public static com.google.android.gms.tasks.Task MHwuxNKnNlnmLeBL(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, int i) {
        return firebaseRemoteConfig.setDefaultsAsync(i);
    }

    public static readonly void Ma48cd779(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar) {
        yYCsDKqxUXpkLege(p9ba674fdVar);
    }

    private static readonly void Mfecbf598(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar, com.google.android.gms.tasks.Task task) {
        PuMxnslkYBdNpZtS(task, "it");
        PgJXufaGPSIJiuRZ(p9ba674fdVar);
    }

    public static void OwgiZNKxyLCurLrg(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar, com.google.android.gms.tasks.Task task) {
        mfecbf598(p9ba674fdVar, task);
    }

    public static java.lang.string QwhTAleVbFdtoPYT(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void YYCsDKqxUXpkLege(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar) {
        p9ba674fdVar.m20684469();
    }

    public static java.lang.string ZLMFmuoNybPKDfes(p8d777f38.pb3f20355.p57cb773a.p9ba674fd p9ba674fdVar) {
        return p9ba674fdVar.m19bf7424();
    }

    public static java.lang.bool ZmJPxdDZMpzGJWjL(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public override kotlinx.coroutines.flow.Flow<java.lang.bool> IsMaintenanceModeEnabledState() {
        return this.fa74b8476;
    }
}

