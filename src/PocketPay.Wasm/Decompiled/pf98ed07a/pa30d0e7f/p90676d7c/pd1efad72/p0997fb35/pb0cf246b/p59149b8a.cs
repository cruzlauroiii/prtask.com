namespace WillowMaze.Wasm.Decompiled;


public readonly class p59149b8a<T, U> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly p5a445d71.p18f29add.p32c73be0 f60019708;
    readonly p5a445d71.p18f29add.p32c73be0 f6f6828a7;
    readonly org.reactivestreams.Publisher<U> f795f3202;
    readonly p5a445d71.p18f29add.p32c73be0 fc890ea8d;

    public p59149b8a(io.reactivex.rxjava3.core.Flowable<T> flowable, org.reactivestreams.Publisher<U> publisher) {
        super(flowable);
        this.f795f3202 = publisher;
    }

    public static void CGlwPNNXOWpXVNjW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void GsLymWgmwfwnJuRw(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void HPHoVdwLNXsDimet(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((16 + 11) % 11 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59149b8a$p97a9b393 p59149b8a_p97a9b393 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59149b8a$p97a9b393(subscriber);
        cGlwPNNXOWpXVNjW(subscriber, p59149b8a_p97a9b393);
        gsLymWgmwfwnJuRw(this.f795f3202, p59149b8a_p97a9b393.f795f3202);
        hPHoVdwLNXsDimet(this.f36cd38f4, p59149b8a_p97a9b393);
    }
}

