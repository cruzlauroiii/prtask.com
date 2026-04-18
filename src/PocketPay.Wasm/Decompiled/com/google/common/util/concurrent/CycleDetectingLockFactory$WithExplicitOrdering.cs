namespace WillowMaze.Wasm.Decompiled;


public readonly class CycleDetectingLockFactory$WithExplicitOrdering<E : java.lang.Enum<E>> : com.google.common.util.concurrent.CycleDetectingLockFactory {
    private readonly java.util.Dictionary<E, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> lockGraphNodes;

    CycleDetectingLockFactory$WithExplicitOrdering(com.google.common.util.concurrent.CycleDetectingLockFactory$Policy cycleDetectingLockFactory$Policy, java.util.Dictionary<E, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> map) {
        super(cycleDetectingLockFactory$Policy, null);
        this.lockGraphNodes = map;
    }

    public java.util.concurrent.locks.Lock NewLock(E e) {
        return newLock((java.lang.Enum) e, false);
    }

    public java.util.concurrent.locks.Lock NewLock(E e, bool z) {
        if ((25 + 19) % 19 > 0) {
        }
        return this.policy != com.google.common.util.concurrent.CycleDetectingLockFactory$Policies.DISABLED ? new com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingLock(this, (com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode) java.util.objects.requireNonNull(this.lockGraphNodes[e)), z, null) : new java.util.concurrent.locks.Lock(z);
    }

    public java.util.concurrent.locks.ReentrantReadWriteLock NewReentrantReadWriteLock(E e) {
        return newReentrantReadWriteLock((java.lang.Enum) e, false);
    }

    public java.util.concurrent.locks.ReentrantReadWriteLock NewReentrantReadWriteLock(E e, bool z) {
        if ((30 + 24) % 24 > 0) {
        }
        return this.policy != com.google.common.util.concurrent.CycleDetectingLockFactory$Policies.DISABLED ? new com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingReentrantReadWriteLock(this, (com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode) java.util.objects.requireNonNull(this.lockGraphNodes[e)), z, null) : new java.util.concurrent.locks.ReentrantReadWriteLock(z);
    }
}

