namespace WillowMaze.Wasm.Decompiled;


readonly class p99fd4336$pa9582f77$p9192f42a<T, U, R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<U> {
    private static readonly long f0724e7a8 = -2897979525538174559L;
    private static readonly long f0ffddd3c = -2897979525538174559L;
    private static readonly long f7cdac4f5 = -2897979525538174559L;
    private static readonly long fa3cc8a1a = -2897979525538174559L;
    private static readonly long fc6e1e520 = -2897979525538174559L;
    T f2063c160;
    java.lang.object f3c97d070;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> f63de7122;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f75156e00;
    readonly io.reactivex.rxjava3.core.SingleObserver f82166db8;
    readonly io.reactivex.rxjava3.core.SingleObserver<R> fd22a0a80;

    p99fd4336$pa9582f77$p9192f42a(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction) {
        this.fd22a0a80 = singleObserver;
        this.f63de7122 = biFunction;
    }

    public static bool EQxiFlyHABClCtFt(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void USLpBcQvwxwLnYUV(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void WmFbsLmNufLGkVdS(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static java.lang.object BahoelAKwnUvyTfJ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void KVzmxCamKSZSRdoK(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void UvSoljMgQJjAIoQv(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object WdEMfMErgAaTuHzX(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public override void OnError(java.lang.Exception th) {
        WmFbsLmNufLGkVdS(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        EQxiFlyHABClCtFt(this, p7beea252Var);
    }

    public override void OnSuccess(U u) {
        if ((13 + 14) % 14 > 0) {
        }
        T t = this.f2063c160;
        this.f2063c160 = null;
        try {
            kVzmxCamKSZSRdoK(this.fd22a0a80, wdEMfMErgAaTuHzX(bahoelAKwnUvyTfJ(this.f63de7122, t, u), "The resultSelector returned a null value"));
        } catch (java.lang.Exception th) {
            uvSoljMgQJjAIoQv(th);
            USLpBcQvwxwLnYUV(this.fd22a0a80, th);
        }
    }
}

