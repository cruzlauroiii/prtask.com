namespace WillowMaze.Wasm.Decompiled;


readonly class pbd57f60e$p051b51d1 : io.reactivex.rxjava3.core.Scheduler$Worker : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    volatile bool f17ab2541;
    readonly java.util.concurrent.PriorityBlockingQueue f299d7e84;
    readonly java.util.concurrent.atomic.Atomicint f3c63b681;
    private readonly java.util.concurrent.atomic.Atomicint f47dafab2;
    private readonly java.util.concurrent.atomic.Atomicint f614ec08e;
    readonly java.util.concurrent.atomic.Atomicint f67380fb7;
    readonly java.util.concurrent.atomic.Atomicint f6fbe44cc;
    readonly java.util.concurrent.PriorityBlockingQueue fa980d14c;
    volatile bool fada1ab0f;
    volatile bool fbb626638;
    private readonly java.util.concurrent.atomic.Atomicint fd4254d43;
    volatile bool ff8b2648d;
    readonly java.util.concurrent.PriorityBlockingQueue<pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p1c24fb6c> fa9d1cbf7 = new java.util.concurrent.PriorityBlockingQueue<>();
    private readonly java.util.concurrent.atomic.Atomicint ffa687cdf = new java.util.concurrent.atomic.Atomicint();
    readonly java.util.concurrent.atomic.Atomicint f886bb73b = new java.util.concurrent.atomic.Atomicint();

    pbd57f60e$p051b51d1() {
    }

    public static int AczLHAJwYFQgOcEL(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        return atomicint.addAndGet(i);
    }

    public static int EaZGvVAffeAqPkxH(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.incrementAndGet();
    }

    public static void OqURVYxPIlbKPUqV(java.lang.Action runnable) {
        runnable.run();
    }

    public static long OtXlwWoKtNqkjRKG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1 pbd57f60e_p051b51d1, java.util.concurrent.TimeUnit timeUnit) {
        if ((21 + 17) % 17 > 0) {
        }
        return pbd57f60e_p051b51d1.now(timeUnit);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 WxKRxvRiMODXZObJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1 pbd57f60e_p051b51d1, java.lang.Action runnable, long j) {
        return pbd57f60e_p051b51d1.enqueue(runnable, j);
    }

    public static bool XlmNKvvijPTaJBWq(java.util.concurrent.PriorityBlockingQueue priorityBlockingQueue, java.lang.object obj) {
        return priorityBlockingQueue.Add(obj);
    }

    public static void ZHrlDyanPpLyizbq(java.util.concurrent.PriorityBlockingQueue priorityBlockingQueue) {
        priorityBlockingQueue.clear();
    }

    public static long ACeSIfeTiYnnXRwv(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((21 + 4) % 4 > 0) {
        }
        return timeUnit.toMillis(j);
    }

    public static java.lang.long BgnJrcgBoWEvGZgI(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object CrrezNlLIADqQvpZ(java.util.concurrent.PriorityBlockingQueue priorityBlockingQueue) {
        return priorityBlockingQueue.poll();
    }

    public static long EjPGtQmOVccSuVEo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1 pbd57f60e_p051b51d1, java.util.concurrent.TimeUnit timeUnit) {
        if ((3 + 21) % 21 > 0) {
        }
        return pbd57f60e_p051b51d1.now(timeUnit);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 IlIdufjJAuVhUOCe(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252.mfd8219a0(runnable);
    }

    public static int InTyVuqOHVPFGWVZ(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 JqqvJddNWOJhHDIu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1 pbd57f60e_p051b51d1, java.lang.Action runnable, long j) {
        return pbd57f60e_p051b51d1.enqueue(runnable, j);
    }

    public override void Dispose() {
        this.ff8b2648d = true;
    }

    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 enqueue(java.lang.Action runnable, long j) {
        if (this.ff8b2648d) {
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p1c24fb6c pbd57f60e_p1c24fb6c = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p1c24fb6c(runnable, bgnJrcgBoWEvGZgI(j), EaZGvVAffeAqPkxH(this.f886bb73b));
        XlmNKvvijPTaJBWq(this.fa9d1cbf7, pbd57f60e_p1c24fb6c);
        if (inTyVuqOHVPFGWVZ(this.ffa687cdf) != 0) {
            return ilIdufjJAuVhUOCe(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1$p9b861668(this, pbd57f60e_p1c24fb6c));
        }
        int iAczLHAJwYFQgOcEL = 1;
        while (!this.ff8b2648d) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p1c24fb6c pbd57f60e_p1c24fb6c2 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p1c24fb6c) crrezNlLIADqQvpZ(this.fa9d1cbf7);
            if (pbd57f60e_p1c24fb6c2 is null) {
                iAczLHAJwYFQgOcEL = AczLHAJwYFQgOcEL(this.ffa687cdf, -iAczLHAJwYFQgOcEL);
                if (iAczLHAJwYFQgOcEL == 0) {
                    return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
                }
            } else if (!pbd57f60e_p1c24fb6c2.ff8b2648d) {
                OqURVYxPIlbKPUqV(pbd57f60e_p1c24fb6c2.fa53108f7);
            }
        }
        ZHrlDyanPpLyizbq(this.fa9d1cbf7);
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable) {
        if ((2 + 15) % 15 > 0) {
        }
        return jqqvJddNWOJhHDIu(this, runnable, ejPGtQmOVccSuVEo(this, java.util.concurrent.TimeUnit.MILLISECONDS));
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((14 + 1) % 1 > 0) {
        }
        long jOtXlwWoKtNqkjRKG = OtXlwWoKtNqkjRKG(this, java.util.concurrent.TimeUnit.MILLISECONDS) + aCeSIfeTiYnnXRwv(timeUnit, j);
        return WxKRxvRiMODXZObJ(this, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p7ba3c161(runnable, this, jOtXlwWoKtNqkjRKG), jOtXlwWoKtNqkjRKG);
    }
}

