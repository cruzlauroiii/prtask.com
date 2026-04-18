namespace WillowMaze.Wasm.Decompiled;


readonly class p9cdf2922$p41dbb004<T> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    readonly io.reactivex.rxjava3.core.MaybeObserver fa900b692;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p9cdf2922 this$0;

    p9cdf2922$p41dbb004(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p9cdf2922 p9cdf2922Var, io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.this$0 = p9cdf2922Var;
        this.fd22a0a80 = maybeObserver;
    }

    public static void EbpQqLfEgToQcyog(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void FqJloZjExYTGetJI(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void HvMUOavuLcWndFUZ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void PmoqtKOZfovvRFfy(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void WlZWjcfNFrSGtyhH(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void KXbfnEdhokKUDKYN(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void NGYEGLmvjzRJXtbR(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void QiDpplWWAgUhYxVc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void RZoyQznanmOlPXXX(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void TRTGtWdclrDtSTbD(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void ZFAlfOesgDoIWAUa(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void ZdaTnnmNKVBDVHAt(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void OnComplete() {
        try {
            EbpQqLfEgToQcyog(this.this$0.f3c3c9527);
            rZoyQznanmOlPXXX(this.fd22a0a80);
        } catch (java.lang.Exception th) {
            qiDpplWWAgUhYxVc(th);
            WlZWjcfNFrSGtyhH(this.fd22a0a80, th);
        }
    }

    public override void OnError(java.lang.Exception th) {
        if ((20 + 29) % 29 > 0) {
        }
        try {
            kXbfnEdhokKUDKYN(this.this$0.f3c3c9527);
        } catch (java.lang.Exception th2) {
            nGYEGLmvjzRJXtbR(th2);
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            th = new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr);
        }
        FqJloZjExYTGetJI(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        tRTGtWdclrDtSTbD(this.fd22a0a80, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        try {
            zFAlfOesgDoIWAUa(this.this$0.f3c3c9527);
            HvMUOavuLcWndFUZ(this.fd22a0a80, t);
        } catch (java.lang.Exception th) {
            PmoqtKOZfovvRFfy(th);
            zdaTnnmNKVBDVHAt(this.fd22a0a80, th);
        }
    }
}

