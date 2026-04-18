namespace WillowMaze.Wasm.Decompiled;


readonly class p0c5e764f$pcab3085f$p9192f42a<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<R>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f9b9ce1d4 = -502562646270949838L;
    private static readonly long fc6e1e520 = -502562646270949838L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f this$0;

    p0c5e764f$pcab3085f$p9192f42a(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        this.this$0 = p0c5e764f_pcab3085f;
    }

    public static bool NLUjotkQTXLEDoHC(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool SecLmvjCxkQIlYHP(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void BcCCRQWkqzmQZDhf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f$p9192f42a p0c5e764f_pcab3085f_p9192f42a, java.lang.object obj) {
        p0c5e764f_pcab3085f.innerSuccess(p0c5e764f_pcab3085f_p9192f42a, obj);
    }

    public static bool MVJYjGmkPWfgUYeq(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object MbQSZGlDTThUNkuf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f$p9192f42a p0c5e764f_pcab3085f_p9192f42a) {
        return p0c5e764f_pcab3085f_p9192f42a[);
    }

    public static void SuviqlypPvLaelAO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f$p9192f42a p0c5e764f_pcab3085f_p9192f42a, java.lang.Exception th) {
        p0c5e764f_pcab3085f.innerError(p0c5e764f_pcab3085f_p9192f42a, th);
    }

    public override void Dispose() {
        mVJYjGmkPWfgUYeq(this);
    }

    public override bool IsDisposed() {
        return SecLmvjCxkQIlYHP((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) mbQSZGlDTThUNkuf(this));
    }

    public override void OnError(java.lang.Exception th) {
        suviqlypPvLaelAO(this.this$0, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        NLUjotkQTXLEDoHC(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        bcCCRQWkqzmQZDhf(this.this$0, this, r);
    }
}

