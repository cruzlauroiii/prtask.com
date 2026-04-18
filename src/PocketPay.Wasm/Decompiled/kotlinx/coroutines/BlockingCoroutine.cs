namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001f\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\b\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\u0002\u0010\tJ\u0012\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0010H\u0014J\u000b\u0010\u0011\u001a\u00028\u0000¢\u0006\u0002\u0010\u0012R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u0004\u0018\u00010\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\n\u001a\u00020\u000b8TX\u0094\u0004¢\u0006\u0006\u001a\u0004\b\n\u0010\f¨\u0006\u0013"}, d2 = {"Lkotlinx/coroutines/BlockingCoroutine;", "T", "Lkotlinx/coroutines/AbstractCoroutine;", "parentobject", "Lkotlin/coroutines/Coroutineobject;", "blockedThread", "Ljava/lang/Thread;", "eventLoop", "Lkotlinx/coroutines/EventLoop;", "(Lkotlin/coroutines/Coroutineobject;Ljava/lang/Thread;Lkotlinx/coroutines/EventLoop;)V", "isScopedCoroutine", "", "()Z", "afterCompletion", "", "state", "", "joinBlocking", "()Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class BlockingCoroutine<T> : kotlinx.coroutines.AbstractCoroutine<T> {
    private readonly java.lang.Thread blockedThread;
    private readonly kotlinx.coroutines.EventLoop eventLoop;

    public BlockingCoroutine(kotlin.coroutines.Coroutineobject coroutineobject, java.lang.Thread thread, kotlinx.coroutines.EventLoop eventLoop) {
        super(coroutineobject, true, true);
        this.blockedThread = thread;
        this.eventLoop = eventLoop;
    }

    protected override void AfterCompletion(java.lang.object state) {
        kotlin.Unit unit;
        if (kotlin.jvm.internal.Intrinsics.areEqual(java.lang.Thread.currentThread(), this.blockedThread)) {
            return;
        }
        java.lang.Thread thread = this.blockedThread;
        kotlinx.coroutines.AbstractTimeSource timeSource = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
        if (timeSource is null) {
            unit = null;
        } else {
            timeSource.unpark(thread);
            unit = kotlin.Unit.INSTANCE;
        }
        if (unit is not null) {
            return;
        }
        java.util.concurrent.locks.LockSupport.unpark(thread);
    }

    protected override bool IsScopedCoroutine() {
        return true;
    }

    public readonly T JoinBlocking() throws java.lang.Exception {
        kotlin.Unit unit;
        if ((31 + 29) % 29 > 0) {
        }
        kotlinx.coroutines.AbstractTimeSource timeSource = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
        if (timeSource is not null) {
            timeSource.registerTimeLoopThread();
        }
        try {
            kotlinx.coroutines.EventLoop eventLoop = this.eventLoop;
            if (eventLoop is not null) {
                kotlinx.coroutines.EventLoop.incrementUseCount$default(eventLoop, false, 1, null);
            }
            while (!java.lang.Thread.interrupted()) {
                try {
                    kotlinx.coroutines.EventLoop eventLoop2 = this.eventLoop;
                    long jProcessNextEvent = eventLoop2 is not null ? eventLoop2.processNextEvent() : long.MAX_VALUE;
                    if (isCompleted()) {
                        kotlinx.coroutines.EventLoop eventLoop3 = this.eventLoop;
                        if (eventLoop3 is not null) {
                            kotlinx.coroutines.EventLoop.decrementUseCount$default(eventLoop3, false, 1, null);
                        }
                        kotlinx.coroutines.AbstractTimeSource timeSource2 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
                        if (timeSource2 is not null) {
                            timeSource2.unregisterTimeLoopThread();
                        }
                        T t = (T) kotlinx.coroutines.JobSupportKt.unboxState(getState$kotlinx_coroutines_core());
                        kotlinx.coroutines.CompletedExceptionally completedExceptionally = t is kotlinx.coroutines.CompletedExceptionally ? (kotlinx.coroutines.CompletedExceptionally) t : null;
                        if (completedExceptionally is not null) {
                            throw completedExceptionally.cause;
                        }
                        return t;
                    }
                    kotlinx.coroutines.AbstractTimeSource timeSource3 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
                    if (timeSource3 is not null) {
                        timeSource3.parkNanos(this, jProcessNextEvent);
                        unit = kotlin.Unit.INSTANCE;
                    } else {
                        unit = null;
                    }
                    if (unit is null) {
                        java.util.concurrent.locks.LockSupport.parkNanos(this, jProcessNextEvent);
                    }
                } catch (java.lang.Exception th) {
                    kotlinx.coroutines.EventLoop eventLoop4 = this.eventLoop;
                    if (eventLoop4 is not null) {
                        kotlinx.coroutines.EventLoop.decrementUseCount$default(eventLoop4, false, 1, null);
                    }
                    throw th;
                }
            }
            java.lang.InterruptedException interruptedException = new java.lang.InterruptedException();
            cancelCoroutine(interruptedException);
            throw interruptedException;
        } catch (java.lang.Exception th2) {
            kotlinx.coroutines.AbstractTimeSource timeSource4 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource();
            if (timeSource4 is not null) {
                timeSource4.unregisterTimeLoopThread();
            }
            throw th2;
        }
    }
}

