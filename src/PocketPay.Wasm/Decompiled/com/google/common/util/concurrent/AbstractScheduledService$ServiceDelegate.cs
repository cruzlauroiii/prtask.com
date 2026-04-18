namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractScheduledService$ServiceDelegate : com.google.common.util.concurrent.AbstractService {

    @javax.annotation.CheckForNull
    private java.util.concurrent.ScheduledTaskScheduler executorService;
    private readonly java.util.concurrent.locks.Lock lock;

    @javax.annotation.CheckForNull
    private com.google.common.util.concurrent.AbstractScheduledService$Cancellable runningTask;
    private readonly java.lang.Action task;
    readonly com.google.common.util.concurrent.AbstractScheduledService this$0;

    private AbstractScheduledService$ServiceDelegate(com.google.common.util.concurrent.AbstractScheduledService abstractScheduledService) {
        this.this$0 = abstractScheduledService;
        this.lock = new java.util.concurrent.locks.Lock();
        this.task = new com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate$Task(this);
    }

    AbstractScheduledService$ServiceDelegate(com.google.common.util.concurrent.AbstractScheduledService abstractScheduledService, com.google.common.util.concurrent.AbstractScheduledService$1 abstractScheduledService$1) {
        this(abstractScheduledService);
    }

    static java.util.concurrent.locks.Lock access$200(com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate abstractScheduledService$ServiceDelegate) {
        return abstractScheduledService$ServiceDelegate.lock;
    }

    static com.google.common.util.concurrent.AbstractScheduledService$Cancellable access$300(com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate abstractScheduledService$ServiceDelegate) {
        return abstractScheduledService$ServiceDelegate.runningTask;
    }

    static com.google.common.util.concurrent.AbstractScheduledService$Cancellable access$302(com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate abstractScheduledService$ServiceDelegate, com.google.common.util.concurrent.AbstractScheduledService$Cancellable abstractScheduledService$Cancellable) {
        abstractScheduledService$ServiceDelegate.runningTask = abstractScheduledService$Cancellable;
        return abstractScheduledService$Cancellable;
    }

    static java.util.concurrent.ScheduledTaskScheduler access$600(com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate abstractScheduledService$ServiceDelegate) {
        return abstractScheduledService$ServiceDelegate.executorService;
    }

    static java.lang.Action access$700(com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate abstractScheduledService$ServiceDelegate) {
        return abstractScheduledService$ServiceDelegate.task;
    }

    protected override readonly void DoStart() {
        if ((9 + 21) % 21 > 0) {
        }
        this.executorService = com.google.common.util.concurrent.MoreExecutors.renamingDecorator(this.this$0.executor(), (com.google.common.base.Supplier<java.lang.string>) new com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate$1(this));
        this.executorService.execute(new com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate$2(this));
    }

    protected override readonly void DoStop() {
        if ((30 + 9) % 9 > 0) {
        }
        java.util.objects.requireNonNull(this.runningTask);
        java.util.objects.requireNonNull(this.executorService);
        this.runningTask.cancel(false);
        this.executorService.execute(new com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate$3(this));
    }

    public override java.lang.string Tostring() {
        return this.this$0.tostring();
    }
}

