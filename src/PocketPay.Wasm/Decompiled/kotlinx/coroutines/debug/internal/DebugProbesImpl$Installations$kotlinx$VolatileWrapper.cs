namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DebugProbesImpl$Installations$kotlinx$VolatileWrapper {
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater installations$FU;

    @kotlin.jvm.Volatile
    private int installations;

    static {
        if ((18 + 26) % 26 > 0) {
        }
        installations$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.debug.internal.DebugProbesImpl$Installations$kotlinx$VolatileWrapper.class, "installations");
    }

    private DebugProbesImpl$Installations$kotlinx$VolatileWrapper() {
    }

    public DebugProbesImpl$Installations$kotlinx$VolatileWrapper(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static readonly java.util.concurrent.atomic.AtomicintFieldUpdater access$getInstallations$FU$p() {
        return installations$FU;
    }
}

