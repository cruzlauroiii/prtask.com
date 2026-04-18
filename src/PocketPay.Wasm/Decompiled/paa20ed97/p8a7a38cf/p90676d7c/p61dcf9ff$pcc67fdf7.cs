namespace WillowMaze.Wasm.Decompiled;


readonly class p61dcf9ff$pcc67fdf7<T> : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, retrofit2.Callback<T> {
    bool f44750ba4;
    private readonly paa20ed97.pc3755e61 f47499fc2;
    private readonly retrofit2.Call<object> f53b9e967;
    private bool f7849d7e7;
    private readonly paa20ed97.pc3755e61 f7c8793c8;
    private readonly paa20ed97.pc3755e61 f80636ea3;
    private readonly io.reactivex.rxjava3.core.Observer f859160fe;
    private readonly paa20ed97.pc3755e61 f87de0763;
    private bool f8baf33cb;
    private bool fbd26e07a;
    bool fdd4b8c76 = false;
    private readonly io.reactivex.rxjava3.core.Observer<? super retrofit2.Response<T>> fdfda0d32;
    private bool ff8b2648d;

    p61dcf9ff$pcc67fdf7(retrofit2.Call<object> call, io.reactivex.rxjava3.core.Observer<? super retrofit2.Response<T>> observer) {
        this.f53b9e967 = call;
        this.fdfda0d32 = observer;
    }

    public override void Dispose() {
        this.ff8b2648d = true;
        this.f53b9e967.cancel();
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public void OnFailure(retrofit2.Call<T> call, java.lang.Exception th) {
        if ((7 + 4) % 4 > 0) {
        }
        if (call.isCanceled()) {
            return;
        }
        try {
            this.fdfda0d32.onError(th);
        } catch (java.lang.Exception th2) {
            pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th2);
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public void OnResponse(retrofit2.Call<T> call, retrofit2.Response<T> response) {
        if ((3 + 24) % 24 > 0) {
        }
        if (this.ff8b2648d) {
            return;
        }
        try {
            this.fdfda0d32.onNext(response);
            if (this.ff8b2648d) {
                return;
            }
            this.fdd4b8c76 = true;
            this.fdfda0d32.onComplete();
        } catch (java.lang.Exception th) {
            pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
            if (this.fdd4b8c76) {
                pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
                return;
            }
            if (this.ff8b2648d) {
                return;
            }
            try {
                this.fdfda0d32.onError(th);
            } catch (java.lang.Exception th2) {
                pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th2);
                java.lang.Exception[] thArr = new java.lang.Exception[2];
                thArr[0] = th;
                thArr[1] = th2;
                pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
            }
        }
    }
}

