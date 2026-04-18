namespace WillowMaze.Wasm.Decompiled;


public readonly class p4ee71481<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly int f2e2e443d;
    readonly int fe2942a04;

    public p4ee71481(io.reactivex.rxjava3.core.Flowable<T> flowable, int i) {
        super(flowable);
        this.fe2942a04 = i;
    }

    public static void TAUmZhArugMLGnkU(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((9 + 8) % 8 > 0) {
        }
        tAUmZhArugMLGnkU(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p4ee71481$p25f7d300(subscriber, this.fe2942a04));
    }
}

