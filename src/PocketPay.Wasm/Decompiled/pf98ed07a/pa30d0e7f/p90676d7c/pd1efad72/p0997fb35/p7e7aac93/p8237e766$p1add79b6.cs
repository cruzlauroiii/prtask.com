namespace WillowMaze.Wasm.Decompiled;


readonly class p8237e766$p1add79b6<T, U> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2673a475;
    readonly p5a445d71.p18f29add.p32c73be0 f2a2341b9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p4c783800 f6f4412c3;
    readonly p5a445d71.p18f29add.p32c73be0 f728391e2;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeDelayOtherPublisher$OtherSubscriber<T> f795f3202;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p4c783800 f8fb49f69;
    readonly p5a445d71.p18f29add.p32c73be0 f9d7904b6;
    readonly org.reactivestreams.Publisher<U> f9defcb3e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 faf7e68d0;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p4c783800 fd4bcd5d1;
    readonly p5a445d71.p18f29add.p32c73be0 fd8025734;

    p8237e766$p1add79b6(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, org.reactivestreams.Publisher<U> publisher) {
        this.f795f3202 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p4c783800(maybeObserver);
        this.f9defcb3e = publisher;
    }

    public static java.lang.object GMyvrzrRiYJnIxbf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p4c783800 p8237e766_p4c783800) {
        return p8237e766_p4c783800[);
    }

    public static void JPIYostyMEhuNRBy(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void MYGEqxdmxrcFkabl(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void ZOMIJRCvGqOFByUv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p1add79b6 p8237e766_p1add79b6) {
        p8237e766_p1add79b6.subscribeNext();
    }

    public static void DpAuviOssDaIujLU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p1add79b6 p8237e766_p1add79b6) {
        p8237e766_p1add79b6.subscribeNext();
    }

    public static bool HdcIyZvwqhjblIPX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void HnTkqivQPgNVondF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p8237e766$p1add79b6 p8237e766_p1add79b6) {
        p8237e766_p1add79b6.subscribeNext();
    }

    public static void WBDmuMHDWmhXnCDD(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static bool ZgOmZAWsnRoCKuxI(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public override void Dispose() {
        MYGEqxdmxrcFkabl(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        zgOmZAWsnRoCKuxI(this.f795f3202);
    }

    public override bool IsDisposed() {
        return GMyvrzrRiYJnIxbf(this.f795f3202) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public override void OnComplete() {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        ZOMIJRCvGqOFByUv(this);
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        this.f795f3202.fcb5e100e = th;
        hnTkqivQPgNVondF(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (hdcIyZvwqhjblIPX(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            wBDmuMHDWmhXnCDD(this.f795f3202.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        this.f795f3202.f2063c160 = t;
        dpAuviOssDaIujLU(this);
    }

    void subscribeNext() {
        JPIYostyMEhuNRBy(this.f9defcb3e, this.f795f3202);
    }
}

