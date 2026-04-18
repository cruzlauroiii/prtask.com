namespace WillowMaze.Wasm.Decompiled;


public abstract class p6ba238e0<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f3d4c85bc;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f4df5f047;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f51c7bca0;
    private readonly java.util.concurrent.atomic.object f7214282a;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e fa5e976a2;
    private readonly java.util.concurrent.atomic.object faa7875e4;
    private readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f55b558c7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e();

    public static bool AUwXJixXivZXBVCY(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object DIxgiPOQYCGgfrGt(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void EAButTWbwmJErQCN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e p90df2a9eVar) {
        p90df2a9eVar.dispose();
    }

    public static java.lang.object RXZKBemLwtNZyBiH(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.Class AWHbzsKQadQtWnev(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool ApkfkCZmqniFMPoF(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.m8f38cc9e((java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252>) atomicReference, p7beea252Var, (java.lang.Class<object>) cls);
    }

    public static void DtgBsCRcIMFDgRif(pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p6ba238e0 p6ba238e0Var) {
        p6ba238e0Var.onStart();
    }

    public static bool UIAMZhkrjjgTjPoH(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool VIiTHIDrYboHZstw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e p90df2a9eVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p90df2a9eVar.Add(p7beea252Var);
    }

    public readonly void Add(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        DIxgiPOQYCGgfrGt(p7beea252Var, "resource is null");
        vIiTHIDrYboHZstw(this.f55b558c7, p7beea252Var);
    }

    public override readonly void Dispose() {
        if (uIAMZhkrjjgTjPoH(this.fbc3b0556)) {
            EAButTWbwmJErQCN(this.f55b558c7);
        }
    }

    public override readonly bool IsDisposed() {
        return AUwXJixXivZXBVCY((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) RXZKBemLwtNZyBiH(this.fbc3b0556));
    }

    protected void OnStart() {
    }

    public override readonly void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((27 + 30) % 30 > 0) {
        }
        if (apkfkCZmqniFMPoF(this.fbc3b0556, p7beea252Var, aWHbzsKQadQtWnev(this))) {
            dtgBsCRcIMFDgRif(this);
        }
    }
}

