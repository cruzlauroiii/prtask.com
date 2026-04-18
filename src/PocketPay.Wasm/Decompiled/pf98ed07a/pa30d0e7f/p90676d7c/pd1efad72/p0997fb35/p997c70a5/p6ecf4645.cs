namespace WillowMaze.Wasm.Decompiled;


public readonly class p6ecf4645<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f5689e5de;

    public p6ecf4645(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(observableSource);
        this.f499f31e7 = scheduler;
    }

    public static void LBUPZWLiqterHLZq(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((22 + 27) % 27 > 0) {
        }
        lBUPZWLiqterHLZq(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6ecf4645$p73ff2988(observer, this.f499f31e7));
    }
}

