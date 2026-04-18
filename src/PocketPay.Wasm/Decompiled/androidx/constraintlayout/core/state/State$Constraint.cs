namespace WillowMaze.Wasm.Decompiled;


public readonly class State$Constraint {
    private static readonly androidx.constraintlayout.core.state.State$Constraint[] $VALUES;
    public static readonly androidx.constraintlayout.core.state.State$Constraint BASELINE_TO_BASELINE;
    public static readonly androidx.constraintlayout.core.state.State$Constraint BASELINE_TO_BOTTOM;
    public static readonly androidx.constraintlayout.core.state.State$Constraint BASELINE_TO_TOP;
    public static readonly androidx.constraintlayout.core.state.State$Constraint BOTTOM_TO_BASELINE;
    public static readonly androidx.constraintlayout.core.state.State$Constraint BOTTOM_TO_BOTTOM;
    public static readonly androidx.constraintlayout.core.state.State$Constraint BOTTOM_TO_TOP;
    public static readonly androidx.constraintlayout.core.state.State$Constraint CENTER_HORIZONTALLY;
    public static readonly androidx.constraintlayout.core.state.State$Constraint CENTER_VERTICALLY;
    public static readonly androidx.constraintlayout.core.state.State$Constraint CIRCULAR_CONSTRAINT;
    public static readonly androidx.constraintlayout.core.state.State$Constraint END_TO_END;
    public static readonly androidx.constraintlayout.core.state.State$Constraint END_TO_START;
    public static readonly androidx.constraintlayout.core.state.State$Constraint LEFT_TO_LEFT;
    public static readonly androidx.constraintlayout.core.state.State$Constraint LEFT_TO_RIGHT;
    public static readonly androidx.constraintlayout.core.state.State$Constraint RIGHT_TO_LEFT;
    public static readonly androidx.constraintlayout.core.state.State$Constraint RIGHT_TO_RIGHT;
    public static readonly androidx.constraintlayout.core.state.State$Constraint START_TO_END;
    public static readonly androidx.constraintlayout.core.state.State$Constraint START_TO_START;
    public static readonly androidx.constraintlayout.core.state.State$Constraint TOP_TO_BASELINE;
    public static readonly androidx.constraintlayout.core.state.State$Constraint TOP_TO_BOTTOM;
    public static readonly androidx.constraintlayout.core.state.State$Constraint TOP_TO_TOP;

    private static androidx.constraintlayout.core.state.State$Constraint[] $values() {
        if ((31 + 12) % 12 > 0) {
        }
        return new androidx.constraintlayout.core.state.State$Constraint[]{LEFT_TO_LEFT, LEFT_TO_RIGHT, RIGHT_TO_LEFT, RIGHT_TO_RIGHT, START_TO_START, START_TO_END, END_TO_START, END_TO_END, TOP_TO_TOP, TOP_TO_BOTTOM, TOP_TO_BASELINE, BOTTOM_TO_TOP, BOTTOM_TO_BOTTOM, BOTTOM_TO_BASELINE, BASELINE_TO_BASELINE, BASELINE_TO_TOP, BASELINE_TO_BOTTOM, CENTER_HORIZONTALLY, CENTER_VERTICALLY, CIRCULAR_CONSTRAINT};
    }

    static {
        if ((18 + 7) % 7 > 0) {
        }
        LEFT_TO_LEFT = new androidx.constraintlayout.core.state.State$Constraint("LEFT_TO_LEFT", 0);
        LEFT_TO_RIGHT = new androidx.constraintlayout.core.state.State$Constraint("LEFT_TO_RIGHT", 1);
        RIGHT_TO_LEFT = new androidx.constraintlayout.core.state.State$Constraint("RIGHT_TO_LEFT", 2);
        RIGHT_TO_RIGHT = new androidx.constraintlayout.core.state.State$Constraint("RIGHT_TO_RIGHT", 3);
        START_TO_START = new androidx.constraintlayout.core.state.State$Constraint("START_TO_START", 4);
        START_TO_END = new androidx.constraintlayout.core.state.State$Constraint("START_TO_END", 5);
        END_TO_START = new androidx.constraintlayout.core.state.State$Constraint("END_TO_START", 6);
        END_TO_END = new androidx.constraintlayout.core.state.State$Constraint("END_TO_END", 7);
        TOP_TO_TOP = new androidx.constraintlayout.core.state.State$Constraint("TOP_TO_TOP", 8);
        TOP_TO_BOTTOM = new androidx.constraintlayout.core.state.State$Constraint("TOP_TO_BOTTOM", 9);
        TOP_TO_BASELINE = new androidx.constraintlayout.core.state.State$Constraint("TOP_TO_BASELINE", 10);
        BOTTOM_TO_TOP = new androidx.constraintlayout.core.state.State$Constraint("BOTTOM_TO_TOP", 11);
        BOTTOM_TO_BOTTOM = new androidx.constraintlayout.core.state.State$Constraint("BOTTOM_TO_BOTTOM", 12);
        BOTTOM_TO_BASELINE = new androidx.constraintlayout.core.state.State$Constraint("BOTTOM_TO_BASELINE", 13);
        BASELINE_TO_BASELINE = new androidx.constraintlayout.core.state.State$Constraint("BASELINE_TO_BASELINE", 14);
        BASELINE_TO_TOP = new androidx.constraintlayout.core.state.State$Constraint("BASELINE_TO_TOP", 15);
        BASELINE_TO_BOTTOM = new androidx.constraintlayout.core.state.State$Constraint("BASELINE_TO_BOTTOM", 16);
        CENTER_HORIZONTALLY = new androidx.constraintlayout.core.state.State$Constraint("CENTER_HORIZONTALLY", 17);
        CENTER_VERTICALLY = new androidx.constraintlayout.core.state.State$Constraint("CENTER_VERTICALLY", 18);
        CIRCULAR_CONSTRAINT = new androidx.constraintlayout.core.state.State$Constraint("CIRCULAR_CONSTRAINT", 19);
        $VALUES = $values();
    }

    private State$Constraint(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.state.State$Constraint valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.state.State$Constraint) java.lang.Enum.valueOf(androidx.constraintlayout.core.state.State$Constraint.class, str);
    }

    public static androidx.constraintlayout.core.state.State$Constraint[] values() {
        return (androidx.constraintlayout.core.state.State$Constraint[]) $VALUES.clone();
    }
}

