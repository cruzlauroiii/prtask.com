namespace WillowMaze.Wasm.Decompiled;


public readonly class pfbbd46e6 : io.reactivex.rxjava3.core.Scheduler {
    readonly bool f01e8dc39;
    readonly java.util.concurrent.Executor f1e58af62;
    readonly bool f27d840aa;
    readonly bool f6523f016;
    readonly bool f6efcf8d5;
    readonly bool fadb5e027;
    readonly java.util.concurrent.Executor fb1925939;
    readonly bool fd30279df;
    readonly bool fe03ca8c8;
    readonly bool ff4121a5a;
    readonly bool ff4c1f7a6;

    public pfbbd46e6(java.util.concurrent.Executor executor, bool z, bool z2) {
        this.fb1925939 = executor;
        this.f6efcf8d5 = z;
        this.ff4121a5a = z2;
    }

    public static java.util.concurrent.ScheduledTask AASTyszYuOQueyxw(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.schedule(callable, j, timeUnit);
    }

    public static void KSMUerzlOiISbANU(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.util.concurrent.ScheduledTask MoyCBxuUSFgwkyue(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.scheduleAtFixedRate(runnable, j, j2, timeUnit);
    }

    public static void NNjExxfxBabUDoDM(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 OGbvQkxEIInvSEEa(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return super.schedulePeriodicallyDirect(runnable, j, j2, timeUnit);
    }

    public static void RQcOWXmEBaYDsugd(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static bool YDdkGrcSzeHkEaHW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static java.util.concurrent.Task DdlqxSFWPWbYxHoe(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.Func callable) {
        return executorService.submit(callable);
    }

    public static void ECNjNmegZCbhAlSc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void GtyOLMtgtpMSxeGG(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static java.lang.Action IezuafrUnQQDDWwK(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static void KhZzFRKrenWsIYNM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5d637c2e p5d637c2eVar, java.util.concurrent.Task future) {
        p5d637c2eVar.setTask(future);
    }

    public static void LFwRvrRdhHzWGkgS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799 p4637c799Var, java.util.concurrent.Task future) {
        p4637c799Var.setTask(future);
    }

    public static java.lang.Action RxlYzQSZMovjBNRQ(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static void VvhSaoPslcfKeuXP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799 p4637c799Var, java.util.concurrent.Task future) {
        p4637c799Var.setTask(future);
    }

    public static java.lang.Action XmUqASQxGLbRQKME(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 YzMVeXWnZavoihkW(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.scheduleDirect(runnable, j, timeUnit);
    }

    public io.reactivex.rxjava3.core.Scheduler$Worker createWorker() {
        if ((5 + 10) % 10 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p8095f997(this.fb1925939, this.f6efcf8d5, this.ff4121a5a);
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ScheduleDirect(java.lang.Action runnable) {
        if ((2 + 31) % 31 > 0) {
        }
        java.lang.Action runnableRxlYzQSZMovjBNRQ = rxlYzQSZMovjBNRQ(runnable);
        try {
            if (this.fb1925939 is java.util.concurrent.TaskScheduler) {
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799 p4637c799Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799(runnableRxlYzQSZMovjBNRQ, this.f6efcf8d5);
                vvhSaoPslcfKeuXP(p4637c799Var, ddlqxSFWPWbYxHoe((java.util.concurrent.TaskScheduler) this.fb1925939, p4637c799Var));
                return p4637c799Var;
            }
            if (this.f6efcf8d5) {
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p8095f997$p1160e21f pfbbd46e6_p8095f997_p1160e21f = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p8095f997$p1160e21f(runnableRxlYzQSZMovjBNRQ, null);
                RQcOWXmEBaYDsugd(this.fb1925939, pfbbd46e6_p8095f997_p1160e21f);
                return pfbbd46e6_p8095f997_p1160e21f;
            }
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p8095f997$p7a24a60d pfbbd46e6_p8095f997_p7a24a60d = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p8095f997$p7a24a60d(runnableRxlYzQSZMovjBNRQ);
            gtyOLMtgtpMSxeGG(this.fb1925939, pfbbd46e6_p8095f997_p7a24a60d);
            return pfbbd46e6_p8095f997_p7a24a60d;
        } catch (java.util.concurrent.RejectedExecutionException e) {
            eCNjNmegZCbhAlSc(e);
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ScheduleDirect(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((7 + 22) % 22 > 0) {
        }
        java.lang.Action runnableIezuafrUnQQDDWwK = iezuafrUnQQDDWwK(runnable);
        if (!(this.fb1925939 is java.util.concurrent.ScheduledTaskScheduler)) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p5a95c67c pfbbd46e6_p5a95c67c = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p5a95c67c(runnableIezuafrUnQQDDWwK);
            YDdkGrcSzeHkEaHW(pfbbd46e6_p5a95c67c.f6c86eb53, yzMVeXWnZavoihkW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$pbc32f790.f8d727b17, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pfbbd46e6$p14aafbed(this, pfbbd46e6_p5a95c67c), j, timeUnit));
            return pfbbd46e6_p5a95c67c;
        }
        try {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799 p4637c799Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p4637c799(runnableIezuafrUnQQDDWwK, this.f6efcf8d5);
            lFwRvrRdhHzWGkgS(p4637c799Var, AASTyszYuOQueyxw((java.util.concurrent.ScheduledTaskScheduler) this.fb1925939, p4637c799Var, j, timeUnit));
            return p4637c799Var;
        } catch (java.util.concurrent.RejectedExecutionException e) {
            NNjExxfxBabUDoDM(e);
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 SchedulePeriodicallyDirect(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        if ((27 + 2) % 2 > 0) {
        }
        if (!(this.fb1925939 is java.util.concurrent.ScheduledTaskScheduler)) {
            return OGbvQkxEIInvSEEa(this, runnable, j, j2, timeUnit);
        }
        try {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5d637c2e p5d637c2eVar = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p5d637c2e(xmUqASQxGLbRQKME(runnable), this.f6efcf8d5);
            khZzFRKrenWsIYNM(p5d637c2eVar, MoyCBxuUSFgwkyue((java.util.concurrent.ScheduledTaskScheduler) this.fb1925939, p5d637c2eVar, j, j2, timeUnit));
            return p5d637c2eVar;
        } catch (java.util.concurrent.RejectedExecutionException e) {
            KSMUerzlOiISbANU(e);
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
    }
}

