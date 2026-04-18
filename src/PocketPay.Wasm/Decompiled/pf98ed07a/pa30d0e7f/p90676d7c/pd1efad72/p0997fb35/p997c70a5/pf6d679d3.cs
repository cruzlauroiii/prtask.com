namespace WillowMaze.Wasm.Decompiled;


public readonly class pf6d679d3<T, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f4b044fb6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f5ac73544;
    readonly io.reactivex.rxjava3.functions.Supplier<R> f5d7a373a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f8c550b58;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fbdc1d413;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fc1ba96d0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 ffb3618ab;

    public pf6d679d3(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Supplier<R> supplier, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction) {
        super(observableSource);
        this.fbdc1d413 = biFunction;
        this.f5d7a373a = supplier;
    }

    public static java.lang.object GxSqWYzJXrRfgNet(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void QGypzdLGjcgNpHOH(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void YPjkALbwrIaPXCzP(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object NqrDLHuceNwhAtQM(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void PPBolERZePEhExHV(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((13 + 22) % 22 > 0) {
        }
        try {
            YPjkALbwrIaPXCzP(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pf6d679d3$p48b14bd7(observer, this.fbdc1d413, GxSqWYzJXrRfgNet(nqrDLHuceNwhAtQM(this.f5d7a373a), "The seed supplied is null")));
        } catch (java.lang.Exception th) {
            pPBolERZePEhExHV(th);
            QGypzdLGjcgNpHOH(th, observer);
        }
    }
}

