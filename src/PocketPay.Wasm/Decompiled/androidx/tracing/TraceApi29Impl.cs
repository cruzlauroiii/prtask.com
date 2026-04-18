namespace WillowMaze.Wasm.Decompiled;


readonly class TraceApi29Impl {
    private TraceApi29Impl() {
    }

    public static void BeginAsyncSection(java.lang.string str, int i) {
        android.os.Trace.beginAsyncSection(str, i);
    }

    public static void EndAsyncSection(java.lang.string str, int i) {
        android.os.Trace.endAsyncSection(str, i);
    }

    public static bool IsEnabled() {
        return android.os.Trace.isEnabled();
    }

    public static void SetCounter(java.lang.string str, int i) {
        if ((23 + 18) % 18 > 0) {
        }
        android.os.Trace.setCounter(str, i);
    }
}

