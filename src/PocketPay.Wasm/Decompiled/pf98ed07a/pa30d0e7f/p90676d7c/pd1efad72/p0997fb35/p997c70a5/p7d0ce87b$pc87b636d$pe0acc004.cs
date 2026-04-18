namespace WillowMaze.Wasm.Decompiled;


readonly class p7d0ce87b$pc87b636d$pe0acc004 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver {
    private static readonly long f8de7ca7d = -2935427570954647017L;
    private static readonly long fc6e1e520 = -2935427570954647017L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7d0ce87b$pc87b636d f044c293f;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableMergeWithCompletable$MergeWithObserver<object> fd0e45878;

    p7d0ce87b$pc87b636d$pe0acc004(io.reactivex.rxjava3.internal.operators.observable.ObservableMergeWithCompletable$MergeWithObserver<object> observableMergeWithCompletable$MergeWithObserver) {
        this.fd0e45878 = observableMergeWithCompletable$MergeWithObserver;
    }

    public static bool DYgzVwNxVoJaWzsI(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void IpzxfGkkHXMqFqsQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7d0ce87b$pc87b636d p7d0ce87b_pc87b636d, java.lang.Exception th) {
        p7d0ce87b_pc87b636d.otherError(th);
    }

    public static void TsmrsSAASwCGNmob(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7d0ce87b$pc87b636d p7d0ce87b_pc87b636d) {
        p7d0ce87b_pc87b636d.otherComplete();
    }

    public override void OnComplete() {
        TsmrsSAASwCGNmob(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        IpzxfGkkHXMqFqsQ(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        DYgzVwNxVoJaWzsI(this, p7beea252Var);
    }
}

