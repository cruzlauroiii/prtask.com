namespace WillowMaze.Wasm.Decompiled;


public readonly class p3986173c<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.CompletableSource f30300d49;
    readonly io.reactivex.rxjava3.core.CompletableSource f795f3202;
    readonly io.reactivex.rxjava3.core.CompletableSource f98406a6a;

    public p3986173c(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.core.CompletableSource completableSource) {
        super(flowable);
        this.f795f3202 = completableSource;
    }

    public static void HNPepjFFogcblLcX(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((19 + 14) % 14 > 0) {
        }
        HNPepjFFogcblLcX(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p3986173c$p32c3c30c(subscriber, this.f795f3202));
    }
}

