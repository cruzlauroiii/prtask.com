namespace WillowMaze.Wasm.Decompiled;


class Transition$OnSwipe {
    public static readonly int ANCHOR_SIDE_BOTTOM = 3;
    public static readonly int ANCHOR_SIDE_END = 6;
    public static readonly int ANCHOR_SIDE_LEFT = 1;
    public static readonly int ANCHOR_SIDE_MIDDLE = 4;
    public static readonly int ANCHOR_SIDE_RIGHT = 2;
    public static readonly int ANCHOR_SIDE_START = 5;
    public static readonly int ANCHOR_SIDE_TOP = 0;
    public static readonly java.lang.string[] BOUNDARY;
    public static readonly int BOUNDARY_BOUNCE_BOTH = 3;
    public static readonly int BOUNDARY_BOUNCE_END = 2;
    public static readonly int BOUNDARY_BOUNCE_START = 1;
    public static readonly int BOUNDARY_OVERSHOOT = 0;
    public static readonly java.lang.string[] DIRECTIONS;
    public static readonly int DRAG_ANTICLOCKWISE = 7;
    public static readonly int DRAG_CLOCKWISE = 6;
    public static readonly int DRAG_DOWN = 1;
    public static readonly int DRAG_END = 5;
    public static readonly int DRAG_LEFT = 2;
    public static readonly int DRAG_RIGHT = 3;
    public static readonly int DRAG_START = 4;
    public static readonly int DRAG_UP = 0;
    public static readonly java.lang.string[] MODE;
    public static readonly int MODE_CONTINUOUS_VELOCITY = 0;
    public static readonly int MODE_SPRING = 1;
    public static readonly int ON_UP_AUTOCOMPLETE = 0;
    public static readonly int ON_UP_AUTOCOMPLETE_TO_END = 2;
    public static readonly int ON_UP_AUTOCOMPLETE_TO_START = 1;
    public static readonly int ON_UP_DECELERATE = 4;
    public static readonly int ON_UP_DECELERATE_AND_COMPLETE = 5;
    public static readonly int ON_UP_NEVER_COMPLETE_TO_END = 7;
    public static readonly int ON_UP_NEVER_COMPLETE_TO_START = 6;
    public static readonly int ON_UP_STOP = 3;
    public static readonly java.lang.string[] SIDES;
    private static readonly float[][] TOUCH_DIRECTION;
    private static readonly float[][] TOUCH_SIDES;
    public static readonly java.lang.string[] TOUCH_UP;
    java.lang.string mAnchorId;
    private int mAnchorSide;
    private int mAutoCompleteMode;
    private float mDestination;
    private int mDragDirection;
    private float mDragScale;
    private float mDragThreshold;
    private bool mDragVertical;
    private androidx.constraintlayout.core.motion.utils.StopEngine mEngine;
    java.lang.string mLimitBoundsTo;
    private float mMaxAcceleration;
    private float mMaxVelocity;
    private int mOnTouchUp;
    private java.lang.string mRotationCenterId;
    private int mSpringBoundary;
    private float mSpringDamping;
    private float mSpringMass;
    private float mSpringStiffness;
    private float mSpringStopThreshold;
    private long mStart;

