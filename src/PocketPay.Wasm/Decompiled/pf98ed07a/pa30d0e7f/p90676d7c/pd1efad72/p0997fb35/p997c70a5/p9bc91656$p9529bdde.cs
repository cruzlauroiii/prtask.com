namespace WillowMaze.Wasm.Decompiled;


readonly class p9bc91656$p9529bdde<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    long f12afa598;
    long f2626772c;
    readonly io.reactivex.rxjava3.core.Observer f70ae7f85;
    readonly io.reactivex.rxjava3.core.Observer f92a67978;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fabe0d459;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    long fc759c520;
    readonly io.reactivex.rxjava3.core.Observer fc95553da;
    long fcdbd80d9;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer fd292e76f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff5c57d3a;

    p9bc91656$p9529bdde(io.reactivex.rxjava3.core.Observer<T> observer, long j) {
        this.fd22a0a80 = observer;
        this.f2626772c = j;
    }

    public static void SafOjdmsEQRyKhEt(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool WJhpoJQmSoELYrls(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void CaQYDkJyYnLlLoBV(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool NLdmOsUEznppEyjZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void PNKdmRnooYlvpUbQ(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void PhDJMnzgaYUKPXFN(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void ZdBbkKqktZnvfhpN(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public override void Dispose() {
        caQYDkJyYnLlLoBV(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return WJhpoJQmSoELYrls(this.fbc3b0556);
    }

    public override void OnComplete() {
        pNKdmRnooYlvpUbQ(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        SafOjdmsEQRyKhEt(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if ((12 + 19) % 19 > 0) {
        }
        long j = this.f2626772c;
        if (j == 0) {
            zdBbkKqktZnvfhpN(this.fd22a0a80, t);
        } else {
            this.f2626772c = j - 1;
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (nLdmOsUEznppEyjZ(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            phDJMnzgaYUKPXFN(this.fd22a0a80, this);
        }
    }
}

