namespace WillowMaze.Wasm.Decompiled;


public readonly class pf2b5fd35<T, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1daa2195;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f44fb8fc4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.Notification<R>> f5b3c3200;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe4b58667;

    public pf2b5fd35(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.Notification<R>> function) {
        super(flowable);
        this.f5b3c3200 = function;
    }

    public static void AwFfHBZEtKcxIrVl(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((5 + 29) % 29 > 0) {
        }
        AwFfHBZEtKcxIrVl(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf2b5fd35$pdc4cee6e(subscriber, this.f5b3c3200));
    }
}

