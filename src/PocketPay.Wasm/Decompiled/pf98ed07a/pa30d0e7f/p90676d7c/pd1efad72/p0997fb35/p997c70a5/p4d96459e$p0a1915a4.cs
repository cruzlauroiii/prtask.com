namespace WillowMaze.Wasm.Decompiled;


readonly class p4d96459e$p0a1915a4<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    java.util.ICollection f01c21fc3;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f125e9160;
    readonly io.reactivex.rxjava3.core.Observer f63409583;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa8a41af9;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer fc5eb892a;
    readonly io.reactivex.rxjava3.core.Observer<U> fd22a0a80;
    U fdb6d9b45;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fe989ccd3;
    readonly io.reactivex.rxjava3.core.Observer ffa173703;

    p4d96459e$p0a1915a4(io.reactivex.rxjava3.core.Observer<U> observer, U u) {
        this.fd22a0a80 = observer;
        this.fdb6d9b45 = u;
    }

    public static bool AdYBYatUAYYjdCak(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void GrsqcdnyETxkOmek(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool IZFwNScTgKSbEoqr(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool BUMaTjrrOffgqqAN(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void FtbhuXEicVERShfL(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void KelaLLzhELlFoNxz(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void USOiaFZnCvbpumXc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void WBgAxeCCFCnZrhyt(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public override void Dispose() {
        uSOiaFZnCvbpumXc(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return bUMaTjrrOffgqqAN(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((22 + 18) % 18 > 0) {
        }
        U u = this.fdb6d9b45;
        this.fdb6d9b45 = null;
        wBgAxeCCFCnZrhyt(this.fd22a0a80, u);
        GrsqcdnyETxkOmek(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        this.fdb6d9b45 = null;
        ftbhuXEicVERShfL(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        IZFwNScTgKSbEoqr(this.fdb6d9b45, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (AdYBYatUAYYjdCak(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            kelaLLzhELlFoNxz(this.fd22a0a80, this);
        }
    }
}

