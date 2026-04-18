namespace WillowMaze.Wasm.Decompiled;


public readonly class p95a3c425<T, U> : io.reactivex.rxjava3.core.Flowable<U> {
    readonly p5a445d71.p18f29add.p32c73be0 f2c26237d;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : U> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f72353809;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa52b70dd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe1497b4d;

    public p95a3c425(org.reactivestreams.Publisher<T> publisher, io.reactivex.rxjava3.functions.Function<? super T, ? : U> function) {
        this.f36cd38f4 = publisher;
        this.f4b9f83e1 = function;
    }

    public static void IvGCluxONGjYgiwt(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<U> subscriber) {
        if ((20 + 15) % 15 > 0) {
        }
        ivGCluxONGjYgiwt(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa04d7793$pd2a16bce(subscriber, this.f4b9f83e1));
    }
}

