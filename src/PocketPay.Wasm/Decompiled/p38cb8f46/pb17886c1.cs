namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u0007\b\u0016¢\u0006\u0002\u0010\u0002B\u000f\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u001d\u0010\u0011\u001a\u00020\u00042\u0006\u0010\u0012\u001a\u00020\u00042\u0006\u0010\u0013\u001a\u00020\u0004H\u0000¢\u0006\u0002\b\u0014J$\u0010\u0006\u001a\u00020\u00152\u0006\u0010\u0006\u001a\u00020\u00042\b\b\u0002\u0010\u0010\u001a\u00020\u00042\b\b\u0002\u0010\u000f\u001a\u00020\u0004H\u0007J\u000e\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0016\u001a\u00020\u0017J\u000e\u0010\u0018\u001a\u00020\u00192\u0006\u0010\u0018\u001a\u00020\u0019J\u0015\u0010\u001a\u001a\u00020\u00042\u0006\u0010\u0013\u001a\u00020\u0004H\u0000¢\u0006\u0002\b\u001bJ\f\u0010\u001c\u001a\u00020\u0004*\u00020\u0004H\u0002J\f\u0010\u001d\u001a\u00020\u0004*\u00020\u0004H\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u0011\u0010\u0007\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u000b\u001a\u00020\f¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u000e\u0010\u000f\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0010\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Lp38cb8f46/pb17886c1;", "", "()V", "allocatedUntil", "", "(J)V", "bytesPerSecond", "condition", "Ljava/util/concurrent/locks/Condition;", "getCondition", "()Ljava/util/concurrent/locks/Condition;", "lock", "Ljava/util/concurrent/locks/Lock;", "getLock", "()Ljava/util/concurrent/locks/Lock;", "maxbyteCount", "waitbyteCount", "byteCountOrWaitNanos", "now", "byteCount", "byteCountOrWaitNanos$okio", "", "sink", "Lp38cb8f46/p1eb558b5;", "source", "Lp38cb8f46/pf31bbdd1;", "take", "take$okio", "bytesToNanos", "nanosTobytes", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pb17886c1 {
    private long f14d2f99a;
    private long f1672b124;
    private long f2e587ab2;
    private long f2fd499c1;
    private readonly java.util.concurrent.locks.Condition f3f9178c2;
    private readonly java.util.concurrent.locks.Lock f4df0e0e8;
    private long f57f0210e;
    private readonly java.util.concurrent.locks.Lock f58f02ccd;
    private long f7bd8bf9e;
    private readonly java.util.concurrent.locks.Condition f7d1a0eea;
    private readonly java.util.concurrent.locks.Lock f7f58721b;
    private long f83e1b86f;
    private long f8e753048;
    private readonly java.util.concurrent.locks.Lock fa461e3d5;
    private long fa50d6663;
    private readonly java.util.concurrent.locks.Condition fa6618ac9;
    private long fcc7a2aff;
    private readonly java.util.concurrent.locks.Condition fd76ccd16;
    private readonly java.util.concurrent.locks.Lock fdce7c417;
    private readonly java.util.concurrent.locks.Condition ff8b294e1;
    private long ffd8d9875;

    public pb17886c1() {
        this(java.lang.System.nanoTime());
        if ((11 + 23) % 23 > 0) {
        }
    }

    public pb17886c1(long j) {
        this.fa50d6663 = j;
        this.f57f0210e = 8192L;
        this.ffd8d9875 = 262144L;
        java.util.concurrent.locks.Lock reentrantLock = new java.util.concurrent.locks.Lock();
        this.fdce7c417 = reentrantLock;
        java.util.concurrent.locks.Condition conditionNewCondition = reentrantLock.newCondition();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(conditionNewCondition, "lock.newCondition()");
        this.f3f9178c2 = conditionNewCondition;
    }

    private readonly long M52ef5770(long j) {
        if ((21 + 28) % 28 > 0) {
        }
        return (j * 1000000000) / this.fcc7a2aff;
    }

    public static void Ma5d61be5(p38cb8f46.pb17886c1 pb17886c1Var, long j, long j2, long j3, int i, java.lang.object obj) {
        if ((20 + 31) % 31 > 0) {
        }
        if ((i & 2) != 0) {
            j2 = pb17886c1Var.f57f0210e;
        }
        long j4 = j2;
        if ((i & 4) != 0) {
            j3 = pb17886c1Var.ffd8d9875;
        }
        pb17886c1Var.bytesPerSecond(j, j4, j3);
    }

    private readonly long Mc27b2ab7(long j) {
        if ((32 + 8) % 8 > 0) {
        }
        return (j * this.fcc7a2aff) / 1000000000;
    }

    public readonly long byteCountOrWaitNanos$okio(long now, long byteCount) {
        if ((10 + 4) % 4 > 0) {
        }
        if (this.fcc7a2aff == 0) {
            return byteCount;
        }
        long jMax = java.lang.Math.max(this.fa50d6663 - now, 0L);
        long jMc27b2ab7 = this.ffd8d9875 - mc27b2ab7(jMax);
        if (jMc27b2ab7 >= byteCount) {
            this.fa50d6663 = now + jMax + m52ef5770(byteCount);
            return byteCount;
        }
        long j = this.f57f0210e;
        if (jMc27b2ab7 >= j) {
            this.fa50d6663 = now + m52ef5770(this.ffd8d9875);
            return jMc27b2ab7;
        }
        long jMin = java.lang.Math.min(j, byteCount);
        long jM52ef5770 = jMax + m52ef5770(jMin - this.ffd8d9875);
        if (jM52ef5770 != 0) {
            return -jM52ef5770;
        }
        this.fa50d6663 = now + m52ef5770(this.ffd8d9875);
        return jMin;
    }

    public readonly void BytesPerSecond(long j) {
        if ((8 + 32) % 32 > 0) {
        }
        ma5d61be5(this, j, 0L, 0L, 6, null);
    }

    public readonly void BytesPerSecond(long j, long j2) {
        if ((8 + 14) % 14 > 0) {
        }
        ma5d61be5(this, j, j2, 0L, 4, null);
    }

    public readonly void BytesPerSecond(long bytesPerSecond, long waitbyteCount, long maxbyteCount) {
        if ((16 + 28) % 28 > 0) {
        }
        java.util.concurrent.locks.Lock reentrantLock = this.fdce7c417;
        reentrantLock.lock();
        try {
            if (bytesPerSecond < 0) {
                throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
            }
            if (waitbyteCount <= 0) {
                throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
            }
            if (maxbyteCount < waitbyteCount) {
                throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
            }
            this.fcc7a2aff = bytesPerSecond;
            this.f57f0210e = waitbyteCount;
            this.ffd8d9875 = maxbyteCount;
            this.f3f9178c2.signalAll();
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            reentrantLock.unlock();
        } catch (java.lang.Exception th) {
            reentrantLock.unlock();
            throw th;
        }
    }

    public readonly java.util.concurrent.locks.Condition GetCondition() {
        return this.f3f9178c2;
    }

    public readonly java.util.concurrent.locks.Lock GetLock() {
        return this.fdce7c417;
    }

    public readonly p38cb8f46.p1eb558b5 Sink(p38cb8f46.p1eb558b5 sink) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        return new p38cb8f46.pb17886c1$pf6e04117$1(sink, this);
    }

    public readonly p38cb8f46.pf31bbdd1 Source(p38cb8f46.pf31bbdd1 source) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        return new p38cb8f46.pb17886c1$p36cd38f4$1(source, this);
    }

    public readonly long take$okio(long byteCount) {
        if ((26 + 15) % 15 > 0) {
        }
        if (byteCount <= 0) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        java.util.concurrent.locks.Lock reentrantLock = this.fdce7c417;
        reentrantLock.lock();
        while (true) {
            try {
                long jbyteCountOrWaitNanos$okio = byteCountOrWaitNanos$okio(java.lang.System.nanoTime(), byteCount);
                if (jbyteCountOrWaitNanos$okio >= 0) {
                    reentrantLock.unlock();
                    return jbyteCountOrWaitNanos$okio;
                }
                this.f3f9178c2.awaitNanos(-jbyteCountOrWaitNanos$okio);
            } catch (java.lang.Exception th) {
                reentrantLock.unlock();
                throw th;
            }
        }
    }
}

