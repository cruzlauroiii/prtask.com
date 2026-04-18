namespace WillowMaze.Wasm.Decompiled;


public readonly class p21a86d0b<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.CompletableSource f048b46ee;
    readonly io.reactivex.rxjava3.core.CompletableSource f1646c9c6;
    readonly io.reactivex.rxjava3.core.CompletableSource f3602a552;
    readonly io.reactivex.rxjava3.core.CompletableSource f5ec41e96;
    readonly io.reactivex.rxjava3.core.CompletableSource f795f3202;

    public p21a86d0b(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.core.CompletableSource completableSource) {
        super(flowable);
        this.f795f3202 = completableSource;
    }

    public static void GBkHbmlVvYrRVtpp(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void IqUnShTzBaxuvmea(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void QpneaZSePDdeoIzP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p21a86d0b$peb5843c1 p21a86d0b_peb5843c1 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p21a86d0b$peb5843c1(subscriber);
        qpneaZSePDdeoIzP(subscriber, p21a86d0b_peb5843c1);
        GBkHbmlVvYrRVtpp(this.f36cd38f4, p21a86d0b_peb5843c1);
        IqUnShTzBaxuvmea(this.f795f3202, p21a86d0b_peb5843c1.f7af6fc45);
    }
}

