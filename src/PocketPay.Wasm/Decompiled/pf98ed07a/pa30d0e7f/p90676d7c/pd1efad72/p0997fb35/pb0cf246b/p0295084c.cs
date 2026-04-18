namespace WillowMaze.Wasm.Decompiled;


public readonly class p0295084c<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly long f360e13ce;
    readonly long fe2942a04;

    public p0295084c(io.reactivex.rxjava3.core.Flowable<T> flowable, long j) {
        super(flowable);
        this.fe2942a04 = j;
    }

    public static void RzQaVVlTDEZEWpvw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0295084c$pa273c45b p0295084c_pa273c45b) {
        p0295084c_pa273c45b.subscribeNext();
    }

    public static void AnqzUslIrdNerrfq(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((4 + 31) % 31 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11(false);
        anqzUslIrdNerrfq(subscriber, pbba58d11Var);
        long j = this.fe2942a04;
        RzQaVVlTDEZEWpvw(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0295084c$pa273c45b(subscriber, j != long.MAX_VALUE ? j - 1 : long.MAX_VALUE, pbba58d11Var, this.f36cd38f4));
    }
}

