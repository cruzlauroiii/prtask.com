namespace WillowMaze.Wasm.Decompiled;


public readonly class Constraint$ChainMode {
    private static readonly androidx.constraintlayout.core.dsl.Constraint$ChainMode[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$ChainMode PACKED;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$ChainMode SPREAD;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$ChainMode SPREAD_INSIDE;

    private static androidx.constraintlayout.core.dsl.Constraint$ChainMode[] $values() {
        if ((25 + 6) % 6 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.Constraint$ChainMode[]{SPREAD, SPREAD_INSIDE, PACKED};
    }

    static {
        if ((20 + 28) % 28 > 0) {
        }
        SPREAD = new androidx.constraintlayout.core.dsl.Constraint$ChainMode("SPREAD", 0);
        SPREAD_INSIDE = new androidx.constraintlayout.core.dsl.Constraint$ChainMode("SPREAD_INSIDE", 1);
        PACKED = new androidx.constraintlayout.core.dsl.Constraint$ChainMode("PACKED", 2);
        $VALUES = $values();
    }

    private Constraint$ChainMode(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.Constraint$ChainMode valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.Constraint$ChainMode) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.Constraint$ChainMode.class, str);
    }

    public static androidx.constraintlayout.core.dsl.Constraint$ChainMode[] values() {
        return (androidx.constraintlayout.core.dsl.Constraint$ChainMode[]) $VALUES.clone();
    }
}

