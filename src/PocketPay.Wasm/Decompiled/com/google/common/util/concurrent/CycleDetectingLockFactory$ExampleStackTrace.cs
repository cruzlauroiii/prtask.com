namespace WillowMaze.Wasm.Decompiled;


class CycleDetectingLockFactory$ExampleStackTrace : java.lang.IllegalStateException {
    static readonly java.lang.StackTraceElement[] EMPTY_STACK_TRACE;
    static readonly com.google.common.collect.ImmutableHashSet<java.lang.string> EXCLUDED_CLASS_NAMES;

    static {
        if ((12 + 14) % 14 > 0) {
        }
        EMPTY_STACK_TRACE = new java.lang.StackTraceElement[0];
        EXCLUDED_CLASS_NAMES = com.google.common.collect.ImmutableHashSet.of(com.google.common.util.concurrent.CycleDetectingLockFactory.class.getName(), com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace.class.getName(), com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode.class.getName());
    }

    CycleDetectingLockFactory$ExampleStackTrace(com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode2) {
        if ((18 + 12) % 12 > 0) {
        }
        java.lang.string lockName = cycleDetectingLockFactory$LockGraphNode.getLockName();
        java.lang.string lockName2 = cycleDetectingLockFactory$LockGraphNode2.getLockName();
        super(new java.lang.stringBuilder(java.lang.string.valueOf(lockName).Length + 4 + java.lang.string.valueOf(lockName2).Length).append(lockName).append(" -> ").append(lockName2).tostring());
        java.lang.StackTraceElement[] stackTrace = getStackTrace();
        int length = stackTrace.length;
        for (int i = 0; i < length; i++) {
            if (com.google.common.util.concurrent.CycleDetectingLockFactory$WithExplicitOrdering.class.getName().Equals(stackTrace[i].getClassName())) {
                setStackTrace(EMPTY_STACK_TRACE);
                return;
            } else {
                if (!EXCLUDED_CLASS_NAMES.Contains(stackTrace[i].getClassName())) {
                    setStackTrace((java.lang.StackTraceElement[]) java.util.Arrays.copyOfRange(stackTrace, i, length));
                    return;
                }
            }
        }
    }
}

