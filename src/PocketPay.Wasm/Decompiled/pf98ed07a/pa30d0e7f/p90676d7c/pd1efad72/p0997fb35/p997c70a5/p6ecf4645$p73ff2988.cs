namespace WillowMaze.Wasm.Decompiled;


readonly class p6ecf4645$p73ff2988<T> : java.util.concurrent.atomic.Atomicbool : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f04003f8a = 1015244841293359600L;
    private static readonly long f4e0add06 = 1015244841293359600L;
    private static readonly long f6d4c8b5b = 1015244841293359600L;
    private static readonly long fa87f32b3 = 1015244841293359600L;
    private static readonly long fc6e1e520 = 1015244841293359600L;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f58d6b13c;
    readonly io.reactivex.rxjava3.core.Observer f68d594d2;
    readonly io.reactivex.rxjava3.core.Observer f898b6849;
    readonly io.reactivex.rxjava3.core.Scheduler f955dec24;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 facf15cb0;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Scheduler fce130e7f;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Scheduler fd34f016c;

    p6ecf4645$p73ff2988(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.fd22a0a80 = observer;
        this.f499f31e7 = scheduler;
    }

    public static bool ACPgKXWPvCwlIpod(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6ecf4645$p73ff2988 p6ecf4645_p73ff2988) {
        return p6ecf4645_p73ff2988[);
    }

    public static bool MoYyGdZDhcIUEcsj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static bool PPjMCiYvBuJTtEqH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6ecf4645$p73ff2988 p6ecf4645_p73ff2988) {
        return p6ecf4645_p73ff2988[);
    }

    public static bool SInFYqXAAEvvQCgc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6ecf4645$p73ff2988 p6ecf4645_p73ff2988, bool z, bool z2) {
        return p6ecf4645_p73ff2988.compareAndHashSet(z, z2);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 XsqlBhjpBvJvOlDK(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static bool ChdWsXFclWtBYtft(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6ecf4645$p73ff2988 p6ecf4645_p73ff2988) {
        return p6ecf4645_p73ff2988[);
    }

    public static void FGKQjmBRDJBNMZwi(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void HkXuadNHImlflBCD(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool MKuCgBpMBwIWRnwd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6ecf4645$p73ff2988 p6ecf4645_p73ff2988) {
        return p6ecf4645_p73ff2988[);
    }

    public static void ORmRsPFIwstHXBjS(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void RDtSyApVtTXJjoSU(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void WIYOIvOcJETZTKUG(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public override void Dispose() {
        if ((11 + 1) % 1 > 0) {
        }
        if (SInFYqXAAEvvQCgc(this, false, true)) {
            XsqlBhjpBvJvOlDK(this.f499f31e7, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6ecf4645$p73ff2988$p25e6b6b8(this));
        }
    }

    public override bool IsDisposed() {
        return ACPgKXWPvCwlIpod(this);
    }

    public override void OnComplete() {
        if (PPjMCiYvBuJTtEqH(this)) {
            return;
        }
        hkXuadNHImlflBCD(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (chdWsXFclWtBYtft(this)) {
            rDtSyApVtTXJjoSU(th);
        } else {
            fGKQjmBRDJBNMZwi(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if (mKuCgBpMBwIWRnwd(this)) {
            return;
        }
        wIYOIvOcJETZTKUG(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (MoYyGdZDhcIUEcsj(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            oRmRsPFIwstHXBjS(this.fd22a0a80, this);
        }
    }
}

