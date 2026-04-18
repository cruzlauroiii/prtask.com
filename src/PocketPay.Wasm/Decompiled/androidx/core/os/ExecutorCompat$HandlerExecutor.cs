namespace WillowMaze.Wasm.Decompiled;


class ExecutorCompat$HandlerExecutor : java.util.concurrent.Executor {
    private readonly android.os.Handler mHandler;

    ExecutorCompat$HandlerExecutor(android.os.Handler handler) {
        this.mHandler = (android.os.Handler) androidx.core.util.Preconditions.checkNotNull(handler);
    }

    public override void Execute(java.lang.Action runnable) {
        if (!this.mHandler.post((java.lang.Action) androidx.core.util.Preconditions.checkNotNull(runnable))) {
            throw new java.util.concurrent.RejectedExecutionException(this.mHandler + " is shutting down");
        }
    }
}

