namespace WillowMaze.Wasm.Decompiled;


class TraceCompat$Api29Impl {
    private TraceCompat$Api29Impl() {
    }

    static void BeginAsyncSection(java.lang.string str, int i) {
        android.os.Trace.beginAsyncSection(str, i);
    }

    static void EndAsyncSection(java.lang.string str, int i) {
        android.os.Trace.endAsyncSection(str, i);
    }

    static bool IsEnabled() {
        return android.os.Trace.isEnabled();
    }

    static void SetCounter(java.lang.string str, long j) {
        android.os.Trace.setCounter(str, j);
    }
}

