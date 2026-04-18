namespace WillowMaze.Wasm.Decompiled;


readonly class pfc02b8a2$p14bcf40d$p9192f42a : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f96973db6 = 8606673141535671828L;
    private static readonly long fc6e1e520 = 8606673141535671828L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d this$0;

    pfc02b8a2$p14bcf40d$p9192f42a(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d pfc02b8a2_p14bcf40d) {
        this.this$0 = pfc02b8a2_p14bcf40d;
    }

    public static void LmkFVPRtfzDQPxkV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d pfc02b8a2_p14bcf40d, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d$p9192f42a pfc02b8a2_p14bcf40d_p9192f42a) {
        pfc02b8a2_p14bcf40d.innerComplete(pfc02b8a2_p14bcf40d_p9192f42a);
    }

    public static bool SmpImHugkSsmjuEL(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool USCBTzaSbbXWQkxb(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object JDAjlVUKSiOZFdwq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d$p9192f42a pfc02b8a2_p14bcf40d_p9192f42a) {
        return pfc02b8a2_p14bcf40d_p9192f42a[);
    }

    public static bool JtLHGJSBapqUwUFz(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void RRMmIvcrbaqPMtUs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d pfc02b8a2_p14bcf40d, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfc02b8a2$p14bcf40d$p9192f42a pfc02b8a2_p14bcf40d_p9192f42a, java.lang.Exception th) {
        pfc02b8a2_p14bcf40d.innerError(pfc02b8a2_p14bcf40d_p9192f42a, th);
    }

    public override void Dispose() {
        jtLHGJSBapqUwUFz(this);
    }

    public override bool IsDisposed() {
        return USCBTzaSbbXWQkxb((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) jDAjlVUKSiOZFdwq(this));
    }

    public override void OnComplete() {
        LmkFVPRtfzDQPxkV(this.this$0, this);
    }

    public override void OnError(java.lang.Exception th) {
        rRMmIvcrbaqPMtUs(this.this$0, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        SmpImHugkSsmjuEL(this, p7beea252Var);
    }
}

