namespace WillowMaze.Wasm.Decompiled;


readonly class p13102011$p5a445cbc$p9ae242ac : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<java.lang.object> {
    private static readonly long f122f7d4a = 3254781284376480842L;
    private static readonly long fc6e1e520 = 3254781284376480842L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p13102011$p5a445cbc this$0;

    p13102011$p5a445cbc$p9ae242ac(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p13102011$p5a445cbc p13102011_p5a445cbc) {
        this.this$0 = p13102011_p5a445cbc;
    }

    public static void BLqdFaNFgrThUROl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p13102011$p5a445cbc p13102011_p5a445cbc) {
        p13102011_p5a445cbc.innerNext();
    }

    public static bool OsFhFCurnIexSqbG(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void AjOhhmuMWVItGVGR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p13102011$p5a445cbc p13102011_p5a445cbc) {
        p13102011_p5a445cbc.innerComplete();
    }

    public static void SaQGHwQIEPjNYjar(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p13102011$p5a445cbc p13102011_p5a445cbc, java.lang.Exception th) {
        p13102011_p5a445cbc.innerError(th);
    }

    public override void OnComplete() {
        ajOhhmuMWVItGVGR(this.this$0);
    }

    public override void OnError(java.lang.Exception th) {
        saQGHwQIEPjNYjar(this.this$0, th);
    }

    public override void OnNext(java.lang.object obj) {
        BLqdFaNFgrThUROl(this.this$0);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        OsFhFCurnIexSqbG(this, p7beea252Var);
    }
}

