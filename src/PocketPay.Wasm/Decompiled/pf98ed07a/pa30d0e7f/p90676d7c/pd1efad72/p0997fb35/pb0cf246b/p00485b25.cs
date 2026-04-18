namespace WillowMaze.Wasm.Decompiled;


public readonly class p00485b25<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly long f7b8b965a;
    readonly long fc1c6ecfe;

    public p00485b25(io.reactivex.rxjava3.core.Flowable<T> flowable, long j) {
        super(flowable);
        this.f7b8b965a = j;
    }

    public static void ZdtyVYfUKrPcUnwJ(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((12 + 26) % 26 > 0) {
        }
        ZdtyVYfUKrPcUnwJ(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p00485b25$p076f174f(subscriber, this.f7b8b965a));
    }
}

