namespace WillowMaze.Wasm.Decompiled;


public readonly class p855ed3b7<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly io.reactivex.rxjava3.core.Flowable f5e132bdb;
    readonly bool f66eac970;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbfc97ec8;

    public p855ed3b7(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, bool z) {
        this.f36cd38f4 = flowable;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void YTwqiXdrswxZPsVf(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((3 + 22) % 22 > 0) {
        }
        YTwqiXdrswxZPsVf(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49(subscriber, this.f4b9f83e1, this.f50fee566));
    }
}

