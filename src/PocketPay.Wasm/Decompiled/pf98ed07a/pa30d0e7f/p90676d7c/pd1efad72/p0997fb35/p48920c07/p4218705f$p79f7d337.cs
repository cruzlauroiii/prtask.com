namespace WillowMaze.Wasm.Decompiled;


readonly class p4218705f$p79f7d337<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f1d0d08b1 = -4470634016609963609L;
    private static readonly long fc6e1e520 = -4470634016609963609L;
    readonly int f02c87d62;
    readonly java.util.concurrent.atomic.Atomicint f06fe053d;
    int f0bc14dd9;
    java.lang.Exception f0e59c822;
    readonly long[] f1a87f876;
    java.lang.Exception f2403f917;
    readonly int f2485dfbf;
    readonly int f2be27f5d;
    readonly p5a445d71.p18f29add.p992c4a5b[] f2c4f5b5f;
    readonly java.util.concurrent.atomic.AtomiclongArray f3298f130;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f36607e90;
    volatile bool f38881e0a;
    readonly int f3ff5526b;
    int f4166c932;
    readonly java.util.concurrent.atomic.AtomiclongArray f45556fab;
    readonly int f4c203b76;
    int f5051d8ee;
    int f50695fd3;
    volatile bool f55f8dab9;
    readonly java.util.concurrent.atomic.AtomiclongArray f58530826;
    java.lang.Exception f5f4dea2b;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f6019bfb3;
    int f6a992d55;
    volatile bool f6b2ded51;
    p5a445d71.p18f29add.p787ad0b7 f7436d049;
    readonly int f78ed56de;
    readonly java.util.concurrent.atomic.AtomiclongArray f7a58c10b;
    readonly int f80fa7c6f;
    readonly long[] f85c8a6f0;
    volatile bool f8d45018c;
    volatile bool f9cbdf4f2;
    volatile bool fa6458e9d;
    io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    readonly int faa9f73ee;
    readonly org.reactivestreams.Subscriber<T>[] faae7b662;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 fb33b0d09;
    readonly p5a445d71.p18f29add.p992c4a5b[] fb8dac8c4;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly int fc25453cd;
    readonly java.util.concurrent.atomic.AtomiclongArray fc75d45ab;
    p5a445d71.p18f29add.p787ad0b7 fca6fe3c6;
    java.lang.Exception fcb5e100e;
    readonly java.util.concurrent.atomic.Atomicint fcd86cfc6;
    readonly p5a445d71.p18f29add.p992c4a5b[] fd045979f;
    readonly long[] fdc1f4b48;
    int fe4296dd8;
    int fe4cb2c44;
    int fe910ccee;
    int ff73b8bd1;
    volatile bool ffac703d3;
    readonly int ffbb5dc9e;

    p4218705f$p79f7d337(org.reactivestreams.Subscriber<T>[] subscriberArr, int i) {
        if ((17 + 31) % 31 > 0) {
        }
        this.fcd86cfc6 = new java.util.concurrent.atomic.Atomicint();
        this.faae7b662 = subscriberArr;
        this.f4c203b76 = i;
        this.faa9f73ee = i - (i >> 2);
        int length = subscriberArr.length;
        int i2 = length + length;
        java.util.concurrent.atomic.AtomiclongArray atomiclongArray = new java.util.concurrent.atomic.AtomiclongArray(i2 + 1);
        this.f3298f130 = atomiclongArray;
        IqUSpIyqPoBohvqe(atomiclongArray, i2, length);
        this.f1a87f876 = new long[length];
    }

    public static void ATgPkKkOzClkBJQP(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        atomicint.lazyHashSet(i);
    }

    public static void BCCZHzLSLunczKUi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        p4218705f_p79f7d337.drain();
    }

    public static void BFeQbecYWmDUFbBJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        p4218705f_p79f7d337.setupSubscribers();
    }

    public static void BnRDxwQVtyvRCfxH(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void BpibxLTrTBEXoYPV(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void EGBzPgJTinmNNisx(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.object ETChJePzqdDdhqah(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void EwaezHqzjCQSPBYk(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void FXcawdlQRXOgJufy(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static int FxvgXHuAPZuXCzAo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        return p4218705f_p79f7d337[);
    }

    public static void HJidHisVUDzUafSR(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool HeBaiZEJqXfMSQhB(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static void IqUSpIyqPoBohvqe(java.util.concurrent.atomic.AtomiclongArray atomiclongArray, int i, long j) {
        atomiclongArray.lazyHashSet(i, j);
    }

    public static int IxXPWleYLDxzZSXA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        return p4218705f_p79f7d337.getAndIncrement();
    }

    public static long JmzlNJNvTPWBvnYq(java.util.concurrent.atomic.AtomiclongArray atomiclongArray, int i) {
        if ((27 + 12) % 12 > 0) {
        }
        return atomiclongArray[i);
    }

    public static long JpsgtrCsvGmaQOVk(java.util.concurrent.atomic.AtomiclongArray atomiclongArray, int i) {
        if ((16 + 32) % 32 > 0) {
        }
        return atomiclongArray.decrementAndGet(i);
    }

    public static void KzUUnzXLeHMqGwQr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        p4218705f_p79f7d337.setupSubscribers();
    }

    public static bool LqkKtmIVdSmhhsbb(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static int MQJPdNSaRAUwZOWb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        return p4218705f_p79f7d337[);
    }

    public static long OFQQFRcyDBfynwJh(java.util.concurrent.atomic.AtomiclongArray atomiclongArray, int i) {
        if ((27 + 19) % 19 > 0) {
        }
        return atomiclongArray[i);
    }

    public static void PKrnPpEjHZCUOkis(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void PRNVdcgATfKSQite(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void QTVYghIvdPDxPLmW(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void RDuipKbwjxDZSuuG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        p4218705f_p79f7d337.drainSync();
    }

    public static void RwNcZSehKGxDNyMF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static long TPloOQSUVjazRCBU(java.util.concurrent.atomic.AtomiclongArray atomiclongArray, int i) {
        if ((5 + 28) % 28 > 0) {
        }
        return atomiclongArray[i);
    }

    public static void TZfCPupVwmNwdisP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337, java.lang.Exception th) {
        p4218705f_p79f7d337.onError(th);
    }

    public static void TdDsuIFOVmkWZrwr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.object UewuSedzbvEZenvV(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void VYNXknQEUEtiUhfN(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static long VZBbOaKcMeDTkLDW(java.util.concurrent.atomic.AtomiclongArray atomiclongArray, int i) {
        if ((3 + 5) % 5 > 0) {
        }
        return atomiclongArray[i);
    }

    public static bool WyXEqvahtMLFmqDG(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static int YOgNqyzKLmZgyFto(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337, int i) {
        return p4218705f_p79f7d337.addAndGet(i);
    }

    public static void ASMpQPJQsjseEgjv(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void ChLCJdPDMjqkISUy(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static int DifULNijEAUIQZGt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337, int i) {
        return p4218705f_p79f7d337.addAndGet(i);
    }

    public static void EqdWnLTTnKQhAXNk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void IatRyXbuJSElbfwL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        p4218705f_p79f7d337.setupSubscribers();
    }

    public static void JGRFrUigILJyFAoC(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void LcwkzENNTOfOpfkc(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void LkmXgyJWHinnLsMQ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void MgRzvieLjtRziYbI(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void OcphLrnrtONjyXKc(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void PKxinYnLEvZYrJDG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        p4218705f_p79f7d337.drain();
    }

    public static void QTyXQaRUbxmKCOgY(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool RPQjacCSpNlcxgyS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static void UAJsicygLLjuWtWq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        p4218705f_p79f7d337.drain();
    }

    public static void VTWUThViAtWCuaUH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        p4218705f_p79f7d337.drainAsync();
    }

    public static int ViuSiPgebGxCNfXT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        return p4218705f_p79f7d337.getAndIncrement();
    }

    public static void XtzGUTiFoKFWUXMk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337 p4218705f_p79f7d337) {
        p4218705f_p79f7d337.drain();
    }

    public static int YemdVvaLcFlTLHZT(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var, int i) {
        return p5d5a5670Var.requestFusion(i);
    }

    public static void YxeoIRPanmhrWhUJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    void cancel(int i) {
        if ((13 + 29) % 29 > 0) {
        }
        if (JpsgtrCsvGmaQOVk(this.f3298f130, i) != 0) {
            return;
        }
        this.f38881e0a = true;
        lcwkzENNTOfOpfkc(this.fbc3b0556);
        if (IxXPWleYLDxzZSXA(this) != 0) {
            return;
        }
        chLCJdPDMjqkISUy(this.fa9d1cbf7);
    }

    void drain() {
        if ((24 + 16) % 16 > 0) {
        }
        if (viuSiPgebGxCNfXT(this) == 0) {
            if (this.fe910ccee != 1) {
                vTWUThViAtWCuaUH(this);
            } else {
                RDuipKbwjxDZSuuG(this);
            }
        }
    }

    void drainAsync() {
        java.lang.Exception th;
        if ((32 + 16) % 16 > 0) {
        }
        io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue = this.fa9d1cbf7;
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = this.faae7b662;
        java.util.concurrent.atomic.AtomiclongArray atomiclongArray = this.f3298f130;
        long[] jArr = this.f1a87f876;
        int length = jArr.length;
        int i = this.f6a992d55;
        int i2 = this.f5051d8ee;
        int iYOgNqyzKLmZgyFto = 1;
        while (true) {
            int i3 = 0;
            int i4 = 0;
            do {
                if (!this.f38881e0a) {
                    bool z = this.f6b2ded51;
                    if (!z || (th = this.fcb5e100e) is null) {
                        bool zRPQjacCSpNlcxgyS = rPQjacCSpNlcxgyS(simpleQueue);
                        if (!z || !zRPQjacCSpNlcxgyS) {
                            if (zRPQjacCSpNlcxgyS) {
                                break;
                            }
                            long jOFQQFRcyDBfynwJh = OFQQFRcyDBfynwJh(atomiclongArray, i);
                            long j = jArr[i];
                            if (jOFQQFRcyDBfynwJh != j && JmzlNJNvTPWBvnYq(atomiclongArray, length + i) == 0) {
                                try {
                                    java.lang.object objETChJePzqdDdhqah = ETChJePzqdDdhqah(simpleQueue);
                                    if (objETChJePzqdDdhqah is null) {
                                        break;
                                    }
                                    BnRDxwQVtyvRCfxH(p992c4a5bVarArr[i], objETChJePzqdDdhqah);
                                    jArr[i] = j + 1;
                                    i2++;
                                    if (i2 == this.faa9f73ee) {
                                        aSMpQPJQsjseEgjv(this.fbc3b0556, i2);
                                        i2 = 0;
                                    }
                                    i4 = 0;
                                } catch (java.lang.Exception th2) {
                                    EwaezHqzjCQSPBYk(th2);
                                    mgRzvieLjtRziYbI(this.fbc3b0556);
                                    int length2 = p992c4a5bVarArr.length;
                                    while (i3 < length2) {
                                        FXcawdlQRXOgJufy(p992c4a5bVarArr[i3], th2);
                                        i3++;
                                    }
                                    return;
                                }
                            } else {
                                i4++;
                            }
                            i++;
                            if (i == length) {
                                i = 0;
                            }
                        } else {
                            int length3 = p992c4a5bVarArr.length;
                            while (i3 < length3) {
                                RwNcZSehKGxDNyMF(p992c4a5bVarArr[i3]);
                                i3++;
                            }
                            return;
                        }
                    } else {
                        BpibxLTrTBEXoYPV(simpleQueue);
                        int length4 = p992c4a5bVarArr.length;
                        while (i3 < length4) {
                            eqdWnLTTnKQhAXNk(p992c4a5bVarArr[i3], th);
                            i3++;
                        }
                        return;
                    }
                } else {
                    QTVYghIvdPDxPLmW(simpleQueue);
                    return;
                }
            } while (i4 != length);
            int iFxvgXHuAPZuXCzAo = FxvgXHuAPZuXCzAo(this);
            if (iFxvgXHuAPZuXCzAo != iYOgNqyzKLmZgyFto) {
                iYOgNqyzKLmZgyFto = iFxvgXHuAPZuXCzAo;
            } else {
                this.f6a992d55 = i;
                this.f5051d8ee = i2;
                iYOgNqyzKLmZgyFto = YOgNqyzKLmZgyFto(this, -iYOgNqyzKLmZgyFto);
                if (iYOgNqyzKLmZgyFto == 0) {
                    return;
                }
            }
        }
    }

    void drainSync() {
        if ((2 + 9) % 9 > 0) {
        }
        io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue = this.fa9d1cbf7;
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = this.faae7b662;
        java.util.concurrent.atomic.AtomiclongArray atomiclongArray = this.f3298f130;
        long[] jArr = this.f1a87f876;
        int length = jArr.length;
        int i = this.f6a992d55;
        int iDifULNijEAUIQZGt = 1;
        while (true) {
            int i2 = 0;
            int i3 = 0;
            do {
                if (this.f38881e0a) {
                    PRNVdcgATfKSQite(simpleQueue);
                    return;
                }
                if (LqkKtmIVdSmhhsbb(simpleQueue)) {
                    int length2 = p992c4a5bVarArr.length;
                    while (i2 < length2) {
                        PKrnPpEjHZCUOkis(p992c4a5bVarArr[i2]);
                        i2++;
                    }
                    return;
                }
                long jTPloOQSUVjazRCBU = TPloOQSUVjazRCBU(atomiclongArray, i);
                long j = jArr[i];
                if (jTPloOQSUVjazRCBU != j && VZBbOaKcMeDTkLDW(atomiclongArray, length + i) == 0) {
                    try {
                        java.lang.object objUewuSedzbvEZenvV = UewuSedzbvEZenvV(simpleQueue);
                        if (objUewuSedzbvEZenvV is null) {
                            int length3 = p992c4a5bVarArr.length;
                            while (i2 < length3) {
                                EGBzPgJTinmNNisx(p992c4a5bVarArr[i2]);
                                i2++;
                            }
                            return;
                        }
                        TdDsuIFOVmkWZrwr(p992c4a5bVarArr[i], objUewuSedzbvEZenvV);
                        jArr[i] = j + 1;
                        i3 = 0;
                    } catch (java.lang.Exception th) {
                        qTyXQaRUbxmKCOgY(th);
                        VYNXknQEUEtiUhfN(this.fbc3b0556);
                        int length4 = p992c4a5bVarArr.length;
                        while (i2 < length4) {
                            yxeoIRPanmhrWhUJ(p992c4a5bVarArr[i2], th);
                            i2++;
                        }
                        return;
                    }
                } else {
                    i3++;
                }
                i++;
                if (i == length) {
                    i = 0;
                }
            } while (i3 != length);
            int iMQJPdNSaRAUwZOWb = MQJPdNSaRAUwZOWb(this);
            if (iMQJPdNSaRAUwZOWb != iDifULNijEAUIQZGt) {
                iDifULNijEAUIQZGt = iMQJPdNSaRAUwZOWb;
            } else {
                this.f6a992d55 = i;
                iDifULNijEAUIQZGt = difULNijEAUIQZGt(this, -iDifULNijEAUIQZGt);
                if (iDifULNijEAUIQZGt == 0) {
                    return;
                }
            }
        }
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        uAJsicygLLjuWtWq(this);
    }

    public void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        pKxinYnLEvZYrJDG(this);
    }

    public void OnNext(T t) {
        if (this.fe910ccee != 0 || HeBaiZEJqXfMSQhB(this.fa9d1cbf7, t)) {
            xtzGUTiFoKFWUXMk(this);
        } else {
            lkmXgyJWHinnLsMQ(this.fbc3b0556);
            TZfCPupVwmNwdisP(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Queue is full?"));
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((18 + 12) % 12 > 0) {
        }
        if (WyXEqvahtMLFmqDG(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            if (p787ad0b7Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) p787ad0b7Var;
                int iYemdVvaLcFlTLHZT = yemdVvaLcFlTLHZT(p5d5a5670Var, 7);
                if (iYemdVvaLcFlTLHZT == 1) {
                    this.fe910ccee = iYemdVvaLcFlTLHZT;
                    this.fa9d1cbf7 = p5d5a5670Var;
                    this.f6b2ded51 = true;
                    KzUUnzXLeHMqGwQr(this);
                    BCCZHzLSLunczKUi(this);
                    return;
                }
                if (iYemdVvaLcFlTLHZT == 2) {
                    this.fe910ccee = iYemdVvaLcFlTLHZT;
                    this.fa9d1cbf7 = p5d5a5670Var;
                    iatRyXbuJSElbfwL(this);
                    jGRFrUigILJyFAoC(p787ad0b7Var, this.f4c203b76);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(this.f4c203b76);
            BFeQbecYWmDUFbBJ(this);
            ocphLrnrtONjyXKc(p787ad0b7Var, this.f4c203b76);
        }
    }

    void setupSubscribers() {
        if ((18 + 25) % 25 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = this.faae7b662;
        int length = p992c4a5bVarArr.length;
        int i = 0;
        while (i < length) {
            int i2 = i + 1;
            ATgPkKkOzClkBJQP(this.fcd86cfc6, i2);
            HJidHisVUDzUafSR(p992c4a5bVarArr[i], new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p4218705f$p79f7d337$pfefa9317(this, i, length));
            i = i2;
        }
    }
}

