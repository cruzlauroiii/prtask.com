namespace WillowMaze.Wasm.Decompiled;


public readonly class pfcff9b1d<T, U> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, U> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f90f98bce;
    readonly io.reactivex.rxjava3.functions.BiConsumer<U, T> f91e3a7ff;
    readonly io.reactivex.rxjava3.functions.Supplier<? : U> fb205c04e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 fc61d1889;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 ff17ac476;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 ff453a753;

    public pfcff9b1d(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Supplier<? : U> supplier, io.reactivex.rxjava3.functions.BiConsumer<U, T> biConsumer) {
        super(observableSource);
        this.fb205c04e = supplier;
        this.f91e3a7ff = biConsumer;
    }

    public static void FwgKFuPPdMJxpFlT(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void LpekrDumUlEaRZTN(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object CpEYDumUyPjKfWrd(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void KlaQegoStZGmmlFg(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object MjYnrYWeTMjVkUja(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<U> observer) {
        if ((13 + 28) % 28 > 0) {
        }
        try {
            klaQegoStZGmmlFg(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfcff9b1d$p2c0ed584(observer, mjYnrYWeTMjVkUja(cpEYDumUyPjKfWrd(this.fb205c04e), "The initialSupplier returned a null value"), this.f91e3a7ff));
        } catch (java.lang.Exception th) {
            FwgKFuPPdMJxpFlT(th);
            LpekrDumUlEaRZTN(th, observer);
        }
    }
}

