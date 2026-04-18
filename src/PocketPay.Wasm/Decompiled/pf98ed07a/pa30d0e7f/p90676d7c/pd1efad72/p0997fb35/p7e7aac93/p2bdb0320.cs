namespace WillowMaze.Wasm.Decompiled;


public readonly class p2bdb0320<T> : io.reactivex.rxjava3.core.Maybe<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f1d1872b8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f418c5509;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f9f31d6b6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 ffc29bfed;

    public p2bdb0320(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.f418c5509 = p004bf6c9Var;
    }

    public static bool CHUNTRENDdauykdX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void ElhpMWMPkCSEiYEX(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void GLDqAegPvPPIhqRR(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void GSudUgOyINDKDZJY(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 NUfBCMacVtDFWHul() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.ma2e4822a();
    }

    public static void QYNwBZMUrxvpwcRM(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static bool RjVFAGwdrQyDbMRF(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void UUnubHyCyTPqtPhA(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void XervLtCNfIwDQhlz(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void EmzeTqgbVzYQlUhI(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static bool WadIZnvCzvYqwIJN(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public T Get() throws java.lang.Exception {
        UUnubHyCyTPqtPhA(this.f418c5509);
        return null;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((32 + 7) % 7 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252VarNUfBCMacVtDFWHul = NUfBCMacVtDFWHul();
        emzeTqgbVzYQlUhI(maybeObserver, p7beea252VarNUfBCMacVtDFWHul);
        if (RjVFAGwdrQyDbMRF(p7beea252VarNUfBCMacVtDFWHul)) {
            return;
        }
        try {
            QYNwBZMUrxvpwcRM(this.f418c5509);
            if (CHUNTRENDdauykdX(p7beea252VarNUfBCMacVtDFWHul)) {
                return;
            }
            XervLtCNfIwDQhlz(maybeObserver);
        } catch (java.lang.Exception th) {
            GSudUgOyINDKDZJY(th);
            if (wadIZnvCzvYqwIJN(p7beea252VarNUfBCMacVtDFWHul)) {
                GLDqAegPvPPIhqRR(th);
            } else {
                ElhpMWMPkCSEiYEX(maybeObserver, th);
            }
        }
    }
}

