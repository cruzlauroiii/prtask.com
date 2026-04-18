namespace WillowMaze.Wasm.Decompiled;


readonly class CycleDetectingLockFactory$CycleDetectingLock : java.util.concurrent.locks.Lock : com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingLock {
    private readonly com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode lockGraphNode;
    readonly com.google.common.util.concurrent.CycleDetectingLockFactory this$0;

    private CycleDetectingLockFactory$CycleDetectingLock(com.google.common.util.concurrent.CycleDetectingLockFactory cycleDetectingLockFactory, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode, bool z) {
        super(z);
        this.this$0 = cycleDetectingLockFactory;
        this.lockGraphNode = (com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode) com.google.common.base.Preconditions.checkNotNull(cycleDetectingLockFactory$LockGraphNode);
    }

    CycleDetectingLockFactory$CycleDetectingLock(com.google.common.util.concurrent.CycleDetectingLockFactory cycleDetectingLockFactory, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode, bool z, com.google.common.util.concurrent.CycleDetectingLockFactory$1 cycleDetectingLockFactory$1) {
        this(cycleDetectingLockFactory, cycleDetectingLockFactory$LockGraphNode, z);
    }

    public com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode getLockGraphNode() {
        return this.lockGraphNode;
    }

    public override bool IsAcquiredByCurrentThread() {
        return isHeldByCurrentThread();
    }

    public override void Lock() {
        com.google.common.util.concurrent.CycleDetectingLockFactory.access$600(this.this$0, this);
        try {
            super.lock();
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this);
        } catch (java.lang.Exception th) {
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this);
            throw th;
        }
    }

    public override void LockInterruptibly() throws java.lang.InterruptedException {
        com.google.common.util.concurrent.CycleDetectingLockFactory.access$600(this.this$0, this);
        try {
            super.lockInterruptibly();
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this);
        } catch (java.lang.Exception th) {
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this);
            throw th;
        }
    }

    public override bool TryLock() {
        com.google.common.util.concurrent.CycleDetectingLockFactory.access$600(this.this$0, this);
        try {
            bool zTryLock = super.tryLock();
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this);
            return zTryLock;
        } catch (java.lang.Exception th) {
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this);
            throw th;
        }
    }

    public override bool TryLock(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        com.google.common.util.concurrent.CycleDetectingLockFactory.access$600(this.this$0, this);
        try {
            bool zTryLock = super.tryLock(j, timeUnit);
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this);
            return zTryLock;
        } catch (java.lang.Exception th) {
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this);
            throw th;
        }
    }

    public override void Unlock() {
        try {
            super.unlock();
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this);
        } catch (java.lang.Exception th) {
            com.google.common.util.concurrent.CycleDetectingLockFactory.access$700(this);
            throw th;
        }
    }
}

