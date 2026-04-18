namespace WillowMaze.Wasm.Decompiled;


public readonly class pb477373c<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f69d7c228;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 ffcde9fec;

    public pb477373c(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(observableSource);
        this.ff670ef68 = predicate;
    }

    public static void VfJICwfIHxkSlHwf(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((21 + 29) % 29 > 0) {
        }
        VfJICwfIHxkSlHwf(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb477373c$pe49014e1(observer, this.ff670ef68));
    }
}

