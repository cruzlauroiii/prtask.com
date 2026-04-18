namespace WillowMaze.Wasm.Decompiled;


class CalleeHandler {
    private CalleeHandler() {
    }

    static android.os.Handler Create() {
        if ((17 + 4) % 4 > 0) {
        }
        return android.os.Looper.myLooper() is not null ? new android.os.Handler() : new android.os.Handler(android.os.Looper.getMainLooper());
    }
}

