namespace WillowMaze.Wasm.Decompiled;


readonly class p33c1ddc0$pc3254395<T, R> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f550c6d8b = -1776795561228106469L;
    private static readonly long fc6e1e520 = -1776795561228106469L;
    java.lang.object f017602cd;
    readonly java.util.concurrent.atomic.Atomiclong f04d52e50;
    readonly java.util.concurrent.atomic.Atomiclong f123434b7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f15b1d8be;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f1684cd8a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f1f921ece;
    R f2063c160;
    volatile bool f38881e0a;
    readonly int f3c028237;
    volatile bool f45b949ea;
    int f48fe8558;
    volatile bool f494f64bc;
    readonly int f4c203b76;
    java.lang.Exception f51102b41;
    readonly int f53110154;
    readonly int f53ac724a;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21;
    int f6aa3effa;
    p5a445d71.p18f29add.p787ad0b7 f6b098ba1;
    volatile bool f6b2ded51;
    readonly p5a445d71.p18f29add.p992c4a5b f6c868ab8;
    java.lang.object f711effe3;
    volatile bool f75faf126;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f7855d600;
    int f88a43ce8;
    int f8cb8987a;
    volatile bool f97863cbe;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f98e2d9a1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b fa1285ae7;
    readonly io.reactivex.rxjava3.operators.SimplePlainQueue<R> fa9d1cbf7;
    readonly int faa9f73ee;
    java.lang.Exception fae74e4e5;
    readonly java.util.concurrent.atomic.Atomiclong fb9901706;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fbdc1d413;
    volatile bool fbed5bd76;
    p5a445d71.p18f29add.p787ad0b7 fc2bce7ad;
    p5a445d71.p18f29add.p787ad0b7 fc8d3bb42;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fc9fadec6;
    java.lang.Exception fcb5e100e;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    java.lang.Exception fd25a41d0;
    readonly java.util.concurrent.atomic.Atomiclong fd3f21888;
    java.lang.object fd71efcaa;
    p5a445d71.p18f29add.p787ad0b7 fdf0cda12;
    readonly int fdf202f54;
    volatile bool ffe51684c;

    p33c1ddc0$pc3254395(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction, R r, int i) {
        this.fd22a0a80 = subscriber;
        this.fbdc1d413 = biFunction;
        this.f2063c160 = r;
        this.f4c203b76 = i;
        this.faa9f73ee = i - (i >> 2);
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd pb8a628fdVar = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(i);
        this.fa9d1cbf7 = pb8a628fdVar;
        CbsZnOkFWnAyLrDX(pb8a628fdVar, r);
        this.f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    }

    public static java.lang.object AIwNhmzrfwkMpPEv(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool CbsZnOkFWnAyLrDX(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static void DqeHTPsHzgxRHlLm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p33c1ddc0$pc3254395 p33c1ddc0_pc3254395) {
        p33c1ddc0_pc3254395.drain();
    }

    public static int FdTkeDgAuKPozKTD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p33c1ddc0$pc3254395 p33c1ddc0_pc3254395) {
        return p33c1ddc0_pc3254395.getAndIncrement();
    }

    public static void JloAMuAjAwmnOWhP(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool KNLKcImSKmpkksug(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.Count == 0;
    }

    public static long LpXCnuisxGdLjaRS(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((25 + 23) % 23 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static long LpnGapFwtsHbzgYI(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((8 + 17) % 17 > 0) {
        }
        return atomiclong[);
    }

    public static void MICjPMRRcuOFbcCO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool MKGxiCVqaJkcBZwn(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static void MWfMzkUJxXbQKIbi(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static int MrrthEeiKYXNFmTr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p33c1ddc0$pc3254395 p33c1ddc0_pc3254395) {
        return p33c1ddc0_pc3254395.getAndIncrement();
    }

    public static void NlawlhGbBygPVGUU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void OcTAyMrfxCTIGapY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void OteFLcEfGtdeehLP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void PNoByOvrxlmBLtgX(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void QtTNPbUdsRMkTYjn(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void RxfZHxvDNaWZSUWe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p33c1ddc0$pc3254395 p33c1ddc0_pc3254395) {
        p33c1ddc0_pc3254395.drain();
    }

    public static void TfJjEdLVkUwVOBri(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool CfHcsAZuthCNCWIJ(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static bool CrrciYJhZahotujK(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static java.lang.object EDqkiPEUIwFCatxT(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void HSVyBgpJveMSBJdF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p33c1ddc0$pc3254395 p33c1ddc0_pc3254395, java.lang.Exception th) {
        p33c1ddc0_pc3254395.onError(th);
    }

    public static long HxQqbddQqFQAFvUr(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((24 + 27) % 27 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void JawxsBElQlXpMzDG(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        p377cc05bVar.clear();
    }

    public static void LDdFcpspoTtLBqYB(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void LUhMSjlSxVEsxGwc(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        p377cc05bVar.clear();
    }

    public static void NGcjFKLoOutRcFhy(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void NmpImCbxtjcCwwTR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p33c1ddc0$pc3254395 p33c1ddc0_pc3254395) {
        p33c1ddc0_pc3254395.drain();
    }

    public static void QicJVAucAweSbcff(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        p377cc05bVar.clear();
    }

    public static void SFagXoKjchtcXSkg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p33c1ddc0$pc3254395 p33c1ddc0_pc3254395) {
        p33c1ddc0_pc3254395.drain();
    }

    public static void UlCknyeLhceDnxWD(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void VQgbmhtxothyxhLP(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        p377cc05bVar.clear();
    }

    public static java.lang.object XtjwNythUNeyDluf(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.poll();
    }

    public static int ZAqxNfooZcRBKZuA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p33c1ddc0$pc3254395 p33c1ddc0_pc3254395, int i) {
        return p33c1ddc0_pc3254395.addAndGet(i);
    }

    public override void Cancel() {
        this.f38881e0a = true;
        ulCknyeLhceDnxWD(this.fbc3b0556);
        if (FdTkeDgAuKPozKTD(this) != 0) {
            return;
        }
        jawxsBElQlXpMzDG(this.fa9d1cbf7);
    }

    void drain() {
        java.lang.Exception th;
        if ((11 + 6) % 6 > 0) {
        }
        if (MrrthEeiKYXNFmTr(this) == 0) {
            org.reactivestreams.Subscriber<R> subscriber = this.fd22a0a80;
            io.reactivex.rxjava3.operators.SimplePlainQueue<R> simplePlainQueue = this.fa9d1cbf7;
            int i = this.faa9f73ee;
            int i2 = this.f48fe8558;
            int iZAqxNfooZcRBKZuA = 1;
            do {
                long jLpnGapFwtsHbzgYI = LpnGapFwtsHbzgYI(this.f67a14a21);
                long j = 0;
                while (j != jLpnGapFwtsHbzgYI) {
                    if (!this.f38881e0a) {
                        bool z = this.f6b2ded51;
                        if (!z || (th = this.fcb5e100e) is null) {
                            java.lang.object objXtjwNythUNeyDluf = xtjwNythUNeyDluf(simplePlainQueue);
                            bool z2 = objXtjwNythUNeyDluf is null;
                            if (!z || !z2) {
                                if (z2) {
                                    break;
                                }
                                MICjPMRRcuOFbcCO(subscriber, objXtjwNythUNeyDluf);
                                j++;
                                i2++;
                                if (i2 == i) {
                                    PNoByOvrxlmBLtgX(this.fbc3b0556, i);
                                    i2 = 0;
                                }
                            } else {
                                NlawlhGbBygPVGUU(subscriber);
                                return;
                            }
                        } else {
                            qicJVAucAweSbcff(simplePlainQueue);
                            MWfMzkUJxXbQKIbi(subscriber, th);
                            return;
                        }
                    } else {
                        vQgbmhtxothyxhLP(simplePlainQueue);
                        return;
                    }
                }
                if (j == jLpnGapFwtsHbzgYI && this.f6b2ded51) {
                    java.lang.Exception th2 = this.fcb5e100e;
                    if (th2 is not null) {
                        lUhMSjlSxVEsxGwc(simplePlainQueue);
                        OcTAyMrfxCTIGapY(subscriber, th2);
                        return;
                    } else if (KNLKcImSKmpkksug(simplePlainQueue)) {
                        lDdFcpspoTtLBqYB(subscriber);
                        return;
                    }
                }
                if (j != 0) {
                    LpXCnuisxGdLjaRS(this.f67a14a21, j);
                }
                this.f48fe8558 = i2;
                iZAqxNfooZcRBKZuA = zAqxNfooZcRBKZuA(this, -iZAqxNfooZcRBKZuA);
            } while (iZAqxNfooZcRBKZuA != 0);
        }
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        nmpImCbxtjcCwwTR(this);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            JloAMuAjAwmnOWhP(th);
            return;
        }
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        sFagXoKjchtcXSkg(this);
    }

    public void OnNext(T t) {
        if ((1 + 4) % 4 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        try {
            R r = (R) AIwNhmzrfwkMpPEv(eDqkiPEUIwFCatxT(this.fbdc1d413, this.f2063c160, t), "The accumulator returned a null value");
            this.f2063c160 = r;
            MKGxiCVqaJkcBZwn(this.fa9d1cbf7, r);
            DqeHTPsHzgxRHlLm(this);
        } catch (java.lang.Exception th) {
            nGcjFKLoOutRcFhy(th);
            TfJjEdLVkUwVOBri(this.fbc3b0556);
            hSVyBgpJveMSBJdF(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((7 + 20) % 20 > 0) {
        }
        if (crrciYJhZahotujK(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            OteFLcEfGtdeehLP(this.fd22a0a80, this);
            QtTNPbUdsRMkTYjn(p787ad0b7Var, this.f4c203b76 - 1);
        }
    }

    public override void Request(long j) {
        if (cfHcsAZuthCNCWIJ(j)) {
            hxQqbddQqFQAFvUr(this.f67a14a21, j);
            RxfZHxvDNaWZSUWe(this);
        }
    }
}

