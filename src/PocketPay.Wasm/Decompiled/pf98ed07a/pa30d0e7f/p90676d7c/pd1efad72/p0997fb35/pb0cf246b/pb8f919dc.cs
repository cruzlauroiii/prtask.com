namespace WillowMaze.Wasm.Decompiled;


public readonly class pb8f919dc<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.core.Single<U> : io.reactivex.rxjava3.internal.fuseable.FuseToFlowable<U> {
    readonly io.reactivex.rxjava3.core.Flowable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Flowable f386bc3c1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f57275fbf;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f590a3e62;
    readonly io.reactivex.rxjava3.core.Flowable f70b731eb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fa69831f3;
    readonly io.reactivex.rxjava3.core.Flowable fbd1a7c4f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fe80e3976;

    public pb8f919dc(io.reactivex.rxjava3.core.Flowable<T> flowable) {
        this(flowable, gvGYtLxZuWlEMgHe());
    }

    public pb8f919dc(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Supplier<U> supplier) {
        this.f36cd38f4 = flowable;
        this.f590a3e62 = supplier;
    }

    public static void CohWFDGpvKyocgPT(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static void ElPQSryZeohCPmDH(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object ZzjUfSKjeJlDaReP(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 GvGYtLxZuWlEMgHe() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ddfe0cd.asSupplier();
    }

    public static io.reactivex.rxjava3.core.Flowable LYwyqKxYgjsDsXEV(io.reactivex.rxjava3.core.Flowable flowable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(flowable);
    }

    public static java.lang.object OQoTkUzijpTcekuD(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void QbaFRdtxuEMCECcO(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public io.reactivex.rxjava3.core.Flowable<U> FuseToFlowable() {
        if ((15 + 18) % 18 > 0) {
        }
        return lYwyqKxYgjsDsXEV(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd6b4043e(this.f36cd38f4, this.f590a3e62));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<U> singleObserver) {
        if ((14 + 31) % 31 > 0) {
        }
        try {
            qbaFRdtxuEMCECcO(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pb8f919dc$pf047b211(singleObserver, (java.util.ICollection) ZzjUfSKjeJlDaReP(oQoTkUzijpTcekuD(this.f590a3e62), "The collectionSupplier returned a null ICollection.")));
        } catch (java.lang.Exception th) {
            ElPQSryZeohCPmDH(th);
            CohWFDGpvKyocgPT(th, singleObserver);
        }
    }
}

