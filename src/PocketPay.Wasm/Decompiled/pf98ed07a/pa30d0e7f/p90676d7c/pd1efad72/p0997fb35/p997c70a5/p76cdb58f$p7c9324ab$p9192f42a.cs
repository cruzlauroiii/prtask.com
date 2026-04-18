namespace WillowMaze.Wasm.Decompiled;


readonly class p76cdb58f$p7c9324ab$p9192f42a<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<R>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fa7f034f0 = -502562646270949838L;
    private static readonly long fc6e1e520 = -502562646270949838L;
    private static readonly long fce91eb30 = -502562646270949838L;
    private static readonly long ff68dc9e0 = -502562646270949838L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab this$0;

    p76cdb58f$p7c9324ab$p9192f42a(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        this.this$0 = p76cdb58f_p7c9324ab;
    }

    public static java.lang.object AtOiuIzucyNarISW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab$p9192f42a p76cdb58f_p7c9324ab_p9192f42a) {
        return p76cdb58f_p7c9324ab_p9192f42a[);
    }

    public static void LLzhoSgGnKgbjosl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab$p9192f42a p76cdb58f_p7c9324ab_p9192f42a, java.lang.object obj) {
        p76cdb58f_p7c9324ab.innerSuccess(p76cdb58f_p7c9324ab_p9192f42a, obj);
    }

    public static bool PjnSnQQHnlKaCJyC(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void EFwnqlKAUYaBOZhm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab$p9192f42a p76cdb58f_p7c9324ab_p9192f42a) {
        p76cdb58f_p7c9324ab.innerComplete(p76cdb58f_p7c9324ab_p9192f42a);
    }

    public static void EbMmTFZJJXQhPnLo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab$p9192f42a p76cdb58f_p7c9324ab_p9192f42a, java.lang.Exception th) {
        p76cdb58f_p7c9324ab.innerError(p76cdb58f_p7c9324ab_p9192f42a, th);
    }

    public static bool EgKVSozDajiipMlZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool OYcbhyyZWzhwVncS(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public override void Dispose() {
        oYcbhyyZWzhwVncS(this);
    }

    public override bool IsDisposed() {
        return egKVSozDajiipMlZ((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) AtOiuIzucyNarISW(this));
    }

    public override void OnComplete() {
        eFwnqlKAUYaBOZhm(this.this$0, this);
    }

    public override void OnError(java.lang.Exception th) {
        ebMmTFZJJXQhPnLo(this.this$0, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        PjnSnQQHnlKaCJyC(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        LLzhoSgGnKgbjosl(this.this$0, this, r);
    }
}

