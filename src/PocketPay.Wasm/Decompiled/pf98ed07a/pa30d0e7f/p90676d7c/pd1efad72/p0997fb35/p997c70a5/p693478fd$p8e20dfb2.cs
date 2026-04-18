namespace WillowMaze.Wasm.Decompiled;


readonly class p693478fd$p8e20dfb2<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.CompletableObserver f237a1f37;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f25922e03;
    readonly io.reactivex.rxjava3.core.CompletableObserver f4331e47e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.CompletableObserver fd22a0a80;
    readonly io.reactivex.rxjava3.core.CompletableObserver fd4bc8f5a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fea47ab21;

    p693478fd$p8e20dfb2(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        this.fd22a0a80 = completableObserver;
    }

    public static bool DBHhjdrZWuQdneoi(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void LSPgorVsbUshAbnv(io.reactivex.rxjava3.core.CompletableObserver completableObserver, java.lang.Exception th) {
        completableObserver.onError(th);
    }

    public static void HVvICmmcibeODXWD(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableObserver.onComplete();
    }

    public static void MxejVFpMEIVRbYBQ(io.reactivex.rxjava3.core.CompletableObserver completableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        completableObserver.onSubscribe(p7beea252Var);
    }

    public static void RnNcwKFPkiiJULnE(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public override void Dispose() {
        rnNcwKFPkiiJULnE(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return DBHhjdrZWuQdneoi(this.fbc3b0556);
    }

    public override void OnComplete() {
        hVvICmmcibeODXWD(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        LSPgorVsbUshAbnv(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        this.fbc3b0556 = p7beea252Var;
        mxejVFpMEIVRbYBQ(this.fd22a0a80, this);
    }
}

