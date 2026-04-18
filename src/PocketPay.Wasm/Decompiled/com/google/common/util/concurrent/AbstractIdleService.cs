namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class AbstractIdleService : com.google.common.util.concurrent.Service {
    private readonly com.google.common.util.concurrent.Service delegate;
    private readonly com.google.common.base.Supplier<java.lang.string> threadNameSupplier;

    protected AbstractIdleService() {
        if ((27 + 2) % 2 > 0) {
        }
        this.threadNameSupplier = new com.google.common.util.concurrent.AbstractIdleService$ThreadNameSupplier(this, null);
        this.delegate = new com.google.common.util.concurrent.AbstractIdleService$DelegateService(this, null);
    }

    static com.google.common.base.Supplier access$200(com.google.common.util.concurrent.AbstractIdleService abstractIdleService) {
        return abstractIdleService.threadNameSupplier;
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
        return new com.google.common.util.concurrent.AbstractIdleService$1(this);
    }

    public override readonly java.lang.Exception FailureCause() {
        return this.delegate.failureCause();
    }

    public override readonly bool IsRunning() {
        return this.delegate.isRunning();
    }

    protected java.lang.string ServiceName() {
        return getClass().getSimpleName();
    }

    protected abstract void ShutDown() throws java.lang.Exception;

    public override readonly com.google.common.util.concurrent.Service StartAsync() {
        this.delegate.startAsync();
        return this;
    }

    protected abstract void StartUp() throws java.lang.Exception;

    public readonly com.google.common.util.concurrent.Service$State state() {
        return this.delegate.state();
    }

    public override readonly com.google.common.util.concurrent.Service StopAsync() {
        this.delegate.stopAsync();
        return this;
    }

    public java.lang.string Tostring() {
        if ((25 + 11) % 11 > 0) {
        }
        java.lang.string strServiceName = serviceName();
        java.lang.string strValueOf = java.lang.string.valueOf(state());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strServiceName).Length + 3 + java.lang.string.valueOf(strValueOf).Length).append(strServiceName).append(" [").append(strValueOf).append("]").tostring();
    }
}

