namespace WillowMaze.Wasm.Decompiled;


abstract class pac58da9c$pf477d37a<T> : java.util.concurrent.atomic.object<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long f03a905a7 = -3517602651313910099L;
    private static readonly long f1c8a7e1e = -3517602651313910099L;
    private static readonly long f98c5b1f2 = -3517602651313910099L;
    private static readonly long fc6e1e520 = -3517602651313910099L;
    private static readonly long ff257784b = -3517602651313910099L;
    readonly java.util.concurrent.TimeUnit f026633e8;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f2c127bf3 = new java.util.concurrent.atomic.object<>();
    readonly io.reactivex.rxjava3.core.Observer f2f6d6a42;
    readonly io.reactivex.rxjava3.core.Observer f30fa6481;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f6064ff25;
    readonly long f6a78e1c7;
    readonly java.util.concurrent.atomic.object f6e30a57c;
    readonly long f735bdd43;
    readonly io.reactivex.rxjava3.core.Observer f7ec1e349;
    readonly io.reactivex.rxjava3.core.Scheduler f811a0d92;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f8db002b3;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f9c5b66fc;
    readonly long fa0acfa46;
    readonly java.util.concurrent.TimeUnit fa37f39e1;
    readonly long faa21c423;
    readonly java.util.concurrent.TimeUnit fab913e8a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Scheduler fc45af1e0;
    readonly java.util.concurrent.atomic.object fca7c0fa1;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;

    pac58da9c$pf477d37a(io.reactivex.rxjava3.core.Observer<T> observer, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.fd22a0a80 = observer;
        this.fa0acfa46 = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static bool BAlRBDrPfVezjBTK(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void DQuLoYRWVqFkIpYv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac58da9c$pf477d37a pac58da9c_pf477d37a) {
        pac58da9c_pf477d37a.cancelTimer();
    }

    public static void GmRSrrNyOjmUukKJ(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void IQoYXPmHOlUjFePY(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void MjVALUUDkdElDxWG(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void SDPrnQHytltnyCwZ(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool VOEsCOdOpNlZjwrr(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void XVwPydkJxOKlRtlz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac58da9c$pf477d37a pac58da9c_pf477d37a) {
        pac58da9c_pf477d37a.complete();
    }

    public static void BycErWZEJryUqqtH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac58da9c$pf477d37a pac58da9c_pf477d37a) {
        pac58da9c_pf477d37a.cancelTimer();
    }

    public static bool IJdkHHBjTprRRkZb(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static java.lang.object KjsHxfwCSRSKhDnk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac58da9c$pf477d37a pac58da9c_pf477d37a, java.lang.object obj) {
        return pac58da9c_pf477d37a.getAndHashSet(obj);
    }

    public static bool LMmoUPQZZLOcooMv(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void WeYuWpzVWFSSXifR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac58da9c$pf477d37a pac58da9c_pf477d37a, java.lang.object obj) {
        pac58da9c_pf477d37a.lazyHashSet(obj);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 YHatLFoyFRxiRNxH(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.schedulePeriodicallyDirect(runnable, j, j2, timeUnit);
    }

    public static void ZIlZhopNKxRDSdct(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac58da9c$pf477d37a pac58da9c_pf477d37a) {
        pac58da9c_pf477d37a.cancelTimer();
    }

    void cancelTimer() {
        VOEsCOdOpNlZjwrr(this.f2c127bf3);
    }

    abstract void Complete();

    public override void Dispose() {
        DQuLoYRWVqFkIpYv(this);
        IQoYXPmHOlUjFePY(this.fbc3b0556);
    }

    void emit() {
        java.lang.object objKjsHxfwCSRSKhDnk = kjsHxfwCSRSKhDnk(this, null);
        if (objKjsHxfwCSRSKhDnk is null) {
            return;
        }
        SDPrnQHytltnyCwZ(this.fd22a0a80, objKjsHxfwCSRSKhDnk);
    }

    public override bool IsDisposed() {
        return iJdkHHBjTprRRkZb(this.fbc3b0556);
    }

    public override void OnComplete() {
        bycErWZEJryUqqtH(this);
        XVwPydkJxOKlRtlz(this);
    }

    public override void OnError(java.lang.Exception th) {
        zIlZhopNKxRDSdct(this);
        GmRSrrNyOjmUukKJ(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        weYuWpzVWFSSXifR(this, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((16 + 1) % 1 > 0) {
        }
        if (lMmoUPQZZLOcooMv(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            MjVALUUDkdElDxWG(this.fd22a0a80, this);
            io.reactivex.rxjava3.core.Scheduler scheduler = this.f499f31e7;
            long j = this.fa0acfa46;
            BAlRBDrPfVezjBTK(this.f2c127bf3, yHatLFoyFRxiRNxH(scheduler, this, j, j, this.f3e34bdeb));
        }
    }
}

