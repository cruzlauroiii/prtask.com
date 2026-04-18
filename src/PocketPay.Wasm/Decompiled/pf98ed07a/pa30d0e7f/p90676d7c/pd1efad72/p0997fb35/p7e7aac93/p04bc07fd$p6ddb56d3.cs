namespace WillowMaze.Wasm.Decompiled;


readonly class p04bc07fd$p6ddb56d3<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f353e7013;
    readonly io.reactivex.rxjava3.core.MaybeObserver f82f638b6;
    readonly io.reactivex.rxjava3.functions.BiConsumer<T, java.lang.Exception> fab428135;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.MaybeObserver fe904391f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 fec332395;

    p04bc07fd$p6ddb56d3(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.functions.BiConsumer<T, java.lang.Exception> biConsumer) {
        this.fd22a0a80 = maybeObserver;
        this.fab428135 = biConsumer;
    }

    public static void FBasDpJHeQEcuSwh(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 pe2a87954Var, java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        pe2a87954Var.accept(obj, obj2);
    }

    public static void FJMNNZvFQHBntwvc(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void HkBWjNVDnwcevNNM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void KcIunCFbengMblqP(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 pe2a87954Var, java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        pe2a87954Var.accept(obj, obj2);
    }

    public static void NbAldgMdzzCjLisI(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 pe2a87954Var, java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        pe2a87954Var.accept(obj, obj2);
    }

    public static bool TxExIxicLVxNlGlJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void VsPjnSCpoAiJKyCd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void BfBdTMeaVjXrMdVo(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void IzAtBgRCWqmsAXNN(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void LzrjqFFWUQoSjJFt(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void MgTdtNhxOOaSmbfo(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static bool OYyofCKuZamrVjhH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void QNwDtoJlaajdjkuR(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void XmtxBPfrhtPSAJPZ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void ZjMmlHUSPwLZOeYA(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public override void Dispose() {
        HkBWjNVDnwcevNNM(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return oYyofCKuZamrVjhH(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((23 + 20) % 20 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        try {
            NbAldgMdzzCjLisI(this.fab428135, null, null);
            mgTdtNhxOOaSmbfo(this.fd22a0a80);
        } catch (java.lang.Exception th) {
            xmtxBPfrhtPSAJPZ(th);
            FJMNNZvFQHBntwvc(this.fd22a0a80, th);
        }
    }

    public override void OnError(java.lang.Exception th) {
        if ((4 + 21) % 21 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        try {
            FBasDpJHeQEcuSwh(this.fab428135, null, th);
        } catch (java.lang.Exception th2) {
            VsPjnSCpoAiJKyCd(th2);
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            th = new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr);
        }
        bfBdTMeaVjXrMdVo(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (TxExIxicLVxNlGlJ(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            zjMmlHUSPwLZOeYA(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((24 + 10) % 10 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        try {
            KcIunCFbengMblqP(this.fab428135, t, null);
            qNwDtoJlaajdjkuR(this.fd22a0a80, t);
        } catch (java.lang.Exception th) {
            lzrjqFFWUQoSjJFt(th);
            izAtBgRCWqmsAXNN(this.fd22a0a80, th);
        }
    }
}

