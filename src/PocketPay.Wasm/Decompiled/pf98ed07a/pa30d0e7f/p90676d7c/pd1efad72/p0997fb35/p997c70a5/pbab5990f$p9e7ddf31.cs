namespace WillowMaze.Wasm.Decompiled;


readonly class pbab5990f$p9e7ddf31<T> : io.reactivex.rxjava3.core.Observer<java.lang.object> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbab5990f$pabe34eb8 f07148cba;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbab5990f$pabe34eb8 f0f1f2b61;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableSampleWithObservable$SampleMainObserver<T> fd0e45878;

    pbab5990f$p9e7ddf31(io.reactivex.rxjava3.internal.operators.observable.ObservableSampleWithObservable$SampleMainObserver<T> observableSampleWithObservable$SampleMainObserver) {
        this.fd0e45878 = observableSampleWithObservable$SampleMainObserver;
    }

    public static void UiwcqpXcJjjEMbDg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbab5990f$pabe34eb8 pbab5990f_pabe34eb8) {
        pbab5990f_pabe34eb8.run();
    }

    public static void XkdjEhUtqyuEIBBJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbab5990f$pabe34eb8 pbab5990f_pabe34eb8, java.lang.Exception th) {
        pbab5990f_pabe34eb8.error(th);
    }

    public static void HUfSiLULUvdXyGaB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbab5990f$pabe34eb8 pbab5990f_pabe34eb8) {
        pbab5990f_pabe34eb8.complete();
    }

    public static bool JYRPPeAvjvovQykQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbab5990f$pabe34eb8 pbab5990f_pabe34eb8, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pbab5990f_pabe34eb8.setOther(p7beea252Var);
    }

    public override void OnComplete() {
        hUfSiLULUvdXyGaB(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        XkdjEhUtqyuEIBBJ(this.fd0e45878, th);
    }

    public override void OnNext(java.lang.object obj) {
        UiwcqpXcJjjEMbDg(this.fd0e45878);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        jYRPPeAvjvovQykQ(this.fd0e45878, p7beea252Var);
    }
}

