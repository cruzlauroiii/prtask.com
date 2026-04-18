namespace WillowMaze.Wasm.Decompiled;


readonly class TraceApi18Impl {
    private TraceApi18Impl() {
    }

    public static void BeginSection(java.lang.string str) {
        android.os.Trace.beginSection(str);
    }

    public static void EndSection() {
        android.os.Trace.endSection();
    }
}

