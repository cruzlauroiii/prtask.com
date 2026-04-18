namespace WillowMaze.Wasm.Decompiled;


readonly class p55037f0e$p475bc90e$p9192f42a<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<R>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f26f801e5 = -502562646270949838L;
    private static readonly long fc6e1e520 = -502562646270949838L;
    private static readonly long fd9ec8045 = -502562646270949838L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e this$0;

    p55037f0e$p475bc90e$p9192f42a(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        this.this$0 = p55037f0e_p475bc90e;
    }

    public static java.lang.object AGvdzWPJCpzNvFon(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e$p9192f42a p55037f0e_p475bc90e_p9192f42a) {
        return p55037f0e_p475bc90e_p9192f42a[);
    }

    public static bool BLQZkgKykLgbKESY(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool FnSIdcWjViGoaqrM(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool KinSNqWlantHUhsk(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void WOiZcxJIcDPQBUFm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e$p9192f42a p55037f0e_p475bc90e_p9192f42a, java.lang.Exception th) {
        p55037f0e_p475bc90e.innerError(p55037f0e_p475bc90e_p9192f42a, th);
    }

    public static void YUbsTmEZBwGuvitv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e$p9192f42a p55037f0e_p475bc90e_p9192f42a, java.lang.object obj) {
        p55037f0e_p475bc90e.innerSuccess(p55037f0e_p475bc90e_p9192f42a, obj);
    }

    public override void Dispose() {
        FnSIdcWjViGoaqrM(this);
    }

    public override bool IsDisposed() {
        return KinSNqWlantHUhsk((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) AGvdzWPJCpzNvFon(this));
    }

    public override void OnError(java.lang.Exception th) {
        wOiZcxJIcDPQBUFm(this.this$0, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        BLQZkgKykLgbKESY(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        yUbsTmEZBwGuvitv(this.this$0, this, r);
    }
}

