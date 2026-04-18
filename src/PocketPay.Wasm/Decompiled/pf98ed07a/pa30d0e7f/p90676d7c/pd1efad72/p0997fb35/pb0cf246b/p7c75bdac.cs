namespace WillowMaze.Wasm.Decompiled;


public readonly class p7c75bdac<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly T f16830a58;
    readonly bool f30b6cfdb;
    readonly java.lang.object f5c66be85;
    readonly bool f822dd650;
    readonly bool fa237ef19;
    readonly bool fcd060df9;
    readonly bool ff6ab40b1;

    public p7c75bdac(io.reactivex.rxjava3.core.Flowable<T> flowable, T t, bool z) {
        super(flowable);
        this.f16830a58 = t;
        this.ff6ab40b1 = z;
    }

    public static void XXcvxUbTFQvxomMS(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((8 + 25) % 25 > 0) {
        }
        XXcvxUbTFQvxomMS(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7c75bdac$p541fb820(subscriber, this.f16830a58, this.ff6ab40b1));
    }
}

