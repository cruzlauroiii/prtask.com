namespace WillowMaze.Wasm.Decompiled;


readonly class p53cc367f$pf6897dd1<T, R> : io.reactivex.rxjava3.internal.operators.mixed.ConcatDictionaryXMainSubscriber<T> : p5a445d71.p18f29add.p787ad0b7 {
    static readonly int f5c7e182c = 0;
    static readonly int f62c4231d = 2;
    static readonly int f7c7006ca = 1;
    static readonly int fba58ebec = 1;
    private static readonly long fc6e1e520 = -9140123220065488293L;
    static readonly int fcdfbbbd2 = 2;
    static readonly int fceaaf465 = 1;
    static readonly int fd1fdf337 = 0;
    static readonly int fd37c24c4 = 2;
    static readonly int fd8d912f4 = 0;
    private static readonly long fdcb4a0fd = -9140123220065488293L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1$p2810c237 f19faaca7;
    readonly p5a445d71.p18f29add.p992c4a5b f35662a4f;
    volatile int f3792c603;
    R f447b7147;
    readonly java.util.concurrent.atomic.Atomiclong f48db9b86;
    int f48fe8558;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly java.util.concurrent.atomic.Atomiclong f613bce91;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21;
    readonly java.util.concurrent.atomic.Atomiclong f6eae6f43;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1$p2810c237 f72589bb5;
    int f82047a77;
    long f8bc8a991;
    java.lang.object f92b1f6ee;
    volatile int f9ed39e2e;
    java.lang.object fa97927b6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb35ba026;
    long fb566f18b;
    long fbe57c354;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    int fe8409385;
    readonly io.reactivex.rxjava3.internal.operators.mixed.FlowableConcatDictionaryMaybe$ConcatDictionaryMaybeSubscriber$ConcatDictionaryMaybeObserver<R> fea97586b;
    long ff4aeaec7;

    p53cc367f$pf6897dd1(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, int i, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var) {
        super(i, pcd04add9Var);
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
        this.f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
        this.fea97586b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1$p2810c237(this);
    }

    public static bool ApiFBnalUNxICxAv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void BYMcKUAjCUnquWZO(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void CdSHYinrJRsfcQcr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.object ExVQSfTCYbPxrxpm(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void GULIMYGLiDKywWAc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static java.lang.object HDmAGXBQaNoqUBOq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void HLcWUvbROswuzymH(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static bool KWaqjSyoQGZAkBgI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void PkvBQgjZZGXeXQWf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void QyfTREFnGqhtjyWZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void SMoYRZoEDTfnteLd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1$p2810c237 p53cc367f_pf6897dd1_p2810c237) {
        p53cc367f_pf6897dd1_p2810c237.dispose();
    }

    public static int UojVUkIYcgSlMkmv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1 p53cc367f_pf6897dd1, int i) {
        return p53cc367f_pf6897dd1.addAndGet(i);
    }

    public static bool VsEdBuhYTVkEcVOt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void WnFnieXEOHWqgFzP(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void YJdHvgVieXkUsIWM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1 p53cc367f_pf6897dd1) {
        p53cc367f_pf6897dd1.drain();
    }

    public static long AfqXhPVoGhAJABai(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((19 + 19) % 19 > 0) {
        }
        return atomiclong[);
    }

    public static void BIZytPIwUYdpsvTP(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void BgWnbnWzlMXNSSnu(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void CZcvtixYHwFvvygP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1 p53cc367f_pf6897dd1) {
        p53cc367f_pf6897dd1.drain();
    }

    public static void DOxRlYPEiwVQzMGh(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void EpcLtLBxFKzsrTYb(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void GmbXfkECwBnbKFxX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void HidiImekrVnXqBYo(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void JIYAdkQXcJioVLhK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1 p53cc367f_pf6897dd1) {
        p53cc367f_pf6897dd1.stop();
    }

    public static long LaKBAcHGRGNJTtTh(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((23 + 24) % 24 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void MwtNcWCGlVNKxwlb(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void NFttbqMoftPEebAL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1 p53cc367f_pf6897dd1) {
        p53cc367f_pf6897dd1.drain();
    }

    public static java.lang.object NsEJIDWkEHOLUyNV(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void PVuNoVANYsFKmSrV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void WjNlfJmTjZXbuPCG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1 p53cc367f_pf6897dd1) {
        p53cc367f_pf6897dd1.drain();
    }

    public static void WtUruhZqNAOVyRRn(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object XoHlqbXstYRbqbHK(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static int ZeGzEvLYPMOuzBHR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p53cc367f$pf6897dd1 p53cc367f_pf6897dd1) {
        return p53cc367f_pf6897dd1.getAndIncrement();
    }

    public override void Cancel() {
        jIYAdkQXcJioVLhK(this);
    }

    void clearValue() {
        this.f447b7147 = null;
    }

    void disposeInner() {
        SMoYRZoEDTfnteLd(this.fea97586b);
    }

    void drain() {
        if ((26 + 17) % 17 > 0) {
        }
        if (zeGzEvLYPMOuzBHR(this) == 0) {
            org.reactivestreams.Subscriber<R> subscriber = this.fd22a0a80;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var = this.f560019e4;
            pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var = this.fa9d1cbf7;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar = this.f07213a01;
            java.util.concurrent.atomic.Atomiclong atomiclong = this.f67a14a21;
            int i = this.f4c203b76 - (this.f4c203b76 >> 1);
            bool z = this.fbf1a3fd2;
            int iUojVUkIYcgSlMkmv = 1;
            while (true) {
                if (this.f38881e0a) {
                    bgWnbnWzlMXNSSnu(pe1601823Var);
                    this.f447b7147 = null;
                } else {
                    int i2 = this.f9ed39e2e;
                    if (HDmAGXBQaNoqUBOq(p36a52e5dVar) is not null && (pcd04add9Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fe35884a2 || (pcd04add9Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fa52f733b && i2 == 0))) {
                        break;
                    }
                    if (i2 == 0) {
                        bool z2 = this.f6b2ded51;
                        try {
                            java.lang.object objNsEJIDWkEHOLUyNV = nsEJIDWkEHOLUyNV(pe1601823Var);
                            bool z3 = objNsEJIDWkEHOLUyNV is null;
                            if (z2 && z3) {
                                pVuNoVANYsFKmSrV(p36a52e5dVar, subscriber);
                                return;
                            }
                            if (!z3) {
                                if (!z) {
                                    int i3 = this.f48fe8558 + 1;
                                    if (i3 != i) {
                                        this.f48fe8558 = i3;
                                    } else {
                                        this.f48fe8558 = 0;
                                        wtUruhZqNAOVyRRn(this.fbc3b0556, i);
                                    }
                                }
                                try {
                                    io.reactivex.rxjava3.core.MaybeSource maybeSource = (io.reactivex.rxjava3.core.MaybeSource) xoHlqbXstYRbqbHK(ExVQSfTCYbPxrxpm(this.f4b9f83e1, objNsEJIDWkEHOLUyNV), "The mapper returned a null MaybeSource");
                                    this.f9ed39e2e = 1;
                                    dOxRlYPEiwVQzMGh(maybeSource, this.fea97586b);
                                } catch (java.lang.Exception th) {
                                    WnFnieXEOHWqgFzP(th);
                                    hidiImekrVnXqBYo(this.fbc3b0556);
                                    mwtNcWCGlVNKxwlb(pe1601823Var);
                                    KWaqjSyoQGZAkBgI(p36a52e5dVar, th);
                                    QyfTREFnGqhtjyWZ(p36a52e5dVar, subscriber);
                                    return;
                                }
                            }
                        } catch (java.lang.Exception th2) {
                            BYMcKUAjCUnquWZO(th2);
                            epcLtLBxFKzsrTYb(this.fbc3b0556);
                            VsEdBuhYTVkEcVOt(p36a52e5dVar, th2);
                            gmbXfkECwBnbKFxX(p36a52e5dVar, subscriber);
                            return;
                        }
                    } else if (i2 == 2) {
                        long j = this.f8bc8a991;
                        if (j != afqXhPVoGhAJABai(atomiclong)) {
                            R r = this.f447b7147;
                            this.f447b7147 = null;
                            CdSHYinrJRsfcQcr(subscriber, r);
                            this.f8bc8a991 = j + 1;
                            this.f9ed39e2e = 0;
                        }
                    }
                }
                iUojVUkIYcgSlMkmv = UojVUkIYcgSlMkmv(this, -iUojVUkIYcgSlMkmv);
                if (iUojVUkIYcgSlMkmv == 0) {
                    return;
                }
            }
            HLcWUvbROswuzymH(pe1601823Var);
            this.f447b7147 = null;
            PkvBQgjZZGXeXQWf(p36a52e5dVar, subscriber);
        }
    }

    void innerComplete() {
        this.f9ed39e2e = 0;
        YJdHvgVieXkUsIWM(this);
    }

    void innerError(java.lang.Exception th) {
        if (ApiFBnalUNxICxAv(this.f07213a01, th)) {
            if (this.f560019e4 != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fb1a326c0) {
                bIZytPIwUYdpsvTP(this.fbc3b0556);
            }
            this.f9ed39e2e = 0;
            wjNlfJmTjZXbuPCG(this);
        }
    }

    void innerSuccess(R r) {
        this.f447b7147 = r;
        this.f9ed39e2e = 2;
        cZcvtixYHwFvvygP(this);
    }

    void onSubscribeDownstream() {
        GULIMYGLiDKywWAc(this.fd22a0a80, this);
    }

    public override void Request(long j) {
        laKBAcHGRGNJTtTh(this.f67a14a21, j);
        nFttbqMoftPEebAL(this);
    }
}

