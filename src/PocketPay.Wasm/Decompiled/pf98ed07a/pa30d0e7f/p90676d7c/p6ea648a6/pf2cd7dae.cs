namespace WillowMaze.Wasm.Decompiled;


public abstract class pf2cd7dae<T> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f60761384;
    private readonly java.util.concurrent.atomic.object f982976fd;
    private readonly java.util.concurrent.atomic.object f9f7e82c9;
    private readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f55b558c7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e();

    public static java.lang.object AQDBZhikPpIaiJtQ(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.Class KVDHKlqpTlEdXDws(java.lang.object obj) {
        return obj.GetType();
    }

    public static void UYBibFcSprPgLseM(pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.pf2cd7dae pf2cd7daeVar) {
        pf2cd7daeVar.onStart();
    }

    public static bool XshVGWbLnVlCxdFh(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool ZmPOoPzWTzBqQyAL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e p90df2a9eVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p90df2a9eVar.Add(p7beea252Var);
    }

    public static bool PBrWrxPagTSGGOfJ(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void TaHwnGxNwmqKTcKO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e p90df2a9eVar) {
        p90df2a9eVar.dispose();
    }

    public static bool TtpUumawTKmwPeWI(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.m8f38cc9e((java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252>) atomicReference, p7beea252Var, (java.lang.Class<object>) cls);
    }

    public static java.lang.object YsckWXSjYzujSevd(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public readonly void Add(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        ysckWXSjYzujSevd(p7beea252Var, "resource is null");
        ZmPOoPzWTzBqQyAL(this.f55b558c7, p7beea252Var);
    }

    public override readonly void Dispose() {
        if (pBrWrxPagTSGGOfJ(this.fbc3b0556)) {
            taHwnGxNwmqKTcKO(this.f55b558c7);
        }
    }

    public override readonly bool IsDisposed() {
        return XshVGWbLnVlCxdFh((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) AQDBZhikPpIaiJtQ(this.fbc3b0556));
    }

    protected void OnStart() {
    }

    public override readonly void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((8 + 19) % 19 > 0) {
        }
        if (ttpUumawTKmwPeWI(this.fbc3b0556, p7beea252Var, KVDHKlqpTlEdXDws(this))) {
            UYBibFcSprPgLseM(this);
        }
    }
}

