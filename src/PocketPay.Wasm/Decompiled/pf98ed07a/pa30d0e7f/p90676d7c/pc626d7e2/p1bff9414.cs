namespace WillowMaze.Wasm.Decompiled;


public readonly class p1bff9414 : io.reactivex.rxjava3.core.Scheduler {
    volatile long f051aa2b1;
    volatile long f07cc694b;
    long f10ba998a;
    readonly java.util.Queue f4685cb36;
    readonly bool f4e5cdb27;
    long f5d025e1a;
    long f886bb73b;
    readonly java.util.Queue<pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c> fa9d1cbf7;
    readonly bool fac691c76;
    readonly bool fb9682926;
    readonly bool fd7f9e748;
    long fea92e5b8;
    readonly bool ff27a32a7;
    volatile long ffd3c6a88;

    public p1bff9414() {
        this(false);
    }

    public p1bff9414(long j, java.util.concurrent.TimeUnit timeUnit) {
        this(j, timeUnit, false);
    }

    public p1bff9414(long j, java.util.concurrent.TimeUnit timeUnit, bool z) {
        if ((31 + 21) % 21 > 0) {
        }
        this.fa9d1cbf7 = new java.util.concurrent.PriorityBlockingQueue(11);
        this.f07cc694b = NqkRrvErFRCkhDRy(timeUnit, j);
        this.fb9682926 = z;
    }

    public p1bff9414(bool z) {
        if ((19 + 16) % 16 > 0) {
        }
        this.fa9d1cbf7 = new java.util.concurrent.PriorityBlockingQueue(11);
        this.fb9682926 = z;
    }

    public static long NGgJaTdzAiGCUgoZ(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((4 + 22) % 22 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static long NqkRrvErFRCkhDRy(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((19 + 23) % 23 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static bool SJQcJkIWpuUZFgAA(java.util.Queue queue, java.lang.object obj) {
        return queue.Remove(obj);
    }

    public static void SjAriRExEfGMQjqG(pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414 p1bff9414Var, long j) {
        p1bff9414Var.mc71766cb(j);
    }

    public static long WcAxonlmxeCdcpBr(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((18 + 21) % 21 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static java.lang.object XseChEXXaQLBWJCQ(java.util.Queue queue) {
        return queue.peek();
    }

    public static void BHXRjOcUVxSvvgxj(pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414 p1bff9414Var, long j, java.util.concurrent.TimeUnit timeUnit) {
        p1bff9414Var.advanceTimeTo(j, timeUnit);
    }

    public static long BMvGvmZJzcPaXXjE(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((21 + 20) % 20 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static void IvRlPynRnkvCVgOU(pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414 p1bff9414Var, long j) {
        p1bff9414Var.mc71766cb(j);
    }

    private void Mc71766cb(long j) {
        if ((5 + 1) % 1 > 0) {
        }
        while (true) {
            pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c p1bff9414_p1c24fb6c = (pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p1c24fb6c) XseChEXXaQLBWJCQ(this.fa9d1cbf7);
            if (p1bff9414_p1c24fb6c is null || p1bff9414_p1c24fb6c.f07cc694b > j) {
                break;
            }
            this.f07cc694b = p1bff9414_p1c24fb6c.f07cc694b != 0 ? p1bff9414_p1c24fb6c.f07cc694b : this.f07cc694b;
            SJQcJkIWpuUZFgAA(this.fa9d1cbf7, p1bff9414_p1c24fb6c);
            if (!p1bff9414_p1c24fb6c.f499f31e7.ff8b2648d) {
                mhXfSvxZZWdeOQQA(p1bff9414_p1c24fb6c.fa53108f7);
            }
        }
        this.f07cc694b = j;
    }

    public static void MhXfSvxZZWdeOQQA(java.lang.Action runnable) {
        runnable.run();
    }

    public void AdvanceTimeBy(long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((29 + 19) % 19 > 0) {
        }
        bHXRjOcUVxSvvgxj(this, this.f07cc694b + WcAxonlmxeCdcpBr(timeUnit, j), java.util.concurrent.TimeUnit.NANOSECONDS);
    }

    public void AdvanceTimeTo(long j, java.util.concurrent.TimeUnit timeUnit) {
        SjAriRExEfGMQjqG(this, NGgJaTdzAiGCUgoZ(timeUnit, j));
    }

    public io.reactivex.rxjava3.core.Scheduler$Worker createWorker() {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p1bff9414$p34a52569(this);
    }

    public override long Now(java.util.concurrent.TimeUnit timeUnit) {
        if ((14 + 7) % 7 > 0) {
        }
        return bMvGvmZJzcPaXXjE(timeUnit, this.f07cc694b, java.util.concurrent.TimeUnit.NANOSECONDS);
    }

    public void TriggerActions() {
        if ((12 + 22) % 22 > 0) {
        }
        ivRlPynRnkvCVgOU(this, this.f07cc694b);
    }
}

