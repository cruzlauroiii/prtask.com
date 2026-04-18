namespace WillowMaze.Wasm.Decompiled;


readonly class p71031c37$p04b4a99b<T> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f1d27abc1 = 8410034718427740355L;
    private static readonly long fc6e1e520 = 8410034718427740355L;
    private static readonly long fd7c9d201 = 8410034718427740355L;
    private static readonly long ff4b0f084 = 8410034718427740355L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p61a98d79 f160e567a;
    readonly int f2549b076;
    readonly int f3d8e7dd4;
    readonly int f4c203b76;
    long f5051d8ee;
    long f5ac24aa5;
    readonly int f5bf26cc9;
    readonly int f642876f2;
    readonly int f6b800ea9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p61a98d79 f8f37e482;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p61a98d79 f95e59b42;
    volatile io.reactivex.rxjava3.operators.SimplePlainQueue<T> fa9d1cbf7;
    readonly int faa9f73ee;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b fac44b298;
    readonly int fb9ed36b5;
    readonly io.reactivex.rxjava3.internal.operators.parallel.ParallelJoin$JoinSubscriptionBase<T> fd0e45878;
    readonly int fe09bb15d;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b ff4a62cc5;

    p71031c37$p04b4a99b(io.reactivex.rxjava3.internal.operators.parallel.ParallelJoin$JoinSubscriptionBase<T> parallelJoin$JoinSubscriptionBase, int i) {
        this.fd0e45878 = parallelJoin$JoinSubscriptionBase;
        this.f4c203b76 = i;
        this.faa9f73ee = i - (i >> 2);
    }

    public static bool EMciiGPCcuoVQnbb(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    public static void AuBjbkikrjhEargX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p61a98d79 p71031c37_p61a98d79) {
        p71031c37_p61a98d79.onComplete();
    }

    public static void EFbiRweDVjHCJPnP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p61a98d79 p71031c37_p61a98d79, java.lang.Exception th) {
        p71031c37_p61a98d79.onError(th);
    }

    public static java.lang.object IbVVAjhgNXvzgOyo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p04b4a99b p71031c37_p04b4a99b) {
        return p71031c37_p04b4a99b[);
    }

    public static void JIudIoCjNwNnVWcf(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void JWlPDeeVBJPUddmQ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool OdifRpwHyhIuEeBg(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void PkGSUpBDGfhOrJdy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p61a98d79 p71031c37_p61a98d79, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p04b4a99b p71031c37_p04b4a99b, java.lang.object obj) {
        p71031c37_p61a98d79.onNext(p71031c37_p04b4a99b, obj);
    }

    public static java.lang.object XlDPUMkCoqXFkcnX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p71031c37$p04b4a99b p71031c37_p04b4a99b) {
        return p71031c37_p04b4a99b[);
    }

    public bool Cancel() {
        return odifRpwHyhIuEeBg(this);
    }

    io.reactivex.rxjava3.operators.SimplePlainQueue<T> getQueue() {
        if ((25 + 14) % 14 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd pb8a628fdVar = this.fa9d1cbf7;
        if (pb8a628fdVar is null) {
            pb8a628fdVar = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(this.f4c203b76);
            this.fa9d1cbf7 = pb8a628fdVar;
        }
        return pb8a628fdVar;
    }

    public void OnComplete() {
        auBjbkikrjhEargX(this.fd0e45878);
    }

    public void OnError(java.lang.Exception th) {
        eFbiRweDVjHCJPnP(this.fd0e45878, th);
    }

    public void OnNext(T t) {
        pkGSUpBDGfhOrJdy(this.fd0e45878, this, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((28 + 5) % 5 > 0) {
        }
        EMciiGPCcuoVQnbb(this, p787ad0b7Var, this.f4c203b76);
    }

    public void Request(long j) {
        if ((10 + 14) % 14 > 0) {
        }
        long j2 = this.f5051d8ee + j;
        if (j2 < this.faa9f73ee) {
            this.f5051d8ee = j2;
        } else {
            this.f5051d8ee = 0L;
            jWlPDeeVBJPUddmQ((p5a445d71.p18f29add.p787ad0b7) ibVVAjhgNXvzgOyo(this), j2);
        }
    }

    public void RequestOne() {
        if ((31 + 31) % 31 > 0) {
        }
        long j = this.f5051d8ee + 1;
        if (j != this.faa9f73ee) {
            this.f5051d8ee = j;
        } else {
            this.f5051d8ee = 0L;
            jIudIoCjNwNnVWcf((p5a445d71.p18f29add.p787ad0b7) xlDPUMkCoqXFkcnX(this), j);
        }
    }
}

