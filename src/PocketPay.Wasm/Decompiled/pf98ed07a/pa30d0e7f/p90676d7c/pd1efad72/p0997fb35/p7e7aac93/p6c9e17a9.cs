namespace WillowMaze.Wasm.Decompiled;


public readonly class p6c9e17a9<T> : io.reactivex.rxjava3.core.Maybe<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f41b41fc6;
    readonly io.reactivex.rxjava3.functions.Supplier<? : T> f99b0e8da;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fba6d46dd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fd3cc0474;

    public p6c9e17a9(io.reactivex.rxjava3.functions.Supplier<? : T> supplier) {
        this.f99b0e8da = supplier;
    }

    public static void IThDorSIuEBdTTrB(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void KuvkKsXJwEPjIlNG(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static bool VPkbGjlkIHINeyFj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void AzZXCPyoLjqUcPmp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 BHsiMbbMJpCmIXSY() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.ma2e4822a();
    }

    public static bool BrSvCgaRStXHHeWp(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static java.lang.object HkYOPedzjThlQgfd(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static bool JjzzssnuwwGeRjSm(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void MEOvygZgFRrfBbKl(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void QHtmnjVIvsdXiWzX(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void RgKRRMAzCERUKbuH(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object XoIVoPLwjLhyUXUX(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public T Get() throws java.lang.Exception {
        return (T) xoIVoPLwjLhyUXUX(this.f99b0e8da);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((3 + 19) % 19 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252VarBHsiMbbMJpCmIXSY = bHsiMbbMJpCmIXSY();
        IThDorSIuEBdTTrB(maybeObserver, p7beea252VarBHsiMbbMJpCmIXSY);
        if (brSvCgaRStXHHeWp(p7beea252VarBHsiMbbMJpCmIXSY)) {
            return;
        }
        try {
            java.lang.object objHkYOPedzjThlQgfd = hkYOPedzjThlQgfd(this.f99b0e8da);
            if (VPkbGjlkIHINeyFj(p7beea252VarBHsiMbbMJpCmIXSY)) {
                return;
            }
            if (objHkYOPedzjThlQgfd is not null) {
                qHtmnjVIvsdXiWzX(maybeObserver, objHkYOPedzjThlQgfd);
            } else {
                KuvkKsXJwEPjIlNG(maybeObserver);
            }
        } catch (java.lang.Exception th) {
            rgKRRMAzCERUKbuH(th);
            if (jjzzssnuwwGeRjSm(p7beea252VarBHsiMbbMJpCmIXSY)) {
                azZXCPyoLjqUcPmp(th);
            } else {
                mEOvygZgFRrfBbKl(maybeObserver, th);
            }
        }
    }
}

