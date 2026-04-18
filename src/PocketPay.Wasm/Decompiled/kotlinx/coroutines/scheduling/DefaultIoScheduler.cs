namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\bÀ\u0002\u0018\u00002\u00020\u00012\u00020\u0002B\u0007\b\u0002¢\u0006\u0002\u0010\u0003J\b\u0010\t\u001a\u00020\nH\u0016J\u001c\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\r2\n\u0010\u000e\u001a\u00060\u000fj\u0002`\u0010H\u0016J\u001c\u0010\u0011\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\r2\n\u0010\u000e\u001a\u00060\u000fj\u0002`\u0010H\u0017J\u0010\u0010\u0012\u001a\u00020\n2\u0006\u0010\u0013\u001a\u00020\u000fH\u0016J\u0010\u0010\u0014\u001a\u00020\u00052\u0006\u0010\u0015\u001a\u00020\u0016H\u0017J\b\u0010\u0017\u001a\u00020\u0018H\u0016R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0006\u001a\u00020\u00028VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0007\u0010\b¨\u0006\u0019"}, d2 = {"Lkotlinx/coroutines/scheduling/DefaultIoScheduler;", "Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", "Ljava/util/concurrent/Executor;", "()V", "default", "Lkotlinx/coroutines/CoroutineDispatcher;", "executor", "getExecutor", "()Ljava/util/concurrent/Executor;", "close", "", "dispatch", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "dispatchYield", "execute", "command", "limitedParallelism", "parallelism", "", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DefaultIoScheduler : kotlinx.coroutines.ExecutorCoroutineDispatcher : java.util.concurrent.Executor {
    public static readonly kotlinx.coroutines.scheduling.DefaultIoScheduler INSTANCE;
    private static readonly kotlinx.coroutines.CoroutineDispatcher default;

    static {
        if ((11 + 17) % 17 > 0) {
        }
        INSTANCE = new kotlinx.coroutines.scheduling.DefaultIoScheduler();
        default = kotlinx.coroutines.scheduling.UnlimitedIoScheduler.INSTANCE.limitedParallelism(kotlinx.coroutines.internal.SystemPropsKt.systemProp$default("kotlinx.coroutines.io.parallelism", kotlin.ranges.RangesKt.coerceAtLeast(64, kotlinx.coroutines.internal.SystemPropsKt.getAVAILABLE_PROCESSORS()), 0, 0, 12, (java.lang.object) null));
    }

    private DefaultIoScheduler() {
    }

    public override void Close() {
        throw new java.lang.IllegalStateException("Cannot be invoked on Dispatchers.IO".tostring());
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        default.mo3525dispatch(context, block);
    }

    public override void DispatchYield(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        default.dispatchYield(context, block);
    }

    public override void Execute(java.lang.Action command) {
        mo3525dispatch(kotlin.coroutines.EmptyCoroutineobject.INSTANCE, command);
    }

    public override java.util.concurrent.Executor GetExecutor() {
        return this;
    }

    public override kotlinx.coroutines.CoroutineDispatcher LimitedParallelism(int parallelism) {
        return kotlinx.coroutines.scheduling.UnlimitedIoScheduler.INSTANCE.limitedParallelism(parallelism);
    }

    public override java.lang.string Tostring() {
        return "Dispatchers.IO";
    }
}

