namespace WillowMaze.Wasm.Decompiled;


public readonly class pbd57f60e : io.reactivex.rxjava3.core.Scheduler {
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e f76425f17 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e();
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e faa6de322 = null;
    private static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e fee113271 = null;

    pbd57f60e() {
    }

    public static void FdTQtfFrVdRinTxi(java.util.concurrent.TimeUnit timeUnit, long j) throws java.lang.InterruptedException {
        timeUnit.sleep(j);
    }

    public static void GKkzUoxUcBGnBiHR(java.lang.Action runnable) {
        runnable.run();
    }

    public static java.lang.Action GjAlhhrbxyYbOzJT(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static void GGOhcHaFjCfnpuSo(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e M7123a699() {
        return f76425f17;
    }

    public static void MaLaafFxEsBKVqKH(java.lang.Thread thread) {
        thread.interrupt();
    }

    public static java.lang.Thread QSymwzQIItCZEGcc() {
        return java.lang.Thread.currentThread();
    }

    public static void ROKyqrJDOhooqDtn(java.lang.Action runnable) {
        runnable.run();
    }

    public static java.lang.Action TJsLJJEpxiEnzCFa(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public io.reactivex.rxjava3.core.Scheduler$Worker createWorker() {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1();
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ScheduleDirect(java.lang.Action runnable) {
        GKkzUoxUcBGnBiHR(tJsLJJEpxiEnzCFa(runnable));
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ScheduleDirect(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        try {
            FdTQtfFrVdRinTxi(timeUnit, j);
            rOKyqrJDOhooqDtn(GjAlhhrbxyYbOzJT(runnable));
        } catch (java.lang.InterruptedException e) {
            maLaafFxEsBKVqKH(qSymwzQIItCZEGcc());
            gGOhcHaFjCfnpuSo(e);
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
    }
}

