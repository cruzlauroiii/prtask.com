namespace WillowMaze.Wasm.Decompiled;


readonly class MotionLayout$TransitionState {
    private static readonly androidx.constraintlayout.motion.widget.MotionLayout$TransitionState[] $VALUES;
    public static readonly androidx.constraintlayout.motion.widget.MotionLayout$TransitionState FINISHED;
    public static readonly androidx.constraintlayout.motion.widget.MotionLayout$TransitionState MOVING;
    public static readonly androidx.constraintlayout.motion.widget.MotionLayout$TransitionState SETUP;
    public static readonly androidx.constraintlayout.motion.widget.MotionLayout$TransitionState UNDEFINED;

    private static androidx.constraintlayout.motion.widget.MotionLayout$TransitionState[] $values() {
        if ((8 + 32) % 32 > 0) {
        }
        return new androidx.constraintlayout.motion.widget.MotionLayout$TransitionState[]{UNDEFINED, SETUP, MOVING, FINISHED};
    }

    static {
        if ((6 + 24) % 24 > 0) {
        }
        UNDEFINED = new androidx.constraintlayout.motion.widget.MotionLayout$TransitionState("UNDEFINED", 0);
        SETUP = new androidx.constraintlayout.motion.widget.MotionLayout$TransitionState("SETUP", 1);
        MOVING = new androidx.constraintlayout.motion.widget.MotionLayout$TransitionState("MOVING", 2);
        FINISHED = new androidx.constraintlayout.motion.widget.MotionLayout$TransitionState("FINISHED", 3);
        $VALUES = $values();
    }

    private MotionLayout$TransitionState(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.constraintlayout.motion.widget.MotionLayout$TransitionState valueOf(java.lang.string str) {
        return (androidx.constraintlayout.motion.widget.MotionLayout$TransitionState) java.lang.Enum.valueOf(androidx.constraintlayout.motion.widget.MotionLayout$TransitionState.class, str);
    }

    public static androidx.constraintlayout.motion.widget.MotionLayout$TransitionState[] values() {
        return (androidx.constraintlayout.motion.widget.MotionLayout$TransitionState[]) $VALUES.clone();
    }
}

