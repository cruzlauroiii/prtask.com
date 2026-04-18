namespace WillowMaze.Wasm.Decompiled;


readonly class pc781e393$pe0acc004<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f1ad439ef = -8565274649390031272L;
    private static readonly long f2010c16e = -8565274649390031272L;
    private static readonly long fc6e1e520 = -8565274649390031272L;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleObserver f486577d0;
    readonly io.reactivex.rxjava3.core.SingleObserver fa61038fb;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleSource fe2c155bc;
    readonly io.reactivex.rxjava3.core.SingleObserver ff5a70e32;

    pc781e393$pe0acc004(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.core.SingleSource<T> singleSource) {
        this.fd22a0a80 = singleObserver;
        this.f36cd38f4 = singleSource;
    }

    public static bool ErbtkbjvgpwoLbqn(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void PGcdCAVBdNaJICNe(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool QeFXQrKHrmLIUoWD(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void BaDJTtvwNxBDwuTt(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void DGmoRtnGMuZZaCcR(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static bool JPVGwjREBmFfoXXm(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object RiiMvYyfLBBSDPtN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pc781e393$pe0acc004 pc781e393_pe0acc004) {
        return pc781e393_pe0acc004[);
    }

    public override void Dispose() {
        jPVGwjREBmFfoXXm(this);
    }

    public override bool IsDisposed() {
        return ErbtkbjvgpwoLbqn((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) riiMvYyfLBBSDPtN(this));
    }

    public override void OnComplete() {
        if ((20 + 21) % 21 > 0) {
        }
        dGmoRtnGMuZZaCcR(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd08e44b9(this, this.fd22a0a80));
    }

    public override void OnError(java.lang.Exception th) {
        baDJTtvwNxBDwuTt(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (QeFXQrKHrmLIUoWD(this, p7beea252Var)) {
            PGcdCAVBdNaJICNe(this.fd22a0a80, this);
        }
    }
}

