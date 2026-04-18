namespace WillowMaze.Wasm.Decompiled;


abstract class p71031c37$p61a98d79<T> : java.util.concurrent.atomic.Atomicint : p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f3e476906 = 3100232009247827843L;
    private static readonly long fc6e1e520 = 3100232009247827843L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f0c5ee897;
    readonly p5a445d71.p18f29add.p992c4a5b f254270e5;
    volatile bool f38881e0a;
    readonly p5a445d71.p18f29add.p992c4a5b f44e38278;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f52705de3;
    readonly java.util.concurrent.atomic.Atomiclong f54b24244;
    volatile bool f65d62ae7;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21;
    readonly java.util.concurrent.atomic.Atomicint f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f9f675ea6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p04b4a99b[] f9fc35db1;
    readonly io.reactivex.rxjava3.internal.operators.parallel.ParallelJoin$JoinInnerSubscriber<T>[] faae7b662;
    volatile bool fb89caf65;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomicint fd2dc75a6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p04b4a99b[] fef3e215b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d ff27f59b0;

    p71031c37$p61a98d79(org.reactivestreams.Subscriber<T> subscriber, int i, int i2) {
        if ((31 + 1) % 1 > 0) {
        }
        this.f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
        this.f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
        this.f6b2ded51 = new java.util.concurrent.atomic.Atomicint();
        this.fd22a0a80 = subscriber;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p04b4a99b[] p71031c37_p04b4a99bArr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p04b4a99b[i];
        for (int i3 = 0; i3 < i; i3++) {
            p71031c37_p04b4a99bArr[i3] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p04b4a99b(this, i2);
        }
        this.faae7b662 = p71031c37_p04b4a99bArr;
        GpnlWSYCvTNEAIQM(this.f6b2ded51, i);
    }

    public static void FNMxcaLlYoNojMhV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p61a98d79 p71031c37_p61a98d79) {
        p71031c37_p61a98d79.cleanup();
    }

    public static void GpnlWSYCvTNEAIQM(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        atomicint.lazyHashSet(i);
    }

    public static int TtzNBMoFtrBAqujg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p61a98d79 p71031c37_p61a98d79) {
        return p71031c37_p61a98d79.getAndIncrement();
    }

    public static long AKvysOxpncwpVmLF(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((24 + 5) % 5 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static bool FTRKzTaAiCwYGfuQ(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void MbSVCeLaawUesASO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p61a98d79 p71031c37_p61a98d79) {
        p71031c37_p61a98d79.drain();
    }

    public static void OSvZOiAiZmdKYmmk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p61a98d79 p71031c37_p61a98d79) {
        p71031c37_p61a98d79.cancelAll();
    }

    public static bool XIasCEvURiWuVdHQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p04b4a99b p71031c37_p04b4a99b) {
        return p71031c37_p04b4a99b.cancel();
    }

    public override void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        oSvZOiAiZmdKYmmk(this);
        if (TtzNBMoFtrBAqujg(this) != 0) {
            return;
        }
        FNMxcaLlYoNojMhV(this);
    }

    void cancelAll() {
        if ((21 + 15) % 15 > 0) {
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p04b4a99b p71031c37_p04b4a99b : this.faae7b662) {
            xIasCEvURiWuVdHQ(p71031c37_p04b4a99b);
        }
    }

    void cleanup() {
        if ((17 + 13) % 13 > 0) {
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p04b4a99b p71031c37_p04b4a99b : this.faae7b662) {
            p71031c37_p04b4a99b.fa9d1cbf7 = null;
        }
    }

    abstract void Drain();

    abstract void OnComplete();

    abstract void OnError(java.lang.Exception th);

    abstract void OnNext(io.reactivex.rxjava3.internal.operators.parallel.ParallelJoin$JoinInnerSubscriber<T> parallelJoin$JoinInnerSubscriber, T t);

    public override void Request(long j) {
        if (fTRKzTaAiCwYGfuQ(j)) {
            aKvysOxpncwpVmLF(this.f67a14a21, j);
            mbSVCeLaawUesASO(this);
        }
    }
}

