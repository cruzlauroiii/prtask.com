namespace WillowMaze.Wasm.Decompiled;


public readonly class p17f60e41<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly io.reactivex.rxjava3.functions.Supplier<? : java.lang.Exception> f6906652a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fd5d3a138;

    public p17f60e41(io.reactivex.rxjava3.functions.Supplier<? : java.lang.Exception> supplier) {
        this.f6906652a = supplier;
    }

    public static java.lang.object DClFCPxIkPwsEQLl(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static java.lang.object GkHuioEYvuwQEKon(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void YQpOYkfZYRmGVOuy(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void ZFmtmomkRMIxknxu(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        try {
            th = (java.lang.Exception) DClFCPxIkPwsEQLl(gkHuioEYvuwQEKon(this.f6906652a), "Supplier returned a null Exception.");
        } catch (java.lang.Exception th) {
            th = th;
            yQpOYkfZYRmGVOuy(th);
        }
        zFmtmomkRMIxknxu(th, observer);
    }
}

