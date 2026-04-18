namespace WillowMaze.Wasm.Decompiled;


readonly class p0de4c479$p1fc0aadb<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.functions.Consumer<T> f22a1f716;
    readonly io.reactivex.rxjava3.core.MaybeObserver f2aca737a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f4719bf5f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f9d38e6cc;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver fc1007b21;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fcae5d493;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fcd933e51;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fce6e369a;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdbf1ca5b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 ff3d590dd;

    p0de4c479$p1fc0aadb(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.functions.Consumer<T> consumer) {
        this.fd22a0a80 = maybeObserver;
        this.f22a1f716 = consumer;
    }

    public static bool GZIBsWGlPSfLUvzJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void GeNApjlOBqgFfyQt(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void IbooXJjfDsBwMSLx(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void KCiZQxyiaGpxqEgS(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void KjNbbugkTAXlYQMT(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static bool ZVIkpPnHdGlfuXXg(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void CgprFBmhtqpYxLsH(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void IrbkeBtgpFYLafib(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void OijckhxyjmUbwNey(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void PmzUgGUYzwXTMeOl(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public override void Dispose() {
        GeNApjlOBqgFfyQt(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return ZVIkpPnHdGlfuXXg(this.fbc3b0556);
    }

    public override void OnComplete() {
        KjNbbugkTAXlYQMT(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        IbooXJjfDsBwMSLx(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (GZIBsWGlPSfLUvzJ(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            irbkeBtgpFYLafib(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        pmzUgGUYzwXTMeOl(this.fd22a0a80, t);
        try {
            cgprFBmhtqpYxLsH(this.f22a1f716, t);
        } catch (java.lang.Exception th) {
            KCiZQxyiaGpxqEgS(th);
            oijckhxyjmUbwNey(th);
        }
    }
}

