namespace WillowMaze.Wasm.Decompiled;


public readonly class p2dc951d8<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f1a16bc4d;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f6a13bfac;

    public p2dc951d8(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(flowable);
        this.f499f31e7 = scheduler;
    }

    public static void YeVJeOBdzLCugkQt(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((26 + 29) % 29 > 0) {
        }
        yeVJeOBdzLCugkQt(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2dc951d8$p21d89799(subscriber, this.f499f31e7));
    }
}

