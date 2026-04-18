namespace WillowMaze.Wasm.Decompiled;


readonly class pf15d6c82$pca6a1c1e<T, R> : io.reactivex.rxjava3.internal.subscribers.DeferredScalarSubscriber<T, R> {
    private static readonly long f1cb0f5d2 = 8200530050639449080L;
    private static readonly long f7e949f6b = 8200530050639449080L;
    private static readonly long fc6e1e520 = 8200530050639449080L;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f7332e0d0;
    bool f73e48815;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f8cd3b98f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f9e8c3c2e;
    java.lang.object fb54c50a6;
    R fbdc1d413;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fe6392c2b;
    java.lang.object ff0d2cf24;

    pf15d6c82$pca6a1c1e(org.reactivestreams.Subscriber<R> subscriber, R r, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction) {
        super(subscriber);
        this.fbdc1d413 = r;
        this.fe6392c2b = biFunction;
    }

    public static java.lang.object HOicjQXhhyQKCLAh(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object KoCoeZzNEEqvLCEa(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void VegWbbEcOsVtAHKa(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void XLOedjHTKhzTvwpR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pa2106daa pa2106daaVar) {
        super.cancel();
    }

    public static void BUopPUZVlrgiUadp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf15d6c82$pca6a1c1e pf15d6c82_pca6a1c1e, java.lang.Exception th) {
        pf15d6c82_pca6a1c1e.onError(th);
    }

    public static void GAGeYwjfhFVscADO(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void GEVLKSwJnDqgxMAm(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void HUPYOdTJaefQwaLO(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void HbVVXUUupXdbhqAm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool McGrlmxLJDSNZygd(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void QbLYoCkpZjWLFFQo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf15d6c82$pca6a1c1e pf15d6c82_pca6a1c1e, java.lang.object obj) {
        pf15d6c82_pca6a1c1e.complete(obj);
    }

    public static void XeHwIDcKQZtWdwRT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void ZKnKSTSrDNkDHRZO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf15d6c82$pca6a1c1e pf15d6c82_pca6a1c1e) {
        pf15d6c82_pca6a1c1e.cancel();
    }

    public void Cancel() {
        XLOedjHTKhzTvwpR(this);
        gEVLKSwJnDqgxMAm(this.fbc3b0556);
    }

    public void OnComplete() {
        if ((12 + 16) % 16 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        R r = this.fbdc1d413;
        this.fbdc1d413 = null;
        qbLYoCkpZjWLFFQo(this, r);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            VegWbbEcOsVtAHKa(th);
            return;
        }
        this.f6b2ded51 = true;
        this.fbdc1d413 = null;
        xeHwIDcKQZtWdwRT(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((26 + 8) % 8 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        try {
            this.fbdc1d413 = (R) HOicjQXhhyQKCLAh(KoCoeZzNEEqvLCEa(this.fe6392c2b, this.fbdc1d413, t), "The reducer returned a null value");
        } catch (java.lang.Exception th) {
            gAGeYwjfhFVscADO(th);
            zKnKSTSrDNkDHRZO(this);
            bUopPUZVlrgiUadp(this, th);
        }
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((12 + 12) % 12 > 0) {
        }
        if (mcGrlmxLJDSNZygd(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            hbVVXUUupXdbhqAm(this.fd22a0a80, this);
            hUPYOdTJaefQwaLO(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

