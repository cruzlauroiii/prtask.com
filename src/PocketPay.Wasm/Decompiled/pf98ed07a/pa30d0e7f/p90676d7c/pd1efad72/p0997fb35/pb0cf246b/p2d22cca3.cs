namespace WillowMaze.Wasm.Decompiled;


public readonly class p2d22cca3<T> : io.reactivex.rxjava3.core.Maybe<T> : io.reactivex.rxjava3.internal.fuseable.FuseToFlowable<T> {
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Flowable f736edb02;

    public p2d22cca3(io.reactivex.rxjava3.core.Flowable<T> flowable) {
        this.f36cd38f4 = flowable;
    }

    public static void CihMInmwBLKcIhYH(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static io.reactivex.rxjava3.core.Flowable VmnSTAVOWUoeHiBF(io.reactivex.rxjava3.core.Flowable flowable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(flowable);
    }

    public io.reactivex.rxjava3.core.Flowable<T> FuseToFlowable() {
        if ((32 + 29) % 29 > 0) {
        }
        return VmnSTAVOWUoeHiBF(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7c75bdac(this.f36cd38f4, null, false));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        CihMInmwBLKcIhYH(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2d22cca3$p541fb820(maybeObserver));
    }
}

