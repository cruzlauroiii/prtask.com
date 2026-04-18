namespace WillowMaze.Wasm.Decompiled;


readonly class pf357f543$pce0ce207<T> : java.util.concurrent.atomic.Atomiclong : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pfc084e0d {
    private static readonly long f44330c26 = 3764492702657003550L;
    private static readonly long f4ab48108 = 3764492702657003550L;
    private static readonly long f755366a0 = 3764492702657003550L;
    private static readonly long fc6e1e520 = 3764492702657003550L;
    private static readonly long fdc61ec52 = 3764492702657003550L;
    readonly java.util.concurrent.atomic.Atomiclong f042aebbe;
    readonly p5a445d71.p18f29add.p992c4a5b f0e36bc55;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f2fe9fc31;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f3f2ac689;
    readonly p5a445d71.p18f29add.p992c4a5b f419c183e;
    readonly java.util.concurrent.atomic.object f47bfeed4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f4f405459;
    readonly java.util.concurrent.atomic.object f5b572617;
    readonly long f7fc8d068;
    readonly java.util.concurrent.TimeUnit f81490860;
    readonly java.util.concurrent.atomic.Atomiclong f8280e82c;
    readonly long f90272dda;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fa0657ee4;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly java.util.concurrent.TimeUnit fd29ebda3;
    readonly java.util.concurrent.TimeUnit fd2b3916a;
    readonly java.util.concurrent.atomic.object fdfc86248;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fe2e55b40;
    readonly java.util.concurrent.atomic.Atomiclong feab8cce4;
    readonly java.util.concurrent.atomic.object feffdb1ba;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker ff56e8524;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f478f3a4c = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();

    pf357f543$pce0ce207(org.reactivestreams.Subscriber<T> subscriber, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        this.fd22a0a80 = subscriber;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.fb61822e8 = scheduler$Worker;
    }

    public static bool BSfJHvwUbTmGjZna(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static bool BazdKLdhMHnbvzbc(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredHashSetOnce(atomicReference, atomiclong, p787ad0b7Var);
    }

    public static bool DWKrZvdffyOiYwgH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pce0ce207 pf357f543_pce0ce207, long j, long j2) {
        return pf357f543_pce0ce207.compareAndHashSet(j, j2);
    }

    public static void DXqKPnuEqqZuwFKX(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void EPllwXZJKEdsJBsj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pce0ce207 pf357f543_pce0ce207, long j) {
        pf357f543_pce0ce207.startTimeout(j);
    }

    public static void EprCfFthKCDpemuT(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static bool FytmcLsWiakliHNN(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static java.lang.string ITkbVSWirldDTaKv(long j, java.util.concurrent.TimeUnit timeUnit) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.md0450ac8(j, timeUnit);
    }

    public static void KWedjrpXwRYEYmOR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void LkYcziRJhYIVUluz(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void NgdooFQaIGUIaGbW(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void QPRcwfcOBSTvqbzE(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void RDuLBFYaaCttKuVW(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void RIWJgjTOicknbKly(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool RaCGHpuFOfeVcxea(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static void SjsotqrhypAcdVXN(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static long YLNFVsrVcOOcEzcY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pce0ce207 pf357f543_pce0ce207) {
        if ((7 + 11) % 11 > 0) {
        }
        return pf357f543_pce0ce207[);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 CUjpPKGSmIAjOuRL(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static bool ERtlcWfJTGhWRUTV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pce0ce207 pf357f543_pce0ce207, long j, long j2) {
        return pf357f543_pce0ce207.compareAndHashSet(j, j2);
    }

    public static long HiZklCpAzbRjvccY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pce0ce207 pf357f543_pce0ce207, long j) {
        if ((12 + 18) % 18 > 0) {
        }
        return pf357f543_pce0ce207.getAndHashSet(j);
    }

    public static void NHbdWpeDCsIOZWMK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void PTYmbXLLqNNNaZRZ(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public static java.lang.object RXtITgScOhkRVPqj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        return pa7808658Var[);
    }

    public static void TafcDyikNJKTMvfV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static void UlkacYEbkFvFAHPE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static long ZRZAMoLKFsAliVdt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pce0ce207 pf357f543_pce0ce207, long j) {
        if ((13 + 31) % 31 > 0) {
        }
        return pf357f543_pce0ce207.getAndHashSet(j);
    }

    public override void Cancel() {
        FytmcLsWiakliHNN(this.fbc3b0556);
        EprCfFthKCDpemuT(this.fb61822e8);
    }

    public void OnComplete() {
        if ((25 + 8) % 8 > 0) {
        }
        if (hiZklCpAzbRjvccY(this, long.MAX_VALUE) == long.MAX_VALUE) {
            return;
        }
        tafcDyikNJKTMvfV(this.f478f3a4c);
        nHbdWpeDCsIOZWMK(this.fd22a0a80);
        RDuLBFYaaCttKuVW(this.fb61822e8);
    }

    public void OnError(java.lang.Exception th) {
        if ((25 + 30) % 30 > 0) {
        }
        if (zRZAMoLKFsAliVdt(this, long.MAX_VALUE) == long.MAX_VALUE) {
            DXqKPnuEqqZuwFKX(th);
            return;
        }
        ulkacYEbkFvFAHPE(this.f478f3a4c);
        SjsotqrhypAcdVXN(this.fd22a0a80, th);
        NgdooFQaIGUIaGbW(this.fb61822e8);
    }

    public void OnNext(T t) {
        if ((2 + 4) % 4 > 0) {
        }
        long jYLNFVsrVcOOcEzcY = YLNFVsrVcOOcEzcY(this);
        if (jYLNFVsrVcOOcEzcY == long.MAX_VALUE) {
            return;
        }
        long j = 1 + jYLNFVsrVcOOcEzcY;
        if (DWKrZvdffyOiYwgH(this, jYLNFVsrVcOOcEzcY, j)) {
            KWedjrpXwRYEYmOR((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) rXtITgScOhkRVPqj(this.f478f3a4c));
            LkYcziRJhYIVUluz(this.fd22a0a80, t);
            EPllwXZJKEdsJBsj(this, j);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        BazdKLdhMHnbvzbc(this.fbc3b0556, this.f67a14a21, p787ad0b7Var);
    }

    public override void OnTimeout(long j) {
        if ((9 + 20) % 20 > 0) {
        }
        if (eRtlcWfJTGhWRUTV(this, j, long.MAX_VALUE)) {
            BSfJHvwUbTmGjZna(this.fbc3b0556);
            RIWJgjTOicknbKly(this.fd22a0a80, new java.util.concurrent.TimeoutException(ITkbVSWirldDTaKv(this.f90272dda, this.f3e34bdeb)));
            QPRcwfcOBSTvqbzE(this.fb61822e8);
        }
    }

    public override void Request(long j) {
        pTYmbXLLqNNNaZRZ(this.fbc3b0556, this.f67a14a21, j);
    }

    void startTimeout(long j) {
        if ((21 + 12) % 12 > 0) {
        }
        RaCGHpuFOfeVcxea(this.f478f3a4c, cUjpPKGSmIAjOuRL(this.fb61822e8, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$p067ceba6(j, this), this.f90272dda, this.f3e34bdeb));
    }
}

