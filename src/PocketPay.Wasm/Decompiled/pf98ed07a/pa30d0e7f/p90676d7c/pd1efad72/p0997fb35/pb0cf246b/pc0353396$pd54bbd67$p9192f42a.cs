namespace WillowMaze.Wasm.Decompiled;


readonly class pc0353396$pd54bbd67$p9192f42a<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<R>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f2f81ec78 = -502562646270949838L;
    private static readonly long fa83d6fd9 = -502562646270949838L;
    private static readonly long fb2019cd8 = -502562646270949838L;
    private static readonly long fc6e1e520 = -502562646270949838L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc0353396$pd54bbd67 this$0;

    pc0353396$pd54bbd67$p9192f42a(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc0353396$pd54bbd67 pc0353396_pd54bbd67) {
        this.this$0 = pc0353396_pd54bbd67;
    }

    public static java.lang.object FoBBKOvLxkycLvEv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc0353396$pd54bbd67$p9192f42a pc0353396_pd54bbd67_p9192f42a) {
        return pc0353396_pd54bbd67_p9192f42a[);
    }

    public static bool MgjoFGjHSVEcDXmd(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void JoErkbrYjLGoqTWQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc0353396$pd54bbd67 pc0353396_pd54bbd67, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc0353396$pd54bbd67$p9192f42a pc0353396_pd54bbd67_p9192f42a) {
        pc0353396_pd54bbd67.innerComplete(pc0353396_pd54bbd67_p9192f42a);
    }

    public static void JrxKJEkHbWfVSaLE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc0353396$pd54bbd67 pc0353396_pd54bbd67, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc0353396$pd54bbd67$p9192f42a pc0353396_pd54bbd67_p9192f42a, java.lang.object obj) {
        pc0353396_pd54bbd67.innerSuccess(pc0353396_pd54bbd67_p9192f42a, obj);
    }

    public static bool LcbyPqHlbsFdOYTS(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void NqdDEGjgmjiCLBem(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc0353396$pd54bbd67 pc0353396_pd54bbd67, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc0353396$pd54bbd67$p9192f42a pc0353396_pd54bbd67_p9192f42a, java.lang.Exception th) {
        pc0353396_pd54bbd67.innerError(pc0353396_pd54bbd67_p9192f42a, th);
    }

    public static bool VTrfLpvxivCDCUcv(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public override void Dispose() {
        vTrfLpvxivCDCUcv(this);
    }

    public override bool IsDisposed() {
        return MgjoFGjHSVEcDXmd((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) FoBBKOvLxkycLvEv(this));
    }

    public override void OnComplete() {
        joErkbrYjLGoqTWQ(this.this$0, this);
    }

    public override void OnError(java.lang.Exception th) {
        nqdDEGjgmjiCLBem(this.this$0, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        lcbyPqHlbsFdOYTS(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        jrxKJEkHbWfVSaLE(this.this$0, this, r);
    }
}

