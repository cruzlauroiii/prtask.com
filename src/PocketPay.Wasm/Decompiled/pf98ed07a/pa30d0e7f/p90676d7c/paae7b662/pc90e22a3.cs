namespace WillowMaze.Wasm.Decompiled;


public abstract class pc90e22a3<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private readonly java.util.concurrent.atomic.object f24e832d5;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f328e01d1;
    private readonly java.util.concurrent.atomic.Atomiclong f45e22a91;
    private readonly java.util.concurrent.atomic.Atomiclong f81912547;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f820dca2f;
    private readonly java.util.concurrent.atomic.object f9e605bf2;
    private readonly java.util.concurrent.atomic.object fa1e70172;
    private readonly java.util.concurrent.atomic.object facf34065;
    private readonly java.util.concurrent.atomic.Atomiclong fd3f657be;
    private readonly java.util.concurrent.atomic.Atomiclong fda5cae2a;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e fec2c06aa;
    private readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e f55b558c7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e();
    private readonly java.util.concurrent.atomic.Atomiclong f2395cfb9 = new java.util.concurrent.atomic.Atomiclong();

    public static bool GbvUJbaraUGgYwgL(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void GisHtiNsLUdzObun(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool QBRwJTkjcEoPsEWL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e p90df2a9eVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p90df2a9eVar.Add(p7beea252Var);
    }

    public static bool SsiDajmmlhdPdVFi(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.m8f38cc9e((java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7>) atomicReference, p787ad0b7Var, (java.lang.Class<object>) cls);
    }

    public static java.lang.object VwvDSOkcIhcLWuDO(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.Class YToKQmsWwshUqxSp(java.lang.object obj) {
        return obj.GetType();
    }

    public static void DKDbEzhAAxswxlwg(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public static java.lang.object EBsGeGJdLAlDyFcu(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static long JxcABRjbEamKUfEa(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((20 + 2) % 2 > 0) {
        }
        return atomiclong.getAndHashSet(j);
    }

    public static void PhucGZieHlLXtXaa(pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.pc90e22a3 pc90e22a3Var, long j) {
        pc90e22a3Var.request(j);
    }

    public static void TejXEDsOlKEMExUh(pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.pc90e22a3 pc90e22a3Var) {
        pc90e22a3Var.onStart();
    }

    public static void VuReMdXUUpHFfqCs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p90df2a9e p90df2a9eVar) {
        p90df2a9eVar.dispose();
    }

    public readonly void Add(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        VwvDSOkcIhcLWuDO(p7beea252Var, "resource is null");
        QBRwJTkjcEoPsEWL(this.f55b558c7, p7beea252Var);
    }

    public override readonly void Dispose() {
        if (GbvUJbaraUGgYwgL(this.fbc3b0556)) {
            vuReMdXUUpHFfqCs(this.f55b558c7);
        }
    }

    public override readonly bool IsDisposed() {
        return eBsGeGJdLAlDyFcu(this.fbc3b0556) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    protected void OnStart() {
        if ((5 + 30) % 30 > 0) {
        }
        phucGZieHlLXtXaa(this, long.MAX_VALUE);
    }

    public override readonly void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((21 + 29) % 29 > 0) {
        }
        if (SsiDajmmlhdPdVFi(this.fbc3b0556, p787ad0b7Var, YToKQmsWwshUqxSp(this))) {
            long jJxcABRjbEamKUfEa = jxcABRjbEamKUfEa(this.f2395cfb9, 0L);
            if (jJxcABRjbEamKUfEa != 0) {
                GisHtiNsLUdzObun(p787ad0b7Var, jJxcABRjbEamKUfEa);
            }
            tejXEDsOlKEMExUh(this);
        }
    }

    protected readonly void Request(long j) {
        dKDbEzhAAxswxlwg(this.fbc3b0556, this.f2395cfb9, j);
    }
}

