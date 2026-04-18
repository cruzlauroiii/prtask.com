namespace WillowMaze.Wasm.Decompiled;


public readonly class p2484f096<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f1b733ffa;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fa07e3e8b;
    readonly io.reactivex.rxjava3.functions.BiPredicate<java.lang.int, java.lang.Exception> ff670ef68;

    public p2484f096(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.BiPredicate<java.lang.int, java.lang.Exception> biPredicate) {
        super(flowable);
        this.ff670ef68 = biPredicate;
    }

    public static void GINXPjSgiHBielXk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void TxnMoTXkHlLXWkyK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2484f096$p0ab66749 p2484f096_p0ab66749) {
        p2484f096_p0ab66749.subscribeNext();
    }

    public void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((28 + 29) % 29 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11(false);
        gINXPjSgiHBielXk(subscriber, pbba58d11Var);
        txnMoTXkHlLXWkyK(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2484f096$p0ab66749(subscriber, this.ff670ef68, pbba58d11Var, this.f36cd38f4));
    }
}

