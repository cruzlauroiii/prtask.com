namespace WillowMaze.Wasm.Decompiled;


public readonly class p06bb1c21<T> : io.reactivex.rxjava3.core.Single<java.lang.long> : io.reactivex.rxjava3.internal.fuseable.FuseToObservable<java.lang.long> {
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableSource feee01409;

    public p06bb1c21(io.reactivex.rxjava3.core.ObservableSource<T> observableSource) {
        this.f36cd38f4 = observableSource;
    }

    public static void RKdOZvIUyRhHiARi(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static io.reactivex.rxjava3.core.Observable RkadtKLQsAEANsAX(io.reactivex.rxjava3.core.Observable observable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(observable);
    }

    public io.reactivex.rxjava3.core.Observable<java.lang.long> FuseToObservable() {
        return rkadtKLQsAEANsAX(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p32f3f4e1(this.f36cd38f4));
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.long> singleObserver) {
        rKdOZvIUyRhHiARi(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p06bb1c21$p0feafce5(singleObserver));
    }
}

