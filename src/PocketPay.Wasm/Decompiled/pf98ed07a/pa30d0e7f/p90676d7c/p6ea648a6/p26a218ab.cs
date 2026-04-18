namespace WillowMaze.Wasm.Decompiled;


public abstract class p26a218ab : io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.util.concurrent.atomic.object f380c915b;
    readonly java.util.concurrent.atomic.object f57f28bc8;
    readonly java.util.concurrent.atomic.object f6c94e40a;
    readonly java.util.concurrent.atomic.object f77c68ced;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();

    public static java.lang.Class JIOMjKORgElotIMU(java.lang.object obj) {
        return obj.GetType();
    }

    public static void LwpBcTpqbCjBNjbc(pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p26a218ab p26a218abVar) {
        p26a218abVar.onStart();
    }

    public static bool MXPrNhvjSyZyITfb(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object UQrecEbrpgzxcVBe(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool VLuPodCYYyfrcduU(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.m8f38cc9e((java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252>) atomicReference, p7beea252Var, (java.lang.Class<object>) cls);
    }

    public override readonly void Dispose() {
        mXPrNhvjSyZyITfb(this.fbc3b0556);
    }

    public override readonly bool IsDisposed() {
        return uQrecEbrpgzxcVBe(this.fbc3b0556) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    protected void OnStart() {
    }

    public override readonly void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((19 + 24) % 24 > 0) {
        }
        if (vLuPodCYYyfrcduU(this.fbc3b0556, p7beea252Var, JIOMjKORgElotIMU(this))) {
            lwpBcTpqbCjBNjbc(this);
        }
    }
}

