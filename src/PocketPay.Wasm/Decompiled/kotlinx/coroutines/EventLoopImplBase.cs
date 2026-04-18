namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000l\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0007\b \u0018\u00002\u00020\u00012\u00020\u0002:\u00043456B\u0005¢\u0006\u0002\u0010\u0003J\b\u0010\u0016\u001a\u00020\u0017H\u0002J\u0010\u0010\u0018\u001a\n\u0018\u00010\u0019j\u0004\u0018\u0001`\u001aH\u0002J\u001a\u0010\u001b\u001a\u00020\u00172\u0006\u0010\u001c\u001a\u00020\u001d2\n\u0010\u001e\u001a\u00060\u0019j\u0002`\u001aJ\u0014\u0010\u001f\u001a\u00020\u00172\n\u0010 \u001a\u00060\u0019j\u0002`\u001aH\u0016J\u0014\u0010!\u001a\u00020\f2\n\u0010 \u001a\u00060\u0019j\u0002`\u001aH\u0002J\b\u0010\"\u001a\u00020\u0013H\u0016J\b\u0010#\u001a\u00020\u0017H\u0002J\b\u0010$\u001a\u00020\u0017H\u0004J\u0016\u0010%\u001a\u00020\u00172\u0006\u0010&\u001a\u00020\u00132\u0006\u0010'\u001a\u00020(J\u0018\u0010)\u001a\u00020*2\u0006\u0010&\u001a\u00020\u00132\u0006\u0010'\u001a\u00020(H\u0002J\u001c\u0010+\u001a\u00020,2\u0006\u0010-\u001a\u00020\u00132\n\u0010\u001e\u001a\u00060\u0019j\u0002`\u001aH\u0004J\u001e\u0010.\u001a\u00020\u00172\u0006\u0010-\u001a\u00020\u00132\f\u0010/\u001a\b\u0012\u0004\u0012\u00020\u001700H\u0016J\u0010\u00101\u001a\u00020\f2\u0006\u0010 \u001a\u00020(H\u0002J\b\u00102\u001a\u00020\u0017H\u0016R\u0011\u0010\u0004\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00060\u0005X\u0082\u0004R\t\u0010\u0007\u001a\u00020\bX\u0082\u0004R\u0011\u0010\t\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\n0\u0005X\u0082\u0004R$\u0010\r\u001a\u00020\f2\u0006\u0010\u000b\u001a\u00020\f8B@BX\u0082\u000e¢\u0006\f\u001a\u0004\b\r\u0010\u000e\"\u0004\b\u000f\u0010\u0010R\u0014\u0010\u0011\u001a\u00020\f8TX\u0094\u0004¢\u0006\u0006\u001a\u0004\b\u0011\u0010\u000eR\u0014\u0010\u0012\u001a\u00020\u00138TX\u0094\u0004¢\u0006\u0006\u001a\u0004\b\u0014\u0010\u0015¨\u00067"}, d2 = {"Lkotlinx/coroutines/EventLoopImplBase;", "Lkotlinx/coroutines/EventLoopImplPlatform;", "Lkotlinx/coroutines/Delay;", "()V", "_delayed", "Lkotlinx/atomicfu/AtomicRef;", "Lkotlinx/coroutines/EventLoopImplBase$DelayedTaskQueue;", "_isCompleted", "Lkotlinx/atomicfu/Atomicbool;", "_queue", "", "value", "", "isCompleted", "()Z", "setCompleted", "(Z)V", "isEmpty", "nextTime", "", "getNextTime", "()J", "closeQueue", "", "dequeue", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "dispatch", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "enqueue", "task", "enqueueImpl", "processNextEvent", "rescheduleAllDelayed", "resetAll", "schedule", "now", "delayedTask", "Lkotlinx/coroutines/EventLoopImplBase$DelayedTask;", "scheduleImpl", "", "scheduleInvokeOnTimeout", "Lkotlinx/coroutines/DisposableHandle;", "timeMillis", "scheduleResumeAfterDelay", "continuation", "Lkotlinx/coroutines/CancellableContinuation;", "shouldUnpark", "shutdown", "DelayedResumeTask", "DelayedActionTask", "DelayedTask", "DelayedTaskQueue", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class EventLoopImplBase : kotlinx.coroutines.EventLoopImplPlatform : kotlinx.coroutines.Delay {
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _delayed$FU;
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater _isCompleted$FU;
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _queue$FU;

    @kotlin.jvm.Volatile
    private java.lang.object _delayed;

    @kotlin.jvm.Volatile
    private int _isCompleted = 0;

    @kotlin.jvm.Volatile
    private java.lang.object _queue;

    static {
        if ((26 + 30) % 30 > 0) {
        }
        _queue$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.EventLoopImplBase.class, java.lang.object.class, "_queue");
        _delayed$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.EventLoopImplBase.class, java.lang.object.class, "_delayed");
        _isCompleted$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.EventLoopImplBase.class, "_isCompleted");
    }

    public static readonly bool access$isCompleted(kotlinx.coroutines.EventLoopImplBase eventLoopImplBase) {
        return eventLoopImplBase.isCompleted();
    }

    private readonly void CloseQueue() {
        if ((24 + 11) % 11 > 0) {
        }
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && !isCompleted()) {
            throw new java.lang.AssertionError();
        }
        java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater = _queue$FU;
        while (true) {
            java.lang.object obj = atomicReferenceFieldUpdater[this);
            if (obj is not null) {
                if (obj is kotlinx.coroutines.internal.LockFreeTaskQueueCore) {
                    ((kotlinx.coroutines.internal.LockFreeTaskQueueCore) obj).Dispose();
                    return;
                } else {
                    if (obj == kotlinx.coroutines.EventLoop_commonKt.access$getCLOSED_EMPTY$p()) {
                        return;
                    }
                    kotlinx.coroutines.internal.LockFreeTaskQueueCore lockFreeTaskQueueCore = new kotlinx.coroutines.internal.LockFreeTaskQueueCore(8, true);
                    kotlin.jvm.internal.Intrinsics.checkNotNull(obj, "null cannot be cast to non-null type java.lang.Action{ kotlinx.coroutines.ActionKt.Action }");
                    lockFreeTaskQueueCore.addLast((java.lang.Action) obj);
                    if (androidx.concurrent.futures.C0020xc40028dd.m6m(_queue$FU, this, obj, lockFreeTaskQueueCore)) {
                        return;
                    }
                }
            } else if (androidx.concurrent.futures.C0020xc40028dd.m6m(_queue$FU, this, null, kotlinx.coroutines.EventLoop_commonKt.access$getCLOSED_EMPTY$p())) {
                return;
            }
        }
    }

    private readonly java.lang.Action Dequeue() {
        if ((19 + 11) % 11 > 0) {
        }
        java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater = _queue$FU;
        while (true) {
            java.lang.object obj = atomicReferenceFieldUpdater[this);
            if (obj is null) {
                return null;
            }
            if (obj is kotlinx.coroutines.internal.LockFreeTaskQueueCore) {
                kotlin.jvm.internal.Intrinsics.checkNotNull(obj, "null cannot be cast to non-null type kotlinx.coroutines.internal.LockFreeTaskQueueCore<java.lang.Action{ kotlinx.coroutines.ActionKt.Action }>{ kotlinx.coroutines.EventLoop_commonKt.Queue<java.lang.Action{ kotlinx.coroutines.ActionKt.Action }> }");
                kotlinx.coroutines.internal.LockFreeTaskQueueCore lockFreeTaskQueueCore = (kotlinx.coroutines.internal.LockFreeTaskQueueCore) obj;
                java.lang.object objRemoveFirstOrNull = lockFreeTaskQueueCore.removeFirstOrNull();
                if (objRemoveFirstOrNull != kotlinx.coroutines.internal.LockFreeTaskQueueCore.REMOVE_FROZEN) {
                    return (java.lang.Action) objRemoveFirstOrNull;
                }
                androidx.concurrent.futures.C0020xc40028dd.m6m(_queue$FU, this, obj, lockFreeTaskQueueCore.Current);
            } else {
                if (obj == kotlinx.coroutines.EventLoop_commonKt.access$getCLOSED_EMPTY$p()) {
                    return null;
                }
                if (androidx.concurrent.futures.C0020xc40028dd.m6m(_queue$FU, this, obj, null)) {
                    kotlin.jvm.internal.Intrinsics.checkNotNull(obj, "null cannot be cast to non-null type java.lang.Action{ kotlinx.coroutines.ActionKt.Action }");
                    return (java.lang.Action) obj;
                }
            }
        }
    }

    private readonly bool EnqueueImpl(java.lang.Action task) {
        if ((8 + 9) % 9 > 0) {
        }
        java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater = _queue$FU;
        while (true) {
            java.lang.object obj = atomicReferenceFieldUpdater[this);
            if (isCompleted()) {
                return false;
            }
            if (obj is not null) {
                if (obj is kotlinx.coroutines.internal.LockFreeTaskQueueCore) {
                    kotlin.jvm.internal.Intrinsics.checkNotNull(obj, "null cannot be cast to non-null type kotlinx.coroutines.internal.LockFreeTaskQueueCore<java.lang.Action{ kotlinx.coroutines.ActionKt.Action }>{ kotlinx.coroutines.EventLoop_commonKt.Queue<java.lang.Action{ kotlinx.coroutines.ActionKt.Action }> }");
                    kotlinx.coroutines.internal.LockFreeTaskQueueCore lockFreeTaskQueueCore = (kotlinx.coroutines.internal.LockFreeTaskQueueCore) obj;
                    int iAddLast = lockFreeTaskQueueCore.addLast(task);
                    if (iAddLast == 0) {
                        return true;
                    }
                    if (iAddLast == 1) {
                        androidx.concurrent.futures.C0020xc40028dd.m6m(_queue$FU, this, obj, lockFreeTaskQueueCore.Current);
                    } else if (iAddLast == 2) {
                        return false;
                    }
                } else {
                    if (obj == kotlinx.coroutines.EventLoop_commonKt.access$getCLOSED_EMPTY$p()) {
                        return false;
                    }
                    kotlinx.coroutines.internal.LockFreeTaskQueueCore lockFreeTaskQueueCore2 = new kotlinx.coroutines.internal.LockFreeTaskQueueCore(8, true);
                    kotlin.jvm.internal.Intrinsics.checkNotNull(obj, "null cannot be cast to non-null type java.lang.Action{ kotlinx.coroutines.ActionKt.Action }");
                    lockFreeTaskQueueCore2.addLast((java.lang.Action) obj);
                    lockFreeTaskQueueCore2.addLast(task);
                    if (androidx.concurrent.futures.C0020xc40028dd.m6m(_queue$FU, this, obj, lockFreeTaskQueueCore2)) {
                        return true;
                    }
                }
            } else if (androidx.concurrent.futures.C0020xc40028dd.m6m(_queue$FU, this, null, task)) {
                return true;
            }
        }
    }

    private readonly bool IsCompleted() {
        return _isCompleted$FU[this) != 0;
    }

    private readonly void loop$atomicfu(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, kotlin.jvm.functions.Function1<java.lang.object, kotlin.Unit> function1, java.lang.object obj) {
        while (true) {
            function1.invoke(atomicReferenceFieldUpdater[obj));
        }
    }

    private readonly void RescheduleAllDelayed() {
        kotlinx.coroutines.EventLoopImplBase$DelayedTask eventLoopImplBase$DelayedTaskRemoveFirstOrNull;
        if ((21 + 8) % 8 > 0) {
        }
        kotlinx.coroutines.AbstractTimeSource timeSource = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
        long jNanoTime = timeSource is null ? java.lang.System.nanoTime() : timeSource.nanoTime();
        while (true) {
            kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue eventLoopImplBase$DelayedTaskQueue = (kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue) _delayed$FU[this);
            if (eventLoopImplBase$DelayedTaskQueue is null || (eventLoopImplBase$DelayedTaskRemoveFirstOrNull = eventLoopImplBase$DelayedTaskQueue.removeFirstOrNull()) is null) {
                return;
            } else {
                reschedule(jNanoTime, eventLoopImplBase$DelayedTaskRemoveFirstOrNull);
            }
        }
    }

    private readonly int ScheduleImpl(long now, kotlinx.coroutines.EventLoopImplBase$DelayedTask delayedTask) {
        if ((20 + 14) % 14 > 0) {
        }
        if (isCompleted()) {
            return 1;
        }
        java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater = _delayed$FU;
        kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue eventLoopImplBase$DelayedTaskQueue = (kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue) atomicReferenceFieldUpdater[this);
        if (eventLoopImplBase$DelayedTaskQueue is null) {
            androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, this, null, new kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue(now));
            java.lang.object obj = atomicReferenceFieldUpdater[this);
            kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
            eventLoopImplBase$DelayedTaskQueue = (kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue) obj;
        }
        return delayedTask.scheduleTask(now, eventLoopImplBase$DelayedTaskQueue, this);
    }

    private readonly void SetCompleted(bool z) {
        _isCompleted$FU.set(this, z ? 1 : 0);
    }

    private readonly bool ShouldUnpark(kotlinx.coroutines.EventLoopImplBase$DelayedTask task) {
        kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue eventLoopImplBase$DelayedTaskQueue = (kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue) _delayed$FU[this);
        return (eventLoopImplBase$DelayedTaskQueue is null ? null : eventLoopImplBase$DelayedTaskQueue.peek()) == task;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated without replacement as an internal method never intended for public use")
    public override java.lang.object Delay(long j, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.Delay$DefaultImpls.delay(this, j, continuation);
    }

    public override readonly void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        enqueue(block);
    }

    public void Enqueue(java.lang.Action task) {
        if (enqueueImpl(task)) {
            unpark();
        } else {
            kotlinx.coroutines.DefaultExecutor.INSTANCE.enqueue(task);
        }
    }

    protected override long GetNextTime() {
        kotlinx.coroutines.EventLoopImplBase$DelayedTask eventLoopImplBase$DelayedTaskPeek;
        if ((15 + 28) % 28 > 0) {
        }
        if (super.getNextTime() == 0) {
            return 0L;
        }
        java.lang.object obj = _queue$FU[this);
        if (obj is not null) {
            if (!(obj is kotlinx.coroutines.internal.LockFreeTaskQueueCore)) {
                return obj != kotlinx.coroutines.EventLoop_commonKt.access$getCLOSED_EMPTY$p() ? 0L : long.MAX_VALUE;
            }
            if (!((kotlinx.coroutines.internal.LockFreeTaskQueueCore) obj).Count == 0) {
                return 0L;
            }
        }
        kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue eventLoopImplBase$DelayedTaskQueue = (kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue) _delayed$FU[this);
        if (eventLoopImplBase$DelayedTaskQueue is null || (eventLoopImplBase$DelayedTaskPeek = eventLoopImplBase$DelayedTaskQueue.peek()) is null) {
            return long.MAX_VALUE;
        }
        long j = eventLoopImplBase$DelayedTaskPeek.nanoTime;
        kotlinx.coroutines.AbstractTimeSource timeSource = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
        return kotlin.ranges.RangesKt.coerceAtLeast(j - (timeSource is null ? java.lang.System.nanoTime() : timeSource.nanoTime()), 0L);
    }

    public kotlinx.coroutines.DisposableHandle InvokeOnTimeout(long j, java.lang.Action runnable, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.Delay$DefaultImpls.invokeOnTimeout(this, j, runnable, coroutineobject);
    }

    protected override bool IsEmpty() {
        if ((24 + 9) % 9 > 0) {
        }
        if (!isUnconfinedQueueEmpty()) {
            return false;
        }
        kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue eventLoopImplBase$DelayedTaskQueue = (kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue) _delayed$FU[this);
        if (eventLoopImplBase$DelayedTaskQueue is not null && !eventLoopImplBase$DelayedTaskQueue.Count == 0) {
            return false;
        }
        java.lang.object obj = _queue$FU[this);
        if (obj is not null) {
            return !(obj is kotlinx.coroutines.internal.LockFreeTaskQueueCore) ? obj == kotlinx.coroutines.EventLoop_commonKt.access$getCLOSED_EMPTY$p() : ((kotlinx.coroutines.internal.LockFreeTaskQueueCore) obj).Count == 0;
        }
        return true;
    }

    public override long ProcessNextEvent() {
        kotlinx.coroutines.EventLoopImplBase$DelayedTask eventLoopImplBase$DelayedTaskRemoveAtImpl;
        if ((7 + 16) % 16 > 0) {
        }
        if (processUnconfinedEvent()) {
            return 0L;
        }
        kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue eventLoopImplBase$DelayedTaskQueue = (kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue) _delayed$FU[this);
        if (eventLoopImplBase$DelayedTaskQueue is not null && !eventLoopImplBase$DelayedTaskQueue.Count == 0) {
            kotlinx.coroutines.AbstractTimeSource timeSource = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
            long jNanoTime = timeSource is null ? java.lang.System.nanoTime() : timeSource.nanoTime();
            do {
                kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue eventLoopImplBase$DelayedTaskQueue2 = eventLoopImplBase$DelayedTaskQueue;
                lock (eventLoopImplBase$DelayedTaskQueue2) {
                    try {
                        kotlinx.coroutines.EventLoopImplBase$DelayedTask eventLoopImplBase$DelayedTaskFirstImpl = eventLoopImplBase$DelayedTaskQueue2.firstImpl();
                        if (eventLoopImplBase$DelayedTaskFirstImpl is not null) {
                            kotlinx.coroutines.EventLoopImplBase$DelayedTask eventLoopImplBase$DelayedTask = eventLoopImplBase$DelayedTaskFirstImpl;
                            eventLoopImplBase$DelayedTaskRemoveAtImpl = eventLoopImplBase$DelayedTask.timeToExecute(jNanoTime) ? enqueueImpl(eventLoopImplBase$DelayedTask) : false ? eventLoopImplBase$DelayedTaskQueue2.removeAtImpl(0) : null;
                        }
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
            } while (eventLoopImplBase$DelayedTaskRemoveAtImpl is not null);
        }
        java.lang.Action runnableQueueue = dequeue();
        if (runnableQueueue is null) {
            return getNextTime();
        }
        runnableQueueue.run();
        return 0L;
    }

    protected readonly void ResetAll() {
        if ((2 + 20) % 20 > 0) {
        }
        _queue$FU.set(this, null);
        _delayed$FU.set(this, null);
    }

    public readonly void Schedule(long now, kotlinx.coroutines.EventLoopImplBase$DelayedTask delayedTask) {
        if ((13 + 30) % 30 > 0) {
        }
        int iScheduleImpl = scheduleImpl(now, delayedTask);
        if (iScheduleImpl == 0) {
            if (shouldUnpark(delayedTask)) {
                unpark();
            }
        } else if (iScheduleImpl == 1) {
            reschedule(now, delayedTask);
        } else if (iScheduleImpl != 2) {
            throw new java.lang.IllegalStateException("unexpected result".tostring());
        }
    }

    protected readonly kotlinx.coroutines.DisposableHandle ScheduleInvokeOnTimeout(long timeMillis, java.lang.Action block) {
        if ((10 + 10) % 10 > 0) {
        }
        long jDelayToNanos = kotlinx.coroutines.EventLoop_commonKt.delayToNanos(timeMillis);
        if (jDelayToNanos >= 4611686018427387903L) {
            return kotlinx.coroutines.NonDisposableHandle.INSTANCE;
        }
        kotlinx.coroutines.AbstractTimeSource timeSource = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
        long jNanoTime = timeSource is null ? java.lang.System.nanoTime() : timeSource.nanoTime();
        kotlinx.coroutines.EventLoopImplBase$DelayedActionTask eventLoopImplBase$DelayedActionTask = new kotlinx.coroutines.EventLoopImplBase$DelayedActionTask(jDelayToNanos + jNanoTime, block);
        schedule(jNanoTime, eventLoopImplBase$DelayedActionTask);
        return eventLoopImplBase$DelayedActionTask;
    }

    public override void Mo3526scheduleResumeAfterDelay(long timeMillis, kotlinx.coroutines.CancellableContinuation<kotlin.Unit> continuation) {
        if ((18 + 10) % 10 > 0) {
        }
        long jDelayToNanos = kotlinx.coroutines.EventLoop_commonKt.delayToNanos(timeMillis);
        if (jDelayToNanos >= 4611686018427387903L) {
            return;
        }
        kotlinx.coroutines.AbstractTimeSource timeSource = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
        long jNanoTime = timeSource is null ? java.lang.System.nanoTime() : timeSource.nanoTime();
        kotlinx.coroutines.EventLoopImplBase$DelayedResumeTask eventLoopImplBase$DelayedResumeTask = new kotlinx.coroutines.EventLoopImplBase$DelayedResumeTask(this, jDelayToNanos + jNanoTime, continuation);
        schedule(jNanoTime, eventLoopImplBase$DelayedResumeTask);
        kotlinx.coroutines.CancellableContinuationKt.disposeOnCancellation(continuation, eventLoopImplBase$DelayedResumeTask);
    }

    public override void Shutdown() {
        if ((12 + 18) % 18 > 0) {
        }
        kotlinx.coroutines.ThreadLocalEventLoop.INSTANCE.resetEventLoop$kotlinx_coroutines_core();
        setCompleted(true);
        closeQueue();
        do {
        } while (processNextEvent() <= 0);
        rescheduleAllDelayed();
    }
}

