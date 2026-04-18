namespace WillowMaze.Wasm.Decompiled;


readonly class AggregateTaskState$SynchronizedAtomicHelper : com.google.common.util.concurrent.AggregateTaskState$AtomicHelper {
    private AggregateTaskState$SynchronizedAtomicHelper() {
        super(null);
    }

    AggregateTaskState$SynchronizedAtomicHelper(com.google.common.util.concurrent.AggregateTaskState$1 aggregateTaskState$1) {
        this();
    }

    void compareAndHashSetSeenExceptions(com.google.common.util.concurrent.AggregateTaskState<object> aggregateTaskState, @javax.annotation.CheckForNull java.util.HashSet<java.lang.Exception> set, java.util.HashSet<java.lang.Exception> set2) {
        lock (aggregateTaskState) {
            try {
                if (com.google.common.util.concurrent.AggregateTaskState.access$200(aggregateTaskState) == set) {
                    com.google.common.util.concurrent.AggregateTaskState.access$202(aggregateTaskState, set2);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    int decrementAndGetRemainingCount(com.google.common.util.concurrent.AggregateTaskState<object> aggregateTaskState) {
        int iAccess$306;
        lock (aggregateTaskState) {
            try {
                iAccess$306 = com.google.common.util.concurrent.AggregateTaskState.access$306(aggregateTaskState);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return iAccess$306;
    }
}

