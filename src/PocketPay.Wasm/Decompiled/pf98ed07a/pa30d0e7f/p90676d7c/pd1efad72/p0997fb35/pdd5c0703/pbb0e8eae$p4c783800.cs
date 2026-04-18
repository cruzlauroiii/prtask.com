namespace WillowMaze.Wasm.Decompiled;


readonly class pbb0e8eae$p4c783800<T, U> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<U>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f12c6716f = -8565274649390031272L;
    private static readonly long f48a41762 = -8565274649390031272L;
    private static readonly long f781648e8 = -8565274649390031272L;
    private static readonly long fc6e1e520 = -8565274649390031272L;
    private static readonly long ff86b9623 = -8565274649390031272L;
    bool f0962e637;
    bool f1fdc4e2f;
    readonly io.reactivex.rxjava3.core.SingleSource f1ff494d3;
    bool f235c81b0;
    readonly io.reactivex.rxjava3.core.SingleSource f27103021;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f528fa681;
    bool f6b2ded51;
    bool fa085c07e;
    readonly io.reactivex.rxjava3.core.SingleSource fbe008615;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver fe336a3d8;

    pbb0e8eae$p4c783800(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.core.SingleSource<T> singleSource) {
        this.fd22a0a80 = singleObserver;
        this.f36cd38f4 = singleSource;
    }

    public static bool DvCBnkngnCKNxfMr(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void MDCyoIxsgkjdynIo(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void UMrxeMPLJxyoerZD(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool ZZRcvhWKaItZEHVN(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void DWcCxnyIVSfMpZbu(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void FUHebHvTHRbcFGRM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pbb0e8eae$p4c783800 pbb0e8eae_p4c783800) {
        pbb0e8eae_p4c783800.onComplete();
    }

    public static void HiOllndYpiuKoooJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object UKkrOeYkePWaCxVW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pbb0e8eae$p4c783800 pbb0e8eae_p4c783800) {
        return pbb0e8eae_p4c783800[);
    }

    public static bool WKwbVTRxAmmVippY(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void XVqHRflJXJWIIaDe(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static java.lang.object YsEeoXDOqEGOualF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pbb0e8eae$p4c783800 pbb0e8eae_p4c783800) {
        return pbb0e8eae_p4c783800[);
    }

    public override void Dispose() {
        wKwbVTRxAmmVippY(this);
    }

    public override bool IsDisposed() {
        return ZZRcvhWKaItZEHVN((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) ysEeoXDOqEGOualF(this));
    }

    public override void OnComplete() {
        if ((31 + 8) % 8 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        MDCyoIxsgkjdynIo(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd08e44b9(this, this.fd22a0a80));
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            UMrxeMPLJxyoerZD(th);
        } else {
            this.f6b2ded51 = true;
            dWcCxnyIVSfMpZbu(this.fd22a0a80, th);
        }
    }

    public override void OnNext(U u) {
        hiOllndYpiuKoooJ((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) uKkrOeYkePWaCxVW(this));
        fUHebHvTHRbcFGRM(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (DvCBnkngnCKNxfMr(this, p7beea252Var)) {
            xVqHRflJXJWIIaDe(this.fd22a0a80, this);
        }
    }
}

