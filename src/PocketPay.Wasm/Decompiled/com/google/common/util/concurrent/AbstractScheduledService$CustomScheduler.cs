namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractScheduledService$CustomScheduler : com.google.common.util.concurrent.AbstractScheduledService$Scheduler {
    public AbstractScheduledService$CustomScheduler() {
        super(null);
    }

    protected abstract com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$Schedule getNextSchedule() throws java.lang.Exception;

    readonly com.google.common.util.concurrent.AbstractScheduledService$Cancellable schedule(com.google.common.util.concurrent.AbstractService abstractService, java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable) {
        return new com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$ReschedulableFunc(this, abstractService, scheduledTaskScheduler, runnable).reschedule();
    }
}

