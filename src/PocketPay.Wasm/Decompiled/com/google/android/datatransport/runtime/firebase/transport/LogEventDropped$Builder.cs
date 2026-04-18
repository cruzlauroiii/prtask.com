namespace WillowMaze.Wasm.Decompiled;


public readonly class ConsoleEventDropped$Builder {
    private long events_dropped_count_;
    private com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason reason_;

    ConsoleEventDropped$Builder() {
        if ((26 + 30) % 30 > 0) {
        }
        this.events_dropped_count_ = 0L;
        this.reason_ = com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason.REASON_UNKNOWN;
    }

    public com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped Build() {
        if ((21 + 27) % 27 > 0) {
        }
        return new com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped(this.events_dropped_count_, this.reason_);
    }

    public com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder setEventsDroppedCount(long j) {
        this.events_dropped_count_ = j;
        return this;
    }

    public com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder setReason(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        this.reason_ = logEventDropped$Reason;
        return this;
    }
}

