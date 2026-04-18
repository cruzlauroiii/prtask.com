namespace WillowMaze.Wasm.Decompiled;


public readonly class p8d542fec<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f05949d1e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f9010251f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f99037c32;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fe6392c2b;

    public p8d542fec(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        super(flowable);
        this.fe6392c2b = biFunction;
    }

    public static void ULRFPeAxYVrbtkGC(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((11 + 11) % 11 > 0) {
        }
        ULRFPeAxYVrbtkGC(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8d542fec$p7c675531(subscriber, this.fe6392c2b));
    }
}

