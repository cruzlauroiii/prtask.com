namespace WillowMaze.Wasm.Decompiled;


public readonly class pba61aebd<T, U, V> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly org.reactivestreams.Publisher<U> f2ffa680f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f330810eb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f780b8fec;
    readonly org.reactivestreams.Publisher<? : T> f795f3202;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7d240029;
    readonly p5a445d71.p18f29add.p32c73be0 f99a7dc6f;
    readonly p5a445d71.p18f29add.p32c73be0 fa2db20f9;
    readonly p5a445d71.p18f29add.p32c73be0 fc9db1c36;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<V>> fca11cf04;
    readonly p5a445d71.p18f29add.p32c73be0 fd7eb7d58;
    readonly p5a445d71.p18f29add.p32c73be0 fde11db2a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fedfe7385;

    public pba61aebd(io.reactivex.rxjava3.core.Flowable<T> flowable, org.reactivestreams.Publisher<U> publisher, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<V>> function, org.reactivestreams.Publisher<? : T> publisher2) {
        super(flowable);
        this.f2ffa680f = publisher;
        this.fca11cf04 = function;
        this.f795f3202 = publisher2;
    }

    public static void DcVnjlQckYkaNekI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void GrpVGBwGTZEhljJU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void WChhuLMAjtIpoVWu(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void HtQePvNJTpdMlmVf(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void RPygmsyXvUNflmpz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pce0ce207 pba61aebd_pce0ce207, p5a445d71.p18f29add.p32c73be0 p32c73be0Var) {
        pba61aebd_pce0ce207.startFirstTimeout(p32c73be0Var);
    }

    public static void ZCOfSgcJyLOWjsnL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pd1e8bd20 pba61aebd_pd1e8bd20, p5a445d71.p18f29add.p32c73be0 p32c73be0Var) {
        pba61aebd_pd1e8bd20.startFirstTimeout(p32c73be0Var);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((1 + 19) % 19 > 0) {
        }
        if (this.f795f3202 is not null) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pd1e8bd20 pba61aebd_pd1e8bd20 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pd1e8bd20(subscriber, this.fca11cf04, this.f795f3202);
            GrpVGBwGTZEhljJU(subscriber, pba61aebd_pd1e8bd20);
            zCOfSgcJyLOWjsnL(pba61aebd_pd1e8bd20, this.f2ffa680f);
            htQePvNJTpdMlmVf(this.f36cd38f4, pba61aebd_pd1e8bd20);
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pce0ce207 pba61aebd_pce0ce207 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pba61aebd$pce0ce207(subscriber, this.fca11cf04);
        DcVnjlQckYkaNekI(subscriber, pba61aebd_pce0ce207);
        rPygmsyXvUNflmpz(pba61aebd_pce0ce207, this.f2ffa680f);
        WChhuLMAjtIpoVWu(this.f36cd38f4, pba61aebd_pce0ce207);
    }
}

