namespace WillowMaze.Wasm.Decompiled;


readonly class pdd6ba593$p2a9c7bcf<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.CompletableObserver f1e7b6898;
    readonly io.reactivex.rxjava3.core.CompletableObserver f7bcdf3a7;
    readonly io.reactivex.rxjava3.core.CompletableObserver fba4f919b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.CompletableObserver fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdab86265;
    readonly io.reactivex.rxjava3.core.CompletableObserver ff6449637;

    pdd6ba593$p2a9c7bcf(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        this.fd22a0a80 = completableObserver;
    }

    public static void BGaFCVziaPviLlRG(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableObserver.onComplete();
    }

    public static bool DSybMEAQkYGsMWGD(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void KgHmNROrPeaivkok(io.reactivex.rxjava3.core.CompletableObserver completableObserver, java.lang.Exception th) {
        completableObserver.onError(th);
    }

    public static bool NuaRjmxNwpOLRntJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void FossUUhrJSUfNFSG(io.reactivex.rxjava3.core.CompletableObserver completableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        completableObserver.onSubscribe(p7beea252Var);
    }

    public static void MbIXuGHhRsSIOkVo(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableObserver.onComplete();
    }

    public static void YAXxkjKoaAdJISNd(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public override void Dispose() {
        yAXxkjKoaAdJISNd(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return DSybMEAQkYGsMWGD(this.fbc3b0556);
    }

    public override void OnComplete() {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        mbIXuGHhRsSIOkVo(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        KgHmNROrPeaivkok(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (NuaRjmxNwpOLRntJ(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            fossUUhrJSUfNFSG(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        BGaFCVziaPviLlRG(this.fd22a0a80);
    }
}

