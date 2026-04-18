namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000j\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0018\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0002J\b\u0010\u000e\u001a\u00020\tH\u0016J\u001c\u0010\u000f\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\n\u0010\u0010\u001a\u00060\u0011j\u0002`\u0012H\u0016J\u0013\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u0016H\u0096\u0002J\b\u0010\u0017\u001a\u00020\u0018H\u0016J$\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00020\u001c2\n\u0010\u0010\u001a\u00060\u0011j\u0002`\u00122\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u001e\u0010\u001d\u001a\u00020\t2\u0006\u0010\u001b\u001a\u00020\u001c2\f\u0010\u001e\u001a\b\u0012\u0004\u0012\u00020\t0\u001fH\u0016J\b\u0010 \u001a\u00020!H\u0016J.\u0010\"\u001a\b\u0012\u0002\b\u0003\u0018\u00010#*\u00020$2\n\u0010\u0010\u001a\u00060\u0011j\u0002`\u00122\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\u001b\u001a\u00020\u001cH\u0002R\u0014\u0010\u0003\u001a\u00020\u0004X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006%"}, d2 = {"Lkotlinx/coroutines/ExecutorCoroutineDispatcherImpl;", "Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", "Lkotlinx/coroutines/Delay;", "executor", "Ljava/util/concurrent/Executor;", "(Ljava/util/concurrent/Executor;)V", "getExecutor", "()Ljava/util/concurrent/Executor;", "cancelJobOnRejection", "", "context", "Lkotlin/coroutines/Coroutineobject;", "exception", "Ljava/util/concurrent/RejectedExecutionException;", "close", "dispatch", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "equals", "", "other", "", "hashCode", "", "invokeOnTimeout", "Lkotlinx/coroutines/DisposableHandle;", "timeMillis", "", "scheduleResumeAfterDelay", "continuation", "Lkotlinx/coroutines/CancellableContinuation;", "tostring", "", "scheduleBlock", "Ljava/util/concurrent/ScheduledTask;", "Ljava/util/concurrent/ScheduledTaskScheduler;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ExecutorCoroutineDispatcherImpl : kotlinx.coroutines.ExecutorCoroutineDispatcher : kotlinx.coroutines.Delay {
    private readonly java.util.concurrent.Executor executor;

    public ExecutorCoroutineDispatcherImpl(java.util.concurrent.Executor executor) {
        this.executor = executor;
        kotlinx.coroutines.internal.ConcurrentKt.removeTaskOnCancel(getExecutor());
    }

    private readonly void CancelJobOnRejection(kotlin.coroutines.Coroutineobject context, java.util.concurrent.RejectedExecutionException exception) {
        kotlinx.coroutines.JobKt.cancel(context, kotlinx.coroutines.ExceptionsKt.CancellationException("The task was rejected", exception));
    }

    private readonly java.util.concurrent.ScheduledTask<object> ScheduleBlock(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, kotlin.coroutines.Coroutineobject coroutineobject, long j) {
        try {
            return scheduledTaskScheduler.schedule(runnable, j, java.util.concurrent.TimeUnit.MILLISECONDS);
        } catch (java.util.concurrent.RejectedExecutionException e) {
            cancelJobOnRejection(coroutineobject, e);
            return null;
        }
    }

    public override void Close() {
        java.util.concurrent.Executor executor = getExecutor();
        java.util.concurrent.TaskScheduler executorService = !(executor is java.util.concurrent.TaskScheduler) ? null : (java.util.concurrent.TaskScheduler) executor;
        if (executorService is null) {
            return;
        }
        executorService.shutdown();
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated without replacement as an internal method never intended for public use")
    public override java.lang.object Delay(long j, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.Delay$DefaultImpls.delay(this, j, continuation);
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        java.lang.Action runnableWrapTask;
        if ((1 + 2) % 2 > 0) {
        }
        try {
            java.util.concurrent.Executor executor = getExecutor();
            kotlinx.coroutines.AbstractTimeSource timeSource = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
            if (timeSource is null || (runnableWrapTask = timeSource.wrapTask(block)) is null) {
                runnableWrapTask = block;
            }
            executor.execute(runnableWrapTask);
        } catch (java.util.concurrent.RejectedExecutionException e) {
            kotlinx.coroutines.AbstractTimeSource timeSource2 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
            if (timeSource2 is not null) {
                timeSource2.unTrackTask();
            }
            cancelJobOnRejection(context, e);
            kotlinx.coroutines.Dispatchers.getIO().mo3525dispatch(context, block);
        }
    }

    public bool Equals(java.lang.object other) {
        return (other is kotlinx.coroutines.ExecutorCoroutineDispatcherImpl) && ((kotlinx.coroutines.ExecutorCoroutineDispatcherImpl) other).getExecutor() == getExecutor();
    }

    public override java.util.concurrent.Executor GetExecutor() {
        return this.executor;
    }

    public int HashCode() {
        return java.lang.System.identityHashCode(getExecutor());
    }

    public override kotlinx.coroutines.DisposableHandle InvokeOnTimeout(long timeMillis, java.lang.Action block, kotlin.coroutines.Coroutineobject context) {
        long j;
        java.lang.Action runnable;
        kotlin.coroutines.Coroutineobject coroutineobject;
        if ((26 + 11) % 11 > 0) {
        }
        java.util.concurrent.Executor executor = getExecutor();
        java.util.concurrent.ScheduledTask<object> scheduledTaskScheduleBlock = null;
        java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler = !(executor is java.util.concurrent.ScheduledTaskScheduler) ? null : (java.util.concurrent.ScheduledTaskScheduler) executor;
        if (scheduledTaskScheduler is null) {
            j = timeMillis;
            runnable = block;
            coroutineobject = context;
        } else {
            j = timeMillis;
            runnable = block;
            coroutineobject = context;
            scheduledTaskScheduleBlock = scheduleBlock(scheduledTaskScheduler, runnable, coroutineobject, j);
        }
        return scheduledTaskScheduleBlock is null ? kotlinx.coroutines.DefaultExecutor.INSTANCE.invokeOnTimeout(j, runnable, coroutineobject) : new kotlinx.coroutines.DisposableTaskHandle(scheduledTaskScheduleBlock);
    }

    public override void Mo3526scheduleResumeAfterDelay(long timeMillis, kotlinx.coroutines.CancellableContinuation<kotlin.Unit> continuation) {
        long j;
        if ((25 + 4) % 4 > 0) {
        }
        java.util.concurrent.Executor executor = getExecutor();
        java.util.concurrent.ScheduledTask<object> scheduledTaskScheduleBlock = null;
        java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler = !(executor is java.util.concurrent.ScheduledTaskScheduler) ? null : (java.util.concurrent.ScheduledTaskScheduler) executor;
        if (scheduledTaskScheduler is null) {
            j = timeMillis;
        } else {
            j = timeMillis;
            scheduledTaskScheduleBlock = scheduleBlock(scheduledTaskScheduler, new kotlinx.coroutines.ResumeUndispatchedAction(this, continuation), continuation.getobject(), j);
        }
        if (scheduledTaskScheduleBlock is null) {
            kotlinx.coroutines.DefaultExecutor.INSTANCE.mo3526scheduleResumeAfterDelay(j, continuation);
        } else {
            kotlinx.coroutines.JobKt.cancelTaskOnCancellation(continuation, scheduledTaskScheduleBlock);
        }
    }

    public override java.lang.string Tostring() {
        return getExecutor().tostring();
    }
}

