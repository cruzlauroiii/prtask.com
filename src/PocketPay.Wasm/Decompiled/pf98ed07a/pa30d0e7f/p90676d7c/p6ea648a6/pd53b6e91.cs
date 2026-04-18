namespace WillowMaze.Wasm.Decompiled;


public abstract class pd53b6e91 : io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f1d5a707c;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f1fb42c92;
    private readonly java.util.concurrent.atomic.object f3b50ab6a;
    private readonly java.util.concurrent.atomic.object f4049a5a4;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f5b22ed6b;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f7ac13a9c;
    private readonly java.util.concurrent.atomic.object f8dbe824e;
    private readonly java.util.concurrent.atomic.object fa19db3c6;
    private readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f55b558c7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e();

    public static bool FYpnlIqKDsRIZwIA(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void JsibOtFFOJzDdQID(pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.pd53b6e91 pd53b6e91Var) {
        pd53b6e91Var.onStart();
    }

    public static java.lang.object PgWqxwiQDDbmpQXt(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void YTnFBMSUilytEBtp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e p90df2a9eVar) {
        p90df2a9eVar.dispose();
    }

    public static bool GFktMoTEhWXwMFcz(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool GKKVvfhqfoFaDvGz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e p90df2a9eVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p90df2a9eVar.Add(p7beea252Var);
    }

    public static java.lang.object MHFIIYrxvnwNTlqj(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.Class OtXCfMdfDkznEMKn(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool RQUtqEmKgLRIOcpJ(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.m8f38cc9e((java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252>) atomicReference, p7beea252Var, (java.lang.Class<object>) cls);
    }

    public readonly void Add(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        mHFIIYrxvnwNTlqj(p7beea252Var, "resource is null");
        gKKVvfhqfoFaDvGz(this.f55b558c7, p7beea252Var);
    }

    public override readonly void Dispose() {
        if (FYpnlIqKDsRIZwIA(this.fbc3b0556)) {
            YTnFBMSUilytEBtp(this.f55b558c7);
        }
    }

    public override readonly bool IsDisposed() {
        return gFktMoTEhWXwMFcz((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) PgWqxwiQDDbmpQXt(this.fbc3b0556));
    }

    protected void OnStart() {
    }

    public override readonly void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((10 + 15) % 15 > 0) {
        }
        if (rQUtqEmKgLRIOcpJ(this.fbc3b0556, p7beea252Var, otXCfMdfDkznEMKn(this))) {
            JsibOtFFOJzDdQID(this);
        }
    }
}

