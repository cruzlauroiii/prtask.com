namespace WillowMaze.Wasm.Decompiled;


public readonly class p09214eef<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.SingleSource f702567ee;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f795f3202;

    public p09214eef(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        super(flowable);
        this.f795f3202 = singleSource;
    }

    public static void SeiEspENjAXKfjIP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void KLfdCleQwKrFDpHT(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void TJRgGXhGGJMWOhDL(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d(subscriber);
        SeiEspENjAXKfjIP(subscriber, p09214eef_pc87b636d);
        kLfdCleQwKrFDpHT(this.f36cd38f4, p09214eef_pc87b636d);
        tJRgGXhGGJMWOhDL(this.f795f3202, p09214eef_pc87b636d.f7af6fc45);
    }
}

