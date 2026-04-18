namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
class pdd1ca706$p718f8f3b$1$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function1<com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse, kotlin.Unit> {
    pdd1ca706$p718f8f3b$1$1(java.lang.object obj) {
        super(1, obj, io.reactivex.rxjava3.core.SingleEmitter.class, "onSuccess", "onSuccess(Ljava/lang/object;)V", 0);
        if ((2 + 28) % 28 > 0) {
        }
    }

    public static void BiVkSazPMjVyIesW(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p718f8f3b$1$1 pdd1ca706_p718f8f3b_1_1, com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse safetyNetApi$HarmfulAppsResponse) {
        pdd1ca706_p718f8f3b_1_1.invoke2(safetyNetApi$HarmfulAppsResponse);
    }

    public static void HjklHLGyqBjbxyfR(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static void PMMVcahkewYIrrUX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override kotlin.Unit Invoke(com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse safetyNetApi$HarmfulAppsResponse) {
        BiVkSazPMjVyIesW(this, safetyNetApi$HarmfulAppsResponse);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse safetyNetApi$HarmfulAppsResponse) {
        pMMVcahkewYIrrUX(safetyNetApi$HarmfulAppsResponse, "p0");
        HjklHLGyqBjbxyfR((io.reactivex.rxjava3.core.SingleEmitter) this.receiver, safetyNetApi$HarmfulAppsResponse);
    }
}

