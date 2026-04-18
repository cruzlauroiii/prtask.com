namespace WillowMaze.Wasm.Decompiled;


readonly class p1bff9414$p34a52569 : io.reactivex.rxjava3.core.Scheduler$Worker {
    volatile bool f44cb5577;
    volatile bool f48f431f3;
    volatile bool ff8b2648d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414 this$0;

    p1bff9414$p34a52569(pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414 p1bff9414Var) {
        this.this$0 = p1bff9414Var;
    }

    public static bool EiaWjJpPSMieioKZ(java.util.Queue queue, java.lang.object obj) {
        return queue.Add(obj);
    }

    public static long ScztnLrYLxAnpDGf(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((1 + 26) % 26 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static java.lang.Action FGBNPZTxHXgHHOKP(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static java.lang.Action RpxcTSMeSOSwuOyh(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static bool YBmTNwPMTxgmgYQK(java.util.Queue queue, java.lang.object obj) {
        return queue.Add(obj);
    }

    public static long ZlgrSRSTpkVjaScS(pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414 p1bff9414Var, java.util.concurrent.TimeUnit timeUnit) {
        if ((13 + 24) % 24 > 0) {
        }
        return p1bff9414Var.now(timeUnit);
    }

    public override void Dispose() {
        this.ff8b2648d = true;
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public override long Now(java.util.concurrent.TimeUnit timeUnit) {
        return zlgrSRSTpkVjaScS(this.this$0, timeUnit);
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable) {
        if ((17 + 26) % 26 > 0) {
        }
        if (this.ff8b2648d) {
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
        if (this.this$0.fb9682926) {
            runnable = fGBNPZTxHXgHHOKP(runnable);
        }
        java.lang.Action runnable2 = runnable;
        pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414 p1bff9414Var = this.this$0;
        long j = p1bff9414Var.f886bb73b;
        p1bff9414Var.f886bb73b = 1 + j;
        pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c p1bff9414_p1c24fb6c = new pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c(this, 0L, runnable2, j);
        EiaWjJpPSMieioKZ(this.this$0.fa9d1cbf7, p1bff9414_p1c24fb6c);
        return new pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p34a52569$p8807d389(this, p1bff9414_p1c24fb6c);
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((23 + 27) % 27 > 0) {
        }
        if (this.ff8b2648d) {
            return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.f76425f17;
        }
        if (this.this$0.fb9682926) {
            runnable = rpxcTSMeSOSwuOyh(runnable);
        }
        java.lang.Action runnable2 = runnable;
        long jScztnLrYLxAnpDGf = this.this$0.f07cc694b + ScztnLrYLxAnpDGf(timeUnit, j);
        pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414 p1bff9414Var = this.this$0;
        long j2 = p1bff9414Var.f886bb73b;
        p1bff9414Var.f886bb73b = 1 + j2;
        pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c p1bff9414_p1c24fb6c = new pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c(this, jScztnLrYLxAnpDGf, runnable2, j2);
        yBmTNwPMTxgmgYQK(this.this$0.fa9d1cbf7, p1bff9414_p1c24fb6c);
        return new pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p34a52569$p8807d389(this, p1bff9414_p1c24fb6c);
    }
}

