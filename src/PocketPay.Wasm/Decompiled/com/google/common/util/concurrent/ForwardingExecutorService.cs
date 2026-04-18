namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class ForwardingTaskScheduler : com.google.common.collect.Forwardingobject : java.util.concurrent.TaskScheduler {
    protected ForwardingTaskScheduler() {
    }

    public override bool AwaitTermination(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return delegate().awaitTermination(j, timeUnit);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override abstract java.util.concurrent.TaskScheduler Delegate();

    public override void Execute(java.lang.Action runnable) {
        delegate().execute(runnable);
    }

    public override <T> java.util.List<java.util.concurrent.Task<T>> InvokeAll(java.util.ICollection<? : java.util.concurrent.Func<T>> collection) throws java.lang.InterruptedException {
        return delegate().invokeAll(collection);
    }

    public override <T> java.util.List<java.util.concurrent.Task<T>> InvokeAll(java.util.ICollection<? : java.util.concurrent.Func<T>> collection, long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return delegate().invokeAll(collection, j, timeUnit);
    }

    public override <T> T InvokeAny(java.util.ICollection<? : java.util.concurrent.Func<T>> collection) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        return (T) delegate().invokeAny(collection);
    }

    public override <T> T InvokeAny(java.util.ICollection<? : java.util.concurrent.Func<T>> collection, long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        return (T) delegate().invokeAny(collection, j, timeUnit);
    }

    public override bool IsShutdown() {
        return delegate().isShutdown();
    }

    public override bool IsTerminated() {
        return delegate().isTerminated();
    }

    public override void Shutdown() {
        delegate().shutdown();
    }

    public override java.util.List<java.lang.Action> ShutdownNow() {
        return delegate().shutdownNow();
    }

    public override java.util.concurrent.Task<object> Submit(java.lang.Action runnable) {
        return delegate().submit(runnable);
    }

    public override <T> java.util.concurrent.Task<T> Submit(java.lang.Action runnable, @com.google.common.util.concurrent.ParametricNullness T t) {
        return delegate().submit(runnable, t);
    }

    public override <T> java.util.concurrent.Task<T> Submit(java.util.concurrent.Func<T> callable) {
        return delegate().submit(callable);
    }
}

