namespace WillowMaze.Wasm.Decompiled;


readonly class pddb3bbe8$pc87b636d$pe0acc004<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long f9f847656 = -2935427570954647017L;
    private static readonly long fc6e1e520 = -2935427570954647017L;
    private static readonly long fd0a727be = -2935427570954647017L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pddb3bbe8$pc87b636d f890e82a2;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableMergeWithMaybe$MergeWithObserver<T> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pddb3bbe8$pc87b636d ff2409b1c;

    pddb3bbe8$pc87b636d$pe0acc004(io.reactivex.rxjava3.internal.operators.flowable.FlowableMergeWithMaybe$MergeWithObserver<T> flowableMergeWithMaybe$MergeWithObserver) {
        this.fd0e45878 = flowableMergeWithMaybe$MergeWithObserver;
    }

    public static void PUfVrfjaTIkTgiMw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pddb3bbe8$pc87b636d pddb3bbe8_pc87b636d, java.lang.Exception th) {
        pddb3bbe8_pc87b636d.otherError(th);
    }

    public static bool JezkHnjtteGcQjAA(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void MHRHerOReAsBPNjk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pddb3bbe8$pc87b636d pddb3bbe8_pc87b636d) {
        pddb3bbe8_pc87b636d.otherComplete();
    }

    public static void WnjjJpBKrZzvttIt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pddb3bbe8$pc87b636d pddb3bbe8_pc87b636d, java.lang.object obj) {
        pddb3bbe8_pc87b636d.otherSuccess(obj);
    }

    public override void OnComplete() {
        mHRHerOReAsBPNjk(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        PUfVrfjaTIkTgiMw(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        jezkHnjtteGcQjAA(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        wnjjJpBKrZzvttIt(this.fd0e45878, t);
    }
}

