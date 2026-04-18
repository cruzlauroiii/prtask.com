namespace WillowMaze.Wasm.Decompiled;


public readonly class p10dc75b5<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.SingleSource f1aa834f2;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.SingleSource fdba551d1;
    readonly io.reactivex.rxjava3.core.SingleSource fee840c3f;

    public p10dc75b5(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        super(flowable);
        this.f795f3202 = singleSource;
    }

    public static void FJgNhjUTkXQBfneg(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((29 + 7) % 7 > 0) {
        }
        FJgNhjUTkXQBfneg(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p10dc75b5$p32c3c30c(subscriber, this.f795f3202));
    }
}

