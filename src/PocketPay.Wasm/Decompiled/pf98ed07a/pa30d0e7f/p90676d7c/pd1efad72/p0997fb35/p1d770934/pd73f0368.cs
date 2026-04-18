namespace WillowMaze.Wasm.Decompiled;


public readonly class pd73f0368<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0e02dad4;
    readonly p5a445d71.p18f29add.p32c73be0 f1b49a5a9;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly p5a445d71.p18f29add.p32c73be0 f6f59cb41;
    readonly bool fa367b568;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa97ebbf3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd254f560;
    readonly bool fdf6e870e;
    readonly bool ff87ac91a;
    readonly p5a445d71.p18f29add.p32c73be0 ffe725b0d;

    public pd73f0368(org.reactivestreams.Publisher<T> publisher, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, bool z) {
        this.f36cd38f4 = publisher;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void DkMQVaHYSsHURePX(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((25 + 27) % 27 > 0) {
        }
        dkMQVaHYSsHURePX(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pa9d45ef6$p6fb43174(subscriber, this.f4b9f83e1, this.f50fee566));
    }
}

