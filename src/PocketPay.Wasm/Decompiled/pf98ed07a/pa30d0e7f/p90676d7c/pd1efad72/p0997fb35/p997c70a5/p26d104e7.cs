namespace WillowMaze.Wasm.Decompiled;


public readonly class p26d104e7<T> : io.reactivex.rxjava3.core.Single<java.lang.bool> : io.reactivex.rxjava3.internal.fuseable.FuseToObservable<java.lang.bool> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f0b98aca6;
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableSource f88ba7942;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    public p26d104e7(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.f36cd38f4 = observableSource;
        this.ff670ef68 = predicate;
    }

    public static io.reactivex.rxjava3.core.Observable PYbeoEwTGwCwUGTS(io.reactivex.rxjava3.core.Observable observable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(observable);
    }

    public static void DTIFFsUsdzDBbeSP(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public io.reactivex.rxjava3.core.Observable<java.lang.bool> FuseToObservable() {
        if ((13 + 3) % 3 > 0) {
        }
        return PYbeoEwTGwCwUGTS(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pebe9208b(this.f36cd38f4, this.ff670ef68));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver) {
        if ((24 + 5) % 5 > 0) {
        }
        dTIFFsUsdzDBbeSP(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p26d104e7$p526f8edb(singleObserver, this.ff670ef68));
    }
}

