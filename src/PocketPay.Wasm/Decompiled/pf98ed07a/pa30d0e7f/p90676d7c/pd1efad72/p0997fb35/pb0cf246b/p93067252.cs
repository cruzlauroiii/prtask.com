namespace WillowMaze.Wasm.Decompiled;


public readonly class p93067252<T, U> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<U>> f4dcb806f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7cf49b9d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8d4bb42f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa5284e80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fdc70610b;

    public p93067252(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<U>> function) {
        super(flowable);
        this.f4dcb806f = function;
    }

    public static void RZXpqSRNPiyhNcWn(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((4 + 5) % 5 > 0) {
        }
        RZXpqSRNPiyhNcWn(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93067252$pe16eeb5b(new pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0(subscriber), this.f4dcb806f));
    }
}

