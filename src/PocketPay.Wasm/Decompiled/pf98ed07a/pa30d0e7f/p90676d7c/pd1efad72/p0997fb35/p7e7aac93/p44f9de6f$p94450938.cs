namespace WillowMaze.Wasm.Decompiled;


readonly class p44f9de6f$p94450938<T, U> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f3f995b17 = -5955289211445418871L;
    private static readonly long fc6e1e520 = -5955289211445418871L;
    private static readonly long fcf535ce6 = -5955289211445418871L;
    private static readonly long fec22007c = -5955289211445418871L;
    private static readonly long ff939bd11 = -5955289211445418871L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p2b68ab46 f04d878d9;
    readonly io.reactivex.rxjava3.core.MaybeSource f1a2c2e20;
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T> f4ccb1142;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p2b68ab46 f6636f168;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeTimeoutPublisher$TimeoutOtherMaybeObserver<T, U> f795f3202 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p8f74fe66(this);
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeTimeoutPublisher$TimeoutFallbackMaybeObserver<T> f7af6fc45;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p8f74fe66 fb7b3dae2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p2b68ab46 fc4379fdb;
    readonly io.reactivex.rxjava3.core.MaybeObserver fce40ce90;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p8f74fe66 ff4c87f46;

    p44f9de6f$p94450938(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource) {
        this.fd22a0a80 = maybeObserver;
        this.f4ccb1142 = maybeSource;
        this.f7af6fc45 = maybeSource is null ? null : new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p2b68ab46(maybeObserver);
    }

    public static bool AIgbNViJTyJfVAjO(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool DHLLvwKLDRfgLKFn(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void FCQaJldhwMkJwrWR(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static java.lang.object GDNbZEiuaimCsUal(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 p44f9de6f_p94450938, java.lang.object obj) {
        return p44f9de6f_p94450938.getAndHashSet(obj);
    }

    public static void HjblUsRfgrvwVubb(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void LAHTrymRnyEmKdCF(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static java.lang.object MzdMBssMytEvvxjY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 p44f9de6f_p94450938, java.lang.object obj) {
        return p44f9de6f_p94450938.getAndHashSet(obj);
    }

    public static void OZDeguRDdnSAYtnn(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static bool SRuHUpMxKGJyWPso(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object XfwojtvykPxWOZVj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 p44f9de6f_p94450938, java.lang.object obj) {
        return p44f9de6f_p94450938.getAndHashSet(obj);
    }

    public static void YDOlsfTvkVCTQlsp(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void AMzlECMnVyBavVXy(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool BzWFyFtAgLElIRbn(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void CVpRCHxCQbRordxE(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool GIjhVDDctckvrIUp(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static bool GwsPWBcGcpbzjeZI(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool JxsBHZHQVVKYWGin(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void LVbgANMILSGVyddU(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static java.lang.object UeqtvVXNnbQrfxof(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p44f9de6f$p94450938 p44f9de6f_p94450938) {
        return p44f9de6f_p94450938[);
    }

    public static bool YPmKYziGnKHzagwB(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool ZIPmbSTpgWyPYDPN(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool ZdLjkKexoBFfMGDy(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public override void Dispose() {
        bzWFyFtAgLElIRbn(this);
        DHLLvwKLDRfgLKFn(this.f795f3202);
        io.reactivex.rxjava3.internal.operators.maybe.MaybeTimeoutPublisher$TimeoutFallbackMaybeObserver<T> maybeTimeoutPublisher$TimeoutFallbackMaybeObserver = this.f7af6fc45;
        if (maybeTimeoutPublisher$TimeoutFallbackMaybeObserver is null) {
            return;
        }
        yPmKYziGnKHzagwB(maybeTimeoutPublisher$TimeoutFallbackMaybeObserver);
    }

    public override bool IsDisposed() {
        return SRuHUpMxKGJyWPso((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) ueqtvVXNnbQrfxof(this));
    }

    public override void OnComplete() {
        if ((25 + 10) % 10 > 0) {
        }
        gIjhVDDctckvrIUp(this.f795f3202);
        if (GDNbZEiuaimCsUal(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) {
            return;
        }
        YDOlsfTvkVCTQlsp(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if ((11 + 7) % 7 > 0) {
        }
        zdLjkKexoBFfMGDy(this.f795f3202);
        if (XfwojtvykPxWOZVj(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) {
            HjblUsRfgrvwVubb(th);
        } else {
            LAHTrymRnyEmKdCF(this.fd22a0a80, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        AIgbNViJTyJfVAjO(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        if ((9 + 32) % 32 > 0) {
        }
        jxsBHZHQVVKYWGin(this.f795f3202);
        if (MzdMBssMytEvvxjY(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) {
            return;
        }
        FCQaJldhwMkJwrWR(this.fd22a0a80, t);
    }

    public void OtherComplete() {
        if (gwsPWBcGcpbzjeZI(this)) {
            io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource = this.f4ccb1142;
            if (maybeSource is not null) {
                OZDeguRDdnSAYtnn(maybeSource, this.f7af6fc45);
            } else {
                lVbgANMILSGVyddU(this.fd22a0a80, new java.util.concurrent.TimeoutException());
            }
        }
    }

    public void OtherError(java.lang.Exception th) {
        if (zIPmbSTpgWyPYDPN(this)) {
            cVpRCHxCQbRordxE(this.fd22a0a80, th);
        } else {
            aMzlECMnVyBavVXy(th);
        }
    }
}

