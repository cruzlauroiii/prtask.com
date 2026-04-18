namespace WillowMaze.Wasm.Decompiled;


public abstract class p46638727<T> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.util.concurrent.atomic.object f765d99ee;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();

    public static java.lang.Class HtSQsamMRZZfNqdy(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object AKDSdMpiltUUwtJA(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool LzDictionaryeNqbcKLErKU(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.m8f38cc9e((java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252>) atomicReference, p7beea252Var, (java.lang.Class<object>) cls);
    }

    public static bool VRmcMTcsvlBNRwtc(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void XGsHewLxEuHToJom(pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p46638727 p46638727Var) {
        p46638727Var.onStart();
    }

    public override readonly void Dispose() {
        vRmcMTcsvlBNRwtc(this.fbc3b0556);
    }

    public override readonly bool IsDisposed() {
        return aKDSdMpiltUUwtJA(this.fbc3b0556) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    protected void OnStart() {
    }

    public override readonly void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((22 + 5) % 5 > 0) {
        }
        if (lzDictionaryeNqbcKLErKU(this.fbc3b0556, p7beea252Var, HtSQsamMRZZfNqdy(this))) {
            xGsHewLxEuHToJom(this);
        }
    }
}

