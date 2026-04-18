namespace WillowMaze.Wasm.Decompiled;


readonly class p045acb5a$pca9f6704<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<R>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fb1fb994f = 854110278590336484L;
    private static readonly long fb27be0f1 = 854110278590336484L;
    private static readonly long fc6e1e520 = 854110278590336484L;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f288374cd;
    readonly io.reactivex.rxjava3.core.Observer f3f03c802;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f492e097a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f9e8fca76;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;

    p045acb5a$pca9f6704(io.reactivex.rxjava3.core.Observer<R> observer) {
        this.fd22a0a80 = observer;
    }

    public static bool AApVeiSHvpytTlDg(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void GaznHbCdsStFMKIa(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool LuNyPoECikgZutKK(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void MmnODFuyLSgMJvYz(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool OstQYQvtdMBOJOXW(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool BKtwPCBNLeiySpMK(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void BNLEnFFvYbRBiCRk(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool KnxfAHLUgBCHYIbc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void QbDoTHGRuFTmrrIT(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void ZbBKZwSyuomnAsxN(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public override void Dispose() {
        zbBKZwSyuomnAsxN(this.fbc3b0556);
        bKtwPCBNLeiySpMK(this);
    }

    public override bool IsDisposed() {
        return AApVeiSHvpytTlDg(this.fbc3b0556);
    }

    public override void OnComplete() {
        LuNyPoECikgZutKK(this);
        MmnODFuyLSgMJvYz(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        OstQYQvtdMBOJOXW(this);
        GaznHbCdsStFMKIa(this.fd22a0a80, th);
    }

    public override void OnNext(R r) {
        bNLEnFFvYbRBiCRk(this.fd22a0a80, r);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (knxfAHLUgBCHYIbc(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            qbDoTHGRuFTmrrIT(this.fd22a0a80, this);
        }
    }
}

