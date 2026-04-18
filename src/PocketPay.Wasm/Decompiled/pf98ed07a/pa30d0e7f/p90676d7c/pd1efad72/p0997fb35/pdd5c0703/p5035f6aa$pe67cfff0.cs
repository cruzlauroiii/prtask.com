namespace WillowMaze.Wasm.Decompiled;


readonly class p5035f6aa$pe67cfff0<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long f463b5503 = 3528003840217436037L;
    private static readonly long fc6e1e520 = 3528003840217436037L;
    java.lang.object f07dbab1b;
    T f2063c160;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    java.lang.Exception f50cb4d49;
    readonly io.reactivex.rxjava3.core.SingleObserver f57655578;
    readonly io.reactivex.rxjava3.core.SingleObserver f8600cbb9;
    readonly io.reactivex.rxjava3.core.SingleObserver fa69f422a;
    readonly io.reactivex.rxjava3.core.Scheduler fc558d64a;
    java.lang.Exception fcb5e100e;
    java.lang.object fce23a9d1;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;

    p5035f6aa$pe67cfff0(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.fd22a0a80 = singleObserver;
        this.f499f31e7 = scheduler;
    }

    public static java.lang.object DXOjfziXfqpOOtoM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p5035f6aa$pe67cfff0 p5035f6aa_pe67cfff0) {
        return p5035f6aa_pe67cfff0[);
    }

    public static void MspSttXfQLdNpFDp(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool ZmofyJkloLZXgTRT(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 DUWlJELTePhsKVwj(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static bool DnSNmXxCGcyLBzvf(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void IyaWMHTGCZvCWzgu(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool LfuKATeDqAjuUfIn(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static bool MkoCWBddwnvMJFpq(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool VDeHryqXneXCOHSX(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ZXBGuTNFBCWONgxT(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static void ZqLRAffIMmoijLsi(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public override void Dispose() {
        mkoCWBddwnvMJFpq(this);
    }

    public override bool IsDisposed() {
        return ZmofyJkloLZXgTRT((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) DXOjfziXfqpOOtoM(this));
    }

    public override void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        dnSNmXxCGcyLBzvf(this, zXBGuTNFBCWONgxT(this.f499f31e7, this));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (vDeHryqXneXCOHSX(this, p7beea252Var)) {
            zqLRAffIMmoijLsi(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        this.f2063c160 = t;
        lfuKATeDqAjuUfIn(this, dUWlJELTePhsKVwj(this.f499f31e7, this));
    }

    public override void Run() {
        java.lang.Exception th = this.fcb5e100e;
        if (th is null) {
            iyaWMHTGCZvCWzgu(this.fd22a0a80, this.f2063c160);
        } else {
            MspSttXfQLdNpFDp(this.fd22a0a80, th);
        }
    }
}

