namespace WillowMaze.Wasm.Decompiled;


readonly class p42f12488$pd32950e0<T> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.MaybeObserver f20961fae;
    readonly io.reactivex.rxjava3.core.MaybeObserver f5fd3edac;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f7db91ee5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f802fe840;
    readonly io.reactivex.rxjava3.core.MaybeObserver f86763492;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f89caa7a0;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fd5d571bb;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fe23cef56;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fe8e20c38;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff40071bb;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    p42f12488$pd32950e0(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.fd22a0a80 = maybeObserver;
        this.ff670ef68 = predicate;
    }

    public static void IeLNmuxKFyiXZTLl(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void MzwioNOtOkCPXZKJ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void PcDUVFvpKwZMyqBy(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void QlGgaOtxpmYqOUsi(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static bool SEMfqCETKVrbilhc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool ICaWJTwZJDdKKCIn(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static bool JqWDNeSBGiiAjHqe(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void KyiJpPrSiHyfKeVV(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void MhgkuHinFIziFHTc(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void TvTTjCORJzKUFnbs(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void Dispose() {
        if ((22 + 19) % 19 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = this.fbc3b0556;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        PcDUVFvpKwZMyqBy(p7beea252Var);
    }

    public override bool IsDisposed() {
        return SEMfqCETKVrbilhc(this.fbc3b0556);
    }

    public override void OnError(java.lang.Exception th) {
        tvTTjCORJzKUFnbs(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (iCaWJTwZJDdKKCIn(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            QlGgaOtxpmYqOUsi(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        try {
            if (jqWDNeSBGiiAjHqe(this.ff670ef68, t)) {
                mhgkuHinFIziFHTc(this.fd22a0a80, t);
            } else {
                kyiJpPrSiHyfKeVV(this.fd22a0a80);
            }
        } catch (java.lang.Exception th) {
            IeLNmuxKFyiXZTLl(th);
            MzwioNOtOkCPXZKJ(this.fd22a0a80, th);
        }
    }
}

