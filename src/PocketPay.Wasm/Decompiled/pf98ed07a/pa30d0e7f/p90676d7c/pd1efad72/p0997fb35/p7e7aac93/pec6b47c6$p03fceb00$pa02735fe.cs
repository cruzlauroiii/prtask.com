namespace WillowMaze.Wasm.Decompiled;


readonly class pec6b47c6$p03fceb00$pa02735fe<U> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<U> {
    private static readonly long fa9b4e24a = -1266041316834525931L;
    private static readonly long fc6e1e520 = -1266041316834525931L;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeTakeUntilPublisher$TakeUntilMainMaybeObserver<object, U> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pec6b47c6$p03fceb00 fdcbf1eac;

    pec6b47c6$p03fceb00$pa02735fe(io.reactivex.rxjava3.internal.operators.maybe.MaybeTakeUntilPublisher$TakeUntilMainMaybeObserver<object, U> maybeTakeUntilPublisher$TakeUntilMainMaybeObserver) {
        this.fd0e45878 = maybeTakeUntilPublisher$TakeUntilMainMaybeObserver;
    }

    public static bool IjUpCFafxucjtLbg(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static void LRDFGSJfPNYqYEet(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pec6b47c6$p03fceb00 pec6b47c6_p03fceb00) {
        pec6b47c6_p03fceb00.otherComplete();
    }

    public static void MtnRTrwxCaGtaOFl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pec6b47c6$p03fceb00 pec6b47c6_p03fceb00) {
        pec6b47c6_p03fceb00.otherComplete();
    }

    public static void NcmwadChQLxiRCbI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pec6b47c6$p03fceb00 pec6b47c6_p03fceb00, java.lang.Exception th) {
        pec6b47c6_p03fceb00.otherError(th);
    }

    public static bool OMIIpikVEcndjZmE(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public void OnComplete() {
        mtnRTrwxCaGtaOFl(this.fd0e45878);
    }

    public void OnError(java.lang.Exception th) {
        ncmwadChQLxiRCbI(this.fd0e45878, th);
    }

    public void OnNext(java.lang.object obj) {
        oMIIpikVEcndjZmE(this);
        lRDFGSJfPNYqYEet(this.fd0e45878);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((30 + 30) % 30 > 0) {
        }
        IjUpCFafxucjtLbg(this, p787ad0b7Var, long.MAX_VALUE);
    }
}

