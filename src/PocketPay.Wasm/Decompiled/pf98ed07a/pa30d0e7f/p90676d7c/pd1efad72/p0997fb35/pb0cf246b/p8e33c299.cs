namespace WillowMaze.Wasm.Decompiled;


public readonly class p8e33c299<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly long f07cc694b;
    readonly long f228a600d;
    readonly int f25a3d8b2;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f6df90dd2;
    readonly java.util.concurrent.TimeUnit f815cb1f7;
    readonly bool f825ea879;
    readonly bool f9e418f24;
    readonly io.reactivex.rxjava3.core.Scheduler fa0740ff2;
    readonly bool fc3c971c8;
    readonly bool fc55b6085;
    readonly int fcdee5967;
    readonly bool fe1860266;
    readonly int fe4606ef5;
    readonly long feb0037a9;
    readonly io.reactivex.rxjava3.core.Scheduler fedd40d86;
    readonly long ff587819b;
    readonly io.reactivex.rxjava3.core.Scheduler ffe81d25c;

    public p8e33c299(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, int i, bool z) {
        super(flowable);
        this.f07cc694b = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fcdee5967 = i;
        this.f825ea879 = z;
    }

    public static void UosBSMlpJDZeahJr(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((25 + 4) % 4 > 0) {
        }
        UosBSMlpJDZeahJr(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8e33c299$p9ad995f1(subscriber, this.f07cc694b, this.f3e34bdeb, this.f499f31e7, this.fcdee5967, this.f825ea879));
    }
}

