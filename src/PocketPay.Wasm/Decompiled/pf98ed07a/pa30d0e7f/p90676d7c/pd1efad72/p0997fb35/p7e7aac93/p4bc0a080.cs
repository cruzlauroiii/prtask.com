namespace WillowMaze.Wasm.Decompiled;


public readonly class p4bc0a080<T> : io.reactivex.rxjava3.core.Flowable<T> : io.reactivex.rxjava3.internal.fuseable.HasUpstreamMaybeSource<T> {
    readonly io.reactivex.rxjava3.core.MaybeSource f12927eab;
    readonly io.reactivex.rxjava3.core.MaybeSource f28d59639;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;

    public p4bc0a080(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource) {
        this.f36cd38f4 = maybeSource;
    }

    public static void SxliONPrJcRSBYyF(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public io.reactivex.rxjava3.core.MaybeSource<T> Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        sxliONPrJcRSBYyF(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p4bc0a080$pbd42b22d(subscriber));
    }
}

