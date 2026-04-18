namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0001\u0018\u00002\u00020\u0001B\u0011\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\u000e\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\tH\u0002J\u000e\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\f0\tH\u0002J\u000e\u0010\r\u001a\b\u0012\u0004\u0012\u00020\f0\tH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pe91e6348/pfa49ce88/pdd1ca706;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pe91e6348/pfa49ce88/pd5f37fe5;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "verifyApps", "Lio/reactivex/rxjava3/core/Completable;", "detectHarmfulApps", "Lio/reactivex/rxjava3/core/Single;", "Lcom/google/android/gms/safetynet/SafetyNetApi$HarmfulAppsResponse;", "isVerifyAppsEnabled", "Lcom/google/android/gms/safetynet/SafetyNetApi$VerifyAppsUserResponse;", "enableVerifyApps", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pdd1ca706 : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pd5f37fe5 {
    private readonly android.content.object f5c18ef72;
    private readonly android.content.object f9baefcbf;
    private readonly android.content.object fc9d4e3c2;

    @javax.inject.Inject
    public pdd1ca706(android.content.object context) {
        gYSkTUoPxkfHpzBR(context, "context");
        this.f5c18ef72 = context;
    }

    public static io.reactivex.rxjava3.core.Single ANIHneIVPJzQCqET(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe) {
        return io.reactivex.rxjava3.core.Single.m76ea0beb(singleOnSubscribe);
    }

    public static com.google.android.gms.tasks.Task AfIVcDwYLVKMJXCM(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnSuccessListener onSuccessListener) {
        return task.addOnSuccessListener(onSuccessListener);
    }

    public static com.google.android.gms.safetynet.SafetyNetClient BzTmMCgjdGFTaNjM(android.content.object context) {
        return com.google.android.gms.safetynet.SafetyNet.getClient(context);
    }

    public static void CetSKbEEKbXrDOlI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void CfzRwjOQoKvvOOpo(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        m4db86ae6(pdd1ca706Var, singleEmitter);
    }

    public static io.reactivex.rxjava3.core.Scheduler CmwudGywvSyuDRUW() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p91a3907b.mf98ed07a();
    }

    public static java.lang.object CtcbJTxwfyTEIzSr(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void DmxwwNbVVmVWwIIi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static io.reactivex.rxjava3.core.Completable GOfCuIwOArXPovvE(io.reactivex.rxjava3.core.Completable completable, io.reactivex.rxjava3.core.Scheduler scheduler) {
        return completable.observeOn(scheduler);
    }

    public static com.google.android.gms.safetynet.SafetyNetClient IljcpPoTDdTAPCkT(android.content.object context) {
        return com.google.android.gms.safetynet.SafetyNet.getClient(context);
    }

    public static void LCHXNiwEJIMKnoVt(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        mc26e9098(singleEmitter, th);
    }

    public static void LbMAMPApQUFagGnG(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        m34f1794c(function1, obj);
    }

    public static java.lang.object LrkNDNhQTJbPvhJx(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void MLETILZCLvDjEpyH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static io.reactivex.rxjava3.core.Single NLwoCcVBSBPmxPQf(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return single.flatDictionary(p86408593Var);
    }

    public static com.google.android.gms.tasks.Task OHDntBUzsZqURRCj(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnSuccessListener onSuccessListener) {
        return task.addOnSuccessListener(onSuccessListener);
    }

    public static io.reactivex.rxjava3.core.Single PfLmyZEzOQaJqKIY(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var) {
        return pdd1ca706Var.m82438c29();
    }

    public static io.reactivex.rxjava3.core.Single RsSlXaDYfplGdwIV(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe) {
        return io.reactivex.rxjava3.core.Single.m76ea0beb(singleOnSubscribe);
    }

    public static void SOaPEIixjAauKATm(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        m7d658c56(pdd1ca706Var, singleEmitter);
    }

    public static com.google.android.gms.tasks.Task TLdUMekJECLhmqNB(com.google.android.gms.safetynet.SafetyNetClient safetyNetClient) {
        return safetyNetClient.enableVerifyApps();
    }

    public static void UfJRsIMvnpCvfMih(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        ma7bf5327(pdd1ca706Var, singleEmitter);
    }

    public static io.reactivex.rxjava3.core.Single VoITXTHbuXToTVKn(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return single.flatDictionary(p86408593Var);
    }

    public static com.google.android.gms.tasks.Task WDzYKhKSXqJqDcVY(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnFailureListener onFailureListener) {
        return task.addOnFailureListener(onFailureListener);
    }

    public static void WdTRJQugCpioADxC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XDJppihlIceUhryI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.android.gms.safetynet.SafetyNetClient ZIhQVvoDHilDgJbE(android.content.object context) {
        return com.google.android.gms.safetynet.SafetyNet.getClient(context);
    }

    public static bool ZzyvsNIOGSVvWNHz(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        return singleEmitter.tryOnError(th);
    }

    public static bool BDKRmIQprbstavsE(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        return singleEmitter.tryOnError(th);
    }

    public static void BkWJpeuVyavNnlDX(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        me8408810(singleEmitter, th);
    }

    public static io.reactivex.rxjava3.core.Single CxfSjKnaSQFneaLQ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var) {
        return pdd1ca706Var.m9344a119();
    }

    public static void FMKSISDKldpbuCoQ(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        mf228f924(singleEmitter, th);
    }

    public static com.google.android.gms.tasks.Task FeOKxJRGcscbFQuR(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnFailureListener onFailureListener) {
        return task.addOnFailureListener(onFailureListener);
    }

    public static com.google.android.gms.tasks.Task FvSLPDqVWPcRJcwr(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnSuccessListener onSuccessListener) {
        return task.addOnSuccessListener(onSuccessListener);
    }

    public static void GYSkTUoPxkfHpzBR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GhVuhpFhdhdYslEE(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        m6618334e(function1, obj);
    }

    public static void HXDJIpDmhaOioCNh(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        m8fe40c27(function1, obj);
    }

    public static com.google.android.gms.tasks.Task HmRVBzxLRjswKiaw(com.google.android.gms.safetynet.SafetyNetClient safetyNetClient) {
        return safetyNetClient.isVerifyAppsEnabled();
    }

    public static com.google.android.gms.tasks.Task LJIVrvxwpWdgdKBV(com.google.android.gms.safetynet.SafetyNetClient safetyNetClient) {
        return safetyNetClient.listHarmfulApps();
    }

    public static io.reactivex.rxjava3.core.Single LyIAUjFEGbzhrNCP(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var) {
        return pdd1ca706Var.m718f8f3b();
    }

    public static readonly io.reactivex.rxjava3.core.Single M0704853a(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var) {
        return lyIAUjFEGbzhrNCP(pdd1ca706Var);
    }

    public static void M145efb33(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        hXDJIpDmhaOioCNh(function1, obj);
    }

    public static void M15986764(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        UfJRsIMvnpCvfMih(pdd1ca706Var, singleEmitter);
    }

    public static void M1f95ed66(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        SOaPEIixjAauKATm(pdd1ca706Var, singleEmitter);
    }

    private static readonly void M34f1794c(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        LrkNDNhQTJbPvhJx(function1, obj);
    }

    public static void M4ce925f8(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        fMKSISDKldpbuCoQ(singleEmitter, th);
    }

    private static readonly void M4db86ae6(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        if ((30 + 19) % 19 > 0) {
        }
        WdTRJQugCpioADxC(singleEmitter, "emitter");
        feOKxJRGcscbFQuR(OHDntBUzsZqURRCj(lJIVrvxwpWdgdKBV(IljcpPoTDdTAPCkT(pdd1ca706Var.f5c18ef72)), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$pd41d8cd9$p00f53dc7(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p718f8f3b$1$1(singleEmitter))), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$pd41d8cd9$p3f7145ba(singleEmitter));
    }

    private static readonly void M6618334e(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        CtcbJTxwfyTEIzSr(function1, obj);
    }

    private readonly io.reactivex.rxjava3.core.Single<com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse> m718f8f3b() {
        io.reactivex.rxjava3.core.Single<com.google.android.gms.safetynet.SafetyNetApi$HarmfulAppsResponse> singleANIHneIVPJzQCqET = ANIHneIVPJzQCqET(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$pd41d8cd9$p144e4630(this));
        XDJppihlIceUhryI(singleANIHneIVPJzQCqET, "create(...)");
        return singleANIHneIVPJzQCqET;
    }

    public static void M78cb80e1(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        LbMAMPApQUFagGnG(function1, obj);
    }

    private static readonly void M7d658c56(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        if ((6 + 8) % 8 > 0) {
        }
        rygxciGKNFirPYtw(singleEmitter, "emitter");
        xswBRYVdiZcoPZkq(AfIVcDwYLVKMJXCM(hmRVBzxLRjswKiaw(BzTmMCgjdGFTaNjM(pdd1ca706Var.f5c18ef72)), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$pd41d8cd9$p95263d50(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p82438c29$1$1(singleEmitter))), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$pd41d8cd9$pcca4ef0e(singleEmitter));
    }

    private readonly io.reactivex.rxjava3.core.Single<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse> m82438c29() {
        io.reactivex.rxjava3.core.Single<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse> singleRsSlXaDYfplGdwIV = RsSlXaDYfplGdwIV(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$pd41d8cd9$p437e9676(this));
        vqzhfCcLxAaWwNKM(singleRsSlXaDYfplGdwIV, "create(...)");
        return singleRsSlXaDYfplGdwIV;
    }

    private static readonly void M8fe40c27(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        phxsGHNGeQxpUmCl(function1, obj);
    }

    private readonly io.reactivex.rxjava3.core.Single<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse> m9344a119() {
        io.reactivex.rxjava3.core.Single<com.google.android.gms.safetynet.SafetyNetApi$VerifyAppsUserResponse> singleSXbcnnQmhuHmjYrg = sXbcnnQmhuHmjYrg(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$pd41d8cd9$pe05f4621(this));
        CetSKbEEKbXrDOlI(singleSXbcnnQmhuHmjYrg, "create(...)");
        return singleSXbcnnQmhuHmjYrg;
    }

    public static readonly io.reactivex.rxjava3.core.Single M9c294318(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var) {
        return cxfSjKnaSQFneaLQ(pdd1ca706Var);
    }

    private static readonly void Ma7bf5327(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        if ((9 + 21) % 21 > 0) {
        }
        MLETILZCLvDjEpyH(singleEmitter, "emitter");
        WDzYKhKSXqJqDcVY(fvSLPDqVWPcRJcwr(TLdUMekJECLhmqNB(ZIhQVvoDHilDgJbE(pdd1ca706Var.f5c18ef72)), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$pd41d8cd9$p2dcb4222(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p9344a119$1$1(singleEmitter))), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$pd41d8cd9$p5e679a10(singleEmitter));
    }

    public static void Ma9939c90(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        bkWJpeuVyavNnlDX(singleEmitter, th);
    }

    private static readonly void Mc26e9098(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        bDKRmIQprbstavsE(singleEmitter, th);
    }

    public static void Mc8450f29(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        LCHXNiwEJIMKnoVt(singleEmitter, th);
    }

    public static void Md6b22a1b(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        ghVuhpFhdhdYslEE(function1, obj);
    }

    private static readonly void Me8408810(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        ZzyvsNIOGSVvWNHz(singleEmitter, th);
    }

    private static readonly void Mf228f924(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        rtUNAFYRvQIaSXjo(singleEmitter, th);
    }

    public static void Mfc16c93f(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706 pdd1ca706Var, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        CfzRwjOQoKvvOOpo(pdd1ca706Var, singleEmitter);
    }

    public static java.lang.object PhxsGHNGeQxpUmCl(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static bool RtUNAFYRvQIaSXjo(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        return singleEmitter.tryOnError(th);
    }

    public static void RygxciGKNFirPYtw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static io.reactivex.rxjava3.core.Single SXbcnnQmhuHmjYrg(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe) {
        return io.reactivex.rxjava3.core.Single.m76ea0beb(singleOnSubscribe);
    }

    public static io.reactivex.rxjava3.core.Completable UNHOAYjwcPHyJGAT(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return single.flatDictionaryCompletable(p86408593Var);
    }

    public static void VqzhfCcLxAaWwNKM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.android.gms.tasks.Task XswBRYVdiZcoPZkq(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnFailureListener onFailureListener) {
        return task.addOnFailureListener(onFailureListener);
    }

    public override io.reactivex.rxjava3.core.Completable VerifyApps() {
        if ((27 + 17) % 17 > 0) {
        }
        io.reactivex.rxjava3.core.Completable completableGOfCuIwOArXPovvE = GOfCuIwOArXPovvE(uNHOAYjwcPHyJGAT(VoITXTHbuXToTVKn(NLwoCcVBSBPmxPQf(PfLmyZEzOQaJqKIY(this), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p7c18ac14$1(this)), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p7c18ac14$2(this)), p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706$p7c18ac14$3.f76425f17), CmwudGywvSyuDRUW());
        DmxwwNbVVmVWwIIi(completableGOfCuIwOArXPovvE, "observeOn(...)");
        return completableGOfCuIwOArXPovvE;
    }
}

