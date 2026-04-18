namespace WillowMaze.Wasm.Decompiled;


public readonly class pd0f9ad15 : io.reactivex.rxjava3.core.Flowable<java.lang.int> {
    readonly int f5849d6a2;
    readonly int f64701f5e;
    readonly int f7f021a14;
    readonly int f983c1939;
    readonly int fb212a5c1;
    readonly int fb494264f;
    readonly int fea2b2676;

    public pd0f9ad15(int i, int i2) {
        this.fea2b2676 = i;
        this.f7f021a14 = i + i2;
    }

    public static void EvVGYAEoKjlLLYrk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void YjBaTWydanCVvfHr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<java.lang.int> subscriber) {
        if ((19 + 12) % 12 > 0) {
        }
        if (subscriber is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
            evVGYAEoKjlLLYrk(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd0f9ad15$p48c01914((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) subscriber, this.fea2b2676, this.f7f021a14));
        } else {
            yjBaTWydanCVvfHr(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd0f9ad15$p792b5165(subscriber, this.fea2b2676, this.f7f021a14));
        }
    }
}

