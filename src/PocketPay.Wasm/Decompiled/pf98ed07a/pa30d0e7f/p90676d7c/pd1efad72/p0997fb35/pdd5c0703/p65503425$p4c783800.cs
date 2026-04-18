namespace WillowMaze.Wasm.Decompiled;


readonly class p65503425$p4c783800<T, U> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.FlowableSubscriber<U>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f21e7648c = -8565274649390031272L;
    private static readonly long fb4f3b55c = -8565274649390031272L;
    private static readonly long fc6e1e520 = -8565274649390031272L;
    readonly io.reactivex.rxjava3.core.SingleObserver f051b5ac7;
    bool f21bfb39f;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleObserver f625cf823;
    bool f6b2ded51;
    p5a445d71.p18f29add.p787ad0b7 f7a89ed2b;
    readonly io.reactivex.rxjava3.core.SingleSource f7f30a6b8;
    readonly io.reactivex.rxjava3.core.SingleSource fa5fd7468;
    readonly io.reactivex.rxjava3.core.SingleSource fa61c59cd;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p787ad0b7 fc071d77c;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver fe6a352ea;
    readonly io.reactivex.rxjava3.core.SingleSource feb4339d2;

    p65503425$p4c783800(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.core.SingleSource<T> singleSource) {
        this.fd22a0a80 = singleObserver;
        this.f36cd38f4 = singleSource;
    }

    public static void AXDHwdcPCDxLLPbS(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object AZZgMkgfYYXSMAKr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p65503425$p4c783800 p65503425_p4c783800) {
        return p65503425_p4c783800[);
    }

    public static void BfIfKfFOzfOKORNu(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void HVhdoUjrsMigjllw(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool MiFLqGzALkgLDRTw(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void SFIbWVQjcEUmTTRa(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static bool TMPDJDsJhZNDGkrC(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void XqLRSRqoDhBDRXxA(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void AdCzStfbLEukasnT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void CUQsZwTijCyCvARe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p65503425$p4c783800 p65503425_p4c783800) {
        p65503425_p4c783800.onComplete();
    }

    public static bool NblPlAiZhPwrCeOW(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void ZpvyxlTUSIgozEQX(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void Dispose() {
        adCzStfbLEukasnT(this.fbc3b0556);
        TMPDJDsJhZNDGkrC(this);
    }

    public override bool IsDisposed() {
        return nblPlAiZhPwrCeOW((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) AZZgMkgfYYXSMAKr(this));
    }

    public void OnComplete() {
        if ((4 + 1) % 1 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        SFIbWVQjcEUmTTRa(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd08e44b9(this, this.fd22a0a80));
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            BfIfKfFOzfOKORNu(th);
        } else {
            this.f6b2ded51 = true;
            zpvyxlTUSIgozEQX(this.fd22a0a80, th);
        }
    }

    public void OnNext(U u) {
        HVhdoUjrsMigjllw(this.fbc3b0556);
        cUQsZwTijCyCvARe(this);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((20 + 10) % 10 > 0) {
        }
        if (MiFLqGzALkgLDRTw(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            XqLRSRqoDhBDRXxA(this.fd22a0a80, this);
            AXDHwdcPCDxLLPbS(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

