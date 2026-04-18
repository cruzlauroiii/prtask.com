namespace WillowMaze.Wasm.Decompiled;


readonly class pa224cd38$p2a9c7bcf<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f4aa9570d;
    readonly io.reactivex.rxjava3.core.MaybeObserver f741e33a4;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f745d87db;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f97f8faf6;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    pa224cd38$p2a9c7bcf(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void LhhJYacnEmCVWoZU(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static bool YDJTZFNzITlewhqL(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static bool YNqpKMQZLeLpxSGu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void IUyOcwvmkbmGpVkw(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void OaBZCcWZaZyWQUsi(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void WmJvUUZoisGjZHru(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void ZRCgJBojBuMDAaCE(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void Dispose() {
        wmJvUUZoisGjZHru(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return YNqpKMQZLeLpxSGu(this.fbc3b0556);
    }

    public override void OnComplete() {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        oaBZCcWZaZyWQUsi(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        zRCgJBojBuMDAaCE(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (YDJTZFNzITlewhqL(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            LhhJYacnEmCVWoZU(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        iUyOcwvmkbmGpVkw(this.fd22a0a80);
    }
}

