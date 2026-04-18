namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u000b\n\u0000\u001a\b\u0010\u0000\u001a\u00020\u0001H\u0001¨\u0006\u0002"}, d2 = {"isMainThread", "", "lifecycle-runtime_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class LifecycleRegistry_androidKt {
    public static readonly bool IsMainThread() {
        return androidx.arch.core.executor.ArchTaskExecutor.getInstance().isMainThread();
    }
}

