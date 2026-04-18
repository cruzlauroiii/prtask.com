namespace WillowMaze.Wasm.Decompiled;


readonly class p4ee71481$p25f7d300<T> : java.util.ArrayQueue<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f184d2857 = 7240042530241604978L;
    private static readonly long f2cc34630 = 7240042530241604978L;
    private static readonly long f50933a9c = 7240042530241604978L;
    private static readonly long fc6e1e520 = 7240042530241604978L;
    private static readonly long fe066a9b2 = 7240042530241604978L;
    p5a445d71.p18f29add.p787ad0b7 f203741aa;
    readonly p5a445d71.p18f29add.p992c4a5b f31589494;
    readonly java.util.concurrent.atomic.Atomiclong f31a06c8a;
    volatile bool f38881e0a;
    volatile bool f6b2ded51;
    readonly int f753562db;
    readonly int f7af6637c;
    readonly java.util.concurrent.atomic.Atomicint f7d372165;
    p5a445d71.p18f29add.p787ad0b7 f7ed0cc73;
    readonly p5a445d71.p18f29add.p992c4a5b fa1ee3c8b;
    readonly int fad6a2a86;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    volatile bool fcedf9762;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    p5a445d71.p18f29add.p787ad0b7 fda49d1d6;
    readonly java.util.concurrent.atomic.Atomicint fdb5af71d;
    readonly int fe2942a04;
    volatile bool ff3c029ec;
    volatile bool ffd09ec9d;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly java.util.concurrent.atomic.Atomicint ffa687cdf = new java.util.concurrent.atomic.Atomicint();

    p4ee71481$p25f7d300(org.reactivestreams.Subscriber<T> subscriber, int i) {
        this.fd22a0a80 = subscriber;
        this.fe2942a04 = i;
    }

    public static void AWkXJmnvqHXaQxWG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.object BRiZMdwfWPeaBfLk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p4ee71481$p25f7d300 p4ee71481_p25f7d300) {
        return p4ee71481_p25f7d300.poll();
    }

    public static bool IeewlWsloYXXRyGM(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static bool IqMHNYzcRctexyyz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p4ee71481$p25f7d300 p4ee71481_p25f7d300) {
        return p4ee71481_p25f7d300.Count == 0;
    }

    public static void JYyyBsvVkYGCymei(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p4ee71481$p25f7d300 p4ee71481_p25f7d300) {
        p4ee71481_p25f7d300.drain();
    }

    public static void LBZqXikazqFIWIrE(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool MicFFLbOMKTbqySm(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static java.lang.object MirMByFnaWkvAhUW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p4ee71481$p25f7d300 p4ee71481_p25f7d300) {
        return p4ee71481_p25f7d300.poll();
    }

    public static void NIamhZlIAeXyxBym(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static long ReRIkDPSJDXxlbQI(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((31 + 9) % 9 > 0) {
        }
        return atomiclong[);
    }

    public static int VOiGcoBDcTdNXVSx(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void VfzbdNFrrLEaDuDi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void XGNaUZHDEinZOXUv(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void YGBNCSRDedFIaCat(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p4ee71481$p25f7d300 p4ee71481_p25f7d300) {
        p4ee71481_p25f7d300.drain();
    }

    public static bool MXPuiMNktMXgDAYN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p4ee71481$p25f7d300 p4ee71481_p25f7d300, java.lang.object obj) {
        return p4ee71481_p25f7d300.offer(obj);
    }

    public static void MoljpGJlNrgRLAev(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void NVWfBJxcnyclsklB(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static int QNGmeEYTBKepTLJz(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static int SIEXtdbRDGYUbWFT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p4ee71481$p25f7d300 p4ee71481_p25f7d300) {
        return p4ee71481_p25f7d300.Count;
    }

    public static long ToMrrdKGRRUVVHRR(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((15 + 6) % 6 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static long XbTQPfFRrkULSClB(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((5 + 9) % 9 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public override void Cancel() {
        this.f38881e0a = true;
        NIamhZlIAeXyxBym(this.fbc3b0556);
    }

    void drain() {
        if ((17 + 10) % 10 > 0) {
        }
        if (qNGmeEYTBKepTLJz(this.ffa687cdf) != 0) {
            return;
        }
        org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
        long jReRIkDPSJDXxlbQI = ReRIkDPSJDXxlbQI(this.f67a14a21);
        while (!this.f38881e0a) {
            if (this.f6b2ded51) {
                long j = 0;
                while (j != jReRIkDPSJDXxlbQI) {
                    if (this.f38881e0a) {
                        return;
                    }
                    java.lang.object objMirMByFnaWkvAhUW = MirMByFnaWkvAhUW(this);
                    if (objMirMByFnaWkvAhUW is null) {
                        nVWfBJxcnyclsklB(subscriber);
                        return;
                    } else {
                        AWkXJmnvqHXaQxWG(subscriber, objMirMByFnaWkvAhUW);
                        j++;
                    }
                }
                if (IqMHNYzcRctexyyz(this)) {
                    XGNaUZHDEinZOXUv(subscriber);
                    return;
                } else if (j != 0) {
                    jReRIkDPSJDXxlbQI = xbTQPfFRrkULSClB(this.f67a14a21, j);
                }
            }
            if (VOiGcoBDcTdNXVSx(this.ffa687cdf) == 0) {
                return;
            }
        }
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        JYyyBsvVkYGCymei(this);
    }

    public void OnError(java.lang.Exception th) {
        moljpGJlNrgRLAev(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((19 + 7) % 7 > 0) {
        }
        if (this.fe2942a04 == sIEXtdbRDGYUbWFT(this)) {
            BRiZMdwfWPeaBfLk(this);
        }
        mXPuiMNktMXgDAYN(this, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((18 + 8) % 8 > 0) {
        }
        if (IeewlWsloYXXRyGM(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            LBZqXikazqFIWIrE(this.fd22a0a80, this);
            VfzbdNFrrLEaDuDi(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    public override void Request(long j) {
        if (MicFFLbOMKTbqySm(j)) {
            toMrrdKGRRUVVHRR(this.f67a14a21, j);
            YGBNCSRDedFIaCat(this);
        }
    }
}

