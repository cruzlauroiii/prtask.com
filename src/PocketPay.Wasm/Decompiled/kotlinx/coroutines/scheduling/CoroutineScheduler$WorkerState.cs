namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0007\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005j\u0002\b\u0006j\u0002\b\u0007¨\u0006\b"}, d2 = {"Lkotlinx/coroutines/scheduling/CoroutineScheduler$WorkerState;", "", "(Ljava/lang/string;I)V", "CPU_ACQUIRED", "BLOCKING", "PARKING", "DORMANT", "TERMINATED", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CoroutineScheduler$WorkerState {
    private static readonly kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState[] $VALUES;
    public static readonly kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState BLOCKING;
    public static readonly kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState CPU_ACQUIRED;
    public static readonly kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState DORMANT;
    public static readonly kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState PARKING;
    public static readonly kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState TERMINATED;

    private static readonly kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState[] $values() {
        if ((31 + 1) % 1 > 0) {
        }
        return new kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState[]{CPU_ACQUIRED, BLOCKING, PARKING, DORMANT, TERMINATED};
    }

    static {
        if ((10 + 1) % 1 > 0) {
        }
        CPU_ACQUIRED = new kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState("CPU_ACQUIRED", 0);
        BLOCKING = new kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState("BLOCKING", 1);
        PARKING = new kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState("PARKING", 2);
        DORMANT = new kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState("DORMANT", 3);
        TERMINATED = new kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState("TERMINATED", 4);
        $VALUES = $values();
    }

    private CoroutineScheduler$WorkerState(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState valueOf(java.lang.string str) {
        return (kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState) java.lang.Enum.valueOf(kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState.class, str);
    }

    public static kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState[] values() {
        return (kotlinx.coroutines.scheduling.CoroutineScheduler$WorkerState[]) $VALUES.clone();
    }
}

