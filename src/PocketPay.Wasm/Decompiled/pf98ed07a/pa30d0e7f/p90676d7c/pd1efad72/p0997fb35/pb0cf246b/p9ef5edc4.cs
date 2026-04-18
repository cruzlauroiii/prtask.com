namespace WillowMaze.Wasm.Decompiled;


public readonly class p9ef5edc4<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly java.util.concurrent.TimeUnit f2d53a1c9;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f5460608e;
    readonly long f554666ae;
    readonly java.util.concurrent.TimeUnit f5e154ace;
    readonly long f90272dda;
    readonly java.util.concurrent.TimeUnit f92d61c8f;
    readonly java.util.concurrent.TimeUnit fc25f045d;

    public p9ef5edc4(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(flowable);
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker USSgGhvrDLswKLBl(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void RlnfZlAcjfrLpHBh(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((4 + 12) % 12 > 0) {
        }
        rlnfZlAcjfrLpHBh(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9ef5edc4$p0abf6034(new pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0(subscriber), this.f90272dda, this.f3e34bdeb, USSgGhvrDLswKLBl(this.f499f31e7)));
    }
}

