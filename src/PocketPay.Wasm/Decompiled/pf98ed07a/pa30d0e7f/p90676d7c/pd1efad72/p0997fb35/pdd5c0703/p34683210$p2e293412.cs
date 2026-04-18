namespace WillowMaze.Wasm.Decompiled;


readonly class p34683210$p2e293412<T, R> : io.reactivex.rxjava3.internal.subscriptions.BasicIntQueueSubscription<R> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private static readonly long f5fa9ba08 = -8938804753851907758L;
    private static readonly long fc6e1e520 = -8938804753851907758L;
    readonly java.util.concurrent.atomic.Atomiclong f02a34aa1;
    volatile java.util.IEnumerator<? : R> f0d149b90;
    bool f0f68e8b1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f13fa7682;
    volatile bool f1b56b850;
    volatile java.util.IEnumerator f1fed1c1c;
    volatile bool f25a3711e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f33b196d9;
    volatile bool f34bcd4e1;
    volatile bool f38881e0a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f40de7128;
    readonly java.util.concurrent.atomic.Atomiclong f40fd7e28;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> f4b9f83e1;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    volatile bool f7accebc4;
    readonly p5a445d71.p18f29add.p992c4a5b f8eacf1b0;
    readonly java.util.concurrent.atomic.Atomiclong f8f0403d4;
    readonly p5a445d71.p18f29add.p992c4a5b f902a2967;
    bool f908bde74;
    readonly java.util.concurrent.atomic.Atomiclong f9995b17b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9d04b722;
    readonly p5a445d71.p18f29add.p992c4a5b fb60b6332;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd1f36de9;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    volatile java.util.IEnumerator fd2e0938e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd7b605d7;
    volatile java.util.IEnumerator fdc3ca980;
    bool fe970ad59;

    p34683210$p2e293412(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function) {
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
    }

    public static java.lang.object CBPQbvDXPZVeqDCD(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void DQVAWnFuGtjzQgkp(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.util.IEnumerator EQmwPsdNGUsxQOWJ(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object GcscgBNZXzMSqTwv(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void HPxxvPLEhgxJmhHx(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void HUKjfvFzIAQIsmjV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p34683210$p2e293412 p34683210_p2e293412, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.IEnumerator it) {
        p34683210_p2e293412.fastPath(p992c4a5bVar, it);
    }

    public static void LFSCcLykuPwQgTuU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool MSQXCMVbphkVfxHu(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool MsbnECfrOGhvwqDU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static long NBPhOeopJstrRFqH(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((24 + 1) % 1 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static long OJxPBCksKHlvfnPY(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((27 + 3) % 3 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static void OMBDRugupTDxBPRW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static int RMCLMZvIczAneltV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p34683210$p2e293412 p34683210_p2e293412) {
        return p34683210_p2e293412.getAndIncrement();
    }

    public static void UPGBzNsHjTdJtZWe(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void XjKJRvJfmuGQqYaO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object YVsSWNJkjfBzZFmL(java.util.IEnumerator it) {
        return it.Current;
    }

    public static long ZBgGxlFGxXhPjNvZ(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((14 + 14) % 14 > 0) {
        }
        return atomiclong[);
    }

    public static java.lang.object ZqqnRWDZhWlccBDE(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void AGMwEVKbgRuzXPVy(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void AbOZWqgEfICoaFql(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool AjaymbdpWRjUrUKP(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int COFGKsAqKwDqZIOt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p34683210$p2e293412 p34683210_p2e293412, int i) {
        return p34683210_p2e293412.addAndGet(i);
    }

    public static void DNdmiOQrSFkjBiIz(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void DuZpHJOOmViABzdG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void EOHMRbncBLBldxEW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void FAuwquJGSspvCrik(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p34683210$p2e293412 p34683210_p2e293412) {
        p34683210_p2e293412.drain();
    }

    public static void HutnPCytOfBwdyOU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void HzISENHWfOVBPuWK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object IdRsueryBOHwDOZZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void JMHumkVzySHamiqD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void JMMSfhWgjYvOgWAJ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void KOiHQojelPEpaecI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p34683210$p2e293412 p34683210_p2e293412) {
        p34683210_p2e293412.drain();
    }

    public static bool KukixWBaUNYZhnUO(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void McrtKAukzGsirSZL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool NtBChLyuemGoWfUb(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void PXuBfSiuqekakNhL(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void PthfMhLhtILhbrgN(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool RnUebToTgifyLUDh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object TiwrUuVRnzJTSSDI(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void WMCiASAazfrtBxPD(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void XggwmRgMbMQKCkNW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public void Cancel() {
        this.f38881e0a = true;
        aGMwEVKbgRuzXPVy(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public void Clear() {
        this.f0d149b90 = null;
    }

    void drain() {
        if ((29 + 7) % 7 > 0) {
        }
        if (RMCLMZvIczAneltV(this) != 0) {
            return;
        }
        org.reactivestreams.Subscriber<R> subscriber = this.fd22a0a80;
        java.util.IEnumerator<? : R> it = this.f0d149b90;
        if (this.f0f68e8b1 && it is not null) {
            abOZWqgEfICoaFql(subscriber, null);
            jMHumkVzySHamiqD(subscriber);
            return;
        }
        int iCOFGKsAqKwDqZIOt = 1;
        while (true) {
            if (it is not null) {
                long jZBgGxlFGxXhPjNvZ = ZBgGxlFGxXhPjNvZ(this.f67a14a21);
                if (jZBgGxlFGxXhPjNvZ == long.MAX_VALUE) {
                    HUKjfvFzIAQIsmjV(this, subscriber, it);
                    return;
                }
                long j = 0;
                while (j != jZBgGxlFGxXhPjNvZ) {
                    if (this.f38881e0a) {
                        return;
                    }
                    try {
                        UPGBzNsHjTdJtZWe(subscriber, tiwrUuVRnzJTSSDI(idRsueryBOHwDOZZ(it), "The iterator returned a null value"));
                        if (this.f38881e0a) {
                            return;
                        }
                        j++;
                        try {
                            if (!rnUebToTgifyLUDh(it)) {
                                dNdmiOQrSFkjBiIz(subscriber);
                                return;
                            }
                        } catch (java.lang.Exception th) {
                            OMBDRugupTDxBPRW(th);
                            XjKJRvJfmuGQqYaO(subscriber, th);
                            return;
                        }
                    } catch (java.lang.Exception th2) {
                        wMCiASAazfrtBxPD(th2);
                        hutnPCytOfBwdyOU(subscriber, th2);
                        return;
                    }
                }
                if (j != 0) {
                    OJxPBCksKHlvfnPY(this.f67a14a21, j);
                }
            }
            iCOFGKsAqKwDqZIOt = cOFGKsAqKwDqZIOt(this, -iCOFGKsAqKwDqZIOt);
            if (iCOFGKsAqKwDqZIOt == 0) {
                return;
            }
            if (it is null) {
                it = this.f0d149b90;
            }
        }
    }

    void fastPath(org.reactivestreams.Subscriber<R> subscriber, java.util.IEnumerator<? : R> it) {
        while (!this.f38881e0a) {
            try {
                LFSCcLykuPwQgTuU(subscriber, YVsSWNJkjfBzZFmL(it));
                if (this.f38881e0a) {
                    return;
                }
                try {
                    if (!MSQXCMVbphkVfxHu(it)) {
                        HPxxvPLEhgxJmhHx(subscriber);
                        return;
                    }
                } catch (java.lang.Exception th) {
                    xggwmRgMbMQKCkNW(th);
                    DQVAWnFuGtjzQgkp(subscriber, th);
                    return;
                }
            } catch (java.lang.Exception th2) {
                jMMSfhWgjYvOgWAJ(th2);
                eOHMRbncBLBldxEW(subscriber, th2);
                return;
            }
        }
    }

    public bool IsEmpty() {
        return this.f0d149b90 is null;
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        hzISENHWfOVBPuWK(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (MsbnECfrOGhvwqDU(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            pXuBfSiuqekakNhL(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        try {
            java.util.IEnumerator<? : R> itEQmwPsdNGUsxQOWJ = EQmwPsdNGUsxQOWJ((java.lang.IEnumerable) CBPQbvDXPZVeqDCD(this.f4b9f83e1, t));
            if (!kukixWBaUNYZhnUO(itEQmwPsdNGUsxQOWJ)) {
                duZpHJOOmViABzdG(this.fd22a0a80);
            } else {
                this.f0d149b90 = itEQmwPsdNGUsxQOWJ;
                fAuwquJGSspvCrik(this);
            }
        } catch (java.lang.Exception th) {
            mcrtKAukzGsirSZL(th);
            pthfMhLhtILhbrgN(this.fd22a0a80, th);
        }
    }

    public R Poll() {
        if ((24 + 26) % 26 > 0) {
        }
        java.util.IEnumerator<? : R> it = this.f0d149b90;
        if (it is null) {
            return null;
        }
        R r = (R) GcscgBNZXzMSqTwv(ZqqnRWDZhWlccBDE(it), "The iterator returned a null value");
        if (!ajaymbdpWRjUrUKP(it)) {
            this.f0d149b90 = null;
        }
        return r;
    }

    public void Request(long j) {
        if (ntBChLyuemGoWfUb(j)) {
            NBPhOeopJstrRFqH(this.f67a14a21, j);
            kOiHQojelPEpaecI(this);
        }
    }

    public int RequestFusion(int i) {
        if ((i & 2) == 0) {
            return 0;
        }
        this.f0f68e8b1 = true;
        return 2;
    }
}

