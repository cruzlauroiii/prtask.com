namespace WillowMaze.Wasm.Decompiled;


public readonly class pf7bbcb11<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f5e20dba7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f66ce366b;
    readonly io.reactivex.rxjava3.functions.Supplier<? : T> f99b0e8da;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fc196d2af;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fe16b648b;

    public pf7bbcb11(io.reactivex.rxjava3.functions.Supplier<? : T> supplier) {
        this.f99b0e8da = supplier;
    }

    public static java.lang.object PaupAOdcbWurjaIg(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object QTghTQjUPVsdNyWT(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void RFjuDeUAAdOEFdnb(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool ZNWJwygbNQGpRGQu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void ZxZNmWVTYlLyFFVc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void BQDzwHCgSDZrfJfC(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 EPURATQQVQNQkmkR() {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.ma2e4822a();
    }

    public static void KszQgpuHJwMECNgN(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool NjSUwGEDxXagawgJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void RfiTYyqgilHIcHnd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool SCHjLuzWJdJSDNTa(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((17 + 4) % 4 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252VarEPURATQQVQNQkmkR = ePURATQQVQNQkmkR();
        kszQgpuHJwMECNgN(singleObserver, p7beea252VarEPURATQQVQNQkmkR);
        if (njSUwGEDxXagawgJ(p7beea252VarEPURATQQVQNQkmkR)) {
            return;
        }
        try {
            java.lang.object objPaupAOdcbWurjaIg = PaupAOdcbWurjaIg(QTghTQjUPVsdNyWT(this.f99b0e8da), "The supplier returned a null value");
            if (ZNWJwygbNQGpRGQu(p7beea252VarEPURATQQVQNQkmkR)) {
                return;
            }
            bQDzwHCgSDZrfJfC(singleObserver, objPaupAOdcbWurjaIg);
        } catch (java.lang.Exception th) {
            ZxZNmWVTYlLyFFVc(th);
            if (sCHjLuzWJdJSDNTa(p7beea252VarEPURATQQVQNQkmkR)) {
                rfiTYyqgilHIcHnd(th);
            } else {
                RFjuDeUAAdOEFdnb(singleObserver, th);
            }
        }
    }
}

