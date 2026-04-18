namespace WillowMaze.Wasm.Decompiled;


public readonly class p13102011<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3d1e030f;
    readonly io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Observable<java.lang.object>, ? : io.reactivex.rxjava3.core.ObservableSource<object>> fc1cbfe27;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe7cdc3bc;

    public p13102011(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Observable<java.lang.object>, ? : io.reactivex.rxjava3.core.ObservableSource<object>> function) {
        super(observableSource);
        this.fc1cbfe27 = function;
    }

    public static void ClUgxhiSbDkOHwAo(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void DzsZskubeHnLJTSV(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 OaseJUDCKykxxjFH() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99.m76ea0beb();
    }

    public static void UDznbhJASsdElmmh(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object YuAmvdkOAEWsllss(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object GnbvJiglQCtHBDIr(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void PiejzurtxhyzBZHR(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pc7892ebb PqbxGQJvOQcooOKy(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 p99b05a99Var) {
        return p99b05a99Var.toSerialized();
    }

    public static void WwwGXMfeKPeUxQJi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p13102011$p5a445cbc p13102011_p5a445cbc) {
        p13102011_p5a445cbc.subscribeNext();
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((29 + 23) % 23 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pc7892ebb pc7892ebbVarPqbxGQJvOQcooOKy = pqbxGQJvOQcooOKy(OaseJUDCKykxxjFH());
        try {
            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) gnbvJiglQCtHBDIr(YuAmvdkOAEWsllss(this.fc1cbfe27, pc7892ebbVarPqbxGQJvOQcooOKy), "The handler returned a null ObservableSource");
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p13102011$p5a445cbc p13102011_p5a445cbc = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p13102011$p5a445cbc(observer, pc7892ebbVarPqbxGQJvOQcooOKy, this.f36cd38f4);
            piejzurtxhyzBZHR(observer, p13102011_p5a445cbc);
            UDznbhJASsdElmmh(observableSource, p13102011_p5a445cbc.fea97586b);
            wwwGXMfeKPeUxQJi(p13102011_p5a445cbc);
        } catch (java.lang.Exception th) {
            ClUgxhiSbDkOHwAo(th);
            DzsZskubeHnLJTSV(th, observer);
        }
    }
}

