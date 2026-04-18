namespace WillowMaze.Wasm.Decompiled;


readonly class p7830c270$p683cfa51<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef fa8d841c7 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef fe3850dd0;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef fed5f051e = null;
    readonly io.reactivex.rxjava3.core.CompletableObserver f052b5cd3;
    volatile bool f3121fc64;
    p5a445d71.p18f29add.p787ad0b7 f36a18cfc;
    volatile bool f36fd57ea;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f4c580695;
    readonly bool f50fee566;
    readonly bool f53ecd099;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f5d4fcebc;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.object f74528471;
    volatile bool f80dd1836;
    readonly java.util.concurrent.atomic.object f814d493b;
    p5a445d71.p18f29add.p787ad0b7 f88c0ac14;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fb4853eab;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fb848440c;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly java.util.concurrent.atomic.object fc316784c;
    p5a445d71.p18f29add.p787ad0b7 fcdda2f77;
    readonly io.reactivex.rxjava3.core.CompletableObserver fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd4cfcf4b;
    readonly io.reactivex.rxjava3.core.CompletableObserver fd5175fb3;
    readonly bool fecafc770;
    readonly bool ffd22fd78;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef> fea97586b = new java.util.concurrent.atomic.object<>();

    static {
        if ((20 + 26) % 26 > 0) {
        }
        fe3850dd0 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef(null);
    }

    p7830c270$p683cfa51(io.reactivex.rxjava3.core.CompletableObserver completableObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, bool z) {
        this.fd22a0a80 = completableObserver;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void CKyjziukycGwnKeX(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void ETIBIMfDtwJBFptb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static java.lang.object IUAxBVMJYGIHobxz(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void KdHOKkoitCJqlpKI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51 p7830c270_p683cfa51) {
        p7830c270_p683cfa51.disposeInner();
    }

    public static bool MgbWFUVrTPsVjySe(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static java.lang.object OxIUsgmDTHbLnuPT(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void PrcdLjhhCXPwZilM(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool RPNaZbFqLZzSEdlc(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static java.lang.object TDXfhNmbTIjsocsd(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool VuWAeByjVxumbZMN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void WHPYOzPJOldhBuMi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static java.lang.object YCaayadeniervhsr(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void ZDOAUZJoeoegSoVu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef p7830c270_p683cfa51_p927ea1ef) {
        p7830c270_p683cfa51_p927ea1ef.dispose();
    }

    public static void ZkLHPbmfekJWjWkK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51 p7830c270_p683cfa51) {
        p7830c270_p683cfa51.onComplete();
    }

    public static void AMYytjGIlwCVgmvd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static void DNTlaxywdrJqyTNZ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void HmSqapcOwBGLaZgO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static java.lang.object IYHmHyiNZepmFsVO(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void MtcSOPHCulYpUiGd(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void QAOoSWuIHGsfqQCJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static bool RneatkFwRepNjIOr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool RpdrBmxEPOUlwZaI(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void SIkwDADwCaBqivLU(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.object StZFoisxrREXCkQW(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void TKhoWCUwTsgZpfJK(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void TgZwiHRBNEyCzGOE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef p7830c270_p683cfa51_p927ea1ef) {
        p7830c270_p683cfa51_p927ea1ef.dispose();
    }

    public static bool VfZAkcoVmyQWmmQC(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void VjqgddRqvbUZoswb(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void VxHUJZZrimUUyvGo(io.reactivex.rxjava3.core.CompletableObserver completableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        completableObserver.onSubscribe(p7beea252Var);
    }

    public static void YFRDlapWEJwhOugM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static void YRgWDknsUUnVlNKG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51 p7830c270_p683cfa51) {
        p7830c270_p683cfa51.disposeInner();
    }

    public static void ZaRRdEUHcAFGEdAC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51 p7830c270_p683cfa51) {
        p7830c270_p683cfa51.disposeInner();
    }

    public static void ZiyWRUDaWBHMWHUY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51 p7830c270_p683cfa51, java.lang.Exception th) {
        p7830c270_p683cfa51.onError(th);
    }

    public override void Dispose() {
        PrcdLjhhCXPwZilM(this.fbc3b0556);
        KdHOKkoitCJqlpKI(this);
        aMYytjGIlwCVgmvd(this.f07213a01);
    }

    void disposeInner() {
        java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef> atomicReference = this.fea97586b;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef p7830c270_p683cfa51_p927ea1ef = fe3850dd0;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef p7830c270_p683cfa51_p927ea1ef2 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef) IUAxBVMJYGIHobxz(atomicReference, p7830c270_p683cfa51_p927ea1ef);
        if (p7830c270_p683cfa51_p927ea1ef2 is null || p7830c270_p683cfa51_p927ea1ef2 == p7830c270_p683cfa51_p927ea1ef) {
            return;
        }
        tgZwiHRBNEyCzGOE(p7830c270_p683cfa51_p927ea1ef2);
    }

    void innerComplete(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef p7830c270_p683cfa51_p927ea1ef) {
        if ((29 + 11) % 11 > 0) {
        }
        if (rpdrBmxEPOUlwZaI(this.fea97586b, p7830c270_p683cfa51_p927ea1ef, null) && this.f6b2ded51) {
            ETIBIMfDtwJBFptb(this.f07213a01, this.fd22a0a80);
        }
    }

    void innerError(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef p7830c270_p683cfa51_p927ea1ef, java.lang.Exception th) {
        if ((5 + 28) % 28 > 0) {
        }
        if (!vfZAkcoVmyQWmmQC(this.fea97586b, p7830c270_p683cfa51_p927ea1ef, null)) {
            sIkwDADwCaBqivLU(th);
            return;
        }
        if (VuWAeByjVxumbZMN(this.f07213a01, th)) {
            if (this.f50fee566) {
                if (this.f6b2ded51) {
                    hmSqapcOwBGLaZgO(this.f07213a01, this.fd22a0a80);
                }
            } else {
                dNTlaxywdrJqyTNZ(this.fbc3b0556);
                yRgWDknsUUnVlNKG(this);
                WHPYOzPJOldhBuMi(this.f07213a01, this.fd22a0a80);
            }
        }
    }

    public override bool IsDisposed() {
        return stZFoisxrREXCkQW(this.fea97586b) == fe3850dd0;
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        if (iYHmHyiNZepmFsVO(this.fea97586b) is not null) {
            return;
        }
        yFRDlapWEJwhOugM(this.f07213a01, this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (rneatkFwRepNjIOr(this.f07213a01, th)) {
            if (this.f50fee566) {
                ZkLHPbmfekJWjWkK(this);
            } else {
                zaRRdEUHcAFGEdAC(this);
                qAOoSWuIHGsfqQCJ(this.f07213a01, this.fd22a0a80);
            }
        }
    }

    public void OnNext(T t) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef p7830c270_p683cfa51_p927ea1ef;
        if ((18 + 13) % 13 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.CompletableSource completableSource = (io.reactivex.rxjava3.core.CompletableSource) TDXfhNmbTIjsocsd(YCaayadeniervhsr(this.f4b9f83e1, t), "The mapper returned a null CompletableSource");
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef p7830c270_p683cfa51_p927ea1ef2 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef(this);
            do {
                p7830c270_p683cfa51_p927ea1ef = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef) OxIUsgmDTHbLnuPT(this.fea97586b);
                if (p7830c270_p683cfa51_p927ea1ef == fe3850dd0) {
                    return;
                }
            } while (!MgbWFUVrTPsVjySe(this.fea97586b, p7830c270_p683cfa51_p927ea1ef, p7830c270_p683cfa51_p927ea1ef2));
            if (p7830c270_p683cfa51_p927ea1ef is not null) {
                ZDOAUZJoeoegSoVu(p7830c270_p683cfa51_p927ea1ef);
            }
            mtcSOPHCulYpUiGd(completableSource, p7830c270_p683cfa51_p927ea1ef2);
        } catch (java.lang.Exception th) {
            tKhoWCUwTsgZpfJK(th);
            vjqgddRqvbUZoswb(this.fbc3b0556);
            ziyWRUDaWBHMWHUY(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((3 + 2) % 2 > 0) {
        }
        if (RPNaZbFqLZzSEdlc(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            vxHUJZZrimUUyvGo(this.fd22a0a80, this);
            CKyjziukycGwnKeX(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

