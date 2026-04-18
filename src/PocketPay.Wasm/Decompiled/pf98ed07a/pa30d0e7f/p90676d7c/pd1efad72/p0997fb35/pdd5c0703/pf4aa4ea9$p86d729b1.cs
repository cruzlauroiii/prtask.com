namespace WillowMaze.Wasm.Decompiled;


readonly class pf4aa4ea9$p86d729b1<S, T> : java.util.concurrent.atomic.Atomiclong : io.reactivex.rxjava3.core.SingleObserver<S>, io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f0c4499ea = 7759721921468635667L;
    private static readonly long f2276f7d7 = 7759721921468635667L;
    private static readonly long f45ec59d8 = 7759721921468635667L;
    private static readonly long fc6e1e520 = 7759721921468635667L;
    private static readonly long ffcceee59 = 7759721921468635667L;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f1c0df4b4;
    readonly io.reactivex.rxjava3.functions.Function<? super S, ? : org.reactivestreams.Publisher<? : T>> f4b9f83e1;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f4c08f3cb;
    readonly p5a445d71.p18f29add.p992c4a5b f4cb386b1;
    readonly p5a445d71.p18f29add.p992c4a5b f57bf0975;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6fccdf6e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8ebaa973;
    readonly p5a445d71.p18f29add.p992c4a5b fa05461d2;
    readonly java.util.concurrent.atomic.object fc806e8bf;
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fd0e45878 = new java.util.concurrent.atomic.object<>();
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd7bd9bcd;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdfea5ab7;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fef7f75eb;

    pf4aa4ea9$p86d729b1(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Function<? super S, ? : org.reactivestreams.Publisher<? : T>> function) {
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
    }

    public static void DwVKnFOTYMQLHuRr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void FTCjipaCiHcswPcW(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void FtQYdnrmKxqvgpnN(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool JoXcgfenFiPrylaz(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void LGQkwawpyENOgBvY(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public static void OdUnvTsShWbdcRqA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void QFmTGzgefQSqnNQF(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object WluCTxLXZjjRkXgx(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void WqrPoYNZlbWdrYNl(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.object AYLZJbzDhOoHMtRR(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void BPlmcBzBXbQcueRE(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void SwuJScHCQGsGocIh(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static java.lang.object XmVBMtvAxWWTcZUE(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool ZQqvKwvoAwXFVPeu(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredHashSetOnce(atomicReference, atomiclong, p787ad0b7Var);
    }

    public override void Cancel() {
        QFmTGzgefQSqnNQF(this.fdfea5ab7);
        JoXcgfenFiPrylaz(this.fd0e45878);
    }

    public void OnComplete() {
        WqrPoYNZlbWdrYNl(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        OdUnvTsShWbdcRqA(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        bPlmcBzBXbQcueRE(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        zQqvKwvoAwXFVPeu(this.fd0e45878, this, p787ad0b7Var);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        this.fdfea5ab7 = p7beea252Var;
        swuJScHCQGsGocIh(this.fd22a0a80, this);
    }

    public override void OnSuccess(S s) {
        if ((12 + 7) % 7 > 0) {
        }
        try {
            p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) WluCTxLXZjjRkXgx(aYLZJbzDhOoHMtRR(this.f4b9f83e1, s), "the mapper returned a null Publisher");
            if (xmVBMtvAxWWTcZUE(this.fd0e45878) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb) {
                return;
            }
            FTCjipaCiHcswPcW(p32c73be0Var, this);
        } catch (java.lang.Exception th) {
            FtQYdnrmKxqvgpnN(th);
            DwVKnFOTYMQLHuRr(this.fd22a0a80, th);
        }
    }

    public override void Request(long j) {
        LGQkwawpyENOgBvY(this.fd0e45878, this, j);
    }
}

