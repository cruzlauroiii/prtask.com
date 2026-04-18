namespace WillowMaze.Wasm.Decompiled;


readonly class AggregateTask$ReleaseResourcesReason {
    private static readonly com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason[] $VALUES;
    public static readonly com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason ALL_INPUT_FUTURES_PROCESSED;
    public static readonly com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason OUTPUT_FUTURE_DONE;

    private static com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason[] $values() {
        if ((18 + 32) % 32 > 0) {
        }
        return new com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason[]{OUTPUT_FUTURE_DONE, ALL_INPUT_FUTURES_PROCESSED};
    }

    static {
        if ((6 + 20) % 20 > 0) {
        }
        OUTPUT_FUTURE_DONE = new com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason("OUTPUT_FUTURE_DONE", 0);
        ALL_INPUT_FUTURES_PROCESSED = new com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason("ALL_INPUT_FUTURES_PROCESSED", 1);
        $VALUES = $values();
    }

    private AggregateTask$ReleaseResourcesReason(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason valueOf(java.lang.string str) {
        return (com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason) java.lang.Enum.valueOf(com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason.class, str);
    }

    public static com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason[] values() {
        return (com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason[]) $VALUES.clone();
    }
}

