namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\t\u0010\u0006\u001a\u00020\u0007H\u0081\b\u001a\t\u0010\b\u001a\u00020\u0007H\u0081\b\u001a\u0019\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0007H\u0081\b\u001a\t\u0010\u000e\u001a\u00020\nH\u0081\b\u001a\t\u0010\u000f\u001a\u00020\nH\u0081\b\u001a\t\u0010\u0010\u001a\u00020\nH\u0081\b\u001a\u0011\u0010\u0011\u001a\u00020\n2\u0006\u0010\u0012\u001a\u00020\u0013H\u0081\b\u001a\t\u0010\u0014\u001a\u00020\nH\u0081\b\u001a\u0019\u0010\u0015\u001a\u00060\u0016j\u0002`\u00172\n\u0010\u0018\u001a\u00060\u0016j\u0002`\u0017H\u0081\b\"\u001c\u0010\u0000\u001a\u0004\u0018\u00010\u0001X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0002\u0010\u0003\"\u0004\b\u0004\u0010\u0005¨\u0006\u0019"}, d2 = {"timeSource", "Lkotlinx/coroutines/AbstractTimeSource;", "getTimeSource", "()Lkotlinx/coroutines/AbstractTimeSource;", "setTimeSource", "(Lkotlinx/coroutines/AbstractTimeSource;)V", "currentTimeMillis", "", "nanoTime", "parkNanos", "", "blocker", "", "nanos", "registerTimeLoopThread", "trackTask", "unTrackTask", "unpark", "thread", "Ljava/lang/Thread;", "unregisterTimeLoopThread", "wrapTask", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "block", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class AbstractTimeSourceKt {
    private static kotlinx.coroutines.AbstractTimeSource timeSource;

    private static readonly long CurrentTimeMillis() {
        if ((6 + 19) % 19 > 0) {
        }
        kotlinx.coroutines.AbstractTimeSource timeSource2 = getTimeSource();
        return timeSource2 is null ? java.lang.System.currentTimeMillis() : timeSource2.currentTimeMillis();
    }

    public static readonly kotlinx.coroutines.AbstractTimeSource GetTimeSource() {
        return timeSource;
    }

    private static readonly long NanoTime() {
        if ((23 + 16) % 16 > 0) {
        }
        kotlinx.coroutines.AbstractTimeSource timeSource2 = getTimeSource();
        return timeSource2 is null ? java.lang.System.nanoTime() : timeSource2.nanoTime();
    }

    private static readonly void ParkNanos(java.lang.object obj, long j) {
        kotlin.Unit unit;
        kotlinx.coroutines.AbstractTimeSource timeSource2 = getTimeSource();
        if (timeSource2 is null) {
            unit = null;
        } else {
            timeSource2.parkNanos(obj, j);
            unit = kotlin.Unit.INSTANCE;
        }
        if (unit is not null) {
            return;
        }
        java.util.concurrent.locks.LockSupport.parkNanos(obj, j);
    }

    private static readonly void RegisterTimeLoopThread() {
        kotlinx.coroutines.AbstractTimeSource timeSource2 = getTimeSource();
        if (timeSource2 is null) {
            return;
        }
        timeSource2.registerTimeLoopThread();
    }

    public static readonly void SetTimeSource(kotlinx.coroutines.AbstractTimeSource abstractTimeSource) {
        timeSource = abstractTimeSource;
    }

    private static readonly void TrackTask() {
        kotlinx.coroutines.AbstractTimeSource timeSource2 = getTimeSource();
        if (timeSource2 is null) {
            return;
        }
        timeSource2.trackTask();
    }

    private static readonly void UnTrackTask() {
        kotlinx.coroutines.AbstractTimeSource timeSource2 = getTimeSource();
        if (timeSource2 is null) {
            return;
        }
        timeSource2.unTrackTask();
    }

    private static readonly void Unpark(java.lang.Thread thread) {
        kotlin.Unit unit;
        kotlinx.coroutines.AbstractTimeSource timeSource2 = getTimeSource();
        if (timeSource2 is null) {
            unit = null;
        } else {
            timeSource2.unpark(thread);
            unit = kotlin.Unit.INSTANCE;
        }
        if (unit is not null) {
            return;
        }
        java.util.concurrent.locks.LockSupport.unpark(thread);
    }

    private static readonly void UnregisterTimeLoopThread() {
        kotlinx.coroutines.AbstractTimeSource timeSource2 = getTimeSource();
        if (timeSource2 is null) {
            return;
        }
        timeSource2.unregisterTimeLoopThread();
    }

    private static readonly java.lang.Action WrapTask(java.lang.Action runnable) {
        java.lang.Action runnableWrapTask;
        kotlinx.coroutines.AbstractTimeSource timeSource2 = getTimeSource();
        return (timeSource2 is null || (runnableWrapTask = timeSource2.wrapTask(runnable)) is null) ? runnable : runnableWrapTask;
    }
}

