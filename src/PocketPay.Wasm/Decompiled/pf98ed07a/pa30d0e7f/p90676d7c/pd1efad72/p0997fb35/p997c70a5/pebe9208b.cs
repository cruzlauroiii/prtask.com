namespace WillowMaze.Wasm.Decompiled;


public readonly class pebe9208b<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, java.lang.bool> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f5cbfedb2;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    public pebe9208b(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(observableSource);
        this.ff670ef68 = predicate;
    }

    public static void HXftYhbpzuUCMvnu(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<java.lang.bool> observer) {
        if ((7 + 7) % 7 > 0) {
        }
        HXftYhbpzuUCMvnu(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pebe9208b$p526f8edb(observer, this.ff670ef68));
    }
}

