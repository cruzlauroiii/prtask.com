namespace WillowMaze.Wasm.Decompiled;


public readonly class p86c468f9<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2d7937c7;
    readonly int f42088376;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly bool f50fee566;
    readonly int f669f2337;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f70ebaf6c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8e819e46;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fca639ab4;
    readonly bool fcfa04f91;
    readonly int fe37dca89;

    public p86c468f9(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, bool z, int i) {
        super(flowable);
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
    }

    public static void BGGZGvOLnOVRGZXq(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((28 + 15) % 15 > 0) {
        }
        BGGZGvOLnOVRGZXq(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d(subscriber, this.f4b9f83e1, this.f50fee566, this.f42088376));
    }
}

