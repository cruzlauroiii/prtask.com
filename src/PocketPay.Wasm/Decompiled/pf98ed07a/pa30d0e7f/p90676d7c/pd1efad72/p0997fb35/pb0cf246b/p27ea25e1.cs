namespace WillowMaze.Wasm.Decompiled;


public readonly class p27ea25e1<T> : io.reactivex.rxjava3.core.Single<java.lang.bool> : io.reactivex.rxjava3.internal.fuseable.FuseToFlowable<java.lang.bool> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f4c0577f9;
    readonly int f4c203b76;
    readonly p5a445d71.p18f29add.p32c73be0 f634a8b38;
    readonly p5a445d71.p18f29add.p32c73be0 f6e17ebbf;
    readonly p5a445d71.p18f29add.p32c73be0 f764a5107;
    readonly p5a445d71.p18f29add.p32c73be0 f7cea2c91;
    readonly org.reactivestreams.Publisher<? : T> f8b04d5e3;
    readonly io.reactivex.rxjava3.functions.BiPredicate<T, T> f9f89a861;
    readonly org.reactivestreams.Publisher<? : T> fa9f0e61a;
    readonly p5a445d71.p18f29add.p32c73be0 fb038214f;
    readonly int fb22f7f62;
    readonly p5a445d71.p18f29add.p32c73be0 fbf482975;
    readonly p5a445d71.p18f29add.p32c73be0 fcaf8ff9e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fd0b44b6b;
    readonly p5a445d71.p18f29add.p32c73be0 fed0dfbf4;

    public p27ea25e1(org.reactivestreams.Publisher<? : T> publisher, org.reactivestreams.Publisher<? : T> publisher2, io.reactivex.rxjava3.functions.BiPredicate<T, T> biPredicate, int i) {
        this.f8b04d5e3 = publisher;
        this.fa9f0e61a = publisher2;
        this.f9f89a861 = biPredicate;
        this.f4c203b76 = i;
    }

    public static void IjUoaclYcUpWVVGA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p27ea25e1$pe7a52b77 p27ea25e1_pe7a52b77, p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p32c73be0 p32c73be0Var2) {
        p27ea25e1_pe7a52b77.subscribe(p32c73be0Var, p32c73be0Var2);
    }

    public static io.reactivex.rxjava3.core.Flowable ORcSZhePHFgINrYv(io.reactivex.rxjava3.core.Flowable flowable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(flowable);
    }

    public static void TwSvhLGAtZzPZCrL(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public io.reactivex.rxjava3.core.Flowable<java.lang.bool> FuseToFlowable() {
        if ((10 + 4) % 4 > 0) {
        }
        return ORcSZhePHFgINrYv(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79(this.f8b04d5e3, this.fa9f0e61a, this.f9f89a861, this.f4c203b76));
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver) {
        if ((13 + 21) % 21 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p27ea25e1$pe7a52b77 p27ea25e1_pe7a52b77 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p27ea25e1$pe7a52b77(singleObserver, this.f4c203b76, this.f9f89a861);
        TwSvhLGAtZzPZCrL(singleObserver, p27ea25e1_pe7a52b77);
        IjUoaclYcUpWVVGA(p27ea25e1_pe7a52b77, this.f8b04d5e3, this.fa9f0e61a);
    }
}

