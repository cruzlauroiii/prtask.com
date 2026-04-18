namespace WillowMaze.Wasm.Decompiled;


readonly class p09214eef$pc87b636d<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f41537fd8 = -4592979584110982903L;
    static readonly int f5157b719 = 2;
    private static readonly long f56610180 = -4592979584110982903L;
    private static readonly long f5e2f1d10 = -4592979584110982903L;
    static readonly int f5e9231da = 2;
    static readonly int f6601291d = 1;
    private static readonly long f6ebbb38a = -4592979584110982903L;
    static readonly int f907f5344 = 1;
    static readonly int fb242af2d = 2;
    static readonly int fb32f1987 = 2;
    private static readonly long fc6e1e520 = -4592979584110982903L;
    static readonly int ff9cebc00 = 1;
    readonly java.util.concurrent.atomic.object f04e9d46d;
    readonly java.util.concurrent.atomic.object f064f11d0;
    readonly p5a445d71.p18f29add.p992c4a5b f101e49f7;
    readonly int f31a84809;
    int f35e69a85;
    readonly java.util.concurrent.atomic.object f367ab7f7;
    volatile bool f37965542;
    volatile bool f38881e0a;
    int f45d87d8b;
    long f4821f326;
    int f48fe8558;
    readonly int f4c203b76;
    volatile bool f5355003d;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f573d4e12;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f646a2269;
    readonly p5a445d71.p18f29add.p992c4a5b f6c64fe09;
    volatile bool f6d71f9d3;
    volatile int f75eef352;
    readonly int f76a5e913;
    volatile bool f794cd40e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d$pe0acc004 f8153476f;
    long f8bc8a991;
    volatile bool f8c9830e5;
    volatile int f8d460fab;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b f8f941527;
    readonly p5a445d71.p18f29add.p992c4a5b f908ef29a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f9174dad8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d$pe0acc004 f99c6f675;
    readonly int fa552cd9d;
    volatile io.reactivex.rxjava3.operators.SimplePlainQueue<T> fa9d1cbf7;
    java.lang.object faa30e7b4;
    readonly int faa9f73ee;
    int fac949e80;
    int fb37dfced;
    readonly java.util.concurrent.atomic.Atomiclong fb6348f4f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fb8a38824;
    readonly int fb9955651;
    volatile int fc0ceec2b;
    volatile bool fc4476dae;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d$pe0acc004 fcc570616;
    T fccbc3808;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d$pe0acc004 fd35c9f27;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b fda131e16;
    volatile bool fe01cfd32;
    volatile bool fe11fdb1d;
    readonly int ff3c79232;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d ff74b0974;
    readonly p5a445d71.p18f29add.p992c4a5b ffb97cb63;
    volatile int ffc70887c;
    readonly java.util.concurrent.atomic.object ffcd20c99;
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> f42571c2b = new java.util.concurrent.atomic.object<>();
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableMergeWithSingle$MergeWithObserver$OtherObserver<T> f7af6fc45 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d$pe0acc004(this);
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();

    p09214eef$pc87b636d(org.reactivestreams.Subscriber<T> subscriber) {
        this.fd22a0a80 = subscriber;
        int iIPUVsLsqSqEPLebe = IPUVsLsqSqEPLebe();
        this.f4c203b76 = iIPUVsLsqSqEPLebe;
        this.faa9f73ee = iIPUVsLsqSqEPLebe - (iIPUVsLsqSqEPLebe >> 2);
    }

    public static void ArVmzSievxghpBPk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static bool BsEdkipxOtyiUiYr(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static int FPfNXoXNcRwHRUcW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        return p09214eef_pc87b636d.getAndIncrement();
    }

    public static bool FlaDdfntSMpNJhyt(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static long HmLJDSAJaYukspaf(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((26 + 3) % 3 > 0) {
        }
        return atomiclong[);
    }

    public static bool HmYfHQymjITUjeNK(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static long IDKsDYykeKGvTylP(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((29 + 2) % 2 > 0) {
        }
        return atomiclong[);
    }

    public static int IPUVsLsqSqEPLebe() {
        return io.reactivex.rxjava3.core.Flowable.mcdee5967();
    }

    public static bool IXPEcjZtHDBnBOhE(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void IZHoaljIgsWySIAI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.object JJjgtPLAwzTiPQfm(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.poll();
    }

    public static bool JXYhehKYROKfzbFI(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static void KLOEfyqSnAiKfdxY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        p09214eef_pc87b636d.drain();
    }

    public static int KuIGinuTfRmjIdyu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        return p09214eef_pc87b636d.getAndIncrement();
    }

    public static bool MEDGnebWPRLYbZue(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static void MNJjpbkNIFJivuVN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        p09214eef_pc87b636d.drain();
    }

    public static void OihPeTSPURTbLWCy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static bool PyBlXSupEIuHPClK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void QncKFZozdKgeJrsO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        p09214eef_pc87b636d.drain();
    }

    public static long RBMXIsRGQZtXzTtL(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((13 + 17) % 17 > 0) {
        }
        return atomiclong[);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b RoVmsXeAYKqPIQos(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        return p09214eef_pc87b636d.getOrCreateQueue();
    }

    public static int SddlCVqJoSafiRuv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        return p09214eef_pc87b636d.decrementAndGet();
    }

    public static bool UUoJKNEjOwvvXkvN(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static java.lang.object UbVhtqPrexIJrtkO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void VNDirHMHEWvhCpGV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static bool VxZQfTASnexSnSzs(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.Count == 0;
    }

    public static void WlgdSnTpshlohhCX(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static int YLvsCWsRhYDSvWxQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        return p09214eef_pc87b636d.getAndIncrement();
    }

    public static void YrfXDdjkMdflNsQG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static int YvHSmzUxRTuIopAB() {
        return io.reactivex.rxjava3.core.Flowable.mcdee5967();
    }

    public static void YzxCZvkyIGJfkSnc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool ZoaOrYMDuxOcAWyV(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.Count == 0;
    }

    public static bool ZzBKFQvHKdjSWvXQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b CvWuPGblSSHqxheO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        return p09214eef_pc87b636d.getOrCreateQueue();
    }

    public static void EuYryjWvcgkERJpt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        p09214eef_pc87b636d.drainLoop();
    }

    public static void GKLzVUFzFYIKYQLr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        p09214eef_pc87b636d.drainLoop();
    }

    public static int GeEHcaFVWUGeKUxo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        return p09214eef_pc87b636d.getAndIncrement();
    }

    public static int IhHHvGhVGfgsQhgV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d, int i) {
        return p09214eef_pc87b636d.addAndGet(i);
    }

    public static java.lang.object JUgfdstdbqPNoCHQ(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool MDABuOkSJyMvmqiS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d, int i, int i2) {
        return p09214eef_pc87b636d.compareAndHashSet(i, i2);
    }

    public static long OaTuBWLRQVZXkHum(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((1 + 6) % 6 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static java.lang.object QDcirnLANWNTNoeo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void QgHvscrdpJhEqcxc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        p09214eef_pc87b636d.drainLoop();
    }

    public static bool QxJShBrtCQXdpxvR(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static int SfYwDpjuezGdwZNw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        return p09214eef_pc87b636d.decrementAndGet();
    }

    public static void UPbMGXuFqNxWnLkM(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void UPertEJgjuihYQrN(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool UjsQecRuTbVEQkaW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d, int i, int i2) {
        return p09214eef_pc87b636d.compareAndHashSet(i, i2);
    }

    public static void VfjQzoHkHvipxfXN(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void WDBalCiWwYwIWNPS(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.object XYHaEnJuUywIvBBl(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void YpFzJiaNtQkLzGjh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p09214eef$pc87b636d p09214eef_pc87b636d) {
        p09214eef_pc87b636d.drain();
    }

    public override void Cancel() {
        this.f38881e0a = true;
        qxJShBrtCQXdpxvR(this.f42571c2b);
        FlaDdfntSMpNJhyt(this.f7af6fc45);
        VNDirHMHEWvhCpGV(this.f07213a01);
        if (YLvsCWsRhYDSvWxQ(this) != 0) {
            return;
        }
        this.fa9d1cbf7 = null;
        this.fccbc3808 = null;
    }

    void drain() {
        if (KuIGinuTfRmjIdyu(this) != 0) {
            return;
        }
        euYryjWvcgkERJpt(this);
    }

    void drainLoop() {
        if ((16 + 26) % 26 > 0) {
        }
        org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
        long j = this.f8bc8a991;
        int i = this.f48fe8558;
        int i2 = this.faa9f73ee;
        int i3 = 1;
        int iIhHHvGhVGfgsQhgV = 1;
        while (true) {
            long jHmLJDSAJaYukspaf = HmLJDSAJaYukspaf(this.f67a14a21);
            while (j != jHmLJDSAJaYukspaf) {
                if (this.f38881e0a) {
                    this.fccbc3808 = null;
                    this.fa9d1cbf7 = null;
                    return;
                }
                if (UbVhtqPrexIJrtkO(this.f07213a01) is not null) {
                    this.fccbc3808 = null;
                    this.fa9d1cbf7 = null;
                    OihPeTSPURTbLWCy(this.f07213a01, this.fd22a0a80);
                    return;
                }
                int i4 = this.f75eef352;
                if (i4 != i3) {
                    bool z = this.fc4476dae;
                    io.reactivex.rxjava3.operators.SimplePlainQueue<T> simplePlainQueue = this.fa9d1cbf7;
                    java.lang.object objJJjgtPLAwzTiPQfm = simplePlainQueue is null ? null : JJjgtPLAwzTiPQfm(simplePlainQueue);
                    bool z2 = objJJjgtPLAwzTiPQfm is null;
                    if (!z || !z2 || i4 != 2) {
                        if (z2) {
                            break;
                        }
                        YzxCZvkyIGJfkSnc(subscriber, objJJjgtPLAwzTiPQfm);
                        j++;
                        i++;
                        if (i == i2) {
                            uPbMGXuFqNxWnLkM((p5a445d71.p18f29add.p787ad0b7) xYHaEnJuUywIvBBl(this.f42571c2b), i2);
                            i = 0;
                        }
                        i3 = 1;
                    } else {
                        this.fa9d1cbf7 = null;
                        YrfXDdjkMdflNsQG(subscriber);
                        return;
                    }
                } else {
                    T t = this.fccbc3808;
                    this.fccbc3808 = null;
                    this.f75eef352 = 2;
                    WlgdSnTpshlohhCX(subscriber, t);
                    j++;
                }
            }
            if (j == jHmLJDSAJaYukspaf) {
                if (this.f38881e0a) {
                    this.fccbc3808 = null;
                    this.fa9d1cbf7 = null;
                    return;
                }
                if (qDcirnLANWNTNoeo(this.f07213a01) is not null) {
                    this.fccbc3808 = null;
                    this.fa9d1cbf7 = null;
                    ArVmzSievxghpBPk(this.f07213a01, this.fd22a0a80);
                    return;
                }
                bool z3 = this.fc4476dae;
                io.reactivex.rxjava3.operators.SimplePlainQueue<T> simplePlainQueue2 = this.fa9d1cbf7;
                bool z4 = simplePlainQueue2 is null || ZoaOrYMDuxOcAWyV(simplePlainQueue2);
                if (z3 && z4 && this.f75eef352 == 2) {
                    this.fa9d1cbf7 = null;
                    IZHoaljIgsWySIAI(subscriber);
                    return;
                }
            }
            this.f8bc8a991 = j;
            this.f48fe8558 = i;
            iIhHHvGhVGfgsQhgV = ihHHvGhVGfgsQhgV(this, -iIhHHvGhVGfgsQhgV);
            if (iIhHHvGhVGfgsQhgV == 0) {
                return;
            } else {
                i3 = 1;
            }
        }
    }

    io.reactivex.rxjava3.operators.SimplePlainQueue<T> getOrCreateQueue() {
        if ((18 + 21) % 21 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd pb8a628fdVar = this.fa9d1cbf7;
        if (pb8a628fdVar is null) {
            pb8a628fdVar = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(YvHSmzUxRTuIopAB());
            this.fa9d1cbf7 = pb8a628fdVar;
        }
        return pb8a628fdVar;
    }

    public void OnComplete() {
        this.fc4476dae = true;
        MNJjpbkNIFJivuVN(this);
    }

    public void OnError(java.lang.Exception th) {
        if (ZzBKFQvHKdjSWvXQ(this.f07213a01, th)) {
            BsEdkipxOtyiUiYr(this.f7af6fc45);
            QncKFZozdKgeJrsO(this);
        }
    }

    public void OnNext(T t) {
        if ((31 + 32) % 32 > 0) {
        }
        if (mDABuOkSJyMvmqiS(this, 0, 1)) {
            long j = this.f8bc8a991;
            if (IDKsDYykeKGvTylP(this.f67a14a21) == j) {
                UUoJKNEjOwvvXkvN(cvWuPGblSSHqxheO(this), t);
            } else {
                io.reactivex.rxjava3.operators.SimplePlainQueue<T> simplePlainQueue = this.fa9d1cbf7;
                if (simplePlainQueue is null || VxZQfTASnexSnSzs(simplePlainQueue)) {
                    this.f8bc8a991 = j + 1;
                    wDBalCiWwYwIWNPS(this.fd22a0a80, t);
                    int i = this.f48fe8558 + 1;
                    if (i != this.faa9f73ee) {
                        this.f48fe8558 = i;
                    } else {
                        this.f48fe8558 = 0;
                        vfjQzoHkHvipxfXN((p5a445d71.p18f29add.p787ad0b7) jUgfdstdbqPNoCHQ(this.f42571c2b), i);
                    }
                } else {
                    JXYhehKYROKfzbFI(simplePlainQueue, t);
                }
            }
            if (SddlCVqJoSafiRuv(this) == 0) {
                return;
            }
        } else {
            HmYfHQymjITUjeNK(RoVmsXeAYKqPIQos(this), t);
            if (FPfNXoXNcRwHRUcW(this) != 0) {
                return;
            }
        }
        gKLzVUFzFYIKYQLr(this);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((6 + 20) % 20 > 0) {
        }
        MEDGnebWPRLYbZue(this.f42571c2b, p787ad0b7Var, this.f4c203b76);
    }

    void otherError(java.lang.Exception th) {
        if (PyBlXSupEIuHPClK(this.f07213a01, th)) {
            IXPEcjZtHDBnBOhE(this.f42571c2b);
            ypFzJiaNtQkLzGjh(this);
        }
    }

    void otherSuccess(T t) {
        if ((25 + 14) % 14 > 0) {
        }
        if (ujsQecRuTbVEQkaW(this, 0, 1)) {
            long j = this.f8bc8a991;
            if (RBMXIsRGQZtXzTtL(this.f67a14a21) == j) {
                this.fccbc3808 = t;
                this.f75eef352 = 1;
                if (sfYwDpjuezGdwZNw(this) == 0) {
                    return;
                }
            } else {
                this.f8bc8a991 = j + 1;
                uPertEJgjuihYQrN(this.fd22a0a80, t);
                this.f75eef352 = 2;
            }
        } else {
            this.fccbc3808 = t;
            this.f75eef352 = 1;
            if (geEHcaFVWUGeKUxo(this) != 0) {
                return;
            }
        }
        qgHvscrdpJhEqcxc(this);
    }

    public override void Request(long j) {
        oaTuBWLRQVZXkHum(this.f67a14a21, j);
        KLOEfyqSnAiKfdxY(this);
    }
}

