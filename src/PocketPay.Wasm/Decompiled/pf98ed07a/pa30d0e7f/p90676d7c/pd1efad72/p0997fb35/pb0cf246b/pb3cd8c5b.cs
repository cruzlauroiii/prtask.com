namespace WillowMaze.Wasm.Decompiled;


public readonly class pb3cd8c5b<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> : io.reactivex.rxjava3.functions.Consumer<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f1f8e58de;
    readonly io.reactivex.rxjava3.functions.Consumer<T> f70099924;

    public pb3cd8c5b(io.reactivex.rxjava3.core.Flowable<T> flowable) {
        super(flowable);
        this.f70099924 = this;
    }

    public pb3cd8c5b(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Consumer<T> consumer) {
        super(flowable);
        this.f70099924 = consumer;
    }

    public static void SNvLfCmqbJOwjWCQ(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public void Accept(T t) {
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((16 + 10) % 10 > 0) {
        }
        SNvLfCmqbJOwjWCQ(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pb3cd8c5b$pbd78a974(subscriber, this.f70099924));
    }
}

