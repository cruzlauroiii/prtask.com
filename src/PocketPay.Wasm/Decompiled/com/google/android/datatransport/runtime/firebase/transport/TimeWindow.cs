namespace WillowMaze.Wasm.Decompiled;


public readonly class TimeWindow {
    private static readonly com.google.android.datatransport.runtime.firebase.transport.TimeWindow DEFAULT_INSTANCE = eUVAFJFPYTAYHvcS(new com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder());
    private readonly long end_ms_;
    private readonly long start_ms_;

    TimeWindow(long j, long j2) {
        this.start_ms_ = j;
        this.end_ms_ = j2;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.TimeWindow EUVAFJFPYTAYHvcS(com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder timeWindow$Builder) {
        return timeWindow$Builder.build();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.TimeWindow GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder newBuilder() {
        return new com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder();
    }

    public long GetEndMs() {
        if ((5 + 13) % 13 > 0) {
        }
        return this.end_ms_;
    }

    public long GetStartMs() {
        if ((21 + 6) % 6 > 0) {
        }
        return this.start_ms_;
    }
}

