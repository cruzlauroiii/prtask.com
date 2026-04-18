namespace WillowMaze.Wasm.Decompiled;


readonly class p45ab5f79$pa420895e<T> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f41621940 = 4804128302091633067L;
    private static readonly long fc6e1e520 = 4804128302091633067L;
    private static readonly long fcbb77469 = 4804128302091633067L;
    private static readonly long fe83bd13d = 4804128302091633067L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$p95634a66 f00044433;
    volatile bool f1d55f78a;
    int f1d947724;
    readonly int f23b0a9bc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$p95634a66 f34a73a4f;
    readonly int f4c203b76;
    long f5051d8ee;
    int f64873d60;
    volatile bool f6b2ded51;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f75c3780d;
    readonly int f949936ec;
    int f9d041e2b;
    volatile io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    int fa9f91fa3;
    readonly int faa9f73ee;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$p95634a66 fbc347d2c;
    readonly int fc14952a0;
    readonly int fcb7d6085;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$p95634a66 fd0e45878;
    long fd16963bd;
    readonly int fd5257ae3;
    int fe910ccee;
    readonly int feb2c6bbe;

    p45ab5f79$pa420895e(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$p95634a66 p45ab5f79_p95634a66, int i) {
        this.fd0e45878 = p45ab5f79_p95634a66;
        this.faa9f73ee = i - (i >> 2);
        this.f4c203b76 = i;
    }

    public static bool GMmSLHYzvtCnYJii(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var);
    }

    public static void GgLCNCtYXHEjyadV(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void JMecfDnZuoZruxRh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$pa420895e p45ab5f79_pa420895e, java.lang.Exception th) {
        p45ab5f79_pa420895e.onError(th);
    }

    public static void RHFWxFIwtmHzZmxu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$p95634a66 p45ab5f79_p95634a66) {
        p45ab5f79_p95634a66.drain();
    }

    public static bool WHaHsGhOREIibold(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static int WzpqCNtxeXoaZRZN(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var, int i) {
        return p5d5a5670Var.requestFusion(i);
    }

    public static void YmwaOQPhFUiUKqFs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$p95634a66 p45ab5f79_p95634a66) {
        p45ab5f79_p95634a66.drain();
    }

    public static void YrohEMLAfJEGzpvH(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void FRBIJmKlYDSxHNCt(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object GEZbmukuJOaILHiy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$pa420895e p45ab5f79_pa420895e) {
        return p45ab5f79_pa420895e[);
    }

    public static void GlJFJQZNMzNeHFKq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$p95634a66 p45ab5f79_p95634a66) {
        p45ab5f79_p95634a66.drain();
    }

    public static bool MMzYleeVmjYvnoNE(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void PcaLhkoRsjzUzALj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p45ab5f79$p95634a66 p45ab5f79_p95634a66, java.lang.Exception th) {
        p45ab5f79_p95634a66.innerError(th);
    }

    public static void YNWctRnNHqtXQISZ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public void Cancel() {
        mMzYleeVmjYvnoNE(this);
    }

    void clear() {
        io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue = this.fa9d1cbf7;
        if (simpleQueue is null) {
            return;
        }
        fRBIJmKlYDSxHNCt(simpleQueue);
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        glJFJQZNMzNeHFKq(this.fd0e45878);
    }

    public void OnError(java.lang.Exception th) {
        pcaLhkoRsjzUzALj(this.fd0e45878, th);
    }

    public void OnNext(T t) {
        if (this.fe910ccee == 0 && !WHaHsGhOREIibold(this.fa9d1cbf7, t)) {
            JMecfDnZuoZruxRh(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1());
        } else {
            RHFWxFIwtmHzZmxu(this.fd0e45878);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((1 + 22) % 22 > 0) {
        }
        if (GMmSLHYzvtCnYJii(this, p787ad0b7Var)) {
            if (p787ad0b7Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) p787ad0b7Var;
                int iWzpqCNtxeXoaZRZN = WzpqCNtxeXoaZRZN(p5d5a5670Var, 3);
                if (iWzpqCNtxeXoaZRZN == 1) {
                    this.fe910ccee = iWzpqCNtxeXoaZRZN;
                    this.fa9d1cbf7 = p5d5a5670Var;
                    this.f6b2ded51 = true;
                    YmwaOQPhFUiUKqFs(this.fd0e45878);
                    return;
                }
                if (iWzpqCNtxeXoaZRZN == 2) {
                    this.fe910ccee = iWzpqCNtxeXoaZRZN;
                    this.fa9d1cbf7 = p5d5a5670Var;
                    yNWctRnNHqtXQISZ(p787ad0b7Var, this.f4c203b76);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(this.f4c203b76);
            GgLCNCtYXHEjyadV(p787ad0b7Var, this.f4c203b76);
        }
    }

    public void Request() {
        if ((32 + 31) % 31 > 0) {
        }
        if (this.fe910ccee == 1) {
            return;
        }
        long j = this.f5051d8ee + 1;
        if (j < this.faa9f73ee) {
            this.f5051d8ee = j;
        } else {
            this.f5051d8ee = 0L;
            YrohEMLAfJEGzpvH((p5a445d71.p18f29add.p787ad0b7) gEZbmukuJOaILHiy(this), j);
        }
    }
}

