namespace WillowMaze.Wasm.Decompiled;


public readonly class p0c5e764f<T, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly bool f31b781f5;
    readonly int f42088376;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly int f4e4a38d7;
    readonly bool f50c0d8b3;
    readonly bool f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f725f875e;
    readonly bool f8120e036;
    readonly bool fbba5b371;
    readonly int ff68048f1;

    public p0c5e764f(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, bool z, int i) {
        super(flowable);
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
    }

    public static void UfZfBXTYvxzHPwcv(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((15 + 17) % 17 > 0) {
        }
        ufZfBXTYvxzHPwcv(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f(subscriber, this.f4b9f83e1, this.f50fee566, this.f42088376));
    }
}

