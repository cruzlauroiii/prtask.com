namespace WillowMaze.Wasm.Decompiled;


public readonly class p6debb716<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fe14348ae;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    public p6debb716(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(flowable);
        this.ff670ef68 = predicate;
    }

    public static void BphgnUvCBqkihixa(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((14 + 7) % 7 > 0) {
        }
        bphgnUvCBqkihixa(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p6debb716$p65e9fe22(subscriber, this.ff670ef68));
    }
}

