namespace WillowMaze.Wasm.Decompiled;


readonly class pa9d45ef6$p6fb43174$p31c54af0<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<R> {
    private static readonly long f053b8a2c = 8042919737683345351L;
    private static readonly long f2bfea64f = 8042919737683345351L;
    private static readonly long fc6e1e520 = 8042919737683345351L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pa9d45ef6$p6fb43174 f116a03fa;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pa9d45ef6$p6fb43174 f3f41ce22;
    volatile R f447b7147;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pa9d45ef6$p6fb43174 f4e7deb46;
    volatile java.lang.object fac8122f1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pa9d45ef6$p6fb43174 fbe8603f3;
    readonly io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionarySingle$SwitchDictionarySingleSubscriber<object, R> fd0e45878;

    pa9d45ef6$p6fb43174$p31c54af0(io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionarySingle$SwitchDictionarySingleSubscriber<object, R> flowableSwitchDictionarySingle$SwitchDictionarySingleSubscriber) {
        this.fd0e45878 = flowableSwitchDictionarySingle$SwitchDictionarySingleSubscriber;
    }

    public static void HNMSqSHpTHQCETaP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pa9d45ef6$p6fb43174 pa9d45ef6_p6fb43174) {
        pa9d45ef6_p6fb43174.drain();
    }

    public static bool LwkbLeGFagGdlkjg(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void TEbRwzgEsGOyWbBq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pa9d45ef6$p6fb43174 pa9d45ef6_p6fb43174, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pa9d45ef6$p6fb43174$p31c54af0 pa9d45ef6_p6fb43174_p31c54af0, java.lang.Exception th) {
        pa9d45ef6_p6fb43174.innerError(pa9d45ef6_p6fb43174_p31c54af0, th);
    }

    public static bool YVhxjYkvJGRkBeiH(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    void dispose() {
        yVhxjYkvJGRkBeiH(this);
    }

    public override void OnError(java.lang.Exception th) {
        tEbRwzgEsGOyWbBq(this.fd0e45878, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        lwkbLeGFagGdlkjg(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        this.f447b7147 = r;
        HNMSqSHpTHQCETaP(this.fd0e45878);
    }
}

