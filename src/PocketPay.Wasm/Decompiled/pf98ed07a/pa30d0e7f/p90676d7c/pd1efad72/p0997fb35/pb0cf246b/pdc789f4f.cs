namespace WillowMaze.Wasm.Decompiled;


public readonly class pdc789f4f<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly long f07cc694b;
    readonly java.util.concurrent.TimeUnit f1d4b8de2;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f469a3639;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly int f5e87b721;
    readonly long f7881c22a;
    readonly io.reactivex.rxjava3.core.Scheduler f81396b6b;
    readonly bool f825ea879;
    readonly bool f922322f5;
    readonly java.util.concurrent.TimeUnit f93cd547a;
    readonly int f946f8d12;
    readonly java.util.concurrent.TimeUnit fa25cbf2b;
    readonly io.reactivex.rxjava3.core.Scheduler fabdad14c;
    readonly io.reactivex.rxjava3.core.Scheduler fcd3f9b8f;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.core.Scheduler fd4888665;
    readonly long fdb2ba506;
    readonly long fe2942a04;
    readonly long ff0087eb6;
    readonly java.util.concurrent.TimeUnit ff86ee99a;

    public pdc789f4f(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, int i, bool z) {
        super(flowable);
        this.fe2942a04 = j;
        this.f07cc694b = j2;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fcdee5967 = i;
        this.f825ea879 = z;
    }

    public static void XxSILEGmbjLDPwJe(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((31 + 14) % 14 > 0) {
        }
        xxSILEGmbjLDPwJe(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6(subscriber, this.fe2942a04, this.f07cc694b, this.f3e34bdeb, this.f499f31e7, this.fcdee5967, this.f825ea879));
    }
}

