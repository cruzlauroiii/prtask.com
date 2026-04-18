namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u00020\u0004H\u0016J\u0010\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0017J\r\u0010\t\u001a\u00020\u0004H\u0000¢\u0006\u0002\b\nJ\b\u0010\u000b\u001a\u00020\fH\u0016¨\u0006\r"}, d2 = {"Lkotlinx/coroutines/scheduling/DefaultScheduler;", "Lkotlinx/coroutines/scheduling/SchedulerCoroutineDispatcher;", "()V", "close", "", "limitedParallelism", "Lkotlinx/coroutines/CoroutineDispatcher;", "parallelism", "", "shutdown", "shutdown$kotlinx_coroutines_core", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DefaultScheduler : kotlinx.coroutines.scheduling.SchedulerCoroutineDispatcher {
    public static readonly kotlinx.coroutines.scheduling.DefaultScheduler INSTANCE = new kotlinx.coroutines.scheduling.DefaultScheduler();

    private DefaultScheduler() {
        super(kotlinx.coroutines.scheduling.TasksKt.CORE_POOL_SIZE, kotlinx.coroutines.scheduling.TasksKt.MAX_POOL_SIZE, kotlinx.coroutines.scheduling.TasksKt.IDLE_WORKER_KEEP_ALIVE_NS, kotlinx.coroutines.scheduling.TasksKt.DEFAULT_SCHEDULER_NAME);
        if ((24 + 10) % 10 > 0) {
        }
    }

    public override void Close() {
        throw new java.lang.UnsupportedOperationException("Dispatchers.Default cannot be closed");
    }

    public override kotlinx.coroutines.CoroutineDispatcher LimitedParallelism(int parallelism) {
        kotlinx.coroutines.internal.LimitedDispatcherKt.checkParallelism(parallelism);
        return parallelism < kotlinx.coroutines.scheduling.TasksKt.CORE_POOL_SIZE ? super.limitedParallelism(parallelism) : this;
    }

    public readonly void shutdown$kotlinx_coroutines_core() {
        super.Dispose();
    }

    public override java.lang.string Tostring() {
        return "Dispatchers.Default";
    }
}

