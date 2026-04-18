namespace WillowMaze.Wasm.Decompiled;


readonly class p93865d37$p81101967<R, U> : io.reactivex.rxjava3.core.Flowable<R> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f0460b081;
    private readonly io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Flowable<U>, ? : org.reactivestreams.Publisher<R>> f5b3c3200;
    private readonly io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.flowables.ConnectableFlowable<U>> f682fb0b1;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f8f09a328;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fa1a6bd1c;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 faf37be6e;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fde056f7a;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe0c535e2;

    p93865d37$p81101967(io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.flowables.ConnectableFlowable<U>> supplier, io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.core.Flowable<U>, ? : org.reactivestreams.Publisher<R>> function) {
        this.f682fb0b1 = supplier;
        this.f5b3c3200 = function;
    }

    public static void HVuADAOTloJgEGEY(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object KguruhneVXzRcLyF(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static java.lang.object QmTruhrPKkaLdHOn(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static java.lang.object RmjxrvWfqHrSsMmu(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void WFZaBnCmMBALDVBX(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void XWzowuiDyiUjlWpN(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void ZZfrMWJeQIlHwfDe(pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 p648c37d3Var, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var) {
        p648c37d3Var.connect(pf8afcf86Var);
    }

    public static void DHzOqfavYvepqLYK(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static java.lang.object OWlZKagCNxFhYErb(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void SkwFqmubRNzCXVPO(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((18 + 24) % 24 > 0) {
        }
        try {
            pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 p648c37d3Var = (pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3) RmjxrvWfqHrSsMmu(QmTruhrPKkaLdHOn(this.f682fb0b1), "The connectableFactory returned a null ConnectableFlowable.");
            try {
                p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) KguruhneVXzRcLyF(oWlZKagCNxFhYErb(this.f5b3c3200, p648c37d3Var), "The selector returned a null Publisher.");
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p5328e997 p5328e997Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p5328e997(subscriber);
                dHzOqfavYvepqLYK(p32c73be0Var, p5328e997Var);
                ZZfrMWJeQIlHwfDe(p648c37d3Var, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p81101967$p158c9725(this, p5328e997Var));
            } catch (java.lang.Exception th) {
                HVuADAOTloJgEGEY(th);
                skwFqmubRNzCXVPO(th, subscriber);
            }
        } catch (java.lang.Exception th2) {
            WFZaBnCmMBALDVBX(th2);
            XWzowuiDyiUjlWpN(th2, subscriber);
        }
    }
}

