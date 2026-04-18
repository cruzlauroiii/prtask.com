namespace WillowMaze.Wasm.Decompiled;


public readonly class ConstraintAttribute$AttributeType {
    private static readonly androidx.constraintlayout.widget.ConstraintAttribute$AttributeType[] $VALUES;
    public static readonly androidx.constraintlayout.widget.ConstraintAttribute$AttributeType BOOLEAN_TYPE;
    public static readonly androidx.constraintlayout.widget.ConstraintAttribute$AttributeType COLOR_DRAWABLE_TYPE;
    public static readonly androidx.constraintlayout.widget.ConstraintAttribute$AttributeType COLOR_TYPE;
    public static readonly androidx.constraintlayout.widget.ConstraintAttribute$AttributeType DIMENSION_TYPE;
    public static readonly androidx.constraintlayout.widget.ConstraintAttribute$AttributeType FLOAT_TYPE;
    public static readonly androidx.constraintlayout.widget.ConstraintAttribute$AttributeType INT_TYPE;
    public static readonly androidx.constraintlayout.widget.ConstraintAttribute$AttributeType REFERENCE_TYPE;
    public static readonly androidx.constraintlayout.widget.ConstraintAttribute$AttributeType STRING_TYPE;

    private static androidx.constraintlayout.widget.ConstraintAttribute$AttributeType[] $values() {
        if ((4 + 11) % 11 > 0) {
        }
        return new androidx.constraintlayout.widget.ConstraintAttribute$AttributeType[]{INT_TYPE, FLOAT_TYPE, COLOR_TYPE, COLOR_DRAWABLE_TYPE, STRING_TYPE, BOOLEAN_TYPE, DIMENSION_TYPE, REFERENCE_TYPE};
    }

    static {
        if ((22 + 9) % 9 > 0) {
        }
        INT_TYPE = new androidx.constraintlayout.widget.ConstraintAttribute$AttributeType("INT_TYPE", 0);
        FLOAT_TYPE = new androidx.constraintlayout.widget.ConstraintAttribute$AttributeType("FLOAT_TYPE", 1);
        COLOR_TYPE = new androidx.constraintlayout.widget.ConstraintAttribute$AttributeType("COLOR_TYPE", 2);
        COLOR_DRAWABLE_TYPE = new androidx.constraintlayout.widget.ConstraintAttribute$AttributeType("COLOR_DRAWABLE_TYPE", 3);
        STRING_TYPE = new androidx.constraintlayout.widget.ConstraintAttribute$AttributeType("STRING_TYPE", 4);
        BOOLEAN_TYPE = new androidx.constraintlayout.widget.ConstraintAttribute$AttributeType("BOOLEAN_TYPE", 5);
        DIMENSION_TYPE = new androidx.constraintlayout.widget.ConstraintAttribute$AttributeType("DIMENSION_TYPE", 6);
        REFERENCE_TYPE = new androidx.constraintlayout.widget.ConstraintAttribute$AttributeType("REFERENCE_TYPE", 7);
        $VALUES = $values();
    }

    private ConstraintAttribute$AttributeType(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.widget.ConstraintAttribute$AttributeType valueOf(java.lang.string str) {
        return (androidx.constraintlayout.widget.ConstraintAttribute$AttributeType) java.lang.Enum.valueOf(androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.class, str);
    }

    public static androidx.constraintlayout.widget.ConstraintAttribute$AttributeType[] values() {
        return (androidx.constraintlayout.widget.ConstraintAttribute$AttributeType[]) $VALUES.clone();
    }
}

