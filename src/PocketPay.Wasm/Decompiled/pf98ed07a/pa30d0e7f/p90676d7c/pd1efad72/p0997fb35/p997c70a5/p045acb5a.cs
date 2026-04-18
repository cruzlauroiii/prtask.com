namespace WillowMaze.Wasm.Decompiled;


public readonly class p045acb5a<T, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f59f90e0f;
    readonly io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Observable<T>, ? : io.reactivex.rxjava3.core.ObservableSource<R>> f5b3c3200;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f944905b8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd86e39f5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe1ae92cd;

    public p045acb5a(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Observable<T>, ? : io.reactivex.rxjava3.core.ObservableSource<R>> function) {
        super(observableSource);
        this.f5b3c3200 = function;
    }

    public static java.lang.object GvPdLqOtIBQhzFOE(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void DOOaVgFFJoTWLiZn(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void MwfwUEJsXqXYHFLk(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void PimHggUhWLXPIOoQ(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void QqcadWoHYYMOXbYG(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object RhSaAoHcKWlBSavc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 TZEcNGBqHOwVabDL() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99.m76ea0beb();
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((16 + 13) % 13 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 p99b05a99VarTZEcNGBqHOwVabDL = tZEcNGBqHOwVabDL();
        try {
            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) GvPdLqOtIBQhzFOE(rhSaAoHcKWlBSavc(this.f5b3c3200, p99b05a99VarTZEcNGBqHOwVabDL), "The selector returned a null ObservableSource");
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p045acb5a$pca9f6704 p045acb5a_pca9f6704 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p045acb5a$pca9f6704(observer);
            qqcadWoHYYMOXbYG(observableSource, p045acb5a_pca9f6704);
            pimHggUhWLXPIOoQ(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p045acb5a$p51584d0b(p99b05a99VarTZEcNGBqHOwVabDL, p045acb5a_pca9f6704));
        } catch (java.lang.Exception th) {
            dOOaVgFFJoTWLiZn(th);
            mwfwUEJsXqXYHFLk(th, observer);
        }
    }
}

