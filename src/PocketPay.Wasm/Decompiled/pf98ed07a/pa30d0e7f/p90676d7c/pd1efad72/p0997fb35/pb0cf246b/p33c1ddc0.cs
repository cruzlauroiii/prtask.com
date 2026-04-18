namespace WillowMaze.Wasm.Decompiled;


public readonly class p33c1ddc0<T, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f4c923e5e;
    readonly io.reactivex.rxjava3.functions.Supplier<R> f5d7a373a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f8bc6f87d;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fbdc1d413;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fd19e168e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fed38ce4a;

    public p33c1ddc0(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Supplier<R> supplier, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction) {
        super(flowable);
        this.fbdc1d413 = biFunction;
        this.f5d7a373a = supplier;
    }

    public static java.lang.object LvXPkZfaunjMZvxO(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static int NYcaDqwoSMxtayHm() {
        return bufferSize();
    }

    public static void QdShckXwNzxRQISX(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static java.lang.object BTJxdpLnPomLrGrs(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void FAhEXEjSuXBHUSdi(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void VGbHthBEbAUhcyzB(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((21 + 30) % 30 > 0) {
        }
        try {
            QdShckXwNzxRQISX(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p33c1ddc0$pc3254395(subscriber, this.fbdc1d413, LvXPkZfaunjMZvxO(bTJxdpLnPomLrGrs(this.f5d7a373a), "The seed supplied is null"), NYcaDqwoSMxtayHm()));
        } catch (java.lang.Exception th) {
            fAhEXEjSuXBHUSdi(th);
            vGbHthBEbAUhcyzB(th, subscriber);
        }
    }
}

