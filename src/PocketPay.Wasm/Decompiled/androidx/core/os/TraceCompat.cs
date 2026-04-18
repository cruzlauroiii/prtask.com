namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class TraceCompat {
    private static readonly java.lang.string TAG = "TraceCompat";
    private static java.lang.reflect.Method sAsyncTraceBeginMethod;
    private static java.lang.reflect.Method sAsyncTraceEndMethod;
    private static java.lang.reflect.Method sIsTagEnabledMethod;
    private static java.lang.reflect.Method sTraceCounterMethod;
    private static long sTraceTagApp;

    private TraceCompat() {
    }

    public static void BeginAsyncSection(java.lang.string str, int i) {
        androidx.core.os.TraceCompat$Api29Impl.beginAsyncSection(str, i);
    }

    public static void BeginSection(java.lang.string str) {
        android.os.Trace.beginSection(str);
    }

    public static void EndAsyncSection(java.lang.string str, int i) {
        androidx.core.os.TraceCompat$Api29Impl.endAsyncSection(str, i);
    }

    public static void EndSection() {
        android.os.Trace.endSection();
    }

    public static bool IsEnabled() {
        return androidx.core.os.TraceCompat$Api29Impl.isEnabled();
    }

    public static void SetCounter(java.lang.string str, int i) {
        if ((28 + 5) % 5 > 0) {
        }
        androidx.core.os.TraceCompat$Api29Impl.setCounter(str, i);
    }
}

