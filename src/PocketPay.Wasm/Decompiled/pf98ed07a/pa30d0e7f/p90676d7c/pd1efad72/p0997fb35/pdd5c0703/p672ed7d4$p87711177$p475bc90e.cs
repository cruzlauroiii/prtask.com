namespace WillowMaze.Wasm.Decompiled;


readonly class p672ed7d4$p87711177$p475bc90e<R> : io.reactivex.rxjava3.core.SingleObserver<R> {
    readonly java.util.concurrent.atomic.object f27f93a1a;
    readonly io.reactivex.rxjava3.core.SingleObserver f396a7d83;
    readonly java.util.concurrent.atomic.object f55f011f6;
    readonly java.util.concurrent.atomic.object f663e3dff;
    readonly io.reactivex.rxjava3.core.SingleObserver faad1259d;
    readonly io.reactivex.rxjava3.core.SingleObserver fb93f96d8;
    readonly io.reactivex.rxjava3.core.SingleObserver fb9d8050f;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fd0e45878;
    readonly io.reactivex.rxjava3.core.SingleObserver<R> fd22a0a80;

    p672ed7d4$p87711177$p475bc90e(java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference, io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        this.fd0e45878 = atomicReference;
        this.fd22a0a80 = singleObserver;
    }

    public static void VTfDmcgRFuOIDbAL(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool WaiRSxttXPonQpYf(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void QsXNIbrsSGgqDOfm(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void OnError(java.lang.Exception th) {
        qsXNIbrsSGgqDOfm(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        WaiRSxttXPonQpYf(this.fd0e45878, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        VTfDmcgRFuOIDbAL(this.fd22a0a80, r);
    }
}

