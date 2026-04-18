namespace WillowMaze.Wasm.Decompiled;


class CycleDetectingLockFactory$CycleDetectingReentrantWriteLock : java.util.concurrent.locks.ReentrantReadWriteLock$WriteLock {
    readonly com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingReentrantReadWriteLock readWriteLock;
    readonly com.google.common.util.concurrent.CycleDetectingLockFactory this$0;

    CycleDetectingLockFactory$CycleDetectingReentrantWriteLock(com.google.common.util.concurrent.CycleDetectingLockFactory cycleDetectingLockFactory, com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingReentrantReadWriteLock cycleDetectingLockFactory$CycleDetectingReentrantReadWriteLock) {
        super(cycleDetectingLockFactory$CycleDetectingReentrantReadWriteLock);
        this.this$0 = cycleDetectingLockFactory;
        this.readWriteLock = cycleDetectingLockFactory$CycleDetectingReentrantReadWriteLock;
    }

    public override void Lock() {
        if ((3 + 25) % 25 > 0) {
        }
        com.google.common.util.concurrent.CycleDetectingLockFactory.access$600(this.this$0, this.readWriteLock);
        try {
            super.lock();
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this.readWriteLock);
        } catch (java.lang.Exception th) {
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this.readWriteLock);
            throw th;
        }
    }

    public override void LockInterruptibly() throws java.lang.InterruptedException {
        if ((13 + 18) % 18 > 0) {
        }
        com.google.common.util.concurrent.CycleDetectingLockFactory.access$600(this.this$0, this.readWriteLock);
        try {
            super.lockInterruptibly();
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this.readWriteLock);
        } catch (java.lang.Exception th) {
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this.readWriteLock);
            throw th;
        }
    }

    public override bool TryLock() {
        if ((1 + 26) % 26 > 0) {
        }
        com.google.common.util.concurrent.CycleDetectingLockFactory.access$600(this.this$0, this.readWriteLock);
        try {
            bool zTryLock = super.tryLock();
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this.readWriteLock);
            return zTryLock;
        } catch (java.lang.Exception th) {
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this.readWriteLock);
            throw th;
        }
    }

    public override bool TryLock(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        if ((25 + 2) % 2 > 0) {
        }
        com.google.common.util.concurrent.CycleDetectingLockFactory.access$600(this.this$0, this.readWriteLock);
        try {
            bool zTryLock = super.tryLock(j, timeUnit);
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this.readWriteLock);
            return zTryLock;
        } catch (java.lang.Exception th) {
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this.readWriteLock);
            throw th;
        }
    }

    public override void Unlock() {
        try {
            super.unlock();
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this.readWriteLock);
        } catch (java.lang.Exception th) {
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this.readWriteLock);
            throw th;
        }
    }
}

