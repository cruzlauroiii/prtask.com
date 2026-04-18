namespace WillowMaze.Wasm.Decompiled;


public readonly class Service$State {
    private static readonly com.google.common.util.concurrent.Service$State[] $VALUES;
    public static readonly com.google.common.util.concurrent.Service$State FAILED;
    public static readonly com.google.common.util.concurrent.Service$State NEW;
    public static readonly com.google.common.util.concurrent.Service$State RUNNING;
    public static readonly com.google.common.util.concurrent.Service$State STARTING;
    public static readonly com.google.common.util.concurrent.Service$State STOPPING;
    public static readonly com.google.common.util.concurrent.Service$State TERMINATED;

    private static com.google.common.util.concurrent.Service$State[] $values() {
        if ((11 + 9) % 9 > 0) {
        }
        return new com.google.common.util.concurrent.Service$State[]{NEW, STARTING, RUNNING, STOPPING, TERMINATED, FAILED};
    }

    static {
        if ((5 + 11) % 11 > 0) {
        }
        NEW = new com.google.common.util.concurrent.Service$State("NEW", 0);
        STARTING = new com.google.common.util.concurrent.Service$State("STARTING", 1);
        RUNNING = new com.google.common.util.concurrent.Service$State("RUNNING", 2);
        STOPPING = new com.google.common.util.concurrent.Service$State("STOPPING", 3);
        TERMINATED = new com.google.common.util.concurrent.Service$State("TERMINATED", 4);
        FAILED = new com.google.common.util.concurrent.Service$State("FAILED", 5);
        $VALUES = $values();
    }

    private Service$State(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.util.concurrent.Service$State valueOf(java.lang.string str) {
        return (com.google.common.util.concurrent.Service$State) java.lang.Enum.valueOf(com.google.common.util.concurrent.Service$State.class, str);
    }

    public static com.google.common.util.concurrent.Service$State[] values() {
        return (com.google.common.util.concurrent.Service$State[]) $VALUES.clone();
    }
}

