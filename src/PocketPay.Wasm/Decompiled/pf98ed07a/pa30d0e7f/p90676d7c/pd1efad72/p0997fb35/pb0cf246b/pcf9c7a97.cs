namespace WillowMaze.Wasm.Decompiled;


public readonly class pcf9c7a97<T, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f814526b4;
    readonly io.reactivex.rxjava3.functions.Supplier<R> f99b0e8da;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f9f857491;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fc71191ac;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fc76bd27f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fe2215fc6;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fe6392c2b;

    public pcf9c7a97(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Supplier<R> supplier, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction) {
        super(flowable);
        this.fe6392c2b = biFunction;
        this.f99b0e8da = supplier;
    }

    public static void FmKGckjaRVDTakIH(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((21 + 3) % 3 > 0) {
        }
        fmKGckjaRVDTakIH(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcf9c7a97$pa738cc88(subscriber, this.f99b0e8da, this.fe6392c2b));
    }
}

