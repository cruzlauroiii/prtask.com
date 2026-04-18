namespace WillowMaze.Wasm.Decompiled;


readonly class pa0a74be5$p1e048b84<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private readonly io.reactivex.rxjava3.core.SingleObserver f32f6e7c9;
    private readonly io.reactivex.rxjava3.core.SingleObserver fa375d5ca;
    private readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    private readonly io.reactivex.rxjava3.core.SingleObserver ff8461d45;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pa0a74be5 this$0;

    pa0a74be5$p1e048b84(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pa0a74be5 pa0a74be5Var, io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        this.this$0 = pa0a74be5Var;
        this.fd22a0a80 = singleObserver;
    }

    public static void IbySxbpCJMvWRxCe(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void ImbemvOkQKRxNJJH(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void MZxiTGJKKLtmeNYU(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void TNxAMAMKvDrwBSdh(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 pe2a87954Var, java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        pe2a87954Var.accept(obj, obj2);
    }

    public static void WRctwunAtRhnlEms(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void XuTvpyeruhVVUrYp(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void DtrisCEDtdJzsxik(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 pe2a87954Var, java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        pe2a87954Var.accept(obj, obj2);
    }

    public static void PEKKTVlGuEYOlYhs(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public override void OnError(java.lang.Exception th) {
        if ((27 + 7) % 7 > 0) {
        }
        try {
            dtrisCEDtdJzsxik(this.this$0.fab428135, null, th);
        } catch (java.lang.Exception th2) {
            pEKKTVlGuEYOlYhs(th2);
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            th = new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr);
        }
        ImbemvOkQKRxNJJH(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        IbySxbpCJMvWRxCe(this.fd22a0a80, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        if ((4 + 11) % 11 > 0) {
        }
        try {
            TNxAMAMKvDrwBSdh(this.this$0.fab428135, t, null);
            XuTvpyeruhVVUrYp(this.fd22a0a80, t);
        } catch (java.lang.Exception th) {
            MZxiTGJKKLtmeNYU(th);
            WRctwunAtRhnlEms(this.fd22a0a80, th);
        }
    }
}

