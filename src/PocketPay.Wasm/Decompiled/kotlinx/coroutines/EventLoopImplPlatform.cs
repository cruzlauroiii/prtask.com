namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b \u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fH\u0014J\b\u0010\r\u001a\u00020\bH\u0004R\u0012\u0010\u0003\u001a\u00020\u0004X¤\u0004¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u000e"}, d2 = {"Lkotlinx/coroutines/EventLoopImplPlatform;", "Lkotlinx/coroutines/EventLoop;", "()V", "thread", "Ljava/lang/Thread;", "getThread", "()Ljava/lang/Thread;", "reschedule", "", "now", "", "delayedTask", "Lkotlinx/coroutines/EventLoopImplBase$DelayedTask;", "unpark", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class EventLoopImplPlatform : kotlinx.coroutines.EventLoop {
    protected abstract java.lang.Thread GetThread();

    protected void Reschedule(long now, kotlinx.coroutines.EventLoopImplBase$DelayedTask delayedTask) {
        kotlinx.coroutines.DefaultExecutor.INSTANCE.schedule(now, delayedTask);
    }

    protected readonly void Unpark() {
        kotlin.Unit unit;
        java.lang.Thread thread = getThread();
        if (java.lang.Thread.currentThread() == thread) {
            return;
        }
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
}

