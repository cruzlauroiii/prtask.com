namespace WillowMaze.Wasm.Decompiled;


public readonly class pc3bcf835<T, K> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f26fe960e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f27f0162f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f85d3bd7e;
    readonly io.reactivex.rxjava3.functions.Function<T, K> f866d6d67;
    readonly io.reactivex.rxjava3.functions.BiPredicate<K, K> f9f89a861;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fa64d4cca;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fad290083;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fb7dd3202;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe230bd2e;

    public pc3bcf835(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<T, K> function, io.reactivex.rxjava3.functions.BiPredicate<K, K> biPredicate) {
        super(flowable);
        this.f866d6d67 = function;
        this.f9f89a861 = biPredicate;
    }

    public static void SPgYZTEMOYMVQmNa(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void AbbccLuVRAgzJdww(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((13 + 24) % 24 > 0) {
        }
        if (!(subscriber is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d)) {
            SPgYZTEMOYMVQmNa(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc3bcf835$p29ee2870(subscriber, this.f866d6d67, this.f9f89a861));
        } else {
            abbccLuVRAgzJdww(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc3bcf835$pd52598a2((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) subscriber, this.f866d6d67, this.f9f89a861));
        }
    }
}

