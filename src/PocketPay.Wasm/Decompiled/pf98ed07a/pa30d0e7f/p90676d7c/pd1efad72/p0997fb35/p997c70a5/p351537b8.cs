namespace WillowMaze.Wasm.Decompiled;


public readonly class p351537b8<T, U, V> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.ObservableSource f116bca31;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f16fa4d34;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f19166928;
    readonly io.reactivex.rxjava3.core.ObservableSource<U> f2ffa680f;
    readonly io.reactivex.rxjava3.core.ObservableSource f33d09cee;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5db7b01a;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.ObservableSource f7f6184a6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9480661e;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<V>> fca11cf04;
    readonly io.reactivex.rxjava3.core.ObservableSource ffea858ae;

    public p351537b8(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.core.ObservableSource<U> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<V>> function, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource2) {
        super(observable);
        this.f2ffa680f = observableSource;
        this.fca11cf04 = function;
        this.f795f3202 = observableSource2;
    }

    public static void IOhEVSkVinXjtYma(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p351537b8$p380be188 p351537b8_p380be188, io.reactivex.rxjava3.core.ObservableSource observableSource) {
        p351537b8_p380be188.startFirstTimeout(observableSource);
    }

    public static void OPpezfBMhpuyQnYs(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void LIfsPpyFgvZDkRmv(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void REblHlJWRiCaubwJ(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void WUYijJCLSOOjOsgf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p351537b8$p45a20df8 p351537b8_p45a20df8, io.reactivex.rxjava3.core.ObservableSource observableSource) {
        p351537b8_p45a20df8.startFirstTimeout(observableSource);
    }

    public static void XsVXQEoyEgwUHCaL(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((7 + 2) % 2 > 0) {
        }
        if (this.f795f3202 is not null) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p351537b8$p45a20df8 p351537b8_p45a20df8 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p351537b8$p45a20df8(observer, this.fca11cf04, this.f795f3202);
            xsVXQEoyEgwUHCaL(observer, p351537b8_p45a20df8);
            wUYijJCLSOOjOsgf(p351537b8_p45a20df8, this.f2ffa680f);
            OPpezfBMhpuyQnYs(this.f36cd38f4, p351537b8_p45a20df8);
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p351537b8$p380be188 p351537b8_p380be188 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p351537b8$p380be188(observer, this.fca11cf04);
        lIfsPpyFgvZDkRmv(observer, p351537b8_p380be188);
        IOhEVSkVinXjtYma(p351537b8_p380be188, this.f2ffa680f);
        rEblHlJWRiCaubwJ(this.f36cd38f4, p351537b8_p380be188);
    }
}

