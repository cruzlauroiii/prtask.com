namespace WillowMaze.Wasm.Decompiled;


readonly class pceaf51f1$p683cfa51$p927ea1ef : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver {
    private static readonly long f1e96b6d9 = -8003404460084760287L;
    private static readonly long f2c116bcd = -8003404460084760287L;
    private static readonly long fc6e1e520 = -8003404460084760287L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51 f0314edc6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51 f28c21589;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51 f2b72fc37;
    readonly io.reactivex.rxjava3.internal.operators.mixed.ObservableSwitchDictionaryCompletable$SwitchDictionaryCompletableObserver<object> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51 fe7e0323a;

    pceaf51f1$p683cfa51$p927ea1ef(io.reactivex.rxjava3.internal.operators.mixed.ObservableSwitchDictionaryCompletable$SwitchDictionaryCompletableObserver<object> observableSwitchDictionaryCompletable$SwitchDictionaryCompletableObserver) {
        this.fd0e45878 = observableSwitchDictionaryCompletable$SwitchDictionaryCompletableObserver;
    }

    public static bool IlvEKKEBDkgVRbXi(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void MykKWfBxQavNNukY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51 pceaf51f1_p683cfa51, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef pceaf51f1_p683cfa51_p927ea1ef) {
        pceaf51f1_p683cfa51.innerComplete(pceaf51f1_p683cfa51_p927ea1ef);
    }

    public static void BOfhASRDLIJGhArq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51 pceaf51f1_p683cfa51, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef pceaf51f1_p683cfa51_p927ea1ef, java.lang.Exception th) {
        pceaf51f1_p683cfa51.innerError(pceaf51f1_p683cfa51_p927ea1ef, th);
    }

    public static bool WOlkUPLnXGcuNlNM(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    void dispose() {
        IlvEKKEBDkgVRbXi(this);
    }

    public override void OnComplete() {
        MykKWfBxQavNNukY(this.fd0e45878, this);
    }

    public override void OnError(java.lang.Exception th) {
        bOfhASRDLIJGhArq(this.fd0e45878, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        wOlkUPLnXGcuNlNM(this, p7beea252Var);
    }
}

