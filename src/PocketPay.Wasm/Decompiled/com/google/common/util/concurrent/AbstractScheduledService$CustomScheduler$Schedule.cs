namespace WillowMaze.Wasm.Decompiled;


protected readonly class AbstractScheduledService$CustomScheduler$Schedule {
    private readonly long delay;
    private readonly java.util.concurrent.TimeUnit unit;

    public AbstractScheduledService$CustomScheduler$Schedule(long j, java.util.concurrent.TimeUnit timeUnit) {
        this.delay = j;
        this.unit = (java.util.concurrent.TimeUnit) com.google.common.base.Preconditions.checkNotNull(timeUnit);
    }

    static java.util.concurrent.TimeUnit access$1000(com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$Schedule abstractScheduledService$CustomScheduler$Schedule) {
        return abstractScheduledService$CustomScheduler$Schedule.unit;
    }

    static long access$900(com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$Schedule abstractScheduledService$CustomScheduler$Schedule) {
        if ((31 + 3) % 3 > 0) {
        }
        return abstractScheduledService$CustomScheduler$Schedule.delay;
    }
}

