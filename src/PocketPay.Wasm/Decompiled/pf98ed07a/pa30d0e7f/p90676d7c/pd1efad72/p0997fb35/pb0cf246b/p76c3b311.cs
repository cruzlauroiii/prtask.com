namespace WillowMaze.Wasm.Decompiled;


public readonly class p76c3b311<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f32a8e896;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly int f4c203b76;
    readonly bool f52357e35;
    readonly int f62fd9697;
    readonly int f69339fda;
    readonly bool f80eab8a7;
    readonly bool f825ea879;
    readonly bool faddaaa11;
    readonly bool fd7186599;

    public p76c3b311(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.core.Scheduler scheduler, bool z, int i) {
        super(flowable);
        this.f499f31e7 = scheduler;
        this.f825ea879 = z;
        this.f4c203b76 = i;
    }

    public static void SFBFRcAnSkmTnTZG(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker TIWPEiNgNLVcKvwh(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void VVehduhqpfKZpxQw(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((7 + 3) % 3 > 0) {
        }
        io.reactivex.rxjava3.core.Scheduler$Worker scheduler$WorkerTIWPEiNgNLVcKvwh = TIWPEiNgNLVcKvwh(this.f499f31e7);
        if (subscriber is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
            VVehduhqpfKZpxQw(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p0e833705((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) subscriber, scheduler$WorkerTIWPEiNgNLVcKvwh, this.f825ea879, this.f4c203b76));
        } else {
            SFBFRcAnSkmTnTZG(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p76c3b311$p8c90dc77(subscriber, scheduler$WorkerTIWPEiNgNLVcKvwh, this.f825ea879, this.f4c203b76));
        }
    }
}

