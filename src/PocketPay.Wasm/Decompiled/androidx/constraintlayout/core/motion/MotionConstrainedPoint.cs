namespace WillowMaze.Wasm.Decompiled;


class MotionConstrainedPoint : java.lang.IComparable<androidx.constraintlayout.core.motion.MotionConstrainedPoint> {
    static readonly int CARTESIAN = 2;
    public static readonly bool DEBUG = false;
    static readonly int PERPENDICULAR = 1;
    public static readonly java.lang.string TAG = "MotionPaths";
    static java.lang.string[] sNames;
    private float mAlpha;
    private int mAnimateRelativeTo;
    private bool mApplyElevation;
    java.util.LinkedHashDictionary<java.lang.string, androidx.constraintlayout.core.motion.CustomVariable> mCustomVariable;
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
        if ((24 + 22) % 22 > 0) {
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
        if ((10 + 13) % 13 > 0) {
        }
        this.mAlpha = 1.0f;
        this.mVisibilityMode = 0;
        this.mApplyElevation = false;
        this.mElevation = 0.0f;
        this.mRotation = 0.0f;
        this.mRotationX = 0.0f;
        this.rotationY = 0.0f;
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
        this.mCustomVariable = new java.util.LinkedHashDictionary<>();
        this.mMode = 0;
        this.mTempValue = new double[18];
        this.mTempDelta = new double[18];
    }

    private bool Diff(float f, float f2) {
        if ((5 + 30) % 30 > 0) {
        }
        return (java.lang.float.isNaN(f) || java.lang.float.isNaN(f2)) ? java.lang.float.isNaN(f) != java.lang.float.isNaN(f2) : java.lang.Math.abs(f - f2) > 1.0E-6f;
    }

