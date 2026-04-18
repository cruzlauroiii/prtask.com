namespace WillowMaze.Wasm.Decompiled;


readonly class p2e204e81$pd309e11d<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    readonly io.reactivex.rxjava3.core.SingleObserver f187605b3;
    readonly io.reactivex.rxjava3.core.SingleObserver f1d355b7b;
    readonly io.reactivex.rxjava3.core.SingleObserver f2d020486;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver ffdc3e40b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p2e204e81 this$0;

    p2e204e81$pd309e11d(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p2e204e81 p2e204e81Var, io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        this.this$0 = p2e204e81Var;
        this.fd22a0a80 = singleObserver;
    }

    public static void CuKykxAyLZMZyxnL(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void NKOOgzLbgjQrHctZ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void UfcgFcFByioIDLtY(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void XQtVLhcJoxPRDYpV(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void FhlPxBOiEnMOTIXi(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void QrOIxNXIfiWTaLKM(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void OnError(java.lang.Exception th) {
        CuKykxAyLZMZyxnL(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        XQtVLhcJoxPRDYpV(this.fd22a0a80, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        try {
            NKOOgzLbgjQrHctZ(this.this$0.ff36fb8bf, t);
            fhlPxBOiEnMOTIXi(this.fd22a0a80, t);
        } catch (java.lang.Exception th) {
            UfcgFcFByioIDLtY(th);
            qrOIxNXIfiWTaLKM(this.fd22a0a80, th);
        }
    }
}

