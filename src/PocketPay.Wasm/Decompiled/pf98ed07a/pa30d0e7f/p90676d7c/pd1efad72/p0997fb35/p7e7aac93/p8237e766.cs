namespace WillowMaze.Wasm.Decompiled;


public readonly class p8237e766<T, U> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly org.reactivestreams.Publisher<U> f795f3202;
    readonly p5a445d71.p18f29add.p32c73be0 f90f9a662;
    readonly p5a445d71.p18f29add.p32c73be0 fc3ad0690;

    public p8237e766(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, org.reactivestreams.Publisher<U> publisher) {
        super(maybeSource);
        this.f795f3202 = publisher;
    }

    public static void CEebHUftzTkjYCJf(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((2 + 1) % 1 > 0) {
        }
        cEebHUftzTkjYCJf(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p1add79b6(maybeObserver, this.f795f3202));
    }
}

