namespace WillowMaze.Wasm.Decompiled;


public readonly class p5328e997<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long fb323d752 = -8612022020200669122L;
    private static readonly long fc6e1e520 = -8612022020200669122L;
    private static readonly long fc702656a = -8612022020200669122L;
    private static readonly long fd3252894 = -8612022020200669122L;
    readonly java.util.concurrent.atomic.object f01e13272;
    readonly p5a445d71.p18f29add.p992c4a5b f58e8658a;
    readonly p5a445d71.p18f29add.p992c4a5b f6a6d2be8;
    readonly java.util.concurrent.atomic.object fa75a592e;
    readonly p5a445d71.p18f29add.p992c4a5b fb1225a28;
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    readonly p5a445d71.p18f29add.p992c4a5b fbc5d86f8;
    readonly java.util.concurrent.atomic.object fc89e5465;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;

    public p5328e997(org.reactivestreams.Subscriber<T> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static bool AshxaKkJDFQAOeHl(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void CMEIWzycOidmjvvm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool ETopBqHfLfhXWfsC(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void GOPPACFVVdaqNIrG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void YpgkVXUwEsyxTCPj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool BtTmgKyBLMgPvvkS(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void EOLrelNCFFAInLPD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object EYUShIbySJyeGWRn(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool HaMtADafgEBKDIkf(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static bool KAwcWTzAKnSTElbq(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool NHIdysuKgFWWXslN(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var);
    }

    public static void QgAhclrDhJMNKcvn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p5328e997 p5328e997Var) {
        p5328e997Var.dispose();
    }

    public static bool RoXSzUAdrzwjiLpA(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.set(atomicReference, p7beea252Var);
    }

    public static java.lang.object WopGxMeLDUfvEfAe(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void ZfWovBnkLwLOachb(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public override void Cancel() {
        qgAhclrDhJMNKcvn(this);
    }

    public override void Dispose() {
        AshxaKkJDFQAOeHl(this.fbc3b0556);
        btTmgKyBLMgPvvkS(this);
    }

    public override bool IsDisposed() {
        return wopGxMeLDUfvEfAe(this.fbc3b0556) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        kAwcWTzAKnSTElbq(this);
        CMEIWzycOidmjvvm(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        ETopBqHfLfhXWfsC(this);
        eOLrelNCFFAInLPD(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        GOPPACFVVdaqNIrG(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (nHIdysuKgFWWXslN(this.fbc3b0556, p787ad0b7Var)) {
            YpgkVXUwEsyxTCPj(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        if (haMtADafgEBKDIkf(j)) {
            zfWovBnkLwLOachb((p5a445d71.p18f29add.p787ad0b7) eYUShIbySJyeGWRn(this.fbc3b0556), j);
        }
    }

    public void SetResource(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        roXSzUAdrzwjiLpA(this, p7beea252Var);
    }
}

