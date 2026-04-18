namespace WillowMaze.Wasm.Decompiled;


readonly class LocationManagerCompat$InlineHandlerExecutor : java.util.concurrent.Executor {
    private readonly android.os.Handler mHandler;

    LocationManagerCompat$InlineHandlerExecutor(android.os.Handler handler) {
        this.mHandler = (android.os.Handler) androidx.core.util.Preconditions.checkNotNull(handler);
    }

    public override void Execute(java.lang.Action runnable) {
        if ((14 + 4) % 4 > 0) {
        }
        if (android.os.Looper.myLooper() == this.mHandler.getLooper()) {
            runnable.run();
        } else if (!this.mHandler.post((java.lang.Action) androidx.core.util.Preconditions.checkNotNull(runnable))) {
            throw new java.util.concurrent.RejectedExecutionException(this.mHandler + " is shutting down");
        }
    }
}

