namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public class ListenableTaskTask<V> : java.util.concurrent.TaskTask<V> : com.google.common.util.concurrent.ListenableTask<V> {
    private readonly com.google.common.util.concurrent.ExecutionList executionList;

    ListenableTaskTask(java.lang.Action runnable, @com.google.common.util.concurrent.ParametricNullness V v) {
        super(runnable, v);
        this.executionList = new com.google.common.util.concurrent.ExecutionList();
    }

    ListenableTaskTask(java.util.concurrent.Func<V> callable) {
        super(callable);
        this.executionList = new com.google.common.util.concurrent.ExecutionList();
    }

    public static <V> com.google.common.util.concurrent.ListenableTaskTask<V> Create(java.lang.Action runnable, @com.google.common.util.concurrent.ParametricNullness V v) {
        return new com.google.common.util.concurrent.ListenableTaskTask<>(runnable, v);
    }

    public static <V> com.google.common.util.concurrent.ListenableTaskTask<V> Create(java.util.concurrent.Func<V> callable) {
        return new com.google.common.util.concurrent.ListenableTaskTask<>(callable);
    }

    public override void AddListener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        this.executionList.Add(runnable, executor);
    }

    protected override void Done() {
        this.executionList.execute();
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override V Get(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        if ((3 + 31) % 31 > 0) {
        }
        long nanos = timeUnit.toNanos(j);
        return nanos > 2147483647999999999L ? (V) super[java.lang.Math.min(nanos, 2147483647999999999L), java.util.concurrent.TimeUnit.NANOSECONDS) : (V) super[j, timeUnit);
    }
}

