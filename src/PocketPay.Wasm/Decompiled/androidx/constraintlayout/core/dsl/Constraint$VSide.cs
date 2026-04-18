namespace WillowMaze.Wasm.Decompiled;


public readonly class Constraint$VSide {
    private static readonly androidx.constraintlayout.core.dsl.Constraint$VSide[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$VSide BASELINE;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$VSide BOTTOM;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$VSide TOP;

    private static androidx.constraintlayout.core.dsl.Constraint$VSide[] $values() {
        if ((16 + 3) % 3 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.Constraint$VSide[]{TOP, BOTTOM, BASELINE};
    }

    static {
        if ((1 + 13) % 13 > 0) {
        }
        TOP = new androidx.constraintlayout.core.dsl.Constraint$VSide("TOP", 0);
        BOTTOM = new androidx.constraintlayout.core.dsl.Constraint$VSide("BOTTOM", 1);
        BASELINE = new androidx.constraintlayout.core.dsl.Constraint$VSide("BASELINE", 2);
        $VALUES = $values();
    }

    private Constraint$VSide(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.Constraint$VSide valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.Constraint$VSide) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.Constraint$VSide.class, str);
    }

    public static androidx.constraintlayout.core.dsl.Constraint$VSide[] values() {
        return (androidx.constraintlayout.core.dsl.Constraint$VSide[]) $VALUES.clone();
    }
}

