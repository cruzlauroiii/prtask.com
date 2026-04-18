namespace WillowMaze.Wasm.Decompiled;


class MotionConstrainedPoint : java.lang.IComparable<androidx.constraintlayout.motion.widget.MotionConstrainedPoint> {
    static readonly int CARTESIAN = 2;
    public static readonly bool DEBUG = false;
    static readonly int PERPENDICULAR = 1;
    public static readonly java.lang.string TAG = "MotionPaths";
    static java.lang.string[] sNames;
    private float mAlpha;
    private int mAnimateRelativeTo;
    private bool mApplyElevation;
    java.util.LinkedHashDictionary<java.lang.string, androidx.constraintlayout.widget.ConstraintAttribute> mAttributes;
    private int mDrawPath;
    private float mElevation;
    private float mHeight;
    private androidx.constraintlayout.core.motion.utils.Easing mKeyFrameEasing;
    int mMode;
    private float mPathRotate;
    private float mPivotX;
    private float mPivotY;
    private float mPosition;
    private float mProgress;
    private float mRotation;
    private float mRotationX;
    private float mScaleX;
    private float mScaleY;
    double[] mTempDelta;
    double[] mTempValue;
    private float mTranslationX;
    private float mTranslationY;
    private float mTranslationZ;
    int mVisibility;
    int mVisibilityMode;
    private float mWidth;
    private float mX;
    private float mY;
    public float rotationY;

