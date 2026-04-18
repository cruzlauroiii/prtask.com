namespace WillowMaze.Wasm.Decompiled;


public readonly class p90f99b24<T> : io.reactivex.rxjava3.core.Flowable<T> {
    private readonly io.reactivex.rxjava3.core.ObservableSource f0eb086c7;
    private readonly io.reactivex.rxjava3.core.ObservableSource f1e1d05de;
    private readonly io.reactivex.rxjava3.core.ObservableSource f4368b6c0;
    private readonly io.reactivex.rxjava3.core.ObservableSource<T> fbc3b0556;
    private readonly io.reactivex.rxjava3.core.ObservableSource fe00a3ef2;

    public p90f99b24(io.reactivex.rxjava3.core.ObservableSource<T> observableSource) {
        this.fbc3b0556 = observableSource;
    }

    public static void QycYbTZutZjJWwqI(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        qycYbTZutZjJWwqI(this.fbc3b0556, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p90f99b24$pf7cb4cf7(subscriber));
    }
}

