namespace WillowMaze.Wasm.Decompiled;


readonly class p550d897b$pa453bafa<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long f6bbfe58b = 7000911171163930287L;
    private static readonly long f9cea6c5b = 7000911171163930287L;
    private static readonly long fc6e1e520 = 7000911171163930287L;
    readonly io.reactivex.rxjava3.core.SingleSource f227eda69;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f290be0c5;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f39792b03;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f478f3a4c = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
    readonly io.reactivex.rxjava3.core.SingleObserver f5b436583;
    readonly io.reactivex.rxjava3.core.SingleSource f67ee0c5f;
    readonly io.reactivex.rxjava3.core.SingleObserver f984d6bb9;
    readonly io.reactivex.rxjava3.core.SingleSource fa07acba2;
    readonly io.reactivex.rxjava3.core.SingleObserver fb1b03118;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver feac250be;

    p550d897b$pa453bafa(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        this.fd22a0a80 = singleObserver;
        this.f36cd38f4 = singleSource;
    }

    public static bool KnnUkBghHtRZyptw(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool MGojrbpgSzPLzFkj(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object QIKneHwVYsTejfHD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p550d897b$pa453bafa p550d897b_pa453bafa) {
        return p550d897b_pa453bafa[);
    }

    public static void SgJWKihxACEjbPGH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static bool VRlYLwFywCAfuJeR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void LkOSPYLOXQpcAnZl(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void LrgOOKHPNDfrhbZy(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void XjhxkCOljsQrTsgN(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public override void Dispose() {
        MGojrbpgSzPLzFkj(this);
        SgJWKihxACEjbPGH(this.f478f3a4c);
    }

    public override bool IsDisposed() {
        return VRlYLwFywCAfuJeR((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) QIKneHwVYsTejfHD(this));
    }

    public override void OnError(java.lang.Exception th) {
        lkOSPYLOXQpcAnZl(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        KnnUkBghHtRZyptw(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        lrgOOKHPNDfrhbZy(this.fd22a0a80, t);
    }

    public override void Run() {
        xjhxkCOljsQrTsgN(this.f36cd38f4, this);
    }
}

