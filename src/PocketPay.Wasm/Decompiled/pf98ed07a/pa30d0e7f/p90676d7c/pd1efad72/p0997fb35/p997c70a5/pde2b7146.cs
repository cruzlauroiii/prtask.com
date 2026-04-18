namespace WillowMaze.Wasm.Decompiled;


public readonly class pde2b7146<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.MaybeSource f335278fc;
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.MaybeSource fe858c693;

    public pde2b7146(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource) {
        super(observable);
        this.f795f3202 = maybeSource;
    }

    public static void YRgeezDGazanlXQV(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((4 + 15) % 15 > 0) {
        }
        YRgeezDGazanlXQV(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pde2b7146$pcb07d71d(observer, this.f795f3202));
    }
}

