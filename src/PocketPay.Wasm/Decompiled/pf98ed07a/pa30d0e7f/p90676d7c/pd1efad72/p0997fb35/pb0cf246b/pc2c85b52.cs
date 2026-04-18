namespace WillowMaze.Wasm.Decompiled;


public readonly class pc2c85b52<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly org.reactivestreams.Publisher<? : T> f795f3202;
    readonly p5a445d71.p18f29add.p32c73be0 f87a022ba;
    readonly p5a445d71.p18f29add.p32c73be0 fd20278af;
    readonly p5a445d71.p18f29add.p32c73be0 fe66d6d14;

    public pc2c85b52(io.reactivex.rxjava3.core.Flowable<T> flowable, org.reactivestreams.Publisher<? : T> publisher) {
        super(flowable);
        this.f795f3202 = publisher;
    }

    public static void MHdphfrOFbHyuuOa(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void RdDqjRtlnsWmqsJb(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((15 + 21) % 21 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc2c85b52$p76457691 pc2c85b52_p76457691 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc2c85b52$p76457691(subscriber, this.f795f3202);
        rdDqjRtlnsWmqsJb(subscriber, pc2c85b52_p76457691.f79106d6f);
        mHdphfrOFbHyuuOa(this.f36cd38f4, pc2c85b52_p76457691);
    }
}

