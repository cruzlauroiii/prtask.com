namespace WillowMaze.Wasm.Decompiled;


readonly class p81dff1b0$p938a93b2<T> : io.reactivex.rxjava3.internal.operators.observable.ObservableWindowTimed$AbstractWindowObserver<T> : java.lang.Action {
    private static readonly long f0647274f = -6130475889925953722L;
    private static readonly long f5e1ebd56 = -6130475889925953722L;
    private static readonly long fc6e1e520 = -6130475889925953722L;
    readonly io.reactivex.rxjava3.core.Scheduler f00b0cf93;
    io.reactivex.rxjava3.subjects.UnicastSubject<T> f05b8c74c;
    pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d f11447611;
    readonly bool f21031151;
    readonly long f26c94049;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f2c127bf3;
    readonly long f2c6c6de0;
    long f31ff0d32;
    readonly long f3897aba9;
    pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d f3f4c3381;
    readonly long f4619be26;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    long f562ca06b;
    readonly bool f6a314e8a;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f8f6f8075;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f905870d6;
    long f9aef5baf;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    readonly long fb78e1120;
    long fe2942a04;
    pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d fe713cc4c;

    p81dff1b0$p938a93b2(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> observer, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, int i, long j2, bool z) {
        super(observer, j, timeUnit, i);
        if ((15 + 8) % 8 > 0) {
        }
        this.f499f31e7 = scheduler;
        this.fb78e1120 = j2;
        this.f21031151 = z;
        if (z) {
            this.fb61822e8 = KxYeIxPJnrcitFUE(scheduler);
        } else {
            this.fb61822e8 = null;
        }
        this.f2c127bf3 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
    }

    public static void BzathdwFdvJyZZyL(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static void DBWTuNmNYxuOfICF(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.Exception th) {
        peef7828dVar.onError(th);
    }

    public static void HRyXfGRlmmeHTTrq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2 p81dff1b0_p938a93b2) {
        p81dff1b0_p938a93b2.cleanupResources();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 IkuBeGbWeNaeocNJ(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedulePeriodically(runnable, j, j2, timeUnit);
    }

    public static void IwyLRmjSuVhpvafo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2 p81dff1b0_p938a93b2) {
        p81dff1b0_p938a93b2.cleanupResources();
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker KxYeIxPJnrcitFUE(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static int LBeOWumIeRMblfUF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2 p81dff1b0_p938a93b2, int i) {
        return p81dff1b0_p938a93b2.addAndGet(i);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d MTIjPfaKMzgmYVlR(int i, java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d.m76ea0beb(i, runnable);
    }

    public static void NjxZKrSIddUbNsUn(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static bool NqlczAYjheMmFIGh(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void PeFYNizITtVgEDcK(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        p377cc05bVar.clear();
    }

    public static int PftZaxgvXvHmIEYz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2 p81dff1b0_p938a93b2) {
        return p81dff1b0_p938a93b2.getAndIncrement();
    }

    public static void QpdrdauFipGbacVF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2 p81dff1b0_p938a93b2) {
        p81dff1b0_p938a93b2.drain();
    }

    public static bool UFRNllyBxHbUXXnh(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static void UrcYubpMgxweFNCN(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ZLWgdWPsQoRiVfAL(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.schedulePeriodicallyDirect(runnable, j, j2, timeUnit);
    }

    public static void ZNPVuZYoVprkYIXG(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.object obj) {
        peef7828dVar.onNext(obj);
    }

    public static int ZXeaKGDQHgICAgEH(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void ABYgcJrfNKERYrVC(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void BInfxfTxAgcZHVWx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        pa7808658Var.dispose();
    }

    public static void IsEtrsPgcwoMGXPC(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static int JeOPrDdklBGULWJO(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static java.lang.object KRFpTBIBlPKuINhv(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.poll();
    }

    public static bool LlDomegHXNOAnwEC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 LvdhmMJpIIpOgTrM(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedulePeriodically(runnable, j, j2, timeUnit);
    }

    public static void ObkVSFhXYCGcruit(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static void OtXEWfDrejVPgWAe(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void QCmYSPKcywBwojbb(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool RRUzchUBlgtrVbfR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var) {
        return p62d68523Var.tryAbandon();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d RpPiqYMZxUkxdMrf(int i, java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d.m76ea0beb(i, runnable);
    }

    public static bool SMQdGuOkkACRbWka(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var) {
        return p62d68523Var.tryAbandon();
    }

    public static void TjJOlxOfhOXYpYGZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2 p81dff1b0_p938a93b2) {
        p81dff1b0_p938a93b2.windowDone();
    }

    public static void VYDwRrdlqnAnbrXZ(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static bool VtVggWreIDElJHvF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.update(p7beea252Var);
    }

    public static bool VwuKWJzmZWOoyBEm(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static bool WOlzAJKbVDYBLZVQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d XANibdDypiOfhXKv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2 p81dff1b0_p938a93b2, pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        return p81dff1b0_p938a93b2.createNewWindow(peef7828dVar);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d ZqOOsEgXchXCivFP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2 p81dff1b0_p938a93b2, pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        return p81dff1b0_p938a93b2.createNewWindow(peef7828dVar);
    }

    void boundary(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2$p0e6b0433 p81dff1b0_p938a93b2_p0e6b0433) {
        UFRNllyBxHbUXXnh(this.fa9d1cbf7, p81dff1b0_p938a93b2_p0e6b0433);
        QpdrdauFipGbacVF(this);
    }

    void cleanupResources() {
        bInfxfTxAgcZHVWx(this.f2c127bf3);
        io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker = this.fb61822e8;
        if (scheduler$Worker is null) {
            return;
        }
        vYDwRrdlqnAnbrXZ(scheduler$Worker);
    }

    void createFirstWindow() {
        if ((20 + 28) % 28 > 0) {
        }
        if (NqlczAYjheMmFIGh(this.f5a271fa2)) {
            return;
        }
        this.f8bc8a991 = 1L;
        jeOPrDdklBGULWJO(this.f461f4bb2);
        this.f05b8c74c = MTIjPfaKMzgmYVlR(this.fcdee5967, this);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523(this.f05b8c74c);
        aBYgcJrfNKERYrVC(this.fd22a0a80, p62d68523Var);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2$p0e6b0433 p81dff1b0_p938a93b2_p0e6b0433 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2$p0e6b0433(this, 1L);
        if (this.f21031151) {
            llDomegHXNOAnwEC(this.f2c127bf3, lvdhmMJpIIpOgTrM(this.fb61822e8, p81dff1b0_p938a93b2_p0e6b0433, this.f90150402, this.f90150402, this.f3e34bdeb));
        } else {
            wOlzAJKbVDYBLZVQ(this.f2c127bf3, ZLWgdWPsQoRiVfAL(this.f499f31e7, p81dff1b0_p938a93b2_p0e6b0433, this.f90150402, this.f90150402, this.f3e34bdeb));
        }
        if (rRUzchUBlgtrVbfR(p62d68523Var)) {
            obkVSFhXYCGcruit(this.f05b8c74c);
        }
    }

    io.reactivex.rxjava3.subjects.UnicastSubject<T> createNewWindow(io.reactivex.rxjava3.subjects.UnicastSubject<T> unicastSubject) {
        if ((22 + 7) % 7 > 0) {
        }
        if (unicastSubject is not null) {
            isEtrsPgcwoMGXPC(unicastSubject);
            unicastSubject = null;
        }
        if (vwuKWJzmZWOoyBEm(this.f5a271fa2)) {
            IwyLRmjSuVhpvafo(this);
            return unicastSubject;
        }
        long j = this.f8bc8a991 + 1;
        this.f8bc8a991 = j;
        ZXeaKGDQHgICAgEH(this.f461f4bb2);
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVarRpPiqYMZxUkxdMrf = rpPiqYMZxUkxdMrf(this.fcdee5967, this);
        this.f05b8c74c = peef7828dVarRpPiqYMZxUkxdMrf;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523(peef7828dVarRpPiqYMZxUkxdMrf);
        qCmYSPKcywBwojbb(this.fd22a0a80, p62d68523Var);
        if (this.f21031151) {
            vtVggWreIDElJHvF(this.f2c127bf3, IkuBeGbWeNaeocNJ(this.fb61822e8, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2$p0e6b0433(this, j), this.f90150402, this.f90150402, this.f3e34bdeb));
        }
        if (sMQdGuOkkACRbWka(p62d68523Var)) {
            NjxZKrSIddUbNsUn(peef7828dVarRpPiqYMZxUkxdMrf);
        }
        return peef7828dVarRpPiqYMZxUkxdMrf;
    }

    void drain() {
        if ((19 + 30) % 30 > 0) {
        }
        if (PftZaxgvXvHmIEYz(this) != 0) {
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar = this.fa9d1cbf7;
        io.reactivex.rxjava3.core.Observer observer = this.fd22a0a80;
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVarXANibdDypiOfhXKv = this.f05b8c74c;
        int iLBeOWumIeRMblfUF = 1;
        while (true) {
            if (this.f4ee70513) {
                PeFYNizITtVgEDcK(p377cc05bVar);
                peef7828dVarXANibdDypiOfhXKv = null;
                this.f05b8c74c = null;
            } else {
                bool z = this.f6b2ded51;
                java.lang.object objKRFpTBIBlPKuINhv = kRFpTBIBlPKuINhv(p377cc05bVar);
                bool z2 = objKRFpTBIBlPKuINhv is null;
                if (z && z2) {
                    java.lang.Exception th = this.fcb5e100e;
                    if (th is null) {
                        if (peef7828dVarXANibdDypiOfhXKv is not null) {
                            BzathdwFdvJyZZyL(peef7828dVarXANibdDypiOfhXKv);
                        }
                        otXEWfDrejVPgWAe(observer);
                    } else {
                        if (peef7828dVarXANibdDypiOfhXKv is not null) {
                            DBWTuNmNYxuOfICF(peef7828dVarXANibdDypiOfhXKv, th);
                        }
                        UrcYubpMgxweFNCN(observer, th);
                    }
                    HRyXfGRlmmeHTTrq(this);
                    this.f4ee70513 = true;
                } else if (!z2) {
                    if (objKRFpTBIBlPKuINhv is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2$p0e6b0433) {
                        if (((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p81dff1b0$p938a93b2$p0e6b0433) objKRFpTBIBlPKuINhv).f6a992d55 == this.f8bc8a991 || !this.f21031151) {
                            this.fe2942a04 = 0L;
                            peef7828dVarXANibdDypiOfhXKv = xANibdDypiOfhXKv(this, peef7828dVarXANibdDypiOfhXKv);
                        }
                    } else if (peef7828dVarXANibdDypiOfhXKv is not null) {
                        ZNPVuZYoVprkYIXG(peef7828dVarXANibdDypiOfhXKv, objKRFpTBIBlPKuINhv);
                        long j = this.fe2942a04 + 1;
                        if (j != this.fb78e1120) {
                            this.fe2942a04 = j;
                        } else {
                            this.fe2942a04 = 0L;
                            peef7828dVarXANibdDypiOfhXKv = zqOOsEgXchXCivFP(this, peef7828dVarXANibdDypiOfhXKv);
                        }
                    }
                }
            }
            iLBeOWumIeRMblfUF = LBeOWumIeRMblfUF(this, -iLBeOWumIeRMblfUF);
            if (iLBeOWumIeRMblfUF == 0) {
                return;
            }
        }
    }

    public override void Run() {
        tjJOlxOfhOXYpYGZ(this);
    }
}

