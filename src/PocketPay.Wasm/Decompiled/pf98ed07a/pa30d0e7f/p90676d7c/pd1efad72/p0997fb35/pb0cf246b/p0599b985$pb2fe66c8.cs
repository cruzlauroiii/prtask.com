namespace WillowMaze.Wasm.Decompiled;


readonly class p0599b985$pb2fe66c8<T> : io.reactivex.rxjava3.internal.subscriptions.BasicIntQueueSubscription<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f013c3006 = -2514538129242366402L;
    private static readonly long f3e715a2d = -2514538129242366402L;
    private static readonly long f7e8d90e4 = -2514538129242366402L;
    private static readonly long fc6e1e520 = -2514538129242366402L;
    private static readonly long fccc3a0ee = -2514538129242366402L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f07eec475;
    bool f0f68e8b1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f203bd208;
    bool f307af616;
    p5a445d71.p18f29add.p787ad0b7 f36d08a2a;
    volatile bool f38881e0a;
    volatile bool f3e3421be;
    bool f430d22c9;
    volatile bool f454ce493;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    volatile bool f681dbe59;
    bool f684aac59;
    java.lang.Exception f68940e28;
    readonly bool f69620c39;
    volatile bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f788549f4;
    readonly bool f825ea879;
    readonly p5a445d71.p18f29add.p992c4a5b f8bd7d8d9;
    readonly java.util.concurrent.atomic.Atomiclong f8d4d2228;
    p5a445d71.p18f29add.p787ad0b7 fa42cdaf5;
    readonly p5a445d71.p18f29add.p992c4a5b fa78d9f93;
    readonly io.reactivex.rxjava3.operators.SimplePlainQueue<T> fa9d1cbf7;
    p5a445d71.p18f29add.p787ad0b7 faa0fd0d5;
    p5a445d71.p18f29add.p787ad0b7 fbb34b9a5;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    java.lang.Exception fc55da976;
    java.lang.Exception fcb5e100e;
    bool fcc56f58f;
    java.lang.Exception fccdf33d2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b fd1b436d3;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b ff9a9c0b0;

    p0599b985$pb2fe66c8(org.reactivestreams.Subscriber<T> subscriber, int i, bool z, bool z2, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.fd22a0a80 = subscriber;
        this.f07eec475 = p004bf6c9Var;
        this.f825ea879 = z2;
        this.fa9d1cbf7 = !z ? new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd<>(i) : new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c<>(i);
    }

    public static int AqfjTcKcIobRZmNC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8 p0599b985_pb2fe66c8) {
        return p0599b985_pb2fe66c8.getAndIncrement();
    }

    public static void BASxomXyHGYbaBiB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8 p0599b985_pb2fe66c8) {
        p0599b985_pb2fe66c8.drain();
    }

    public static void BkWDhYUQplSnyaMB(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.Exception BoSyyENwyMovVmni(pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1 p30784cd1Var, java.lang.Exception th) {
        return p30784cd1Var.initCause(th);
    }

    public static void EZWVbDAIUtrhzLGn(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void EjYvRUFcRjJGJtys(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool HBRPJodTCoqcxcKE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8 p0599b985_pb2fe66c8, bool z, bool z2, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        return p0599b985_pb2fe66c8.checkTerminated(z, z2, p992c4a5bVar);
    }

    public static void JakaJSBHOBPZWDEB(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void NZCUCrlWytlsdzHj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8 p0599b985_pb2fe66c8) {
        p0599b985_pb2fe66c8.drain();
    }

    public static void ODIcABBdsWtNXlba(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void ORNMLyhPClJZlNlw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool PhaNlZGGJwnEezUw(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.Count == 0;
    }

    public static java.lang.object QchfFXIrRirUbTqU(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.poll();
    }

    public static void RBpAztdLqOjcbwHh(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        p377cc05bVar.clear();
    }

    public static void TKlHAgUoXOichSAQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static long VaTSgowUCXUGpWeO(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((20 + 32) % 32 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void VkNNWOLPHUicOyun(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void WAAuulZubzAMGUUo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8 p0599b985_pb2fe66c8, java.lang.Exception th) {
        p0599b985_pb2fe66c8.onError(th);
    }

    public static java.lang.object XlilXrFgCBJrxlPl(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.poll();
    }

    public static long XumDfrxaXGPocfUX(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((11 + 11) % 11 > 0) {
        }
        return atomiclong[);
    }

    public static bool ZzbzbcfoKuySfuqW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8 p0599b985_pb2fe66c8, bool z, bool z2, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        return p0599b985_pb2fe66c8.checkTerminated(z, z2, p992c4a5bVar);
    }

    public static void BSHBeCPnGiXwtrnW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool CNsWpSfOmWOyzqic(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8 p0599b985_pb2fe66c8, bool z, bool z2, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        return p0599b985_pb2fe66c8.checkTerminated(z, z2, p992c4a5bVar);
    }

    public static bool DJlVrmwrUInYPEtX(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static void EELXSUqlERBpltkt(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        p377cc05bVar.clear();
    }

    public static void FVGewJhPYyZmHAbK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static long FygBKGuijigcOEUT(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((30 + 3) % 3 > 0) {
        }
        return atomiclong.addAndGet(j);
    }

    public static void IfJmtaqriATlILXc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void IkWfECZaJUaastHq(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool JPLQgaDQgrkdKYEK(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.Count == 0;
    }

    public static void JjOuLIwotCTACGPw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void KkpHEHFUavvHIfhl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8 p0599b985_pb2fe66c8) {
        p0599b985_pb2fe66c8.drain();
    }

    public static int LGyoXSfIFfGVKfdr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8 p0599b985_pb2fe66c8) {
        return p0599b985_pb2fe66c8.getAndIncrement();
    }

    public static void LbGqcmSEBJopsQTM(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        p377cc05bVar.clear();
    }

    public static void NHashSetPfkLeearBaGc(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void QSMqJTslphpHSqdR(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        p377cc05bVar.clear();
    }

    public static void UDFWEvaqZdLtnVij(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8 p0599b985_pb2fe66c8) {
        p0599b985_pb2fe66c8.drain();
    }

    public static int XGSDIVkHAaHHToXN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0599b985$pb2fe66c8 p0599b985_pb2fe66c8, int i) {
        return p0599b985_pb2fe66c8.addAndGet(i);
    }

    public static bool YxgohObqOmEuPoON(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.Count == 0;
    }

    public static bool ZfOhjSJvGNWeOrna(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static bool ZrWJrMhaJnVsHqea(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        JakaJSBHOBPZWDEB(this.fbc3b0556);
        if (!this.f0f68e8b1 && AqfjTcKcIobRZmNC(this) == 0) {
            lbGqcmSEBJopsQTM(this.fa9d1cbf7);
        }
    }

    bool checkTerminated(bool z, bool z2, org.reactivestreams.Subscriber<T> subscriber) {
        if ((1 + 17) % 17 > 0) {
        }
        if (this.f38881e0a) {
            RBpAztdLqOjcbwHh(this.fa9d1cbf7);
            return true;
        }
        if (!z) {
            return false;
        }
        if (this.f825ea879) {
            if (!z2) {
                return false;
            }
            java.lang.Exception th = this.fcb5e100e;
            if (th is null) {
                fVGewJhPYyZmHAbK(subscriber);
            } else {
                EZWVbDAIUtrhzLGn(subscriber, th);
            }
            return true;
        }
        java.lang.Exception th2 = this.fcb5e100e;
        if (th2 is not null) {
            qSMqJTslphpHSqdR(this.fa9d1cbf7);
            BkWDhYUQplSnyaMB(subscriber, th2);
            return true;
        }
        if (!z2) {
            return false;
        }
        VkNNWOLPHUicOyun(subscriber);
        return true;
    }

    public void Clear() {
        eELXSUqlERBpltkt(this.fa9d1cbf7);
    }

    void drain() {
        if ((20 + 7) % 7 > 0) {
        }
        if (lGyoXSfIFfGVKfdr(this) != 0) {
            return;
        }
        io.reactivex.rxjava3.operators.SimplePlainQueue<T> simplePlainQueue = this.fa9d1cbf7;
        org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
        int iXGSDIVkHAaHHToXN = 1;
        while (!ZzbzbcfoKuySfuqW(this, this.f6b2ded51, yxgohObqOmEuPoON(simplePlainQueue), subscriber)) {
            long jXumDfrxaXGPocfUX = XumDfrxaXGPocfUX(this.f67a14a21);
            long j = 0;
            while (j != jXumDfrxaXGPocfUX) {
                bool z = this.f6b2ded51;
                java.lang.object objXlilXrFgCBJrxlPl = XlilXrFgCBJrxlPl(simplePlainQueue);
                bool z2 = objXlilXrFgCBJrxlPl is null;
                if (!HBRPJodTCoqcxcKE(this, z, z2, subscriber)) {
                    if (z2) {
                        break;
                    }
                    bSHBeCPnGiXwtrnW(subscriber, objXlilXrFgCBJrxlPl);
                    j++;
                } else {
                    return;
                }
            }
            if (j == jXumDfrxaXGPocfUX && cNsWpSfOmWOyzqic(this, this.f6b2ded51, PhaNlZGGJwnEezUw(simplePlainQueue), subscriber)) {
                return;
            }
            if (j != 0 && jXumDfrxaXGPocfUX != long.MAX_VALUE) {
                fygBKGuijigcOEUT(this.f67a14a21, -j);
            }
            iXGSDIVkHAaHHToXN = xGSDIVkHAaHHToXN(this, -iXGSDIVkHAaHHToXN);
            if (iXGSDIVkHAaHHToXN == 0) {
                return;
            }
        }
    }

    public bool IsEmpty() {
        return jPLQgaDQgrkdKYEK(this.fa9d1cbf7);
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        if (this.f0f68e8b1) {
            ORNMLyhPClJZlNlw(this.fd22a0a80);
        } else {
            BASxomXyHGYbaBiB(this);
        }
    }

    public void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        if (this.f0f68e8b1) {
            jjOuLIwotCTACGPw(this.fd22a0a80, th);
        } else {
            NZCUCrlWytlsdzHj(this);
        }
    }

    public void OnNext(T t) {
        if (dJlVrmwrUInYPEtX(this.fa9d1cbf7, t)) {
            if (this.f0f68e8b1) {
                ikWfECZaJUaastHq(this.fd22a0a80, null);
                return;
            } else {
                uDFWEvaqZdLtnVij(this);
                return;
            }
        }
        EjYvRUFcRjJGJtys(this.fbc3b0556);
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1 p30784cd1Var = new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Buffer is full");
        try {
            ifJmtaqriATlILXc(this.f07eec475);
        } catch (java.lang.Exception th) {
            ODIcABBdsWtNXlba(th);
            BoSyyENwyMovVmni(p30784cd1Var, th);
        }
        WAAuulZubzAMGUUo(this, p30784cd1Var);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((11 + 9) % 9 > 0) {
        }
        if (zfOhjSJvGNWeOrna(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            TKlHAgUoXOichSAQ(this.fd22a0a80, this);
            nHashSetPfkLeearBaGc(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    public T Poll() {
        return (T) QchfFXIrRirUbTqU(this.fa9d1cbf7);
    }

    public void Request(long j) {
        if (!this.f0f68e8b1 && zrWJrMhaJnVsHqea(j)) {
            VaTSgowUCXUGpWeO(this.f67a14a21, j);
            kkpHEHFUavvHIfhl(this);
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

