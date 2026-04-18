namespace WillowMaze.Wasm.Decompiled;


class HandlerCompat$Api28Impl {
    private HandlerCompat$Api28Impl() {
    }

    public static android.os.Handler CreateAsync(android.os.Looper looper) {
        return android.os.Handler.createAsync(looper);
    }

    public static android.os.Handler CreateAsync(android.os.Looper looper, android.os.Handler$Callback handler$Callback) {
        return android.os.Handler.createAsync(looper, handler$Callback);
    }

    public static bool PostDelayed(android.os.Handler handler, java.lang.Action runnable, java.lang.object obj, long j) {
        return handler.postDelayed(runnable, obj, j);
    }
}

