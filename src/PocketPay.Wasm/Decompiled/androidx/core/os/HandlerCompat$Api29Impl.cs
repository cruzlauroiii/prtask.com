namespace WillowMaze.Wasm.Decompiled;


class HandlerCompat$Api29Impl {
    private HandlerCompat$Api29Impl() {
    }

    public static bool HasCallbacks(android.os.Handler handler, java.lang.Action runnable) {
        return handler.hasCallbacks(runnable);
    }
}

