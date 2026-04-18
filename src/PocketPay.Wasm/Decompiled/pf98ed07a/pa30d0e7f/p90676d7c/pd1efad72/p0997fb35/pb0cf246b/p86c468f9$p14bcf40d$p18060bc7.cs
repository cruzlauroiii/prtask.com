namespace WillowMaze.Wasm.Decompiled;


readonly class p86c468f9$p14bcf40d$p18060bc7 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fc6e1e520 = 8606673141535671828L;
    private static readonly long fda27b68c = 8606673141535671828L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d this$0;

    p86c468f9$p14bcf40d$p18060bc7(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d p86c468f9_p14bcf40d) {
        this.this$0 = p86c468f9_p14bcf40d;
    }

    public static bool DyhAPGGPuhVxqnJi(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object KHxpYndEikawPveK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d$p18060bc7 p86c468f9_p14bcf40d_p18060bc7) {
        return p86c468f9_p14bcf40d_p18060bc7[);
    }

    public static bool XgpceUrzhiBFuFUz(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void OgNqubiXYWfZSEcV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d p86c468f9_p14bcf40d, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d$p18060bc7 p86c468f9_p14bcf40d_p18060bc7) {
        p86c468f9_p14bcf40d.innerComplete(p86c468f9_p14bcf40d_p18060bc7);
    }

    public static bool PyLXZrFaGYrCnEEH(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void WHRNcCBRqLZQBeMo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d p86c468f9_p14bcf40d, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p86c468f9$p14bcf40d$p18060bc7 p86c468f9_p14bcf40d_p18060bc7, java.lang.Exception th) {
        p86c468f9_p14bcf40d.innerError(p86c468f9_p14bcf40d_p18060bc7, th);
    }

    public override void Dispose() {
        DyhAPGGPuhVxqnJi(this);
    }

    public override bool IsDisposed() {
        return XgpceUrzhiBFuFUz((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) KHxpYndEikawPveK(this));
    }

    public override void OnComplete() {
        ogNqubiXYWfZSEcV(this.this$0, this);
    }

    public override void OnError(java.lang.Exception th) {
        wHRNcCBRqLZQBeMo(this.this$0, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pyLXZrFaGYrCnEEH(this, p7beea252Var);
    }
}

