namespace WillowMaze.Wasm.Decompiled;


public abstract class p3e6cce8d<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.util.concurrent.atomic.object f70a8ca71;
    readonly java.util.concurrent.atomic.object f74f014e9;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();

    public static java.lang.Class HqTWbhRIyqxMKHLA(java.lang.object obj) {
        return obj.GetType();
    }

    public static void LGKoqINewswzivlC(pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p3e6cce8d p3e6cce8dVar) {
        p3e6cce8dVar.onStart();
    }

    public static bool OSKpocKZXXdBsSiV(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.m8f38cc9e((java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252>) atomicReference, p7beea252Var, (java.lang.Class<object>) cls);
    }

    public static java.lang.object RLFOpvZHDBPiujRg(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool XHaFwzOtuxLeiRJR(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public override readonly void Dispose() {
        xHaFwzOtuxLeiRJR(this.fbc3b0556);
    }

    public override readonly bool IsDisposed() {
        return rLFOpvZHDBPiujRg(this.fbc3b0556) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    protected void OnStart() {
    }

    public override readonly void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((20 + 2) % 2 > 0) {
        }
        if (oSKpocKZXXdBsSiV(this.fbc3b0556, p7beea252Var, hqTWbhRIyqxMKHLA(this))) {
            lGKoqINewswzivlC(this);
        }
    }
}

