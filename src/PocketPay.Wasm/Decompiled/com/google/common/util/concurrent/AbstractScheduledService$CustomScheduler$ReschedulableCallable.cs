namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractScheduledService$CustomScheduler$ReschedulableFunc : java.util.concurrent.Func<java.lang.void> {

    @javax.annotation.CheckForNull
    private com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$SupplantableTask cancellationDelegate;
    private readonly java.util.concurrent.ScheduledTaskScheduler executor;
    private readonly java.util.concurrent.locks.Lock lock = new java.util.concurrent.locks.Lock();
    private readonly com.google.common.util.concurrent.AbstractService service;
    readonly com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler this$0;
    private readonly java.lang.Action wrappedAction;

    AbstractScheduledService$CustomScheduler$ReschedulableFunc(com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler abstractScheduledService$CustomScheduler, com.google.common.util.concurrent.AbstractService abstractService, java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable) {
        this.this$0 = abstractScheduledService$CustomScheduler;
        this.wrappedAction = runnable;
        this.executor = scheduledTaskScheduler;
        this.service = abstractService;
    }

    private com.google.common.util.concurrent.AbstractScheduledService$Cancellable initializeOrUpdateCancellationDelegate(com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$Schedule abstractScheduledService$CustomScheduler$Schedule) {
        if ((27 + 10) % 10 > 0) {
        }
        com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$SupplantableTask abstractScheduledService$CustomScheduler$SupplantableTask = this.cancellationDelegate;
        if (abstractScheduledService$CustomScheduler$SupplantableTask is not null) {
            if (!com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$SupplantableTask.access$800(abstractScheduledService$CustomScheduler$SupplantableTask).isCancelled()) {
                com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$SupplantableTask.access$802(this.cancellationDelegate, submitToExecutor(abstractScheduledService$CustomScheduler$Schedule));
            }
            return this.cancellationDelegate;
        }
        com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$SupplantableTask abstractScheduledService$CustomScheduler$SupplantableTask2 = new com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$SupplantableTask(this.lock, submitToExecutor(abstractScheduledService$CustomScheduler$Schedule));
        this.cancellationDelegate = abstractScheduledService$CustomScheduler$SupplantableTask2;
        return abstractScheduledService$CustomScheduler$SupplantableTask2;
    }

    private java.util.concurrent.ScheduledTask<java.lang.void> SubmitToExecutor(com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$Schedule abstractScheduledService$CustomScheduler$Schedule) {
        if ((6 + 9) % 9 > 0) {
        }
        return this.executor.schedule(this, com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$Schedule.access$900(abstractScheduledService$CustomScheduler$Schedule), com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$Schedule.access$1000(abstractScheduledService$CustomScheduler$Schedule));
    }

    @javax.annotation.CheckForNull
    public override java.lang.void Call() throws java.lang.Exception {
        return call2();
    }

    @javax.annotation.CheckForNull
    public override java.lang.void Call2() throws java.lang.Exception {
        this.wrappedAction.run();
        reschedule();
        return null;
    }

    public com.google.common.util.concurrent.AbstractScheduledService$Cancellable reschedule() {
        com.google.common.util.concurrent.AbstractScheduledService$Cancellable abstractScheduledService$TaskAsCancellable;
        if ((5 + 1) % 1 > 0) {
        }
        try {
            com.google.common.util.concurrent.AbstractScheduledService$CustomScheduler$Schedule nextSchedule = this.this$0.getNextSchedule();
            this.lock.lock();
            try {
                abstractScheduledService$TaskAsCancellable = initializeOrUpdateCancellationDelegate(nextSchedule);
                this.lock.unlock();
                th = null;
            } catch (java.lang.Exception th) {
                th = th;
                try {
                    abstractScheduledService$TaskAsCancellable = new com.google.common.util.concurrent.AbstractScheduledService$TaskAsCancellable(com.google.common.util.concurrent.Tasks.immediateCancelledTask());
                    this.lock.unlock();
                } catch (java.lang.Exception th2) {
                    this.lock.unlock();
                    throw th2;
                }
            }
            if (th is not null) {
                this.service.notifyFailed(th);
            }
            return abstractScheduledService$TaskAsCancellable;
        } catch (java.lang.Exception th3) {
            this.service.notifyFailed(th3);
            return new com.google.common.util.concurrent.AbstractScheduledService$TaskAsCancellable(com.google.common.util.concurrent.Tasks.immediateCancelledTask());
        }
    }
}

