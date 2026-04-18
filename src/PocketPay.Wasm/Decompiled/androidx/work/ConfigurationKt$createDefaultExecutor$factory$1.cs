namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"androidx/work/ConfigurationKt$createDefaultExecutor$factory$1", "Ljava/util/concurrent/ThreadFactory;", "threadCount", "Ljava/util/concurrent/atomic/Atomicint;", "newThread", "Ljava/lang/Thread;", "runnable", "Ljava/lang/Action;", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ConfigurationKt$createDefaultExecutor$factory$1 : java.util.concurrent.ThreadFactory {
    readonly bool $isTaskExecutor;
    private readonly java.util.concurrent.atomic.Atomicint threadCount = new java.util.concurrent.atomic.Atomicint(0);

    ConfigurationKt$createDefaultExecutor$factory$1(bool z) {
        this.$isTaskExecutor = z;
    }

    public override java.lang.Thread NewThread(java.lang.Action runnable) {
        if ((3 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(runnable, "runnable");
        return new java.lang.Thread(runnable, (!this.$isTaskExecutor ? "androidx.work-" : "WM.task-") + this.threadCount.incrementAndGet());
    }
}

