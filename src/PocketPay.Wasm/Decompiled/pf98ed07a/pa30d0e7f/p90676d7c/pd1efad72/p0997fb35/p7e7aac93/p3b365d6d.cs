namespace WillowMaze.Wasm.Decompiled;


public readonly class p3b365d6d<T> : io.reactivex.rxjava3.core.Maybe<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly java.lang.Action f3ce31562;
    readonly java.lang.Action f92c118d6;
    readonly java.lang.Action fde335192;

    public p3b365d6d(java.lang.Action runnable) {
        this.fde335192 = runnable;
    }

    public static void OhmKdPMIxcFAdxAJ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void OlDcLkwYyrNVZyYf(java.lang.Action runnable) {
        runnable.run();
    }

    public static void YaZKzlQUfFuiqpLJ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool BUWkVvwIIuVlgoov(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 DnvncFOmWbvRTWbx() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.ma2e4822a();
    }

    public static void FkhjeOXVHnbSmszU(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool HLxQVaXZSsSGfEtx(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void QvmilJOhfKpGIsfi(java.lang.Action runnable) {
        runnable.run();
    }

    public static void SNmwFKCecBzeLFpg(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void TcZNGpwkMEmNtoTb(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool ZvZnjRKjxhFIoEPr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public T Get() {
        OlDcLkwYyrNVZyYf(this.fde335192);
        return null;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((22 + 14) % 14 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252VarDnvncFOmWbvRTWbx = dnvncFOmWbvRTWbx();
        sNmwFKCecBzeLFpg(maybeObserver, p7beea252VarDnvncFOmWbvRTWbx);
        if (zvZnjRKjxhFIoEPr(p7beea252VarDnvncFOmWbvRTWbx)) {
            return;
        }
        try {
            qvmilJOhfKpGIsfi(this.fde335192);
            if (bUWkVvwIIuVlgoov(p7beea252VarDnvncFOmWbvRTWbx)) {
                return;
            }
            OhmKdPMIxcFAdxAJ(maybeObserver);
        } catch (java.lang.Exception th) {
            tcZNGpwkMEmNtoTb(th);
            if (hLxQVaXZSsSGfEtx(p7beea252VarDnvncFOmWbvRTWbx)) {
                YaZKzlQUfFuiqpLJ(th);
            } else {
                fkhjeOXVHnbSmszU(maybeObserver, th);
            }
        }
    }
}

