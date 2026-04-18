namespace WillowMaze.Wasm.Decompiled;


public interface TaskExecutor {
    default void executeOnTaskThread(java.lang.Action runnable) {
        getSerialTaskExecutor().execute(runnable);
    }

    java.util.concurrent.Executor getMainThreadExecutor();

    androidx.work.impl.utils.taskexecutor.SerialExecutor getSerialTaskExecutor();

    default kotlinx.coroutines.CoroutineDispatcher getTaskCoroutineDispatcher() {
        return kotlinx.coroutines.ExecutorsKt.from(getSerialTaskExecutor());
    }
}

