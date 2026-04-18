namespace WillowMaze.Wasm.Decompiled;


readonly class pd6811bcc$pfb7b3a3d<T, U : java.util.ICollection<T>, B> : io.reactivex.rxjava3.observers.DisposableObserver<B> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd6811bcc$pd603aa0f f3dfc7c13;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd6811bcc$pd603aa0f f822f1ce8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd6811bcc$pd603aa0f fada82fab;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableBufferExactBoundary$BufferExactBoundaryObserver<T, U, B> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd6811bcc$pd603aa0f ff91e88d3;

    pd6811bcc$pfb7b3a3d(io.reactivex.rxjava3.internal.operators.observable.ObservableBufferExactBoundary$BufferExactBoundaryObserver<T, U, B> observableBufferExactBoundary$BufferExactBoundaryObserver) {
        this.fd0e45878 = observableBufferExactBoundary$BufferExactBoundaryObserver;
    }

    public static void DPKMsqObxFhXsYfZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd6811bcc$pd603aa0f pd6811bcc_pd603aa0f, java.lang.Exception th) {
        pd6811bcc_pd603aa0f.onError(th);
    }

    public static void TTIcWLWqgLMBMURV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd6811bcc$pd603aa0f pd6811bcc_pd603aa0f) {
        pd6811bcc_pd603aa0f.onComplete();
    }

    public static void SOzNSonLzrpVpIhi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd6811bcc$pd603aa0f pd6811bcc_pd603aa0f) {
        pd6811bcc_pd603aa0f.Current;
    }

    public void OnComplete() {
        TTIcWLWqgLMBMURV(this.fd0e45878);
    }

    public void OnError(java.lang.Exception th) {
        DPKMsqObxFhXsYfZ(this.fd0e45878, th);
    }

    public void OnNext(B b) {
        sOzNSonLzrpVpIhi(this.fd0e45878);
    }
}

