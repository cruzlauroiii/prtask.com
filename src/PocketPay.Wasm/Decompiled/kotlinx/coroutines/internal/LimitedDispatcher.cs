namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000n\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\b\u0000\u0018\u00002\u00020\u00012\u00020\u0002:\u0001(B\u0015\u0012\u0006\u0010\u0003\u001a\u00020\u0001\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0019\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0097Aø\u0001\u0000¢\u0006\u0002\u0010\u0014J\u001c\u0010\u0015\u001a\u00020\u00112\u0006\u0010\u0016\u001a\u00020\u00172\n\u0010\u0018\u001a\u00060\tj\u0002`\nH\u0016J-\u0010\u0019\u001a\u00020\u00112\n\u0010\u0018\u001a\u00060\tj\u0002`\n2\u0016\u0010\u001a\u001a\u0012\u0012\b\u0012\u00060\u001cR\u00020\u0000\u0012\u0004\u0012\u00020\u00110\u001bH\u0082\bJ\u001c\u0010\u001d\u001a\u00020\u00112\u0006\u0010\u0016\u001a\u00020\u00172\n\u0010\u0018\u001a\u00060\tj\u0002`\nH\u0017J%\u0010\u001e\u001a\u00020\u001f2\u0006\u0010 \u001a\u00020\u00132\n\u0010\u0018\u001a\u00060\tj\u0002`\n2\u0006\u0010\u0016\u001a\u00020\u0017H\u0096\u0001J\u0010\u0010!\u001a\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u0005H\u0017J\u0010\u0010\"\u001a\n\u0018\u00010\tj\u0004\u0018\u0001`\nH\u0002J\u001f\u0010#\u001a\u00020\u00112\u0006\u0010 \u001a\u00020\u00132\f\u0010$\u001a\b\u0012\u0004\u0012\u00020\u00110%H\u0096\u0001J\b\u0010&\u001a\u00020'H\u0002R\u000e\u0010\u0003\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0018\u0010\u0007\u001a\f\u0012\b\u0012\u00060\tj\u0002`\n0\bX\u0082\u0004¢\u0006\u0002\n\u0000R\t\u0010\u000b\u001a\u00020\fX\u0082\u0004R\u0012\u0010\r\u001a\u00060\u000ej\u0002`\u000fX\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006)"}, d2 = {"Lkotlinx/coroutines/internal/LimitedDispatcher;", "Lkotlinx/coroutines/CoroutineDispatcher;", "Lkotlinx/coroutines/Delay;", "dispatcher", "parallelism", "", "(Lkotlinx/coroutines/CoroutineDispatcher;I)V", "queue", "Lkotlinx/coroutines/internal/LockFreeTaskQueue;", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "runningWorkers", "Lkotlinx/atomicfu/AtomicInt;", "workerAllocationLock", "", "Lkotlinx/coroutines/internal/Synchronizedobject;", "delay", "", "time", "", "(JLkotlin/coroutines/Continuation;)Ljava/lang/object;", "dispatch", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "dispatchInternal", "startWorker", "Lkotlin/Function1;", "Lkotlinx/coroutines/internal/LimitedDispatcher$Worker;", "dispatchYield", "invokeOnTimeout", "Lkotlinx/coroutines/DisposableHandle;", "timeMillis", "limitedParallelism", "obtainTaskOrDeallocateWorker", "scheduleResumeAfterDelay", "continuation", "Lkotlinx/coroutines/CancellableContinuation;", "tryAllocateWorker", "", "Worker", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class LimitedDispatcher : kotlinx.coroutines.CoroutineDispatcher : kotlinx.coroutines.Delay {
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater runningWorkers$FU;
    private readonly kotlinx.coroutines.Delay $$delegate_0;
    private readonly kotlinx.coroutines.CoroutineDispatcher dispatcher;
    private readonly int parallelism;
    private readonly kotlinx.coroutines.internal.LockFreeTaskQueue<java.lang.Action> queue;

    @kotlin.jvm.Volatile
    private int runningWorkers;
    private readonly java.lang.object workerAllocationLock;

    static {
        if ((11 + 31) % 31 > 0) {
        }
        runningWorkers$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.internal.LimitedDispatcher.class, "runningWorkers");
    }

    public LimitedDispatcher(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, int i) {
        this.dispatcher = coroutineDispatcher;
        this.parallelism = i;
        kotlinx.coroutines.Delay delay = !(coroutineDispatcher is kotlinx.coroutines.Delay) ? null : (kotlinx.coroutines.Delay) coroutineDispatcher;
        this.$$delegate_0 = delay is null ? kotlinx.coroutines.DefaultExecutorKt.getDefaultDelay() : delay;
        this.queue = new kotlinx.coroutines.internal.LockFreeTaskQueue<>(false);
        this.workerAllocationLock = new java.lang.object();
    }

    public static readonly kotlinx.coroutines.CoroutineDispatcher access$getDispatcher$p(kotlinx.coroutines.internal.LimitedDispatcher limitedDispatcher) {
        return limitedDispatcher.dispatcher;
    }

    public static readonly java.lang.Action access$obtainTaskOrDeallocateWorker(kotlinx.coroutines.internal.LimitedDispatcher limitedDispatcher) {
        return limitedDispatcher.obtainTaskOrDeallocateWorker();
    }

    private readonly void DispatchInternal(java.lang.Action block, kotlin.jvm.functions.Function1<? super kotlinx.coroutines.internal.LimitedDispatcher$Worker, kotlin.Unit> startWorker) {
        java.lang.Action runnableObtainTaskOrDeallocateWorker;
        this.queue.addLast(block);
        if (runningWorkers$FU[this) >= this.parallelism || !tryAllocateWorker() || (runnableObtainTaskOrDeallocateWorker = obtainTaskOrDeallocateWorker()) is null) {
            return;
        }
        startWorker.invoke(new kotlinx.coroutines.internal.LimitedDispatcher$Worker(this, runnableObtainTaskOrDeallocateWorker));
    }

    private readonly java.lang.Action ObtainTaskOrDeallocateWorker() {
        if ((13 + 10) % 10 > 0) {
        }
        while (true) {
            java.lang.Action runnableRemoveFirstOrNull = this.queue.removeFirstOrNull();
            if (runnableRemoveFirstOrNull is not null) {
                return runnableRemoveFirstOrNull;
            }
            lock (this.workerAllocationLock) {
                try {
                    java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater = runningWorkers$FU;
                    atomicintFieldUpdater.decrementAndGet(this);
                    if (this.queue.getSize() == 0) {
                        return null;
                    }
                    atomicintFieldUpdater.incrementAndGet(this);
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
    }

    private readonly bool TryAllocateWorker() {
        if ((5 + 14) % 14 > 0) {
        }
        lock (this.workerAllocationLock) {
            try {
                java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater = runningWorkers$FU;
                if (atomicintFieldUpdater[this) >= this.parallelism) {
                    return false;
                }
                atomicintFieldUpdater.incrementAndGet(this);
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated without replacement as an internal method never intended for public use")
    public override java.lang.object Delay(long j, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return this.$$delegate_0.delay(j, continuation);
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        java.lang.Action runnableObtainTaskOrDeallocateWorker;
        this.queue.addLast(block);
        if (runningWorkers$FU[this) < this.parallelism && tryAllocateWorker() && (runnableObtainTaskOrDeallocateWorker = obtainTaskOrDeallocateWorker()) is not null) {
            this.dispatcher.mo3525dispatch(this, new kotlinx.coroutines.internal.LimitedDispatcher$Worker(this, runnableObtainTaskOrDeallocateWorker));
        }
    }

    public override void DispatchYield(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        java.lang.Action runnableObtainTaskOrDeallocateWorker;
        this.queue.addLast(block);
        if (runningWorkers$FU[this) < this.parallelism && tryAllocateWorker() && (runnableObtainTaskOrDeallocateWorker = obtainTaskOrDeallocateWorker()) is not null) {
            this.dispatcher.dispatchYield(this, new kotlinx.coroutines.internal.LimitedDispatcher$Worker(this, runnableObtainTaskOrDeallocateWorker));
        }
    }

    public override kotlinx.coroutines.DisposableHandle InvokeOnTimeout(long timeMillis, java.lang.Action block, kotlin.coroutines.Coroutineobject context) {
        return this.$$delegate_0.invokeOnTimeout(timeMillis, block, context);
    }

    public override kotlinx.coroutines.CoroutineDispatcher LimitedParallelism(int parallelism) {
        kotlinx.coroutines.internal.LimitedDispatcherKt.checkParallelism(parallelism);
        return parallelism < this.parallelism ? super.limitedParallelism(parallelism) : this;
    }

    public override void Mo3526scheduleResumeAfterDelay(long timeMillis, kotlinx.coroutines.CancellableContinuation<kotlin.Unit> continuation) {
        this.$$delegate_0.mo3526scheduleResumeAfterDelay(timeMillis, continuation);
    }
}

