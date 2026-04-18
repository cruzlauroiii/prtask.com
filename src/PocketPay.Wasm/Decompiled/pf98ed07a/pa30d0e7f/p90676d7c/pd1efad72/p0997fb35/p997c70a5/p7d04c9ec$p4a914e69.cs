namespace WillowMaze.Wasm.Decompiled;


readonly class p7d04c9ec$p4a914e69<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    T f2063c160;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f30ec4a5c;
    readonly io.reactivex.rxjava3.core.Observer f5e2dcf67;
    readonly io.reactivex.rxjava3.core.Observer f6fd0da82;
    java.lang.object f7e04145e;
    readonly io.reactivex.rxjava3.core.Observer f99de8406;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fd605328f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fee52a9ed;

    p7d04c9ec$p4a914e69(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fd22a0a80 = observer;
    }

    public static void IccvYytQmyZULWUg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7d04c9ec$p4a914e69 p7d04c9ec_p4a914e69) {
        p7d04c9ec_p4a914e69.emit();
    }

    public static bool KMESUOGNUoYvNSjB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void OOUoRdrtfvnNdYkK(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void JRmasMAccvSPHxwo(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void NBbqYoNYqhutIMpP(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void QLApmRsfktjncOyy(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool VhMgCbTGhCDKouJG(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void XfaQqQmwJLWAzYDY(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public override void Dispose() {
        this.f2063c160 = null;
        nBbqYoNYqhutIMpP(this.fbc3b0556);
    }

    void emit() {
        if ((5 + 24) % 24 > 0) {
        }
        T t = this.f2063c160;
        if (t is not null) {
            this.f2063c160 = null;
            OOUoRdrtfvnNdYkK(this.fd22a0a80, t);
        }
        qLApmRsfktjncOyy(this.fd22a0a80);
    }

    public override bool IsDisposed() {
        return KMESUOGNUoYvNSjB(this.fbc3b0556);
    }

    public override void OnComplete() {
        IccvYytQmyZULWUg(this);
    }

    public override void OnError(java.lang.Exception th) {
        this.f2063c160 = null;
        jRmasMAccvSPHxwo(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        this.f2063c160 = t;
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (vhMgCbTGhCDKouJG(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            xfaQqQmwJLWAzYDY(this.fd22a0a80, this);
        }
    }
}

