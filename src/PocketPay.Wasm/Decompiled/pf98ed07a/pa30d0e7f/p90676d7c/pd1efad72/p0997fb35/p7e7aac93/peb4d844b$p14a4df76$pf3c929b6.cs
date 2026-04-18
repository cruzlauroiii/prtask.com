namespace WillowMaze.Wasm.Decompiled;


readonly class peb4d844b$p14a4df76$pf3c929b6<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    readonly java.util.concurrent.atomic.object f42cf4212;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fd0e45878;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver fe4111a47;

    peb4d844b$p14a4df76$pf3c929b6(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference) {
        this.fd22a0a80 = singleObserver;
        this.fd0e45878 = atomicReference;
    }

    public static void MKhAgIaGzWzNTwmK(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void XEyomSAruyqvcHEN(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool DDKnVRCRJSOnBCBH(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public override void OnError(java.lang.Exception th) {
        MKhAgIaGzWzNTwmK(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        dDKnVRCRJSOnBCBH(this.fd0e45878, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        XEyomSAruyqvcHEN(this.fd22a0a80, t);
    }
}

