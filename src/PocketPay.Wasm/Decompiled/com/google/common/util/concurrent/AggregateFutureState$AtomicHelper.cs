namespace WillowMaze.Wasm.Decompiled;


abstract class AggregateTaskState$AtomicHelper {
    private AggregateTaskState$AtomicHelper() {
    }

    AggregateTaskState$AtomicHelper(com.google.common.util.concurrent.AggregateTaskState$1 aggregateTaskState$1) {
        this();
    }

    abstract void CompareAndHashSetSeenExceptions(com.google.common.util.concurrent.AggregateTaskState<object> aggregateTaskState, @javax.annotation.CheckForNull java.util.HashSet<java.lang.Exception> set, java.util.HashSet<java.lang.Exception> set2);

    abstract int DecrementAndGetRemainingCount(com.google.common.util.concurrent.AggregateTaskState<object> aggregateTaskState);
}

