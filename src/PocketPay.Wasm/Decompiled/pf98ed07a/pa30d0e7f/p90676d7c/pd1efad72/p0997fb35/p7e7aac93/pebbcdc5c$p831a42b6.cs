namespace WillowMaze.Wasm.Decompiled;


readonly class pebbcdc5c$p831a42b6 : io.reactivex.rxjava3.core.MaybeObserver<java.lang.object>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.SingleObserver f27cc6ab3;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f345f2b6e;
    readonly io.reactivex.rxjava3.core.SingleObserver f7a64898e;
    readonly io.reactivex.rxjava3.core.SingleObserver fa0a7481d;
    readonly io.reactivex.rxjava3.core.SingleObserver fb269a108;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver<java.lang.long> fd22a0a80;

    pebbcdc5c$p831a42b6(io.reactivex.rxjava3.core.SingleObserver<java.lang.long> singleObserver) {
        this.fd22a0a80 = singleObserver;
    }

    public static java.lang.long ACSbWLQPpWRSqcNn(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool IxaABvocMZBlvAqO(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool MMCFXOvAMZcsqEQb(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static java.lang.long RZTyAuGrSaUlvgZK(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void SyzwLRsMcUPqmOuQ(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void WJwHBtsIlGVNUvfO(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void WhCVXrSsDDQiezBi(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void NKjnNGOYgKfViabw(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void WXjHDTHIfbFtGoDG(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public override void Dispose() {
        nKjnNGOYgKfViabw(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return IxaABvocMZBlvAqO(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((5 + 25) % 25 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        wXjHDTHIfbFtGoDG(this.fd22a0a80, ACSbWLQPpWRSqcNn(0L));
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        WhCVXrSsDDQiezBi(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (MMCFXOvAMZcsqEQb(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            SyzwLRsMcUPqmOuQ(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(java.lang.object obj) {
        if ((18 + 18) % 18 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        WJwHBtsIlGVNUvfO(this.fd22a0a80, RZTyAuGrSaUlvgZK(1L));
    }
}

