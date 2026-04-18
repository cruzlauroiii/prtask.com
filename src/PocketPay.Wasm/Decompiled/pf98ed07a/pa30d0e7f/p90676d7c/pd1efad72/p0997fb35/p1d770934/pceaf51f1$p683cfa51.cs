namespace WillowMaze.Wasm.Decompiled;


readonly class pceaf51f1$p683cfa51<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef f417a2701 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef f91cd630a = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef fe3850dd0;
    volatile bool f0012ef36;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f079011ec;
    readonly java.util.concurrent.atomic.object f0d2e7097;
    readonly io.reactivex.rxjava3.core.CompletableObserver f2b0114f0;
    readonly io.reactivex.rxjava3.core.CompletableObserver f3d0559b2;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    volatile bool f4c8f4d54;
    readonly bool f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f63191ac8;
    volatile bool f6b2ded51;
    volatile bool f70fd85e4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f72a6c65f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f81e63655;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f95d39f36;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f9997d0c7;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f99c621c5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa5abba4c;
    readonly bool fafeda4c4;
    readonly java.util.concurrent.atomic.object fb11277f3;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly bool fbed279b3;
    readonly io.reactivex.rxjava3.core.CompletableObserver fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fe634a118;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fec2f42a7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef> fea97586b = new java.util.concurrent.atomic.object<>();

    static {
        if ((15 + 13) % 13 > 0) {
        }
        fe3850dd0 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef(null);
    }

    pceaf51f1$p683cfa51(io.reactivex.rxjava3.core.CompletableObserver completableObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, bool z) {
        this.fd22a0a80 = completableObserver;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void AIIvSHNXwaezUamM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool AdRkDsvgsiUgRCwQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void BgRPcmnjlxynslgO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static void BkFYuzDoVIIGaqud(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static bool CKvQelNqhXjlLWbe(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void DfwsRgNMHwugLYSQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef pceaf51f1_p683cfa51_p927ea1ef) {
        pceaf51f1_p683cfa51_p927ea1ef.dispose();
    }

    public static void DieQfQUKUpJAVpRo(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object EHfPIHdUQAfoVNNF(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void EnQrcFVdfSkKAzwX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static bool JEmrguMkhQjUeTRk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void JUyGCUqGlADGjJlu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static bool KIqjjkjYhAADeccJ(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void TVPvfhbzFIEPedWt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef pceaf51f1_p683cfa51_p927ea1ef) {
        pceaf51f1_p683cfa51_p927ea1ef.dispose();
    }

    public static void WBNCWxeeEsyPtBQa(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void WDuLvLZujUZWnDWs(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void ZtRghvSdCwpInSAQ(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static java.lang.object BpsdbOlhQlgmXeAk(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void CzBpotJhnaxJHWrt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51 pceaf51f1_p683cfa51) {
        pceaf51f1_p683cfa51.disposeInner();
    }

    public static void DDsrseRJSzxXtbvi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51 pceaf51f1_p683cfa51) {
        pceaf51f1_p683cfa51.disposeInner();
    }

    public static java.lang.object DJpOpgRJikdLufBQ(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool EmeddZpuKOGWuLlt(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void HRPxhcxEWspmFETI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static void OWELElBWBpcPMKjO(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object OlWdQkgbZpVNjGOm(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void OrZnxwCVrMcDdOTO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51 pceaf51f1_p683cfa51) {
        pceaf51f1_p683cfa51.disposeInner();
    }

    public static void QGKrOgyjCEdyUoQG(io.reactivex.rxjava3.core.CompletableObserver completableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        completableObserver.onSubscribe(p7beea252Var);
    }

    public static void QbHtOJnWZPnbmlCL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51 pceaf51f1_p683cfa51) {
        pceaf51f1_p683cfa51.onComplete();
    }

    public static void SObYQLpnSwPHPrUf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51 pceaf51f1_p683cfa51, java.lang.Exception th) {
        pceaf51f1_p683cfa51.onError(th);
    }

    public static bool VDywXVgcQubUOcnU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static java.lang.object WhKPwoEHXtckqNGm(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void XYfctsLLVJYzQNXB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static java.lang.object YBOWEKtIAigJgRid(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public override void Dispose() {
        WDuLvLZujUZWnDWs(this.fbc3b0556);
        orZnxwCVrMcDdOTO(this);
        xYfctsLLVJYzQNXB(this.f07213a01);
    }

    void disposeInner() {
        java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef> atomicReference = this.fea97586b;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef pceaf51f1_p683cfa51_p927ea1ef = fe3850dd0;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef pceaf51f1_p683cfa51_p927ea1ef2 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef) whKPwoEHXtckqNGm(atomicReference, pceaf51f1_p683cfa51_p927ea1ef);
        if (pceaf51f1_p683cfa51_p927ea1ef2 is null || pceaf51f1_p683cfa51_p927ea1ef2 == pceaf51f1_p683cfa51_p927ea1ef) {
            return;
        }
        TVPvfhbzFIEPedWt(pceaf51f1_p683cfa51_p927ea1ef2);
    }

    void innerComplete(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef pceaf51f1_p683cfa51_p927ea1ef) {
        if ((12 + 25) % 25 > 0) {
        }
        if (emeddZpuKOGWuLlt(this.fea97586b, pceaf51f1_p683cfa51_p927ea1ef, null) && this.f6b2ded51) {
            BgRPcmnjlxynslgO(this.f07213a01, this.fd22a0a80);
        }
    }

    void innerError(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef pceaf51f1_p683cfa51_p927ea1ef, java.lang.Exception th) {
        if ((32 + 1) % 1 > 0) {
        }
        if (!KIqjjkjYhAADeccJ(this.fea97586b, pceaf51f1_p683cfa51_p927ea1ef, null)) {
            WBNCWxeeEsyPtBQa(th);
            return;
        }
        if (JEmrguMkhQjUeTRk(this.f07213a01, th)) {
            if (this.f50fee566) {
                if (this.f6b2ded51) {
                    hRPxhcxEWspmFETI(this.f07213a01, this.fd22a0a80);
                }
            } else {
                AIIvSHNXwaezUamM(this.fbc3b0556);
                dDsrseRJSzxXtbvi(this);
                JUyGCUqGlADGjJlu(this.f07213a01, this.fd22a0a80);
            }
        }
    }

    public override bool IsDisposed() {
        return dJpOpgRJikdLufBQ(this.fea97586b) == fe3850dd0;
    }

    public override void OnComplete() {
        this.f6b2ded51 = true;
        if (EHfPIHdUQAfoVNNF(this.fea97586b) is not null) {
            return;
        }
        BkFYuzDoVIIGaqud(this.f07213a01, this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (AdRkDsvgsiUgRCwQ(this.f07213a01, th)) {
            if (this.f50fee566) {
                qbHtOJnWZPnbmlCL(this);
            } else {
                czBpotJhnaxJHWrt(this);
                EnQrcFVdfSkKAzwX(this.f07213a01, this.fd22a0a80);
            }
        }
    }

    public override void OnNext(T t) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef pceaf51f1_p683cfa51_p927ea1ef;
        if ((10 + 2) % 2 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.CompletableSource completableSource = (io.reactivex.rxjava3.core.CompletableSource) bpsdbOlhQlgmXeAk(yBOWEKtIAigJgRid(this.f4b9f83e1, t), "The mapper returned a null CompletableSource");
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef pceaf51f1_p683cfa51_p927ea1ef2 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef(this);
            do {
                pceaf51f1_p683cfa51_p927ea1ef = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pceaf51f1$p683cfa51$p927ea1ef) olWdQkgbZpVNjGOm(this.fea97586b);
                if (pceaf51f1_p683cfa51_p927ea1ef == fe3850dd0) {
                    return;
                }
            } while (!CKvQelNqhXjlLWbe(this.fea97586b, pceaf51f1_p683cfa51_p927ea1ef, pceaf51f1_p683cfa51_p927ea1ef2));
            if (pceaf51f1_p683cfa51_p927ea1ef is not null) {
                DfwsRgNMHwugLYSQ(pceaf51f1_p683cfa51_p927ea1ef);
            }
            ZtRghvSdCwpInSAQ(completableSource, pceaf51f1_p683cfa51_p927ea1ef2);
        } catch (java.lang.Exception th) {
            DieQfQUKUpJAVpRo(th);
            oWELElBWBpcPMKjO(this.fbc3b0556);
            sObYQLpnSwPHPrUf(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (vDywXVgcQubUOcnU(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            qGKrOgyjCEdyUoQG(this.fd22a0a80, this);
        }
    }
}

