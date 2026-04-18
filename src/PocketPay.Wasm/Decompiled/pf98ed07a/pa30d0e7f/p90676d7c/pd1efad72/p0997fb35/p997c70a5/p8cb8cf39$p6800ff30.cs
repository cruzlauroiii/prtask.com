namespace WillowMaze.Wasm.Decompiled;


readonly class p8cb8cf39$p6800ff30<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    java.lang.object f03b04384;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f0cccf5aa;
    T f447b7147;
    readonly java.lang.object f4b891625;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f6c3f71ad;
    readonly T f8fe94b37;
    readonly io.reactivex.rxjava3.core.SingleObserver f93b326c6;
    java.lang.object f997de881;
    java.lang.object fa1195f59;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    java.lang.object fd0cf5312;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;

    p8cb8cf39$p6800ff30(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, T t) {
        this.fd22a0a80 = singleObserver;
        this.f8fe94b37 = t;
    }

    public static void JpjEhrZdswQpFwdq(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void XwwrlXNExsroqBdE(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void AlFpyndqzbXKVNsr(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void MolNaBSXEoRTDeQy(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool OauiCRZBsJwPpLTZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void QQRrzMllOUPCIMNv(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void RIyZIJYkNpRNJwpx(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void Dispose() {
        qQRrzMllOUPCIMNv(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override void OnComplete() {
        if ((19 + 13) % 13 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        T t = this.f447b7147;
        if (t is not null) {
            this.f447b7147 = null;
            XwwrlXNExsroqBdE(this.fd22a0a80, t);
            return;
        }
        T t2 = this.f8fe94b37;
        if (t2 is null) {
            alFpyndqzbXKVNsr(this.fd22a0a80, new java.util.NoSuchElementException());
        } else {
            molNaBSXEoRTDeQy(this.fd22a0a80, t2);
        }
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        this.f447b7147 = null;
        rIyZIJYkNpRNJwpx(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        this.f447b7147 = t;
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (oauiCRZBsJwPpLTZ(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            JpjEhrZdswQpFwdq(this.fd22a0a80, this);
        }
    }
}

