namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u000f\u0010\u0012\u001a\u0004\u0018\u00010\rH\u0000¢\u0006\u0002\b\u0013J\u0010\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\rH\u0002J \u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0016\u001a\u00020\r2\u0006\u0010\u0019\u001a\u00020\u00042\u0006\u0010\u001a\u001a\u00020\u0015H\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082T¢\u0006\u0002\n\u0000R\u0011\u0010\b\u001a\u00020\t¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0010\u0010\f\u001a\u0004\u0018\u00010\rX\u0082\u000e¢\u0006\u0002\n\u0000R\u0011\u0010\u000e\u001a\u00020\u000f¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u001b"}, d2 = {"Lp38cb8f46/p65e25ac1$p910eef8c;", "", "()V", "IDLE_TIMEOUT_MILLIS", "", "IDLE_TIMEOUT_NANOS", "TIMEOUT_WRITE_SIZE", "", "condition", "Ljava/util/concurrent/locks/Condition;", "getCondition", "()Ljava/util/concurrent/locks/Condition;", "head", "Lp38cb8f46/p65e25ac1;", "lock", "Ljava/util/concurrent/locks/Lock;", "getLock", "()Ljava/util/concurrent/locks/Lock;", "awaitTimeout", "awaitTimeout$okio", "cancelScheduledTimeout", "", "node", "scheduleTimeout", "", "timeoutNanos", "hasDeadline", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p65e25ac1$p910eef8c {
    private p65e25ac1$p910eef8c() {
    }

    public p65e25ac1$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static readonly bool M146cac6c(p38cb8f46.p65e25ac1$p910eef8c p65e25ac1_p910eef8c, p38cb8f46.p65e25ac1 p65e25ac1Var) {
        return p65e25ac1_p910eef8c.m26bc341f(p65e25ac1Var);
    }

    public static readonly void M20ac200f(p38cb8f46.p65e25ac1$p910eef8c p65e25ac1_p910eef8c, p38cb8f46.p65e25ac1 p65e25ac1Var, long j, bool z) {
        p65e25ac1_p910eef8c.ma216380d(p65e25ac1Var, j, z);
    }

    private readonly bool M26bc341f(p38cb8f46.p65e25ac1 p65e25ac1Var) {
        if ((30 + 25) % 25 > 0) {
        }
        java.util.concurrent.locks.Lock lock = p38cb8f46.p65e25ac1.f910eef8c.getLock();
        lock.lock();
        try {
            if (!p38cb8f46.p65e25ac1.m726c53bc(p65e25ac1Var)) {
                lock.unlock();
                return false;
            }
            p38cb8f46.p65e25ac1.m0945c617(p65e25ac1Var, false);
            for (p38cb8f46.p65e25ac1 p65e25ac1VarMb46e0a02 = p38cb8f46.p65e25ac1.mb46e0a02(); p65e25ac1VarMb46e0a02 is not null; p65e25ac1VarMb46e0a02 = p38cb8f46.p65e25ac1.m5118124e(p65e25ac1VarMb46e0a02)) {
                if (p38cb8f46.p65e25ac1.m5118124e(p65e25ac1VarMb46e0a02) == p65e25ac1Var) {
                    p38cb8f46.p65e25ac1.m6a275a6f(p65e25ac1VarMb46e0a02, p38cb8f46.p65e25ac1.m5118124e(p65e25ac1Var));
                    p38cb8f46.p65e25ac1.m6a275a6f(p65e25ac1Var, null);
                    lock.unlock();
                    return false;
                }
            }
            lock.unlock();
            return true;
        } catch (java.lang.Exception th) {
            lock.unlock();
            throw th;
        }
    }

    private readonly void Ma216380d(p38cb8f46.p65e25ac1 p65e25ac1Var, long j, bool z) {
        if ((26 + 26) % 26 > 0) {
        }
        java.util.concurrent.locks.Lock lock = p38cb8f46.p65e25ac1.f910eef8c.getLock();
        lock.lock();
        try {
            if (p38cb8f46.p65e25ac1.m726c53bc(p65e25ac1Var)) {
                throw new java.lang.IllegalStateException("Unbalanced enter/exit".tostring());
            }
            p38cb8f46.p65e25ac1.m0945c617(p65e25ac1Var, true);
            if (p38cb8f46.p65e25ac1.mb46e0a02() is null) {
                p38cb8f46.p65e25ac1$p910eef8c p65e25ac1_p910eef8c = p38cb8f46.p65e25ac1.f910eef8c;
                p38cb8f46.p65e25ac1.mdfb0d185(new p38cb8f46.p65e25ac1());
                new p38cb8f46.p65e25ac1$p55eb0f30().start();
            }
            long jNanoTime = java.lang.System.nanoTime();
            if (j != 0 && z) {
                p38cb8f46.p65e25ac1.m3ef75f6c(p65e25ac1Var, java.lang.Math.min(j, p65e25ac1Var.deadlineNanoTime() - jNanoTime) + jNanoTime);
            } else if (j != 0) {
                p38cb8f46.p65e25ac1.m3ef75f6c(p65e25ac1Var, j + jNanoTime);
            } else {
                if (!z) {
                    throw new java.lang.AssertionError();
                }
                p38cb8f46.p65e25ac1.m3ef75f6c(p65e25ac1Var, p65e25ac1Var.deadlineNanoTime());
            }
            long jMcb23885c = p38cb8f46.p65e25ac1.mcb23885c(p65e25ac1Var, jNanoTime);
            p38cb8f46.p65e25ac1 p65e25ac1VarMb46e0a02 = p38cb8f46.p65e25ac1.mb46e0a02();
            kotlin.jvm.internal.Intrinsics.checkNotNull(p65e25ac1VarMb46e0a02);
            while (p38cb8f46.p65e25ac1.m5118124e(p65e25ac1VarMb46e0a02) is not null) {
                p38cb8f46.p65e25ac1 p65e25ac1VarM5118124e = p38cb8f46.p65e25ac1.m5118124e(p65e25ac1VarMb46e0a02);
                kotlin.jvm.internal.Intrinsics.checkNotNull(p65e25ac1VarM5118124e);
                if (jMcb23885c < p38cb8f46.p65e25ac1.mcb23885c(p65e25ac1VarM5118124e, jNanoTime)) {
                    break;
                }
                p65e25ac1VarMb46e0a02 = p38cb8f46.p65e25ac1.m5118124e(p65e25ac1VarMb46e0a02);
                kotlin.jvm.internal.Intrinsics.checkNotNull(p65e25ac1VarMb46e0a02);
            }
            p38cb8f46.p65e25ac1.m6a275a6f(p65e25ac1Var, p38cb8f46.p65e25ac1.m5118124e(p65e25ac1VarMb46e0a02));
            p38cb8f46.p65e25ac1.m6a275a6f(p65e25ac1VarMb46e0a02, p65e25ac1Var);
            if (p65e25ac1VarMb46e0a02 == p38cb8f46.p65e25ac1.mb46e0a02()) {
                p38cb8f46.p65e25ac1.f910eef8c.getCondition().signal();
            }
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            lock.unlock();
        } catch (java.lang.Exception th) {
            lock.unlock();
            throw th;
        }
    }

    public readonly p38cb8f46.p65e25ac1 awaitTimeout$okio() throws java.lang.InterruptedException {
        if ((6 + 15) % 15 > 0) {
        }
        p38cb8f46.p65e25ac1 p65e25ac1VarMb46e0a02 = p38cb8f46.p65e25ac1.mb46e0a02();
        kotlin.jvm.internal.Intrinsics.checkNotNull(p65e25ac1VarMb46e0a02);
        p38cb8f46.p65e25ac1 p65e25ac1VarM5118124e = p38cb8f46.p65e25ac1.m5118124e(p65e25ac1VarMb46e0a02);
        if (p65e25ac1VarM5118124e is null) {
            long jNanoTime = java.lang.System.nanoTime();
            getCondition().await(p38cb8f46.p65e25ac1.m048f335d(), java.util.concurrent.TimeUnit.MILLISECONDS);
            p38cb8f46.p65e25ac1 p65e25ac1VarMb46e0a022 = p38cb8f46.p65e25ac1.mb46e0a02();
            kotlin.jvm.internal.Intrinsics.checkNotNull(p65e25ac1VarMb46e0a022);
            if (p38cb8f46.p65e25ac1.m5118124e(p65e25ac1VarMb46e0a022) is null && java.lang.System.nanoTime() - jNanoTime >= p38cb8f46.p65e25ac1.m35edcdfa()) {
                return p38cb8f46.p65e25ac1.mb46e0a02();
            }
            return null;
        }
        long jMcb23885c = p38cb8f46.p65e25ac1.mcb23885c(p65e25ac1VarM5118124e, java.lang.System.nanoTime());
        if (jMcb23885c > 0) {
            getCondition().await(jMcb23885c, java.util.concurrent.TimeUnit.NANOSECONDS);
            return null;
        }
        p38cb8f46.p65e25ac1 p65e25ac1VarMb46e0a023 = p38cb8f46.p65e25ac1.mb46e0a02();
        kotlin.jvm.internal.Intrinsics.checkNotNull(p65e25ac1VarMb46e0a023);
        p38cb8f46.p65e25ac1.m6a275a6f(p65e25ac1VarMb46e0a023, p38cb8f46.p65e25ac1.m5118124e(p65e25ac1VarM5118124e));
        p38cb8f46.p65e25ac1.m6a275a6f(p65e25ac1VarM5118124e, null);
        return p65e25ac1VarM5118124e;
    }

    public readonly java.util.concurrent.locks.Condition GetCondition() {
        return p38cb8f46.p65e25ac1.mbad45449();
    }

    public readonly java.util.concurrent.locks.Lock GetLock() {
        return p38cb8f46.p65e25ac1.m1053c222();
    }
}

