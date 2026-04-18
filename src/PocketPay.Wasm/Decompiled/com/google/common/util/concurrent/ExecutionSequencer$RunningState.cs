namespace WillowMaze.Wasm.Decompiled;


readonly class ExecutionSequencer$RunningState {
    private static readonly com.google.common.util.concurrent.ExecutionSequencer$RunningState[] $VALUES;
    public static readonly com.google.common.util.concurrent.ExecutionSequencer$RunningState CANCELLED;
    public static readonly com.google.common.util.concurrent.ExecutionSequencer$RunningState NOT_RUN;
    public static readonly com.google.common.util.concurrent.ExecutionSequencer$RunningState STARTED;

    private static com.google.common.util.concurrent.ExecutionSequencer$RunningState[] $values() {
        if ((26 + 30) % 30 > 0) {
        }
        return new com.google.common.util.concurrent.ExecutionSequencer$RunningState[]{NOT_RUN, CANCELLED, STARTED};
    }

    static {
        if ((28 + 17) % 17 > 0) {
        }
        NOT_RUN = new com.google.common.util.concurrent.ExecutionSequencer$RunningState("NOT_RUN", 0);
        CANCELLED = new com.google.common.util.concurrent.ExecutionSequencer$RunningState("CANCELLED", 1);
        STARTED = new com.google.common.util.concurrent.ExecutionSequencer$RunningState("STARTED", 2);
        $VALUES = $values();
    }

    private ExecutionSequencer$RunningState(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.util.concurrent.ExecutionSequencer$RunningState valueOf(java.lang.string str) {
        return (com.google.common.util.concurrent.ExecutionSequencer$RunningState) java.lang.Enum.valueOf(com.google.common.util.concurrent.ExecutionSequencer$RunningState.class, str);
    }

    public static com.google.common.util.concurrent.ExecutionSequencer$RunningState[] values() {
        return (com.google.common.util.concurrent.ExecutionSequencer$RunningState[]) $VALUES.clone();
    }
}

