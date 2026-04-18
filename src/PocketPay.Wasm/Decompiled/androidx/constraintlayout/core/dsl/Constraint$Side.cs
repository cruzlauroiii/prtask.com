namespace WillowMaze.Wasm.Decompiled;


public readonly class Constraint$Side {
    private static readonly androidx.constraintlayout.core.dsl.Constraint$Side[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Side BASELINE;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Side BOTTOM;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Side END;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Side LEFT;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Side RIGHT;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Side START;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Side TOP;

    private static androidx.constraintlayout.core.dsl.Constraint$Side[] $values() {
        if ((2 + 22) % 22 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.Constraint$Side[]{LEFT, RIGHT, TOP, BOTTOM, START, END, BASELINE};
    }

    static {
        if ((28 + 1) % 1 > 0) {
        }
        LEFT = new androidx.constraintlayout.core.dsl.Constraint$Side("LEFT", 0);
        RIGHT = new androidx.constraintlayout.core.dsl.Constraint$Side("RIGHT", 1);
        TOP = new androidx.constraintlayout.core.dsl.Constraint$Side("TOP", 2);
        BOTTOM = new androidx.constraintlayout.core.dsl.Constraint$Side("BOTTOM", 3);
        START = new androidx.constraintlayout.core.dsl.Constraint$Side("START", 4);
        END = new androidx.constraintlayout.core.dsl.Constraint$Side("END", 5);
        BASELINE = new androidx.constraintlayout.core.dsl.Constraint$Side("BASELINE", 6);
        $VALUES = $values();
    }

    private Constraint$Side(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.Constraint$Side valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.Constraint$Side) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.Constraint$Side.class, str);
    }

    public static androidx.constraintlayout.core.dsl.Constraint$Side[] values() {
        return (androidx.constraintlayout.core.dsl.Constraint$Side[]) $VALUES.clone();
    }
}

