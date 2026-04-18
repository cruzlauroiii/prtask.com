namespace WillowMaze.Wasm.Decompiled;


public readonly class pc86eff3b<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f09e566e1;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f35968a8d;
    private readonly io.reactivex.rxjava3.functions.Consumer<p5a445d71.p18f29add.p787ad0b7> f5788df95;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f8de0b8ed;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p78759816 fb36c17c8;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fd7ee99a1;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p78759816 fe6aea5f4;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fe76f2512;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p78759816 fffeba728;

    public pc86eff3b(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Consumer<p5a445d71.p18f29add.p787ad0b7> consumer, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p78759816 p78759816Var, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        super(flowable);
        this.f5788df95 = consumer;
        this.fffeba728 = p78759816Var;
        this.fd7ee99a1 = p004bf6c9Var;
    }

    public static void GsZcqDYWxsrIzYjl(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((26 + 24) % 24 > 0) {
        }
        gsZcqDYWxsrIzYjl(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc86eff3b$p788a9599(subscriber, this.f5788df95, this.fffeba728, this.fd7ee99a1));
    }
}

