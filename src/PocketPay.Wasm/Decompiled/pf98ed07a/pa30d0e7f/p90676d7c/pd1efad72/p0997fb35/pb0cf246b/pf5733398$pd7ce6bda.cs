namespace WillowMaze.Wasm.Decompiled;


readonly class pf5733398$pd7ce6bda<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.MaybeObserver f370e9266;
    java.lang.object f3b0cb3ec;
    T f447b7147;
    readonly io.reactivex.rxjava3.core.MaybeObserver f4d54b00a;
    java.lang.object f576eefff;
    readonly io.reactivex.rxjava3.core.MaybeObserver f90803e15;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.MaybeObserver fd2ab2166;
    java.lang.object ff6a405a5;
    p5a445d71.p18f29add.p787ad0b7 ff6a632ce;

    pf5733398$pd7ce6bda(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void AbFFPYGqxAijiqXB(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void LEOOpYJaMxbgLCNZ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void SuVdXKQyWmuuKuLz(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void FAVrxrBhTkUrXqLN(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void LmjdTdiKIesPXFHT(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void TNzqIeipBFRcFmha(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static bool UyMyFfIvKHBOUtAb(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public override void Dispose() {
        AbFFPYGqxAijiqXB(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        if ((1 + 21) % 21 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        T t = this.f447b7147;
        if (t is null) {
            tNzqIeipBFRcFmha(this.fd22a0a80);
        } else {
            this.f447b7147 = null;
            LEOOpYJaMxbgLCNZ(this.fd22a0a80, t);
        }
    }

    public void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        this.f447b7147 = null;
        lmjdTdiKIesPXFHT(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        this.f447b7147 = t;
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((26 + 23) % 23 > 0) {
        }
        if (uyMyFfIvKHBOUtAb(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            SuVdXKQyWmuuKuLz(this.fd22a0a80, this);
            fAVrxrBhTkUrXqLN(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

