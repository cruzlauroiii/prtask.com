namespace WillowMaze.Wasm.Decompiled;


readonly class pd8768b96$p7c9324ab$p9192f42a<R> : io.reactivex.rxjava3.core.MaybeObserver<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd8768b96$p7c9324ab this$0;

    pd8768b96$p7c9324ab$p9192f42a(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd8768b96$p7c9324ab pd8768b96_p7c9324ab) {
        this.this$0 = pd8768b96_p7c9324ab;
    }

    public static void FnLtsZQExIywDPjr(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool DGLiEffoJhzBGLdS(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void QTGjcVotmALIkRhr(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void SjIRGrAJfqYWCXYk(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public override void OnComplete() {
        sjIRGrAJfqYWCXYk(this.this$0.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        qTGjcVotmALIkRhr(this.this$0.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        dGLiEffoJhzBGLdS(this.this$0, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        FnLtsZQExIywDPjr(this.this$0.fd22a0a80, r);
    }
}

