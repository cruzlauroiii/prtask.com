namespace WillowMaze.Wasm.Decompiled;


public abstract class p323bc2dd<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.util.concurrent.atomic.object f7fa62b5b;
    readonly java.util.concurrent.atomic.object f8bdfb899;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();

    public static void AnmYqkXNZBdVsfkF(pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p323bc2dd p323bc2ddVar) {
        p323bc2ddVar.onStart();
    }

    public static bool BuzHTZYjzBQHSbtY(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object HgPbnogadKtwLbBi(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool TVplrrJiqnYMTgWA(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.m8f38cc9e((java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252>) atomicReference, p7beea252Var, (java.lang.Class<object>) cls);
    }

    public static java.lang.Class UlSwhFHQosufUHLN(java.lang.object obj) {
        return obj.GetType();
    }

    public override readonly void Dispose() {
        buzHTZYjzBQHSbtY(this.fbc3b0556);
    }

    public override readonly bool IsDisposed() {
        return hgPbnogadKtwLbBi(this.fbc3b0556) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    protected void OnStart() {
    }

    public override readonly void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((17 + 5) % 5 > 0) {
        }
        if (tVplrrJiqnYMTgWA(this.fbc3b0556, p7beea252Var, ulSwhFHQosufUHLN(this))) {
            anmYqkXNZBdVsfkF(this);
        }
    }
}

