namespace WillowMaze.Wasm.Decompiled;


readonly class pabb40c48$pc87b636d$pe0acc004<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private static readonly long f232e3186 = -2935427570954647017L;
    private static readonly long f86f75911 = -2935427570954647017L;
    private static readonly long f8f5edeeb = -2935427570954647017L;
    private static readonly long f9b769427 = -2935427570954647017L;
    private static readonly long fc6e1e520 = -2935427570954647017L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pabb40c48$pc87b636d f94d3b5b8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pabb40c48$pc87b636d fb6a0ab83;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableMergeWithSingle$MergeWithObserver<T> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pabb40c48$pc87b636d fd9cf0614;

    pabb40c48$pc87b636d$pe0acc004(io.reactivex.rxjava3.internal.operators.observable.ObservableMergeWithSingle$MergeWithObserver<T> observableMergeWithSingle$MergeWithObserver) {
        this.fd0e45878 = observableMergeWithSingle$MergeWithObserver;
    }

    public static bool CtCDKhuejXReQgwa(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void JWlRnUltmcWotHWR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pabb40c48$pc87b636d pabb40c48_pc87b636d, java.lang.object obj) {
        pabb40c48_pc87b636d.otherSuccess(obj);
    }

    public static void DEBOjFCBvTpmVctS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pabb40c48$pc87b636d pabb40c48_pc87b636d, java.lang.Exception th) {
        pabb40c48_pc87b636d.otherError(th);
    }

    public override void OnError(java.lang.Exception th) {
        dEBOjFCBvTpmVctS(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        CtCDKhuejXReQgwa(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        JWlRnUltmcWotHWR(this.fd0e45878, t);
    }
}

