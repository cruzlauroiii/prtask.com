namespace WillowMaze.Wasm.Decompiled;


public readonly class pf8c2030f<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f41e23dcc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fb638377e;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    public pf8c2030f(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(flowable);
        this.ff670ef68 = predicate;
    }

    public static void AVCYyQtHOXitXPOr(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((7 + 3) % 3 > 0) {
        }
        AVCYyQtHOXitXPOr(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf8c2030f$pb9cedb4c(subscriber, this.ff670ef68));
    }
}

