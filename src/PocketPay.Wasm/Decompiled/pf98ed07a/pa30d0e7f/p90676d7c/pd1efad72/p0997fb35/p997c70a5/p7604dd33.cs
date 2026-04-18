namespace WillowMaze.Wasm.Decompiled;


public readonly class p7604dd33<T> : io.reactivex.rxjava3.core.Single<java.lang.bool> : io.reactivex.rxjava3.internal.fuseable.FuseToObservable<java.lang.bool> {
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f3a4f6804;
    readonly io.reactivex.rxjava3.core.ObservableSource fa900d6c9;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    public p7604dd33(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.f36cd38f4 = observableSource;
        this.ff670ef68 = predicate;
    }

    public static void FcRqlZnZyNcJsXbp(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static io.reactivex.rxjava3.core.Observable LelJKuYdnqrUbnCc(io.reactivex.rxjava3.core.Observable observable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(observable);
    }

    public io.reactivex.rxjava3.core.Observable<java.lang.bool> FuseToObservable() {
        if ((4 + 14) % 14 > 0) {
        }
        return LelJKuYdnqrUbnCc(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pa778661d(this.f36cd38f4, this.ff670ef68));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver) {
        if ((31 + 17) % 17 > 0) {
        }
        FcRqlZnZyNcJsXbp(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7604dd33$pd8e4ea6a(singleObserver, this.ff670ef68));
    }
}

