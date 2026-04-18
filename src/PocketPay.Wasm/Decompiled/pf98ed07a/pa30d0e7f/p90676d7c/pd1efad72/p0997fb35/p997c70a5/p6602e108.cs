namespace WillowMaze.Wasm.Decompiled;


public readonly class p6602e108<T> : io.reactivex.rxjava3.core.Observable<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f3ca597d1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f418c5509;

    public p6602e108(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.f418c5509 = p004bf6c9Var;
    }

    public static bool AdCTaTmkEJNtYTPe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static void FHpXMjUWToBQzDfz(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void GDHPysWZVNoAUrYg(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void GkmGaLqJdwAYiViF(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool JVZsueiTPkwCcXeD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static bool YeFBvWgnuriCLHaz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static void CVRGYJFAsFTzqlVs(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void EzhgJgwAQoqiWmLd(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void GikdmVZkoscNiPyq(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void MCflfrphDJVBskNA(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public T Get() throws java.lang.Exception {
        ezhgJgwAQoqiWmLd(this.f418c5509);
        return null;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((6 + 23) % 23 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025();
        FHpXMjUWToBQzDfz(observer, p9ec25025Var);
        if (JVZsueiTPkwCcXeD(p9ec25025Var)) {
            return;
        }
        try {
            gikdmVZkoscNiPyq(this.f418c5509);
            if (YeFBvWgnuriCLHaz(p9ec25025Var)) {
                return;
            }
            cVRGYJFAsFTzqlVs(observer);
        } catch (java.lang.Exception th) {
            GDHPysWZVNoAUrYg(th);
            if (AdCTaTmkEJNtYTPe(p9ec25025Var)) {
                mCflfrphDJVBskNA(th);
            } else {
                GkmGaLqJdwAYiViF(observer, th);
            }
        }
    }
}

