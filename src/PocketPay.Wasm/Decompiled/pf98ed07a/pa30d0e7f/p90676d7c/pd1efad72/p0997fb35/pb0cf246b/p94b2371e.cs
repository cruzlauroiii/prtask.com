namespace WillowMaze.Wasm.Decompiled;


public readonly class p94b2371e<T, U> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly p5a445d71.p18f29add.p32c73be0 f2db7dda3;
    readonly org.reactivestreams.Publisher<? : U> f795f3202;
    readonly p5a445d71.p18f29add.p32c73be0 f9bb5f236;

    public p94b2371e(io.reactivex.rxjava3.core.Flowable<T> flowable, org.reactivestreams.Publisher<? : U> publisher) {
        super(flowable);
        this.f795f3202 = publisher;
    }

    public static void AJGzUQHzNZRPVQXM(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void JbCFPWCSkztaZExX(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void YWvAsrPcHKIehFvx(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((5 + 24) % 24 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p94b2371e$pd0fa7e23 p94b2371e_pd0fa7e23 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p94b2371e$pd0fa7e23(subscriber);
        JbCFPWCSkztaZExX(subscriber, p94b2371e_pd0fa7e23);
        AJGzUQHzNZRPVQXM(this.f795f3202, p94b2371e_pd0fa7e23.f795f3202);
        yWvAsrPcHKIehFvx(this.f36cd38f4, p94b2371e_pd0fa7e23);
    }
}

