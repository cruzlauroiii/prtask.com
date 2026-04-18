namespace WillowMaze.Wasm.Decompiled;


readonly class pd8863bd2$pd32950e0<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f15233f44;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f15c1f835;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2c27631d;
    readonly io.reactivex.rxjava3.core.MaybeObserver f42b43e66;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f4c9e9953;
    readonly io.reactivex.rxjava3.core.MaybeObserver f54657f4b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f84816bae;
    readonly io.reactivex.rxjava3.core.MaybeObserver f87c7949d;
    readonly io.reactivex.rxjava3.core.MaybeObserver f919520e7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fa16133c2;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fc963d312;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    pd8863bd2$pd32950e0(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.fd22a0a80 = maybeObserver;
        this.ff670ef68 = predicate;
    }

    public static void BOHlQqQsRpzGkfbE(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void LZuQGMqWQSPUCFxn(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static bool SspoixPBKkpDwuTm(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void DGmQxyNnGCYeSGQx(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void HNidPCSlSFTumicM(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void LAoarzaTXDNtvHCc(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void QZmewMUrFGOZGOeo(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool RaIuFADgcorVQTlB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void VNKtuDCFjclRrQXS(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void VNslBBCAKEIEohAh(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool WfcpQFedLmnvjTAp(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public override void Dispose() {
        if ((5 + 23) % 23 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = this.fbc3b0556;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        vNKtuDCFjclRrQXS(p7beea252Var);
    }

    public override bool IsDisposed() {
        return SspoixPBKkpDwuTm(this.fbc3b0556);
    }

    public override void OnComplete() {
        LZuQGMqWQSPUCFxn(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        BOHlQqQsRpzGkfbE(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (raIuFADgcorVQTlB(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            hNidPCSlSFTumicM(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        try {
            if (wfcpQFedLmnvjTAp(this.ff670ef68, t)) {
                dGmQxyNnGCYeSGQx(this.fd22a0a80, t);
            } else {
                lAoarzaTXDNtvHCc(this.fd22a0a80);
            }
        } catch (java.lang.Exception th) {
            vNslBBCAKEIEohAh(th);
            qZmewMUrFGOZGOeo(this.fd22a0a80, th);
        }
    }
}

