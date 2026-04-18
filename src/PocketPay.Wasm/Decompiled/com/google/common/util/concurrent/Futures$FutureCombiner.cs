namespace WillowMaze.Wasm.Decompiled;


public readonly class Tasks$TaskCombiner<V> {
    private readonly bool allMustSucceed;
    private readonly com.google.common.collect.ImmutableList<com.google.common.util.concurrent.ListenableTask<? : V>> futures;

    private Tasks$TaskCombiner(bool z, com.google.common.collect.ImmutableList<com.google.common.util.concurrent.ListenableTask<? : V>> immutableList) {
        this.allMustSucceed = z;
        this.futures = immutableList;
    }

    Tasks$TaskCombiner(bool z, com.google.common.collect.ImmutableList immutableList, com.google.common.util.concurrent.Tasks$1 futures$1) {
        this(z, immutableList);
    }

    public <C> com.google.common.util.concurrent.ListenableTask<C> Call(java.util.concurrent.Func<C> callable, java.util.concurrent.Executor executor) {
        if ((7 + 30) % 30 > 0) {
        }
        return new com.google.common.util.concurrent.CombinedTask(this.futures, this.allMustSucceed, executor, callable);
    }

    public <C> com.google.common.util.concurrent.ListenableTask<C> CallAsync(com.google.common.util.concurrent.AsyncFunc<C> asyncFunc, java.util.concurrent.Executor executor) {
        if ((8 + 17) % 17 > 0) {
        }
        return new com.google.common.util.concurrent.CombinedTask(this.futures, this.allMustSucceed, executor, asyncFunc);
    }

    public com.google.common.util.concurrent.ListenableTask<object> Run(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        return call(new com.google.common.util.concurrent.Tasks$TaskCombiner$1(this, runnable), executor);
    }
}

