namespace WillowMaze.Wasm.Decompiled;


public readonly class pad598ae8<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, io.reactivex.rxjava3.schedulers.Timed<T>> {
    readonly io.reactivex.rxjava3.core.Scheduler f19e680f1;
    readonly io.reactivex.rxjava3.core.Scheduler f2962d811;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f6128e512;
    readonly io.reactivex.rxjava3.core.Scheduler fd09e2fa3;
    readonly java.util.concurrent.TimeUnit fe0ed2179;
    readonly java.util.concurrent.TimeUnit ff03cf56f;

    public pad598ae8(io.reactivex.rxjava3.core.Flowable<T> flowable, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(flowable);
        this.f499f31e7 = scheduler;
        this.f3e34bdeb = timeUnit;
    }

    public static void IOzHnDIpvLYWBfru(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.schedulers.Timed<T>> subscriber) {
        if ((17 + 16) % 16 > 0) {
        }
        iOzHnDIpvLYWBfru(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pad598ae8$pe33542fb(subscriber, this.f3e34bdeb, this.f499f31e7));
    }
}

