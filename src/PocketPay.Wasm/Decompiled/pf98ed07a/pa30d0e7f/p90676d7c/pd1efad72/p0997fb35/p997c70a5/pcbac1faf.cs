namespace WillowMaze.Wasm.Decompiled;


public readonly class pcbac1faf<T, R> : io.reactivex.rxjava3.core.Single<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f11192d06;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f205caa0d;
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f5addc56d;
    readonly io.reactivex.rxjava3.functions.Supplier<R> f5d7a373a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f78035006;
    readonly io.reactivex.rxjava3.core.ObservableSource fe63561a5;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fe6392c2b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba ff015c11f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 ff93f77d5;

    public pcbac1faf(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Supplier<R> supplier, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction) {
        this.f36cd38f4 = observableSource;
        this.f5d7a373a = supplier;
        this.fe6392c2b = biFunction;
    }

    public static java.lang.object DJHKDqEcINUVxzGr(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void LoyUvTUsqVfTpmav(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void QyXrAjBtRrGzFqIU(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static void AXWYpsVkMqMEqgZd(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object DbyRtftcAnIQpepK(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        if ((16 + 26) % 26 > 0) {
        }
        try {
            aXWYpsVkMqMEqgZd(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0ef92064$p32707b45(singleObserver, this.fe6392c2b, dbyRtftcAnIQpepK(DJHKDqEcINUVxzGr(this.f5d7a373a), "The seedSupplier returned a null value")));
        } catch (java.lang.Exception th) {
            LoyUvTUsqVfTpmav(th);
            QyXrAjBtRrGzFqIU(th, singleObserver);
        }
    }
}

