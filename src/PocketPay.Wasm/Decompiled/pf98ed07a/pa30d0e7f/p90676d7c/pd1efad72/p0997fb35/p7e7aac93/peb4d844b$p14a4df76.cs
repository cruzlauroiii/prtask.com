namespace WillowMaze.Wasm.Decompiled;


readonly class peb4d844b$p14a4df76<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f07f41314 = 4603919676453758899L;
    private static readonly long f25326e29 = 4603919676453758899L;
    private static readonly long f9ba6ce83 = 4603919676453758899L;
    private static readonly long fc6e1e520 = 4603919676453758899L;
    readonly io.reactivex.rxjava3.core.SingleObserver f0db2280d;
    readonly io.reactivex.rxjava3.core.SingleObserver f297ffe43;
    readonly io.reactivex.rxjava3.core.SingleObserver f2d651a59;
    readonly io.reactivex.rxjava3.core.SingleObserver f3a73d1b8;
    readonly io.reactivex.rxjava3.core.SingleSource f598673ed;
    readonly io.reactivex.rxjava3.core.SingleSource f6ab881b1;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f795f3202;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;

    peb4d844b$p14a4df76(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        this.fd22a0a80 = singleObserver;
        this.f795f3202 = singleSource;
    }

    public static java.lang.object DKYbnsayfepxqARv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.peb4d844b$p14a4df76 peb4d844b_p14a4df76) {
        return peb4d844b_p14a4df76[);
    }

    public static void DKxxykkAvqBRRlYx(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static bool EbVkMtFwrRBudeAg(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool TizNzVLvpOhXtgzN(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object VECjMNrYyrXBBMqH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.peb4d844b$p14a4df76 peb4d844b_p14a4df76) {
        return peb4d844b_p14a4df76[);
    }

    public static void WINHNzTGvDTairuc(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void FlMUJHgzQlstafhK(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void NzhxVVCQHUJcZtlT(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool PEEbipBcoukWlgUR(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool UaFoLjrpBedluIcn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.peb4d844b$p14a4df76 peb4d844b_p14a4df76, java.lang.object obj, java.lang.object obj2) {
        return peb4d844b_p14a4df76.compareAndHashSet(obj, obj2);
    }

    public override void Dispose() {
        pEEbipBcoukWlgUR(this);
    }

    public override bool IsDisposed() {
        return TizNzVLvpOhXtgzN((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) VECjMNrYyrXBBMqH(this));
    }

    public override void OnComplete() {
        if ((6 + 3) % 3 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) DKYbnsayfepxqARv(this);
        if (p7beea252Var != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8 && uaFoLjrpBedluIcn(this, p7beea252Var, null)) {
            DKxxykkAvqBRRlYx(this.f795f3202, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.peb4d844b$p14a4df76$pf3c929b6(this.fd22a0a80, this));
        }
    }

    public override void OnError(java.lang.Exception th) {
        flMUJHgzQlstafhK(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (EbVkMtFwrRBudeAg(this, p7beea252Var)) {
            WINHNzTGvDTairuc(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        nzhxVVCQHUJcZtlT(this.fd22a0a80, t);
    }
}

