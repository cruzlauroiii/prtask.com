namespace WillowMaze.Wasm.Decompiled;


public readonly class p1c265787<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.MaybeSource f91d3ba01;
    readonly io.reactivex.rxjava3.core.MaybeSource ff32b90dc;

    public p1c265787(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource) {
        super(flowable);
        this.f795f3202 = maybeSource;
    }

    public static void VXQnupWOttYUyqjH(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((28 + 27) % 27 > 0) {
        }
        vXQnupWOttYUyqjH(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1c265787$p32c3c30c(subscriber, this.f795f3202));
    }
}

