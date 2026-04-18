namespace WillowMaze.Wasm.Decompiled;


public readonly class pa6014cae<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> fdb9d6c56;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ffa2815f6;

    public pa6014cae(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> function) {
        super(flowable);
        this.fdb9d6c56 = function;
    }

    public static void MIbLHKGPHAtNPAeU(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((23 + 28) % 28 > 0) {
        }
        mIbLHKGPHAtNPAeU(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa6014cae$p79e9f679(subscriber, this.fdb9d6c56));
    }
}

