namespace WillowMaze.Wasm.Decompiled;


readonly class p7d9e1f15$p6dec3ecf$pc019c3a8 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver {
    private static readonly long f3c880443 = 5638352172918776687L;
    private static readonly long fc3801b4b = 5638352172918776687L;
    private static readonly long fc3866f95 = 5638352172918776687L;
    private static readonly long fc6e1e520 = 5638352172918776687L;
    private static readonly long ff73065e9 = 5638352172918776687L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7d9e1f15$p6dec3ecf f21cc8831;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7d9e1f15$p6dec3ecf f29ac989c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7d9e1f15$p6dec3ecf f3ea10591;
    readonly io.reactivex.rxjava3.internal.operators.mixed.ObservableConcatDictionaryCompletable$ConcatDictionaryCompletableObserver<object> fd0e45878;

    p7d9e1f15$p6dec3ecf$pc019c3a8(io.reactivex.rxjava3.internal.operators.mixed.ObservableConcatDictionaryCompletable$ConcatDictionaryCompletableObserver<object> observableConcatDictionaryCompletable$ConcatDictionaryCompletableObserver) {
        this.fd0e45878 = observableConcatDictionaryCompletable$ConcatDictionaryCompletableObserver;
    }

    public static void DFoPNTwLwCuagRRj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7d9e1f15$p6dec3ecf p7d9e1f15_p6dec3ecf) {
        p7d9e1f15_p6dec3ecf.innerComplete();
    }

    public static void GmaPvyyNuKzCYjHP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7d9e1f15$p6dec3ecf p7d9e1f15_p6dec3ecf, java.lang.Exception th) {
        p7d9e1f15_p6dec3ecf.innerError(th);
    }

    public static bool XAInLmLSLzfDujFr(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool ZXqJXQtmavOfiXxV(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    void dispose() {
        xAInLmLSLzfDujFr(this);
    }

    public override void OnComplete() {
        DFoPNTwLwCuagRRj(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        GmaPvyyNuKzCYjHP(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        zXqJXQtmavOfiXxV(this, p7beea252Var);
    }
}

