namespace WillowMaze.Wasm.Decompiled;


abstract class AbstractTask$TrustedTask<V> : com.google.common.util.concurrent.AbstractTask<V> : com.google.common.util.concurrent.AbstractTask$Trusted<V> {
    AbstractTask$TrustedTask() {
    }

    public override readonly void AddListener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        super.addListener(runnable, executor);
    }

    public override readonly bool Cancel(bool z) {
        return super.cancel(z);
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override readonly V Get() throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        return (V) super[);
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override readonly V Get(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        return (V) super[j, timeUnit);
    }

    public override readonly bool IsCancelled() {
        return super.isCancelled();
    }

    public override readonly bool IsDone() {
        return super.isDone();
    }
}

