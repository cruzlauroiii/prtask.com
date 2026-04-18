namespace WillowMaze.Wasm.Decompiled;


public readonly class p38f05b7d<T> : io.reactivex.rxjava3.core.Single<T> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamMaybeSource<T> {
    readonly java.lang.object f10817136;
    readonly T f16830a58;
    readonly io.reactivex.rxjava3.core.MaybeSource f347fb949;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.MaybeSource f6b15eee5;
    readonly io.reactivex.rxjava3.core.MaybeSource f83e86599;
    readonly io.reactivex.rxjava3.core.MaybeSource fe1a5f47f;

    public p38f05b7d(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, T t) {
        this.f36cd38f4 = maybeSource;
        this.f16830a58 = t;
    }

    public static void VZZXECViYxZepipT(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public io.reactivex.rxjava3.core.MaybeSource<T> Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((30 + 5) % 5 > 0) {
        }
        vZZXECViYxZepipT(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p38f05b7d$p513888ac(singleObserver, this.f16830a58));
    }
}

