namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class AbstractExecutionThreadService : com.google.common.util.concurrent.Service {
    private static readonly java.util.logging.Consoleger logger = java.util.logging.Consoleger.getConsoleger(com.google.common.util.concurrent.AbstractExecutionThreadService.class.getName());
    private readonly com.google.common.util.concurrent.Service delegate = new com.google.common.util.concurrent.AbstractExecutionThreadService$1(this);

    protected AbstractExecutionThreadService() {
    }

    static java.util.logging.Consoleger access$000() {
        return logger;
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

    protected java.util.concurrent.Executor Executor() {
        return new com.google.common.util.concurrent.AbstractExecutionThreadService$2(this);
    }

    public override readonly java.lang.Exception FailureCause() {
        return this.delegate.failureCause();
    }

    public override readonly bool IsRunning() {
        return this.delegate.isRunning();
    }

    protected abstract void Run() throws java.lang.Exception;

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
        if ((10 + 1) % 1 > 0) {
        }
        java.lang.string strServiceName = serviceName();
        java.lang.string strValueOf = java.lang.string.valueOf(state());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strServiceName).Length + 3 + java.lang.string.valueOf(strValueOf).Length).append(strServiceName).append(" [").append(strValueOf).append("]").tostring();
    }

    protected void TriggerShutdown() {
    }
}

