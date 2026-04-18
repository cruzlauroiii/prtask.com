namespace WillowMaze.Wasm.Decompiled;


public readonly class p8419f2ad<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly long f56e95ea8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f87ac5902;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fca9a8dc1;
    readonly long fd884e3e9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fd9ad5f87;
    readonly long fe2942a04;
    readonly io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> ff670ef68;
    readonly long ffe40e1ac;

    public p8419f2ad(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> predicate) {
        super(flowable);
        this.ff670ef68 = predicate;
        this.fe2942a04 = j;
    }

    public static void MTkfKQFRVKzaVNIc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void RGwmQdifCeWkRjXd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8419f2ad$pf649f678 p8419f2ad_pf649f678) {
        p8419f2ad_pf649f678.subscribeNext();
    }

    public void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((22 + 30) % 30 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11(false);
        MTkfKQFRVKzaVNIc(subscriber, pbba58d11Var);
        rGwmQdifCeWkRjXd(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8419f2ad$pf649f678(subscriber, this.fe2942a04, this.ff670ef68, pbba58d11Var, this.f36cd38f4));
    }
}

