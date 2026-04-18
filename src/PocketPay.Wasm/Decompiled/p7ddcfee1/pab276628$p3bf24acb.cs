namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0005\u001a\u00020\u0006H\u0016J\u0018\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\bH\u0016J\b\u0010\u0003\u001a\u00020\u0004H\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp7ddcfee1/pab276628$p3bf24acb;", "Lp38cb8f46/pf31bbdd1;", "(Lp7ddcfee1/pab276628;)V", "timeout", "Lp38cb8f46/pc85a251c;", "close", "", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class pab276628$p3bf24acb : p38cb8f46.pf31bbdd1 {
    private readonly p38cb8f46.pc85a251c f3cf24b54;
    private readonly p38cb8f46.pc85a251c f90272dda;
    readonly p7ddcfee1.pab276628 this$0;

    public pab276628$p3bf24acb(p7ddcfee1.pab276628 this$0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        this.this$0 = this$0;
        this.f90272dda = new p38cb8f46.pc85a251c();
    }

    public override void Close() {
        if (kotlin.jvm.internal.Intrinsics.areEqual(p7ddcfee1.pab276628.m9e05c510(this.this$0), this)) {
            p7ddcfee1.pab276628.m9a8561e6(this.this$0, null);
        }
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) {
        if ((23 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        if (byteCount < 0) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("byteCount < 0: ", java.lang.long.valueOf(byteCount)).tostring());
        }
        if (!kotlin.jvm.internal.Intrinsics.areEqual(p7ddcfee1.pab276628.m9e05c510(this.this$0), this)) {
            throw new java.lang.IllegalStateException("closed".tostring());
        }
        p38cb8f46.pc85a251c pc85a251cVarTimeout = p7ddcfee1.pab276628.m8c618f64(this.this$0).timeout();
        p38cb8f46.pc85a251c pc85a251cVar = this.f90272dda;
        p7ddcfee1.pab276628 pab276628Var = this.this$0;
        long jTimeoutNanos = pc85a251cVarTimeout.timeoutNanos();
        pc85a251cVarTimeout.timeout(p38cb8f46.pc85a251c.f910eef8c.minTimeout(pc85a251cVar.timeoutNanos(), pc85a251cVarTimeout.timeoutNanos()), java.util.concurrent.TimeUnit.NANOSECONDS);
        if (!pc85a251cVarTimeout.hasDeadline()) {
            if (pc85a251cVar.hasDeadline()) {
                pc85a251cVarTimeout.deadlineNanoTime(pc85a251cVar.deadlineNanoTime());
            }
            try {
                long jM33e914cf = p7ddcfee1.pab276628.m33e914cf(pab276628Var, byteCount);
                long j = jM33e914cf == 0 ? -1L : p7ddcfee1.pab276628.m8c618f64(pab276628Var).read(sink, jM33e914cf);
                pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                if (pc85a251cVar.hasDeadline()) {
                    pc85a251cVarTimeout.clearDeadline();
                }
                return j;
            } catch (java.lang.Exception th) {
                pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                if (pc85a251cVar.hasDeadline()) {
                    pc85a251cVarTimeout.clearDeadline();
                }
                throw th;
            }
        }
        long jDeadlineNanoTime = pc85a251cVarTimeout.deadlineNanoTime();
        if (pc85a251cVar.hasDeadline()) {
            pc85a251cVarTimeout.deadlineNanoTime(java.lang.Math.min(pc85a251cVarTimeout.deadlineNanoTime(), pc85a251cVar.deadlineNanoTime()));
        }
        try {
            long jM33e914cf2 = p7ddcfee1.pab276628.m33e914cf(pab276628Var, byteCount);
            long j2 = jM33e914cf2 == 0 ? -1L : p7ddcfee1.pab276628.m8c618f64(pab276628Var).read(sink, jM33e914cf2);
            pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
            if (pc85a251cVar.hasDeadline()) {
                pc85a251cVarTimeout.deadlineNanoTime(jDeadlineNanoTime);
            }
            return j2;
        } catch (java.lang.Exception th2) {
            pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
            if (pc85a251cVar.hasDeadline()) {
                pc85a251cVarTimeout.deadlineNanoTime(jDeadlineNanoTime);
            }
            throw th2;
        }
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f90272dda;
    }
}

