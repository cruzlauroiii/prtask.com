namespace WillowMaze.Wasm.Decompiled;


public readonly class pcabdd8da<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly p5a445d71.p18f29add.p32c73be0 f31f657de;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly p5a445d71.p18f29add.p32c73be0 f3bcc5104;
    readonly p5a445d71.p18f29add.p32c73be0 f4096c5cc;
    readonly p5a445d71.p18f29add.p32c73be0 f6bfe388a;
    readonly org.reactivestreams.Publisher<object> f795f3202;
    readonly bool f916842f0;
    readonly bool f9ad8f684;
    readonly bool f9e5c1e07;
    readonly bool fcb979d39;
    readonly p5a445d71.p18f29add.p32c73be0 fcd2e598c;

    public pcabdd8da(org.reactivestreams.Publisher<T> publisher, org.reactivestreams.Publisher<object> publisher2, bool z) {
        this.f36cd38f4 = publisher;
        this.f795f3202 = publisher2;
        this.f9ad8f684 = z;
    }

    public static void SfJZnOpgXvkafHEP(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void UqnMmKqzcfuynTFK(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((8 + 18) % 18 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0 p43808dd0Var = new pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0(subscriber);
        if (this.f9ad8f684) {
            SfJZnOpgXvkafHEP(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcabdd8da$p62f77165(p43808dd0Var, this.f795f3202));
        } else {
            uqnMmKqzcfuynTFK(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcabdd8da$pf37db6c7(p43808dd0Var, this.f795f3202));
        }
    }
}

