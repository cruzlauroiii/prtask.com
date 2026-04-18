namespace WillowMaze.Wasm.Decompiled;


readonly class p21a86d0b$peb5843c1$pe0acc004 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver {
    private static readonly long f10851e34 = -2935427570954647017L;
    private static readonly long f4acf7e42 = -2935427570954647017L;
    private static readonly long fc6e1e520 = -2935427570954647017L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p21a86d0b$peb5843c1 f0a7edfea;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p21a86d0b$peb5843c1 f3b70a84e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p21a86d0b$peb5843c1 f45320d5e;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableMergeWithCompletable$MergeWithSubscriber<object> fd0e45878;

    p21a86d0b$peb5843c1$pe0acc004(io.reactivex.rxjava3.internal.operators.flowable.FlowableMergeWithCompletable$MergeWithSubscriber<object> flowableMergeWithCompletable$MergeWithSubscriber) {
        this.fd0e45878 = flowableMergeWithCompletable$MergeWithSubscriber;
    }

    public static bool CNMXTmTYXNjaYKyb(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void OIEHcbBFwQMwulRE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p21a86d0b$peb5843c1 p21a86d0b_peb5843c1) {
        p21a86d0b_peb5843c1.otherComplete();
    }

    public static void TbcczhbkCqHzRZlf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p21a86d0b$peb5843c1 p21a86d0b_peb5843c1, java.lang.Exception th) {
        p21a86d0b_peb5843c1.otherError(th);
    }

    public override void OnComplete() {
        oIEHcbBFwQMwulRE(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        tbcczhbkCqHzRZlf(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        cNMXTmTYXNjaYKyb(this, p7beea252Var);
    }
}

