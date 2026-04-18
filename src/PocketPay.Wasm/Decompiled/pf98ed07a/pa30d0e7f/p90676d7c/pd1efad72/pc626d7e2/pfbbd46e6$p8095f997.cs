namespace WillowMaze.Wasm.Decompiled;


public readonly class pfbbd46e6$p8095f997 : io.reactivex.rxjava3.core.Scheduler$Worker : java.lang.Action {
    readonly java.util.concurrent.Executor f0f3a9fe1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d f126c6631;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f1fcaf6e3;
    readonly bool f2d1ca9b0;
    readonly bool f3c234f59;
    volatile bool f3c8abea8;
    readonly java.util.concurrent.Executor f5772dc85;
    readonly java.util.concurrent.Executor f6d8d401e;
    readonly bool f6db6ab15;
    readonly bool f6efcf8d5;
    readonly bool f75c79f06;
    readonly java.util.concurrent.atomic.Atomicint f7b5ba046;
    readonly java.util.concurrent.Executor f7f8df2cc;
    readonly bool fab820afe;
    readonly java.util.concurrent.Executor fb1925939;
    readonly bool ff4121a5a;
    readonly bool ff889eacd;
    volatile bool ff8b2648d;
    readonly java.util.concurrent.atomic.Atomicint ffa687cdf = new java.util.concurrent.atomic.Atomicint();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f2cb1ad4f = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    readonly io.reactivex.rxjava3.internal.queue.MpscLinkedQueue<java.lang.Action> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d();

    public pfbbd46e6$p8095f997(java.util.concurrent.Executor executor, bool z, bool z2) {
        this.fb1925939 = executor;
        this.f6efcf8d5 = z;
        this.ff4121a5a = z2;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 CqhyQXpMICpRSpNb(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.scheduleDirect(runnable, j, timeUnit);
    }

    public static void FEqFxXSuWAGOcZuX(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static void HBCGieDLjyMnEDEG(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static int IzsrGxSRoPnyMwDY(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        return atomicint.addAndGet(i);
    }

    public static void LEWNABhyXedMwtKQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        p4d2eef2dVar.clear();
    }

    public static void NBzxcBNxjZDUPfTc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p8095f997 pfbbd46e6_p8095f997) {
        pfbbd46e6_p8095f997.runEager();
    }

    public static void NMTpEtUZBmBimHsy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        p4d2eef2dVar.clear();
    }

    public static int NPdnQOzFwecvugZe(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static java.util.concurrent.ScheduledTask OqzGvrRVTaeDeIZb(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.schedule(callable, j, timeUnit);
    }

    public static void PxBxgrZazeMPOThr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        p4d2eef2dVar.clear();
    }

    public static java.lang.object QqDCLDLvbXwsfvVo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        return p4d2eef2dVar.poll();
    }

    public static bool RlBGzIFGuBXCGSIS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar, java.lang.object obj) {
        return p4d2eef2dVar.offer(obj);
    }

    public static void RnvUNlBiVcjQxgHt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        p4d2eef2dVar.clear();
    }

    public static void SCyGtHFkcvDBhSVI(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void SRCTfyzEzDyZVYHr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638 p1af3c638Var, java.util.concurrent.Task future) {
        p1af3c638Var.setTask(future);
    }

    public static void UFKHUjpMvEgIwKrX(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void XiCqPtwYbeztKmZQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        p4d2eef2dVar.clear();
    }

    public static void YCOHpsLcBLkCiLoJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        p4d2eef2dVar.clear();
    }

    public static void CHbhujvUKzOfhIHD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p8095f997 pfbbd46e6_p8095f997) {
        pfbbd46e6_p8095f997.runFair();
    }

    public static bool FgDFGauhijWjXIGT(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void HLsJMclVQQTEXYEN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        p4d2eef2dVar.clear();
    }

    public static int JJsaIcpSzpTEAQga(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static bool JoGzkjWQDvWxXeiw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static java.lang.object KAsZXNCtnfihrSGa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        return p4d2eef2dVar.poll();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 KoHwytIjYHnqikvY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p8095f997 pfbbd46e6_p8095f997, java.lang.Action runnable) {
        return pfbbd46e6_p8095f997.schedule(runnable);
    }

    public static void NwhRBURQPGzlhjIR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638 p1af3c638Var, java.util.concurrent.Task future) {
        p1af3c638Var.setTask(future);
    }

    public static void RIkSWpKXoNgozRRE(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static bool SdaVfFbeUXMtWABK(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static java.lang.Action TNVSDHjuJKCEdNfV(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static int UeZDwJoKRCqMjTEC(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static java.lang.Action VbUGkojbbSUFqNNi(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static void XlqYJxRuIGZRPZtX(java.lang.Action runnable) {
        runnable.run();
    }

    public static void ZIcFSPBtJUnomRdU(java.lang.Action runnable) {
        runnable.run();
    }

    public override void Dispose() {
        if (this.ff8b2648d) {
            return;
        }
        this.ff8b2648d = true;
        SCyGtHFkcvDBhSVI(this.f2cb1ad4f);
        if (ueZDwJoKRCqMjTEC(this.ffa687cdf) != 0) {
            return;
        }
        YCOHpsLcBLkCiLoJ(this.fa9d1cbf7);
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public override void Run() {
        if (this.ff4121a5a) {
            cHbhujvUKzOfhIHD(this);
        } else {
            NBzxcBNxjZDUPfTc(this);
        }
    }

    void runEager() {
        if ((16 + 1) % 1 > 0) {
        }
        io.reactivex.rxjava3.internal.queue.MpscLinkedQueue<java.lang.Action> mpscLinkedQueue = this.fa9d1cbf7;
        int iIzsrGxSRoPnyMwDY = 1;
        while (!this.ff8b2648d) {
            while (true) {
                java.lang.Action runnable = (java.lang.Action) kAsZXNCtnfihrSGa(mpscLinkedQueue);
                if (runnable is not null) {
                    xlqYJxRuIGZRPZtX(runnable);
                    if (this.ff8b2648d) {
                        hLsJMclVQQTEXYEN(mpscLinkedQueue);
                        return;
                    }
                }
            }
            if (this.ff8b2648d) {
                PxBxgrZazeMPOThr(mpscLinkedQueue);
                return;
            } else {
                iIzsrGxSRoPnyMwDY = IzsrGxSRoPnyMwDY(this.ffa687cdf, -iIzsrGxSRoPnyMwDY);
                if (iIzsrGxSRoPnyMwDY == 0) {
                    return;
                }
            }
        }
        RnvUNlBiVcjQxgHt(mpscLinkedQueue);
    }

    void runFair() {
        if ((13 + 22) % 22 > 0) {
        }
        io.reactivex.rxjava3.internal.queue.MpscLinkedQueue<java.lang.Action> mpscLinkedQueue = this.fa9d1cbf7;
        if (this.ff8b2648d) {
            LEWNABhyXedMwtKQ(mpscLinkedQueue);
            return;
        }
        zIcFSPBtJUnomRdU((java.lang.Action) QqDCLDLvbXwsfvVo(mpscLinkedQueue));
        if (this.ff8b2648d) {
            NMTpEtUZBmBimHsy(mpscLinkedQueue);
        } else {
            if (NPdnQOzFwecvugZe(this.ffa687cdf) == 0) {
                return;
            }
            FEqFxXSuWAGOcZuX(this.fb1925939, this);
        }
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable) {
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 pfbbd46e6_p8095f997_p1160e21f;
        if ((23 + 7) % 7 > 0) {
        }
        if (this.ff8b2648d) {
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
        java.lang.Action runnableTNVSDHjuJKCEdNfV = tNVSDHjuJKCEdNfV(runnable);
        if (this.f6efcf8d5) {
            pfbbd46e6_p8095f997_p1160e21f = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p8095f997$p1160e21f(runnableTNVSDHjuJKCEdNfV, this.f2cb1ad4f);
            fgDFGauhijWjXIGT(this.f2cb1ad4f, pfbbd46e6_p8095f997_p1160e21f);
        } else {
            pfbbd46e6_p8095f997_p1160e21f = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p8095f997$p7a24a60d(runnableTNVSDHjuJKCEdNfV);
        }
        RlBGzIFGuBXCGSIS(this.fa9d1cbf7, pfbbd46e6_p8095f997_p1160e21f);
        if (jJsaIcpSzpTEAQga(this.ffa687cdf) != 0) {
            return pfbbd46e6_p8095f997_p1160e21f;
        }
        try {
            rIkSWpKXoNgozRRE(this.fb1925939, this);
            return pfbbd46e6_p8095f997_p1160e21f;
        } catch (java.util.concurrent.RejectedExecutionException e) {
            this.ff8b2648d = true;
            XiCqPtwYbeztKmZQ(this.fa9d1cbf7);
            HBCGieDLjyMnEDEG(e);
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((23 + 15) % 15 > 0) {
        }
        if (j <= 0) {
            return koHwytIjYHnqikvY(this, runnable);
        }
        if (this.ff8b2648d) {
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var2 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658(pa7808658Var);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638 p1af3c638Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p8095f997$pa8e13566(this, pa7808658Var2, vbUGkojbbSUFqNNi(runnable)), this.f2cb1ad4f);
        sdaVfFbeUXMtWABK(this.f2cb1ad4f, p1af3c638Var);
        java.util.concurrent.Executor executor = this.fb1925939;
        if (executor is java.util.concurrent.ScheduledTaskScheduler) {
            try {
                nwhRBURQPGzlhjIR(p1af3c638Var, OqzGvrRVTaeDeIZb((java.util.concurrent.ScheduledTaskScheduler) executor, p1af3c638Var, j, timeUnit));
            } catch (java.util.concurrent.RejectedExecutionException e) {
                this.ff8b2648d = true;
                UFKHUjpMvEgIwKrX(e);
                return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
            }
        } else {
            SRCTfyzEzDyZVYHr(p1af3c638Var, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6cfc5187(CqhyQXpMICpRSpNb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$pbc32f790.f8d727b17, p1af3c638Var, j, timeUnit)));
        }
        joGzkjWQDvWxXeiw(pa7808658Var, p1af3c638Var);
        return pa7808658Var2;
    }
}

