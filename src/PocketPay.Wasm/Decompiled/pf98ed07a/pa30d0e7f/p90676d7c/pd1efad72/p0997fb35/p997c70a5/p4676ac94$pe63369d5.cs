namespace WillowMaze.Wasm.Decompiled;


readonly class p4676ac94$pe63369d5<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    bool f1f33d70a;
    readonly io.reactivex.rxjava3.core.Observer f276ff260;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f6b21e38d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f9ff7ef11;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fa3f77b54;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fb27cda75;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    bool fbe747de2;
    bool fca13a1c4;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fdaa6707c;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fe2599aee;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    p4676ac94$pe63369d5(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.fd22a0a80 = observer;
        this.ff670ef68 = predicate;
    }

    public static void BiGFXTkwwlBtAFDE(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void HhNjsQRvUESxfBdo(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool KlZRwATzjbdnmPwu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void QRPjKjZszowOqhUg(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void SvYGhXwtkzBDIDcJ(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void YZbozUewQhrdPGNY(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void AyaCibrFkOEgliMJ(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool INReGBJwZbqJLZSB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void IpISAozBVZasQCmc(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool PhBCEvConsoleFaXoKcK(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void QQjTcEgbvUSgMEbX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void RTWkiEpwRgYgybuy(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public override void Dispose() {
        qQjTcEgbvUSgMEbX(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return iNReGBJwZbqJLZSB(this.fbc3b0556);
    }

    public override void OnComplete() {
        HhNjsQRvUESxfBdo(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        ipISAozBVZasQCmc(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if (this.fbe747de2) {
            QRPjKjZszowOqhUg(this.fd22a0a80, t);
            return;
        }
        try {
            if (phBCEvConsoleFaXoKcK(this.ff670ef68, t)) {
                return;
            }
            this.fbe747de2 = true;
            ayaCibrFkOEgliMJ(this.fd22a0a80, t);
        } catch (java.lang.Exception th) {
            BiGFXTkwwlBtAFDE(th);
            rTWkiEpwRgYgybuy(this.fbc3b0556);
            SvYGhXwtkzBDIDcJ(this.fd22a0a80, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (KlZRwATzjbdnmPwu(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            YZbozUewQhrdPGNY(this.fd22a0a80, this);
        }
    }
}

