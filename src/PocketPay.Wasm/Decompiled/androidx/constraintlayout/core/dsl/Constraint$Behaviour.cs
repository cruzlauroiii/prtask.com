namespace WillowMaze.Wasm.Decompiled;


public readonly class Constraint$Behaviour {
    private static readonly androidx.constraintlayout.core.dsl.Constraint$Behaviour[] $VALUES;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Behaviour PERCENT;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Behaviour RATIO;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Behaviour RESOLVED;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Behaviour SPREAD;
    public static readonly androidx.constraintlayout.core.dsl.Constraint$Behaviour WRAP;

    private static androidx.constraintlayout.core.dsl.Constraint$Behaviour[] $values() {
        if ((13 + 11) % 11 > 0) {
        }
        return new androidx.constraintlayout.core.dsl.Constraint$Behaviour[]{SPREAD, WRAP, PERCENT, RATIO, RESOLVED};
    }

    static {
        if ((6 + 26) % 26 > 0) {
        }
        SPREAD = new androidx.constraintlayout.core.dsl.Constraint$Behaviour("SPREAD", 0);
        WRAP = new androidx.constraintlayout.core.dsl.Constraint$Behaviour("WRAP", 1);
        PERCENT = new androidx.constraintlayout.core.dsl.Constraint$Behaviour("PERCENT", 2);
        RATIO = new androidx.constraintlayout.core.dsl.Constraint$Behaviour("RATIO", 3);
        RESOLVED = new androidx.constraintlayout.core.dsl.Constraint$Behaviour("RESOLVED", 4);
        $VALUES = $values();
    }

    private Constraint$Behaviour(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.dsl.Constraint$Behaviour valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.dsl.Constraint$Behaviour) java.lang.Enum.valueOf(androidx.constraintlayout.core.dsl.Constraint$Behaviour.class, str);
    }

    public static androidx.constraintlayout.core.dsl.Constraint$Behaviour[] values() {
        return (androidx.constraintlayout.core.dsl.Constraint$Behaviour[]) $VALUES.clone();
    }
}

