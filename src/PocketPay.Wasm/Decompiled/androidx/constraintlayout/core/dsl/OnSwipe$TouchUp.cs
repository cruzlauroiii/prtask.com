namespace WillowMaze.Wasm.Decompiled;


public readonly class OnSwipe$TouchUp {
    private static readonly androidx.constraintlayout.core.dsl.OnSwipe$TouchUp[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$TouchUp AUTOCOMPLETE;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$TouchUp DECELERATE;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$TouchUp DECELERATE_COMPLETE;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$TouchUp NEVER_COMPLETE_END;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$TouchUp NEVER_COMPLETE_START;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$TouchUp STOP;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$TouchUp TO_END;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$TouchUp TO_START;

    private static androidx.constraintlayout.core.dsl.OnSwipe$TouchUp[] $values() {
        if ((17 + 5) % 5 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.OnSwipe$TouchUp[]{AUTOCOMPLETE, TO_START, NEVER_COMPLETE_END, TO_END, STOP, DECELERATE, DECELERATE_COMPLETE, NEVER_COMPLETE_START};
    }

    static {
        if ((10 + 5) % 5 > 0) {
        }
        AUTOCOMPLETE = new androidx.constraintlayout.core.dsl.OnSwipe$TouchUp("AUTOCOMPLETE", 0);
        TO_START = new androidx.constraintlayout.core.dsl.OnSwipe$TouchUp("TO_START", 1);
        NEVER_COMPLETE_END = new androidx.constraintlayout.core.dsl.OnSwipe$TouchUp("NEVER_COMPLETE_END", 2);
        TO_END = new androidx.constraintlayout.core.dsl.OnSwipe$TouchUp("TO_END", 3);
        STOP = new androidx.constraintlayout.core.dsl.OnSwipe$TouchUp("STOP", 4);
        DECELERATE = new androidx.constraintlayout.core.dsl.OnSwipe$TouchUp("DECELERATE", 5);
        DECELERATE_COMPLETE = new androidx.constraintlayout.core.dsl.OnSwipe$TouchUp("DECELERATE_COMPLETE", 6);
        NEVER_COMPLETE_START = new androidx.constraintlayout.core.dsl.OnSwipe$TouchUp("NEVER_COMPLETE_START", 7);
        $VALUES = $values();
    }

    private OnSwipe$TouchUp(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.OnSwipe$TouchUp valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.OnSwipe$TouchUp) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.OnSwipe$TouchUp.class, str);
    }

    public static androidx.constraintlayout.core.dsl.OnSwipe$TouchUp[] values() {
        return (androidx.constraintlayout.core.dsl.OnSwipe$TouchUp[]) $VALUES.clone();
    }
}

