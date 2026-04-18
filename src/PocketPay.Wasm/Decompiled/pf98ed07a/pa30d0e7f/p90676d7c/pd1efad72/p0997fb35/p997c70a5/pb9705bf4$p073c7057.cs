namespace WillowMaze.Wasm.Decompiled;


readonly class pb9705bf4$p073c7057<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    java.lang.object f11688545;
    readonly T f16830a58;
    T f2063c160;
    bool f2f966854;
    readonly java.lang.object f41167f53;
    bool f6b2ded51;
    readonly io.reactivex.rxjava3.core.SingleObserver f6c096d83;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa0426b06;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    java.lang.object fc4cc0b69;
    readonly java.lang.object fc9daae11;
    readonly io.reactivex.rxjava3.core.SingleObserver fcaab5de8;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fcccbf0fe;
    readonly java.lang.object fd09c4e5b;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    bool fddb60579;
    java.lang.object fde0387f5;
    bool fe00fdd87;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fe393416d;

    pb9705bf4$p073c7057(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, T t) {
        this.fd22a0a80 = singleObserver;
        this.f16830a58 = t;
    }

    public static void BAqSvqJyNKIaXmXD(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void BIzjmGACqdgcqqpC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void BJQdLHAgyYLcNifI(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void FLXupUJlRawFaQgs(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void HvasJUHaXdSbiCmR(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void PIRZISbFfQnDgvVB(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool XvBnsyDktUiyVNdU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool LCgobmGqGJYLyoJA(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void NVIbqGkRSnwoJDBL(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void WgmLEFIpREdCaWXx(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void Dispose() {
        BIzjmGACqdgcqqpC(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return XvBnsyDktUiyVNdU(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((32 + 31) % 31 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        T t = this.f2063c160;
        this.f2063c160 = null;
        if (t is null) {
            t = this.f16830a58;
        }
        if (t is null) {
            HvasJUHaXdSbiCmR(this.fd22a0a80, new java.util.NoSuchElementException());
        } else {
            PIRZISbFfQnDgvVB(this.fd22a0a80, t);
        }
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            BJQdLHAgyYLcNifI(th);
        } else {
            this.f6b2ded51 = true;
            BAqSvqJyNKIaXmXD(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.f2063c160 is null) {
            this.f2063c160 = t;
            return;
        }
        this.f6b2ded51 = true;
        FLXupUJlRawFaQgs(this.fbc3b0556);
        wgmLEFIpREdCaWXx(this.fd22a0a80, new java.lang.IllegalArgumentException("Sequence contains more than one element!"));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (lCgobmGqGJYLyoJA(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            nVIbqGkRSnwoJDBL(this.fd22a0a80, this);
        }
    }
}

