namespace WillowMaze.Wasm.Decompiled;


public readonly class p6c93c6eb<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly p5a445d71.p18f29add.p32c73be0 f01f59272;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly p5a445d71.p18f29add.p32c73be0 f5ebd4060;
    readonly p5a445d71.p18f29add.p32c73be0 f88742c8a;
    readonly long f96cae92c;
    readonly p5a445d71.p18f29add.p32c73be0 fa2c015cc;
    readonly long faa9f73ee;
    readonly long fac9826b0;

    public p6c93c6eb(org.reactivestreams.Publisher<T> publisher, long j) {
        this.f36cd38f4 = publisher;
        this.faa9f73ee = j;
    }

    public static void OawHyqJRNuUpAgca(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((17 + 7) % 7 > 0) {
        }
        oawHyqJRNuUpAgca(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9567bfd3$p81281806(subscriber, this.faa9f73ee));
    }
}

