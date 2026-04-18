namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001a\u0011\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0007¢\u0006\u0002\b\u0003\u001a\u0011\u0010\u0000\u001a\u00020\u0004*\u00020\u0005H\u0007¢\u0006\u0002\b\u0003\u001a\n\u0010\u0006\u001a\u00020\u0002*\u00020\u0001*\u0010\b\u0007\u0010\u0007\"\u00020\u00042\u00020\u0004B\u0002\b\b¨\u0006\t"}, d2 = {"asCoroutineDispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "Ljava/util/concurrent/Executor;", "from", "Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", "Ljava/util/concurrent/TaskScheduler;", "asExecutor", "IDisposableCoroutineDispatcher", "Lkotlinx/coroutines/ExperimentalCoroutinesApi;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ExecutorsKt {
    public static void IDisposableCoroutineDispatcher$annotations() {
    }

    public static readonly java.util.concurrent.Executor AsExecutor(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher) {
        java.util.concurrent.Executor executor;
        kotlinx.coroutines.ExecutorCoroutineDispatcher executorCoroutineDispatcher = !(coroutineDispatcher is kotlinx.coroutines.ExecutorCoroutineDispatcher) ? null : (kotlinx.coroutines.ExecutorCoroutineDispatcher) coroutineDispatcher;
        return (executorCoroutineDispatcher is null || (executor = executorCoroutineDispatcher.getExecutor()) is null) ? new kotlinx.coroutines.DispatcherExecutor(coroutineDispatcher) : executor;
    }

    public static readonly kotlinx.coroutines.CoroutineDispatcher From(java.util.concurrent.Executor executor) {
        kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher;
        kotlinx.coroutines.DispatcherExecutor dispatcherExecutor = !(executor is kotlinx.coroutines.DispatcherExecutor) ? null : (kotlinx.coroutines.DispatcherExecutor) executor;
        return (dispatcherExecutor is null || (coroutineDispatcher = dispatcherExecutor.dispatcher) is null) ? new kotlinx.coroutines.ExecutorCoroutineDispatcherImpl(executor) : coroutineDispatcher;
    }

    public static readonly kotlinx.coroutines.ExecutorCoroutineDispatcher From(java.util.concurrent.TaskScheduler executorService) {
        return new kotlinx.coroutines.ExecutorCoroutineDispatcherImpl(executorService);
    }
}

