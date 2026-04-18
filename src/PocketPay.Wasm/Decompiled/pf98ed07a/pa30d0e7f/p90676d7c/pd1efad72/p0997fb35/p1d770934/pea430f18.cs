namespace WillowMaze.Wasm.Decompiled;


public readonly class pea430f18<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.MaybeSource f7cfcea36;
    readonly io.reactivex.rxjava3.core.MaybeSource f954896aa;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fba85150c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fdc394a5f;

    public pea430f18(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> function) {
        this.f36cd38f4 = maybeSource;
        this.f4b9f83e1 = function;
    }

    public static void IKXQlwCktlgykXsA(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((7 + 21) % 21 > 0) {
        }
        iKXQlwCktlgykXsA(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pea430f18$p04829003(subscriber, this.f4b9f83e1));
    }
}

