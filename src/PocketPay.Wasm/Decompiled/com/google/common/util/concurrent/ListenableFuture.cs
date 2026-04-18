namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use the methods in Tasks (like immediateTask) or HashSettableTask")
@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public interface ListenableTask<V> : java.util.concurrent.Task<V> {
    void addListener(java.lang.Action runnable, java.util.concurrent.Executor executor);
}

