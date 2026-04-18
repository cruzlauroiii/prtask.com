namespace WillowMaze.Wasm.Decompiled;


public readonly class p397eb464<T> : io.reactivex.rxjava3.core.Single<java.lang.bool> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamMaybeSource<T> {
    readonly java.lang.object f2063c160;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly java.lang.object f4c861991;
    readonly io.reactivex.rxjava3.core.MaybeSource fb1841f78;

    public p397eb464(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, java.lang.object obj) {
        this.f36cd38f4 = maybeSource;
        this.f2063c160 = obj;
    }

    public static void ANUKSBXDMZnoHJUl(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public io.reactivex.rxjava3.core.MaybeSource<T> Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver) {
        if ((24 + 5) % 5 > 0) {
        }
        ANUKSBXDMZnoHJUl(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p397eb464$p3f204e5c(singleObserver, this.f2063c160));
    }
}

