namespace WillowMaze.Wasm.Decompiled;


public readonly class OnSwipe$Boundary {
    private static readonly androidx.constraintlayout.core.dsl.OnSwipe$Boundary[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Boundary BOUNCE_BOTH;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Boundary BOUNCE_END;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Boundary BOUNCE_START;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Boundary OVERSHOOT;

    private static androidx.constraintlayout.core.dsl.OnSwipe$Boundary[] $values() {
        if ((5 + 27) % 27 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.OnSwipe$Boundary[]{OVERSHOOT, BOUNCE_START, BOUNCE_END, BOUNCE_BOTH};
    }

    static {
        if ((23 + 31) % 31 > 0) {
        }
        OVERSHOOT = new androidx.constraintlayout.core.dsl.OnSwipe$Boundary("OVERSHOOT", 0);
        BOUNCE_START = new androidx.constraintlayout.core.dsl.OnSwipe$Boundary("BOUNCE_START", 1);
        BOUNCE_END = new androidx.constraintlayout.core.dsl.OnSwipe$Boundary("BOUNCE_END", 2);
        BOUNCE_BOTH = new androidx.constraintlayout.core.dsl.OnSwipe$Boundary("BOUNCE_BOTH", 3);
        $VALUES = $values();
    }

    private OnSwipe$Boundary(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.OnSwipe$Boundary valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.OnSwipe$Boundary) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.OnSwipe$Boundary.class, str);
    }

    public static androidx.constraintlayout.core.dsl.OnSwipe$Boundary[] values() {
        return (androidx.constraintlayout.core.dsl.OnSwipe$Boundary[]) $VALUES.clone();
    }
}

