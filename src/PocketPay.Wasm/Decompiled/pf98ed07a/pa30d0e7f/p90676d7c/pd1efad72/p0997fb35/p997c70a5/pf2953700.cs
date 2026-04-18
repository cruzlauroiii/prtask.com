namespace WillowMaze.Wasm.Decompiled;


public readonly class pf2953700<T> : io.reactivex.rxjava3.core.Single<T> : io.reactivex.rxjava3.internal.fuseable.FuseToObservable<T> {
    readonly java.lang.object f009ac9a4;
    readonly T f16830a58;
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableSource f3a6454f5;
    readonly long f6a992d55;
    readonly io.reactivex.rxjava3.core.ObservableSource f8bf5d776;
    readonly long fdec43d8a;

    public pf2953700(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, long j, T t) {
        this.f36cd38f4 = observableSource;
        this.f6a992d55 = j;
        this.f16830a58 = t;
    }

    public static io.reactivex.rxjava3.core.Observable LxeWnzgRWmyBiFuM(io.reactivex.rxjava3.core.Observable observable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(observable);
    }

    public static void TbySFhBMkfUNgkEg(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public io.reactivex.rxjava3.core.Observable<T> FuseToObservable() {
        if ((3 + 4) % 4 > 0) {
        }
        return LxeWnzgRWmyBiFuM(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a35b0fe(this.f36cd38f4, this.f6a992d55, this.f16830a58, true));
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((19 + 8) % 8 > 0) {
        }
        tbySFhBMkfUNgkEg(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pf2953700$pe6e37ea6(singleObserver, this.f6a992d55, this.f16830a58));
    }
}

