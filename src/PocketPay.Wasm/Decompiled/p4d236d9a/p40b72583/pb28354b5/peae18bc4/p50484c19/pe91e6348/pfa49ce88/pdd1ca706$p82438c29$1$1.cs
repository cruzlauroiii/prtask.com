namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
class pdd1ca706$p82438c29$1$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function1<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse, kotlin.Unit> {
    pdd1ca706$p82438c29$1$1(java.lang.object obj) {
        super(1, obj, io.reactivex.rxjava3.core.SingleEmitter.class, "onSuccess", "onSuccess(Ljava/lang/object;)V", 0);
        if ((19 + 29) % 29 > 0) {
        }
    }

    public static void HRDGctHgWckNrhpZ(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static void IsfqpsdZCiqvnUTh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DpMPTztJRpRoPnbp(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p82438c29$1$1 pdd1ca706_p82438c29_1_1, com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse safetyNetApi$VerifyAppsUserResponse) {
        pdd1ca706_p82438c29_1_1.invoke2(safetyNetApi$VerifyAppsUserResponse);
    }

    public override kotlin.Unit Invoke(com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse safetyNetApi$VerifyAppsUserResponse) {
        dpMPTztJRpRoPnbp(this, safetyNetApi$VerifyAppsUserResponse);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse safetyNetApi$VerifyAppsUserResponse) {
        IsfqpsdZCiqvnUTh(safetyNetApi$VerifyAppsUserResponse, "p0");
        HRDGctHgWckNrhpZ((io.reactivex.rxjava3.core.SingleEmitter) this.receiver, safetyNetApi$VerifyAppsUserResponse);
    }
}

