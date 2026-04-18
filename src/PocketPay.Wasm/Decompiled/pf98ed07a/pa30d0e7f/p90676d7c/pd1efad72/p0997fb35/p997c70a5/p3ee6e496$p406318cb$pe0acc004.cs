namespace WillowMaze.Wasm.Decompiled;


readonly class p3ee6e496$p406318cb$pe0acc004<U> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<U> {
    private static readonly long fa8f94c5c = -8693423678067375039L;
    private static readonly long fc6e1e520 = -8693423678067375039L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3ee6e496$p406318cb this$0;

    p3ee6e496$p406318cb$pe0acc004(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3ee6e496$p406318cb p3ee6e496_p406318cb) {
        this.this$0 = p3ee6e496_p406318cb;
    }

    public static bool BTuxDmCBaZBnxdvT(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void TlvarQBnzpBzXgqT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3ee6e496$p406318cb p3ee6e496_p406318cb) {
        p3ee6e496_p406318cb.otherComplete();
    }

    public static bool VxLpVByKqBwmaeEU(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void YSteZhwaSmbMFKYz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3ee6e496$p406318cb p3ee6e496_p406318cb) {
        p3ee6e496_p406318cb.otherComplete();
    }

    public static void SpQbGdEsrGCUstpm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3ee6e496$p406318cb p3ee6e496_p406318cb, java.lang.Exception th) {
        p3ee6e496_p406318cb.otherError(th);
    }

    public override void OnComplete() {
        YSteZhwaSmbMFKYz(this.this$0);
    }

    public override void OnError(java.lang.Exception th) {
        spQbGdEsrGCUstpm(this.this$0, th);
    }

    public override void OnNext(U u) {
        VxLpVByKqBwmaeEU(this);
        TlvarQBnzpBzXgqT(this.this$0);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        BTuxDmCBaZBnxdvT(this, p7beea252Var);
    }
}

