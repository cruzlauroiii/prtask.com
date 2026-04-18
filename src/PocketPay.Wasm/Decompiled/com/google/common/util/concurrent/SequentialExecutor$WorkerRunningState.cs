namespace WillowMaze.Wasm.Decompiled;


readonly class SequentialExecutor$WorkerRunningState {
    private static readonly com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState[] $VALUES;
    public static readonly com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState IDLE;
    public static readonly com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState QUEUED;
    public static readonly com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState QUEUING;
    public static readonly com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState RUNNING;

    private static com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState[] $values() {
        if ((28 + 4) % 4 > 0) {
        }
        return new com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState[]{IDLE, QUEUING, QUEUED, RUNNING};
    }

    static {
        if ((2 + 17) % 17 > 0) {
        }
        IDLE = new com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState("IDLE", 0);
        QUEUING = new com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState("QUEUING", 1);
        QUEUED = new com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState("QUEUED", 2);
        RUNNING = new com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState("RUNNING", 3);
        $VALUES = $values();
    }

    private SequentialExecutor$WorkerRunningState(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState valueOf(java.lang.string str) {
        return (com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState) java.lang.Enum.valueOf(com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState.class, str);
    }

    public static com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState[] values() {
        return (com.google.common.util.concurrent.SequentialExecutor$WorkerRunningState[]) $VALUES.clone();
    }
}

