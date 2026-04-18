namespace WillowMaze.Wasm.Decompiled;


public readonly class p9f287dff<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f10298b36;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : org.reactivestreams.Publisher<? : T>> f1a4f6e5a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1b836cb2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe421df32;

    public p9f287dff(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : org.reactivestreams.Publisher<? : T>> function) {
        super(flowable);
        this.f1a4f6e5a = function;
    }

    public static void AFnIxVXwXBJHePfn(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void HIYHEVMlCwhPlXQo(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((6 + 11) % 11 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9f287dff$pee0fdafd p9f287dff_pee0fdafd = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9f287dff$pee0fdafd(subscriber, this.f1a4f6e5a);
        HIYHEVMlCwhPlXQo(subscriber, p9f287dff_pee0fdafd);
        AFnIxVXwXBJHePfn(this.f36cd38f4, p9f287dff_pee0fdafd);
    }
}

