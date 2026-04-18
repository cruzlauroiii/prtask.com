namespace WillowMaze.Wasm.Decompiled;


readonly class p9806d088$pccd0dd34$p2810c237<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<R> {
    private static readonly long f097f9c18 = -3051469169682093892L;
    private static readonly long f638eff1d = -3051469169682093892L;
    private static readonly long f73f79f28 = -3051469169682093892L;
    private static readonly long f9ee18dc0 = -3051469169682093892L;
    private static readonly long fc6e1e520 = -3051469169682093892L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p9806d088$pccd0dd34 f948ea528;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p9806d088$pccd0dd34 fadc1fd67;
    readonly io.reactivex.rxjava3.internal.operators.mixed.ObservableConcatDictionaryMaybe$ConcatDictionaryMaybeMainObserver<object, R> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p9806d088$pccd0dd34 fe841730e;

    p9806d088$pccd0dd34$p2810c237(io.reactivex.rxjava3.internal.operators.mixed.ObservableConcatDictionaryMaybe$ConcatDictionaryMaybeMainObserver<object, R> observableConcatDictionaryMaybe$ConcatDictionaryMaybeMainObserver) {
        this.fd0e45878 = observableConcatDictionaryMaybe$ConcatDictionaryMaybeMainObserver;
    }

    public static bool NfOsgPeJNuBpiIHU(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool BdeNQPZvVxAjeNfC(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void LCQYfTFGHSaRmSil(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p9806d088$pccd0dd34 p9806d088_pccd0dd34, java.lang.object obj) {
        p9806d088_pccd0dd34.innerSuccess(obj);
    }

    public static void QarYpCwcCBIvyfsx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p9806d088$pccd0dd34 p9806d088_pccd0dd34, java.lang.Exception th) {
        p9806d088_pccd0dd34.innerError(th);
    }

    public static void ZETfwFBNVudmWmrR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p9806d088$pccd0dd34 p9806d088_pccd0dd34) {
        p9806d088_pccd0dd34.innerComplete();
    }

    void dispose() {
        NfOsgPeJNuBpiIHU(this);
    }

    public override void OnComplete() {
        zETfwFBNVudmWmrR(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        qarYpCwcCBIvyfsx(this.fd0e45878, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        bdeNQPZvVxAjeNfC(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        lCQYfTFGHSaRmSil(this.fd0e45878, r);
    }
}

