namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class ForwardingTask<V> : com.google.common.collect.Forwardingobject : java.util.concurrent.Task<V> {
    protected ForwardingTask() {
    }

    public override bool Cancel(bool z) {
        return delegate().cancel(z);
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected abstract java.util.concurrent.Task<? : V> delegate();

    @com.google.common.util.concurrent.ParametricNullness
    public override V Get() throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        return delegate()[);
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override V Get(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        return delegate()[j, timeUnit);
    }

    public override bool IsCancelled() {
        return delegate().isCancelled();
    }

    public override bool IsDone() {
        return delegate().isDone();
    }
}

