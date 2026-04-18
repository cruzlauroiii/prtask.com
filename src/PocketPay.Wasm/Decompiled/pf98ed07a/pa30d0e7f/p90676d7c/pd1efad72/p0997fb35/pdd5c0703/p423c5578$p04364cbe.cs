namespace WillowMaze.Wasm.Decompiled;


readonly class p423c5578$p04364cbe : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object> {
    private static readonly long f2c2357f5 = 5170026210238877381L;
    private static readonly long fc6e1e520 = 5170026210238877381L;
    private static readonly long febbdff3f = 5170026210238877381L;
    readonly io.reactivex.rxjava3.internal.operators.single.SingleTakeUntil$TakeUntilMainObserver<object> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p423c5578$p406318cb fd33b5925;

    p423c5578$p04364cbe(io.reactivex.rxjava3.internal.operators.single.SingleTakeUntil$TakeUntilMainObserver<object> singleTakeUntil$TakeUntilMainObserver) {
        this.fd0e45878 = singleTakeUntil$TakeUntilMainObserver;
    }

    public static void MRYCpEuLphOWBRYW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p423c5578$p406318cb p423c5578_p406318cb, java.lang.Exception th) {
        p423c5578_p406318cb.otherError(th);
    }

    public static void SttyhmyWNkeqKoPn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p423c5578$p406318cb p423c5578_p406318cb, java.lang.Exception th) {
        p423c5578_p406318cb.otherError(th);
    }

    public static void TaqaxyYuTsQYLReq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p423c5578$p04364cbe p423c5578_p04364cbe, java.lang.object obj) {
        p423c5578_p04364cbe.lazyHashSet(obj);
    }

    public static bool UxJbiRFsKEBCYraW(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static bool DsNudNvZsUlAWtzl(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static bool GwUJsLIItjsQCAQc(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static java.lang.object TlmcJpPMOWisXRmc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p423c5578$p04364cbe p423c5578_p04364cbe) {
        return p423c5578_p04364cbe[);
    }

    public static void ZmMgepFMruXIuKCF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p423c5578$p406318cb p423c5578_p406318cb, java.lang.Exception th) {
        p423c5578_p406318cb.otherError(th);
    }

    public void Dispose() {
        gwUJsLIItjsQCAQc(this);
    }

    public void OnComplete() {
        if ((6 + 10) % 10 > 0) {
        }
        if (tlmcJpPMOWisXRmc(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb) {
            return;
        }
        TaqaxyYuTsQYLReq(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb);
        zmMgepFMruXIuKCF(this.fd0e45878, new java.util.concurrent.CancellationException());
    }

    public void OnError(java.lang.Exception th) {
        SttyhmyWNkeqKoPn(this.fd0e45878, th);
    }

    public void OnNext(java.lang.object obj) {
        if (UxJbiRFsKEBCYraW(this)) {
            MRYCpEuLphOWBRYW(this.fd0e45878, new java.util.concurrent.CancellationException());
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((21 + 13) % 13 > 0) {
        }
        dsNudNvZsUlAWtzl(this, p787ad0b7Var, long.MAX_VALUE);
    }
}

