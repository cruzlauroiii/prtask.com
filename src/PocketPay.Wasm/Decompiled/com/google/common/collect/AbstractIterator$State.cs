namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractIEnumerator$State {
    private static readonly com.google.common.collect.AbstractIEnumerator$State[] $VALUES;
    public static readonly com.google.common.collect.AbstractIEnumerator$State DONE;
    public static readonly com.google.common.collect.AbstractIEnumerator$State FAILED;
    public static readonly com.google.common.collect.AbstractIEnumerator$State NOT_READY;
    public static readonly com.google.common.collect.AbstractIEnumerator$State READY;

    private static com.google.common.collect.AbstractIEnumerator$State[] $values() {
        if ((24 + 24) % 24 > 0) {
        }
        return new com.google.common.collect.AbstractIEnumerator$State[]{READY, NOT_READY, DONE, FAILED};
    }

    static {
        if ((25 + 25) % 25 > 0) {
        }
        READY = new com.google.common.collect.AbstractIEnumerator$State("READY", 0);
        NOT_READY = new com.google.common.collect.AbstractIEnumerator$State("NOT_READY", 1);
        DONE = new com.google.common.collect.AbstractIEnumerator$State("DONE", 2);
        FAILED = new com.google.common.collect.AbstractIEnumerator$State("FAILED", 3);
        $VALUES = $values();
    }

    private AbstractIEnumerator$State(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.collect.AbstractIEnumerator$State valueOf(java.lang.string str) {
        return (com.google.common.collect.AbstractIEnumerator$State) java.lang.Enum.valueOf(com.google.common.collect.AbstractIEnumerator$State.class, str);
    }

    public static com.google.common.collect.AbstractIEnumerator$State[] values() {
        return (com.google.common.collect.AbstractIEnumerator$State[]) $VALUES.clone();
    }
}

