namespace WillowMaze.Wasm.Decompiled;


public readonly class p59b2b1dc<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.functions.Consumer<T> f3964f381;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fec943a5d;

    public p59b2b1dc(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Consumer<T> consumer) {
        super(flowable);
        this.f3964f381 = consumer;
    }

    public static void LydqaahUJcTOmRss(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void UwZkDWkVvukzbESG(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((14 + 18) % 18 > 0) {
        }
        if (subscriber is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
            uwZkDWkVvukzbESG(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59b2b1dc$p4ec50e6c((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) subscriber, this.f3964f381));
        } else {
            LydqaahUJcTOmRss(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59b2b1dc$p1dd1133b(subscriber, this.f3964f381));
        }
    }
}

