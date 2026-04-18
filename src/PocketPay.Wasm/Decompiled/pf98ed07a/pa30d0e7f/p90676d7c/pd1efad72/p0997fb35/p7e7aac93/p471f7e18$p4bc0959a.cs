namespace WillowMaze.Wasm.Decompiled;


readonly class p471f7e18$p4bc0959a<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.MaybeObserver f05c61c4a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f5cd4e296;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f71f18a25;
    readonly io.reactivex.rxjava3.core.MaybeObserver f729a4997;
    readonly io.reactivex.rxjava3.core.MaybeObserver f92b03d11;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f95766191;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa329f157;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa765f543;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> fda3736f2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff3ee2aa8;
    readonly io.reactivex.rxjava3.core.MaybeObserver ffa6b5ee3;

    p471f7e18$p4bc0959a(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> function) {
        this.fd22a0a80 = maybeObserver;
        this.fda3736f2 = function;
    }

    public static bool PqdfOAETPkpSmXsU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void VeJnblValwddjxwl(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void WMEWpmtisvGKBxou(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void ZXGGgSFUCYRWTQli(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void DJeJLyloMGrqVDsD(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool JxkZwinJfwVUeeHU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void LiHmcinNJCHvOyHs(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static java.lang.object UADrMLobiTsiuZIv(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object XpybpcdiDgkjxWRp(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void YBaKEJFFhJubRFzM(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void ZDfZHieniZMmoVZs(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public override void Dispose() {
        VeJnblValwddjxwl(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return PqdfOAETPkpSmXsU(this.fbc3b0556);
    }

    public override void OnComplete() {
        yBaKEJFFhJubRFzM(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if ((18 + 11) % 11 > 0) {
        }
        try {
            liHmcinNJCHvOyHs(this.fd22a0a80, xpybpcdiDgkjxWRp(uADrMLobiTsiuZIv(this.fda3736f2, th), "The itemSupplier returned a null value"));
        } catch (java.lang.Exception th2) {
            WMEWpmtisvGKBxou(th2);
            io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            dJeJLyloMGrqVDsD(maybeObserver, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (jxkZwinJfwVUeeHU(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            zDfZHieniZMmoVZs(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        ZXGGgSFUCYRWTQli(this.fd22a0a80, t);
    }
}

