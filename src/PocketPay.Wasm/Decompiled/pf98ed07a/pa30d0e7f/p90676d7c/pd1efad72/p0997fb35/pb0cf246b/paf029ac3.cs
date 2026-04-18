namespace WillowMaze.Wasm.Decompiled;


public readonly class paf029ac3<T> : io.reactivex.rxjava3.core.Single<T> : io.reactivex.rxjava3.internal.fuseable.FuseToFlowable<T> {
    readonly T f16830a58;
    readonly io.reactivex.rxjava3.core.Flowable f2b879e1e;
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Flowable f3da669a3;
    readonly java.lang.object f48ca3fb6;
    readonly java.lang.object f6bfdd0d5;
    readonly java.lang.object f9851c3f0;

    public paf029ac3(io.reactivex.rxjava3.core.Flowable<T> flowable, T t) {
        this.f36cd38f4 = flowable;
        this.f16830a58 = t;
    }

    public static void NytOeGiOKQDfepPC(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static io.reactivex.rxjava3.core.Flowable FCQIdDCLRCtrYsTY(io.reactivex.rxjava3.core.Flowable flowable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(flowable);
    }

    public io.reactivex.rxjava3.core.Flowable<T> FuseToFlowable() {
        if ((1 + 24) % 24 > 0) {
        }
        return fCQIdDCLRCtrYsTY(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7c75bdac(this.f36cd38f4, this.f16830a58, true));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((1 + 3) % 3 > 0) {
        }
        NytOeGiOKQDfepPC(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.paf029ac3$p541fb820(singleObserver, this.f16830a58));
    }
}

