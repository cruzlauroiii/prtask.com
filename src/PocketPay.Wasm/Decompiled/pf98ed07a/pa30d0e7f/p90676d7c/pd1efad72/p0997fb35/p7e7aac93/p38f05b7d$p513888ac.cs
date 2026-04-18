namespace WillowMaze.Wasm.Decompiled;


readonly class p38f05b7d$p513888ac<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly T f16830a58;
    readonly java.lang.object f35075cbd;
    readonly java.lang.object f62862ba1;
    readonly java.lang.object fa5d426bc;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fc776ca4f;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly java.lang.object fd9cc98a0;
    readonly io.reactivex.rxjava3.core.SingleObserver fe4750148;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fee54f4a0;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fffc3c3a4;

    p38f05b7d$p513888ac(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, T t) {
        this.fd22a0a80 = singleObserver;
        this.f16830a58 = t;
    }

    public static void DMZkrUqRCEhhOvvH(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void GTemJZBJhEooJITz(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool JZkpHFjUQfyHLlwc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void MnbDTiNTbiHvcpDj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void NuvQuFwvkTKMcCbz(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool TeVyVURxazlFxFIA(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void OwszKijWtDnHdjdX(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void WDiFACSaSxxonHwG(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public override void Dispose() {
        MnbDTiNTbiHvcpDj(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return JZkpHFjUQfyHLlwc(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((19 + 26) % 26 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        T t = this.f16830a58;
        if (t is null) {
            GTemJZBJhEooJITz(this.fd22a0a80, new java.util.NoSuchElementException("The MaybeSource is empty"));
        } else {
            owszKijWtDnHdjdX(this.fd22a0a80, t);
        }
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        DMZkrUqRCEhhOvvH(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (TeVyVURxazlFxFIA(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            NuvQuFwvkTKMcCbz(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        wDiFACSaSxxonHwG(this.fd22a0a80, t);
    }
}

