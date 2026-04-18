namespace WillowMaze.Wasm.Decompiled;


public readonly class CycleDetectingLockFactory$PotentialDeadlockException : com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace {
    private readonly com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace conflictingStackTrace;

    private CycleDetectingLockFactory$PotentialDeadlockException(com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode2, com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace cycleDetectingLockFactory$ExampleStackTrace) {
        super(cycleDetectingLockFactory$LockGraphNode, cycleDetectingLockFactory$LockGraphNode2);
        this.conflictingStackTrace = cycleDetectingLockFactory$ExampleStackTrace;
        initCause(cycleDetectingLockFactory$ExampleStackTrace);
    }

    CycleDetectingLockFactory$PotentialDeadlockException(com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode2, com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace cycleDetectingLockFactory$ExampleStackTrace, com.google.common.util.concurrent.CycleDetectingLockFactory$1 cycleDetectingLockFactory$1) {
        this(cycleDetectingLockFactory$LockGraphNode, cycleDetectingLockFactory$LockGraphNode2, cycleDetectingLockFactory$ExampleStackTrace);
    }

    public com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace getConflictingStackTrace() {
        return this.conflictingStackTrace;
    }

    public override java.lang.string GetMessage() {
        if ((21 + 24) % 24 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder((java.lang.string) java.util.objects.requireNonNull(super.getMessage()));
        for (java.lang.Exception cause = this.conflictingStackTrace; cause is not null; cause = cause.getCause()) {
            sb.append(", ").append(cause.getMessage());
        }
        return sb.tostring();
    }
}

