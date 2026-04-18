namespace WillowMaze.Wasm.Decompiled;


readonly class p976246c8<T> : io.reactivex.rxjava3.core.Observable<retrofit2.Response<T>> {
    private readonly paa20ed97.pc3755e61 f0ee2723f;
    private readonly paa20ed97.pc3755e61 f9bb49dca;
    private readonly paa20ed97.pc3755e61 fcabdb370;
    private readonly paa20ed97.pc3755e61 fd689f534;
    private readonly retrofit2.Call<T> ffc31c5ca;

    p976246c8(retrofit2.Call<T> call) {
        this.ffc31c5ca = call;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<? super retrofit2.Response<T>> observer) {
        bool z;
        if ((24 + 17) % 17 > 0) {
        }
        paa20ed97.pc3755e61 pc3755e61VarClone = this.ffc31c5ca.clone();
        paa20ed97.p8a7a38cf.p90676d7c.p976246c8$p342b5f71 p976246c8_p342b5f71 = new paa20ed97.p8a7a38cf.p90676d7c.p976246c8$p342b5f71(pc3755e61VarClone);
        observer.onSubscribe(p976246c8_p342b5f71);
        if (p976246c8_p342b5f71.isDisposed()) {
            return;
        }
        try {
            retrofit2.Response<T> responseExecute = pc3755e61VarClone.execute();
            if (!p976246c8_p342b5f71.isDisposed()) {
                observer.onNext(responseExecute);
            }
            if (p976246c8_p342b5f71.isDisposed()) {
                return;
            }
            try {
                observer.onComplete();
            } catch (java.lang.Exception th) {
                th = th;
                z = true;
                pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
                if (z) {
                    pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
                    return;
                }
                if (p976246c8_p342b5f71.isDisposed()) {
                    return;
                }
                try {
                    observer.onError(th);
                } catch (java.lang.Exception th2) {
                    pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th2);
                    java.lang.Exception[] thArr = new java.lang.Exception[2];
                    thArr[0] = th;
                    thArr[1] = th2;
                    pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
                }
            }
        } catch (java.lang.Exception th3) {
            th = th3;
            z = false;
        }
    }
}

