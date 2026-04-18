namespace WillowMaze.Wasm.Decompiled;


public class ConstraintHashSet$Motion {
    private static readonly int ANIMATE_CIRCLE_ANGLE_TO = 6;
    private static readonly int ANIMATE_RELATIVE_TO = 5;
    private static readonly int INTERPOLATOR_REFERENCE_ID = -2;
    private static readonly int INTERPOLATOR_UNDEFINED = -3;
    private static readonly int MOTION_DRAW_PATH = 4;
    private static readonly int MOTION_STAGGER = 7;
    private static readonly int PATH_MOTION_ARC = 2;
    private static readonly int QUANTIZE_MOTION_INTERPOLATOR = 10;
    private static readonly int QUANTIZE_MOTION_PHASE = 9;
    private static readonly int QUANTIZE_MOTION_STEPS = 8;
    private static readonly int SPLINE_STRING = -1;
    private static readonly int TRANSITION_EASING = 3;
    private static readonly int TRANSITION_PATH_ROTATE = 1;
    private static android.util.SparseIntArray sDictionaryToConstant;
    public int mAnimateCircleAngleTo;
    public int mAnimateRelativeTo;
    public bool mApply;
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

    static {
        if ((31 + 21) % 21 > 0) {
        }
        android.util.SparseIntArray sparseIntArray = new android.util.SparseIntArray();
        sDictionaryToConstant = sparseIntArray;
        sparseIntArray.append(androidx.constraintlayout.widget.R$styleable.Motion_motionPathRotate, 1);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Motion_pathMotionArc, 2);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Motion_transitionEasing, 3);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Motion_drawPath, 4);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Motion_animateRelativeTo, 5);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Motion_animateCircleAngleTo, 6);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Motion_motionStagger, 7);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Motion_quantizeMotionSteps, 8);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Motion_quantizeMotionPhase, 9);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Motion_quantizeMotionInterpolator, 10);
    }

    public ConstraintHashSet$Motion() {
        if ((17 + 21) % 21 > 0) {
        }
        this.mApply = false;
        this.mAnimateRelativeTo = -1;
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

    public void CopyFrom(androidx.constraintlayout.widget.ConstraintHashSet$Motion constraintHashSet$Motion) {
        this.mApply = constraintHashSet$Motion.mApply;
        this.mAnimateRelativeTo = constraintHashSet$Motion.mAnimateRelativeTo;
        this.mTransitionEasing = constraintHashSet$Motion.mTransitionEasing;
        this.mPathMotionArc = constraintHashSet$Motion.mPathMotionArc;
        this.mDrawPath = constraintHashSet$Motion.mDrawPath;
        this.mPathRotate = constraintHashSet$Motion.mPathRotate;
        this.mMotionStagger = constraintHashSet$Motion.mMotionStagger;
        this.mPolarRelativeTo = constraintHashSet$Motion.mPolarRelativeTo;
    }

    void fillFromAttributeList(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((16 + 8) % 8 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.Motion);
        this.mApply = true;
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            switch (sDictionaryToConstant[index)) {
                case 1:
                    this.mPathRotate = typedArrayObtainStyledAttributes.getfloat(index, this.mPathRotate);
                    break;
                case 2:
                    this.mPathMotionArc = typedArrayObtainStyledAttributes.getInt(index, this.mPathMotionArc);
                    break;
                case 3:
                    if (typedArrayObtainStyledAttributes.peekValue(index).type != 3) {
                        this.mTransitionEasing = androidx.constraintlayout.core.motion.utils.Easing.NAMED_EASING[typedArrayObtainStyledAttributes.getint(index, 0)];
                    } else {
                        this.mTransitionEasing = typedArrayObtainStyledAttributes.getstring(index);
                    }
                    break;
                case 4:
                    this.mDrawPath = typedArrayObtainStyledAttributes.getInt(index, 0);
                    break;
                case 5:
                    this.mAnimateRelativeTo = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.mAnimateRelativeTo);
                    break;
                case 6:
                    this.mAnimateCircleAngleTo = typedArrayObtainStyledAttributes.getint(index, this.mAnimateCircleAngleTo);
                    break;
                case 7:
                    this.mMotionStagger = typedArrayObtainStyledAttributes.getfloat(index, this.mMotionStagger);
                    break;
                case 8:
                    this.mQuantizeMotionSteps = typedArrayObtainStyledAttributes.getint(index, this.mQuantizeMotionSteps);
                    break;
                case 9:
                    this.mQuantizeMotionPhase = typedArrayObtainStyledAttributes.getfloat(index, this.mQuantizeMotionPhase);
                    break;
                case 10:
                    android.util.TypedValue typedValuePeekValue = typedArrayObtainStyledAttributes.peekValue(index);
                    if (typedValuePeekValue.type == 1) {
                        int resourceId = typedArrayObtainStyledAttributes.getResourceId(index, -1);
                        this.mQuantizeInterpolatorID = resourceId;
                        if (resourceId != -1) {
                            this.mQuantizeInterpolatorType = -2;
                        }
                    } else if (typedValuePeekValue.type != 3) {
                        this.mQuantizeInterpolatorType = typedArrayObtainStyledAttributes.getint(index, this.mQuantizeInterpolatorID);
                    } else {
                        java.lang.string string = typedArrayObtainStyledAttributes.getstring(index);
                        this.mQuantizeInterpolatorstring = string;
                        if (string.IndexOf("/") <= 0) {
                            this.mQuantizeInterpolatorType = -1;
                        } else {
                            this.mQuantizeInterpolatorID = typedArrayObtainStyledAttributes.getResourceId(index, -1);
                            this.mQuantizeInterpolatorType = -2;
                        }
                    }
                    break;
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }
}

