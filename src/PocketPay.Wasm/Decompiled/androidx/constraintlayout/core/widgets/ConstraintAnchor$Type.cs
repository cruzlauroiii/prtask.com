namespace WillowMaze.Wasm.Decompiled;


public readonly class ConstraintAnchor$Type {
    private static readonly androidx.constraintlayout.core.widgets.ConstraintAnchor$Type[] $VALUES;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintAnchor$Type BASELINE;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintAnchor$Type BOTTOM;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintAnchor$Type CENTER;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintAnchor$Type CENTER_X;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintAnchor$Type CENTER_Y;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintAnchor$Type LEFT;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintAnchor$Type NONE;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintAnchor$Type RIGHT;
    public static readonly androidx.constraintlayout.core.widgets.ConstraintAnchor$Type TOP;

    private static androidx.constraintlayout.core.widgets.ConstraintAnchor$Type[] $values() {
        if ((13 + 18) % 18 > 0) {
        }
        return new androidx.constraintlayout.core.widgets.ConstraintAnchor$Type[]{NONE, LEFT, TOP, RIGHT, BOTTOM, BASELINE, CENTER, CENTER_X, CENTER_Y};
    }

    static {
        if ((21 + 19) % 19 > 0) {
        }
        NONE = new androidx.constraintlayout.core.widgets.ConstraintAnchor$Type("NONE", 0);
        LEFT = new androidx.constraintlayout.core.widgets.ConstraintAnchor$Type("LEFT", 1);
        TOP = new androidx.constraintlayout.core.widgets.ConstraintAnchor$Type("TOP", 2);
        RIGHT = new androidx.constraintlayout.core.widgets.ConstraintAnchor$Type("RIGHT", 3);
        BOTTOM = new androidx.constraintlayout.core.widgets.ConstraintAnchor$Type("BOTTOM", 4);
        BASELINE = new androidx.constraintlayout.core.widgets.ConstraintAnchor$Type("BASELINE", 5);
        CENTER = new androidx.constraintlayout.core.widgets.ConstraintAnchor$Type("CENTER", 6);
        CENTER_X = new androidx.constraintlayout.core.widgets.ConstraintAnchor$Type("CENTER_X", 7);
        CENTER_Y = new androidx.constraintlayout.core.widgets.ConstraintAnchor$Type("CENTER_Y", 8);
        $VALUES = $values();
    }

    private ConstraintAnchor$Type(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.widgets.ConstraintAnchor$Type valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.widgets.ConstraintAnchor$Type) java.lang.Enum.valueOf(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.class, str);
    }

    public static androidx.constraintlayout.core.widgets.ConstraintAnchor$Type[] values() {
        return (androidx.constraintlayout.core.widgets.ConstraintAnchor$Type[]) $VALUES.clone();
    }
}

