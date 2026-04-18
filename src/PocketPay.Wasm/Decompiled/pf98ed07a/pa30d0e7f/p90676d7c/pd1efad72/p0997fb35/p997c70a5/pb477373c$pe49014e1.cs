namespace WillowMaze.Wasm.Decompiled;


readonly class pb477373c$pe49014e1<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f01c4c753;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f31619e5e;
    readonly io.reactivex.rxjava3.core.Observer f63557542;
    bool f6b2ded51;
    readonly io.reactivex.rxjava3.core.Observer f9934262f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fc61ad037;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    bool fe3f647ad;
    readonly io.reactivex.rxjava3.core.Observer fe7b323f0;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    pb477373c$pe49014e1(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.fd22a0a80 = observer;
        this.ff670ef68 = predicate;
    }

    public static bool FiHUHDyGugsKWSyQ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void GSzZgogrpvoHNgIu(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void PxvwtMjCfHCcDXzd(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void SNVWKtvCHYrjljwD(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void SzgMOKUFrFclIYoV(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool YBjydcFxnviAxmKo(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void AnRLfPoVHONsiZQh(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool DEmCzesaxEZYkNCu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void FYAaSFzbsfWZNUkd(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void FhDcSXYWivsGtMZt(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void GmHEvgOqtHvOnbjR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void NPvXCauVaqKDFobE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb477373c$pe49014e1 pb477373c_pe49014e1, java.lang.Exception th) {
        pb477373c_pe49014e1.onError(th);
    }

    public static void UuBNXqBAxcGxRags(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void XYWmQDWKTbHItFvd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public override void Dispose() {
        fhDcSXYWivsGtMZt(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return dEmCzesaxEZYkNCu(this.fbc3b0556);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        GSzZgogrpvoHNgIu(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            xYWmQDWKTbHItFvd(th);
        } else {
            this.f6b2ded51 = true;
            uuBNXqBAxcGxRags(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        try {
            if (YBjydcFxnviAxmKo(this.ff670ef68, t)) {
                fYAaSFzbsfWZNUkd(this.fd22a0a80, t);
                return;
            }
            this.f6b2ded51 = true;
            gmHEvgOqtHvOnbjR(this.fbc3b0556);
            PxvwtMjCfHCcDXzd(this.fd22a0a80);
        } catch (java.lang.Exception th) {
            anRLfPoVHONsiZQh(th);
            SNVWKtvCHYrjljwD(this.fbc3b0556);
            nPvXCauVaqKDFobE(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (FiHUHDyGugsKWSyQ(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            SzgMOKUFrFclIYoV(this.fd22a0a80, this);
        }
    }
}

