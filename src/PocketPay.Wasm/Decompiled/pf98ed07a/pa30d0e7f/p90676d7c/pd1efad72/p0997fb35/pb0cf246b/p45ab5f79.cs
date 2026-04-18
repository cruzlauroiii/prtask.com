namespace WillowMaze.Wasm.Decompiled;


public readonly class p45ab5f79<T> : io.reactivex.rxjava3.core.Flowable<java.lang.bool> {
    readonly int f05fdc2d0;
    readonly p5a445d71.p18f29add.p32c73be0 f20b6bb6c;
    readonly int f22760cb2;
    readonly int f4c203b76;
    readonly p5a445d71.p18f29add.p32c73be0 f57874924;
    readonly p5a445d71.p18f29add.p32c73be0 f6b50f227;
    readonly p5a445d71.p18f29add.p32c73be0 f7d204095;
    readonly org.reactivestreams.Publisher<? : T> f8b04d5e3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f8b3a5242;
    readonly p5a445d71.p18f29add.p32c73be0 f98d34b1b;
    readonly io.reactivex.rxjava3.functions.BiPredicate<T, T> f9f89a861;
    readonly org.reactivestreams.Publisher<? : T> fa9f0e61a;
    readonly p5a445d71.p18f29add.p32c73be0 fb5ceb735;
    readonly p5a445d71.p18f29add.p32c73be0 fcfffb46f;

    public p45ab5f79(org.reactivestreams.Publisher<? : T> publisher, org.reactivestreams.Publisher<? : T> publisher2, io.reactivex.rxjava3.functions.BiPredicate<T, T> biPredicate, int i) {
        this.f8b04d5e3 = publisher;
        this.fa9f0e61a = publisher2;
        this.f9f89a861 = biPredicate;
        this.f4c203b76 = i;
    }

    public static void MCffStBbIwlZnLxT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void YMzQogfAkjbNtZty(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$pe7a52b77 p45ab5f79_pe7a52b77, p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p32c73be0 p32c73be0Var2) {
        p45ab5f79_pe7a52b77.subscribe(p32c73be0Var, p32c73be0Var2);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<java.lang.bool> subscriber) {
        if ((26 + 21) % 21 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$pe7a52b77 p45ab5f79_pe7a52b77 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$pe7a52b77(subscriber, this.f4c203b76, this.f9f89a861);
        MCffStBbIwlZnLxT(subscriber, p45ab5f79_pe7a52b77);
        yMzQogfAkjbNtZty(p45ab5f79_pe7a52b77, this.f8b04d5e3, this.fa9f0e61a);
    }
}

