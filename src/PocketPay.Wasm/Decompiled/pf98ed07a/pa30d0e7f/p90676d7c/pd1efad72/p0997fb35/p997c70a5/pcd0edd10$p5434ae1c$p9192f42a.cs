namespace WillowMaze.Wasm.Decompiled;


readonly class pcd0edd10$p5434ae1c$p9192f42a : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f9212f60f = 8606673141535671828L;
    private static readonly long fc6e1e520 = 8606673141535671828L;
    private static readonly long fddff649c = 8606673141535671828L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcd0edd10$p5434ae1c this$0;

    pcd0edd10$p5434ae1c$p9192f42a(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcd0edd10$p5434ae1c pcd0edd10_p5434ae1c) {
        this.this$0 = pcd0edd10_p5434ae1c;
    }

    public static void BJaPDAtWSPogYdut(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcd0edd10$p5434ae1c pcd0edd10_p5434ae1c, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcd0edd10$p5434ae1c$p9192f42a pcd0edd10_p5434ae1c_p9192f42a, java.lang.Exception th) {
        pcd0edd10_p5434ae1c.innerError(pcd0edd10_p5434ae1c_p9192f42a, th);
    }

    public static bool PhEcOnmRXDsLwHws(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool SccohIqBUGKggWwc(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static java.lang.object HfeqwJWBKbCYJQQo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcd0edd10$p5434ae1c$p9192f42a pcd0edd10_p5434ae1c_p9192f42a) {
        return pcd0edd10_p5434ae1c_p9192f42a[);
    }

    public static bool NYrJTdMvYITLssmc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void NerqaZjNyyZInweq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcd0edd10$p5434ae1c pcd0edd10_p5434ae1c, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcd0edd10$p5434ae1c$p9192f42a pcd0edd10_p5434ae1c_p9192f42a) {
        pcd0edd10_p5434ae1c.innerComplete(pcd0edd10_p5434ae1c_p9192f42a);
    }

    public override void Dispose() {
        PhEcOnmRXDsLwHws(this);
    }

    public override bool IsDisposed() {
        return nYrJTdMvYITLssmc((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) hfeqwJWBKbCYJQQo(this));
    }

    public override void OnComplete() {
        nerqaZjNyyZInweq(this.this$0, this);
    }

    public override void OnError(java.lang.Exception th) {
        BJaPDAtWSPogYdut(this.this$0, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        SccohIqBUGKggWwc(this, p7beea252Var);
    }
}

