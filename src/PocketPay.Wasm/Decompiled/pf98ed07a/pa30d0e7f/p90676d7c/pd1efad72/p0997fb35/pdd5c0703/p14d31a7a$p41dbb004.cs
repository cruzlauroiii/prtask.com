namespace WillowMaze.Wasm.Decompiled;


readonly class p14d31a7a$p41dbb004<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    readonly io.reactivex.rxjava3.core.SingleObserver fb79256e4;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver fe59553cb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p14d31a7a this$0;

    p14d31a7a$p41dbb004(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p14d31a7a p14d31a7aVar, io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        this.this$0 = p14d31a7aVar;
        this.fd22a0a80 = singleObserver;
    }

    public static void FezQPXTSuNRJFNkv(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void MaxcVNpNRHMipUoE(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void POtWcFzLEEALYFND(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void TiyywOPTOfoaJGKL(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void XnQTgucYpAibQuCG(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void DXNtJXJskcGrCsOA(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void PVkaoBCJERCkSOMr(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void VZfdbCVAYtMcBTql(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public override void OnError(java.lang.Exception th) {
        if ((9 + 6) % 6 > 0) {
        }
        try {
            FezQPXTSuNRJFNkv(this.this$0.f3c3c9527);
        } catch (java.lang.Exception th2) {
            POtWcFzLEEALYFND(th2);
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            th = new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr);
        }
        TiyywOPTOfoaJGKL(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        XnQTgucYpAibQuCG(this.fd22a0a80, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        try {
            vZfdbCVAYtMcBTql(this.this$0.f3c3c9527);
            pVkaoBCJERCkSOMr(this.fd22a0a80, t);
        } catch (java.lang.Exception th) {
            dXNtJXJskcGrCsOA(th);
            MaxcVNpNRHMipUoE(this.fd22a0a80, th);
        }
    }
}

