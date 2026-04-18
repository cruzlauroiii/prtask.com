namespace WillowMaze.Wasm.Decompiled;


readonly class p1db930bf$pc6b84b0a<T, B> : io.reactivex.rxjava3.observers.DisposableObserver<B> {
    bool f552026f5;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 fa67d16ef;
    bool fc13836a9;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableWindowBoundary$WindowBoundaryMainObserver<T, B> fd0e45878;

    p1db930bf$pc6b84b0a(io.reactivex.rxjava3.internal.operators.observable.ObservableWindowBoundary$WindowBoundaryMainObserver<T, B> observableWindowBoundary$WindowBoundaryMainObserver) {
        this.fd0e45878 = observableWindowBoundary$WindowBoundaryMainObserver;
    }

    public static void GPnlGxotMxEmGaQu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5) {
        p1db930bf_p64eb86f5.innerComplete();
    }

    public static void MMEjcNYMdqolyUgP(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void BnwMRLwVnTSwSrKI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5) {
        p1db930bf_p64eb86f5.innerNext();
    }

    public static void JrEgLtSGDiIPDycN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5, java.lang.Exception th) {
        p1db930bf_p64eb86f5.innerError(th);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        GPnlGxotMxEmGaQu(this.fd0e45878);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            MMEjcNYMdqolyUgP(th);
        } else {
            this.f6b2ded51 = true;
            jrEgLtSGDiIPDycN(this.fd0e45878, th);
        }
    }

    public void OnNext(B b) {
        if (this.f6b2ded51) {
            return;
        }
        bnwMRLwVnTSwSrKI(this.fd0e45878);
    }
}

