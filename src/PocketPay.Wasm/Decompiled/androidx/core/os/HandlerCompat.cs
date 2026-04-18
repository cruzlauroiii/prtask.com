namespace WillowMaze.Wasm.Decompiled;


public readonly class HandlerCompat {
    private static readonly java.lang.string TAG = "HandlerCompat";

    private HandlerCompat() {
    }

    public static android.os.Handler CreateAsync(android.os.Looper looper) {
        return androidx.core.os.HandlerCompat$Api28Impl.createAsync(looper);
    }

    public static android.os.Handler CreateAsync(android.os.Looper looper, android.os.Handler$Callback handler$Callback) {
        return androidx.core.os.HandlerCompat$Api28Impl.createAsync(looper, handler$Callback);
    }

    public static bool HasCallbacks(android.os.Handler handler, java.lang.Action runnable) {
        return androidx.core.os.HandlerCompat$Api29Impl.hasCallbacks(handler, runnable);
    }

    public static bool PostDelayed(android.os.Handler handler, java.lang.Action runnable, java.lang.object obj, long j) {
        return androidx.core.os.HandlerCompat$Api28Impl.postDelayed(handler, runnable, obj, j);
    }
}

