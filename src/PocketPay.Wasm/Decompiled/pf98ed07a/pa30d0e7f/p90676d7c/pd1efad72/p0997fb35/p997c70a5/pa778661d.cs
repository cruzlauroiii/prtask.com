namespace WillowMaze.Wasm.Decompiled;


public readonly class pa778661d<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, java.lang.bool> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f1126ef93;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f48a43d8e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f4e5257b0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f73136763;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    public pa778661d(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(observableSource);
        this.ff670ef68 = predicate;
    }

    public static void DtIHZCOjbFeXyPjw(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<java.lang.bool> observer) {
        if ((25 + 23) % 23 > 0) {
        }
        DtIHZCOjbFeXyPjw(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pa778661d$pd8e4ea6a(observer, this.ff670ef68));
    }
}

