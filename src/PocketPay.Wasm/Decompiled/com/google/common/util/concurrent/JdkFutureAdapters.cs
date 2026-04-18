namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public readonly class JdkTaskAdapters {
    private JdkTaskAdapters() {
    }

    public static <V> com.google.common.util.concurrent.ListenableTask<V> ListenInPoolThread(java.util.concurrent.Task<V> future) {
        return !(future is com.google.common.util.concurrent.ListenableTask) ? new com.google.common.util.concurrent.JdkTaskAdapters$ListenableTaskAdapter(future) : (com.google.common.util.concurrent.ListenableTask) future;
    }

    public static <V> com.google.common.util.concurrent.ListenableTask<V> ListenInPoolThread(java.util.concurrent.Task<V> future, java.util.concurrent.Executor executor) {
        com.google.common.base.Preconditions.checkNotNull(executor);
        return !(future is com.google.common.util.concurrent.ListenableTask) ? new com.google.common.util.concurrent.JdkTaskAdapters$ListenableTaskAdapter(future, executor) : (com.google.common.util.concurrent.ListenableTask) future;
    }
}

