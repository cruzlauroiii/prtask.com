namespace WillowMaze.Wasm.Decompiled;


public readonly class pac030d5c<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.MaybeSource f5afe733d;
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T> f795f3202;

    public pac030d5c(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource) {
        super(observable);
        this.f795f3202 = maybeSource;
    }

    public static void PUzMvMJKxasKWqqq(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void JOCXdJsCqzlkdLcC(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void JcwhqJRSEzaPrlSK(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d(observer);
        jcwhqJRSEzaPrlSK(observer, pac030d5c_pc87b636d);
        jOCXdJsCqzlkdLcC(this.f36cd38f4, pac030d5c_pc87b636d);
        PUzMvMJKxasKWqqq(this.f795f3202, pac030d5c_pc87b636d.f7af6fc45);
    }
}

