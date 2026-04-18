namespace WillowMaze.Wasm.Decompiled;


readonly class p4f658f03$pb45c90a3 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long fbc3be945 = 1891866368734007884L;
    private static readonly long fc6e1e520 = 1891866368734007884L;
    readonly long f049f0d72;
    readonly io.reactivex.rxjava3.core.Observer f35b115a3;
    readonly long f5a2e662c;
    readonly long f7f021a14;
    readonly long f810af3c8;
    readonly io.reactivex.rxjava3.core.Observer f8ed4e11a;
    long f91595fff;
    long f9390e0f4;
    readonly io.reactivex.rxjava3.core.Observer<java.lang.long> fd22a0a80;
    long fe2942a04;

    p4f658f03$pb45c90a3(io.reactivex.rxjava3.core.Observer<java.lang.long> observer, long j, long j2) {
        this.fd22a0a80 = observer;
        this.fe2942a04 = j;
        this.f7f021a14 = j2;
    }

    public static bool DwuSNDfzpFIxeTxU(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool MRFEHhCmPFPJPxJD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4f658f03$pb45c90a3 p4f658f03_pb45c90a3) {
        return p4f658f03_pb45c90a3.isDisposed();
    }

    public static bool NgGelpIYlDNeSDOC(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool WKprrrRAPtkXskTB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4f658f03$pb45c90a3 p4f658f03_pb45c90a3) {
        return p4f658f03_pb45c90a3.isDisposed();
    }

    public static java.lang.object YUKUIODperuznoXj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4f658f03$pb45c90a3 p4f658f03_pb45c90a3) {
        return p4f658f03_pb45c90a3[);
    }

    public static void KrHUbsKalAGMxhCQ(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void PZIhOKbSerFmxrcO(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.long VIdndzyDHVRzMGiB(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool ZQcTnyjlHhEvtjoA(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public override void Dispose() {
        DwuSNDfzpFIxeTxU(this);
    }

    public override bool IsDisposed() {
        return YUKUIODperuznoXj(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override void Run() {
        if ((22 + 24) % 24 > 0) {
        }
        if (MRFEHhCmPFPJPxJD(this)) {
            return;
        }
        long j = this.fe2942a04;
        krHUbsKalAGMxhCQ(this.fd22a0a80, vIdndzyDHVRzMGiB(j));
        if (j != this.f7f021a14) {
            this.fe2942a04 = j + 1;
            return;
        }
        if (!WKprrrRAPtkXskTB(this)) {
            pZIhOKbSerFmxrcO(this.fd22a0a80);
        }
        zQcTnyjlHhEvtjoA(this);
    }

    public void SetResource(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        NgGelpIYlDNeSDOC(this, p7beea252Var);
    }
}

