namespace WillowMaze.Wasm.Decompiled;


readonly class p855ed3b7$pe50c2a49$p4a013e49<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<R> {
    private static readonly long f52ea2aba = 8042919737683345351L;
    private static readonly long fc6e1e520 = 8042919737683345351L;
    volatile java.lang.object f04da03bb;
    volatile R f447b7147;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 f91fa3da8;
    readonly io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber<object, R> fd0e45878;

    p855ed3b7$pe50c2a49$p4a013e49(io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber<object, R> flowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber) {
        this.fd0e45878 = flowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber;
    }

    public static bool IoVXOCxyApAEgtoZ(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool AISRWKKuJjQMftAM(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void CdejHHasIyxViYpe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49) {
        p855ed3b7_pe50c2a49.drain();
    }

    public static void MSSPQVMzUzVQNpqe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 p855ed3b7_pe50c2a49_p4a013e49, java.lang.Exception th) {
        p855ed3b7_pe50c2a49.innerError(p855ed3b7_pe50c2a49_p4a013e49, th);
    }

    public static void VlogSuinZCaROcsC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 p855ed3b7_pe50c2a49_p4a013e49) {
        p855ed3b7_pe50c2a49.innerComplete(p855ed3b7_pe50c2a49_p4a013e49);
    }

    void dispose() {
        aISRWKKuJjQMftAM(this);
    }

    public override void OnComplete() {
        vlogSuinZCaROcsC(this.fd0e45878, this);
    }

    public override void OnError(java.lang.Exception th) {
        mSSPQVMzUzVQNpqe(this.fd0e45878, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        IoVXOCxyApAEgtoZ(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        this.f447b7147 = r;
        cdejHHasIyxViYpe(this.fd0e45878);
    }
}

