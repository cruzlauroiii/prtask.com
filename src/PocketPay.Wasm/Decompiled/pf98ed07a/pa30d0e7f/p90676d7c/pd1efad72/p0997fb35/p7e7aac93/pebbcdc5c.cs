namespace WillowMaze.Wasm.Decompiled;


public readonly class pebbcdc5c<T> : io.reactivex.rxjava3.core.Single<java.lang.long> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamMaybeSource<T> {
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.MaybeSource f4c284be6;

    public pebbcdc5c(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource) {
        this.f36cd38f4 = maybeSource;
    }

    public static void ThWBgaHPeMgmGVQE(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public io.reactivex.rxjava3.core.MaybeSource<T> Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.long> singleObserver) {
        thWBgaHPeMgmGVQE(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pebbcdc5c$p831a42b6(singleObserver));
    }
}

