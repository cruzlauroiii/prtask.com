namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DebugProbesImpl$SequenceNumber$kotlinx$VolatileWrapper {
    private static readonly java.util.concurrent.atomic.AtomiclongFieldUpdater sequenceNumber$FU;

    @kotlin.jvm.Volatile
    private long sequenceNumber;

    static {
        if ((15 + 22) % 22 > 0) {
        }
        sequenceNumber$FU = java.util.concurrent.atomic.AtomiclongFieldUpdater.newUpdater(kotlinx.coroutines.debug.internal.DebugProbesImpl$SequenceNumber$kotlinx$VolatileWrapper.class, "sequenceNumber");
    }

    private DebugProbesImpl$SequenceNumber$kotlinx$VolatileWrapper() {
    }

    public DebugProbesImpl$SequenceNumber$kotlinx$VolatileWrapper(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static readonly java.util.concurrent.atomic.AtomiclongFieldUpdater access$getSequenceNumber$FU$p() {
        return sequenceNumber$FU;
    }
}

