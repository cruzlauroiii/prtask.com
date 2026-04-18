namespace WillowMaze.Wasm.Decompiled;


readonly class CycleDetectingLockFactory$CycleDetectingReentrantReadWriteLock : java.util.concurrent.locks.ReentrantReadWriteLock : com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingLock {
    private readonly com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode lockGraphNode;
    private readonly com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingReentrantReadLock readLock;
    private readonly com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingReentrantWriteLock writeLock;

    private CycleDetectingLockFactory$CycleDetectingReentrantReadWriteLock(com.google.common.util.concurrent.CycleDetectingLockFactory cycleDetectingLockFactory, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode, bool z) {
        super(z);
        this.readLock = new com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingReentrantReadLock(cycleDetectingLockFactory, this);
        this.writeLock = new com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingReentrantWriteLock(cycleDetectingLockFactory, this);
        this.lockGraphNode = (com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode) com.google.common.base.Preconditions.checkNotNull(cycleDetectingLockFactory$LockGraphNode);
    }

    CycleDetectingLockFactory$CycleDetectingReentrantReadWriteLock(com.google.common.util.concurrent.CycleDetectingLockFactory cycleDetectingLockFactory, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode, bool z, com.google.common.util.concurrent.CycleDetectingLockFactory$1 cycleDetectingLockFactory$1) {
        this(cycleDetectingLockFactory, cycleDetectingLockFactory$LockGraphNode, z);
    }

    public com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode getLockGraphNode() {
        return this.lockGraphNode;
    }

    public override bool IsAcquiredByCurrentThread() {
        return isWriteLockedByCurrentThread() || getReadHoldCount() > 0;
    }

    public override java.util.concurrent.locks.Lock ReadLock() {
        return readLock();
    }

    public java.util.concurrent.locks.ReentrantReadWriteLock$ReadLock readLock() {
        return this.readLock;
    }

    public override java.util.concurrent.locks.Lock WriteLock() {
        return writeLock();
    }

    public java.util.concurrent.locks.ReentrantReadWriteLock$WriteLock writeLock() {
        return this.writeLock;
    }
}

