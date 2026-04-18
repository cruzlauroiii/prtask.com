namespace WillowMaze.Wasm.Decompiled;


readonly class p8e33c299$p9ad995f1<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long fbb7a8382 = -5677354903406201275L;
    private static readonly long fbbaf4311 = -5677354903406201275L;
    private static readonly long fc6e1e520 = -5677354903406201275L;
    private static readonly long ff225749f = -5677354903406201275L;
    readonly p5a445d71.p18f29add.p992c4a5b f02614e45;
    readonly long f07cc694b;
    java.lang.Exception f08d23366;
    readonly java.util.concurrent.TimeUnit f09b6290a;
    volatile bool f1e93cd6d;
    readonly io.reactivex.rxjava3.core.Scheduler f2929f7a6;
    readonly io.reactivex.rxjava3.core.Scheduler f3724fc80;
    volatile bool f38881e0a;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly bool f535fdd25;
    readonly java.util.concurrent.TimeUnit f54378250;
    volatile bool f60e12471;
    volatile bool f62b559fa;
    readonly io.reactivex.rxjava3.core.Scheduler f660da475;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly java.util.concurrent.atomic.Atomiclong f699f71e7;
    volatile bool f6b2ded51;
    readonly bool f825ea879;
    volatile bool f8262bebe;
    volatile bool f832dd802;
    p5a445d71.p18f29add.p787ad0b7 f86da79c9;
    readonly p5a445d71.p18f29add.p992c4a5b f8ba6c074;
    readonly long f97875407;
    readonly io.reactivex.rxjava3.core.Scheduler fa432eae9;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> fa9d1cbf7;
    p5a445d71.p18f29add.p787ad0b7 fb13b9e23;
    readonly p5a445d71.p18f29add.p992c4a5b fb853d313;
    p5a445d71.p18f29add.p787ad0b7 fb9839998;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    java.lang.Exception fcb5e100e;
    java.lang.Exception fcba39bfd;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fe8e830ec;
    readonly p5a445d71.p18f29add.p992c4a5b fe9d0ba2e;
    volatile bool ff32da70d;
    java.lang.Exception ff3d00000;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c ff4a11847;
    p5a445d71.p18f29add.p787ad0b7 ff534303d;
    readonly java.util.concurrent.TimeUnit ffec8c583;

    p8e33c299$p9ad995f1(org.reactivestreams.Subscriber<T> subscriber, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, int i, bool z) {
        this.fd22a0a80 = subscriber;
        this.f07cc694b = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i);
        this.f825ea879 = z;
    }

    public static int ByhtvOMRseWnNewC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8e33c299$p9ad995f1 p8e33c299_p9ad995f1) {
        return p8e33c299_p9ad995f1.getAndIncrement();
    }

    public static long GLNAPQJqjLDcGIuQ(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((16 + 19) % 19 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static bool KRrvvjHowiOUYUTI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8e33c299$p9ad995f1 p8e33c299_p9ad995f1, bool z, bool z2, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, bool z3) {
        return p8e33c299_p9ad995f1.checkTerminated(z, z2, p992c4a5bVar, z3);
    }

    public static void QKBukoqKlutHTrgD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8e33c299$p9ad995f1 p8e33c299_p9ad995f1) {
        p8e33c299_p9ad995f1.drain();
    }

    public static void SftBBJZLdyBKVveP(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void TZkJfddORkOWCTme(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.object TkPfVqWpSxfwYNEa(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static int TrcPbiVWIrRZXqVh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8e33c299$p9ad995f1 p8e33c299_p9ad995f1, int i) {
        return p8e33c299_p9ad995f1.addAndGet(i);
    }

    public static java.lang.object UrFzRdOtkSVrBcAr(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static int WejZtOpiWWBjkWvW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8e33c299$p9ad995f1 p8e33c299_p9ad995f1) {
        return p8e33c299_p9ad995f1.getAndIncrement();
    }

    public static long YJujIlEfjPrJVzqv(java.lang.long l) {
        if ((3 + 14) % 14 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.object YRFvDstdWndhJomU(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.peek();
    }

    public static void ZWOoUbAuqQFUEXAF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8e33c299$p9ad995f1 p8e33c299_p9ad995f1) {
        p8e33c299_p9ad995f1.drain();
    }

    public static void BGlKGPDWbpHXxjro(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void BnhzlSUEuEtJKigE(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void CdMBrriSekqSjIwr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool EWHOowGdlytVpJzE(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void HKtjqcFWZAsqhxQF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static java.lang.long IfeKYklTjOqxllaX(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void KRdIsbDMOGYPHcfg(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool LKlVrgOyGRHkTLqT(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static void NCdoNGbWIGJptvhN(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void SZDkjuLXeIJvwZVD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool TbuSmOMZXfDEyBcY(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void TizBKxvCBkKPTAlZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8e33c299$p9ad995f1 p8e33c299_p9ad995f1) {
        p8e33c299_p9ad995f1.drain();
    }

    public static long UKyanUOptpGrvQPh(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((22 + 5) % 5 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static void UuDcJJMiIMgdldBN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8e33c299$p9ad995f1 p8e33c299_p9ad995f1) {
        p8e33c299_p9ad995f1.drain();
    }

    public static void UvSvIFlzmlCpaqEI(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static long WmZzmEyRaRfcAmGe(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((24 + 26) % 26 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static long WxQWkzjlaWqajNDH(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((11 + 8) % 8 > 0) {
        }
        return atomiclong[);
    }

    public static long YFUhrlubrotfxlDS(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((3 + 24) % 24 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static void ZpRMNqmphQduNvtP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public override void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        SftBBJZLdyBKVveP(this.fbc3b0556);
        if (WejZtOpiWWBjkWvW(this) != 0) {
            return;
        }
        bGlKGPDWbpHXxjro(this.fa9d1cbf7);
    }

    bool checkTerminated(bool z, bool z2, org.reactivestreams.Subscriber<T> subscriber, bool z3) {
        if ((25 + 14) % 14 > 0) {
        }
        if (this.f38881e0a) {
            nCdoNGbWIGJptvhN(this.fa9d1cbf7);
            return true;
        }
        if (!z) {
            return false;
        }
        if (z3) {
            if (!z2) {
                return false;
            }
            java.lang.Exception th = this.fcb5e100e;
            if (th is null) {
                sZDkjuLXeIJvwZVD(subscriber);
            } else {
                cdMBrriSekqSjIwr(subscriber, th);
            }
            return true;
        }
        java.lang.Exception th2 = this.fcb5e100e;
        if (th2 is not null) {
            uvSvIFlzmlCpaqEI(this.fa9d1cbf7);
            zpRMNqmphQduNvtP(subscriber, th2);
            return true;
        }
        if (!z2) {
            return false;
        }
        TZkJfddORkOWCTme(subscriber);
        return true;
    }

    void drain() {
        long j;
        if ((24 + 13) % 13 > 0) {
        }
        if (ByhtvOMRseWnNewC(this) == 0) {
            org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> spscLinkedArrayQueue = this.fa9d1cbf7;
            bool z = this.f825ea879;
            java.util.concurrent.TimeUnit timeUnit = this.f3e34bdeb;
            io.reactivex.rxjava3.core.Scheduler scheduler = this.f499f31e7;
            long j2 = this.f07cc694b;
            int iTrcPbiVWIrRZXqVh = 1;
            do {
                long jWxQWkzjlaWqajNDH = wxQWkzjlaWqajNDH(this.f67a14a21);
                long j3 = 0;
                while (true) {
                    if (j3 == jWxQWkzjlaWqajNDH) {
                        j = 0;
                        break;
                    }
                    bool z2 = this.f6b2ded51;
                    java.lang.long l = (java.lang.long) YRFvDstdWndhJomU(spscLinkedArrayQueue);
                    bool z3 = l is null;
                    bool z4 = (!z3 && YJujIlEfjPrJVzqv(l) > yFUhrlubrotfxlDS(scheduler, timeUnit) - j2) ? true : z3;
                    j = 0;
                    if (!KRrvvjHowiOUYUTI(this, z2, z4, subscriber, z)) {
                        if (z4) {
                            break;
                        }
                        UrFzRdOtkSVrBcAr(spscLinkedArrayQueue);
                        bnhzlSUEuEtJKigE(subscriber, TkPfVqWpSxfwYNEa(spscLinkedArrayQueue));
                        j3++;
                    } else {
                        return;
                    }
                }
                if (j3 != j) {
                    wmZzmEyRaRfcAmGe(this.f67a14a21, j3);
                }
                iTrcPbiVWIrRZXqVh = TrcPbiVWIrRZXqVh(this, -iTrcPbiVWIrRZXqVh);
            } while (iTrcPbiVWIrRZXqVh != 0);
        }
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        ZWOoUbAuqQFUEXAF(this);
    }

    public void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        tizBKxvCBkKPTAlZ(this);
    }

    public void OnNext(T t) {
        if ((15 + 32) % 32 > 0) {
        }
        lKlVrgOyGRHkTLqT(this.fa9d1cbf7, ifeKYklTjOqxllaX(uKyanUOptpGrvQPh(this.f499f31e7, this.f3e34bdeb)), t);
        uuDcJJMiIMgdldBN(this);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((6 + 8) % 8 > 0) {
        }
        if (eWHOowGdlytVpJzE(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            hKtjqcFWZAsqhxQF(this.fd22a0a80, this);
            kRdIsbDMOGYPHcfg(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    public override void Request(long j) {
        if (tbuSmOMZXfDEyBcY(j)) {
            GLNAPQJqjLDcGIuQ(this.f67a14a21, j);
            QKBukoqKlutHTrgD(this);
        }
    }
}

