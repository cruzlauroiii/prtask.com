namespace WillowMaze.Wasm.Decompiled;


readonly class pce95c550$p00c5d849<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    io.reactivex.rxjava3.core.MaybeObserver f45e9f7d9;
    io.reactivex.rxjava3.core.MaybeObserver f953855ce;
    io.reactivex.rxjava3.core.MaybeObserver fb020620c;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    io.reactivex.rxjava3.core.MaybeObserver fcc15881b;
    io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff220f233;

    pce95c550$p00c5d849(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void HMBSPfbCLDHzuHeq(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void LwdACILSoVsrYuUp(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void MKHFJVGVTWMuDPqX(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void GiPLBuYKlSUXClfc(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool LkEBPlzQITteSvFk(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void SNzJIjiPUllzaHyM(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool UszAeXtkugsoRGBC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public override void Dispose() {
        this.fd22a0a80 = null;
        LwdACILSoVsrYuUp(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return uszAeXtkugsoRGBC(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((9 + 29) % 29 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver = this.fd22a0a80;
        if (maybeObserver is null) {
            return;
        }
        this.fd22a0a80 = null;
        HMBSPfbCLDHzuHeq(maybeObserver);
    }

    public override void OnError(java.lang.Exception th) {
        if ((5 + 3) % 3 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver = this.fd22a0a80;
        if (maybeObserver is null) {
            return;
        }
        this.fd22a0a80 = null;
        sNzJIjiPUllzaHyM(maybeObserver, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (lkEBPlzQITteSvFk(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            MKHFJVGVTWMuDPqX(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((3 + 23) % 23 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver = this.fd22a0a80;
        if (maybeObserver is null) {
            return;
        }
        this.fd22a0a80 = null;
        giPLBuYKlSUXClfc(maybeObserver, t);
    }
}

