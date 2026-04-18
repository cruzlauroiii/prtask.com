namespace WillowMaze.Wasm.Decompiled;


readonly class p19082e9b$p3ee7de56<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.MaybeObserver f813788d5;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa7427bbc;
    readonly io.reactivex.rxjava3.core.MaybeObserver fab4fd144;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbec13953;
    readonly io.reactivex.rxjava3.core.MaybeObserver fc2007927;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    p19082e9b$p3ee7de56(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void BPSTmixvFQTXnRhA(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void CgjvmBpfzNTgqxcA(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void EKFxUvqXEdLKZglu(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool AcCVPiLVRjnXctmR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void LQEKaFntPFXbOjmY(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void LzNBlxPshGMNQgDi(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool YjDyrrDeqtQBBRnY(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public override void Dispose() {
        lzNBlxPshGMNQgDi(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return yjDyrrDeqtQBBRnY(this.fbc3b0556);
    }

    public override void OnComplete() {
        lQEKaFntPFXbOjmY(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        CgjvmBpfzNTgqxcA(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (acCVPiLVRjnXctmR(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            BPSTmixvFQTXnRhA(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        EKFxUvqXEdLKZglu(this.fd22a0a80, t);
    }
}

