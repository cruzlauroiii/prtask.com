namespace WillowMaze.Wasm.Decompiled;


public readonly class p66758ec3<T, B> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, io.reactivex.rxjava3.core.Flowable<T>> {
    readonly int f0b1310ff;
    readonly int f51394688;
    readonly p5a445d71.p18f29add.p32c73be0 f620df9cb;
    readonly org.reactivestreams.Publisher<B> f795f3202;
    readonly int fa1f7bd0a;
    readonly p5a445d71.p18f29add.p32c73be0 fddac3a74;
    readonly int ff0d768be;

    public p66758ec3(io.reactivex.rxjava3.core.Flowable<T> flowable, org.reactivestreams.Publisher<B> publisher, int i) {
        super(flowable);
        this.f795f3202 = publisher;
        this.f0b1310ff = i;
    }

    public static void DwLKmuZVPqSOkuEC(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void PPvjcUJAoNvdGBgZ(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void ZWgheIUlVJFahVyN(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void ZXGWLUiVTMwqQitR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6) {
        p66758ec3_pcbd5c6a6.innerNext();
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber) {
        if ((27 + 28) % 28 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6(subscriber, this.f0b1310ff);
        DwLKmuZVPqSOkuEC(subscriber, p66758ec3_pcbd5c6a6);
        ZXGWLUiVTMwqQitR(p66758ec3_pcbd5c6a6);
        PPvjcUJAoNvdGBgZ(this.f795f3202, p66758ec3_pcbd5c6a6.fd3aefb56);
        ZWgheIUlVJFahVyN(this.f36cd38f4, p66758ec3_pcbd5c6a6);
    }
}

