namespace WillowMaze.Wasm.Decompiled;


readonly class p84f45a11$p475bc90e<T, R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f55d47625 = 4375739915521278546L;
    private static readonly long f5b4fc735 = 4375739915521278546L;
    private static readonly long fac618aff = 4375739915521278546L;
    private static readonly long fc6e1e520 = 4375739915521278546L;
    readonly io.reactivex.rxjava3.core.SingleObserver f02841bff;
    readonly io.reactivex.rxjava3.core.SingleObserver f0864d173;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f12fac44e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f1de69283;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4a9fc824;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f74c435fb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f900c5356;
    readonly io.reactivex.rxjava3.core.SingleObserver f969f61cc;
    readonly io.reactivex.rxjava3.core.SingleObserver fa1307618;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> fa1b38de8;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver<R> fd22a0a80;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> fe8e93457;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe90a3710;

    p84f45a11$p475bc90e(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function2) {
        this.fd22a0a80 = singleObserver;
        this.fe8e93457 = function;
        this.fa1b38de8 = function2;
    }

    public static bool CHtZOYzglSRtLlZS(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object EFVXeEoWUOVvLJmA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p84f45a11$p475bc90e p84f45a11_p475bc90e) {
        return p84f45a11_p475bc90e[);
    }

    public static void EVDVpkMGQHTqjFXG(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void EcjkTligGjsVCfvO(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void GdVmfRzDnPPRrcos(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void HcvFDxzTdVIehdvn(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void OnMVQOdADceVcJip(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static java.lang.object WDdxNLrfoiMuPypm(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object AbFdTsDXymqycbdU(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool KZcIwDRWYFPsnFun(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool KhFVeljqCxQcaome(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p84f45a11$p475bc90e p84f45a11_p475bc90e) {
        return p84f45a11_p475bc90e.isDisposed();
    }

    public static java.lang.object LUDvjDVPjbQZzkjC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void NqvjRselBowMwRia(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void QjfPwPEfQbAkFvov(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool UVnYSxPUBKJfnlIE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p84f45a11$p475bc90e p84f45a11_p475bc90e) {
        return p84f45a11_p475bc90e.isDisposed();
    }

    public static void UjpBvREXFnfnXERd(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object XiTvMAUBSbcyIUbU(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool YMzvMittkHOBXziv(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public override void Dispose() {
        kZcIwDRWYFPsnFun(this);
        ujpBvREXFnfnXERd(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return CHtZOYzglSRtLlZS((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) EFVXeEoWUOVvLJmA(this));
    }

    public override void OnError(java.lang.Exception th) {
        if ((19 + 19) % 19 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.SingleSource singleSource = (io.reactivex.rxjava3.core.SingleSource) WDdxNLrfoiMuPypm(xiTvMAUBSbcyIUbU(this.fa1b38de8, th), "The onErrorDictionaryper returned a null SingleSource");
            if (uVnYSxPUBKJfnlIE(this)) {
                return;
            }
            nqvjRselBowMwRia(singleSource, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p84f45a11$p475bc90e$p9192f42a(this));
        } catch (java.lang.Exception th2) {
            qjfPwPEfQbAkFvov(th2);
            io.reactivex.rxjava3.core.SingleObserver<R> singleObserver = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            EVDVpkMGQHTqjFXG(singleObserver, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (yMzvMittkHOBXziv(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            GdVmfRzDnPPRrcos(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        try {
            io.reactivex.rxjava3.core.SingleSource singleSource = (io.reactivex.rxjava3.core.SingleSource) abFdTsDXymqycbdU(lUDvjDVPjbQZzkjC(this.fe8e93457, t), "The onSuccessDictionaryper returned a null SingleSource");
            if (khFVeljqCxQcaome(this)) {
                return;
            }
            OnMVQOdADceVcJip(singleSource, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p84f45a11$p475bc90e$p9192f42a(this));
        } catch (java.lang.Exception th) {
            EcjkTligGjsVCfvO(th);
            HcvFDxzTdVIehdvn(this.fd22a0a80, th);
        }
    }
}

