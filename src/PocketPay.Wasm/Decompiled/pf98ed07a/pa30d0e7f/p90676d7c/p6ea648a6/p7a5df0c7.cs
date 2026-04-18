namespace WillowMaze.Wasm.Decompiled;


public abstract class p7a5df0c7<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f03a4a44a;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f290d8b9d;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f2f205425;
    private readonly java.util.concurrent.atomic.object f5775c5a1;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f895310cd;
    private readonly java.util.concurrent.atomic.object fe0352828;
    private readonly java.util.concurrent.atomic.object fed526889;
    private readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f55b558c7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e();

    public static bool DSEYWwAABWQaxYce(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.m8f38cc9e((java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252>) atomicReference, p7beea252Var, (java.lang.Class<object>) cls);
    }

    public static bool HaqgyUfHWFzNWIOU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void MQeqbhoMniUYyFrX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e p90df2a9eVar) {
        p90df2a9eVar.dispose();
    }

    public static java.lang.object QGrUFSQNpnuhHLko(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object SsEzEAUpYxwPyAHL(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool TjwQKFlIYObqPPKU(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void WJajkQIAQNsbDuAy(pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p7a5df0c7 p7a5df0c7Var) {
        p7a5df0c7Var.onStart();
    }

    public static java.lang.Class YAAGLjjkYsFoIgHc(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool PnSKubxhxivncZqm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e p90df2a9eVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p90df2a9eVar.Add(p7beea252Var);
    }

    public readonly void Add(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        QGrUFSQNpnuhHLko(p7beea252Var, "resource is null");
        pnSKubxhxivncZqm(this.f55b558c7, p7beea252Var);
    }

    public override readonly void Dispose() {
        if (TjwQKFlIYObqPPKU(this.fbc3b0556)) {
            MQeqbhoMniUYyFrX(this.f55b558c7);
        }
    }

    public override readonly bool IsDisposed() {
        return HaqgyUfHWFzNWIOU((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) SsEzEAUpYxwPyAHL(this.fbc3b0556));
    }

    protected void OnStart() {
    }

    public override readonly void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((31 + 28) % 28 > 0) {
        }
        if (DSEYWwAABWQaxYce(this.fbc3b0556, p7beea252Var, YAAGLjjkYsFoIgHc(this))) {
            WJajkQIAQNsbDuAy(this);
        }
    }
}

