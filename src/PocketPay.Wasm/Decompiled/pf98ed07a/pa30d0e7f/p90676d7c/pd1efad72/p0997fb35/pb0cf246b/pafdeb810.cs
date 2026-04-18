namespace WillowMaze.Wasm.Decompiled;


public readonly class pafdeb810<TLeft, TRight, TLeftEnd, TRightEnd, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<TLeft, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f077363fc;
    readonly io.reactivex.rxjava3.functions.Function<? super TRight, ? : org.reactivestreams.Publisher<TRightEnd>> f2fbf087c;
    readonly io.reactivex.rxjava3.functions.Function<? super TLeft, ? : org.reactivestreams.Publisher<TLeftEnd>> f412d0c77;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f4eaf9a8d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f62a1dba8;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super io.reactivex.rxjava3.core.Flowable<TRight>, ? : R> f63de7122;
    readonly org.reactivestreams.Publisher<? : TRight> f795f3202;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f9bffbe1b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fabd24949;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb40fc20b;
    readonly p5a445d71.p18f29add.p32c73be0 fbe63dfc5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbe9a39b7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fdb73e537;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ffe38b3ae;

    public pafdeb810(io.reactivex.rxjava3.core.Flowable<TLeft> flowable, org.reactivestreams.Publisher<? : TRight> publisher, io.reactivex.rxjava3.functions.Function<? super TLeft, ? : org.reactivestreams.Publisher<TLeftEnd>> function, io.reactivex.rxjava3.functions.Function<? super TRight, ? : org.reactivestreams.Publisher<TRightEnd>> function2, io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super io.reactivex.rxjava3.core.Flowable<TRight>, ? : R> biFunction) {
        super(flowable);
        this.f795f3202 = publisher;
        this.f412d0c77 = function;
        this.f2fbf087c = function2;
        this.f63de7122 = biFunction;
    }

    public static void AAbAbUlzuzFHOANW(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void NdnCqUORnFZWdxmw(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void ZGycOQRFxbWjQylk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool ZPbsmEHCWunvgfqZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static bool TILXnzqMeKRbXxeZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((12 + 17) % 17 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92 pafdeb810_p93060f92 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p93060f92(subscriber, this.f412d0c77, this.f2fbf087c, this.f63de7122);
        ZGycOQRFxbWjQylk(subscriber, pafdeb810_p93060f92);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644 pafdeb810_p4c9f5644 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644(pafdeb810_p93060f92, true);
        ZPbsmEHCWunvgfqZ(pafdeb810_p93060f92.f52905679, pafdeb810_p4c9f5644);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644 pafdeb810_p4c9f56442 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644(pafdeb810_p93060f92, false);
        tILXnzqMeKRbXxeZ(pafdeb810_p93060f92.f52905679, pafdeb810_p4c9f56442);
        NdnCqUORnFZWdxmw(this.f36cd38f4, pafdeb810_p4c9f5644);
        AAbAbUlzuzFHOANW(this.f795f3202, pafdeb810_p4c9f56442);
    }
}

