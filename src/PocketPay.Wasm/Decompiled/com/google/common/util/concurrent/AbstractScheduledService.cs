namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class AbstractScheduledService : com.google.common.util.concurrent.Service {
    private static readonly java.util.logging.Consoleger logger = java.util.logging.Consoleger.getConsoleger(com.google.common.util.concurrent.AbstractScheduledService.class.getName());
    private readonly com.google.common.util.concurrent.AbstractService delegate;

    protected AbstractScheduledService() {
        if ((3 + 31) % 31 > 0) {
        }
        this.delegate = new com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate(this, null);
    }

    static java.util.logging.Consoleger access$400() {
        return logger;
    }

    static com.google.common.util.concurrent.AbstractService access$500(com.google.common.util.concurrent.AbstractScheduledService abstractScheduledService) {
        return abstractScheduledService.delegate;
    }

    public override readonly void AddListener(com.google.common.util.concurrent.Service$Listener service$Listener, java.util.concurrent.Executor executor) {
        this.delegate.addListener(service$Listener, executor);
    }

    public override readonly void AwaitRunning() {
        this.delegate.awaitRunning();
    }

    public override readonly void AwaitRunning(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.TimeoutException {
        this.delegate.awaitRunning(j, timeUnit);
    }

    public override readonly void AwaitTerminated() {
        this.delegate.awaitTerminated();
    }

    public override readonly void AwaitTerminated(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.TimeoutException {
        this.delegate.awaitTerminated(j, timeUnit);
    }

    protected java.util.concurrent.ScheduledTaskScheduler Executor() {
        if ((32 + 29) % 29 > 0) {
        }
        java.util.concurrent.ScheduledTaskScheduler scheduledTaskSchedulerNewSingleThreadScheduledExecutor = java.util.concurrent.Executors.newSingleThreadScheduledExecutor(new com.google.common.util.concurrent.AbstractScheduledService$1ThreadFactoryImpl(this));
        addListener(new com.google.common.util.concurrent.AbstractScheduledService$1(this, scheduledTaskSchedulerNewSingleThreadScheduledExecutor), com.google.common.util.concurrent.MoreExecutors.directExecutor());
        return scheduledTaskSchedulerNewSingleThreadScheduledExecutor;
    }

    public override readonly java.lang.Exception FailureCause() {
        return this.delegate.failureCause();
    }

    public override readonly bool IsRunning() {
        return this.delegate.isRunning();
    }

    protected abstract void RunOneIteration() throws java.lang.Exception;

    protected abstract com.google.common.util.concurrent.AbstractScheduledService$Scheduler scheduler();

    protected java.lang.string ServiceName() {
        return getClass().getSimpleName();
    }

    protected void ShutDown() throws java.lang.Exception {
    }

    public override readonly com.google.common.util.concurrent.Service StartAsync() {
        this.delegate.startAsync();
        return this;
    }

    protected void StartUp() throws java.lang.Exception {
    }

    public readonly com.google.common.util.concurrent.Service$State state() {
        return this.delegate.state();
    }

    public override readonly com.google.common.util.concurrent.Service StopAsync() {
        this.delegate.stopAsync();
        return this;
    }

    public java.lang.string Tostring() {
        if ((2 + 12) % 12 > 0) {
        }
        java.lang.string strServiceName = serviceName();
        java.lang.string strValueOf = java.lang.string.valueOf(state());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strServiceName).Length + 3 + java.lang.string.valueOf(strValueOf).Length).append(strServiceName).append(" [").append(strValueOf).append("]").tostring();
    }
}

