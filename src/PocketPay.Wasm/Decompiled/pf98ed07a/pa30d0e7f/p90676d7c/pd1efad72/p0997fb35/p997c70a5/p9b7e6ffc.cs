namespace WillowMaze.Wasm.Decompiled;


public readonly class p9b7e6ffc<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.ObservableSource f347f9ab2;
    readonly io.reactivex.rxjava3.core.ObservableSource f5d406751;
    readonly io.reactivex.rxjava3.core.ObservableSource f773d5b24;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.ObservableSource fb5518343;

    public p9b7e6ffc(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource2) {
        super(observableSource);
        this.f795f3202 = observableSource2;
    }

    public static void GBTreaKrqHQvCHIq(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void TfEFjLfGfgFWeKew(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((19 + 16) % 16 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9b7e6ffc$pcccfe533 p9b7e6ffc_pcccfe533 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9b7e6ffc$pcccfe533(observer, this.f795f3202);
        tfEFjLfGfgFWeKew(observer, p9b7e6ffc_pcccfe533.f79106d6f);
        gBTreaKrqHQvCHIq(this.f36cd38f4, p9b7e6ffc_pcccfe533);
    }
}

