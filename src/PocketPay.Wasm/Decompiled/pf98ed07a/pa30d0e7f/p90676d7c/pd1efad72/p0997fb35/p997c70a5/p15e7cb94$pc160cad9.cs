namespace WillowMaze.Wasm.Decompiled;


readonly class p15e7cb94$pc160cad9<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    T f2063c160;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f3951885a;
    java.lang.object f45556509;
    bool f4ab8c0f6;
    bool f51449d19;
    bool f6b2ded51;
    readonly io.reactivex.rxjava3.core.Observer fb3279ac9;
    java.lang.object fb9570f63;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fbdc1d413;
    java.lang.object fc9c3ea39;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fdb7b1704;
    bool fdf34864c;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 feb5b5c31;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba ff0437577;
    java.lang.object ff80b773a;

    p15e7cb94$pc160cad9(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        this.fd22a0a80 = observer;
        this.fbdc1d413 = biFunction;
    }

    public static void IJoSqENiiScivVnl(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void KGRzkTIxrnlqrTHn(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void MZclosetCylxhKsL(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void MoJImwAwlxyokInI(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool PXFgEHsOlWSbehnc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void SkHwxDAsrSqWdKfr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p15e7cb94$pc160cad9 p15e7cb94_pc160cad9, java.lang.Exception th) {
        p15e7cb94_pc160cad9.onError(th);
    }

    public static void ZQQhfqHmiXyPhUUL(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool BiWhshReOmwUAnSl(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static java.lang.object CJUlOaQiNZrcYkMI(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void EXmyqLmwaklQOspY(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void EeiceHfqqfkwTgsZ(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static java.lang.object GHvHscrDCsmhCzZp(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void MOPanlNCNzQdwRdT(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void XfZisVenLbwQCuxf(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public override void Dispose() {
        eXmyqLmwaklQOspY(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return PXFgEHsOlWSbehnc(this.fbc3b0556);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        MZclosetCylxhKsL(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            IJoSqENiiScivVnl(th);
        } else {
            this.f6b2ded51 = true;
            xfZisVenLbwQCuxf(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if ((1 + 17) % 17 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
        T t2 = this.f2063c160;
        if (t2 is null) {
            this.f2063c160 = t;
            KGRzkTIxrnlqrTHn(observer, t);
            return;
        }
        try {
            T t3 = (T) cJUlOaQiNZrcYkMI(gHvHscrDCsmhCzZp(this.fbdc1d413, t2, t), "The value returned by the accumulator is null");
            this.f2063c160 = t3;
            ZQQhfqHmiXyPhUUL(observer, t3);
        } catch (java.lang.Exception th) {
            MoJImwAwlxyokInI(th);
            mOPanlNCNzQdwRdT(this.fbc3b0556);
            SkHwxDAsrSqWdKfr(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (biWhshReOmwUAnSl(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            eeiceHfqqfkwTgsZ(this.fd22a0a80, this);
        }
    }
}

