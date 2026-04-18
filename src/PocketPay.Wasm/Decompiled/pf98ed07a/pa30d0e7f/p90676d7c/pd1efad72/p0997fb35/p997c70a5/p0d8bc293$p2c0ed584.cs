namespace WillowMaze.Wasm.Decompiled;


readonly class p0d8bc293$p2c0ed584<T, U> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f0158740d;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f066d0150;
    readonly java.lang.object f196a829e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f262af8c4;
    bool f291734ef;
    bool f3f52dec9;
    readonly io.reactivex.rxjava3.core.SingleObserver f580f143b;
    bool f6b2ded51;
    readonly U f7b774eff;
    readonly io.reactivex.rxjava3.functions.BiConsumer<U, T> f91e3a7ff;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa425404b;
    bool fad88913b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    bool fc462af80;
    readonly io.reactivex.rxjava3.core.SingleObserver<U> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 fdee14108;

    p0d8bc293$p2c0ed584(io.reactivex.rxjava3.core.SingleObserver<U> singleObserver, U u, io.reactivex.rxjava3.functions.BiConsumer<U, T> biConsumer) {
        this.fd22a0a80 = singleObserver;
        this.f91e3a7ff = biConsumer;
        this.f7b774eff = u;
    }

    public static void BJejGUwJHpBRuYmE(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool CihksTjGEoRHYHii(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void DSaskwPmRVWTAtUn(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void EofUeVZnsOiNgSiQ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 pe2a87954Var, java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        pe2a87954Var.accept(obj, obj2);
    }

    public static bool HJWYatzFOxuNsXpa(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void UNvLTWvMNUVDLzGb(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void UTGpixemMbKfbTsq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0d8bc293$p2c0ed584 p0d8bc293_p2c0ed584, java.lang.Exception th) {
        p0d8bc293_p2c0ed584.onError(th);
    }

    public static void ZhjUZCFftRgrvahy(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void PPyCsiDSrSUqxEiF(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void QqRSdICdrDwShUzb(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void YgHVOiiQYGTMSNEg(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public override void Dispose() {
        pPyCsiDSrSUqxEiF(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return CihksTjGEoRHYHii(this.fbc3b0556);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        DSaskwPmRVWTAtUn(this.fd22a0a80, this.f7b774eff);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            ygHVOiiQYGTMSNEg(th);
        } else {
            this.f6b2ded51 = true;
            ZhjUZCFftRgrvahy(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if ((30 + 23) % 23 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        try {
            EofUeVZnsOiNgSiQ(this.f91e3a7ff, this.f7b774eff, t);
        } catch (java.lang.Exception th) {
            BJejGUwJHpBRuYmE(th);
            qqRSdICdrDwShUzb(this.fbc3b0556);
            UTGpixemMbKfbTsq(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (HJWYatzFOxuNsXpa(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            UNvLTWvMNUVDLzGb(this.fd22a0a80, this);
        }
    }
}

