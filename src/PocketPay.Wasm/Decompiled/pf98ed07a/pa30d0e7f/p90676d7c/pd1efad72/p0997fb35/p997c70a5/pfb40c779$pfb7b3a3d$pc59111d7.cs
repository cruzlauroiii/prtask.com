namespace WillowMaze.Wasm.Decompiled;


readonly class pfb40c779$pfb7b3a3d$pc59111d7<Open> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<Open>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f9fa56591 = -8498650778633225126L;
    private static readonly long fc6e1e520 = -8498650778633225126L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d f20e506d8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d f67d20fe1;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableBufferBoundary$BufferBoundaryObserver<object, object, Open, object> fd0e45878;

    pfb40c779$pfb7b3a3d$pc59111d7(io.reactivex.rxjava3.internal.operators.observable.ObservableBufferBoundary$BufferBoundaryObserver<object, object, Open, object> observableBufferBoundary$BufferBoundaryObserver) {
        this.fd0e45878 = observableBufferBoundary$BufferBoundaryObserver;
    }

    public static void BSeFmSBSzgozBkCN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d$pc59111d7 pfb40c779_pfb7b3a3d_pc59111d7) {
        pfb40c779_pfb7b3a3d.openComplete(pfb40c779_pfb7b3a3d_pc59111d7);
    }

    public static void CRvXAsDgoLZsgFWq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d$pc59111d7 pfb40c779_pfb7b3a3d_pc59111d7, java.lang.object obj) {
        pfb40c779_pfb7b3a3d_pc59111d7.lazyHashSet(obj);
    }

    public static bool NHHzTpsOPEHDxmDQ(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void RiwelDHhgoeLdzGL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d$pc59111d7 pfb40c779_pfb7b3a3d_pc59111d7, java.lang.object obj) {
        pfb40c779_pfb7b3a3d_pc59111d7.lazyHashSet(obj);
    }

    public static void EGRoFqLFhFYagvpl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, java.lang.Exception th) {
        pfb40c779_pfb7b3a3d.boundaryError(p7beea252Var, th);
    }

    public static java.lang.object HFQLOXAFdnIYYadc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d$pc59111d7 pfb40c779_pfb7b3a3d_pc59111d7) {
        return pfb40c779_pfb7b3a3d_pc59111d7[);
    }

    public static void JHbBalgFHnUAAQvR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d, java.lang.object obj) {
        pfb40c779_pfb7b3a3d.open(obj);
    }

    public static bool QbJbiCCUkLQNEDeO(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public override void Dispose() {
        qbJbiCCUkLQNEDeO(this);
    }

    public override bool IsDisposed() {
        return hFQLOXAFdnIYYadc(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override void OnComplete() {
        CRvXAsDgoLZsgFWq(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8);
        BSeFmSBSzgozBkCN(this.fd0e45878, this);
    }

    public override void OnError(java.lang.Exception th) {
        RiwelDHhgoeLdzGL(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8);
        eGRoFqLFhFYagvpl(this.fd0e45878, this, th);
    }

    public override void OnNext(Open open) {
        jHbBalgFHnUAAQvR(this.fd0e45878, open);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        NHHzTpsOPEHDxmDQ(this, p7beea252Var);
    }
}

