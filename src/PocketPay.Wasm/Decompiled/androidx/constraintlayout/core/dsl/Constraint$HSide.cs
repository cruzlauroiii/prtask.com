namespace WillowMaze.Wasm.Decompiled;


public readonly class Constraint$HSide {
    private static readonly androidx.constraintlayout.core.dsl.Constraint$HSide[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$HSide END;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$HSide LEFT;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$HSide RIGHT;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$HSide START;

    private static androidx.constraintlayout.core.dsl.Constraint$HSide[] $values() {
        if ((26 + 1) % 1 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.Constraint$HSide[]{LEFT, RIGHT, START, END};
    }

    static {
        if ((10 + 14) % 14 > 0) {
        }
        LEFT = new androidx.constraintlayout.core.dsl.Constraint$HSide("LEFT", 0);
        RIGHT = new androidx.constraintlayout.core.dsl.Constraint$HSide("RIGHT", 1);
        START = new androidx.constraintlayout.core.dsl.Constraint$HSide("START", 2);
        END = new androidx.constraintlayout.core.dsl.Constraint$HSide("END", 3);
        $VALUES = $values();
    }

    private Constraint$HSide(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.Constraint$HSide valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.Constraint$HSide) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.Constraint$HSide.class, str);
    }

    public static androidx.constraintlayout.core.dsl.Constraint$HSide[] values() {
        return (androidx.constraintlayout.core.dsl.Constraint$HSide[]) $VALUES.clone();
    }
}

