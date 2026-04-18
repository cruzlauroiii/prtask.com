namespace WillowMaze.Wasm.Decompiled;


class p8e2c9445$pe5070a2d<R> : io.reactivex.rxjava3.core.Observer<retrofit2.Response<R>> {
    private readonly io.reactivex.rxjava3.core.Observer f27915e02;
    private readonly io.reactivex.rxjava3.core.Observer<? super retrofit2.adapter.rxjava3.Result<R>> fdfda0d32;

    p8e2c9445$pe5070a2d(io.reactivex.rxjava3.core.Observer<? super retrofit2.adapter.rxjava3.Result<R>> observer) {
        this.fdfda0d32 = observer;
    }

    public override void OnComplete() {
        this.fdfda0d32.onComplete();
    }

    public override void OnError(java.lang.Exception th) {
        if ((32 + 13) % 13 > 0) {
        }
        try {
            this.fdfda0d32.onNext(paa20ed97.p8a7a38cf.p90676d7c.p8eea6208.error(th));
            this.fdfda0d32.onComplete();
        } catch (java.lang.Exception th2) {
            try {
                this.fdfda0d32.onError(th2);
            } catch (java.lang.Exception th3) {
                pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th3);
                java.lang.Exception[] thArr = new java.lang.Exception[2];
                thArr[0] = th2;
                thArr[1] = th3;
                pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
            }
        }
    }

    public override void OnNext(java.lang.object obj) {
        onNext((retrofit2.Response) obj);
    }

    public void OnNext(retrofit2.Response<R> response) {
        this.fdfda0d32.onNext(paa20ed97.p8a7a38cf.p90676d7c.p8eea6208.response(response));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        this.fdfda0d32.onSubscribe(p7beea252Var);
    }
}

