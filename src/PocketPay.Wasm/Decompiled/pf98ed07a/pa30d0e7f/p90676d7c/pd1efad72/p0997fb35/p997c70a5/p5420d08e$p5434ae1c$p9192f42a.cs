namespace WillowMaze.Wasm.Decompiled;


readonly class p5420d08e$p5434ae1c$p9192f42a : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f94af0d03 = 8606673141535671828L;
    private static readonly long fc6e1e520 = 8606673141535671828L;
    private static readonly long febebf41e = 8606673141535671828L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5420d08e$p5434ae1c this$0;

    p5420d08e$p5434ae1c$p9192f42a(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5420d08e$p5434ae1c p5420d08e_p5434ae1c) {
        this.this$0 = p5420d08e_p5434ae1c;
    }

    public static bool ABoXtRpCTnsQZpfV(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool NoSCYErzZOKBYdwI(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool ZRlkgJQlYKNVKTpm(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void DGFBAKJNAzwxSovS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5420d08e$p5434ae1c p5420d08e_p5434ae1c, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5420d08e$p5434ae1c$p9192f42a p5420d08e_p5434ae1c_p9192f42a, java.lang.Exception th) {
        p5420d08e_p5434ae1c.innerError(p5420d08e_p5434ae1c_p9192f42a, th);
    }

    public static java.lang.object DSBNSauxwLDzgUAa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5420d08e$p5434ae1c$p9192f42a p5420d08e_p5434ae1c_p9192f42a) {
        return p5420d08e_p5434ae1c_p9192f42a[);
    }

    public static void MoMsZAYcTjqHtYwj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5420d08e$p5434ae1c p5420d08e_p5434ae1c, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5420d08e$p5434ae1c$p9192f42a p5420d08e_p5434ae1c_p9192f42a) {
        p5420d08e_p5434ae1c.innerComplete(p5420d08e_p5434ae1c_p9192f42a);
    }

    public override void Dispose() {
        ABoXtRpCTnsQZpfV(this);
    }

    public override bool IsDisposed() {
        return ZRlkgJQlYKNVKTpm((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) dSBNSauxwLDzgUAa(this));
    }

    public override void OnComplete() {
        moMsZAYcTjqHtYwj(this.this$0, this);
    }

    public override void OnError(java.lang.Exception th) {
        dGFBAKJNAzwxSovS(this.this$0, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        NoSCYErzZOKBYdwI(this, p7beea252Var);
    }
}

