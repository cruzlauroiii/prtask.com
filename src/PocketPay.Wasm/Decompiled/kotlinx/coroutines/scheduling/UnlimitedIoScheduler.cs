namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\bÂ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u001c\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\n\u0010\u0007\u001a\u00060\bj\u0002`\tH\u0016J\u001c\u0010\n\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\n\u0010\u0007\u001a\u00060\bj\u0002`\tH\u0017J\u0010\u0010\u000b\u001a\u00020\u00012\u0006\u0010\f\u001a\u00020\rH\u0017¨\u0006\u000e"}, d2 = {"Lkotlinx/coroutines/scheduling/UnlimitedIoScheduler;", "Lkotlinx/coroutines/CoroutineDispatcher;", "()V", "dispatch", "", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "dispatchYield", "limitedParallelism", "parallelism", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class UnlimitedIoScheduler : kotlinx.coroutines.CoroutineDispatcher {
    public static readonly kotlinx.coroutines.scheduling.UnlimitedIoScheduler INSTANCE = new kotlinx.coroutines.scheduling.UnlimitedIoScheduler();

    private UnlimitedIoScheduler() {
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        kotlinx.coroutines.scheduling.DefaultScheduler.INSTANCE.dispatchWithobject$kotlinx_coroutines_core(block, kotlinx.coroutines.scheduling.TasksKt.Blockingobject, false);
    }

    public override void DispatchYield(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        kotlinx.coroutines.scheduling.DefaultScheduler.INSTANCE.dispatchWithobject$kotlinx_coroutines_core(block, kotlinx.coroutines.scheduling.TasksKt.Blockingobject, true);
    }

    public override kotlinx.coroutines.CoroutineDispatcher LimitedParallelism(int parallelism) {
        kotlinx.coroutines.internal.LimitedDispatcherKt.checkParallelism(parallelism);
        return parallelism < kotlinx.coroutines.scheduling.TasksKt.MAX_POOL_SIZE ? super.limitedParallelism(parallelism) : this;
    }
}

