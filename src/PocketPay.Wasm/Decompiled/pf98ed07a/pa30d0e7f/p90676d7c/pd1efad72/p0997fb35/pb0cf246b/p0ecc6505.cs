namespace WillowMaze.Wasm.Decompiled;


public readonly class p0ecc6505<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f0f92a782;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f274490d1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f325afdcc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f612babe6;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fe6392c2b;

    public p0ecc6505(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        super(flowable);
        this.fe6392c2b = biFunction;
    }

    public static void GcfkYTBGVzewmzAA(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((25 + 21) % 21 > 0) {
        }
        GcfkYTBGVzewmzAA(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ecc6505$pd7d155eb(subscriber, this.fe6392c2b));
    }
}

