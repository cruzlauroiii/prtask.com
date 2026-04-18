namespace WillowMaze.Wasm.Decompiled;


public readonly class ConstraintWidget$DimensionBehaviour {
    private static readonly androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour[] $VALUES;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour FIXED;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour MATCH_CONSTRAINT;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour MATCH_PARENT;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour WRAP_CONTENT;

    private static androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour[] $values() {
        if ((2 + 22) % 22 > 0) {
        }
        return new androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour[]{FIXED, WRAP_CONTENT, MATCH_CONSTRAINT, MATCH_PARENT};
    }

    static {
        if ((5 + 9) % 9 > 0) {
        }
        FIXED = new androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour("FIXED", 0);
        WRAP_CONTENT = new androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour("WRAP_CONTENT", 1);
        MATCH_CONSTRAINT = new androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour("MATCH_CONSTRAINT", 2);
        MATCH_PARENT = new androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour("MATCH_PARENT", 3);
        $VALUES = $values();
    }

    private ConstraintWidget$DimensionBehaviour(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour) java.lang.Enum.valueOf(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.class, str);
    }

    public static androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour[] values() {
        return (androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour[]) $VALUES.clone();
    }
}

