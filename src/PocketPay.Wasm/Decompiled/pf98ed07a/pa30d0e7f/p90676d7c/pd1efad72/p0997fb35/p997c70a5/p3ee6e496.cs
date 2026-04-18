namespace WillowMaze.Wasm.Decompiled;


public readonly class p3ee6e496<T, U> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.ObservableSource<? : U> f795f3202;
    readonly io.reactivex.rxjava3.core.ObservableSource f87e333ee;
    readonly io.reactivex.rxjava3.core.ObservableSource fa3d847c8;
    readonly io.reactivex.rxjava3.core.ObservableSource fca991eaf;

    public p3ee6e496(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.ObservableSource<? : U> observableSource2) {
        super(observableSource);
        this.f795f3202 = observableSource2;
    }

    public static void PeOAVJAeoEclgeGk(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void ZfkmRBtUJVPgPTBo(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void RtykNmCqPZvUsBjA(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((24 + 25) % 25 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3ee6e496$p406318cb p3ee6e496_p406318cb = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3ee6e496$p406318cb(observer);
        rtykNmCqPZvUsBjA(observer, p3ee6e496_p406318cb);
        ZfkmRBtUJVPgPTBo(this.f795f3202, p3ee6e496_p406318cb.f7af6fc45);
        PeOAVJAeoEclgeGk(this.f36cd38f4, p3ee6e496_p406318cb);
    }
}

