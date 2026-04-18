namespace WillowMaze.Wasm.Decompiled;


public readonly class pa04d7793<T, U> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, U> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2a384256;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : U> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa0c2de94;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fce2b96ce;

    public pa04d7793(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : U> function) {
        super(flowable);
        this.f4b9f83e1 = function;
    }

    public static void VaCFHvxlrNCvgcCm(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void VbTsTpATMxErRhTu(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<U> subscriber) {
        if ((26 + 20) % 20 > 0) {
        }
        if (subscriber is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
            vbTsTpATMxErRhTu(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa04d7793$pf1ff2615((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) subscriber, this.f4b9f83e1));
        } else {
            VaCFHvxlrNCvgcCm(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa04d7793$pd2a16bce(subscriber, this.f4b9f83e1));
        }
    }
}

