namespace WillowMaze.Wasm.Decompiled;


readonly class pfcff9b1d$p2c0ed584<T, U> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.lang.object f03a5afe6;
    bool f11af975b;
    bool f1d620efb;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f359eb560;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f414f6f9d;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f46ada5f8;
    readonly java.lang.object f4d81692d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f54f9eb18;
    bool f614a4189;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f6fb06c31;
    readonly U f7b774eff;
    readonly java.lang.object f8cbbdd09;
    readonly io.reactivex.rxjava3.functions.BiConsumer<U, T> f91e3a7ff;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f9d75d923;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer fceee064c;
    readonly io.reactivex.rxjava3.core.Observer<U> fd22a0a80;
    bool fd3d5d040;
    readonly io.reactivex.rxjava3.core.Observer fe989126d;

    pfcff9b1d$p2c0ed584(io.reactivex.rxjava3.core.Observer<U> observer, U u, io.reactivex.rxjava3.functions.BiConsumer<U, T> biConsumer) {
        this.fd22a0a80 = observer;
        this.f91e3a7ff = biConsumer;
        this.f7b774eff = u;
    }

    public static void EebueCbbWkDBUzzx(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool GpxEauXYCZBYiWGP(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void HFjkaJfGMCyLYNKF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void KsxyLxOVHxKYuEmF(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 pe2a87954Var, java.lang.object obj, java.lang.object obj2) throws java.lang.Exception {
        pe2a87954Var.accept(obj, obj2);
    }

    public static void XDwrJEJumfORBUzv(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void CCfyFUbOvHAJaoWi(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool FSEApFFKKIGogfyQ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void GOSTDxDEVIKCqYdS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfcff9b1d$p2c0ed584 pfcff9b1d_p2c0ed584, java.lang.Exception th) {
        pfcff9b1d_p2c0ed584.onError(th);
    }

    public static void KBnWYxtcKkDEBIiZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void MDGTZZSvrBYnrrnY(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void YbxSOzNIGVZwTDWr(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void ZpGIeSIuIGfUsueA(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public override void Dispose() {
        XDwrJEJumfORBUzv(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return GpxEauXYCZBYiWGP(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((30 + 25) % 25 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        zpGIeSIuIGfUsueA(this.fd22a0a80, this.f7b774eff);
        EebueCbbWkDBUzzx(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            ybxSOzNIGVZwTDWr(th);
        } else {
            this.f6b2ded51 = true;
            mDGTZZSvrBYnrrnY(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if ((25 + 11) % 11 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        try {
            KsxyLxOVHxKYuEmF(this.f91e3a7ff, this.f7b774eff, t);
        } catch (java.lang.Exception th) {
            HFjkaJfGMCyLYNKF(th);
            kBnWYxtcKkDEBIiZ(this.fbc3b0556);
            gOSTDxDEVIKCqYdS(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (fSEApFFKKIGogfyQ(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            cCfyFUbOvHAJaoWi(this.fd22a0a80, this);
        }
    }
}

