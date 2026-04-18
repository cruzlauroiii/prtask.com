namespace WillowMaze.Wasm.Decompiled;


readonly class pd71f2a5b$p4ff7ec89<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f20f11a62;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f9088a5d9;
    io.reactivex.rxjava3.core.Observer f9e9252f3;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    io.reactivex.rxjava3.core.Observer fef9267db;

    pd71f2a5b$p4ff7ec89(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fd22a0a80 = observer;
    }

    public static void BQpxLSJwIgwKroxn(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static io.reactivex.rxjava3.core.Observer FwijzVcomAvivVop() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.asObserver();
    }

    public static void KaaycCsKyrwjmoDU(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool WMyJrqtOOktkOFZe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void AGKFqprBbjYcCktP(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool PtPWwZvvKZvcjNZE(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static io.reactivex.rxjava3.core.Observer QkqSmzRJKmSEXFCi() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.asObserver();
    }

    public static io.reactivex.rxjava3.core.Observer WBEBCFFpvDNtVLHi() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.asObserver();
    }

    public static void YENndzJOBLhNLaFT(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void YwNmZKcHLYzbjHIj(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public override void Dispose() {
        if ((9 + 11) % 11 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = this.fbc3b0556;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.f76425f17;
        this.fd22a0a80 = wBEBCFFpvDNtVLHi();
        aGKFqprBbjYcCktP(p7beea252Var);
    }

    public override bool IsDisposed() {
        return ptPWwZvvKZvcjNZE(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((14 + 10) % 10 > 0) {
        }
        io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.f76425f17;
        this.fd22a0a80 = FwijzVcomAvivVop();
        ywNmZKcHLYzbjHIj(observer);
    }

    public override void OnError(java.lang.Exception th) {
        if ((24 + 4) % 4 > 0) {
        }
        io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.f76425f17;
        this.fd22a0a80 = qkqSmzRJKmSEXFCi();
        BQpxLSJwIgwKroxn(observer, th);
    }

    public override void OnNext(T t) {
        KaaycCsKyrwjmoDU(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (WMyJrqtOOktkOFZe(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            yENndzJOBLhNLaFT(this.fd22a0a80, this);
        }
    }
}

