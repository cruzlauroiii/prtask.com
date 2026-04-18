namespace WillowMaze.Wasm.Decompiled;


readonly class pbe069a49$p93332f27<T> : io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2eae1e67;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f4d72e234;
    readonly io.reactivex.rxjava3.core.MaybeObserver f53830df3;
    readonly io.reactivex.rxjava3.core.MaybeObserver f9f7056b9;
    readonly io.reactivex.rxjava3.core.MaybeObserver faaa58618;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fad69976d;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.MaybeObserver fd392c60a;

    pbe069a49$p93332f27(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void LUPYSAuQQbMmFUfG(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void VzdXKWFAzmCjTUlz(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void BHmWDYtRpiGuNAoo(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void KWbGjgjGxaWbjSKe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool QDCszEJsARfeIWuk(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static bool WjnaGVZXIrhxYLGm(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public override void Dispose() {
        kWbGjgjGxaWbjSKe(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return wjnaGVZXIrhxYLGm(this.fbc3b0556);
    }

    public override void OnComplete() {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        bHmWDYtRpiGuNAoo(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        VzdXKWFAzmCjTUlz(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (qDCszEJsARfeIWuk(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            LUPYSAuQQbMmFUfG(this.fd22a0a80, this);
        }
    }
}

