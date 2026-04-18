namespace WillowMaze.Wasm.Decompiled;


public readonly class p44ea2cb0<T> : io.reactivex.rxjava3.core.Observable<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly java.util.concurrent.Func f651a6046;
    readonly java.util.concurrent.Func<? : T> f765d2ec9;
    readonly java.util.concurrent.Func f95a6b0eb;
    readonly java.util.concurrent.Func fefb0767b;

    public p44ea2cb0(java.util.concurrent.Func<? : T> callable) {
        this.f765d2ec9 = callable;
    }

    public static void CxBYjLKyJxMnzpfT(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool FnfTrgdoFRckWLRz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var) {
        return pdcc9ce39Var.isDisposed();
    }

    public static java.lang.object GUDbRtLkgdwrIHUG(java.util.concurrent.Func callable) {
        return callable.call();
    }

    public static bool PwmnJTSDCwJUqmof(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var) {
        return pdcc9ce39Var.isDisposed();
    }

    public static void ZDUCKtSXPyNNSoES(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var, java.lang.object obj) {
        pdcc9ce39Var.complete(obj);
    }

    public static java.lang.object BaaPZoueIWaocRaJ(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void CkLjGlhmAoAxdurx(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void HbKiqjhXYLNwtbEb(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.object TdeJpltlrikLSpnf(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static java.lang.object WdkyZckHELgdBbtE(java.util.concurrent.Func callable) {
        return callable.call();
    }

    public static void XbGKwYPyybBWJQEP(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public T Get() throws java.lang.Exception {
        return (T) baaPZoueIWaocRaJ(GUDbRtLkgdwrIHUG(this.f765d2ec9), "The Func returned a null value.");
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((23 + 4) % 4 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39(observer);
        ckLjGlhmAoAxdurx(observer, pdcc9ce39Var);
        if (PwmnJTSDCwJUqmof(pdcc9ce39Var)) {
            return;
        }
        try {
            ZDUCKtSXPyNNSoES(pdcc9ce39Var, tdeJpltlrikLSpnf(wdkyZckHELgdBbtE(this.f765d2ec9), "Func returned a null value."));
        } catch (java.lang.Exception th) {
            xbGKwYPyybBWJQEP(th);
            if (FnfTrgdoFRckWLRz(pdcc9ce39Var)) {
                hbKiqjhXYLNwtbEb(th);
            } else {
                CxBYjLKyJxMnzpfT(observer, th);
            }
        }
    }
}

