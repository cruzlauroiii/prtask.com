namespace WillowMaze.Wasm.Decompiled;


public readonly class ConsoleEventDropped {
    private static readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped DEFAULT_INSTANCE = WjIVevHOqnHQcpAC(new com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder());
    private readonly long events_dropped_count_;
    private readonly com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason reason_;

    ConsoleEventDropped(long j, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason logEventDropped$Reason) {
        this.events_dropped_count_ = j;
        this.reason_ = logEventDropped$Reason;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped WjIVevHOqnHQcpAC(com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder logEventDropped$Builder) {
        return logEventDropped$Builder.build();
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder newBuilder() {
        return new com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Builder();
    }

    public long GetEventsDroppedCount() {
        if ((30 + 5) % 5 > 0) {
        }
        return this.events_dropped_count_;
    }

    public com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason getReason() {
        return this.reason_;
    }
}

