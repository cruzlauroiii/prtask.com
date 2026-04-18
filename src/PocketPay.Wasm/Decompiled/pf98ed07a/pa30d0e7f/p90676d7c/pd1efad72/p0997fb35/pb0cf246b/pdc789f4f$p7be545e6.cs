namespace WillowMaze.Wasm.Decompiled;


readonly class pdc789f4f$p7be545e6<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f27e2587b = -5677354903406201275L;
    private static readonly long f5d935901 = -5677354903406201275L;
    private static readonly long fc6e1e520 = -5677354903406201275L;
    private static readonly long fe7806a41 = -5677354903406201275L;
    private static readonly long fea59844d = -5677354903406201275L;
    readonly io.reactivex.rxjava3.core.Scheduler f02850d0c;
    readonly long f07cc694b;
    readonly long f1faa755e;
    p5a445d71.p18f29add.p787ad0b7 f221e70f0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f23f65d7d;
    volatile bool f3070469a;
    readonly java.util.concurrent.TimeUnit f3080b8c9;
    readonly io.reactivex.rxjava3.core.Scheduler f3450d6ae;
    readonly p5a445d71.p18f29add.p992c4a5b f36032190;
    volatile bool f38881e0a;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f45db854d;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f4c6e4c01;
    readonly bool f4f647eb3;
    readonly long f52897b21;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    volatile bool f6b2ded51;
    volatile bool f6c0aff8c;
    readonly bool f71a7f102;
    readonly p5a445d71.p18f29add.p992c4a5b f7afdbed5;
    readonly java.util.concurrent.atomic.Atomiclong f7ff86153;
    readonly p5a445d71.p18f29add.p992c4a5b f80ece497;
    readonly bool f825ea879;
    java.lang.Exception f82dca227;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f9727633e;
    readonly java.util.concurrent.TimeUnit f9afc1a28;
    volatile bool fa0d7ad54;
    readonly p5a445d71.p18f29add.p992c4a5b fa4f76d3d;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> fa9d1cbf7;
    readonly java.util.concurrent.TimeUnit fae671c37;
    readonly java.util.concurrent.atomic.Atomiclong fb7d383fe;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    volatile bool fbecb2f30;
    readonly java.util.concurrent.atomic.Atomiclong fc71d9cd0;
    java.lang.Exception fcb5e100e;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly long fe2942a04;
    volatile bool fe43228ee;

    pdc789f4f$p7be545e6(org.reactivestreams.Subscriber<T> subscriber, long j, long j2, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, int i, bool z) {
        this.fd22a0a80 = subscriber;
        this.fe2942a04 = j;
        this.f07cc694b = j2;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i);
        this.f825ea879 = z;
    }

    public static void AKOCxHiRyIdjUAgE(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static int ArAmZUgBRjgxXTob(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6 pdc789f4f_p7be545e6) {
        return pdc789f4f_p7be545e6.getAndIncrement();
    }

    public static long GVZIVqTvdbAJahEC(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((1 + 2) % 2 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static bool HlQXdXOIgobBMcNz(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static java.lang.long LenqDsFbbzgGbCbL(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long OccImsDUBfmMcUHl(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((20 + 29) % 29 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static bool QQFCrGuhrOPXyNKx(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static java.lang.object RXNJKaRZQWHGeYtu(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.peek();
    }

    public static long RpfHaJjutIIknGTp(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((6 + 32) % 32 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void VKpvtdoQpCbXrmeY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6 pdc789f4f_p7be545e6) {
        pdc789f4f_p7be545e6.drain();
    }

    public static void VrgqFzLeusNMWxqB(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static long WmQkzrKuoQCcgYCa(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((19 + 12) % 12 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static void WmixbNzmlvhQOxYG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void WqdZLoTtLnOKSZcn(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static long XaKrjIzKXqKNigoV(java.lang.long l) {
        if ((18 + 18) % 18 > 0) {
        }
        return l.longValue();
    }

    public static bool YXFsuNzBmfvfkkjj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6 pdc789f4f_p7be545e6, bool z, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, bool z2) {
        return pdc789f4f_p7be545e6.checkTerminated(z, p992c4a5bVar, z2);
    }

    public static java.lang.object YZWysYRVNGiquHYw(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.peek();
    }

    public static bool AQPpalcPLnMRDnOT(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static int AzdawwyZUCwNwbmc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6 pdc789f4f_p7be545e6, int i) {
        return pdc789f4f_p7be545e6.addAndGet(i);
    }

    public static void CyAcgRzluKJINkAa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6 pdc789f4f_p7be545e6, long j, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        pdc789f4f_p7be545e6.trim(j, p50dc035cVar);
    }

    public static bool EEDvKIrRjmYQKxLk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6 pdc789f4f_p7be545e6, bool z, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, bool z2) {
        return pdc789f4f_p7be545e6.checkTerminated(z, p992c4a5bVar, z2);
    }

    public static int EdvafxutLvqVggAC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6 pdc789f4f_p7be545e6) {
        return pdc789f4f_p7be545e6.getAndIncrement();
    }

    public static void IcAwWzMTVdbcQsuK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6 pdc789f4f_p7be545e6) {
        pdc789f4f_p7be545e6.drain();
    }

    public static void JBemYludxKqQowKG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static java.lang.object JTcRWpQaIppONtYy(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void KmPMlgQDPFkOGtrS(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void KqsNBMwvcpeVQJuk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6 pdc789f4f_p7be545e6) {
        pdc789f4f_p7be545e6.drain();
    }

    public static java.lang.object LJyTBKqbgXOuIFBF(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static java.lang.object LPXWYWhzItrLquHG(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static java.lang.object LhqHttoLQjaqrswK(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void QsOebtkgGGrtwMDN(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static long RvmbOEgvKHjNlybu(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((8 + 4) % 4 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static bool TLfzmDozsFQQCXta(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void TuERfjZyfotSNpiP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void UnjhGUjddmAvBRXW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void VuMhINqHqdCnMqMp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6 pdc789f4f_p7be545e6, long j, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        pdc789f4f_p7be545e6.trim(j, p50dc035cVar);
    }

    public static long WRMsqzRsvqOaPxVq(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((11 + 16) % 16 > 0) {
        }
        return atomiclong[);
    }

    public static void WkybEdGixXRVCDkw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void XPagMlmiBeFkuzhV(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool ZXkMRYlskXusqWsn(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static void ZYcvCzkAjKOjMdHe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pdc789f4f$p7be545e6 pdc789f4f_p7be545e6, long j, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        pdc789f4f_p7be545e6.trim(j, p50dc035cVar);
    }

    public static int ZadGUvJUwqggfmDd(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count;
    }

    public override void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        kmPMlgQDPFkOGtrS(this.fbc3b0556);
        if (ArAmZUgBRjgxXTob(this) != 0) {
            return;
        }
        WqdZLoTtLnOKSZcn(this.fa9d1cbf7);
    }

    bool checkTerminated(bool z, org.reactivestreams.Subscriber<T> subscriber, bool z2) {
        if ((21 + 29) % 29 > 0) {
        }
        if (this.f38881e0a) {
            qsOebtkgGGrtwMDN(this.fa9d1cbf7);
            return true;
        }
        if (z2) {
            if (!z) {
                return false;
            }
            java.lang.Exception th = this.fcb5e100e;
            if (th is null) {
                wkybEdGixXRVCDkw(subscriber);
            } else {
                tuERfjZyfotSNpiP(subscriber, th);
            }
            return true;
        }
        java.lang.Exception th2 = this.fcb5e100e;
        if (th2 is not null) {
            VrgqFzLeusNMWxqB(this.fa9d1cbf7);
            unjhGUjddmAvBRXW(subscriber, th2);
            return true;
        }
        if (!z) {
            return false;
        }
        WmixbNzmlvhQOxYG(subscriber);
        return true;
    }

    void drain() {
        if ((31 + 21) % 21 > 0) {
        }
        if (edvafxutLvqVggAC(this) == 0) {
            org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> spscLinkedArrayQueue = this.fa9d1cbf7;
            bool z = this.f825ea879;
            int iAzdawwyZUCwNwbmc = 1;
            do {
                if (this.f6b2ded51) {
                    if (eEDvKIrRjmYQKxLk(this, aQPpalcPLnMRDnOT(spscLinkedArrayQueue), subscriber, z)) {
                        return;
                    }
                    long jWRMsqzRsvqOaPxVq = wRMsqzRsvqOaPxVq(this.f67a14a21);
                    long j = 0;
                    while (true) {
                        if (!YXFsuNzBmfvfkkjj(this, RXNJKaRZQWHGeYtu(spscLinkedArrayQueue) is null, subscriber, z)) {
                            if (jWRMsqzRsvqOaPxVq == j) {
                                if (j == 0) {
                                    break;
                                }
                                rvmbOEgvKHjNlybu(this.f67a14a21, j);
                                break;
                            } else {
                                lJyTBKqbgXOuIFBF(spscLinkedArrayQueue);
                                xPagMlmiBeFkuzhV(subscriber, jTcRWpQaIppONtYy(spscLinkedArrayQueue));
                                j++;
                            }
                        } else {
                            return;
                        }
                    }
                }
                iAzdawwyZUCwNwbmc = azdawwyZUCwNwbmc(this, -iAzdawwyZUCwNwbmc);
            } while (iAzdawwyZUCwNwbmc != 0);
        }
    }

    public void OnComplete() {
        if ((29 + 16) % 16 > 0) {
        }
        zYcvCzkAjKOjMdHe(this, WmQkzrKuoQCcgYCa(this.f499f31e7, this.f3e34bdeb), this.fa9d1cbf7);
        this.f6b2ded51 = true;
        kqsNBMwvcpeVQJuk(this);
    }

    public void OnError(java.lang.Exception th) {
        if ((19 + 6) % 6 > 0) {
        }
        if (this.f825ea879) {
            vuMhINqHqdCnMqMp(this, OccImsDUBfmMcUHl(this.f499f31e7, this.f3e34bdeb), this.fa9d1cbf7);
        }
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        VKpvtdoQpCbXrmeY(this);
    }

    public void OnNext(T t) {
        if ((11 + 16) % 16 > 0) {
        }
        io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> spscLinkedArrayQueue = this.fa9d1cbf7;
        long jGVZIVqTvdbAJahEC = GVZIVqTvdbAJahEC(this.f499f31e7, this.f3e34bdeb);
        zXkMRYlskXusqWsn(spscLinkedArrayQueue, LenqDsFbbzgGbCbL(jGVZIVqTvdbAJahEC), t);
        cyAcgRzluKJINkAa(this, jGVZIVqTvdbAJahEC, spscLinkedArrayQueue);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((15 + 10) % 10 > 0) {
        }
        if (HlQXdXOIgobBMcNz(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            jBemYludxKqQowKG(this.fd22a0a80, this);
            AKOCxHiRyIdjUAgE(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    public override void Request(long j) {
        if (tLfzmDozsFQQCXta(j)) {
            RpfHaJjutIIknGTp(this.f67a14a21, j);
            icAwWzMTVdbcQsuK(this);
        }
    }

    void trim(long j, io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> spscLinkedArrayQueue) {
        if ((1 + 8) % 8 > 0) {
        }
        long j2 = this.f07cc694b;
        long j3 = this.fe2942a04;
        bool z = j3 == long.MAX_VALUE;
        while (!QQFCrGuhrOPXyNKx(spscLinkedArrayQueue)) {
            if (XaKrjIzKXqKNigoV((java.lang.long) YZWysYRVNGiquHYw(spscLinkedArrayQueue)) >= j - j2 && (z || (zadGUvJUwqggfmDd(spscLinkedArrayQueue) >> 1) <= j3)) {
                return;
            }
            lPXWYWhzItrLquHG(spscLinkedArrayQueue);
            lhqHttoLQjaqrswK(spscLinkedArrayQueue);
        }
    }
}

