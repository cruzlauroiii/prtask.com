namespace WillowMaze.Wasm.Decompiled;


public readonly class p55fe4ffc<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f2b2abb5b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f3303b116;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f832a28bf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fc6845740;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    public p55fe4ffc(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(flowable);
        this.ff670ef68 = predicate;
    }

    public static void COVnotKnBUPwHxaU(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void JFsoVtpgCWeISkHg(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((2 + 2) % 2 > 0) {
        }
        if (subscriber is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) {
            jFsoVtpgCWeISkHg(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p55fe4ffc$p5dc62853((pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d) subscriber, this.ff670ef68));
        } else {
            cOVnotKnBUPwHxaU(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p55fe4ffc$p2189bcb1(subscriber, this.ff670ef68));
        }
    }
}

