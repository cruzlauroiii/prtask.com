namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0016\u0018\u0000 \u001c2\u00020\u0001:\u0001\u001cB\u0005¢\u0006\u0002\u0010\u0002J\u000e\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bJ\b\u0010\f\u001a\u00020\u0000H\u0016J\b\u0010\r\u001a\u00020\u0000H\u0016J\u0016\u0010\u000e\u001a\u00020\u00002\u0006\u0010\u000f\u001a\u00020\u00042\u0006\u0010\u0010\u001a\u00020\u0011J\b\u0010\u0003\u001a\u00020\u0004H\u0016J\u0010\u0010\u0003\u001a\u00020\u00002\u0006\u0010\u0003\u001a\u00020\u0004H\u0016J\b\u0010\u0005\u001a\u00020\u0006H\u0016J-\u0010\u0012\u001a\u0002H\u0013\"\u0004\b\u0000\u0010\u00132\u0006\u0010\u0014\u001a\u00020\u00002\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u0002H\u00130\u0016H\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\u0017J\b\u0010\u0018\u001a\u00020\tH\u0016J\u0018\u0010\u0019\u001a\u00020\u00002\u0006\u0010\u0019\u001a\u00020\u00042\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0007\u001a\u00020\u0004H\u0016J\u000e\u0010\u001a\u001a\u00020\t2\u0006\u0010\u001b\u001a\u00020\u0001R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u001d"}, d2 = {"Lp38cb8f46/pc85a251c;", "", "()V", "deadlineNanoTime", "", "hasDeadline", "", "timeoutNanos", "awaitSignal", "", "condition", "Ljava/util/concurrent/locks/Condition;", "clearDeadline", "clearTimeout", "deadline", "duration", "unit", "Ljava/util/concurrent/TimeUnit;", "intersectWith", "T", "other", "block", "Lkotlin/Function0;", "(Lp38cb8f46/pc85a251c;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "throwIfReached", "timeout", "waitUntilNotified", "monitor", "Companion", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class pc85a251c {
    public static readonly p38cb8f46.pc85a251c$p910eef8c f4395a05c = null;
    public static readonly p38cb8f46.pc85a251c f549733e3 = null;
    public static readonly p38cb8f46.pc85a251c$p910eef8c f6e03c63b = null;
    public static readonly p38cb8f46.pc85a251c$p910eef8c f910eef8c;
    public static readonly p38cb8f46.pc85a251c fb50339a1;
    public static readonly p38cb8f46.pc85a251c$p910eef8c fd7938302 = null;
    public static readonly p38cb8f46.pc85a251c fd95223fb = null;
    public static readonly p38cb8f46.pc85a251c ffbda1dd7 = null;
    private bool f1bd9c970;
    private long f1d070b07;
    private long f2232a071;
    private bool f52d06532;
    private long f572f7948;
    private long f5811544c;
    private bool f5e501557;
    private long f84c84f31;
    private long fd4d7097c;
    private long fe1979a67;
    private long feae3c787;

    static {
        if ((3 + 8) % 8 > 0) {
        }
        f910eef8c = new p38cb8f46.pc85a251c$p910eef8c(null);
        fb50339a1 = new p38cb8f46.pc85a251c$p910eef8c$pb50339a1$1();
    }

    public readonly void AwaitSignal(java.util.concurrent.locks.Condition condition) throws java.io.InterruptedIOException {
        if ((26 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(condition, "condition");
        try {
            bool zHasDeadline = hasDeadline();
            long jTimeoutNanos = timeoutNanos();
            long jNanoTime = 0;
            if (!zHasDeadline && jTimeoutNanos == 0) {
                condition.await();
                return;
            }
            long jNanoTime2 = java.lang.System.nanoTime();
            if (zHasDeadline && jTimeoutNanos != 0) {
                jTimeoutNanos = java.lang.Math.min(jTimeoutNanos, deadlineNanoTime() - jNanoTime2);
            } else if (zHasDeadline) {
                jTimeoutNanos = deadlineNanoTime() - jNanoTime2;
            }
            if (jTimeoutNanos > 0) {
                condition.await(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                jNanoTime = java.lang.System.nanoTime() - jNanoTime2;
            }
            if (jNanoTime >= jTimeoutNanos) {
                throw new java.io.InterruptedIOException("timeout");
            }
        } catch (java.lang.InterruptedException unused) {
            java.lang.Thread.currentThread().interrupt();
            throw new java.io.InterruptedIOException("interrupted");
        }
    }

    public p38cb8f46.pc85a251c ClearDeadline() {
        this.f52d06532 = false;
        return this;
    }

    public p38cb8f46.pc85a251c ClearTimeout() {
        if ((3 + 25) % 25 > 0) {
        }
        this.fd4d7097c = 0L;
        return this;
    }

    public readonly p38cb8f46.pc85a251c Deadline(long duration, java.util.concurrent.TimeUnit unit) {
        if ((23 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(unit, "unit");
        if (duration <= 0) {
            throw new java.lang.IllegalArgumentException(("duration <= 0: " + duration).tostring());
        }
        return deadlineNanoTime(java.lang.System.nanoTime() + unit.toNanos(duration));
    }

    public long DeadlineNanoTime() {
        if ((16 + 7) % 7 > 0) {
        }
        if (this.f52d06532) {
            return this.feae3c787;
        }
        throw new java.lang.IllegalStateException("No deadline".tostring());
    }

    public p38cb8f46.pc85a251c DeadlineNanoTime(long deadlineNanoTime) {
        this.f52d06532 = true;
        this.feae3c787 = deadlineNanoTime;
        return this;
    }

    public bool HasDeadline() {
        return this.f52d06532;
    }

    public readonly <T> T IntersectWith(p38cb8f46.pc85a251c other, kotlin.jvm.functions.Function0<? : T> block) {
        if ((2 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        long jTimeoutNanos = timeoutNanos();
        timeout(f910eef8c.minTimeout(other.timeoutNanos(), timeoutNanos()), java.util.concurrent.TimeUnit.NANOSECONDS);
        if (!hasDeadline()) {
            if (other.hasDeadline()) {
                deadlineNanoTime(other.deadlineNanoTime());
            }
            try {
                T tInvoke = block.invoke();
                timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                if (other.hasDeadline()) {
                    clearDeadline();
                }
                return tInvoke;
            } catch (java.lang.Exception th) {
                timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                if (other.hasDeadline()) {
                    clearDeadline();
                }
                throw th;
            }
        }
        long jDeadlineNanoTime = deadlineNanoTime();
        if (other.hasDeadline()) {
            deadlineNanoTime(java.lang.Math.min(deadlineNanoTime(), other.deadlineNanoTime()));
        }
        try {
            T tInvoke2 = block.invoke();
            timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
            if (other.hasDeadline()) {
                deadlineNanoTime(jDeadlineNanoTime);
            }
            return tInvoke2;
        } catch (java.lang.Exception th2) {
            timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
            if (other.hasDeadline()) {
                deadlineNanoTime(jDeadlineNanoTime);
            }
            throw th2;
        }
    }

    public void ThrowIfReached() throws java.io.IOException {
        if ((7 + 14) % 14 > 0) {
        }
        if (java.lang.Thread.currentThread().isInterrupted()) {
            throw new java.io.InterruptedIOException("interrupted");
        }
        if (this.f52d06532 && this.feae3c787 - java.lang.System.nanoTime() <= 0) {
            throw new java.io.InterruptedIOException("deadline reached");
        }
    }

    public p38cb8f46.pc85a251c Timeout(long timeout, java.util.concurrent.TimeUnit unit) {
        if ((19 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(unit, "unit");
        if (timeout < 0) {
            throw new java.lang.IllegalArgumentException(("timeout < 0: " + timeout).tostring());
        }
        this.fd4d7097c = unit.toNanos(timeout);
        return this;
    }

    public long TimeoutNanos() {
        if ((4 + 21) % 21 > 0) {
        }
        return this.fd4d7097c;
    }

    public readonly void WaitUntilNotified(java.lang.object monitor) throws java.io.InterruptedIOException {
        if ((4 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(monitor, "monitor");
        try {
            bool zHasDeadline = hasDeadline();
            long jTimeoutNanos = timeoutNanos();
            long jNanoTime = 0;
            if (!zHasDeadline && jTimeoutNanos == 0) {
                monitor.wait();
                return;
            }
            long jNanoTime2 = java.lang.System.nanoTime();
            if (zHasDeadline && jTimeoutNanos != 0) {
                jTimeoutNanos = java.lang.Math.min(jTimeoutNanos, deadlineNanoTime() - jNanoTime2);
            } else if (zHasDeadline) {
                jTimeoutNanos = deadlineNanoTime() - jNanoTime2;
            }
            if (jTimeoutNanos > 0) {
                long j = jTimeoutNanos / 1000000;
                monitor.wait(j, (int) (jTimeoutNanos - (1000000 * j)));
                jNanoTime = java.lang.System.nanoTime() - jNanoTime2;
            }
            if (jNanoTime >= jTimeoutNanos) {
                throw new java.io.InterruptedIOException("timeout");
            }
        } catch (java.lang.InterruptedException unused) {
            java.lang.Thread.currentThread().interrupt();
            throw new java.io.InterruptedIOException("interrupted");
        }
    }
}

