namespace WillowMaze.Wasm.Decompiled;


public readonly class p4676ac94<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f242f6bba;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fbecf080f;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    public p4676ac94(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(observableSource);
        this.ff670ef68 = predicate;
    }

    public static void QQSgxyBPqUUlIOZt(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((5 + 11) % 11 > 0) {
        }
        QQSgxyBPqUUlIOZt(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4676ac94$pe63369d5(observer, this.ff670ef68));
    }
}

