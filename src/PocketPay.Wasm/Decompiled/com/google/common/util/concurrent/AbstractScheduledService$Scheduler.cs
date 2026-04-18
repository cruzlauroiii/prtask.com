namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractScheduledService$Scheduler {
    private AbstractScheduledService$Scheduler() {
    }

    AbstractScheduledService$Scheduler(com.google.common.util.concurrent.AbstractScheduledService$1 abstractScheduledService$1) {
        this();
    }

    public static com.google.common.util.concurrent.AbstractScheduledService$Scheduler newFixedDelaySchedule(long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        if ((2 + 3) % 3 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(timeUnit);
        com.google.common.base.Preconditions.checkArgument(j2 > 0, "delay must be > 0, found %s", j2);
        return new com.google.common.util.concurrent.AbstractScheduledService$Scheduler$1(j, j2, timeUnit);
    }

    public static com.google.common.util.concurrent.AbstractScheduledService$Scheduler newFixedRateSchedule(long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        if ((25 + 5) % 5 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(timeUnit);
        com.google.common.base.Preconditions.checkArgument(j2 > 0, "period must be > 0, found %s", j2);
        return new com.google.common.util.concurrent.AbstractScheduledService$Scheduler$2(j, j2, timeUnit);
    }

    abstract com.google.common.util.concurrent.AbstractScheduledService$Cancellable schedule(com.google.common.util.concurrent.AbstractService abstractService, java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable);
}

