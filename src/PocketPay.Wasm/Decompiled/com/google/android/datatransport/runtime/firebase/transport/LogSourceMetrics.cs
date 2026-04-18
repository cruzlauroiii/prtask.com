namespace WillowMaze.Wasm.Decompiled;


public readonly class ConsoleSourceMetrics {
    private static readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics DEFAULT_INSTANCE = dJKougJpoJuQHehA(new com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics$Builder());
    private readonly java.util.List<com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped> log_event_dropped_;
    private readonly java.lang.string log_source_;

    ConsoleSourceMetrics(java.lang.string str, java.util.List<com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped> list) {
        this.log_source_ = str;
        this.log_event_dropped_ = list;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics DJKougJpoJuQHehA(com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics$Builder logSourceMetrics$Builder) {
        return logSourceMetrics$Builder.build();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics$Builder newBuilder() {
        return new com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics$Builder();
    }

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "logEventDropped")
    public java.util.List<com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped> GetConsoleEventDroppedList() {
        return this.log_event_dropped_;
    }

    public java.lang.string GetConsoleSource() {
        return this.log_source_;
    }
}