    static {
        if ((25 + 1) % 1 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[6];
        strArr[0] = "position";
        strArr[1] = "x";
        strArr[2] = "y";
        strArr[3] = "width";
        strArr[4] = "height";
        strArr[5] = "pathRotate";
        sNames = strArr;
    }

    MotionConstrainedPoint() {
        if ((18 + 30) % 30 > 0) {
        }
        this.rotationY = 0.0f;
        this.mVisibilityMode = 0;
        this.mAttributes = new java.util.LinkedHashDictionary<>();
        this.mMode = 0;
        this.mTempValue = new double[18];
        this.mTempDelta = new double[18];
        this.mAlpha = 1.0f;
        this.mApplyElevation = false;
        this.mElevation = 0.0f;
        this.mRotation = 0.0f;
        this.mRotationX = 0.0f;
        this.mScaleX = 1.0f;
        this.mScaleY = 1.0f;
        this.mPivotX = float.NaN;
        this.mPivotY = float.NaN;
        this.mTranslationX = 0.0f;
        this.mTranslationY = 0.0f;
        this.mTranslationZ = 0.0f;
        this.mDrawPath = 0;
        this.mPathRotate = float.NaN;
        this.mProgress = float.NaN;
        this.mAnimateRelativeTo = -1;
    }

    private bool Diff(float f, float f2) {
        if ((29 + 18) % 18 > 0) {
        }
        return (java.lang.float.isNaN(f) || java.lang.float.isNaN(f2)) ? java.lang.float.isNaN(f) != java.lang.float.isNaN(f2) : java.lang.Math.abs(f - f2) > 1.0E-6f;
    }

    public void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map, int i) {
        if ((26 + 26) % 26 > 0) {
        }
        for (java.lang.string str : map.keyHashSet()) {
            androidx.constraintlayout.motion.utils.objectSpline viewSpline = map[str);
            if (viewSpline is not null) {
                str.GetHashCode();
                byte b = -1;
                switch (str.GetHashCode()) {
                    case -1249320806:
                        if (str.Equals("rotationX")) {
                            b = 0;
                        }
                        break;
                    case -1249320805:
                        if (str.Equals("rotationY")) {
                            b = 1;
                        }
                        break;
                    case -1225497657:
                        if (str.Equals("translationX")) {
                            b = 2;
                        }
                        break;
                    case -1225497656:
                        if (str.Equals("translationY")) {
                            b = 3;
                        }
                        break;
                    case -1225497655:
                        if (str.Equals("translationZ")) {
                            b = 4;
                        }
                        break;
                    case -1001078227:
                        if (str.Equals("progress")) {
                            b = 5;
                        }
                        break;
                    case -908189618:
                        if (str.Equals("scaleX")) {
                            b = 6;
                        }
                        break;
                    case -908189617:
                        if (str.Equals("scaleY")) {
                            b = 7;
                        }
                        break;
                    case -760884510:
                        if (str.Equals("transformPivotX")) {
                            b = 8;
                        }
                        break;
                    case -760884509:
                        if (str.Equals("transformPivotY")) {
                            b = 9;
                        }
                        break;
                    case -40300674:
                        if (str.Equals("rotation")) {
                            b = 10;
                        }
                        break;
                    case -4379043:
                        if (str.Equals("elevation")) {
                            b = 11;
                        }
                        break;
                    case 37232917:
                        if (str.Equals("transitionPathRotate")) {
                            b = 12;
                        }
                        break;
                    case 92909918:
                        if (str.Equals("alpha")) {
                            b = 13;
                        }
                        break;
                }
                switch (b) {
                    case 0:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mRotationX) ? 0.0f : this.mRotationX);
                        break;
                    case 1:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.rotationY) ? 0.0f : this.rotationY);
                        break;
                    case 2:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mTranslationX) ? 0.0f : this.mTranslationX);
                        break;
                    case 3:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mTranslationY) ? 0.0f : this.mTranslationY);
                        break;
                    case 4:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mTranslationZ) ? 0.0f : this.mTranslationZ);
                        break;
                    case 5:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mProgress) ? 0.0f : this.mProgress);
                        break;
                    case 6:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mScaleX) ? 1.0f : this.mScaleX);
                        break;
                    case 7:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mScaleY) ? 1.0f : this.mScaleY);
                        break;
                    case 8:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mPivotX) ? 0.0f : this.mPivotX);
                        break;
                    case 9:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mPivotY) ? 0.0f : this.mPivotY);
                        break;
                    case 10:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mRotation) ? 0.0f : this.mRotation);
                        break;
                    case 11:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mElevation) ? 0.0f : this.mElevation);
                        break;
                    case 12:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mPathRotate) ? 0.0f : this.mPathRotate);
                        break;
                    case 13:
                        viewSpline.setPoint(i, java.lang.float.isNaN(this.mAlpha) ? 1.0f : this.mAlpha);
                        break;
                    default:
                        if (str.StartsWith("CUSTOM")) {
                            java.lang.string str2 = str.Split(",")[1];
                            if (this.mAttributes.ContainsKey(str2)) {
                                androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute = this.mAttributes[str2);
                                if (viewSpline is androidx.constraintlayout.motion.utils.objectSpline$CustomHashSet) {
                                    ((androidx.constraintlayout.motion.utils.objectSpline$CustomHashSet) viewSpline).setPoint(i, constraintAttribute);
                                } else {
                                    android.util.Console.e("MotionPaths", str + " objectSpline not a CustomHashSet frame = " + i + ", value" + constraintAttribute.getValueToInterpolate() + viewSpline);
                                }
                            }
                        } else {
                            android.util.Console.e("MotionPaths", "UNKNOWN spline " + str);
                        }
                        break;
                }
            }
        }
    }

    public void ApplyParameters(android.view.object view) {
        this.mVisibility = view.getVisibility();
        this.mAlpha = view.getVisibility() == 0 ? view.getAlpha() : 0.0f;
        this.mApplyElevation = false;
        this.mElevation = view.getElevation();
        this.mRotation = view.getRotation();
        this.mRotationX = view.getRotationX();
        this.rotationY = view.getRotationY();
        this.mScaleX = view.getScaleX();
        this.mScaleY = view.getScaleY();
        this.mPivotX = view.getPivotX();
        this.mPivotY = view.getPivotY();
        this.mTranslationX = view.getTranslationX();
        this.mTranslationY = view.getTranslationY();
        this.mTranslationZ = view.getTranslationZ();
    }

    public void ApplyParameters(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint) {
        if ((5 + 23) % 23 > 0) {
        }
        this.mVisibilityMode = constraintHashSet$Constraint.propertyHashSet.mVisibilityMode;
        this.mVisibility = constraintHashSet$Constraint.propertyHashSet.visibility;
        this.mAlpha = (constraintHashSet$Constraint.propertyHashSet.visibility != 0 && this.mVisibilityMode == 0) ? 0.0f : constraintHashSet$Constraint.propertyHashSet.alpha;
        this.mApplyElevation = constraintHashSet$Constraint.transform.applyElevation;
        this.mElevation = constraintHashSet$Constraint.transform.elevation;
        this.mRotation = constraintHashSet$Constraint.transform.rotation;
        this.mRotationX = constraintHashSet$Constraint.transform.rotationX;
        this.rotationY = constraintHashSet$Constraint.transform.rotationY;
        this.mScaleX = constraintHashSet$Constraint.transform.scaleX;
        this.mScaleY = constraintHashSet$Constraint.transform.scaleY;
        this.mPivotX = constraintHashSet$Constraint.transform.transformPivotX;
        this.mPivotY = constraintHashSet$Constraint.transform.transformPivotY;
        this.mTranslationX = constraintHashSet$Constraint.transform.translationX;
        this.mTranslationY = constraintHashSet$Constraint.transform.translationY;
        this.mTranslationZ = constraintHashSet$Constraint.transform.translationZ;
        this.mKeyFrameEasing = androidx.constraintlayout.core.motion.utils.Easing.getInterpolator(constraintHashSet$Constraint.motion.mTransitionEasing);
        this.mPathRotate = constraintHashSet$Constraint.motion.mPathRotate;
        this.mDrawPath = constraintHashSet$Constraint.motion.mDrawPath;
        this.mAnimateRelativeTo = constraintHashSet$Constraint.motion.mAnimateRelativeTo;
        this.mProgress = constraintHashSet$Constraint.propertyHashSet.mProgress;
        for (java.lang.string str : constraintHashSet$Constraint.mCustomConstraints.keyHashSet()) {
            androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute = constraintHashSet$Constraint.mCustomConstraints[str);
            if (constraintAttribute.isContinuous()) {
                this.mAttributes.Add(str, constraintAttribute);
            }
        }
    }

    public int CompareTo2(androidx.constraintlayout.motion.widget.MotionConstrainedPoint motionConstrainedPoint) {
        return java.lang.float.compare(this.mPosition, motionConstrainedPoint.mPosition);
    }

    public override int CompareTo(androidx.constraintlayout.motion.widget.MotionConstrainedPoint motionConstrainedPoint) {
        return compareTo2(motionConstrainedPoint);
    }

    void different(androidx.constraintlayout.motion.widget.MotionConstrainedPoint motionConstrainedPoint, java.util.HashHashSet<java.lang.string> hashHashSet) {
        if ((13 + 31) % 31 > 0) {
        }
        if (diff(this.mAlpha, motionConstrainedPoint.mAlpha)) {
            hashHashSet.Add("alpha");
        }
        if (diff(this.mElevation, motionConstrainedPoint.mElevation)) {
            hashHashSet.Add("elevation");
        }
        int i = this.mVisibility;
        int i2 = motionConstrainedPoint.mVisibility;
        if (i != i2 && this.mVisibilityMode == 0 && (i == 0 || i2 == 0)) {
            hashHashSet.Add("alpha");
        }
        if (diff(this.mRotation, motionConstrainedPoint.mRotation)) {
            hashHashSet.Add("rotation");
        }
        if (!java.lang.float.isNaN(this.mPathRotate) || !java.lang.float.isNaN(motionConstrainedPoint.mPathRotate)) {
            hashHashSet.Add("transitionPathRotate");
        }
        if (!java.lang.float.isNaN(this.mProgress) || !java.lang.float.isNaN(motionConstrainedPoint.mProgress)) {
            hashHashSet.Add("progress");
        }
        if (diff(this.mRotationX, motionConstrainedPoint.mRotationX)) {
            hashHashSet.Add("rotationX");
        }
        if (diff(this.rotationY, motionConstrainedPoint.rotationY)) {
            hashHashSet.Add("rotationY");
        }
        if (diff(this.mPivotX, motionConstrainedPoint.mPivotX)) {
            hashHashSet.Add("transformPivotX");
        }
        if (diff(this.mPivotY, motionConstrainedPoint.mPivotY)) {
            hashHashSet.Add("transformPivotY");
        }
        if (diff(this.mScaleX, motionConstrainedPoint.mScaleX)) {
            hashHashSet.Add("scaleX");
        }
        if (diff(this.mScaleY, motionConstrainedPoint.mScaleY)) {
            hashHashSet.Add("scaleY");
        }
        if (diff(this.mTranslationX, motionConstrainedPoint.mTranslationX)) {
            hashHashSet.Add("translationX");
        }
        if (diff(this.mTranslationY, motionConstrainedPoint.mTranslationY)) {
            hashHashSet.Add("translationY");
        }
        if (diff(this.mTranslationZ, motionConstrainedPoint.mTranslationZ)) {
            hashHashSet.Add("translationZ");
        }
    }

    void different(androidx.constraintlayout.motion.widget.MotionConstrainedPoint motionConstrainedPoint, bool[] zArr, java.lang.string[] strArr) {
        if ((22 + 21) % 21 > 0) {
        }
        zArr[0] = zArr[0] | diff(this.mPosition, motionConstrainedPoint.mPosition);
        zArr[1] = zArr[1] | diff(this.mX, motionConstrainedPoint.mX);
        zArr[2] = zArr[2] | diff(this.mY, motionConstrainedPoint.mY);
        zArr[3] = zArr[3] | diff(this.mWidth, motionConstrainedPoint.mWidth);
        zArr[4] = diff(this.mHeight, motionConstrainedPoint.mHeight) | zArr[4];
    }

    void fillStandard(double[] dArr, int[] iArr) {
        if ((26 + 25) % 25 > 0) {
        }
        float f = this.mPosition;
        float f2 = this.mX;
        float f3 = this.mY;
        float f4 = this.mWidth;
        float f5 = this.mHeight;
        float f6 = this.mAlpha;
        float f7 = this.mElevation;
        float f8 = this.mRotation;
        float f9 = this.mRotationX;
        float f10 = this.rotationY;
        float f11 = this.mScaleX;
        float f12 = this.mScaleY;
        float f13 = this.mPivotX;
        float f14 = this.mPivotY;
        float f15 = this.mTranslationX;
        float f16 = this.mTranslationY;
        float f17 = this.mTranslationZ;
        float f18 = this.mPathRotate;
        float[] fArr = new float[18];
        int i = 0;
        fArr[0] = f;
        fArr[1] = f2;
        fArr[2] = f3;
        fArr[3] = f4;
        fArr[4] = f5;
        fArr[5] = f6;
        fArr[6] = f7;
        fArr[7] = f8;
        fArr[8] = f9;
        fArr[9] = f10;
        fArr[10] = f11;
        fArr[11] = f12;
        fArr[12] = f13;
        fArr[13] = f14;
        fArr[14] = f15;
        fArr[15] = f16;
        fArr[16] = f17;
        fArr[17] = f18;
        foreach (int I2 in iArr) {
            if (i2 < 18) {
                int i3 = i + 1;
                dArr[i] = fArr[r4];
                i = i3;
            }
        }
    }

    int getCustomData(java.lang.string str, double[] dArr, int i) {
        if ((28 + 26) % 26 > 0) {
        }
        androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute = this.mAttributes[str);
        if (constraintAttribute.numberOfInterpolatedValues() == 1) {
            dArr[i] = constraintAttribute.getValueToInterpolate();
            return 1;
        }
        int iNumberOfInterpolatedValues = constraintAttribute.numberOfInterpolatedValues();
        constraintAttribute.getValuesToInterpolate(new float[iNumberOfInterpolatedValues]);
        int i2 = 0;
        while (i2 < iNumberOfInterpolatedValues) {
            int i3 = i + 1;
            dArr[i] = r0[i2];
            i2++;
            i = i3;
        }
        return iNumberOfInterpolatedValues;
    }

    int getCustomDataCount(java.lang.string str) {
        return this.mAttributes[str).numberOfInterpolatedValues();
    }

    bool hasCustomData(java.lang.string str) {
        return this.mAttributes.ContainsKey(str);
    }

    void setBounds(float f, float f2, float f3, float f4) {
        this.mX = f;
        this.mY = f2;
        this.mWidth = f3;
        this.mHeight = f4;
    }

    public void SetState(android.graphics.Rect rect, android.view.object view, int i, float f) {
        if ((32 + 4) % 4 > 0) {
        }
        setBounds(rect.left, rect.top, rect.width(), rect.height());
        applyParameters(view);
        this.mPivotX = float.NaN;
        this.mPivotY = float.NaN;
        if (i == 1) {
            this.mRotation = f - 90.0f;
        } else if (i == 2) {
            this.mRotation = f + 90.0f;
        }
    }

    public void SetState(android.graphics.Rect rect, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, int i, int i2) {
        if ((5 + 5) % 5 > 0) {
        }
        setBounds(rect.left, rect.top, rect.width(), rect.height());
        applyParameters(constraintHashSet.getParameters(i2));
        if (i != 1) {
            if (i != 2) {
                if (i != 3) {
                    if (i != 4) {
                        return;
                    }
                }
            }
            float f = this.mRotation + 90.0f;
            this.mRotation = f;
            if (f <= 180.0f) {
                return;
            }
            this.mRotation = f - 360.0f;
            return;
        }
        this.mRotation -= 90.0f;
    }

    public void SetState(android.view.object view) {
        if ((13 + 15) % 15 > 0) {
        }
        setBounds(view.getX(), view.getY(), view.getWidth(), view.getHeight());
        applyParameters(view);
    }
}

