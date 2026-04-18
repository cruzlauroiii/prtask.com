namespace WillowMaze.Wasm.Decompiled;


readonly class pf135f7cd$pa9582f77$p9192f42a<T, U, R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<U> {
    private static readonly long f9f590705 = -2897979525538174559L;
    private static readonly long fc6e1e520 = -2897979525538174559L;
    private static readonly long ffea53ada = -2897979525538174559L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f008b8325;
    T f2063c160;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f42ec1206;
    readonly io.reactivex.rxjava3.core.MaybeObserver f4b0385b1;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> f63de7122;
    readonly io.reactivex.rxjava3.core.MaybeObserver f7b643e65;
    readonly io.reactivex.rxjava3.core.MaybeObserver f820bd4a5;
    java.lang.object f91f7277f;
    readonly io.reactivex.rxjava3.core.MaybeObserver<R> fd22a0a80;
    java.lang.object fdc9c5021;

    pf135f7cd$pa9582f77$p9192f42a(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction) {
        this.fd22a0a80 = maybeObserver;
        this.f63de7122 = biFunction;
    }

    public static java.lang.object GsyvzgnWwyumdXWz(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static java.lang.object VWqjLkAoZKAAxMWs(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void YRKJfFZtzCsiZyKU(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static bool HIRSKgxbFqZbwDsH(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void HcjCBkGggnpiDfjj(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void MwhlVWxJkQCZPmMG(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void QEvcxiKEursmyCRg(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void SreSyNpUswqughFr(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void OnComplete() {
        YRKJfFZtzCsiZyKU(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        sreSyNpUswqughFr(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        hIRSKgxbFqZbwDsH(this, p7beea252Var);
    }

    public override void OnSuccess(U u) {
        if ((22 + 25) % 25 > 0) {
        }
        T t = this.f2063c160;
        this.f2063c160 = null;
        try {
            mwhlVWxJkQCZPmMG(this.fd22a0a80, VWqjLkAoZKAAxMWs(GsyvzgnWwyumdXWz(this.f63de7122, t, u), "The resultSelector returned a null value"));
        } catch (java.lang.Exception th) {
            hcjCBkGggnpiDfjj(th);
            qEvcxiKEursmyCRg(this.fd22a0a80, th);
        }
    }
}

