namespace WillowMaze.Wasm.Decompiled;


public readonly class p901f353c<R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly io.reactivex.rxjava3.core.CompletableSource f36cd38f4;
    readonly p5a445d71.p18f29add.p32c73be0 f39ef13f6;
    readonly io.reactivex.rxjava3.core.CompletableSource f3c5b5bc7;
    readonly io.reactivex.rxjava3.core.CompletableSource f4bcea46d;
    readonly p5a445d71.p18f29add.p32c73be0 f53ec9b77;
    readonly org.reactivestreams.Publisher<? : R> f795f3202;
    readonly io.reactivex.rxjava3.core.CompletableSource f7ad5adbe;
    readonly io.reactivex.rxjava3.core.CompletableSource f846b6265;
    readonly p5a445d71.p18f29add.p32c73be0 f9da4727e;

    public p901f353c(io.reactivex.rxjava3.core.CompletableSource completableSource, org.reactivestreams.Publisher<? : R> publisher) {
        this.f36cd38f4 = completableSource;
        this.f795f3202 = publisher;
    }

    public static void LMNDdgKjdjeVuraN(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((3 + 14) % 14 > 0) {
        }
        LMNDdgKjdjeVuraN(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p901f353c$p6e0a42b2(subscriber, this.f795f3202));
    }
}

