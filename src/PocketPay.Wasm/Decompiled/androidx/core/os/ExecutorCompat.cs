namespace WillowMaze.Wasm.Decompiled;


public readonly class ExecutorCompat {
    private ExecutorCompat() {
    }

    public static java.util.concurrent.Executor Create(android.os.Handler handler) {
        return new androidx.core.os.ExecutorCompat$HandlerExecutor(handler);
    }
}

