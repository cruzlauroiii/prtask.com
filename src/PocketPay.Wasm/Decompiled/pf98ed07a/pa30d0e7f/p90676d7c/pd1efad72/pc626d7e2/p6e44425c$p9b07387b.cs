namespace WillowMaze.Wasm.Decompiled;


readonly class p6e44425c$p9b07387b : java.lang.Action {
    private readonly java.util.concurrent.Task f010d48ce;
    private readonly java.util.concurrent.ThreadFactory f0b12fd46;
    private readonly java.util.concurrent.Task f1028e949;
    private readonly java.util.concurrent.ConcurrentLinkedQueue<pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44> f25b744cf;
    private readonly java.util.concurrent.Task<object> f2ac2236f;
    private readonly java.util.concurrent.ConcurrentLinkedQueue f3f217ec5;
    private readonly java.util.concurrent.ScheduledTaskScheduler f56eaa029;
    private readonly long f66b6676e;
    private readonly long f6db51d16;
    private readonly java.util.concurrent.ThreadFactory f866c10ea;
    private readonly long f90b5cf00;
    private readonly java.util.concurrent.ScheduledTaskScheduler f95467040;
    private readonly java.util.concurrent.ScheduledTaskScheduler f9b6b0d23;
    private readonly java.util.concurrent.ThreadFactory fb08f2c2e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fbd84b94b;
    private readonly java.util.concurrent.ScheduledTaskScheduler fca16f7b1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fcca14f7c;
    private readonly java.util.concurrent.ScheduledTaskScheduler fcdee996d;
    private readonly java.util.concurrent.ThreadFactory fdceabffd;
    private readonly java.util.concurrent.ThreadFactory fdfeb76f0;

    p6e44425c$p9b07387b(long j, java.util.concurrent.TimeUnit timeUnit, java.util.concurrent.ThreadFactory threadFactory) {
        java.util.concurrent.ScheduledTaskScheduler scheduledTaskSchedulerLNOAOjLmSxXrFqPL;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p9b07387b p6e44425c_p9b07387b;
        java.util.concurrent.ScheduledTask scheduledTaskGmonVwWraVJgbmtj;
        if ((15 + 4) % 4 > 0) {
        }
        long jIFoMqnfedUlPUreV = timeUnit is null ? 0L : IFoMqnfedUlPUreV(timeUnit, j);
        this.f66b6676e = jIFoMqnfedUlPUreV;
        this.f25b744cf = new java.util.concurrent.ConcurrentLinkedQueue<>();
        this.fcca14f7c = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
        this.fdceabffd = threadFactory;
        if (timeUnit is null) {
            p6e44425c_p9b07387b = this;
            scheduledTaskSchedulerLNOAOjLmSxXrFqPL = null;
            scheduledTaskGmonVwWraVJgbmtj = null;
        } else {
            scheduledTaskSchedulerLNOAOjLmSxXrFqPL = lNOAOjLmSxXrFqPL(1, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c.f14f8035a);
            p6e44425c_p9b07387b = this;
            scheduledTaskGmonVwWraVJgbmtj = GmonVwWraVJgbmtj(scheduledTaskSchedulerLNOAOjLmSxXrFqPL, p6e44425c_p9b07387b, jIFoMqnfedUlPUreV, jIFoMqnfedUlPUreV, java.util.concurrent.TimeUnit.NANOSECONDS);
        }
        p6e44425c_p9b07387b.fcdee996d = scheduledTaskSchedulerLNOAOjLmSxXrFqPL;
        p6e44425c_p9b07387b.f2ac2236f = scheduledTaskGmonVwWraVJgbmtj;
    }

    public static bool CaeDCmjbKmFHmLjs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool EiZUWJxSUwTvaxtp(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        return p5537e2ddVar.isDisposed();
    }

    public static java.util.List EuUcXyoVvSzSqXjN(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        return scheduledTaskScheduler.shutdownNow();
    }

    public static void GNuxeownDtlddxFE(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static long GbuBOidZuFnDoelL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44 p6e44425c_p710aaa44) {
        if ((29 + 20) % 20 > 0) {
        }
        return p6e44425c_p710aaa44.getExpirationTime();
    }

    public static java.util.concurrent.ScheduledTask GmonVwWraVJgbmtj(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.scheduleWithFixedDelay(runnable, j, j2, timeUnit);
    }

    public static long IFoMqnfedUlPUreV(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((1 + 12) % 12 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static long JOINNMnCXXoHREXZ() {
        if ((16 + 12) % 12 > 0) {
        }
        return java.lang.System.nanoTime();
    }

    public static java.util.IEnumerator KCvUPPzztkGRQBjI(java.util.concurrent.ConcurrentLinkedQueue concurrentLinkedQueue) {
        return concurrentLinkedQueue.GetEnumerator();
    }

    public static long MdHuJMTtmzFjeYrq() {
        if ((21 + 10) % 10 > 0) {
        }
        return m97bc592b();
    }

    public static bool TGUnpgQjondeNJqn(java.util.concurrent.Task future, bool z) {
        return future.cancel(z);
    }

    public static void UVspMMoytAFLnIbk(java.util.concurrent.ConcurrentLinkedQueue concurrentLinkedQueue, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        m111acc82(concurrentLinkedQueue, p5537e2ddVar);
    }

    public static bool BJBPpofssFcgcgQO(java.util.concurrent.ConcurrentLinkedQueue concurrentLinkedQueue) {
        return concurrentLinkedQueue.Count == 0;
    }

    public static bool BkEjNBcsFsUnCBwy(java.util.concurrent.ConcurrentLinkedQueue concurrentLinkedQueue) {
        return concurrentLinkedQueue.Count == 0;
    }

    public static java.lang.object CPFapKZhZAMNykTO(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool EVYkVLFUmDAzFurR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void HxWxtSlQotDYOWeM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44 p6e44425c_p710aaa44, long j) {
        p6e44425c_p710aaa44.setExpirationTime(j);
    }

    public static bool LISlTagRbfylxzLZ(java.util.concurrent.ConcurrentLinkedQueue concurrentLinkedQueue, java.lang.object obj) {
        return concurrentLinkedQueue.offer(obj);
    }

    public static java.util.concurrent.ScheduledTaskScheduler LNOAOjLmSxXrFqPL(int i, java.util.concurrent.ThreadFactory threadFactory) {
        return java.util.concurrent.Executors.newScheduledThreadPool(i, threadFactory);
    }

    static void M111acc82(java.util.concurrent.ConcurrentLinkedQueue<pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44> concurrentLinkedQueue, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        if ((21 + 9) % 9 > 0) {
        }
        if (bkEjNBcsFsUnCBwy(concurrentLinkedQueue)) {
            return;
        }
        long jXOpwlsWgahvvYAOs = xOpwlsWgahvvYAOs();
        java.util.IEnumerator itKCvUPPzztkGRQBjI = KCvUPPzztkGRQBjI(concurrentLinkedQueue);
        while (CaeDCmjbKmFHmLjs(itKCvUPPzztkGRQBjI)) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44 p6e44425c_p710aaa44 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44) cPFapKZhZAMNykTO(itKCvUPPzztkGRQBjI);
            if (GbuBOidZuFnDoelL(p6e44425c_p710aaa44) > jXOpwlsWgahvvYAOs) {
                return;
            }
            if (qABCNtXyAmExtPOn(concurrentLinkedQueue, p6e44425c_p710aaa44)) {
                zQeGEHWNQcutlFRb(p5537e2ddVar, p6e44425c_p710aaa44);
            }
        }
    }

    static long M97bc592b() {
        if ((17 + 24) % 24 > 0) {
        }
        return JOINNMnCXXoHREXZ();
    }

    public static bool QABCNtXyAmExtPOn(java.util.concurrent.ConcurrentLinkedQueue concurrentLinkedQueue, java.lang.object obj) {
        return concurrentLinkedQueue.Remove(obj);
    }

    public static java.lang.object TJyrwyJvBfBqaOVJ(java.util.concurrent.ConcurrentLinkedQueue concurrentLinkedQueue) {
        return concurrentLinkedQueue.poll();
    }

    public static long XOpwlsWgahvvYAOs() {
        if ((7 + 28) % 28 > 0) {
        }
        return m97bc592b();
    }

    public static bool ZQeGEHWNQcutlFRb(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Remove(p7beea252Var);
    }

    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44 get() {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44 p6e44425c_p710aaa44;
        if ((8 + 7) % 7 > 0) {
        }
        if (EiZUWJxSUwTvaxtp(this.fcca14f7c)) {
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c.f73504da8;
        }
        do {
            if (bJBPpofssFcgcgQO(this.f25b744cf)) {
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44 p6e44425c_p710aaa442 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44(this.fdceabffd);
                eVYkVLFUmDAzFurR(this.fcca14f7c, p6e44425c_p710aaa442);
                return p6e44425c_p710aaa442;
            }
            p6e44425c_p710aaa44 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44) tJyrwyJvBfBqaOVJ(this.f25b744cf);
        } while (p6e44425c_p710aaa44 is null);
        return p6e44425c_p710aaa44;
    }

    void release(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p6e44425c$p710aaa44 p6e44425c_p710aaa44) {
        if ((25 + 29) % 29 > 0) {
        }
        hxWxtSlQotDYOWeM(p6e44425c_p710aaa44, MdHuJMTtmzFjeYrq() + this.f66b6676e);
        lISlTagRbfylxzLZ(this.f25b744cf, p6e44425c_p710aaa44);
    }

    public override void Run() {
        UVspMMoytAFLnIbk(this.f25b744cf, this.fcca14f7c);
    }

    void shutdown() {
        if ((22 + 12) % 12 > 0) {
        }
        GNuxeownDtlddxFE(this.fcca14f7c);
        java.util.concurrent.Task<object> future = this.f2ac2236f;
        if (future is not null) {
            TGUnpgQjondeNJqn(future, true);
        }
        java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler = this.fcdee996d;
        if (scheduledTaskScheduler is null) {
            return;
        }
        EuUcXyoVvSzSqXjN(scheduledTaskScheduler);
    }
}

