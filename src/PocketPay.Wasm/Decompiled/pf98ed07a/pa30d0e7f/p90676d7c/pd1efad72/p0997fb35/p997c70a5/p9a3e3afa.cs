namespace WillowMaze.Wasm.Decompiled;


public readonly class p9a3e3afa<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Observable<java.lang.Exception>, ? : io.reactivex.rxjava3.core.ObservableSource<object>> fc1cbfe27;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff9cc7420;

    public p9a3e3afa(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Observable<java.lang.Exception>, ? : io.reactivex.rxjava3.core.ObservableSource<object>> function) {
        super(observableSource);
        this.fc1cbfe27 = function;
    }

    public static java.lang.object QNOllTsZbkQEQbSm(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void AXZdZRKQpxWpLuAe(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void BkehpInHeMdxRpFM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a3e3afa$p5a445cbc p9a3e3afa_p5a445cbc) {
        p9a3e3afa_p5a445cbc.subscribeNext();
    }

    public static java.lang.object EyewSBwhDXGHVRrX(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void JhBJBpOjYSvnxGuI(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 LbVhItgIXQDWLiSB() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99.m76ea0beb();
    }

    public static void MSDXAcCDbGqSgLGV(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pc7892ebb NHdeTZPawDBmdrxi(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 p99b05a99Var) {
        return p99b05a99Var.toSerialized();
    }

    public static void WTauFqsKlZHseIBV(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((27 + 27) % 27 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pc7892ebb pc7892ebbVarNHdeTZPawDBmdrxi = nHdeTZPawDBmdrxi(lbVhItgIXQDWLiSB());
        try {
            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) QNOllTsZbkQEQbSm(eyewSBwhDXGHVRrX(this.fc1cbfe27, pc7892ebbVarNHdeTZPawDBmdrxi), "The handler returned a null ObservableSource");
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a3e3afa$p5a445cbc p9a3e3afa_p5a445cbc = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a3e3afa$p5a445cbc(observer, pc7892ebbVarNHdeTZPawDBmdrxi, this.f36cd38f4);
            aXZdZRKQpxWpLuAe(observer, p9a3e3afa_p5a445cbc);
            jhBJBpOjYSvnxGuI(observableSource, p9a3e3afa_p5a445cbc.fea97586b);
            bkehpInHeMdxRpFM(p9a3e3afa_p5a445cbc);
        } catch (java.lang.Exception th) {
            mSDXAcCDbGqSgLGV(th);
            wTauFqsKlZHseIBV(th, observer);
        }
    }
}

