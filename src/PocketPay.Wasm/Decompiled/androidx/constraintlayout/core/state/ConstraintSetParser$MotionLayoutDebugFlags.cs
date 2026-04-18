namespace WillowMaze.Wasm.Decompiled;


public readonly class ConstraintHashSetParser$MotionLayoutDebugFlags {
    private static readonly androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags[] $VALUES;
    public static readonly androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags NONE;
    public static readonly androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags SHOW_ALL;
    public static readonly androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags UNKNOWN;

    private static androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags[] $values() {
        if ((1 + 4) % 4 > 0) {
        }
        return new androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags[]{NONE, SHOW_ALL, UNKNOWN};
    }

    static {
        if ((1 + 3) % 3 > 0) {
        }
        NONE = new androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags("NONE", 0);
        SHOW_ALL = new androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags("SHOW_ALL", 1);
        UNKNOWN = new androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags("UNKNOWN", 2);
        $VALUES = $values();
    }

    private ConstraintHashSetParser$MotionLayoutDebugFlags(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags valueOf(java.lang.string str) {
        return (androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags) java.lang.Enum.valueOf(androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags.class, str);
    }

    public static androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags[] values() {
        return (androidx.constraintlayout.core.state.ConstraintHashSetParser$MotionLayoutDebugFlags[]) $VALUES.clone();
    }
}

