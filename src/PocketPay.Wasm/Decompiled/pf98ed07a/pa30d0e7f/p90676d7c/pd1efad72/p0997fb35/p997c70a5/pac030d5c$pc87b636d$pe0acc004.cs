namespace WillowMaze.Wasm.Decompiled;


readonly class pac030d5c$pc87b636d$pe0acc004<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long fc6e1e520 = -2935427570954647017L;
    private static readonly long ffe2ced93 = -2935427570954647017L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d f41d2f890;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d f8a8c2c50;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d f9b2c644b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d fc15c0ac7;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableMergeWithMaybe$MergeWithObserver<T> fd0e45878;

    pac030d5c$pc87b636d$pe0acc004(io.reactivex.rxjava3.internal.operators.observable.ObservableMergeWithMaybe$MergeWithObserver<T> observableMergeWithMaybe$MergeWithObserver) {
        this.fd0e45878 = observableMergeWithMaybe$MergeWithObserver;
    }

    public static void HJEqPsMNUMUKoXiA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d, java.lang.Exception th) {
        pac030d5c_pc87b636d.otherError(th);
    }

    public static void ScneQQMldaeNXUtu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d) {
        pac030d5c_pc87b636d.otherComplete();
    }

    public static bool ZWBdysSOEsKgUtmG(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void EvmolYSknOGGsHXn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pac030d5c$pc87b636d pac030d5c_pc87b636d, java.lang.object obj) {
        pac030d5c_pc87b636d.otherSuccess(obj);
    }

    public override void OnComplete() {
        ScneQQMldaeNXUtu(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        HJEqPsMNUMUKoXiA(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        ZWBdysSOEsKgUtmG(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        evmolYSknOGGsHXn(this.fd0e45878, t);
    }
}

