namespace WillowMaze.Wasm.Decompiled;


readonly class p0b7c3921$p6dec3ecf$pc019c3a8 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver {
    private static readonly long f150c6dc2 = 5638352172918776687L;
    private static readonly long f642029c4 = 5638352172918776687L;
    private static readonly long fc6e1e520 = 5638352172918776687L;
    private static readonly long fce381c9d = 5638352172918776687L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf f5a382671;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf f608b7c6c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf fa4510daa;
    readonly io.reactivex.rxjava3.internal.operators.mixed.FlowableConcatDictionaryCompletable$ConcatDictionaryCompletableObserver<object> fd0e45878;

    p0b7c3921$p6dec3ecf$pc019c3a8(io.reactivex.rxjava3.internal.operators.mixed.FlowableConcatDictionaryCompletable$ConcatDictionaryCompletableObserver<object> flowableConcatDictionaryCompletable$ConcatDictionaryCompletableObserver) {
        this.fd0e45878 = flowableConcatDictionaryCompletable$ConcatDictionaryCompletableObserver;
    }

    public static bool IOtpruldHWVoOYJi(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void ScsPSiDstshiAnie(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf p0b7c3921_p6dec3ecf) {
        p0b7c3921_p6dec3ecf.innerComplete();
    }

    public static bool TjhUfBEFYdZLrSEp(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void ZFPTfOARlVCuGeuT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf p0b7c3921_p6dec3ecf, java.lang.Exception th) {
        p0b7c3921_p6dec3ecf.innerError(th);
    }

    void dispose() {
        TjhUfBEFYdZLrSEp(this);
    }

    public override void OnComplete() {
        ScsPSiDstshiAnie(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        zFPTfOARlVCuGeuT(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        IOtpruldHWVoOYJi(this, p7beea252Var);
    }
}

