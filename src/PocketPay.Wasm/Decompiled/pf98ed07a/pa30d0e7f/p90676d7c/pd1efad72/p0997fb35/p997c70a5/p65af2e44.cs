namespace WillowMaze.Wasm.Decompiled;


public readonly class p65af2e44<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, io.reactivex.rxjava3.schedulers.Timed<T>> {
    readonly java.util.concurrent.TimeUnit f1174c0b9;
    readonly io.reactivex.rxjava3.core.Scheduler f3ab3b25e;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler fa4cd5047;
    readonly io.reactivex.rxjava3.core.Scheduler fb1bdbf4c;

    public p65af2e44(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(observableSource);
        this.f499f31e7 = scheduler;
        this.f3e34bdeb = timeUnit;
    }

    public static void EvruLCtYiVSAHtHs(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.schedulers.Timed<T>> observer) {
        if ((3 + 8) % 8 > 0) {
        }
        evruLCtYiVSAHtHs(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p65af2e44$pdad5a6f4(observer, this.f3e34bdeb, this.f499f31e7));
    }
}

