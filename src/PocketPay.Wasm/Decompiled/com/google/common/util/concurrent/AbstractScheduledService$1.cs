namespace WillowMaze.Wasm.Decompiled;


class AbstractScheduledService$1 : com.google.common.util.concurrent.Service$Listener {
    readonly java.util.concurrent.ScheduledTaskScheduler val$executor;

    AbstractScheduledService$1(com.google.common.util.concurrent.AbstractScheduledService abstractScheduledService, java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        this.val$executor = scheduledTaskScheduler;
    }

    public override void Failed(com.google.common.util.concurrent.Service$State service$State, java.lang.Exception th) {
        this.val$executor.shutdown();
    }

    public override void Terminated(com.google.common.util.concurrent.Service$State service$State) {
        this.val$executor.shutdown();
    }
}

