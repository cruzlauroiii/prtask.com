namespace WillowMaze.Wasm.Decompiled;


public readonly class p9567bfd3<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly long f083316ed;
    readonly long f7b8b965a;

    public p9567bfd3(io.reactivex.rxjava3.core.Flowable<T> flowable, long j) {
        super(flowable);
        this.f7b8b965a = j;
    }

    public static void AcqDfAZzMjQZcyQi(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((20 + 5) % 5 > 0) {
        }
        AcqDfAZzMjQZcyQi(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9567bfd3$p81281806(subscriber, this.f7b8b965a));
    }
}

