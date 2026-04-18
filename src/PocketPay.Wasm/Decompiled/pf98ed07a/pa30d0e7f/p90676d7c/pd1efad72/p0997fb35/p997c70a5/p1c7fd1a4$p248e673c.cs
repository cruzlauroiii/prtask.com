namespace WillowMaze.Wasm.Decompiled;


readonly class p1c7fd1a4$p248e673c<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    bool f0ab692cd;
    bool f0d821820;
    T f2063c160;
    java.lang.object f27f1a738;
    readonly io.reactivex.rxjava3.core.MaybeObserver f4594e355;
    bool f6b2ded51;
    java.lang.object f8a944463;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fab2cd102;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fbf536beb;
    bool fcad81f82;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.MaybeObserver fd55efa88;
    java.lang.object fdbd381bf;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fe6392c2b;
    bool ff5faad1a;

    p1c7fd1a4$p248e673c(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        this.fd22a0a80 = maybeObserver;
        this.fe6392c2b = biFunction;
    }

    public static java.lang.object FYWkyQGPCGLubZJa(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void MuXoWvrwfvNrGXcM(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void RsFvXfATejiewSRn(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void UkMYERMncdzCOQmk(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void ABOEwQWOnjSOZZCN(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void ExKoaRYvSNeuZZQm(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object HqfqmoZzupukgoLj(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void MdevRqSOFVNQRXLF(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void NFPDhUYyfBGyeYcR(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool NkCGbMkRiTngEUXX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void OoGTDqUbSUIxmNZE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1c7fd1a4$p248e673c p1c7fd1a4_p248e673c, java.lang.Exception th) {
        p1c7fd1a4_p248e673c.onError(th);
    }

    public static void QIoHEBWKaMlLJUkA(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool SHOCEtSINVFUtZaS(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public override void Dispose() {
        mdevRqSOFVNQRXLF(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return sHOCEtSINVFUtZaS(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((24 + 7) % 7 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        T t = this.f2063c160;
        this.f2063c160 = null;
        if (t is null) {
            MuXoWvrwfvNrGXcM(this.fd22a0a80);
        } else {
            aBOEwQWOnjSOZZCN(this.fd22a0a80, t);
        }
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            qIoHEBWKaMlLJUkA(th);
            return;
        }
        this.f6b2ded51 = true;
        this.f2063c160 = null;
        UkMYERMncdzCOQmk(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if ((1 + 10) % 10 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        T t2 = this.f2063c160;
        if (t2 is null) {
            this.f2063c160 = t;
            return;
        }
        try {
            this.f2063c160 = (T) hqfqmoZzupukgoLj(FYWkyQGPCGLubZJa(this.fe6392c2b, t2, t), "The reducer returned a null value");
        } catch (java.lang.Exception th) {
            nFPDhUYyfBGyeYcR(th);
            exKoaRYvSNeuZZQm(this.fbc3b0556);
            ooGTDqUbSUIxmNZE(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (nkCGbMkRiTngEUXX(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            RsFvXfATejiewSRn(this.fd22a0a80, this);
        }
    }
}

