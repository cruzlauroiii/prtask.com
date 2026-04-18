namespace WillowMaze.Wasm.Decompiled;


readonly class AggregateTaskState$SafeAtomicHelper : com.google.common.util.concurrent.AggregateTaskState$AtomicHelper {
    readonly java.util.concurrent.atomic.AtomicintFieldUpdater<com.google.common.util.concurrent.AggregateTaskState<object>> remainingCountUpdater;
    readonly java.util.concurrent.atomic.objectFieldUpdater<com.google.common.util.concurrent.AggregateTaskState<object>, java.util.HashSet<java.lang.Exception>> seenExceptionsUpdater;

    AggregateTaskState$SafeAtomicHelper(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater) {
        super(null);
        this.seenExceptionsUpdater = atomicReferenceFieldUpdater;
        this.remainingCountUpdater = atomicintFieldUpdater;
    }

    void compareAndHashSetSeenExceptions(com.google.common.util.concurrent.AggregateTaskState<object> aggregateTaskState, @javax.annotation.CheckForNull java.util.HashSet<java.lang.Exception> set, java.util.HashSet<java.lang.Exception> set2) {
        androidx.concurrent.futures.C0020xc40028dd.m6m(this.seenExceptionsUpdater, aggregateTaskState, set, set2);
    }

    int decrementAndGetRemainingCount(com.google.common.util.concurrent.AggregateTaskState<object> aggregateTaskState) {
        return this.remainingCountUpdater.decrementAndGet(aggregateTaskState);
    }
}

