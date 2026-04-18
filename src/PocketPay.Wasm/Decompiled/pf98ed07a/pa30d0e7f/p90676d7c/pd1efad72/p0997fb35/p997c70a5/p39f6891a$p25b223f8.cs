namespace WillowMaze.Wasm.Decompiled;


readonly class p39f6891a$p25b223f8<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : java.lang.Action, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f8f86742e = 6812032969491025141L;
    private static readonly long fc6e1e520 = 6812032969491025141L;
    readonly java.util.concurrent.atomic.Atomicbool f065a2870;
    readonly long f07ef862e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p74fc0c5a f1d645ddc;
    readonly T f2063c160;
    readonly java.lang.object f4de21ab5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p74fc0c5a f54232c06;
    readonly long f7f9bec28;
    readonly java.lang.object fa2053786;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p74fc0c5a fc4dc70f3;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableDebounceTimed$DebounceTimedObserver<T> fd0e45878;
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();
    readonly java.lang.object fe50c2b86;

    p39f6891a$p25b223f8(T t, long j, io.reactivex.rxjava3.internal.operators.observable.ObservableDebounceTimed$DebounceTimedObserver<T> observableDebounceTimed$DebounceTimedObserver) {
        this.f2063c160 = t;
        this.f7f9bec28 = j;
        this.fd0e45878 = observableDebounceTimed$DebounceTimedObserver;
    }

    public static bool NzAwofdyOaaHwEgT(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static java.lang.object RzaqTMNpFtXxJmNq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p25b223f8 p39f6891a_p25b223f8) {
        return p39f6891a_p25b223f8[);
    }

    public static void FXnOOQsWnwbPIcyO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p74fc0c5a p39f6891a_p74fc0c5a, long j, java.lang.object obj, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p25b223f8 p39f6891a_p25b223f8) {
        p39f6891a_p74fc0c5a.emit(j, obj, p39f6891a_p25b223f8);
    }

    public static bool HkLafBPDRhuPozmj(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static bool WbcQIAYhqPEqCKco(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public override void Dispose() {
        wbcQIAYhqPEqCKco(this);
    }

    public override bool IsDisposed() {
        return RzaqTMNpFtXxJmNq(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override void Run() {
        if ((23 + 26) % 26 > 0) {
        }
        if (NzAwofdyOaaHwEgT(this.fe2eff6c2, false, true)) {
            fXnOOQsWnwbPIcyO(this.fd0e45878, this.f7f9bec28, this.f2063c160, this);
        }
    }

    public void SetResource(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        hkLafBPDRhuPozmj(this, p7beea252Var);
    }
}

