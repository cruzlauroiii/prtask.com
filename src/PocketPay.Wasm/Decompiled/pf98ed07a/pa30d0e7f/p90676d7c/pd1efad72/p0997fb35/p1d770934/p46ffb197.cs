namespace WillowMaze.Wasm.Decompiled;


public readonly class p46ffb197<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7f955b92;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f82706787;
    readonly int facad592d;
    readonly p5a445d71.p18f29add.p32c73be0 ff4e2e576;
    readonly p5a445d71.p18f29add.p32c73be0 ffb5e2345;

    public p46ffb197(org.reactivestreams.Publisher<T> publisher, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var, int i) {
        this.f36cd38f4 = publisher;
        this.f4b9f83e1 = function;
        this.f560019e4 = pcd04add9Var;
        this.f4c203b76 = i;
    }

    public static void ARKnhXvAuJPtREqY(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((9 + 24) % 24 > 0) {
        }
        aRKnhXvAuJPtREqY(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1(subscriber, this.f4b9f83e1, this.f4c203b76, this.f560019e4));
    }
}

