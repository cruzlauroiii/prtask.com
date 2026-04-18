namespace WillowMaze.Wasm.Decompiled;


public readonly class pcd3cd1ca<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f51ed71cf;
    readonly bool f70ae79c5;
    readonly long f7243f8be;
    readonly bool f7cb8d3ba;
    readonly bool f825ea879;
    readonly java.util.concurrent.TimeUnit f8e060f36;
    readonly java.util.concurrent.TimeUnit fa78b3674;
    readonly java.util.concurrent.TimeUnit fa8313724;
    readonly java.util.concurrent.TimeUnit fc9e13638;
    readonly bool fd8e3ddbd;
    readonly long fea71504d;
    readonly long ffb677d03;

    public pcd3cd1ca(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        super(flowable);
        this.f7243f8be = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f825ea879 = z;
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker QyWsbpzsVDTQpkTY(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void VZPUnVKZWPygWSrt(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((16 + 4) % 4 > 0) {
        }
        VZPUnVKZWPygWSrt(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcd3cd1ca$pb721f323(!this.f825ea879 ? new pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0<>(subscriber) : subscriber, this.f7243f8be, this.f3e34bdeb, QyWsbpzsVDTQpkTY(this.f499f31e7), this.f825ea879));
    }
}

