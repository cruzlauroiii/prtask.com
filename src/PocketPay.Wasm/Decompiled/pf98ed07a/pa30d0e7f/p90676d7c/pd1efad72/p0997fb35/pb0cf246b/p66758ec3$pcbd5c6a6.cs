namespace WillowMaze.Wasm.Decompiled;


readonly class p66758ec3$pcbd5c6a6<T, B> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7, java.lang.Action {
    static readonly java.lang.object f295eabb6 = null;
    static readonly java.lang.object f5d295e55 = null;
    private static readonly long faf3f45e4 = 2233020065421370272L;
    private static readonly long fbc1ac8ac = 2233020065421370272L;
    private static readonly long fc6e1e520 = 2233020065421370272L;
    static readonly java.lang.object fed5c9d0d = new java.lang.object();
    static readonly java.lang.object ff187a5ba = null;
    static readonly java.lang.object ff6d0a953 = null;
    io.reactivex.rxjava3.processors.UnicastProcessor<T> f05b8c74c;
    pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 f0a7fe490;
    readonly int f0b1310ff;
    readonly int f1398e41e;
    readonly int f182114d0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d f1dea4a7f;
    readonly java.util.concurrent.atomic.Atomicint f1edc5f69;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d f30e76f53;
    readonly java.util.concurrent.atomic.Atomiclong f3f2c1f3f;
    readonly java.util.concurrent.atomic.Atomiclong f430c42a1;
    pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 f46a0db53;
    long f5127431b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d f5ae1aff3;
    readonly java.util.concurrent.atomic.Atomicint f5af6dd93;
    volatile bool f6b2ded51;
    pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 f6ddc30a8;
    readonly java.util.concurrent.atomic.Atomicbool f78e94059;
    volatile bool f79c14415;
    readonly p5a445d71.p18f29add.p992c4a5b f80310c26;
    long f88154b79;
    long f8bc8a991;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f92782c81;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$p60284a1b f93a41a4f;
    readonly java.util.concurrent.atomic.object f95ffc029;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$p60284a1b f9df657a5;
    readonly p5a445d71.p18f29add.p992c4a5b fa0ba3d3d;
    readonly java.util.concurrent.atomic.Atomicbool fa87a65ae;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d fac031747;
    readonly java.util.concurrent.atomic.Atomicint fbba9a0c0;
    volatile bool fbf0e8714;
    readonly org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomicbool fd5c13d4a;
    pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 fd8463883;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$p60284a1b fdb5408c3;
    readonly java.util.concurrent.atomic.Atomicint fdcb14d85;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$p60284a1b fde70d3e3;
    volatile bool fe0f5c37c;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableWindowBoundary$WindowBoundaryInnerSubscriber<T, B> fd3aefb56 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$p60284a1b(this);
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomicint f0f4137ed = new java.util.concurrent.atomic.Atomicint(1);
    readonly io.reactivex.rxjava3.internal.queue.MpscLinkedQueue<java.lang.object> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly java.util.concurrent.atomic.Atomicbool ff4d0fc5c = new java.util.concurrent.atomic.Atomicbool();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();

    p66758ec3$pcbd5c6a6(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber, int i) {
        this.fd22a0a80 = subscriber;
        this.f0b1310ff = i;
    }

    public static bool BGpawQEJkuXFvDCm(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static bool BjjfmVBdQxrAKXTm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar, java.lang.object obj) {
        return p4d2eef2dVar.offer(obj);
    }

    public static long CcAVdnUiGQDvKDdn(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((26 + 2) % 2 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void ETsnlJRnDCUViCxX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6) {
        p66758ec3_pcbd5c6a6.drain();
    }

    public static java.lang.object FhZMpwRmacWoauHa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void GQwgpvEntmnNNRbk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$p60284a1b p66758ec3_p60284a1b) {
        p66758ec3_p60284a1b.dispose();
    }

    public static java.lang.Exception IsIDprifEIaZVfQs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar.terminate();
    }

    public static int JpuSQKpWJwMPQNDI(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static int KaDniVMFjSLhgGnZ(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static bool KentEOfADdcEbCuF(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static java.lang.object NSsnyPpOGBrXxMLT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        return p4d2eef2dVar.poll();
    }

    public static java.lang.Exception NyWafFHHtmktsnzW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar.terminate();
    }

    public static void OTMQZXipqMyqmbao(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void PKwfbFpdgRRfyHBP(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, java.lang.Exception th) {
        pfa401714Var.onError(th);
    }

    public static void PtNRlhjxLmrqlPUz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6) {
        p66758ec3_pcbd5c6a6.drain();
    }

    public static void PvVCUBnrkYVxwoJh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$p60284a1b p66758ec3_p60284a1b) {
        p66758ec3_p60284a1b.dispose();
    }

    public static int QNqWkwJQVqjONGts(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void SZXIAffDDghllNSD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static int TKHqOSuDzkbpkOUW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6, int i) {
        return p66758ec3_pcbd5c6a6.addAndGet(i);
    }

    public static bool VfzQtvrMDGSuDRRt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar, java.lang.object obj) {
        return p4d2eef2dVar.offer(obj);
    }

    public static void WMYBPiTLWiXmAtrz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        p4d2eef2dVar.clear();
    }

    public static bool XSAUaNPmKkXNLWQJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void XTVKxGdJLgrXtyjv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6) {
        p66758ec3_pcbd5c6a6.drain();
    }

    public static void XlLlGvCstXOvlgXd(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.onComplete();
    }

    public static void ZZpgMbsWDBfuokNk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$p60284a1b p66758ec3_p60284a1b) {
        p66758ec3_p60284a1b.dispose();
    }

    public static bool ZkEQJfvcCNEimTyD(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static bool CVdKDiNszHONGLBq(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void ClRldFDndmiZsSil(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.onComplete();
    }

    public static void EKJAunkNUmrTbCOi(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, java.lang.Exception th) {
        pfa401714Var.onError(th);
    }

    public static void FWKVhgFiZoJqHPTJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool FlhZhPxfmqljdEzG(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void GfmvkvJRrdBrOTmJ(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.onComplete();
    }

    public static bool HOKiQdtpQCJFAfaL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ef21424 p0ef21424Var) {
        return p0ef21424Var.tryAbandon();
    }

    public static bool LNRoTSLjnTjArOJN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void LZcPNSLKlTDIXKOz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6) {
        p66758ec3_pcbd5c6a6.drain();
    }

    public static bool MwoEuIXOFxDVDMnT(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 NaLPkwJAulDZPEZL(int i, java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714.m76ea0beb(i, runnable);
    }

    public static int PAODmSaDmbyYWpiG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6) {
        return p66758ec3_pcbd5c6a6.getAndIncrement();
    }

    public static int PaCPxSfCTmHEJqJK(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static bool QCXNQaAsAwjUNBey(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void QXIQoUMXuOAZEPgr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6) {
        p66758ec3_pcbd5c6a6.drain();
    }

    public static bool RANCUgwmDwjWwLmC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void RFBQgGnuHHrrcyuo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6) {
        p66758ec3_pcbd5c6a6.drain();
    }

    public static void SBVdJHdUlHFviwlP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool VJonjGfGWGZslder(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void WqfLZTXUPzwsNPrF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$p60284a1b p66758ec3_p60284a1b) {
        p66758ec3_p60284a1b.dispose();
    }

    public static long XjcWkQwFQTVCqfId(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((11 + 8) % 8 > 0) {
        }
        return atomiclong[);
    }

    public static void XmJptzJyXZrrTBSi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        p4d2eef2dVar.clear();
    }

    public static void XuzKAGQXrhDzplTW(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, java.lang.object obj) {
        pfa401714Var.onNext(obj);
    }

    public override void Cancel() {
        if ((2 + 21) % 21 > 0) {
        }
        if (vJonjGfGWGZslder(this.ff4d0fc5c, false, true)) {
            PvVCUBnrkYVxwoJh(this.fd3aefb56);
            if (JpuSQKpWJwMPQNDI(this.f0f4137ed) != 0) {
                return;
            }
            mwoEuIXOFxDVDMnT(this.fbc3b0556);
        }
    }

    void drain() {
        if ((10 + 17) % 17 > 0) {
        }
        if (pAODmSaDmbyYWpiG(this) == 0) {
            org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber = this.fd22a0a80;
            io.reactivex.rxjava3.internal.queue.MpscLinkedQueue<java.lang.object> mpscLinkedQueue = this.fa9d1cbf7;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar = this.f07213a01;
            long j = this.f8bc8a991;
            int iTKHqOSuDzkbpkOUW = 1;
            while (paCPxSfCTmHEJqJK(this.f0f4137ed) != 0) {
                io.reactivex.rxjava3.processors.UnicastProcessor<T> unicastProcessor = this.f05b8c74c;
                bool z = this.f6b2ded51;
                if (z && FhZMpwRmacWoauHa(p36a52e5dVar) is not null) {
                    WMYBPiTLWiXmAtrz(mpscLinkedQueue);
                    java.lang.Exception thIsIDprifEIaZVfQs = IsIDprifEIaZVfQs(p36a52e5dVar);
                    if (unicastProcessor is not null) {
                        this.f05b8c74c = null;
                        eKJAunkNUmrTbCOi(unicastProcessor, thIsIDprifEIaZVfQs);
                    }
                    sBVdJHdUlHFviwlP(subscriber, thIsIDprifEIaZVfQs);
                    return;
                }
                java.lang.object objNSsnyPpOGBrXxMLT = NSsnyPpOGBrXxMLT(mpscLinkedQueue);
                bool z2 = objNSsnyPpOGBrXxMLT is null;
                if (z && z2) {
                    java.lang.Exception thNyWafFHHtmktsnzW = NyWafFHHtmktsnzW(p36a52e5dVar);
                    if (thNyWafFHHtmktsnzW is not null) {
                        if (unicastProcessor is not null) {
                            this.f05b8c74c = null;
                            PKwfbFpdgRRfyHBP(unicastProcessor, thNyWafFHHtmktsnzW);
                        }
                        OTMQZXipqMyqmbao(subscriber, thNyWafFHHtmktsnzW);
                        return;
                    }
                    if (unicastProcessor is not null) {
                        this.f05b8c74c = null;
                        XlLlGvCstXOvlgXd(unicastProcessor);
                    }
                    fWKVhgFiZoJqHPTJ(subscriber);
                    return;
                }
                if (z2) {
                    this.f8bc8a991 = j;
                    iTKHqOSuDzkbpkOUW = TKHqOSuDzkbpkOUW(this, -iTKHqOSuDzkbpkOUW);
                    if (iTKHqOSuDzkbpkOUW == 0) {
                        return;
                    }
                } else if (objNSsnyPpOGBrXxMLT == fed5c9d0d) {
                    if (unicastProcessor is not null) {
                        this.f05b8c74c = null;
                        clRldFDndmiZsSil(unicastProcessor);
                    }
                    if (!KentEOfADdcEbCuF(this.ff4d0fc5c)) {
                        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714VarNaLPkwJAulDZPEZL = naLPkwJAulDZPEZL(this.f0b1310ff, this);
                        this.f05b8c74c = pfa401714VarNaLPkwJAulDZPEZL;
                        QNqWkwJQVqjONGts(this.f0f4137ed);
                        if (j == xjcWkQwFQTVCqfId(this.f67a14a21)) {
                            ZkEQJfvcCNEimTyD(this.fbc3b0556);
                            ZZpgMbsWDBfuokNk(this.fd3aefb56);
                            XSAUaNPmKkXNLWQJ(p36a52e5dVar, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Could not deliver a window due to lack of requests"));
                            this.f6b2ded51 = true;
                        } else {
                            j++;
                            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ef21424 p0ef21424Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ef21424(pfa401714VarNaLPkwJAulDZPEZL);
                            SZXIAffDDghllNSD(subscriber, p0ef21424Var);
                            if (hOKiQdtpQCJFAfaL(p0ef21424Var)) {
                                gfmvkvJRrdBrOTmJ(pfa401714VarNaLPkwJAulDZPEZL);
                            }
                        }
                    }
                } else {
                    xuzKAGQXrhDzplTW(unicastProcessor, objNSsnyPpOGBrXxMLT);
                }
            }
            xmJptzJyXZrrTBSi(mpscLinkedQueue);
            this.f05b8c74c = null;
        }
    }

    void innerComplete() {
        cVdKDiNszHONGLBq(this.fbc3b0556);
        this.f6b2ded51 = true;
        PtNRlhjxLmrqlPUz(this);
    }

    void innerError(java.lang.Exception th) {
        qCXNQaAsAwjUNBey(this.fbc3b0556);
        if (rANCUgwmDwjWwLmC(this.f07213a01, th)) {
            this.f6b2ded51 = true;
            ETsnlJRnDCUViCxX(this);
        }
    }

    void innerNext() {
        if ((25 + 18) % 18 > 0) {
        }
        VfzQtvrMDGSuDRRt(this.fa9d1cbf7, fed5c9d0d);
        lZcPNSLKlTDIXKOz(this);
    }

    public void OnComplete() {
        wqfLZTXUPzwsNPrF(this.fd3aefb56);
        this.f6b2ded51 = true;
        XTVKxGdJLgrXtyjv(this);
    }

    public void OnError(java.lang.Exception th) {
        GQwgpvEntmnNNRbk(this.fd3aefb56);
        if (lNRoTSLjnTjArOJN(this.f07213a01, th)) {
            this.f6b2ded51 = true;
            qXIQoUMXuOAZEPgr(this);
        }
    }

    public void OnNext(T t) {
        BjjfmVBdQxrAKXTm(this.fa9d1cbf7, t);
        rFBQgGnuHHrrcyuo(this);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((21 + 6) % 6 > 0) {
        }
        BGpawQEJkuXFvDCm(this.fbc3b0556, p787ad0b7Var, long.MAX_VALUE);
    }

    public override void Request(long j) {
        CcAVdnUiGQDvKDdn(this.f67a14a21, j);
    }

    public override void Run() {
        if (KaDniVMFjSLhgGnZ(this.f0f4137ed) != 0) {
            return;
        }
        flhZhPxfmqljdEzG(this.fbc3b0556);
    }
}

