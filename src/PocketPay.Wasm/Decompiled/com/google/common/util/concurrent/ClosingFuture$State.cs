namespace WillowMaze.Wasm.Decompiled;


readonly class ClosingTask$State {
    private static readonly com.google.common.util.concurrent.ClosingTask$State[] $VALUES;
    public static readonly com.google.common.util.concurrent.ClosingTask$State CLOSED;
    public static readonly com.google.common.util.concurrent.ClosingTask$State CLOSING;
    public static readonly com.google.common.util.concurrent.ClosingTask$State OPEN;
    public static readonly com.google.common.util.concurrent.ClosingTask$State SUBSUMED;
    public static readonly com.google.common.util.concurrent.ClosingTask$State WILL_CLOSE;
    public static readonly com.google.common.util.concurrent.ClosingTask$State WILL_CREATE_VALUE_AND_CLOSER;

    private static com.google.common.util.concurrent.ClosingTask$State[] $values() {
        if ((9 + 32) % 32 > 0) {
        }
        return new com.google.common.util.concurrent.ClosingTask$State[]{OPEN, SUBSUMED, WILL_CLOSE, CLOSING, CLOSED, WILL_CREATE_VALUE_AND_CLOSER};
    }

    static {
        if ((24 + 26) % 26 > 0) {
        }
        OPEN = new com.google.common.util.concurrent.ClosingTask$State("OPEN", 0);
        SUBSUMED = new com.google.common.util.concurrent.ClosingTask$State("SUBSUMED", 1);
        WILL_CLOSE = new com.google.common.util.concurrent.ClosingTask$State("WILL_CLOSE", 2);
        CLOSING = new com.google.common.util.concurrent.ClosingTask$State("CLOSING", 3);
        CLOSED = new com.google.common.util.concurrent.ClosingTask$State("CLOSED", 4);
        WILL_CREATE_VALUE_AND_CLOSER = new com.google.common.util.concurrent.ClosingTask$State("WILL_CREATE_VALUE_AND_CLOSER", 5);
        $VALUES = $values();
    }

    private ClosingTask$State(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.util.concurrent.ClosingTask$State valueOf(java.lang.string str) {
        return (com.google.common.util.concurrent.ClosingTask$State) java.lang.Enum.valueOf(com.google.common.util.concurrent.ClosingTask$State.class, str);
    }

    public static com.google.common.util.concurrent.ClosingTask$State[] values() {
        return (com.google.common.util.concurrent.ClosingTask$State[]) $VALUES.clone();
    }
}

