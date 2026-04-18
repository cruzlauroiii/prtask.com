namespace WillowMaze.Wasm.Decompiled;


public class pe4a0e604 : io.reactivex.rxjava3.core.Scheduler$Worker : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    volatile bool f1911e09c;
    volatile bool f4044c3c3;
    private readonly java.util.concurrent.ScheduledTaskScheduler f63a75958;
    volatile bool f72aeec15;
    private readonly java.util.concurrent.ScheduledTaskScheduler fb1925939;
    volatile bool ff8b2648d;

    public pe4a0e604(java.util.concurrent.ThreadFactory threadFactory) {
        this.fb1925939 = sQNpoxmmjUbWSEzN(threadFactory);
    }

    public static void CWwEgIfiYHVSgXad(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799 p4637c799Var, java.util.concurrent.Task future) {
        p4637c799Var.setTask(future);
    }

    public static void DHBDvcXORjtwjevV(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        scheduledTaskScheduler.shutdown();
    }

    public static java.util.concurrent.Task FgBpbuZPmaAjfcTU(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable) {
        return scheduledTaskScheduler.submit(callable);
    }

    public static java.util.List HOWeYwMLMpfjdGog(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        return scheduledTaskScheduler.shutdownNow();
    }

    public static void HnFuxIMwgDYXheUc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool JlsOhVgHgGAhFOfd(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.padbc3aba padbc3abaVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return padbc3abaVar.Remove(p7beea252Var);
    }

    public static java.util.concurrent.ScheduledTask MkvdOLFyFaqQAtso(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.scheduleAtFixedRate(runnable, j, j2, timeUnit);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638 QlMBIkFtVpfJMLaL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pe4a0e604 pe4a0e604Var, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.padbc3aba padbc3abaVar) {
        return pe4a0e604Var.scheduleActual(runnable, j, timeUnit, padbc3abaVar);
    }

    public static bool UhEMyvIHhNBaurWC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.padbc3aba padbc3abaVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return padbc3abaVar.Add(p7beea252Var);
    }

    public static void YMLNcxdzCZyTlRvY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5d637c2e p5d637c2eVar, java.util.concurrent.Task future) {
        p5d637c2eVar.setTask(future);
    }

    public static void YpWVEFjSSWEyCFPz(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.Action ZNDfoAzAFndyCzWV(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static java.lang.Action AJhiTdwYtvsZjcPj(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 BedbOZRaDMEERiep(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pe4a0e604 pe4a0e604Var, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return pe4a0e604Var.schedule(runnable, j, timeUnit);
    }

    public static void CtVotxvAGcyiUUpf(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.util.concurrent.ScheduledTask DnVFsRNcgsSWQGVj(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.schedule(callable, j, timeUnit);
    }

    public static void FLyzvAoZSpQaYHxP(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.util.concurrent.Task GfHsAOzjDtWWqWeo(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable) {
        return scheduledTaskScheduler.submit(callable);
    }

    public static java.util.concurrent.ScheduledTask HIOtAKVKbympmjXl(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.schedule(callable, j, timeUnit);
    }

    public static java.util.concurrent.Task HiAkprlsYWUpPSdD(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable) {
        return scheduledTaskScheduler.submit(callable);
    }

    public static void KiwhuaUKdlkPfdOS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pc7039ca5 pc7039ca5Var, java.util.concurrent.Task future) {
        pc7039ca5Var.setFirst(future);
    }

    public static void QXePXDFlRoTJOVYX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638 p1af3c638Var, java.util.concurrent.Task future) {
        p1af3c638Var.setTask(future);
    }

    public static java.util.concurrent.ScheduledTaskScheduler SQNpoxmmjUbWSEzN(java.util.concurrent.ThreadFactory threadFactory) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p76922488.m76ea0beb(threadFactory);
    }

    public static java.util.concurrent.ScheduledTask TrkjOVYMCdDEFvTj(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.schedule(callable, j, timeUnit);
    }

    public static java.lang.Action ZmZsbOQPxXFkVKqd(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public override void Dispose() {
        if (this.ff8b2648d) {
            return;
        }
        this.ff8b2648d = true;
        HOWeYwMLMpfjdGog(this.fb1925939);
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable) {
        if ((13 + 21) % 21 > 0) {
        }
        return bedbOZRaDMEERiep(this, runnable, 0L, null);
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((13 + 23) % 23 > 0) {
        }
        return !this.ff8b2648d ? QlMBIkFtVpfJMLaL(this, runnable, j, timeUnit, null) : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
    }

    public pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638 ScheduleActual(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.padbc3aba padbc3abaVar) {
        if ((31 + 8) % 8 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638 p1af3c638Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638(aJhiTdwYtvsZjcPj(runnable), padbc3abaVar);
        if (padbc3abaVar is null || UhEMyvIHhNBaurWC(padbc3abaVar, p1af3c638Var)) {
            try {
                qXePXDFlRoTJOVYX(p1af3c638Var, j > 0 ? dnVFsRNcgsSWQGVj(this.fb1925939, p1af3c638Var, j, timeUnit) : FgBpbuZPmaAjfcTU(this.fb1925939, p1af3c638Var));
                return p1af3c638Var;
            } catch (java.util.concurrent.RejectedExecutionException e) {
                if (padbc3abaVar is not null) {
                    JlsOhVgHgGAhFOfd(padbc3abaVar, p1af3c638Var);
                }
                ctVotxvAGcyiUUpf(e);
            }
        }
        return p1af3c638Var;
    }

    public pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ScheduleDirect(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((11 + 26) % 26 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799 p4637c799Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799(zmZsbOQPxXFkVKqd(runnable), true);
        try {
            CWwEgIfiYHVSgXad(p4637c799Var, j > 0 ? trkjOVYMCdDEFvTj(this.fb1925939, p4637c799Var, j, timeUnit) : gfHsAOzjDtWWqWeo(this.fb1925939, p4637c799Var));
            return p4637c799Var;
        } catch (java.util.concurrent.RejectedExecutionException e) {
            YpWVEFjSSWEyCFPz(e);
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
    }

    public pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 SchedulePeriodicallyDirect(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        if ((6 + 21) % 21 > 0) {
        }
        java.lang.Action runnableZNDfoAzAFndyCzWV = ZNDfoAzAFndyCzWV(runnable);
        if (j2 > 0) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5d637c2e p5d637c2eVar = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5d637c2e(runnableZNDfoAzAFndyCzWV, true);
            try {
                YMLNcxdzCZyTlRvY(p5d637c2eVar, MkvdOLFyFaqQAtso(this.fb1925939, p5d637c2eVar, j, j2, timeUnit));
                return p5d637c2eVar;
            } catch (java.util.concurrent.RejectedExecutionException e) {
                fLyzvAoZSpQaYHxP(e);
                return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
            }
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pc7039ca5 pc7039ca5Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pc7039ca5(runnableZNDfoAzAFndyCzWV, this.fb1925939);
        try {
            kiwhuaUKdlkPfdOS(pc7039ca5Var, j > 0 ? hIOtAKVKbympmjXl(this.fb1925939, pc7039ca5Var, j, timeUnit) : hiAkprlsYWUpPSdD(this.fb1925939, pc7039ca5Var));
            return pc7039ca5Var;
        } catch (java.util.concurrent.RejectedExecutionException e2) {
            HnFuxIMwgDYXheUc(e2);
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
    }

    public void Shutdown() {
        if (this.ff8b2648d) {
            return;
        }
        this.ff8b2648d = true;
        DHBDvcXORjtwjevV(this.fb1925939);
    }
}

