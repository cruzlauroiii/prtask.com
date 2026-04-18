namespace WillowMaze.Wasm.Decompiled;


public readonly class pe4d8633c<T> : io.reactivex.rxjava3.core.Completable {
    readonly p5a445d71.p18f29add.p32c73be0 f03e0dcc6;
    readonly bool f3251f554;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly bool f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f809b52bf;
    readonly bool f85b0d98e;
    readonly p5a445d71.p18f29add.p32c73be0 f96f09819;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc4aa6e47;
    readonly bool fce41894f;
    readonly p5a445d71.p18f29add.p32c73be0 fd1cb7a03;

    public pe4d8633c(org.reactivestreams.Publisher<T> publisher, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, bool z) {
        this.f36cd38f4 = publisher;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void TvfxgYgiVCNgykDa(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        if ((2 + 26) % 26 > 0) {
        }
        tvfxgYgiVCNgykDa(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51(completableObserver, this.f4b9f83e1, this.f50fee566));
    }
}