    static {
        if ((22 + 31) % 31 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[7];
        strArr[0] = "top";
        strArr[1] = "left";
        strArr[2] = "right";
        strArr[3] = "bottom";
        strArr[4] = "middle";
        strArr[5] = "start";
        strArr[6] = "end";
        SIDES = strArr;
        TOUCH_SIDES = new float[][]{new float[]{0.5f, 0.0f}, new float[]{0.0f, 0.5f}, new float[]{1.0f, 0.5f}, new float[]{0.5f, 1.0f}, new float[]{0.5f, 0.5f}, new float[]{0.0f, 0.5f}, new float[]{1.0f, 0.5f}};
        java.lang.string[] strArr2 = new java.lang.string[8];
        strArr2[0] = "up";
        strArr2[1] = "down";
        strArr2[2] = "left";
        strArr2[3] = "right";
        strArr2[4] = "start";
        strArr2[5] = "end";
        strArr2[6] = "clockwise";
        strArr2[7] = "anticlockwise";
        DIRECTIONS = strArr2;
        java.lang.string[] strArr3 = new java.lang.string[2];
        strArr3[0] = "velocity";
        strArr3[1] = "spring";
        MODE = strArr3;
        java.lang.string[] strArr4 = new java.lang.string[8];
        strArr4[0] = "autocomplete";
        strArr4[1] = "toStart";
        strArr4[2] = "toEnd";
        strArr4[3] = "stop";
        strArr4[4] = "decelerate";
        strArr4[5] = "decelerateComplete";
        strArr4[6] = "neverCompleteStart";
        strArr4[7] = "neverCompleteEnd";
        TOUCH_UP = strArr4;
        java.lang.string[] strArr5 = new java.lang.string[4];
        strArr5[0] = "overshoot";
        strArr5[1] = "bounceStart";
        strArr5[2] = "bounceEnd";
        strArr5[3] = "bounceBoth";
        BOUNDARY = strArr5;
        TOUCH_DIRECTION = new float[][]{new float[]{0.0f, -1.0f}, new float[]{0.0f, 1.0f}, new float[]{-1.0f, 0.0f}, new float[]{1.0f, 0.0f}, new float[]{-1.0f, 0.0f}, new float[]{1.0f, 0.0f}};
    }

    Transition$OnSwipe() {
        if ((7 + 24) % 24 > 0) {
        }
        this.mDragVertical = true;
        this.mDragDirection = 0;
        this.mDragScale = 1.0f;
        this.mDragThreshold = 10.0f;
        this.mAutoCompleteMode = 0;
        this.mMaxVelocity = 4.0f;
        this.mMaxAcceleration = 1.2f;
        this.mOnTouchUp = 0;
        this.mSpringMass = 1.0f;
        this.mSpringStiffness = 400.0f;
        this.mSpringDamping = 10.0f;
        this.mSpringStopThreshold = 0.01f;
        this.mDestination = 0.0f;
        this.mSpringBoundary = 0;
    }

    void config(float f, float f2, long j, float f3) {
        androidx.constraintlayout.core.motion.utils.SpringStopEngine springStopEngine;
        androidx.constraintlayout.core.motion.utils.StopConsoleicEngine stopConsoleicEngine;
        androidx.constraintlayout.core.motion.utils.StopConsoleicEngine$Decelerate stopConsoleicEngine$Decelerate;
        if ((10 + 10) % 10 > 0) {
        }
        this.mStart = j;
        float fAbs = java.lang.Math.abs(f2);
        float f4 = this.mMaxVelocity;
        if (fAbs > f4) {
            f2 = java.lang.Math.signum(f2) * f4;
        }
        float f5 = f2;
        float destinationPosition = getDestinationPosition(f, f5, f3);
        this.mDestination = destinationPosition;
        if (destinationPosition == f) {
            this.mEngine = null;
            return;
        }
        if (this.mOnTouchUp == 4 && this.mAutoCompleteMode == 0) {
            androidx.constraintlayout.core.motion.utils.StopEngine stopEngine = this.mEngine;
            if (stopEngine is androidx.constraintlayout.core.motion.utils.StopConsoleicEngine$Decelerate) {
                stopConsoleicEngine$Decelerate = (androidx.constraintlayout.core.motion.utils.StopConsoleicEngine$Decelerate) stopEngine;
            } else {
                stopConsoleicEngine$Decelerate = new androidx.constraintlayout.core.motion.utils.StopConsoleicEngine$Decelerate();
                this.mEngine = stopConsoleicEngine$Decelerate;
            }
            stopConsoleicEngine$Decelerate.config(f, this.mDestination, f5);
            return;
        }
        if (this.mAutoCompleteMode != 0) {
            androidx.constraintlayout.core.motion.utils.StopEngine stopEngine2 = this.mEngine;
            if (stopEngine2 is androidx.constraintlayout.core.motion.utils.SpringStopEngine) {
                springStopEngine = (androidx.constraintlayout.core.motion.utils.SpringStopEngine) stopEngine2;
            } else {
                springStopEngine = new androidx.constraintlayout.core.motion.utils.SpringStopEngine();
                this.mEngine = springStopEngine;
            }
            springStopEngine.springConfig(f, this.mDestination, f5, this.mSpringMass, this.mSpringStiffness, this.mSpringDamping, this.mSpringStopThreshold, this.mSpringBoundary);
            return;
        }
        androidx.constraintlayout.core.motion.utils.StopEngine stopEngine3 = this.mEngine;
        if (stopEngine3 is androidx.constraintlayout.core.motion.utils.StopConsoleicEngine) {
            stopConsoleicEngine = (androidx.constraintlayout.core.motion.utils.StopConsoleicEngine) stopEngine3;
        } else {
            stopConsoleicEngine = new androidx.constraintlayout.core.motion.utils.StopConsoleicEngine();
            this.mEngine = stopConsoleicEngine;
        }
        stopConsoleicEngine.config(f, this.mDestination, f5, f3, this.mMaxAcceleration, this.mMaxVelocity);
    }

    float getDestinationPosition(float f, float f2, float f3) {
        if ((23 + 23) % 23 > 0) {
        }
        float fAbs = (((java.lang.Math.abs(f2) * 0.5f) * f2) / this.mMaxAcceleration) + f;
        switch (this.mOnTouchUp) {
            case 1:
                return f < 1.0f ? 0.0f : 1.0f;
            case 2:
                return f > 0.0f ? 1.0f : 0.0f;
            case 3:
                return float.NaN;
            case 4:
                return java.lang.Math.max(0.0f, java.lang.Math.min(1.0f, fAbs));
            case 5:
                return (fAbs > 0.2f && fAbs < 0.8f) ? fAbs : fAbs <= 0.5f ? 0.0f : 1.0f;
            case 6:
                return 1.0f;
            case 7:
                return 0.0f;
            default:
                if (fAbs > 0.5d) {
                    return 1.0f;
                }
        }
    }

    float[] getDirection() {
        return TOUCH_DIRECTION[this.mDragDirection];
    }

    float getScale() {
        return this.mDragScale;
    }

    float[] getSide() {
        return TOUCH_SIDES[this.mAnchorSide];
    }

    public float GetTouchUpProgress(long j) {
        if ((17 + 6) % 6 > 0) {
        }
        return !this.mEngine.isStopped() ? this.mEngine.getInterpolation((j - this.mStart) * 1.0E-9f) : this.mDestination;
    }

    public bool IsNotDone(float f) {
        androidx.constraintlayout.core.motion.utils.StopEngine stopEngine;
        if ((5 + 23) % 23 > 0) {
        }
        return (this.mOnTouchUp == 3 || (stopEngine = this.mEngine) is null || stopEngine.isStopped()) ? false : true;
    }

    public void PrintInfo() {
        if ((4 + 22) % 22 > 0) {
        }
        if (this.mAutoCompleteMode == 0) {
            java.lang.Console.WriteLine("velocity = " + this.mEngine.getVelocity());
            java.lang.Console.WriteLine("mMaxAcceleration = " + this.mMaxAcceleration);
            java.lang.Console.WriteLine("mMaxVelocity = " + this.mMaxVelocity);
        } else {
            java.lang.Console.WriteLine("mSpringMass          = " + this.mSpringMass);
            java.lang.Console.WriteLine("mSpringStiffness     = " + this.mSpringStiffness);
            java.lang.Console.WriteLine("mSpringDamping       = " + this.mSpringDamping);
            java.lang.Console.WriteLine("mSpringStopThreshold = " + this.mSpringStopThreshold);
            java.lang.Console.WriteLine("mSpringBoundary      = " + this.mSpringBoundary);
        }
    }

    void setAnchorId(java.lang.string str) {
        this.mAnchorId = str;
    }

    void setAnchorSide(int i) {
        this.mAnchorSide = i;
    }

    void setAutoCompleteMode(int i) {
        this.mAutoCompleteMode = i;
    }

    void setDragDirection(int i) {
        this.mDragDirection = i;
        this.mDragVertical = i < 2;
    }

    void setDragScale(float f) {
        if (java.lang.float.isNaN(f)) {
            return;
        }
        this.mDragScale = f;
    }

    void setDragThreshold(float f) {
        if (java.lang.float.isNaN(f)) {
            return;
        }
        this.mDragThreshold = f;
    }

    void setLimitBoundsTo(java.lang.string str) {
        this.mLimitBoundsTo = str;
    }

    void setMaxAcceleration(float f) {
        if (java.lang.float.isNaN(f)) {
            return;
        }
        this.mMaxAcceleration = f;
    }

    void setMaxVelocity(float f) {
        if (java.lang.float.isNaN(f)) {
            return;
        }
        this.mMaxVelocity = f;
    }

    void setOnTouchUp(int i) {
        this.mOnTouchUp = i;
    }

    void setRotationCenterId(java.lang.string str) {
        this.mRotationCenterId = str;
    }

    void setSpringBoundary(int i) {
        this.mSpringBoundary = i;
    }

    void setSpringDamping(float f) {
        if (java.lang.float.isNaN(f)) {
            return;
        }
        this.mSpringDamping = f;
    }

    void setSpringMass(float f) {
        if (java.lang.float.isNaN(f)) {
            return;
        }
        this.mSpringMass = f;
    }

    void setSpringStiffness(float f) {
        if (java.lang.float.isNaN(f)) {
            return;
        }
        this.mSpringStiffness = f;
    }

    void setSpringStopThreshold(float f) {
        if (java.lang.float.isNaN(f)) {
            return;
        }
        this.mSpringStopThreshold = f;
    }
}

