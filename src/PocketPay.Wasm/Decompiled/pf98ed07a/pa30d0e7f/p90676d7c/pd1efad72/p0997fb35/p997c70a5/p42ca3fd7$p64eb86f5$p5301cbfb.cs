namespace WillowMaze.Wasm.Decompiled;


readonly class p42ca3fd7$p64eb86f5$p5301cbfb<B> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<B> {
    private static readonly long f395d410f = -3326496781427702834L;
    private static readonly long f577cbdf7 = -3326496781427702834L;
    private static readonly long f8e74823c = -3326496781427702834L;
    private static readonly long fb8095dce = -3326496781427702834L;
    private static readonly long fc6e1e520 = -3326496781427702834L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p42ca3fd7$p64eb86f5 f26e6fb02;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p42ca3fd7$p64eb86f5 f6dd61367;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p42ca3fd7$p64eb86f5 f86744566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p42ca3fd7$p64eb86f5 fbadc2686;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableWindowBoundarySelector$WindowBoundaryMainObserver<object, B, object> fd0e45878;

    p42ca3fd7$p64eb86f5$p5301cbfb(io.reactivex.rxjava3.internal.operators.observable.ObservableWindowBoundarySelector$WindowBoundaryMainObserver<object, B, object> observableWindowBoundarySelector$WindowBoundaryMainObserver) {
        this.fd0e45878 = observableWindowBoundarySelector$WindowBoundaryMainObserver;
    }

    public static bool KzIazyAMRwzZnovR(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void VauhEiiCiksxFosI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p42ca3fd7$p64eb86f5 p42ca3fd7_p64eb86f5, java.lang.object obj) {
        p42ca3fd7_p64eb86f5.open(obj);
    }

    public static void IbxECwyOnOfxvnHs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p42ca3fd7$p64eb86f5 p42ca3fd7_p64eb86f5) {
        p42ca3fd7_p64eb86f5.openComplete();
    }

    public static void PIjNyandPXZnHFwF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p42ca3fd7$p64eb86f5 p42ca3fd7_p64eb86f5, java.lang.Exception th) {
        p42ca3fd7_p64eb86f5.openError(th);
    }

    public static bool SWSlVDywQuNURprL(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    void dispose() {
        KzIazyAMRwzZnovR(this);
    }

    public override void OnComplete() {
        ibxECwyOnOfxvnHs(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        pIjNyandPXZnHFwF(this.fd0e45878, th);
    }

    public override void OnNext(B b) {
        VauhEiiCiksxFosI(this.fd0e45878, b);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        sWSlVDywQuNURprL(this, p7beea252Var);
    }
}

