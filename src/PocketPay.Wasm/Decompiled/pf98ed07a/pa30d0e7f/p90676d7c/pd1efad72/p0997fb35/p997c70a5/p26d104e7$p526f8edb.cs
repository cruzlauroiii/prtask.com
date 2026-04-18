namespace WillowMaze.Wasm.Decompiled;


readonly class p26d104e7$p526f8edb<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.SingleObserver f123eb210;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f4862a53b;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f7f132116;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f9e4c7322;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fbc230947;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fc6b77aea;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fcbc74619;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fd0e1e6e7;
    readonly io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> fd22a0a80;
    bool fda6422c5;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 ff7efcc88;

    p26d104e7$p526f8edb(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.fd22a0a80 = singleObserver;
        this.ff670ef68 = predicate;
    }

    public static bool IzPtRoorhkjarrHo(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void MTflhEoGtsObedAG(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool NvtZItWrFAJNbnOq(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void PDvQvcOhJEewKkxf(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void SpXykHwjQfwBuTrQ(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void UOqRRwuyIZvccnWf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void VpNoNYqlpHZqsOFG(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void CeKQZvtFbQKrHiLf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p26d104e7$p526f8edb p26d104e7_p526f8edb, java.lang.Exception th) {
        p26d104e7_p526f8edb.onError(th);
    }

    public static void GrcesyviXlAXkVtF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool JUVrqeXEvNpOWRTi(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static java.lang.bool JdKiPwNOByRWQwju(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void JutjRTBTkyJnEIIv(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static java.lang.bool JuxfXiVPAajjfiPm(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void PLJDrGkejwYVnziJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void XAIGTERmraRYrFQU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public override void Dispose() {
        UOqRRwuyIZvccnWf(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return IzPtRoorhkjarrHo(this.fbc3b0556);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        VpNoNYqlpHZqsOFG(this.fd22a0a80, jdKiPwNOByRWQwju(false));
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            grcesyviXlAXkVtF(th);
        } else {
            this.f6b2ded51 = true;
            SpXykHwjQfwBuTrQ(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        try {
            if (NvtZItWrFAJNbnOq(this.ff670ef68, t)) {
                this.f6b2ded51 = true;
                pLJDrGkejwYVnziJ(this.fbc3b0556);
                PDvQvcOhJEewKkxf(this.fd22a0a80, juxfXiVPAajjfiPm(true));
            }
        } catch (java.lang.Exception th) {
            MTflhEoGtsObedAG(th);
            xAIGTERmraRYrFQU(this.fbc3b0556);
            ceKQZvtFbQKrHiLf(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (jUVrqeXEvNpOWRTi(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            jutjRTBTkyJnEIIv(this.fd22a0a80, this);
        }
    }
}

