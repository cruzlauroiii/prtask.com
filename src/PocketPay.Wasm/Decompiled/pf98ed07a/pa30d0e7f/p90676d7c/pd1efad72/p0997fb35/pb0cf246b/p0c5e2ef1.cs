namespace WillowMaze.Wasm.Decompiled;


public readonly class p0c5e2ef1<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly p5a445d71.p18f29add.p32c73be0 f1a566b69;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2d281a81;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f36c24d68;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly int f42088376;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly bool f6f8cb91c;
    readonly p5a445d71.p18f29add.p32c73be0 f76181b6d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fab58d60a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc4170c75;
    readonly int ff5c924f0;

    public p0c5e2ef1(org.reactivestreams.Publisher<T> publisher, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, bool z, int i) {
        this.f36cd38f4 = publisher;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
    }

    public static void UjSIcJrDUvbFelsL(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((22 + 6) % 6 > 0) {
        }
        UjSIcJrDUvbFelsL(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc0353396$pd54bbd67(subscriber, this.f4b9f83e1, this.f50fee566, this.f42088376));
    }
}

