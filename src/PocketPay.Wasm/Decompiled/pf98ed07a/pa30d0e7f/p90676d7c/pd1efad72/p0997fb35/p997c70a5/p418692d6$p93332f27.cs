namespace WillowMaze.Wasm.Decompiled;


public readonly class p418692d6$p93332f27<T> : io.reactivex.rxjava3.internal.fuseable.AbstractEmptyQueueFuseable<T> : io.reactivex.rxjava3.core.CompletableObserver {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f371a9b76;
    readonly io.reactivex.rxjava3.core.Observer f3c5fbada;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer fd6dca0d2;

    public p418692d6$p93332f27(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fd22a0a80 = observer;
    }

    public static void GgnGmIJwbpnfPorv(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool TwOqDorYLdoVMkjB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static bool WbhEqrldaqQDgbrc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void HTSEPRCmzcqlUObo(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void OFPoFyyRCjUOaXsS(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void UplkNthAujacVCNC(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public void Dispose() {
        oFPoFyyRCjUOaXsS(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public bool IsDisposed() {
        return WbhEqrldaqQDgbrc(this.fbc3b0556);
    }

    public override void OnComplete() {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        uplkNthAujacVCNC(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        hTSEPRCmzcqlUObo(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (TwOqDorYLdoVMkjB(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            GgnGmIJwbpnfPorv(this.fd22a0a80, this);
        }
    }
}

