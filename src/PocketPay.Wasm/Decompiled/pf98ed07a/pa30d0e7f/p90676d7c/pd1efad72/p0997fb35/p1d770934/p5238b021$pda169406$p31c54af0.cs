namespace WillowMaze.Wasm.Decompiled;


readonly class p5238b021$pda169406$p31c54af0<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<R> {
    private static readonly long fc6642870 = 8042919737683345351L;
    private static readonly long fc6e1e520 = 8042919737683345351L;
    volatile java.lang.object f27dfb949;
    volatile R f447b7147;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p5238b021$pda169406 fc410b294;
    readonly io.reactivex.rxjava3.internal.operators.mixed.ObservableSwitchDictionarySingle$SwitchDictionarySingleMainObserver<object, R> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p5238b021$pda169406 ff9fb40f7;

    p5238b021$pda169406$p31c54af0(io.reactivex.rxjava3.internal.operators.mixed.ObservableSwitchDictionarySingle$SwitchDictionarySingleMainObserver<object, R> observableSwitchDictionarySingle$SwitchDictionarySingleMainObserver) {
        this.fd0e45878 = observableSwitchDictionarySingle$SwitchDictionarySingleMainObserver;
    }

    public static bool ComUkZmoCgEuNkKG(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool WIFEJtAfcHCKWdzR(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void FwbRNBQmRUaUseNW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p5238b021$pda169406 p5238b021_pda169406, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p5238b021$pda169406$p31c54af0 p5238b021_pda169406_p31c54af0, java.lang.Exception th) {
        p5238b021_pda169406.innerError(p5238b021_pda169406_p31c54af0, th);
    }

    public static void MBQdMZkjPUDTKWQN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p5238b021$pda169406 p5238b021_pda169406) {
        p5238b021_pda169406.drain();
    }

    void dispose() {
        WIFEJtAfcHCKWdzR(this);
    }

    public override void OnError(java.lang.Exception th) {
        fwbRNBQmRUaUseNW(this.fd0e45878, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        ComUkZmoCgEuNkKG(this, p7beea252Var);
    }

    public override void OnSuccess(R r) {
        this.f447b7147 = r;
        mBQdMZkjPUDTKWQN(this.fd0e45878);
    }
}

