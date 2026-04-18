namespace WillowMaze.Wasm.Decompiled;


public readonly class pabb40c48<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.SingleSource fa67d4849;
    readonly io.reactivex.rxjava3.core.SingleSource faa05500a;
    readonly io.reactivex.rxjava3.core.SingleSource fc70561f6;

    public pabb40c48(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        super(observable);
        this.f795f3202 = singleSource;
    }

    public static void FAIzYTpBpyCoOAEv(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void PoRvqfnqJCETqmmt(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void XGqphTHtKUZTtDSP(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pabb40c48$pc87b636d pabb40c48_pc87b636d = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pabb40c48$pc87b636d(observer);
        FAIzYTpBpyCoOAEv(observer, pabb40c48_pc87b636d);
        PoRvqfnqJCETqmmt(this.f36cd38f4, pabb40c48_pc87b636d);
        xGqphTHtKUZTtDSP(this.f795f3202, pabb40c48_pc87b636d.f7af6fc45);
    }
}

