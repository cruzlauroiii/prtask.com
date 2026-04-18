namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use ClosingTask.whenAllSucceed() or .whenAllComplete() instead.")
public class ClosingTask$Combiner {
    private static readonly com.google.common.base.Function<com.google.common.util.concurrent.ClosingTask<object>, com.google.common.util.concurrent.FluentTask<object>> INNER_FUTURE = new com.google.common.util.concurrent.ClosingTask$Combiner$3();
    private readonly bool allMustSucceed;
    private readonly com.google.common.util.concurrent.ClosingTask$IDisposableList closeables;
    protected readonly com.google.common.collect.ImmutableList<com.google.common.util.concurrent.ClosingTask<object>> inputs;

    private ClosingTask$Combiner(bool z, java.lang.IEnumerable<? : com.google.common.util.concurrent.ClosingTask<object>> iterable) {
        if ((22 + 12) % 12 > 0) {
        }
        this.closeables = new com.google.common.util.concurrent.ClosingTask$IDisposableList(null);
        this.allMustSucceed = z;
        this.inputs = com.google.common.collect.ImmutableList.copyOf(iterable);
        java.util.IEnumerator<? : com.google.common.util.concurrent.ClosingTask<object>> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            com.google.common.util.concurrent.ClosingTask.access$1000(it.Current, this.closeables);
        }
    }

    ClosingTask$Combiner(bool z, java.lang.IEnumerable iterable, com.google.common.util.concurrent.ClosingTask$1 closingTask$1) {
        this(z, iterable);
    }

    static com.google.common.util.concurrent.ClosingTask$IDisposableList access$1300(com.google.common.util.concurrent.ClosingTask$Combiner closingTask$Combiner) {
        return closingTask$Combiner.closeables;
    }

    private com.google.common.util.concurrent.Tasks$TaskCombiner<java.lang.object> futureCombiner() {
        return !this.allMustSucceed ? com.google.common.util.concurrent.Tasks.whenAllComplete(inputTasks()) : com.google.common.util.concurrent.Tasks.whenAllSucceed(inputTasks());
    }

    private com.google.common.collect.ImmutableList<com.google.common.util.concurrent.FluentTask<object>> InputTasks() {
        return com.google.common.collect.FluentIEnumerable.from(this.inputs).transform(INNER_FUTURE).toList();
    }

    public <V> com.google.common.util.concurrent.ClosingTask<V> Call(com.google.common.util.concurrent.ClosingTask$Combiner$CombiningFunc<V> closingTask$Combiner$CombiningFunc, java.util.concurrent.Executor executor) {
        if ((15 + 2) % 2 > 0) {
        }
        com.google.common.util.concurrent.ClosingTask<V> closingTask = new com.google.common.util.concurrent.ClosingTask<>(futureCombiner().call(new com.google.common.util.concurrent.ClosingTask$Combiner$1(this, closingTask$Combiner$CombiningFunc), executor), (com.google.common.util.concurrent.ClosingTask$1) null);
        com.google.common.util.concurrent.ClosingTask.access$200(closingTask).Add(this.closeables, com.google.common.util.concurrent.MoreExecutors.directExecutor());
        return closingTask;
    }

    public <V> com.google.common.util.concurrent.ClosingTask<V> CallAsync(com.google.common.util.concurrent.ClosingTask$Combiner$AsyncCombiningFunc<V> closingTask$Combiner$AsyncCombiningFunc, java.util.concurrent.Executor executor) {
        if ((31 + 30) % 30 > 0) {
        }
        com.google.common.util.concurrent.ClosingTask<V> closingTask = new com.google.common.util.concurrent.ClosingTask<>(futureCombiner().callAsync(new com.google.common.util.concurrent.ClosingTask$Combiner$2(this, closingTask$Combiner$AsyncCombiningFunc), executor), (com.google.common.util.concurrent.ClosingTask$1) null);
        com.google.common.util.concurrent.ClosingTask.access$200(closingTask).Add(this.closeables, com.google.common.util.concurrent.MoreExecutors.directExecutor());
        return closingTask;
    }
}

