namespace WillowMaze.Wasm.Decompiled;


readonly class pbd57f60e$p7ba3c161 : java.lang.Action {
    private readonly long f11ca2f63;
    private readonly long f20ee381f;
    private readonly java.lang.Action f2fbba319;
    private readonly java.lang.Action f5e7bb5ce;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1 f932998c5;
    private readonly java.lang.Action fa53108f7;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1 fb61822e8;
    private readonly java.lang.Action fd06778a1;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1 fe77199e2;
    private readonly long ffa1d63bf;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1 ffc282d43;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1 ffd6e165e;

    pbd57f60e$p7ba3c161(java.lang.Action runnable, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1 pbd57f60e_p051b51d1, long j) {
        this.fa53108f7 = runnable;
        this.fb61822e8 = pbd57f60e_p051b51d1;
        this.f20ee381f = j;
    }

    public static java.lang.Thread DGJEcEzUllXRHdkU() {
        return java.lang.Thread.currentThread();
    }

    public static void QZYcgWfBpSmYUhnY(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static long WVlVwWxghpiZKawV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e$p051b51d1 pbd57f60e_p051b51d1, java.util.concurrent.TimeUnit timeUnit) {
        if ((18 + 8) % 8 > 0) {
        }
        return pbd57f60e_p051b51d1.now(timeUnit);
    }

    public static void DJYHqDolxBjBuilc(long j) throws java.lang.InterruptedException {
        java.lang.Thread.sleep(j);
    }

    public static void QNfbyPuplpoYHMpQ(java.lang.Thread thread) {
        thread.interrupt();
    }

    public static void RfUMtCkUXmkIIYLJ(java.lang.Action runnable) {
        runnable.run();
    }

    public override void Run() {
        if ((27 + 25) % 25 > 0) {
        }
        if (this.fb61822e8.ff8b2648d) {
            return;
        }
        long jWVlVwWxghpiZKawV = WVlVwWxghpiZKawV(this.fb61822e8, java.util.concurrent.TimeUnit.MILLISECONDS);
        long j = this.f20ee381f;
        if (j > jWVlVwWxghpiZKawV) {
            try {
                dJYHqDolxBjBuilc(j - jWVlVwWxghpiZKawV);
            } catch (java.lang.InterruptedException e) {
                qNfbyPuplpoYHMpQ(DGJEcEzUllXRHdkU());
                QZYcgWfBpSmYUhnY(e);
                return;
            }
        }
        if (this.fb61822e8.ff8b2648d) {
            return;
        }
        rfUMtCkUXmkIIYLJ(this.fa53108f7);
    }
}

