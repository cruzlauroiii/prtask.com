namespace WillowMaze.Wasm.Decompiled;


readonly class p84f45a11$p475bc90e$p9192f42a<R> : io.reactivex.rxjava3.core.SingleObserver<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p84f45a11$p475bc90e this$0;

    p84f45a11$p475bc90e$p9192f42a(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p84f45a11$p475bc90e p84f45a11_p475bc90e) {
        this.this$0 = p84f45a11_p475bc90e;
    }

    public static void ArVkQqtDXezAJNeY(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool CHWMZapSuJXYTTnf(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void CoaJxnmpHchwhSjI(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public override void OnError(java.lang.Exception th) {
        ArVkQqtDXezAJNeY(this.this$0.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        CHWMZapSuJXYTTnf(this.this$0, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        coaJxnmpHchwhSjI(this.this$0.fd22a0a80, r);
    }
}

