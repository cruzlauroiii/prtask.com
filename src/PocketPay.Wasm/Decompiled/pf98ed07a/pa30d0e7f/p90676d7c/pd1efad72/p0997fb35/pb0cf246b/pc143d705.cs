namespace WillowMaze.Wasm.Decompiled;


public readonly class pc143d705<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f03d23af9;
    readonly long f06368e80;
    readonly io.reactivex.rxjava3.core.Scheduler f34790826;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly java.util.concurrent.TimeUnit f4dca6538;
    readonly bool f5d19179c;
    readonly long f6cff0b5a;
    readonly io.reactivex.rxjava3.core.Scheduler f8791ccf2;
    readonly long f90272dda;
    readonly bool f9ad8f684;
    readonly bool fce9fafd3;
    readonly long fd258f2cd;
    readonly io.reactivex.rxjava3.core.Scheduler fd52e943e;
    readonly bool fda9cc245;
    readonly java.util.concurrent.TimeUnit fe4c09dba;
    readonly java.util.concurrent.TimeUnit fe6c33cc1;

    public pc143d705(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        super(flowable);
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f9ad8f684 = z;
    }

    public static void AzdXLwuJNJoEiuBm(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker DaHpfCszDhhSuKlv(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((12 + 5) % 5 > 0) {
        }
        AzdXLwuJNJoEiuBm(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc143d705$p472c9085(subscriber, this.f90272dda, this.f3e34bdeb, DaHpfCszDhhSuKlv(this.f499f31e7), this.f9ad8f684));
    }
}

