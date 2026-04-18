namespace WillowMaze.Wasm.Decompiled;


public readonly class p58d79e9c<T, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly bool f1af3b437;
    readonly int f2310e0fb;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4f0629a5;
    readonly io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Flowable<T>, ? : org.reactivestreams.Publisher<? : R>> f5b3c3200;
    readonly int f6ce17216;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f78650107;
    readonly bool f7dc823e3;
    readonly bool f825ea879;
    readonly int f9d155c96;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa602ce7a;
    readonly bool fb4f4a7a8;

    public p58d79e9c(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Flowable<T>, ? : org.reactivestreams.Publisher<? : R>> function, int i, bool z) {
        super(flowable);
        this.f5b3c3200 = function;
        this.f4c203b76 = i;
        this.f825ea879 = z;
    }

    public static void EVxXloZiXWJOExxQ(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static java.lang.object GXKxeyJCrxlihoLe(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void TrTqbaEEgeYmBbOb(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static java.lang.object VQvZFSpgIIWQQWqu(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void IbDjRsxTpUbbtLLm(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void MfOpaQIQAqNwVjqC(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((13 + 24) % 24 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p58d79e9c$p2531c9d8 p58d79e9c_p2531c9d8 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p58d79e9c$p2531c9d8(this.f4c203b76, this.f825ea879);
        try {
            TrTqbaEEgeYmBbOb((p5a445d71.p18f29add.p32c73be0) GXKxeyJCrxlihoLe(VQvZFSpgIIWQQWqu(this.f5b3c3200, p58d79e9c_p2531c9d8), "selector returned a null Publisher"), new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p58d79e9c$p9da755e1(subscriber, p58d79e9c_p2531c9d8));
            EVxXloZiXWJOExxQ(this.f36cd38f4, p58d79e9c_p2531c9d8);
        } catch (java.lang.Exception th) {
            ibDjRsxTpUbbtLLm(th);
            mfOpaQIQAqNwVjqC(th, subscriber);
        }
    }
}

