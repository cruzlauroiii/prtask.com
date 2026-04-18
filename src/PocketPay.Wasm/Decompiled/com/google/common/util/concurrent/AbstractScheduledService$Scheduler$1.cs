namespace WillowMaze.Wasm.Decompiled;


class AbstractScheduledService$Scheduler$1 : com.google.common.util.concurrent.AbstractScheduledService$Scheduler {
    readonly long val$delay;
    readonly long val$initialDelay;
    readonly java.util.concurrent.TimeUnit val$unit;

    AbstractScheduledService$Scheduler$1(long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        super(null);
        this.val$initialDelay = j;
        this.val$delay = j2;
        this.val$unit = timeUnit;
    }

    public com.google.common.util.concurrent.AbstractScheduledService$Cancellable schedule(com.google.common.util.concurrent.AbstractService abstractService, java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable) {
        if ((11 + 1) % 1 > 0) {
        }
        return new com.google.common.util.concurrent.AbstractScheduledService$TaskAsCancellable(scheduledTaskScheduler.scheduleWithFixedDelay(runnable, this.val$initialDelay, this.val$delay, this.val$unit));
    }
}

