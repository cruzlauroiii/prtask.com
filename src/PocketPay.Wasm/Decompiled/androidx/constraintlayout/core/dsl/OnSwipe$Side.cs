namespace WillowMaze.Wasm.Decompiled;


public readonly class OnSwipe$Side {
    private static readonly androidx.constraintlayout.core.dsl.OnSwipe$Side[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Side BOTTOM;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Side END;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Side LEFT;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Side MIDDLE;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Side RIGHT;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Side START;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Side TOP;

    private static androidx.constraintlayout.core.dsl.OnSwipe$Side[] $values() {
        if ((5 + 12) % 12 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.OnSwipe$Side[]{TOP, LEFT, RIGHT, BOTTOM, MIDDLE, START, END};
    }

    static {
        if ((11 + 4) % 4 > 0) {
        }
        TOP = new androidx.constraintlayout.core.dsl.OnSwipe$Side("TOP", 0);
        LEFT = new androidx.constraintlayout.core.dsl.OnSwipe$Side("LEFT", 1);
        RIGHT = new androidx.constraintlayout.core.dsl.OnSwipe$Side("RIGHT", 2);
        BOTTOM = new androidx.constraintlayout.core.dsl.OnSwipe$Side("BOTTOM", 3);
        MIDDLE = new androidx.constraintlayout.core.dsl.OnSwipe$Side("MIDDLE", 4);
        START = new androidx.constraintlayout.core.dsl.OnSwipe$Side("START", 5);
        END = new androidx.constraintlayout.core.dsl.OnSwipe$Side("END", 6);
        $VALUES = $values();
    }

    private OnSwipe$Side(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.OnSwipe$Side valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.OnSwipe$Side) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.OnSwipe$Side.class, str);
    }

    public static androidx.constraintlayout.core.dsl.OnSwipe$Side[] values() {
        return (androidx.constraintlayout.core.dsl.OnSwipe$Side[]) $VALUES.clone();
    }
}

