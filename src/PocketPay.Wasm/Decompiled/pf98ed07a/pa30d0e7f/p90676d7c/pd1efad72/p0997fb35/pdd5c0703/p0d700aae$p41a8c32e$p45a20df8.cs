namespace WillowMaze.Wasm.Decompiled;


readonly class p0d700aae$p41a8c32e$p45a20df8<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private static readonly long f875747fb = 2071387740092105509L;
    private static readonly long f8aea03f2 = 2071387740092105509L;
    private static readonly long fc6e1e520 = 2071387740092105509L;
    private static readonly long fc8e83547 = 2071387740092105509L;
    private static readonly long fea9cd079 = 2071387740092105509L;
    readonly io.reactivex.rxjava3.core.SingleObserver f12fca22e;
    readonly io.reactivex.rxjava3.core.SingleObserver f8432ddec;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;

    p0d700aae$p41a8c32e$p45a20df8(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        this.fd22a0a80 = singleObserver;
    }

    public static bool NYSRhXEuDxMnAhky(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void DMyjajgibjTpplRA(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void IVUrIVBSiITxlaER(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public override void OnError(java.lang.Exception th) {
        dMyjajgibjTpplRA(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        NYSRhXEuDxMnAhky(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        iVUrIVBSiITxlaER(this.fd22a0a80, t);
    }
}

