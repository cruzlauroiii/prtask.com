namespace WillowMaze.Wasm.Decompiled;


public readonly class p6860313c : java.util.concurrent.atomic.Atomiclong : p5a445d71.p18f29add.p787ad0b7, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fae50377e = 7028635084060361255L;
    private static readonly long fc1f0e3dd = 7028635084060361255L;
    private static readonly long fc6e1e520 = 7028635084060361255L;
    readonly java.util.concurrent.atomic.object f1809f320;
    readonly java.util.concurrent.atomic.object f25c6d81f;
    readonly java.util.concurrent.atomic.object f4a9944d4;
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> f5157e3c7;
    readonly java.util.concurrent.atomic.object f8c9db287;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f96ab4e16;

    public p6860313c() {
        this.f96ab4e16 = new java.util.concurrent.atomic.object<>();
        this.f5157e3c7 = new java.util.concurrent.atomic.object<>();
    }

    public p6860313c(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        this();
        EbkKnYNAbaRfLmNm(this.f96ab4e16, p7beea252Var);
    }

    public static bool CHVntnaLGfLdZizU(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void EbkKnYNAbaRfLmNm(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static bool JQwIJEjtCmHyPhKm(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredHashSetOnce(atomicReference, atomiclong, p787ad0b7Var);
    }

    public static java.lang.object KrVAKgkLrbmssuig(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool MqytyRcllYABFTge(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.set(atomicReference, p7beea252Var);
    }

    public static void TwjHqsLmdwjOKYcr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p6860313c p6860313cVar) {
        p6860313cVar.dispose();
    }

    public static bool GoCPDhVgCUAdHoNv(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool TrSdISWCfookpGbX(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void YRAiFHoPJBsyepCb(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public override void Cancel() {
        TwjHqsLmdwjOKYcr(this);
    }

    public override void Dispose() {
        CHVntnaLGfLdZizU(this.f5157e3c7);
        goCPDhVgCUAdHoNv(this.f96ab4e16);
    }

    public override bool IsDisposed() {
        return KrVAKgkLrbmssuig(this.f5157e3c7) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public bool ReplaceResource(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return trSdISWCfookpGbX(this.f96ab4e16, p7beea252Var);
    }

    public override void Request(long j) {
        yRAiFHoPJBsyepCb(this.f5157e3c7, this, j);
    }

    public bool SetResource(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return MqytyRcllYABFTge(this.f96ab4e16, p7beea252Var);
    }

    public void SetSubscription(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        JQwIJEjtCmHyPhKm(this.f5157e3c7, this, p787ad0b7Var);
    }
}

