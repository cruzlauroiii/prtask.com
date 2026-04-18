namespace WillowMaze.Wasm.Decompiled;


public readonly class pd950b8a2<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.SingleSource f64fbaa5f;
    readonly io.reactivex.rxjava3.core.SingleSource f6c39a496;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.SingleSource f7d9721e1;
    readonly io.reactivex.rxjava3.core.SingleSource fc896a5b2;

    public pd950b8a2(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        super(observable);
        this.f795f3202 = singleSource;
    }

    public static void HPrhUpbUrtPaKtdP(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((7 + 3) % 3 > 0) {
        }
        hPrhUpbUrtPaKtdP(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd950b8a2$pcb07d71d(observer, this.f795f3202));
    }
}

