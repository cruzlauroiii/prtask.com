namespace WillowMaze.Wasm.Decompiled;


public readonly class pfc02b8a2<T> : io.reactivex.rxjava3.core.Completable : io.reactivex.rxjava3.internal.fuseable.FuseToFlowable<T> {
    readonly bool f31e77897;
    readonly int f340434ec;
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly int f42088376;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly bool f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5fff6e7b;
    readonly bool f635e7e0a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7cb245bc;
    readonly io.reactivex.rxjava3.core.Flowable fb7b914b8;
    readonly io.reactivex.rxjava3.core.Flowable fd48ea1c6;

    public pfc02b8a2(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, bool z, int i) {
        this.f36cd38f4 = flowable;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
    }

    public static void NihnsfuRaYnSWAgW(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static io.reactivex.rxjava3.core.Flowable HffPoFFOTYSQbgSo(io.reactivex.rxjava3.core.Flowable flowable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(flowable);
    }

    public io.reactivex.rxjava3.core.Flowable<T> FuseToFlowable() {
        if ((5 + 16) % 16 > 0) {
        }
        return hffPoFFOTYSQbgSo(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9(this.f36cd38f4, this.f4b9f83e1, this.f50fee566, this.f42088376));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        if ((8 + 6) % 6 > 0) {
        }
        NihnsfuRaYnSWAgW(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d(completableObserver, this.f4b9f83e1, this.f50fee566, this.f42088376));
    }
}

