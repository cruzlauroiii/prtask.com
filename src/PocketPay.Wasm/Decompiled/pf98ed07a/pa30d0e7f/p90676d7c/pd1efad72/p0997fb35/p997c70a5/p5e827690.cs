namespace WillowMaze.Wasm.Decompiled;


public readonly class p5e827690<T, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, R> {
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.Notification<R>> f5b3c3200;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb5c80c83;

    public p5e827690(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.Notification<R>> function) {
        super(observableSource);
        this.f5b3c3200 = function;
    }

    public static void JTwxFUSTnRzxbRCY(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((20 + 30) % 30 > 0) {
        }
        jTwxFUSTnRzxbRCY(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e827690$p206aa94e(observer, this.f5b3c3200));
    }
}

