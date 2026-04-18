namespace WillowMaze.Wasm.Decompiled;


public readonly class p50bcaf3b<T> : io.reactivex.rxjava3.core.Single<java.lang.long> : io.reactivex.rxjava3.internal.fuseable.FuseToFlowable<java.lang.long> {
    readonly io.reactivex.rxjava3.core.Flowable f0a287ef8;
    readonly io.reactivex.rxjava3.core.Flowable f0feb811d;
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Flowable f4fcdb9cf;
    readonly io.reactivex.rxjava3.core.Flowable fa70bef73;

    public p50bcaf3b(io.reactivex.rxjava3.core.Flowable<T> flowable) {
        this.f36cd38f4 = flowable;
    }

    public static io.reactivex.rxjava3.core.Flowable HWjFczZyrJzuTrug(io.reactivex.rxjava3.core.Flowable flowable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(flowable);
    }

    public static void XmRdyAtUkFTHNxRj(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public io.reactivex.rxjava3.core.Flowable<java.lang.long> FuseToFlowable() {
        return HWjFczZyrJzuTrug(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0a3b59b2(this.f36cd38f4));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.long> singleObserver) {
        XmRdyAtUkFTHNxRj(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p50bcaf3b$p4ef17000(singleObserver));
    }
}

