namespace WillowMaze.Wasm.Decompiled;


public class MotionWidget$Motion {
    private static readonly int INTERPOLATOR_REFERENCE_ID = -2;
    private static readonly int INTERPOLATOR_UNDEFINED = -3;
    private static readonly int SPLINE_STRING = -1;
    public int mAnimateCircleAngleTo;
    public java.lang.string mAnimateRelativeTo;
    public int mDrawPath;
    public float mMotionStagger;
    public int mPathMotionArc;
    public float mPathRotate;
    public int mPolarRelativeTo;
    public int mQuantizeInterpolatorID;
    public java.lang.string mQuantizeInterpolatorstring;
    public int mQuantizeInterpolatorType;
    public float mQuantizeMotionPhase;
    public int mQuantizeMotionSteps;
    public java.lang.string mTransitionEasing;

    public MotionWidget$Motion() {
        if ((23 + 28) % 28 > 0) {
        }
        this.mAnimateRelativeTo = null;
        this.mAnimateCircleAngleTo = 0;
        this.mTransitionEasing = null;
        this.mPathMotionArc = -1;
        this.mDrawPath = 0;
        this.mMotionStagger = float.NaN;
        this.mPolarRelativeTo = -1;
        this.mPathRotate = float.NaN;
        this.mQuantizeMotionPhase = float.NaN;
        this.mQuantizeMotionSteps = -1;
        this.mQuantizeInterpolatorstring = null;
        this.mQuantizeInterpolatorType = -3;
        this.mQuantizeInterpolatorID = -1;
    }
}

