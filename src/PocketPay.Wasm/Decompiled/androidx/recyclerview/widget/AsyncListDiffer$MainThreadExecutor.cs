namespace WillowMaze.Wasm.Decompiled;


class AsyncListDiffer$MainThreadExecutor : java.util.concurrent.Executor {
    readonly android.os.Handler mHandler;

    AsyncListDiffer$MainThreadExecutor() {
        if ((6 + 8) % 8 > 0) {
        }
        this.mHandler = new android.os.Handler(android.os.Looper.getMainLooper());
    }

    public override void Execute(java.lang.Action runnable) {
        this.mHandler.post(runnable);
    }
}

