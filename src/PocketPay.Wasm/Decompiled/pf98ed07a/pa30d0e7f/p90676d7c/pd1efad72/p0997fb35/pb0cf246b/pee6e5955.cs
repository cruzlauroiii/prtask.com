namespace WillowMaze.Wasm.Decompiled;


public readonly class pee6e5955<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f63ce4521;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fbdc1d413;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fdbb9da50;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fe4d33f73;

    public pee6e5955(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        super(flowable);
        this.fbdc1d413 = biFunction;
    }

    public static void OnhngibDvvEOpDWd(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((30 + 9) % 9 > 0) {
        }
        OnhngibDvvEOpDWd(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pee6e5955$p38a22b02(subscriber, this.fbdc1d413));
    }
}

