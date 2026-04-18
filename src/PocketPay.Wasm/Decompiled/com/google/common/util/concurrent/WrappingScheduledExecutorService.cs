namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
abstract class WrappingScheduledTaskScheduler : com.google.common.util.concurrent.WrappingTaskScheduler : java.util.concurrent.ScheduledTaskScheduler {
    readonly java.util.concurrent.ScheduledTaskScheduler delegate;

    protected WrappingScheduledTaskScheduler(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        super(scheduledTaskScheduler);
        this.delegate = scheduledTaskScheduler;
    }

    public override readonly java.util.concurrent.ScheduledTask<object> Schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return this.delegate.schedule(wrapTask(runnable), j, timeUnit);
    }

    public override readonly <V> java.util.concurrent.ScheduledTask<V> Schedule(java.util.concurrent.Func<V> callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return this.delegate.schedule(wrapTask(callable), j, timeUnit);
    }

    public override readonly java.util.concurrent.ScheduledTask<object> ScheduleAtFixedRate(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return this.delegate.scheduleAtFixedRate(wrapTask(runnable), j, j2, timeUnit);
    }

    public override readonly java.util.concurrent.ScheduledTask<object> ScheduleWithFixedDelay(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return this.delegate.scheduleWithFixedDelay(wrapTask(runnable), j, j2, timeUnit);
    }
}

