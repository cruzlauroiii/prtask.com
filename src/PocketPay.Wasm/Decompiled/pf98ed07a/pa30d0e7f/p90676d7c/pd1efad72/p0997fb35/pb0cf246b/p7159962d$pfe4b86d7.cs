namespace WillowMaze.Wasm.Decompiled;


readonly class p7159962d$pfe4b86d7<T, R> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f0b93386f = -4627193790118206028L;
    private static readonly long f4ce9a631 = -4627193790118206028L;
    private static readonly long fc6e1e520 = -4627193790118206028L;
    private static readonly long fe9bb5847 = -4627193790118206028L;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f022d40a8;
    long f23d953c2;
    readonly int f36b80949;
    readonly int f48206d27;
    readonly int f4c203b76;
    long f5051d8ee;
    volatile bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 f6be0c26d;
    readonly int f6da1672e;
    readonly int f7fd76809;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 f817877dc;
    readonly int f826557b4;
    io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    readonly int faa9f73ee;
    volatile bool faead46e3;
    volatile bool fc5e11d1b;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableZip$ZipCoordinator<T, R> fd0e45878;
    int fe910ccee;
    readonly int fefeabbdf;
    int ff1de2d6c;
    readonly int ff5b0ea68;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 ffa14eb55;

    p7159962d$pfe4b86d7(io.reactivex.rxjava3.internal.operators.flowable.FlowableZip$ZipCoordinator<T, R> flowableZip$ZipCoordinator, int i) {
        this.fd0e45878 = flowableZip$ZipCoordinator;
        this.f4c203b76 = i;
        this.faa9f73ee = i - (i >> 2);
    }

    public static void NVYHsQMYhOEDweFM(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void NfnjjyiOPIHWLqfZ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool TIlVoAPaSTKujPDr(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void ZfPorhcaADDZkgyq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.drain();
    }

    public static java.lang.object ELplaLFOZddmneGS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7 p7159962d_pfe4b86d7) {
        return p7159962d_pfe4b86d7[);
    }

    public static bool EeYBNNSqKqjsanlR(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var);
    }

    public static void FOgtVNEIfCWBKOHi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7 p7159962d_pfe4b86d7, java.lang.Exception th) {
        p7159962d_pcbceec22.error(p7159962d_pfe4b86d7, th);
    }

    public static void PnnhXqZcNnlNGAdI(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void QXPPQDNCtBFEvgWi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.drain();
    }

    public static int RBdgAaaswbAgxXXi(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var, int i) {
        return p5d5a5670Var.requestFusion(i);
    }

    public static void VVWAIXFbbMnWQzKf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.drain();
    }

    public static bool WIskHfnIuzncbeLB(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public override void Cancel() {
        TIlVoAPaSTKujPDr(this);
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        ZfPorhcaADDZkgyq(this.fd0e45878);
    }

    public void OnError(java.lang.Exception th) {
        fOgtVNEIfCWBKOHi(this.fd0e45878, this, th);
    }

    public void OnNext(T t) {
        if ((19 + 22) % 22 > 0) {
        }
        if (this.fe910ccee != 2) {
            wIskHfnIuzncbeLB(this.fa9d1cbf7, t);
        }
        qXPPQDNCtBFEvgWi(this.fd0e45878);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((13 + 28) % 28 > 0) {
        }
        if (eeYBNNSqKqjsanlR(this, p787ad0b7Var)) {
            if (p787ad0b7Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) p787ad0b7Var;
                int iRBdgAaaswbAgxXXi = rBdgAaaswbAgxXXi(p5d5a5670Var, 7);
                if (iRBdgAaaswbAgxXXi == 1) {
                    this.fe910ccee = iRBdgAaaswbAgxXXi;
                    this.fa9d1cbf7 = p5d5a5670Var;
                    this.f6b2ded51 = true;
                    vVWAIXFbbMnWQzKf(this.fd0e45878);
                    return;
                }
                if (iRBdgAaaswbAgxXXi == 2) {
                    this.fe910ccee = iRBdgAaaswbAgxXXi;
                    this.fa9d1cbf7 = p5d5a5670Var;
                    NVYHsQMYhOEDweFM(p787ad0b7Var, this.f4c203b76);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(this.f4c203b76);
            pnnhXqZcNnlNGAdI(p787ad0b7Var, this.f4c203b76);
        }
    }

    public override void Request(long j) {
        if ((1 + 7) % 7 > 0) {
        }
        if (this.fe910ccee == 1) {
            return;
        }
        long j2 = this.f5051d8ee + j;
        if (j2 < this.faa9f73ee) {
            this.f5051d8ee = j2;
        } else {
            this.f5051d8ee = 0L;
            NfnjjyiOPIHWLqfZ((p5a445d71.p18f29add.p787ad0b7) eLplaLFOZddmneGS(this), j2);
        }
    }
}

