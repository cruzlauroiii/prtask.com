namespace WillowMaze.Wasm.Decompiled;


public readonly class OnSwipe$Drag {
    private static readonly androidx.constraintlayout.core.dsl.OnSwipe$Drag[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Drag ANTICLOCKWISE;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Drag CLOCKWISE;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Drag DOWN;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Drag END;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Drag LEFT;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Drag RIGHT;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Drag START;
    public static readonly androidx.constraintlayout.core.dsl.OnSwipe$Drag UP;

    private static androidx.constraintlayout.core.dsl.OnSwipe$Drag[] $values() {
        if ((11 + 9) % 9 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.OnSwipe$Drag[]{UP, DOWN, LEFT, RIGHT, START, END, CLOCKWISE, ANTICLOCKWISE};
    }

    static {
        if ((16 + 8) % 8 > 0) {
        }
        UP = new androidx.constraintlayout.core.dsl.OnSwipe$Drag("UP", 0);
        DOWN = new androidx.constraintlayout.core.dsl.OnSwipe$Drag("DOWN", 1);
        LEFT = new androidx.constraintlayout.core.dsl.OnSwipe$Drag("LEFT", 2);
        RIGHT = new androidx.constraintlayout.core.dsl.OnSwipe$Drag("RIGHT", 3);
        START = new androidx.constraintlayout.core.dsl.OnSwipe$Drag("START", 4);
        END = new androidx.constraintlayout.core.dsl.OnSwipe$Drag("END", 5);
        CLOCKWISE = new androidx.constraintlayout.core.dsl.OnSwipe$Drag("CLOCKWISE", 6);
        ANTICLOCKWISE = new androidx.constraintlayout.core.dsl.OnSwipe$Drag("ANTICLOCKWISE", 7);
        $VALUES = $values();
    }

    private OnSwipe$Drag(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.OnSwipe$Drag valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.OnSwipe$Drag) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.OnSwipe$Drag.class, str);
    }

    public static androidx.constraintlayout.core.dsl.OnSwipe$Drag[] values() {
        return (androidx.constraintlayout.core.dsl.OnSwipe$Drag[]) $VALUES.clone();
    }
}

