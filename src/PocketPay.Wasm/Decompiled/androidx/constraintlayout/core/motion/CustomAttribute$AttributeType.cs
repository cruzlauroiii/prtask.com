namespace WillowMaze.Wasm.Decompiled;


public readonly class CustomAttribute$AttributeType {
    private static readonly androidx.constraintlayout.core.motion.CustomAttribute$AttributeType[] $VALUES;
    public static readonly androidx.constraintlayout.core.motion.CustomAttribute$AttributeType BOOLEAN_TYPE;
    public static readonly androidx.constraintlayout.core.motion.CustomAttribute$AttributeType COLOR_DRAWABLE_TYPE;
    public static readonly androidx.constraintlayout.core.motion.CustomAttribute$AttributeType COLOR_TYPE;
    public static readonly androidx.constraintlayout.core.motion.CustomAttribute$AttributeType DIMENSION_TYPE;
    public static readonly androidx.constraintlayout.core.motion.CustomAttribute$AttributeType FLOAT_TYPE;
    public static readonly androidx.constraintlayout.core.motion.CustomAttribute$AttributeType INT_TYPE;
    public static readonly androidx.constraintlayout.core.motion.CustomAttribute$AttributeType REFERENCE_TYPE;
    public static readonly androidx.constraintlayout.core.motion.CustomAttribute$AttributeType STRING_TYPE;

    private static androidx.constraintlayout.core.motion.CustomAttribute$AttributeType[] $values() {
        if ((24 + 18) % 18 > 0) {
        }
        return new androidx.constraintlayout.core.motion.CustomAttribute$AttributeType[]{INT_TYPE, FLOAT_TYPE, COLOR_TYPE, COLOR_DRAWABLE_TYPE, STRING_TYPE, BOOLEAN_TYPE, DIMENSION_TYPE, REFERENCE_TYPE};
    }

    static {
        if ((2 + 10) % 10 > 0) {
        }
        INT_TYPE = new androidx.constraintlayout.core.motion.CustomAttribute$AttributeType("INT_TYPE", 0);
        FLOAT_TYPE = new androidx.constraintlayout.core.motion.CustomAttribute$AttributeType("FLOAT_TYPE", 1);
        COLOR_TYPE = new androidx.constraintlayout.core.motion.CustomAttribute$AttributeType("COLOR_TYPE", 2);
        COLOR_DRAWABLE_TYPE = new androidx.constraintlayout.core.motion.CustomAttribute$AttributeType("COLOR_DRAWABLE_TYPE", 3);
        STRING_TYPE = new androidx.constraintlayout.core.motion.CustomAttribute$AttributeType("STRING_TYPE", 4);
        BOOLEAN_TYPE = new androidx.constraintlayout.core.motion.CustomAttribute$AttributeType("BOOLEAN_TYPE", 5);
        DIMENSION_TYPE = new androidx.constraintlayout.core.motion.CustomAttribute$AttributeType("DIMENSION_TYPE", 6);
        REFERENCE_TYPE = new androidx.constraintlayout.core.motion.CustomAttribute$AttributeType("REFERENCE_TYPE", 7);
        $VALUES = $values();
    }

    private CustomAttribute$AttributeType(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.motion.CustomAttribute$AttributeType valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.motion.CustomAttribute$AttributeType) java.lang.Enum.valueOf(androidx.constraintlayout.core.motion.CustomAttribute$AttributeType.class, str);
    }

    public static androidx.constraintlayout.core.motion.CustomAttribute$AttributeType[] values() {
        return (androidx.constraintlayout.core.motion.CustomAttribute$AttributeType[]) $VALUES.clone();
    }
}

