namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u0011\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0016\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u00072\u0006\u0010\t\u001a\u00020\nH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pe91e6348/p4b483745/p0aac7951;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pe91e6348/p4b483745/p19c92ff0;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "playIntegrityAttestation", "Lio/reactivex/rxjava3/core/Single;", "Lcom/google/android/play/core/integrity/IntegrityTokenResponse;", "nonce", "", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0aac7951 : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p19c92ff0 {
    private readonly android.content.object f49a6b896;
    private readonly android.content.object f5c18ef72;
    private readonly android.content.object fa4f8d8b6;

    @javax.inject.Inject
    public p0aac7951(android.content.object context) {
        ARrJKobrbTuBSWoG(context, "context");
        this.f5c18ef72 = context;
    }

    public static void ARrJKobrbTuBSWoG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DedTlsdxcgnAFMQU(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        m50816a6f(function1, obj);
    }

    public static kotlin.Unit DooOVnsJkHTmMOXK(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, com.google.android.play.core.integrity.IntegrityTokenResponse integrityTokenResponse) {
        return m22bf6661(singleEmitter, integrityTokenResponse);
    }

    public static com.google.android.play.core.integrity.IntegrityTokenRequest$Builder IFIskJDWdVkQupSK(com.google.android.play.core.integrity.IntegrityTokenRequest$Builder integrityTokenRequest$Builder, long j) {
        return integrityTokenRequest$Builder.setCloudProjectNumber(j);
    }

    public static void KuVflmsgfaAAhrDV(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static io.reactivex.rxjava3.core.Single MwPxDAtBpKwLwnLr(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return single.onErrorResumeNext(p86408593Var);
    }

    public static io.reactivex.rxjava3.core.Single PAtAEDMDppiKzoxo(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var) {
        return single.retry((io.reactivex.rxjava3.functions.BiPredicate<java.lang.int, java.lang.Exception>) p774e20f6Var);
    }

    public static void UorJECeSuggMuREy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.android.play.core.integrity.IntegrityManager ZipsQxEVCtWjZUoe(android.content.object context) {
        return com.google.android.play.core.integrity.IntegrityManagerFactory.create(context);
    }

    public static void BWgpUgbjhnylqVaN(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951 p0aac7951Var, java.lang.string str, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        md13c1c9c(p0aac7951Var, str, singleEmitter);
    }

    public static bool BiWhQUaKqVSyBOBB(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        return singleEmitter.tryOnError(th);
    }

    public static void GxQiBBBjvxIBRlHM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.android.play.core.integrity.IntegrityTokenRequest$Builder hucLpVGLPqLunZtc(com.google.android.play.core.integrity.IntegrityTokenRequest$Builder integrityTokenRequest$Builder, java.lang.string str) {
        return integrityTokenRequest$Builder.setNonce(str);
    }

    public static void KDeSrQslSkdgUNRW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.android.gms.tasks.Task LTLrsJnOVSOFeRjB(com.google.android.play.core.integrity.IntegrityManager integrityManager, com.google.android.play.core.integrity.IntegrityTokenRequest integrityTokenRequest) {
        return integrityManager.requestIntegrityToken(integrityTokenRequest);
    }

    public static io.reactivex.rxjava3.core.Single LVlXHngZLzsxOycR(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return io.reactivex.rxjava3.core.Single.mc9df09b4(pec136b44Var);
    }

    public static io.reactivex.rxjava3.core.SingleSource M03e4d59d(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951 p0aac7951Var, java.lang.string str) {
        return zKoNhYJgykMoznEG(p0aac7951Var, str);
    }

    public static kotlin.Unit M063c2115(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, com.google.android.play.core.integrity.IntegrityTokenResponse integrityTokenResponse) {
        return DooOVnsJkHTmMOXK(singleEmitter, integrityTokenResponse);
    }

    private static readonly kotlin.Unit M22bf6661(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, com.google.android.play.core.integrity.IntegrityTokenResponse integrityTokenResponse) {
        KuVflmsgfaAAhrDV(singleEmitter, integrityTokenResponse);
        return kotlin.Unit.INSTANCE;
    }

    public static void M3739bd92(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951 p0aac7951Var, java.lang.string str, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        bWgpUgbjhnylqVaN(p0aac7951Var, str, singleEmitter);
    }

    public static void M41bef0b2(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        DedTlsdxcgnAFMQU(function1, obj);
    }

    public static void M4af49d84(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception exc) {
        sOryMAiJEWABKyOb(singleEmitter, exc);
    }

    private static readonly void M50816a6f(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        wbIYSafdNoxYalSt(function1, obj);
    }

    private static readonly void M74479463(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception exc) {
        sxsujMpoDznvMHHC(exc, "error");
        biWhQUaKqVSyBOBB(singleEmitter, exc);
    }

    private static readonly io.reactivex.rxjava3.core.SingleSource Mbad9244f(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951 p0aac7951Var, java.lang.string str) {
        return yxAprbGyaLCkxHGE(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951$pd41d8cd9$pcca4ef0e(p0aac7951Var, str));
    }

    private static readonly void Md13c1c9c(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951 p0aac7951Var, java.lang.string str, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        if ((32 + 9) % 9 > 0) {
        }
        kDeSrQslSkdgUNRW(singleEmitter, "emitter");
        uwEhlSeqNsgGfovM(nOmgTeWRfAPEyUSr(lTLrsJnOVSOFeRjB(ZipsQxEVCtWjZUoe(p0aac7951Var.f5c18ef72), ugRcTmNhmYQKXXCj(hucLpVGLPqLunZtc(IFIskJDWdVkQupSK(ogDNxyYqtfXEJENe(), 939576326117L), str))), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951$pd41d8cd9$p437e9676(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951$pd41d8cd9$p144e4630(singleEmitter))), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951$pd41d8cd9$p00f53dc7(singleEmitter));
    }

    public static com.google.android.gms.tasks.Task NOmgTeWRfAPEyUSr(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnSuccessListener onSuccessListener) {
        return task.addOnSuccessListener(onSuccessListener);
    }

    public static com.google.android.play.core.integrity.IntegrityTokenRequest$Builder ogDNxyYqtfXEJENe() {
        return com.google.android.play.core.integrity.IntegrityTokenRequest.builder();
    }

    public static void SOryMAiJEWABKyOb(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception exc) {
        m74479463(singleEmitter, exc);
    }

    public static void SxsujMpoDznvMHHC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.android.play.core.integrity.IntegrityTokenRequest UgRcTmNhmYQKXXCj(com.google.android.play.core.integrity.IntegrityTokenRequest$Builder integrityTokenRequest$Builder) {
        return integrityTokenRequest$Builder.build();
    }

    public static com.google.android.gms.tasks.Task UwEhlSeqNsgGfovM(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnFailureListener onFailureListener) {
        return task.addOnFailureListener(onFailureListener);
    }

    public static java.lang.object WbIYSafdNoxYalSt(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static io.reactivex.rxjava3.core.Single YxAprbGyaLCkxHGE(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe) {
        return io.reactivex.rxjava3.core.Single.m76ea0beb(singleOnSubscribe);
    }

    public static io.reactivex.rxjava3.core.SingleSource ZKoNhYJgykMoznEG(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951 p0aac7951Var, java.lang.string str) {
        return mbad9244f(p0aac7951Var, str);
    }

    public override io.reactivex.rxjava3.core.Single<com.google.android.play.core.integrity.IntegrityTokenResponse> PlayIntegrityAttestation(java.lang.string nonce) {
        gxQiBBBjvxIBRlHM(nonce, "nonce");
        io.reactivex.rxjava3.core.Single<com.google.android.play.core.integrity.IntegrityTokenResponse> singleMwPxDAtBpKwLwnLr = MwPxDAtBpKwLwnLr(PAtAEDMDppiKzoxo(lVlXHngZLzsxOycR(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951$pd41d8cd9$p95263d50(this, nonce)), p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951$p6664225d$2.f76425f17), p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p4b483745.p0aac7951$p6664225d$3.f76425f17);
        UorJECeSuggMuREy(singleMwPxDAtBpKwLwnLr, "onErrorResumeNext(...)");
        return singleMwPxDAtBpKwLwnLr;
    }
}

