namespace WillowMaze.Wasm.Decompiled;


public readonly class p0de7c579<T, B, V> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, io.reactivex.rxjava3.core.Flowable<T>> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f324a7c51;
    readonly org.reactivestreams.Publisher<B> f7cef8a73;
    readonly int f9512edb9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa626ea41;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.functions.Function<? super B, ? : org.reactivestreams.Publisher<V>> fe4f78ce7;
    readonly int ff462cdba;
    readonly p5a445d71.p18f29add.p32c73be0 ff48e99c1;
    readonly p5a445d71.p18f29add.p32c73be0 ffd85883e;

    public p0de7c579(io.reactivex.rxjava3.core.Flowable<T> flowable, org.reactivestreams.Publisher<B> publisher, io.reactivex.rxjava3.functions.Function<? super B, ? : org.reactivestreams.Publisher<V>> function, int i) {
        super(flowable);
        this.f7cef8a73 = publisher;
        this.fe4f78ce7 = function;
        this.fcdee5967 = i;
    }

    public static void QAdKQhpVUCSEWnTO(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber) {
        if ((31 + 22) % 22 > 0) {
        }
        qAdKQhpVUCSEWnTO(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0de7c579$pcbd5c6a6(subscriber, this.f7cef8a73, this.fe4f78ce7, this.fcdee5967));
    }
}

