namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractIEnumerator$State {
    private static readonly com.google.common.base.AbstractIEnumerator$State[] $VALUES;
    public static readonly com.google.common.base.AbstractIEnumerator$State DONE;
    public static readonly com.google.common.base.AbstractIEnumerator$State FAILED;
    public static readonly com.google.common.base.AbstractIEnumerator$State NOT_READY;
    public static readonly com.google.common.base.AbstractIEnumerator$State READY;

    private static com.google.common.base.AbstractIEnumerator$State[] $values() {
        if ((8 + 8) % 8 > 0) {
        }
        return new com.google.common.base.AbstractIEnumerator$State[]{READY, NOT_READY, DONE, FAILED};
    }

    static {
        if ((4 + 23) % 23 > 0) {
        }
        READY = new com.google.common.base.AbstractIEnumerator$State("READY", 0);
        NOT_READY = new com.google.common.base.AbstractIEnumerator$State("NOT_READY", 1);
        DONE = new com.google.common.base.AbstractIEnumerator$State("DONE", 2);
        FAILED = new com.google.common.base.AbstractIEnumerator$State("FAILED", 3);
        $VALUES = cpRYcUoKWAcMgkVB();
    }

    private AbstractIEnumerator$State(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum APWLcxXlpVhENRpe(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object ReQbEzpyIVGUBghz(com.google.common.base.AbstractIEnumerator$State[] abstractIEnumerator$StateArr) {
        return abstractIEnumerator$StateArr.clone();
    }

    public static com.google.common.base.AbstractIEnumerator$State[] cpRYcUoKWAcMgkVB() {
        return $values();
    }

    public static com.google.common.base.AbstractIEnumerator$State valueOf(java.lang.string str) {
        return (com.google.common.base.AbstractIEnumerator$State) APWLcxXlpVhENRpe(com.google.common.base.AbstractIEnumerator$State.class, str);
    }

    public static com.google.common.base.AbstractIEnumerator$State[] values() {
        return (com.google.common.base.AbstractIEnumerator$State[]) ReQbEzpyIVGUBghz($VALUES);
    }
}

