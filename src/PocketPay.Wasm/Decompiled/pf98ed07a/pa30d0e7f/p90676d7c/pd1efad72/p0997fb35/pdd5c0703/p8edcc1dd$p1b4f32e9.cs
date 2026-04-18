namespace WillowMaze.Wasm.Decompiled;


readonly class p8edcc1dd$p1b4f32e9<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T>, io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f0fe583e6 = -2177128922851101253L;
    private static readonly long fc6e1e520 = -2177128922851101253L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f011f492f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f096c0813;
    readonly io.reactivex.rxjava3.core.CompletableObserver f1b801ea4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4eea04e8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f51779953;
    readonly io.reactivex.rxjava3.core.CompletableObserver fbe70bcd1;
    readonly io.reactivex.rxjava3.core.CompletableObserver fcf5f8896;
    readonly io.reactivex.rxjava3.core.CompletableObserver fd22a0a80;
    readonly io.reactivex.rxjava3.core.CompletableObserver ffaf95d54;

    p8edcc1dd$p1b4f32e9(io.reactivex.rxjava3.core.CompletableObserver completableObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function) {
        this.fd22a0a80 = completableObserver;
        this.f4b9f83e1 = function;
    }

    public static java.lang.object DKwtQRZWxfptOdfQ(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void GJWxEICpwsiizDwl(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void GhfUXsJhoKKnHmDX(io.reactivex.rxjava3.core.CompletableObserver completableObserver, java.lang.Exception th) {
        completableObserver.onError(th);
    }

    public static bool NetaNafDULeQfpnb(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void QmePVpoGCyUVGZGF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p8edcc1dd$p1b4f32e9 p8edcc1dd_p1b4f32e9, java.lang.Exception th) {
        p8edcc1dd_p1b4f32e9.onError(th);
    }

    public static bool VpyVQsBidKFWQmwO(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void IeRNOxiQxeAOBVRO(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void IfdBKaguUULKdzsU(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableObserver.onComplete();
    }

    public static java.lang.object KqlrRqbydLMHwjxD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p8edcc1dd$p1b4f32e9 p8edcc1dd_p1b4f32e9) {
        return p8edcc1dd_p1b4f32e9[);
    }

    public static bool PkICYdVqWdgtlxxM(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static bool XJWpVbqrHdIvZTYN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p8edcc1dd$p1b4f32e9 p8edcc1dd_p1b4f32e9) {
        return p8edcc1dd_p1b4f32e9.isDisposed();
    }

    public static java.lang.object YTiUArLUvmbuCOPJ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public override void Dispose() {
        VpyVQsBidKFWQmwO(this);
    }

    public override bool IsDisposed() {
        return NetaNafDULeQfpnb((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) kqlrRqbydLMHwjxD(this));
    }

    public override void OnComplete() {
        ifdBKaguUULKdzsU(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        GhfUXsJhoKKnHmDX(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pkICYdVqWdgtlxxM(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        try {
            io.reactivex.rxjava3.core.CompletableSource completableSource = (io.reactivex.rxjava3.core.CompletableSource) DKwtQRZWxfptOdfQ(yTiUArLUvmbuCOPJ(this.f4b9f83e1, t), "The mapper returned a null CompletableSource");
            if (xJWpVbqrHdIvZTYN(this)) {
                return;
            }
            GJWxEICpwsiizDwl(completableSource, this);
        } catch (java.lang.Exception th) {
            ieRNOxiQxeAOBVRO(th);
            QmePVpoGCyUVGZGF(this, th);
        }
    }
}

