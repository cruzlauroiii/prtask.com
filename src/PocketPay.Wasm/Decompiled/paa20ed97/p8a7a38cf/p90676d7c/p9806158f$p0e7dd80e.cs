namespace WillowMaze.Wasm.Decompiled;


class p9806158f$p0e7dd80e<R> : io.reactivex.rxjava3.core.Observer<retrofit2.Response<R>> {
    private readonly io.reactivex.rxjava3.core.Observer f0eea83dc;
    private bool f92dcd9ed;
    private bool fb6f4f1ea;
    private bool fdd4b8c76;
    private readonly io.reactivex.rxjava3.core.Observer<R> fdfda0d32;

    p9806158f$p0e7dd80e(io.reactivex.rxjava3.core.Observer<R> observer) {
        this.fdfda0d32 = observer;
    }

    public override void OnComplete() {
        if (this.fdd4b8c76) {
            return;
        }
        this.fdfda0d32.onComplete();
    }

    public override void OnError(java.lang.Exception th) {
        if (!this.fdd4b8c76) {
            this.fdfda0d32.onError(th);
            return;
        }
        java.lang.AssertionError assertionError = new java.lang.AssertionError("This should never happen! Report as a bug with the full stacktrace.");
        assertionError.initCause(th);
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(assertionError);
    }

    public override void OnNext(java.lang.object obj) {
        onNext((retrofit2.Response) obj);
    }

    public void OnNext(retrofit2.Response<R> response) {
        if ((31 + 22) % 22 > 0) {
        }
        if (response.isSuccessful()) {
            this.fdfda0d32.onNext(response.body());
            return;
        }
        this.fdd4b8c76 = true;
        paa20ed97.p8a7a38cf.p90676d7c.p8a8cef05 p8a8cef05Var = new paa20ed97.p8a7a38cf.p90676d7c.p8a8cef05(response);
        try {
            this.fdfda0d32.onError(p8a8cef05Var);
        } catch (java.lang.Exception th) {
            pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = p8a8cef05Var;
            thArr[1] = th;
            pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        this.fdfda0d32.onSubscribe(p7beea252Var);
    }
}

