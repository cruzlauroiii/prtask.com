namespace WillowMaze.Wasm.Decompiled;


readonly class pae6bafbb$p1add79b6<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long f2a84c7b7 = 706635022205076709L;
    private static readonly long fc6e1e520 = 706635022205076709L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f1b35635f;
    readonly io.reactivex.rxjava3.core.MaybeObserver fc6d77a27;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;

    pae6bafbb$p1add79b6(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void CrfdAURqsbeAppsq(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void HEqvPDCVMYDRFBeu(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool NTfhRlpeKELQdAjt(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void ZbOvbsPzIOGVgyxm(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void OnComplete() {
        crfdAURqsbeAppsq(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        zbOvbsPzIOGVgyxm(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        nTfhRlpeKELQdAjt(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        hEqvPDCVMYDRFBeu(this.fd22a0a80, t);
    }
}

