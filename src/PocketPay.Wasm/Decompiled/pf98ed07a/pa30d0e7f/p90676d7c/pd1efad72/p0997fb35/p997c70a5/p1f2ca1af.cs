namespace WillowMaze.Wasm.Decompiled;


public readonly class p1f2ca1af<T> : io.reactivex.rxjava3.core.Observable<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f724fd126;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f7cb6adda;
    readonly io.reactivex.rxjava3.functions.Supplier<? : T> f99b0e8da;

    public p1f2ca1af(io.reactivex.rxjava3.functions.Supplier<? : T> supplier) {
        this.f99b0e8da = supplier;
    }

    public static java.lang.object BMgKqOqGVNuuqRad(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static java.lang.object EKgpvSnHedeQJNBD(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void OcIIUmSAdlOdqaXD(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void WwxvjPAGKMRRtmWs(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void AiLZkkfOYWClrHvx(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool GUcJPDFcemJKCXZW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var) {
        return pdcc9ce39Var.isDisposed();
    }

    public static java.lang.object JSsJGRIZvUxRhWIt(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void SAetCXmuhHxCSXSr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var, java.lang.object obj) {
        pdcc9ce39Var.complete(obj);
    }

    public static java.lang.object UbdkrhQYpecahGPa(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void WJXsZyMUTRnZuBec(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool XnPxCFqFNDzIGPMf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var) {
        return pdcc9ce39Var.isDisposed();
    }

    public T Get() throws java.lang.Exception {
        return (T) ubdkrhQYpecahGPa(BMgKqOqGVNuuqRad(this.f99b0e8da), "The supplier returned a null value.");
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((12 + 26) % 26 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39(observer);
        WwxvjPAGKMRRtmWs(observer, pdcc9ce39Var);
        if (gUcJPDFcemJKCXZW(pdcc9ce39Var)) {
            return;
        }
        try {
            sAetCXmuhHxCSXSr(pdcc9ce39Var, EKgpvSnHedeQJNBD(jSsJGRIZvUxRhWIt(this.f99b0e8da), "Supplier returned a null value."));
        } catch (java.lang.Exception th) {
            OcIIUmSAdlOdqaXD(th);
            if (xnPxCFqFNDzIGPMf(pdcc9ce39Var)) {
                aiLZkkfOYWClrHvx(th);
            } else {
                wJXsZyMUTRnZuBec(observer, th);
            }
        }
    }
}

