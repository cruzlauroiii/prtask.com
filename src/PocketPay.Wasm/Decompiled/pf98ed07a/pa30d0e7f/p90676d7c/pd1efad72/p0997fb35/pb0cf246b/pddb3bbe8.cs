namespace WillowMaze.Wasm.Decompiled;


public readonly class pddb3bbe8<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.MaybeSource fcc51a0a0;
    readonly io.reactivex.rxjava3.core.MaybeSource fdb8e32bb;

    public pddb3bbe8(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource) {
        super(flowable);
        this.f795f3202 = maybeSource;
    }

    public static void MKujoJUcYjraJTHE(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void XbcBIcpOyBOoSEcI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void AzqBqVbFLBRcemsz(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pddb3bbe8$pc87b636d pddb3bbe8_pc87b636d = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pddb3bbe8$pc87b636d(subscriber);
        XbcBIcpOyBOoSEcI(subscriber, pddb3bbe8_pc87b636d);
        MKujoJUcYjraJTHE(this.f36cd38f4, pddb3bbe8_pc87b636d);
        azqBqVbFLBRcemsz(this.f795f3202, pddb3bbe8_pc87b636d.f7af6fc45);
    }
}

