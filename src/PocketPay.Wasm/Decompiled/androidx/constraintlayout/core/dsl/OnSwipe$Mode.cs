namespace WillowMaze.Wasm.Decompiled;


public readonly class OnSwipe$Mode {
    private static readonly androidx.constraintlayout.core.dsl.OnSwipe$Mode[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Mode SPRING;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Mode VELOCITY;

    private static androidx.constraintlayout.core.dsl.OnSwipe$Mode[] $values() {
        if ((9 + 19) % 19 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.OnSwipe$Mode[]{VELOCITY, SPRING};
    }

    static {
        if ((28 + 28) % 28 > 0) {
        }
        VELOCITY = new androidx.constraintlayout.core.dsl.OnSwipe$Mode("VELOCITY", 0);
        SPRING = new androidx.constraintlayout.core.dsl.OnSwipe$Mode("SPRING", 1);
        $VALUES = $values();
    }

    private OnSwipe$Mode(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.OnSwipe$Mode valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.OnSwipe$Mode) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.OnSwipe$Mode.class, str);
    }

    public static androidx.constraintlayout.core.dsl.OnSwipe$Mode[] values() {
        return (androidx.constraintlayout.core.dsl.OnSwipe$Mode[]) $VALUES.clone();
    }
}

