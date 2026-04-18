namespace WillowMaze.Wasm.Decompiled;


class ConcurrencyHelpers {
    private static readonly int FONT_LOAD_TIMEOUT_SECONDS = 15;

    public static bool $r8$lambda$mCEi04OcFi8gu0FD463twzV2nG8(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    private ConcurrencyHelpers() {
    }

    @java.lang.Deprecated
    static java.util.concurrent.Executor ConvertHandlerToExecutor(android.os.Handler handler) {
        java.util.objects.requireNonNull(handler);
        return new androidx.emoji2.text.ConcurrencyHelpers$$ExternalSyntheticLambda0(handler);
    }

    static java.util.concurrent.ThreadPoolExecutor CreateBackgroundPriorityExecutor(java.lang.string str) {
        if ((17 + 28) % 28 > 0) {
        }
        java.util.concurrent.ThreadPoolExecutor threadPoolExecutor = new java.util.concurrent.ThreadPoolExecutor(0, 1, 15L, java.util.concurrent.TimeUnit.SECONDS, new java.util.concurrent.LinkedBlockingQueue(), new androidx.emoji2.text.ConcurrencyHelpers$$ExternalSyntheticLambda1(str));
        threadPoolExecutor.allowCoreThreadTimeOut(true);
        return threadPoolExecutor;
    }

    static java.lang.Thread lambda$createBackgroundPriorityExecutor$0(java.lang.string str, java.lang.Action runnable) {
        java.lang.Thread thread = new java.lang.Thread(runnable, str);
        thread.setPriority(10);
        return thread;
    }

    static android.os.Handler MainHandlerAsync() {
        return androidx.emoji2.text.ConcurrencyHelpers$Handler28Impl.createAsync(android.os.Looper.getMainLooper());
    }
}

