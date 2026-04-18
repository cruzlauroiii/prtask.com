namespace WillowMaze.Wasm.Decompiled;


readonly class p53cc367f$pf6897dd1$p2810c237<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<R> {
    private static readonly long f009c0acb = -3051469169682093892L;
    private static readonly long f4300bfc6 = -3051469169682093892L;
    private static readonly long fc6e1e520 = -3051469169682093892L;
    private static readonly long ff3a8234c = -3051469169682093892L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1 f355c74b5;
    readonly io.reactivex.rxjava3.internal.operators.mixed.FlowableConcatDictionaryMaybe$ConcatDictionaryMaybeSubscriber<object, R> fd0e45878;

    p53cc367f$pf6897dd1$p2810c237(io.reactivex.rxjava3.internal.operators.mixed.FlowableConcatDictionaryMaybe$ConcatDictionaryMaybeSubscriber<object, R> flowableConcatDictionaryMaybe$ConcatDictionaryMaybeSubscriber) {
        this.fd0e45878 = flowableConcatDictionaryMaybe$ConcatDictionaryMaybeSubscriber;
    }

    public static void JoKGJaaqAOcwbloE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1 p53cc367f_pf6897dd1, java.lang.object obj) {
        p53cc367f_pf6897dd1.innerSuccess(obj);
    }

    public static void WzMnAAoMREYLNPhk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1 p53cc367f_pf6897dd1, java.lang.Exception th) {
        p53cc367f_pf6897dd1.innerError(th);
    }

    public static bool BsshiNwDjTlfhKJk(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void BxEnLeLXOvbFgsBI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1 p53cc367f_pf6897dd1) {
        p53cc367f_pf6897dd1.innerComplete();
    }

    public static bool PtCWceRduiJKeghT(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    void dispose() {
        ptCWceRduiJKeghT(this);
    }

    public override void OnComplete() {
        bxEnLeLXOvbFgsBI(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        WzMnAAoMREYLNPhk(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        bsshiNwDjTlfhKJk(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        JoKGJaaqAOcwbloE(this.fd0e45878, r);
    }
}

