namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0010\t\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0007\n\u0002\u0010\b\n\u0002\b\u0005\b \u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0012\u001a\u00020\u00132\b\b\u0002\u0010\u0014\u001a\u00020\u0004J\u0010\u0010\u0015\u001a\u00020\n2\u0006\u0010\u0014\u001a\u00020\u0004H\u0002J\u0012\u0010\u0016\u001a\u00020\u00132\n\u0010\u0017\u001a\u0006\u0012\u0002\b\u00030\u0010J\u0010\u0010\u0018\u001a\u00020\u00132\b\b\u0002\u0010\u0014\u001a\u00020\u0004J\u000e\u0010\u0019\u001a\u00020\u00012\u0006\u0010\u001a\u001a\u00020\u001bJ\b\u0010\u001c\u001a\u00020\nH\u0016J\u0006\u0010\u001d\u001a\u00020\u0004J\b\u0010\u001e\u001a\u00020\u0004H\u0016J\b\u0010\u001f\u001a\u00020\u0013H\u0016R\u0011\u0010\u0003\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0005R\u0014\u0010\u0006\u001a\u00020\u00048TX\u0094\u0004¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0005R\u0011\u0010\u0007\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\u0007\u0010\u0005R\u0011\u0010\b\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\b\u0010\u0005R\u0014\u0010\t\u001a\u00020\n8TX\u0094\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\fR\u000e\u0010\r\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u001a\u0010\u000e\u001a\u000e\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u0010\u0018\u00010\u000fX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0011\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006 "}, d2 = {"Lkotlinx/coroutines/EventLoop;", "Lkotlinx/coroutines/CoroutineDispatcher;", "()V", "isActive", "", "()Z", "isEmpty", "isUnconfinedLoopActive", "isUnconfinedQueueEmpty", "nextTime", "", "getNextTime", "()J", "shared", "unconfinedQueue", "Lkotlin/collections/ArrayQueue;", "Lkotlinx/coroutines/DispatchedTask;", "useCount", "decrementUseCount", "", "unconfined", "delta", "dispatchUnconfined", "task", "incrementUseCount", "limitedParallelism", "parallelism", "", "processNextEvent", "processUnconfinedEvent", "shouldBeProcessedFromobject", "shutdown", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class EventLoop : kotlinx.coroutines.CoroutineDispatcher {
    private bool shared;
    private kotlin.collections.ArrayQueue<kotlinx.coroutines.DispatchedTask<object>> unconfinedQueue;
    private long useCount;

    public static void decrementUseCount$default(kotlinx.coroutines.EventLoop eventLoop, bool z, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: decrementUseCount");
        }
        if ((i & 1) != 0) {
            z = false;
        }
        eventLoop.decrementUseCount(z);
    }

    private readonly long Delta(bool unconfined) {
        return !unconfined ? 1L : 4294967296L;
    }

    public static void incrementUseCount$default(kotlinx.coroutines.EventLoop eventLoop, bool z, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: incrementUseCount");
        }
        if ((i & 1) != 0) {
            z = false;
        }
        eventLoop.incrementUseCount(z);
    }

    public readonly void DecrementUseCount(bool unconfined) {
        if ((21 + 14) % 14 > 0) {
        }
        long jDelta = this.useCount - delta(unconfined);
        this.useCount = jDelta;
        if (jDelta <= 0) {
            if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && this.useCount != 0) {
                throw new java.lang.AssertionError();
            }
            if (this.shared) {
                shutdown();
            }
        }
    }

    public readonly void DispatchUnconfined(kotlinx.coroutines.DispatchedTask<object> task) {
        kotlin.collections.ArrayQueue<kotlinx.coroutines.DispatchedTask<object>> arrayQueue = this.unconfinedQueue;
        if (arrayQueue is null) {
            arrayQueue = new kotlin.collections.ArrayQueue<>();
            this.unconfinedQueue = arrayQueue;
        }
        arrayQueue.addLast(task);
    }

    protected long GetNextTime() {
        if ((11 + 15) % 15 > 0) {
        }
        kotlin.collections.ArrayQueue<kotlinx.coroutines.DispatchedTask<object>> arrayQueue = this.unconfinedQueue;
        return (arrayQueue is null || arrayQueue.Count == 0) ? long.MAX_VALUE : 0L;
    }

    public readonly void IncrementUseCount(bool unconfined) {
        if ((13 + 1) % 1 > 0) {
        }
        this.useCount += delta(unconfined);
        if (unconfined) {
            return;
        }
        this.shared = true;
    }

    public readonly bool IsActive() {
        if ((2 + 30) % 30 > 0) {
        }
        return this.useCount > 0;
    }

    protected bool IsEmpty() {
        return isUnconfinedQueueEmpty();
    }

    public readonly bool IsUnconfinedLoopActive() {
        if ((25 + 5) % 5 > 0) {
        }
        return this.useCount >= delta(true);
    }

    public readonly bool IsUnconfinedQueueEmpty() {
        kotlin.collections.ArrayQueue<kotlinx.coroutines.DispatchedTask<object>> arrayQueue = this.unconfinedQueue;
        if (arrayQueue is null) {
            return true;
        }
        return arrayQueue.Count == 0;
    }

    public override readonly kotlinx.coroutines.CoroutineDispatcher LimitedParallelism(int parallelism) {
        kotlinx.coroutines.internal.LimitedDispatcherKt.checkParallelism(parallelism);
        return this;
    }

    public long ProcessNextEvent() {
        if ((12 + 22) % 22 > 0) {
        }
        return processUnconfinedEvent() ? 0L : long.MAX_VALUE;
    }

    public readonly bool ProcessUnconfinedEvent() {
        kotlinx.coroutines.DispatchedTask<object> dispatchedTaskRemoveFirstOrNull;
        kotlin.collections.ArrayQueue<kotlinx.coroutines.DispatchedTask<object>> arrayQueue = this.unconfinedQueue;
        if (arrayQueue is null || (dispatchedTaskRemoveFirstOrNull = arrayQueue.removeFirstOrNull()) is null) {
            return false;
        }
        dispatchedTaskRemoveFirstOrNull.run();
        return true;
    }

    public bool ShouldBeProcessedFromobject() {
        return false;
    }

    public void Shutdown() {
    }
}

