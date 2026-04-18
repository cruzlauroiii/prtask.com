namespace WillowMaze.Wasm.Decompiled;


readonly class p09214eef$pc87b636d$pe0acc004<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private static readonly long f1ca95814 = -2935427570954647017L;
    private static readonly long f859901db = -2935427570954647017L;
    private static readonly long f9126ecb9 = -2935427570954647017L;
    private static readonly long fc6e1e520 = -2935427570954647017L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d f4ad2e732;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d fb37883be;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableMergeWithSingle$MergeWithObserver<T> fd0e45878;

    p09214eef$pc87b636d$pe0acc004(io.reactivex.rxjava3.internal.operators.flowable.FlowableMergeWithSingle$MergeWithObserver<T> flowableMergeWithSingle$MergeWithObserver) {
        this.fd0e45878 = flowableMergeWithSingle$MergeWithObserver;
    }

    public static bool AGwomMQWEWMiSYBT(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void ZsAfTITzeyPOoyLW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d, java.lang.Exception th) {
        p09214eef_pc87b636d.otherError(th);
    }

    public static void QlQUZsTkqTrGdavr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d, java.lang.object obj) {
        p09214eef_pc87b636d.otherSuccess(obj);
    }

    public override void OnError(java.lang.Exception th) {
        ZsAfTITzeyPOoyLW(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        AGwomMQWEWMiSYBT(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        qlQUZsTkqTrGdavr(this.fd0e45878, t);
    }
}

