namespace WillowMaze.Wasm.Decompiled;


readonly class p7604dd33$pd8e4ea6a<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f004796a8;
    bool f077c8855;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f21b65c14;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f34adda01;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f3a452320;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f5189d733;
    bool f5b568854;
    readonly io.reactivex.rxjava3.core.SingleObserver f6a786d2a;
    bool f6b2ded51;
    bool f9a03ab8c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f9a66f3ee;
    bool f9b5b62ee;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver fc0a46d09;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fc115e03b;
    readonly io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> fd22a0a80;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff98eaa66;

    p7604dd33$pd8e4ea6a(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.fd22a0a80 = singleObserver;
        this.ff670ef68 = predicate;
    }

    public static void CYmCQVffaeVBOJNH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7604dd33$pd8e4ea6a p7604dd33_pd8e4ea6a, java.lang.Exception th) {
        p7604dd33_pd8e4ea6a.onError(th);
    }

    public static void IQXUojYmJqUSFbzd(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool THVHHSSsfaaZJQeC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static java.lang.bool ZLocZFbbMMDisFJV(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool ZpCjOXWWYldUqPNM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void AKIoUBrNgdxIBAKi(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void AbopgibUDpJbKTop(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void GzNYYjhcJuFUeDKf(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void LUyIqBVMbhqBmYpK(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void NhJbtMYKTQRpeofA(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool PLqxxAsmuMXQstTA(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static java.lang.bool QuthpVyPmCZdxgJq(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void WIvUrdONCoGSwnKM(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void XxCuleRNBEDDRCzO(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void YsxCSeSLFiZdvmrY(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public override void Dispose() {
        abopgibUDpJbKTop(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return ZpCjOXWWYldUqPNM(this.fbc3b0556);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        gzNYYjhcJuFUeDKf(this.fd22a0a80, ZLocZFbbMMDisFJV(true));
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            aKIoUBrNgdxIBAKi(th);
        } else {
            this.f6b2ded51 = true;
            wIvUrdONCoGSwnKM(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        try {
            if (pLqxxAsmuMXQstTA(this.ff670ef68, t)) {
                return;
            }
            this.f6b2ded51 = true;
            lUyIqBVMbhqBmYpK(this.fbc3b0556);
            nhJbtMYKTQRpeofA(this.fd22a0a80, quthpVyPmCZdxgJq(false));
        } catch (java.lang.Exception th) {
            ysxCSeSLFiZdvmrY(th);
            xxCuleRNBEDDRCzO(this.fbc3b0556);
            CYmCQVffaeVBOJNH(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (THVHHSSsfaaZJQeC(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            IQXUojYmJqUSFbzd(this.fd22a0a80, this);
        }
    }
}

