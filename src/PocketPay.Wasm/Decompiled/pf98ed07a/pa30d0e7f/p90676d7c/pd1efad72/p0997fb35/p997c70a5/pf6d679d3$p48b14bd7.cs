namespace WillowMaze.Wasm.Decompiled;


readonly class pf6d679d3$p48b14bd7<T, R> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f0658cf5e;
    java.lang.object f109e4dba;
    readonly io.reactivex.rxjava3.core.Observer f171e185c;
    R f2063c160;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f20c610b0;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2b4c85f1;
    readonly io.reactivex.rxjava3.core.Observer f450701d2;
    bool f4683a50d;
    java.lang.object f487f986b;
    bool f6429b395;
    bool f6b2ded51;
    readonly io.reactivex.rxjava3.core.Observer fa8d17e8f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fbdc1d413;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbf1a598b;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer fd2e52e3d;
    java.lang.object ff316f607;

    pf6d679d3$p48b14bd7(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction, R r) {
        this.fd22a0a80 = observer;
        this.fbdc1d413 = biFunction;
        this.f2063c160 = r;
    }

    public static void AchqvZNbhuToTBKO(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool FVRzcSYDQgDWQLXx(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void KfXOeHlpmctoKVfl(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void LDpclFbeGbJFcXHp(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void LOvULIXPCShHiQCg(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void NpdFvMIcknxRpjsi(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool SPUCbQqFrlWutphA(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void WxWOwgUvJGDAaqWr(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object YkBKmtLijeKprPQx(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static java.lang.object BPWHaXOgFphrQDyV(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void CtRVdkwUDATumoPf(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void IobdqbWLRnoIGkeQ(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void OWACKtHwPlENMZxu(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void YQlVglpeglzbdWhk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pf6d679d3$p48b14bd7 pf6d679d3_p48b14bd7, java.lang.Exception th) {
        pf6d679d3_p48b14bd7.onError(th);
    }

    public override void Dispose() {
        LOvULIXPCShHiQCg(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return FVRzcSYDQgDWQLXx(this.fbc3b0556);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        ctRVdkwUDATumoPf(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            KfXOeHlpmctoKVfl(th);
        } else {
            this.f6b2ded51 = true;
            iobdqbWLRnoIGkeQ(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if ((27 + 8) % 8 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        try {
            R r = (R) bPWHaXOgFphrQDyV(YkBKmtLijeKprPQx(this.fbdc1d413, this.f2063c160, t), "The accumulator returned a null value");
            this.f2063c160 = r;
            oWACKtHwPlENMZxu(this.fd22a0a80, r);
        } catch (java.lang.Exception th) {
            AchqvZNbhuToTBKO(th);
            NpdFvMIcknxRpjsi(this.fbc3b0556);
            yQlVglpeglzbdWhk(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (SPUCbQqFrlWutphA(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            LDpclFbeGbJFcXHp(this.fd22a0a80, this);
            WxWOwgUvJGDAaqWr(this.fd22a0a80, this.f2063c160);
        }
    }
}

