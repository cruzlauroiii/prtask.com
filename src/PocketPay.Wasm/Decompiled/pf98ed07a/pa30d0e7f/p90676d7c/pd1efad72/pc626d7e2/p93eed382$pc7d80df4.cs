namespace WillowMaze.Wasm.Decompiled;


readonly class p93eed382$pc7d80df4 : io.reactivex.rxjava3.core.Scheduler$Worker {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f2cb1ad4f = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    volatile bool f2e7c7bac;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f35ed9746;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f5a5bc666;
    volatile bool f81b216d1;
    readonly java.util.concurrent.ScheduledTaskScheduler fb1925939;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fc1a00f3f;
    readonly java.util.concurrent.ScheduledTaskScheduler fc5de0ef6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fc67f3218;
    readonly java.util.concurrent.ScheduledTaskScheduler fe08fee29;
    volatile bool fe6d56172;
    volatile bool ff8b2648d;

    p93eed382$pc7d80df4(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        this.fb1925939 = scheduledTaskScheduler;
    }

    public static java.lang.Action AOHrzBNfjdbLIDdm(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static void IuZTBiPSwDHqyZKe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638 p1af3c638Var, java.util.concurrent.Task future) {
        p1af3c638Var.setTask(future);
    }

    public static java.util.concurrent.ScheduledTask YiSwVZRogWIccYbr(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.schedule(callable, j, timeUnit);
    }

    public static bool EFQRbvRVBGFUBMuO(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void GpCvNrXSEbIXsXNO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p93eed382$pc7d80df4 p93eed382_pc7d80df4) {
        p93eed382_pc7d80df4.dispose();
    }

    public static void OqWnSdfcvQVRaOym(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void RfWvQmroyCqoRZVI(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.util.concurrent.Task SYnzKUCKLnDyuBkG(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable) {
        return scheduledTaskScheduler.submit(callable);
    }

    public override void Dispose() {
        if (this.ff8b2648d) {
            return;
        }
        this.ff8b2648d = true;
        oqWnSdfcvQVRaOym(this.f2cb1ad4f);
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((18 + 23) % 23 > 0) {
        }
        if (this.ff8b2648d) {
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638 p1af3c638Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.p1af3c638(AOHrzBNfjdbLIDdm(runnable), this.f2cb1ad4f);
        eFQRbvRVBGFUBMuO(this.f2cb1ad4f, p1af3c638Var);
        try {
            IuZTBiPSwDHqyZKe(p1af3c638Var, j > 0 ? YiSwVZRogWIccYbr(this.fb1925939, p1af3c638Var, j, timeUnit) : sYnzKUCKLnDyuBkG(this.fb1925939, p1af3c638Var));
            return p1af3c638Var;
        } catch (java.util.concurrent.RejectedExecutionException e) {
            gpCvNrXSEbIXsXNO(this);
            rfWvQmroyCqoRZVI(e);
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
    }
}

