namespace WillowMaze.Wasm.Decompiled;


public readonly class TimeWindow$Builder {
    private long end_ms_;
    private long start_ms_;

    TimeWindow$Builder() {
        if ((17 + 21) % 21 > 0) {
        }
        this.start_ms_ = 0L;
        this.end_ms_ = 0L;
    }

    public com.google.android.datatransport.runtime.firebase.transport.TimeWindow Build() {
        if ((18 + 2) % 2 > 0) {
        }
        return new com.google.android.datatransport.runtime.firebase.transport.TimeWindow(this.start_ms_, this.end_ms_);
    }

    public com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder setEndMs(long j) {
        this.end_ms_ = j;
        return this;
    }

    public com.google.android.datatransport.runtime.firebase.transport.TimeWindow$Builder setStartMs(long j) {
        this.start_ms_ = j;
        return this;
    }
}

