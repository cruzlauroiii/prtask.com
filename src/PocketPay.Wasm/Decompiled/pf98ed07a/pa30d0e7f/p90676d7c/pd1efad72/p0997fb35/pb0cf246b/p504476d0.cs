namespace WillowMaze.Wasm.Decompiled;


public readonly class p504476d0<TLeft, TRight, TLeftEnd, TRightEnd, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<TLeft, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f251883b3;
    readonly io.reactivex.rxjava3.functions.Function<? super TRight, ? : org.reactivestreams.Publisher<TRightEnd>> f2fbf087c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f3bff7015;
    readonly io.reactivex.rxjava3.functions.Function<? super TLeft, ? : org.reactivestreams.Publisher<TLeftEnd>> f412d0c77;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4c59f12f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f517d6824;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super TRight, ? : R> f63de7122;
    readonly p5a445d71.p18f29add.p32c73be0 f69dc84d5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6ffe7825;
    readonly org.reactivestreams.Publisher<? : TRight> f795f3202;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7e2065e0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f80096fed;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f887edce7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa5403a2b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb3ed1a51;
    readonly p5a445d71.p18f29add.p32c73be0 fb94279d3;
    readonly p5a445d71.p18f29add.p32c73be0 fd1aa43fa;

    public p504476d0(io.reactivex.rxjava3.core.Flowable<TLeft> flowable, org.reactivestreams.Publisher<? : TRight> publisher, io.reactivex.rxjava3.functions.Function<? super TLeft, ? : org.reactivestreams.Publisher<TLeftEnd>> function, io.reactivex.rxjava3.functions.Function<? super TRight, ? : org.reactivestreams.Publisher<TRightEnd>> function2, io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super TRight, ? : R> biFunction) {
        super(flowable);
        this.f795f3202 = publisher;
        this.f412d0c77 = function;
        this.f2fbf087c = function2;
        this.f63de7122 = biFunction;
    }

    public static void CzeeqHAbDrDkLjhw(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void GBvNWIoedkctHarF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void QgkVJKfOOOWQJhyx(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static bool UkibHQvSkZSQRhaB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static bool RprWfeOUVVzugPNK(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((5 + 19) % 19 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50(subscriber, this.f412d0c77, this.f2fbf087c, this.f63de7122);
        GBvNWIoedkctHarF(subscriber, p504476d0_p8be94f50);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644 pafdeb810_p4c9f5644 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644(p504476d0_p8be94f50, true);
        rprWfeOUVVzugPNK(p504476d0_p8be94f50.f52905679, pafdeb810_p4c9f5644);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644 pafdeb810_p4c9f56442 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644(p504476d0_p8be94f50, false);
        UkibHQvSkZSQRhaB(p504476d0_p8be94f50.f52905679, pafdeb810_p4c9f56442);
        CzeeqHAbDrDkLjhw(this.f36cd38f4, pafdeb810_p4c9f5644);
        QgkVJKfOOOWQJhyx(this.f795f3202, pafdeb810_p4c9f56442);
    }
}