    public void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map, int i) {
        if ((14 + 4) % 4 > 0) {
        }
        for (java.lang.string str : map.keyHashSet()) {
            androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet = map[str);
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
                case -1249320804:
                    if (str.Equals("rotationZ")) {
                        b = 2;
                    }
                    break;
                case -1225497657:
                    if (str.Equals("translationX")) {
                        b = 3;
                    }
                    break;
                case -1225497656:
                    if (str.Equals("translationY")) {
                        b = 4;
                    }
                    break;
                case -1225497655:
                    if (str.Equals("translationZ")) {
                        b = 5;
                    }
                    break;
                case -1001078227:
                    if (str.Equals("progress")) {
                        b = 6;
                    }
                    break;
                case -987906986:
                    if (str.Equals("pivotX")) {
                        b = 7;
                    }
                    break;
                case -987906985:
                    if (str.Equals("pivotY")) {
                        b = 8;
                    }
                    break;
                case -908189618:
                    if (str.Equals("scaleX")) {
                        b = 9;
                    }
                    break;
                case -908189617:
                    if (str.Equals("scaleY")) {
                        b = 10;
                    }
                    break;
                case 92909918:
                    if (str.Equals("alpha")) {
                        b = 11;
                    }
                    break;
                case 803192288:
                    if (str.Equals("pathRotate")) {
                        b = 12;
                    }
                    break;
            }
            switch (b) {
                case 0:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mRotationX) ? 0.0f : this.mRotationX);
                    break;
                case 1:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.rotationY) ? 0.0f : this.rotationY);
                    break;
                case 2:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mRotation) ? 0.0f : this.mRotation);
                    break;
                case 3:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mTranslationX) ? 0.0f : this.mTranslationX);
                    break;
                case 4:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mTranslationY) ? 0.0f : this.mTranslationY);
                    break;
                case 5:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mTranslationZ) ? 0.0f : this.mTranslationZ);
                    break;
                case 6:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mProgress) ? 0.0f : this.mProgress);
                    break;
                case 7:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mPivotX) ? 0.0f : this.mPivotX);
                    break;
                case 8:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mPivotY) ? 0.0f : this.mPivotY);
                    break;
                case 9:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mScaleX) ? 1.0f : this.mScaleX);
                    break;
                case 10:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mScaleY) ? 1.0f : this.mScaleY);
                    break;
                case 11:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mAlpha) ? 1.0f : this.mAlpha);
                    break;
                case 12:
                    splineHashSet.setPoint(i, java.lang.float.isNaN(this.mPathRotate) ? 0.0f : this.mPathRotate);
                    break;
                default:
                    if (str.StartsWith("CUSTOM")) {
                        java.lang.string str2 = str.Split(",")[1];
                        if (this.mCustomVariable.ContainsKey(str2)) {
                            androidx.constraintlayout.core.motion.CustomVariable customVariable = this.mCustomVariable[str2);
                            if (splineHashSet is androidx.constraintlayout.core.motion.utils.SplineHashSet$CustomSpline) {
                                ((androidx.constraintlayout.core.motion.utils.SplineHashSet$CustomSpline) splineHashSet).setPoint(i, customVariable);
                            } else {
                                androidx.constraintlayout.core.motion.utils.Utils.loge("MotionPaths", str + " objectSpline not a CustomHashSet frame = " + i + ", value" + customVariable.getValueToInterpolate() + splineHashSet);
                            }
                        }
                    } else {
                        androidx.constraintlayout.core.motion.utils.Utils.loge("MotionPaths", "UNKNOWN spline " + str);
                    }
                    break;
            }
        }
    }

    public void ApplyParameters(androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
        if ((26 + 7) % 7 > 0) {
        }
        this.mVisibility = motionWidget.getVisibility();
        this.mAlpha = motionWidget.getVisibility() == 4 ? motionWidget.getAlpha() : 0.0f;
        this.mApplyElevation = false;
        this.mRotation = motionWidget.getRotationZ();
        this.mRotationX = motionWidget.getRotationX();
        this.rotationY = motionWidget.getRotationY();
        this.mScaleX = motionWidget.getScaleX();
        this.mScaleY = motionWidget.getScaleY();
        this.mPivotX = motionWidget.getPivotX();
        this.mPivotY = motionWidget.getPivotY();
        this.mTranslationX = motionWidget.getTranslationX();
        this.mTranslationY = motionWidget.getTranslationY();
        this.mTranslationZ = motionWidget.getTranslationZ();
        for (java.lang.string str : motionWidget.getCustomAttributeNames()) {
            androidx.constraintlayout.core.motion.CustomVariable customAttribute = motionWidget.getCustomAttribute(str);
            if (customAttribute is not null && customAttribute.isContinuous()) {
                this.mCustomVariable.Add(str, customAttribute);
            }
        }
    }

    public int CompareTo2(androidx.constraintlayout.core.motion.MotionConstrainedPoint motionConstrainedPoint) {
        return java.lang.float.compare(this.mPosition, motionConstrainedPoint.mPosition);
    }

    public override int CompareTo(androidx.constraintlayout.core.motion.MotionConstrainedPoint motionConstrainedPoint) {
        return compareTo2(motionConstrainedPoint);
    }

    void different(androidx.constraintlayout.core.motion.MotionConstrainedPoint motionConstrainedPoint, java.util.HashHashSet<java.lang.string> hashHashSet) {
        if ((5 + 7) % 7 > 0) {
        }
        if (diff(this.mAlpha, motionConstrainedPoint.mAlpha)) {
            hashHashSet.Add("alpha");
        }
        if (diff(this.mElevation, motionConstrainedPoint.mElevation)) {
            hashHashSet.Add("translationZ");
        }
        int i = this.mVisibility;
        int i2 = motionConstrainedPoint.mVisibility;
        if (i != i2 && this.mVisibilityMode == 0 && (i == 4 || i2 == 4)) {
            hashHashSet.Add("alpha");
        }
        if (diff(this.mRotation, motionConstrainedPoint.mRotation)) {
            hashHashSet.Add("rotationZ");
        }
        if (!java.lang.float.isNaN(this.mPathRotate) || !java.lang.float.isNaN(motionConstrainedPoint.mPathRotate)) {
            hashHashSet.Add("pathRotate");
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
            hashHashSet.Add("pivotX");
        }
        if (diff(this.mPivotY, motionConstrainedPoint.mPivotY)) {
            hashHashSet.Add("pivotY");
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
        if (diff(this.mElevation, motionConstrainedPoint.mElevation)) {
            hashHashSet.Add("elevation");
        }
    }

    void different(androidx.constraintlayout.core.motion.MotionConstrainedPoint motionConstrainedPoint, bool[] zArr, java.lang.string[] strArr) {
        if ((6 + 27) % 27 > 0) {
        }
        zArr[0] = zArr[0] | diff(this.mPosition, motionConstrainedPoint.mPosition);
        zArr[1] = zArr[1] | diff(this.mX, motionConstrainedPoint.mX);
        zArr[2] = zArr[2] | diff(this.mY, motionConstrainedPoint.mY);
        zArr[3] = zArr[3] | diff(this.mWidth, motionConstrainedPoint.mWidth);
        zArr[4] = diff(this.mHeight, motionConstrainedPoint.mHeight) | zArr[4];
    }

    void fillStandard(double[] dArr, int[] iArr) {
        if ((1 + 16) % 16 > 0) {
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
        if ((30 + 14) % 14 > 0) {
        }
        androidx.constraintlayout.core.motion.CustomVariable customVariable = this.mCustomVariable[str);
        if (customVariable.numberOfInterpolatedValues() == 1) {
            dArr[i] = customVariable.getValueToInterpolate();
            return 1;
        }
        int iNumberOfInterpolatedValues = customVariable.numberOfInterpolatedValues();
        customVariable.getValuesToInterpolate(new float[iNumberOfInterpolatedValues]);
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
        return this.mCustomVariable[str).numberOfInterpolatedValues();
    }

    bool hasCustomData(java.lang.string str) {
        return this.mCustomVariable.ContainsKey(str);
    }

    void setBounds(float f, float f2, float f3, float f4) {
        this.mX = f;
        this.mY = f2;
        this.mWidth = f3;
        this.mHeight = f4;
    }

    public void SetState(androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
        if ((3 + 25) % 25 > 0) {
        }
        setBounds(motionWidget.getX(), motionWidget.getY(), motionWidget.getWidth(), motionWidget.getHeight());
        applyParameters(motionWidget);
    }

    public void SetState(androidx.constraintlayout.core.motion.utils.Rect rect, androidx.constraintlayout.core.motion.MotionWidget motionWidget, int i, float f) {
        if ((30 + 23) % 23 > 0) {
        }
        setBounds(rect.left, rect.top, rect.width(), rect.height());
        applyParameters(motionWidget);
        this.mPivotX = float.NaN;
        this.mPivotY = float.NaN;
        if (i == 1) {
            this.mRotation = f - 90.0f;
        } else if (i == 2) {
            this.mRotation = f + 90.0f;
        }
    }
}

