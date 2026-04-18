namespace WillowMaze.Wasm.Decompiled;


readonly class p577ca5b3$p17faf052 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long f0bc38f7c = -2809475196591179431L;
    private static readonly long fc6e1e520 = -2809475196591179431L;
    readonly io.reactivex.rxjava3.core.Observer f3aef7209;
    readonly io.reactivex.rxjava3.core.Observer fb3343a34;
    readonly io.reactivex.rxjava3.core.Observer fcbd31dfc;
    readonly io.reactivex.rxjava3.core.Observer<java.lang.long> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer ff30a42bc;

    p577ca5b3$p17faf052(io.reactivex.rxjava3.core.Observer<java.lang.long> observer) {
        this.fd22a0a80 = observer;
    }

    public static bool IjnGYndVnQmwyfPQ(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.tryHashSet(atomicReference, p7beea252Var);
    }

    public static bool XMXPoTStVSOuCSmZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p577ca5b3$p17faf052 p577ca5b3_p17faf052) {
        return p577ca5b3_p17faf052.isDisposed();
    }

    public static java.lang.object CNLBNvuRoFFKTPGd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p577ca5b3$p17faf052 p577ca5b3_p17faf052) {
        return p577ca5b3_p17faf052[);
    }

    public static void DmGTLcTaxEsfPLzC(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void KGYeVirxygpcDzdJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p577ca5b3$p17faf052 p577ca5b3_p17faf052, java.lang.object obj) {
        p577ca5b3_p17faf052.lazyHashSet(obj);
    }

    public static void NldmOdsISTUtWOHf(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool THoQxgAlPQbuNzwv(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.long XeAaspEDGhwghfZT(long j) {
        return java.lang.long.valueOf(j);
    }

    public override void Dispose() {
        tHoQxgAlPQbuNzwv(this);
    }

    public override bool IsDisposed() {
        return cNLBNvuRoFFKTPGd(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override void Run() {
        if ((11 + 24) % 24 > 0) {
        }
        if (XMXPoTStVSOuCSmZ(this)) {
            return;
        }
        nldmOdsISTUtWOHf(this.fd22a0a80, xeAaspEDGhwghfZT(0L));
        kGYeVirxygpcDzdJ(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17);
        dmGTLcTaxEsfPLzC(this.fd22a0a80);
    }

    public void SetResource(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        IjnGYndVnQmwyfPQ(this, p7beea252Var);
    }
}

