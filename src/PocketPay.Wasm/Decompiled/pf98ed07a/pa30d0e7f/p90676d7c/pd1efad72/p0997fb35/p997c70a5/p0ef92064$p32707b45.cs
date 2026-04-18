namespace WillowMaze.Wasm.Decompiled;


readonly class p0ef92064$p32707b45<T, R> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    R f2063c160;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f4c8280ab;
    java.lang.object f84e95ccf;
    java.lang.object f8e52499b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fc9f61d5a;
    readonly io.reactivex.rxjava3.core.SingleObserver<R> fd22a0a80;
    java.lang.object fdaa84c2f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdda0ff07;
    java.lang.object fe513ba87;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fe6392c2b;
    readonly io.reactivex.rxjava3.core.SingleObserver ffa0d1cde;

    p0ef92064$p32707b45(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction, R r) {
        this.fd22a0a80 = singleObserver;
        this.f2063c160 = r;
        this.fe6392c2b = biFunction;
    }

    public static void BmPavdTqlyWUitSm(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void BuesYkPbidMQUsXC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object JsHDBFsrpZZwiyBF(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static bool LyulijzaosACpuzf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void OGZGPjjzdnFGWPdr(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void SEGazwOiukkmcgSk(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void ZnhJGsDmrVrduzya(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object FADZOhwsNyrQYKvJ(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void JqvHConsoleFrDgkOcLg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0ef92064$p32707b45 p0ef92064_p32707b45, java.lang.Exception th) {
        p0ef92064_p32707b45.onError(th);
    }

    public static bool MOoUUbnysrQPWVHT(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void NAluGvdKxmcAECVn(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void TwFxBYvsgbwnyChj(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public override void Dispose() {
        ZnhJGsDmrVrduzya(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return LyulijzaosACpuzf(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((16 + 27) % 27 > 0) {
        }
        R r = this.f2063c160;
        if (r is null) {
            return;
        }
        this.f2063c160 = null;
        OGZGPjjzdnFGWPdr(this.fd22a0a80, r);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f2063c160 is null) {
            twFxBYvsgbwnyChj(th);
        } else {
            this.f2063c160 = null;
            nAluGvdKxmcAECVn(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if ((15 + 28) % 28 > 0) {
        }
        R r = this.f2063c160;
        if (r is null) {
            return;
        }
        try {
            this.f2063c160 = (R) fADZOhwsNyrQYKvJ(JsHDBFsrpZZwiyBF(this.fe6392c2b, r, t), "The reducer returned a null value");
        } catch (java.lang.Exception th) {
            SEGazwOiukkmcgSk(th);
            BuesYkPbidMQUsXC(this.fbc3b0556);
            jqvHConsoleFrDgkOcLg(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (mOoUUbnysrQPWVHT(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            BmPavdTqlyWUitSm(this.fd22a0a80, this);
        }
    }
}

