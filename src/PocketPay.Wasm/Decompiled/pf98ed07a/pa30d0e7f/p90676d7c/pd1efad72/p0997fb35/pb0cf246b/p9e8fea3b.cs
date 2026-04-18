namespace WillowMaze.Wasm.Decompiled;


public readonly class p9e8fea3b<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f04c53121;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f31bc3d2a;
    readonly io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> ff670ef68;

    public p9e8fea3b(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> predicate) {
        super(flowable);
        this.ff670ef68 = predicate;
    }

    public static void BXClSnZgbVoELbRq(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((9 + 19) % 19 > 0) {
        }
        bXClSnZgbVoELbRq(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9e8fea3b$pb78efd82(subscriber, this.ff670ef68));
    }
}

