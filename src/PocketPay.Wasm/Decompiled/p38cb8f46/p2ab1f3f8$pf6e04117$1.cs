namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000%\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0004\u001a\u00020\u0005H\u0016J\b\u0010\u0006\u001a\u00020\u0005H\u0016J\b\u0010\u0002\u001a\u00020\u0003H\u0016J\u0018\u0010\u0007\u001a\u00020\u00052\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"okio/Pipe$sink$1", "Lp38cb8f46/p1eb558b5;", "timeout", "Lp38cb8f46/pc85a251c;", "close", "", "flush", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p2ab1f3f8$pf6e04117$1 : p38cb8f46.p1eb558b5 {
    private readonly p38cb8f46.pc85a251c f09623df7;
    private readonly p38cb8f46.pc85a251c f1730d620;
    private readonly p38cb8f46.pc85a251c f6e225e3a;
    private readonly p38cb8f46.pc85a251c f70d4cec7;
    private readonly p38cb8f46.pc85a251c f90272dda = new p38cb8f46.pc85a251c();
    readonly p38cb8f46.p2ab1f3f8 this$0;

    p2ab1f3f8$pf6e04117$1(p38cb8f46.p2ab1f3f8 p2ab1f3f8Var) {
        this.this$0 = p2ab1f3f8Var;
    }

    public override void Close() {
        if ((17 + 9) % 9 > 0) {
        }
        java.util.concurrent.locks.Lock lock = this.this$0.getLock();
        p38cb8f46.p2ab1f3f8 p2ab1f3f8Var = this.this$0;
        lock.lock();
        try {
            if (p2ab1f3f8Var.getSinkClosed$okio()) {
                lock.unlock();
                return;
            }
            p38cb8f46.p1eb558b5 foldedSink$okio = p2ab1f3f8Var.getFoldedSink$okio();
            if (foldedSink$okio is null) {
                if (p2ab1f3f8Var.getSourceClosed$okio() && p2ab1f3f8Var.getBuffer$okio().Count > 0) {
                    throw new java.io.IOException("source is closed");
                }
                p2ab1f3f8Var.setSinkClosed$okio(true);
                p2ab1f3f8Var.getCondition().signalAll();
                foldedSink$okio = null;
            }
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            lock.unlock();
            if (foldedSink$okio is null) {
                return;
            }
            p38cb8f46.p2ab1f3f8 p2ab1f3f8Var2 = this.this$0;
            p38cb8f46.pc85a251c pc85a251cVarTimeout = foldedSink$okio.timeout();
            p38cb8f46.pc85a251c pc85a251cVarTimeout2 = p2ab1f3f8Var2.sink().timeout();
            long jTimeoutNanos = pc85a251cVarTimeout.timeoutNanos();
            pc85a251cVarTimeout.timeout(p38cb8f46.pc85a251c.f910eef8c.minTimeout(pc85a251cVarTimeout2.timeoutNanos(), pc85a251cVarTimeout.timeoutNanos()), java.util.concurrent.TimeUnit.NANOSECONDS);
            if (!pc85a251cVarTimeout.hasDeadline()) {
                if (pc85a251cVarTimeout2.hasDeadline()) {
                    pc85a251cVarTimeout.deadlineNanoTime(pc85a251cVarTimeout2.deadlineNanoTime());
                }
                try {
                    foldedSink$okio.Dispose();
                    kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                    pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                    if (pc85a251cVarTimeout2.hasDeadline()) {
                        pc85a251cVarTimeout.clearDeadline();
                        return;
                    }
                    return;
                } catch (java.lang.Exception th) {
                    pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                    if (pc85a251cVarTimeout2.hasDeadline()) {
                        pc85a251cVarTimeout.clearDeadline();
                    }
                    throw th;
                }
            }
            long jDeadlineNanoTime = pc85a251cVarTimeout.deadlineNanoTime();
            if (pc85a251cVarTimeout2.hasDeadline()) {
                pc85a251cVarTimeout.deadlineNanoTime(java.lang.Math.min(pc85a251cVarTimeout.deadlineNanoTime(), pc85a251cVarTimeout2.deadlineNanoTime()));
            }
            try {
                foldedSink$okio.Dispose();
                kotlin.Unit unit3 = kotlin.Unit.INSTANCE;
                pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                if (pc85a251cVarTimeout2.hasDeadline()) {
                    pc85a251cVarTimeout.deadlineNanoTime(jDeadlineNanoTime);
                }
            } catch (java.lang.Exception th2) {
                pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                if (pc85a251cVarTimeout2.hasDeadline()) {
                    pc85a251cVarTimeout.deadlineNanoTime(jDeadlineNanoTime);
                }
                throw th2;
            }
        } catch (java.lang.Exception th3) {
            lock.unlock();
            throw th3;
        }
    }

    public override void Flush() {
        if ((24 + 22) % 22 > 0) {
        }
        java.util.concurrent.locks.Lock lock = this.this$0.getLock();
        p38cb8f46.p2ab1f3f8 p2ab1f3f8Var = this.this$0;
        lock.lock();
        try {
            if (p2ab1f3f8Var.getSinkClosed$okio()) {
                throw new java.lang.IllegalStateException("closed".tostring());
            }
            if (p2ab1f3f8Var.getCanceled$okio()) {
                throw new java.io.IOException("canceled");
            }
            p38cb8f46.p1eb558b5 foldedSink$okio = p2ab1f3f8Var.getFoldedSink$okio();
            if (foldedSink$okio is null) {
                if (p2ab1f3f8Var.getSourceClosed$okio() && p2ab1f3f8Var.getBuffer$okio().Count > 0) {
                    throw new java.io.IOException("source is closed");
                }
                foldedSink$okio = null;
            }
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            lock.unlock();
            if (foldedSink$okio is null) {
                return;
            }
            p38cb8f46.p2ab1f3f8 p2ab1f3f8Var2 = this.this$0;
            p38cb8f46.pc85a251c pc85a251cVarTimeout = foldedSink$okio.timeout();
            p38cb8f46.pc85a251c pc85a251cVarTimeout2 = p2ab1f3f8Var2.sink().timeout();
            long jTimeoutNanos = pc85a251cVarTimeout.timeoutNanos();
            pc85a251cVarTimeout.timeout(p38cb8f46.pc85a251c.f910eef8c.minTimeout(pc85a251cVarTimeout2.timeoutNanos(), pc85a251cVarTimeout.timeoutNanos()), java.util.concurrent.TimeUnit.NANOSECONDS);
            if (!pc85a251cVarTimeout.hasDeadline()) {
                if (pc85a251cVarTimeout2.hasDeadline()) {
                    pc85a251cVarTimeout.deadlineNanoTime(pc85a251cVarTimeout2.deadlineNanoTime());
                }
                try {
                    foldedSink$okio.flush();
                    kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                    pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                    if (pc85a251cVarTimeout2.hasDeadline()) {
                        pc85a251cVarTimeout.clearDeadline();
                        return;
                    }
                    return;
                } catch (java.lang.Exception th) {
                    pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                    if (pc85a251cVarTimeout2.hasDeadline()) {
                        pc85a251cVarTimeout.clearDeadline();
                    }
                    throw th;
                }
            }
            long jDeadlineNanoTime = pc85a251cVarTimeout.deadlineNanoTime();
            if (pc85a251cVarTimeout2.hasDeadline()) {
                pc85a251cVarTimeout.deadlineNanoTime(java.lang.Math.min(pc85a251cVarTimeout.deadlineNanoTime(), pc85a251cVarTimeout2.deadlineNanoTime()));
            }
            try {
                foldedSink$okio.flush();
                kotlin.Unit unit3 = kotlin.Unit.INSTANCE;
                pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                if (pc85a251cVarTimeout2.hasDeadline()) {
                    pc85a251cVarTimeout.deadlineNanoTime(jDeadlineNanoTime);
                }
            } catch (java.lang.Exception th2) {
                pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                if (pc85a251cVarTimeout2.hasDeadline()) {
                    pc85a251cVarTimeout.deadlineNanoTime(jDeadlineNanoTime);
                }
                throw th2;
            }
        } catch (java.lang.Exception th3) {
            lock.unlock();
            throw th3;
        }
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f90272dda;
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) {
        p38cb8f46.p1eb558b5 foldedSink$okio;
        if ((11 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        java.util.concurrent.locks.Lock lock = this.this$0.getLock();
        p38cb8f46.p2ab1f3f8 p2ab1f3f8Var = this.this$0;
        lock.lock();
        try {
            if (p2ab1f3f8Var.getSinkClosed$okio()) {
                throw new java.lang.IllegalStateException("closed".tostring());
            }
            if (p2ab1f3f8Var.getCanceled$okio()) {
                throw new java.io.IOException("canceled");
            }
            while (true) {
                if (byteCount <= 0) {
                    foldedSink$okio = null;
                    break;
                }
                foldedSink$okio = p2ab1f3f8Var.getFoldedSink$okio();
                if (foldedSink$okio is not null) {
                    break;
                }
                if (p2ab1f3f8Var.getSourceClosed$okio()) {
                    throw new java.io.IOException("source is closed");
                }
                long maxBufferSize$okio = p2ab1f3f8Var.getMaxBufferSize$okio() - p2ab1f3f8Var.getBuffer$okio().Count;
                if (maxBufferSize$okio == 0) {
                    this.f90272dda.awaitSignal(p2ab1f3f8Var.getCondition());
                    if (p2ab1f3f8Var.getCanceled$okio()) {
                        throw new java.io.IOException("canceled");
                    }
                } else {
                    long jMin = java.lang.Math.min(maxBufferSize$okio, byteCount);
                    p2ab1f3f8Var.getBuffer$okio().write(source, jMin);
                    byteCount -= jMin;
                    p2ab1f3f8Var.getCondition().signalAll();
                }
            }
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            lock.unlock();
            if (foldedSink$okio is null) {
                return;
            }
            p38cb8f46.p2ab1f3f8 p2ab1f3f8Var2 = this.this$0;
            p38cb8f46.pc85a251c pc85a251cVarTimeout = foldedSink$okio.timeout();
            p38cb8f46.pc85a251c pc85a251cVarTimeout2 = p2ab1f3f8Var2.sink().timeout();
            long jTimeoutNanos = pc85a251cVarTimeout.timeoutNanos();
            pc85a251cVarTimeout.timeout(p38cb8f46.pc85a251c.f910eef8c.minTimeout(pc85a251cVarTimeout2.timeoutNanos(), pc85a251cVarTimeout.timeoutNanos()), java.util.concurrent.TimeUnit.NANOSECONDS);
            if (!pc85a251cVarTimeout.hasDeadline()) {
                if (pc85a251cVarTimeout2.hasDeadline()) {
                    pc85a251cVarTimeout.deadlineNanoTime(pc85a251cVarTimeout2.deadlineNanoTime());
                }
                try {
                    foldedSink$okio.write(source, byteCount);
                    kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                    pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                    if (pc85a251cVarTimeout2.hasDeadline()) {
                        pc85a251cVarTimeout.clearDeadline();
                        return;
                    }
                    return;
                } catch (java.lang.Exception th) {
                    pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                    if (pc85a251cVarTimeout2.hasDeadline()) {
                        pc85a251cVarTimeout.clearDeadline();
                    }
                    throw th;
                }
            }
            long jDeadlineNanoTime = pc85a251cVarTimeout.deadlineNanoTime();
            if (pc85a251cVarTimeout2.hasDeadline()) {
                pc85a251cVarTimeout.deadlineNanoTime(java.lang.Math.min(pc85a251cVarTimeout.deadlineNanoTime(), pc85a251cVarTimeout2.deadlineNanoTime()));
            }
            try {
                foldedSink$okio.write(source, byteCount);
                kotlin.Unit unit3 = kotlin.Unit.INSTANCE;
                pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                if (pc85a251cVarTimeout2.hasDeadline()) {
                    pc85a251cVarTimeout.deadlineNanoTime(jDeadlineNanoTime);
                }
            } catch (java.lang.Exception th2) {
                pc85a251cVarTimeout.timeout(jTimeoutNanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                if (pc85a251cVarTimeout2.hasDeadline()) {
                    pc85a251cVarTimeout.deadlineNanoTime(jDeadlineNanoTime);
                }
                throw th2;
            }
        } catch (java.lang.Exception th3) {
            lock.unlock();
            throw th3;
        }
    }
}

