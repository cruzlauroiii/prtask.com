namespace WillowMaze.Wasm.Decompiled;


public readonly class p93ccfea4<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly long f0600f23e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f07eec475;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f15ad1e1f;
    readonly long f3ee68fad;
    readonly long f71b645b7;
    readonly io.reactivex.rxjava3.core.BackpressureOverflowStrategy f77e53c1c;
    readonly io.reactivex.rxjava3.core.BackpressureOverflowStrategy fc0089e65;
    readonly long fcdee5967;
    readonly long fe685628e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 ffa1cda4a;

    public p93ccfea4(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var, io.reactivex.rxjava3.core.BackpressureOverflowStrategy backpressureOverflowStrategy) {
        super(flowable);
        this.fcdee5967 = j;
        this.f07eec475 = p004bf6c9Var;
        this.fc0089e65 = backpressureOverflowStrategy;
    }

    public static void YXOkOVQWfcojCSko(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((24 + 23) % 23 > 0) {
        }
        YXOkOVQWfcojCSko(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7(subscriber, this.f07eec475, this.fc0089e65, this.fcdee5967));
    }
}

