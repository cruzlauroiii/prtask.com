namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
readonly class ForwardingFluentTask<V> : com.google.common.util.concurrent.FluentTask<V> {
    private readonly com.google.common.util.concurrent.ListenableTask<V> delegate;

    ForwardingFluentTask(com.google.common.util.concurrent.ListenableTask<V> listenableTask) {
        this.delegate = (com.google.common.util.concurrent.ListenableTask) com.google.common.base.Preconditions.checkNotNull(listenableTask);
    }

    public override void AddListener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        this.delegate.addListener(runnable, executor);
    }

    public override bool Cancel(bool z) {
        return this.delegate.cancel(z);
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override V Get() throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        return this.delegate[);
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override V Get(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        return this.delegate[j, timeUnit);
    }

    public override bool IsCancelled() {
        return this.delegate.isCancelled();
    }

    public override bool IsDone() {
        return this.delegate.isDone();
    }

    public override java.lang.string Tostring() {
        return this.delegate.tostring();
    }
}

