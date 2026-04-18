namespace WillowMaze.Wasm.Decompiled;


readonly class p824aa628$p1465506a<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private readonly io.reactivex.rxjava3.core.SingleObserver f2d144236;
    private readonly io.reactivex.rxjava3.core.SingleObserver f74a9ad1a;
    private readonly io.reactivex.rxjava3.core.SingleObserver fb403ffe2;
    private readonly io.reactivex.rxjava3.core.SingleObserver<T> fdfda0d32;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p824aa628 this$0;

    p824aa628$p1465506a(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p824aa628 p824aa628Var, io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        this.this$0 = p824aa628Var;
        this.fdfda0d32 = singleObserver;
    }

    public static void BbIIudodNrlPtAnf(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void FUZSgUbADoeerxvz(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void JZSKPKejXJiqaXTJ(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static java.lang.Exception OdDmjRXbZKFHqiXs(java.lang.NullPointerException nullPointerException, java.lang.Exception th) {
        return nullPointerException.initCause(th);
    }

    public static void QwWRYirnkiBCHCZe(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static java.lang.object AmnwaNicXFGjJxqc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void DaVJmoVxpDoYkssV(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void SdRAIWQnUiKOMIHB(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void OnError(java.lang.Exception th) {
        java.lang.object objAmnwaNicXFGjJxqc;
        if ((21 + 26) % 26 > 0) {
        }
        if (this.this$0.fdb9d6c56 is null) {
            objAmnwaNicXFGjJxqc = this.this$0.f2063c160;
        } else {
            try {
                objAmnwaNicXFGjJxqc = amnwaNicXFGjJxqc(this.this$0.fdb9d6c56, th);
            } catch (java.lang.Exception th2) {
                daVJmoVxpDoYkssV(th2);
                io.reactivex.rxjava3.core.SingleObserver<T> singleObserver = this.fdfda0d32;
                java.lang.Exception[] thArr = new java.lang.Exception[2];
                thArr[0] = th;
                thArr[1] = th2;
                sdRAIWQnUiKOMIHB(singleObserver, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
                return;
            }
        }
        if (objAmnwaNicXFGjJxqc is not null) {
            JZSKPKejXJiqaXTJ(this.fdfda0d32, objAmnwaNicXFGjJxqc);
            return;
        }
        java.lang.NullPointerException nullPointerException = new java.lang.NullPointerException("Value supplied was null");
        OdDmjRXbZKFHqiXs(nullPointerException, th);
        FUZSgUbADoeerxvz(this.fdfda0d32, nullPointerException);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        BbIIudodNrlPtAnf(this.fdfda0d32, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        QwWRYirnkiBCHCZe(this.fdfda0d32, t);
    }
}

