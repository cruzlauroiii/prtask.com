namespace WillowMaze.Wasm.Decompiled;


public readonly class pa9d45ef6<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly io.reactivex.rxjava3.core.Flowable f16fc4dac;
    readonly bool f2cc0737d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f30ae2581;
    readonly io.reactivex.rxjava3.core.Flowable f33b1f4c2;
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa73aa630;
    readonly io.reactivex.rxjava3.core.Flowable fbc61e77b;
    readonly io.reactivex.rxjava3.core.Flowable fd21eeb07;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fdc907dc3;

    public pa9d45ef6(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, bool z) {
        this.f36cd38f4 = flowable;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void UIxOXvMdSfihKKkq(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((12 + 4) % 4 > 0) {
        }
        uIxOXvMdSfihKKkq(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pa9d45ef6$p6fb43174(subscriber, this.f4b9f83e1, this.f50fee566));
    }
}

