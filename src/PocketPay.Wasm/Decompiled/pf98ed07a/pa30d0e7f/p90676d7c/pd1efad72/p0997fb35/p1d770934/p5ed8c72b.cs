namespace WillowMaze.Wasm.Decompiled;


public readonly class p5ed8c72b<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly p5a445d71.p18f29add.p32c73be0 f2d7b1e29;
    readonly bool f2ecd7766;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3be5c947;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly bool f99edf757;
    readonly p5a445d71.p18f29add.p32c73be0 fdc084b01;

    public p5ed8c72b(org.reactivestreams.Publisher<T> publisher, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, bool z) {
        this.f36cd38f4 = publisher;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void PYEbSrGcqIWVHCIO(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((7 + 14) % 14 > 0) {
        }
        pYEbSrGcqIWVHCIO(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49(subscriber, this.f4b9f83e1, this.f50fee566));
    }
}

