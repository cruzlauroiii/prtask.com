namespace WillowMaze.Wasm.Decompiled;


public readonly class pf61d92ca<T, U, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f1f2d6cf4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f58b4021c;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> f61aaf8fd;
    readonly p5a445d71.p18f29add.p32c73be0 f7737bc7a;
    readonly org.reactivestreams.Publisher<? : U> f795f3202;
    readonly p5a445d71.p18f29add.p32c73be0 f81b98f9e;
    readonly p5a445d71.p18f29add.p32c73be0 fe6e43412;

    public pf61d92ca(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction, org.reactivestreams.Publisher<? : U> publisher) {
        super(flowable);
        this.f61aaf8fd = biFunction;
        this.f795f3202 = publisher;
    }

    public static void DskwkMvEAYyFylOo(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void BRYdiFFvCrTwmBxd(pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0 p43808dd0Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p43808dd0Var.onSubscribe(p787ad0b7Var);
    }

    public static void XOXoZmrkhaolrHjH(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((15 + 24) % 24 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0 p43808dd0Var = new pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0(subscriber);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca$p0d7efdfb pf61d92ca_p0d7efdfb = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca$p0d7efdfb(p43808dd0Var, this.f61aaf8fd);
        bRYdiFFvCrTwmBxd(p43808dd0Var, pf61d92ca_p0d7efdfb);
        xOXoZmrkhaolrHjH(this.f795f3202, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca$p76064289(this, pf61d92ca_p0d7efdfb));
        DskwkMvEAYyFylOo(this.f36cd38f4, pf61d92ca_p0d7efdfb);
    }
}

