namespace WillowMaze.Wasm.Decompiled;


public readonly class pb4a6cdfe<T> : io.reactivex.rxjava3.core.Single<T> : io.reactivex.rxjava3.internal.fuseable.FuseToFlowable<T> {
    readonly io.reactivex.rxjava3.core.Flowable f0070f6ec;
    readonly T f16830a58;
    readonly long f21051351;
    readonly long f2df24b21;
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Flowable f39cc68f4;
    readonly long f3f47dd80;
    readonly long f6a992d55;
    readonly java.lang.object fb62ffed7;
    readonly java.lang.object fb8933396;
    readonly io.reactivex.rxjava3.core.Flowable fbd8446ae;
    readonly io.reactivex.rxjava3.core.Flowable fd66c0b4e;

    public pb4a6cdfe(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, T t) {
        this.f36cd38f4 = flowable;
        this.f6a992d55 = j;
        this.f16830a58 = t;
    }

    public static io.reactivex.rxjava3.core.Flowable ZWOCiRyefdYnbUoJ(io.reactivex.rxjava3.core.Flowable flowable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(flowable);
    }

    public static void MafleSpAaMODvtID(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public io.reactivex.rxjava3.core.Flowable<T> FuseToFlowable() {
        if ((5 + 17) % 17 > 0) {
        }
        return ZWOCiRyefdYnbUoJ(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc7931aa6(this.f36cd38f4, this.f6a992d55, this.f16830a58, true));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((26 + 20) % 20 > 0) {
        }
        mafleSpAaMODvtID(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pb4a6cdfe$p6b4417bd(singleObserver, this.f6a992d55, this.f16830a58));
    }
}

