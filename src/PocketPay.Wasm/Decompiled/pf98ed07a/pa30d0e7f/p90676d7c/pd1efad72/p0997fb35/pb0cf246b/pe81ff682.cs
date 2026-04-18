namespace WillowMaze.Wasm.Decompiled;


public readonly class pe81ff682<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly java.util.concurrent.TimeUnit f196b3212;
    readonly io.reactivex.rxjava3.core.Scheduler f37390dd7;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f5c8c7600;
    readonly long f90272dda;
    readonly long f9901317d;
    readonly io.reactivex.rxjava3.core.Scheduler f9a1cd06a;
    readonly io.reactivex.rxjava3.core.Scheduler facc313b9;
    readonly long fb66905c6;
    readonly long fbc038020;
    readonly java.util.concurrent.TimeUnit ff66274f3;

    public pe81ff682(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(flowable);
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static void ElKQvSBlzQJYuBnv(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker LNkIIEdinqQztwtk(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((4 + 32) % 32 > 0) {
        }
        ElKQvSBlzQJYuBnv(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe81ff682$p0abf6034(new pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0(subscriber), this.f90272dda, this.f3e34bdeb, LNkIIEdinqQztwtk(this.f499f31e7)));
    }
}

