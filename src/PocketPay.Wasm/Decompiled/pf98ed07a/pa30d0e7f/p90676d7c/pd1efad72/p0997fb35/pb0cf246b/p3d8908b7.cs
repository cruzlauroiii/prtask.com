namespace WillowMaze.Wasm.Decompiled;


public readonly class p3d8908b7<T> : io.reactivex.rxjava3.core.Completable : io.reactivex.rxjava3.internal.fuseable.FuseToFlowable<T> {
    readonly io.reactivex.rxjava3.core.Flowable f161cf8df;
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Flowable f5a1518ef;

    public p3d8908b7(io.reactivex.rxjava3.core.Flowable<T> flowable) {
        this.f36cd38f4 = flowable;
    }

    public static void IiXNmhDoLMeANzLT(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static io.reactivex.rxjava3.core.Flowable KZlOPDJWrUcAVjXc(io.reactivex.rxjava3.core.Flowable flowable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(flowable);
    }

    public io.reactivex.rxjava3.core.Flowable<T> FuseToFlowable() {
        return kZlOPDJWrUcAVjXc(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd80e9de(this.f36cd38f4));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        iiXNmhDoLMeANzLT(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p3d8908b7$p765294b8(completableObserver));
    }
}

