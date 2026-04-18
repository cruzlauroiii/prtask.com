namespace WillowMaze.Wasm.Decompiled;


readonly class p1113988b$p115d16e0<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.Observer f23a83381;
    readonly io.reactivex.rxjava3.core.Observer f59057229;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f6991b0cf;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f7152cd00;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f88a09096;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;

    p1113988b$p115d16e0(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fd22a0a80 = observer;
    }

    public static void AXpByPrAoaXvMYyN(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void DneHBMgSfMFebcNN(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void VvrlLQUFwkHbhNFZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void HbxGTFIhTPbqOJhj(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void HnWHKmATEPKVrgsi(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool HuZxJRlMPhjcghFM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static bool TgeFgBjyWJxVarZu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public override void Dispose() {
        VvrlLQUFwkHbhNFZ(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return tgeFgBjyWJxVarZu(this.fbc3b0556);
    }

    public override void OnComplete() {
        AXpByPrAoaXvMYyN(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        hbxGTFIhTPbqOJhj(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        DneHBMgSfMFebcNN(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (huZxJRlMPhjcghFM(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            hnWHKmATEPKVrgsi(this.fd22a0a80, this);
        }
    }
}

