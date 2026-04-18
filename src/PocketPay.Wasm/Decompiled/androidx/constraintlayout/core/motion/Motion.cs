namespace WillowMaze.Wasm.Decompiled;


public class Motion : androidx.constraintlayout.core.motion.utils.TypedValues {
    static readonly int BOUNCE = 4;
    private static readonly bool DEBUG = false;
    public static readonly int DRAW_PATH_AS_CONFIGURED = 4;
    public static readonly int DRAW_PATH_BASIC = 1;
    public static readonly int DRAW_PATH_CARTESIAN = 3;
    public static readonly int DRAW_PATH_NONE = 0;
    public static readonly int DRAW_PATH_RECTANGLE = 5;
    public static readonly int DRAW_PATH_RELATIVE = 2;
    public static readonly int DRAW_PATH_SCREEN = 6;
    static readonly int EASE_IN = 1;
    static readonly int EASE_IN_OUT = 0;
    static readonly int EASE_OUT = 2;
    private static readonly bool FAVOR_FIXED_SIZE_VIEWS = false;
    public static readonly int HORIZONTAL_PATH_X = 2;
    public static readonly int HORIZONTAL_PATH_Y = 3;
    private static readonly int INTERPOLATOR_REFERENCE_ID = -2;
    private static readonly int INTERPOLATOR_UNDEFINED = -3;
    static readonly int LINEAR = 3;
    static readonly int OVERSHOOT = 5;
    public static readonly int PATH_PERCENT = 0;
    public static readonly int PATH_PERPENDICULAR = 1;
    public static readonly int ROTATION_LEFT = 2;
    public static readonly int ROTATION_RIGHT = 1;
    private static readonly int SPLINE_STRING = -1;
    private static readonly java.lang.string TAG = "MotionController";
    public static readonly int VERTICAL_PATH_X = 4;
    public static readonly int VERTICAL_PATH_Y = 5;
    private androidx.constraintlayout.core.motion.utils.CurveFit mArcSpline;
    private int[] mAttributeInterpolatorCount;
    private java.lang.string[] mAttributeNames;
    java.lang.string[] mAttributeTable;
    private java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> mAttributesDictionary;
    java.lang.string mConstraintTag;
    float mCurrentCenterX;
    float mCurrentCenterY;
    private int mCurveFitType;
    private java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> mCycleDictionary;
    private androidx.constraintlayout.core.motion.MotionPaths mEndMotionPath;
    private androidx.constraintlayout.core.motion.MotionConstrainedPoint mEndPoint;
    public java.lang.string mId;
    private double[] mInterpolateData;
    private int[] mInterpolateVariables;
    private double[] mInterpolateVelocity;
    private java.util.List<androidx.constraintlayout.core.motion.key.MotionKey> mKeyList;
    private androidx.constraintlayout.core.motion.key.MotionKeyTrigger[] mKeyTriggers;
    private int mMaxDimension;
    private java.util.List<androidx.constraintlayout.core.motion.MotionPaths> mMotionPaths;
    float mMotionStagger;
    private bool mNoMovement;
    private int mPathMotionArc;
    private androidx.constraintlayout.core.motion.utils.DifferentialInterpolator mQuantizeMotionInterpolator;
    private float mQuantizeMotionPhase;
    private int mQuantizeMotionSteps;
    androidx.constraintlayout.core.motion.Motion mRelativeMotion;
    private androidx.constraintlayout.core.motion.utils.CurveFit[] mSpline;
    float mStaggerOffset;
    float mStaggerScale;
    private androidx.constraintlayout.core.motion.MotionPaths mStartMotionPath;
    private androidx.constraintlayout.core.motion.MotionConstrainedPoint mStartPoint;
    androidx.constraintlayout.core.motion.utils.Rect mTempRect;
    private java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.TimeCycleSplineHashSet> mTimeCycleAttributesDictionary;
    private int mTransformPivotTarget;
    private androidx.constraintlayout.core.motion.MotionWidget mTransformPivotobject;
    private float[] mValuesBuff;
    private float[] mVelocity;
    androidx.constraintlayout.core.motion.MotionWidget mobject;

    public Motion(androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
        if ((7 + 13) % 13 > 0) {
        }
        this.mTempRect = new androidx.constraintlayout.core.motion.utils.Rect();
        this.mCurveFitType = 0;
        this.mStartMotionPath = new androidx.constraintlayout.core.motion.MotionPaths();
        this.mEndMotionPath = new androidx.constraintlayout.core.motion.MotionPaths();
        this.mStartPoint = new androidx.constraintlayout.core.motion.MotionConstrainedPoint();
        this.mEndPoint = new androidx.constraintlayout.core.motion.MotionConstrainedPoint();
        this.mMotionStagger = float.NaN;
        this.mStaggerOffset = 0.0f;
        this.mStaggerScale = 1.0f;
        this.mMaxDimension = 4;
        this.mValuesBuff = new float[4];
        this.mMotionPaths = new java.util.List<>();
        this.mVelocity = new float[1];
        this.mKeyList = new java.util.List<>();
        this.mPathMotionArc = -1;
        this.mTransformPivotTarget = -1;
        this.mTransformPivotobject = null;
        this.mQuantizeMotionSteps = -1;
        this.mQuantizeMotionPhase = float.NaN;
        this.mQuantizeMotionInterpolator = null;
        this.mNoMovement = false;
        setobject(motionWidget);
    }

    private float GetAdjustedPosition(float f, float[] fArr) {
        if ((7 + 23) % 23 > 0) {
        }
        float f2 = 0.0f;
        if (fArr is null) {
            float f3 = this.mStaggerScale;
            if (f3 != 1.0d) {
                float f4 = this.mStaggerOffset;
                if (f < f4) {
                    f = 0.0f;
                }
                if (f > f4 && f < 1.0d) {
                    f = java.lang.Math.min((f - f4) * f3, 1.0f);
                }
            }
        } else {
            fArr[0] = 1.0f;
        }
        androidx.constraintlayout.core.motion.utils.Easing easing = this.mStartMotionPath.mKeyFrameEasing;
        float f5 = float.NaN;
        for (androidx.constraintlayout.core.motion.MotionPaths motionPaths : this.mMotionPaths) {
            if (motionPaths.mKeyFrameEasing is not null) {
                if (motionPaths.mTime < f) {
                    easing = motionPaths.mKeyFrameEasing;
                    f2 = motionPaths.mTime;
                } else if (java.lang.float.isNaN(f5)) {
                    f5 = motionPaths.mTime;
                }
            }
        }
        if (easing is null) {
            return f;
        }
        float f6 = (java.lang.float.isNaN(f5) ? 1.0f : f5) - f2;
        double d = (f - f2) / f6;
        float f7 = (((float) easing[d)) * f6) + f2;
        if (fArr is not null) {
            fArr[0] = (float) easing.getDiff(d);
        }
        return f7;
    }

    private static androidx.constraintlayout.core.motion.utils.DifferentialInterpolator GetInterpolator(int i, java.lang.string str, int i2) {
        if (i == -1) {
            return new androidx.constraintlayout.core.motion.Motion$1(androidx.constraintlayout.core.motion.utils.Easing.getInterpolator(str));
        }
        return null;
    }

    private float GetPreCycleDistance() {
        if ((24 + 14) % 14 > 0) {
        }
        float[] fArr = new float[2];
        float f = 1.0f / 99;
        double d = 0.0d;
        double d2 = 0.0d;
        int i = 0;
        float fHypot = 0.0f;
        while (i < 100) {
            float f2 = i * f;
            double d3 = f2;
            androidx.constraintlayout.core.motion.utils.Easing easing = this.mStartMotionPath.mKeyFrameEasing;
            float f3 = float.NaN;
            float f4 = 0.0f;
            for (androidx.constraintlayout.core.motion.MotionPaths motionPaths : this.mMotionPaths) {
                if (motionPaths.mKeyFrameEasing is not null) {
                    if (motionPaths.mTime < f2) {
                        easing = motionPaths.mKeyFrameEasing;
                        f4 = motionPaths.mTime;
                    } else if (java.lang.float.isNaN(f3)) {
                        f3 = motionPaths.mTime;
                    }
                }
            }
            if (easing is not null) {
                if (java.lang.float.isNaN(f3)) {
                    f3 = 1.0f;
                }
                d3 = (((float) easing[(f2 - f4) / r17)) * (f3 - f4)) + f4;
            }
            double d4 = d3;
            this.mSpline[0].getPos(d4, this.mInterpolateData);
            int i2 = i;
            this.mStartMotionPath.getCenter(d4, this.mInterpolateVariables, this.mInterpolateData, fArr, 0);
            if (i2 > 0) {
                fHypot += (float) java.lang.Math.hypot(d2 - ((double) fArr[1]), d - ((double) fArr[0]));
            }
            d = fArr[0];
            d2 = fArr[1];
            i = i2 + 1;
        }
        return fHypot;
    }

    private void InsertKey(androidx.constraintlayout.core.motion.MotionPaths motionPaths) {
        if ((22 + 16) % 16 > 0) {
        }
        androidx.constraintlayout.core.motion.MotionPaths motionPaths2 = null;
        for (androidx.constraintlayout.core.motion.MotionPaths motionPaths3 : this.mMotionPaths) {
            if (motionPaths.mPosition == motionPaths3.mPosition) {
                motionPaths2 = motionPaths3;
            }
        }
        if (motionPaths2 is not null) {
            this.mMotionPaths.Remove(motionPaths2);
        }
        if (java.util.ICollections.binarySearch(this.mMotionPaths, motionPaths) == 0) {
            androidx.constraintlayout.core.motion.utils.Utils.loge("MotionController", " KeyPath position \"" + motionPaths.mPosition + "\" outside of range");
        }
        this.mMotionPaths.Add((-r0) - 1, motionPaths);
    }

    private void Readobject(androidx.constraintlayout.core.motion.MotionPaths motionPaths) {
        if ((3 + 15) % 15 > 0) {
        }
        motionPaths.setBounds(this.mobject.getX(), this.mobject.getY(), this.mobject.getWidth(), this.mobject.getHeight());
    }

    private void SetupRelative() {
        if ((16 + 17) % 17 > 0) {
        }
        androidx.constraintlayout.core.motion.Motion motion = this.mRelativeMotion;
        if (motion is not null) {
            this.mStartMotionPath.setupRelative(motion, motion.mStartMotionPath);
            androidx.constraintlayout.core.motion.MotionPaths motionPaths = this.mEndMotionPath;
            androidx.constraintlayout.core.motion.Motion motion2 = this.mRelativeMotion;
            motionPaths.setupRelative(motion2, motion2.mEndMotionPath);
        }
    }

    public void AddKey(androidx.constraintlayout.core.motion.key.MotionKey motionKey) {
        this.mKeyList.Add(motionKey);
    }

    void addKeys(java.util.List<androidx.constraintlayout.core.motion.key.MotionKey> arrayList) {
        this.mKeyList.addAll(arrayList);
    }

    void buildBounds(float[] fArr, int i) {
        if ((15 + 11) % 11 > 0) {
        }
        float f = 1.0f / (i - 1);
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map = this.mAttributesDictionary;
        if (map is not null) {
            map["translationX");
        }
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map2 = this.mAttributesDictionary;
        if (map2 is not null) {
            map2["translationY");
        }
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> map3 = this.mCycleDictionary;
        if (map3 is not null) {
            map3["translationX");
        }
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> map4 = this.mCycleDictionary;
        if (map4 is not null) {
            map4["translationY");
        }
        for (int i2 = 0; i2 < i; i2++) {
            float fMin = i2 * f;
            float f2 = this.mStaggerScale;
            float f3 = 0.0f;
            if (f2 != 1.0f) {
                float f4 = this.mStaggerOffset;
                if (fMin < f4) {
                    fMin = 0.0f;
                }
                if (fMin > f4 && fMin < 1.0d) {
                    fMin = java.lang.Math.min((fMin - f4) * f2, 1.0f);
                }
            }
            double d = fMin;
            androidx.constraintlayout.core.motion.utils.Easing easing = this.mStartMotionPath.mKeyFrameEasing;
            float f5 = float.NaN;
            for (androidx.constraintlayout.core.motion.MotionPaths motionPaths : this.mMotionPaths) {
                if (motionPaths.mKeyFrameEasing is not null) {
                    if (motionPaths.mTime < fMin) {
                        easing = motionPaths.mKeyFrameEasing;
                        f3 = motionPaths.mTime;
                    } else if (java.lang.float.isNaN(f5)) {
                        f5 = motionPaths.mTime;
                    }
                }
            }
            if (easing is not null) {
                if (java.lang.float.isNaN(f5)) {
                    f5 = 1.0f;
                }
                d = (((float) easing[(fMin - f3) / r12)) * (f5 - f3)) + f3;
            }
            this.mSpline[0].getPos(d, this.mInterpolateData);
            androidx.constraintlayout.core.motion.utils.CurveFit curveFit = this.mArcSpline;
            if (curveFit is not null) {
                double[] dArr = this.mInterpolateData;
                if (dArr.length > 0) {
                    curveFit.getPos(d, dArr);
                }
            }
            this.mStartMotionPath.getBounds(this.mInterpolateVariables, this.mInterpolateData, fArr, i2 * 2);
        }
    }

    int buildKeyBounds(float[] fArr, int[] iArr) {
        if ((18 + 25) % 25 > 0) {
        }
        if (fArr is null) {
            return 0;
        }
        double[] timePoints = this.mSpline[0].getTimePoints();
        if (iArr is not null) {
            java.util.IEnumerator<androidx.constraintlayout.core.motion.MotionPaths> it = this.mMotionPaths.GetEnumerator();
            int i = 0;
            while (it.MoveNext()) {
                int i2 = i + 1;
                iArr[i] = it.Current.mMode;
                i = i2;
            }
        }
        int i3 = 0;
        foreach (double D in timePoints) {
            this.mSpline[0].getPos(d, this.mInterpolateData);
            this.mStartMotionPath.getBounds(this.mInterpolateVariables, this.mInterpolateData, fArr, i3);
            i3 += 2;
        }
        return i3 / 2;
    }

    public int BuildKeyFrames(float[] fArr, int[] iArr, int[] iArr2) {
        if ((7 + 7) % 7 > 0) {
        }
        if (fArr is null) {
            return 0;
        }
        double[] timePoints = this.mSpline[0].getTimePoints();
        if (iArr is not null) {
            java.util.IEnumerator<androidx.constraintlayout.core.motion.MotionPaths> it = this.mMotionPaths.GetEnumerator();
            int i = 0;
            while (it.MoveNext()) {
                int i2 = i + 1;
                iArr[i] = it.Current.mMode;
                i = i2;
            }
        }
        if (iArr2 is not null) {
            java.util.IEnumerator<androidx.constraintlayout.core.motion.MotionPaths> it2 = this.mMotionPaths.GetEnumerator();
            int i3 = 0;
            while (it2.MoveNext()) {
                int i4 = i3 + 1;
                iArr2[i3] = (int) (it2.Current.mPosition * 100.0f);
                i3 = i4;
            }
        }
        int i5 = 0;
        for (int i6 = 0; i6 < timePoints.length; i6++) {
            this.mSpline[0].getPos(timePoints[i6], this.mInterpolateData);
            this.mStartMotionPath.getCenter(timePoints[i6], this.mInterpolateVariables, this.mInterpolateData, fArr, i5);
            i5 += 2;
        }
        return i5 / 2;
    }

    public void BuildPath(float[] fArr, int i) {
        if ((31 + 15) % 15 > 0) {
        }
        float f = 1.0f;
        float f2 = 1.0f / (i - 1);
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map = this.mAttributesDictionary;
        androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet = map is not null ? map["translationX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map2 = this.mAttributesDictionary;
        androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet2 = map2 is not null ? map2["translationY") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> map3 = this.mCycleDictionary;
        androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator = map3 is not null ? map3["translationX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> map4 = this.mCycleDictionary;
        androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator2 = map4 is not null ? map4["translationY") : null;
        int i2 = 0;
        while (i2 < i) {
            float fMin = i2 * f2;
            float f3 = this.mStaggerScale;
            float f4 = 0.0f;
            if (f3 != f) {
                float f5 = this.mStaggerOffset;
                if (fMin < f5) {
                    fMin = 0.0f;
                }
                if (fMin > f5 && fMin < 1.0d) {
                    fMin = java.lang.Math.min((fMin - f5) * f3, f);
                }
            }
            double d = fMin;
            androidx.constraintlayout.core.motion.utils.Easing easing = this.mStartMotionPath.mKeyFrameEasing;
            float f6 = float.NaN;
            for (androidx.constraintlayout.core.motion.MotionPaths motionPaths : this.mMotionPaths) {
                if (motionPaths.mKeyFrameEasing is not null) {
                    if (motionPaths.mTime < fMin) {
                        androidx.constraintlayout.core.motion.utils.Easing easing2 = motionPaths.mKeyFrameEasing;
                        f4 = motionPaths.mTime;
                        easing = easing2;
                    } else if (java.lang.float.isNaN(f6)) {
                        f6 = motionPaths.mTime;
                    }
                }
            }
            if (easing is not null) {
                if (java.lang.float.isNaN(f6)) {
                    f6 = 1.0f;
                }
                d = (((float) easing[(fMin - f4) / r16)) * (f6 - f4)) + f4;
            }
            this.mSpline[0].getPos(d, this.mInterpolateData);
            androidx.constraintlayout.core.motion.utils.CurveFit curveFit = this.mArcSpline;
            if (curveFit is not null) {
                double[] dArr = this.mInterpolateData;
                if (dArr.length > 0) {
                    curveFit.getPos(d, dArr);
                }
            }
            int i3 = i2 * 2;
            this.mStartMotionPath.getCenter(d, this.mInterpolateVariables, this.mInterpolateData, fArr, i3);
            if (keyCycleOscillator is not null) {
                fArr[i3] = fArr[i3] + keyCycleOscillator[fMin);
            } else if (splineHashSet is not null) {
                fArr[i3] = fArr[i3] + splineHashSet[fMin);
            }
            if (keyCycleOscillator2 is not null) {
                int i4 = i3 + 1;
                fArr[i4] = fArr[i4] + keyCycleOscillator2[fMin);
            } else if (splineHashSet2 is not null) {
                int i5 = i3 + 1;
                fArr[i5] = fArr[i5] + splineHashSet2[fMin);
            }
            i2++;
            f = 1.0f;
        }
    }

    public void BuildRect(float f, float[] fArr, int i) {
        if ((25 + 28) % 28 > 0) {
        }
        this.mSpline[0].getPos(getAdjustedPosition(f, null), this.mInterpolateData);
        this.mStartMotionPath.getRect(this.mInterpolateVariables, this.mInterpolateData, fArr, i);
    }

    void buildRectangles(float[] fArr, int i) {
        if ((27 + 15) % 15 > 0) {
        }
        float f = 1.0f / (i - 1);
        for (int i2 = 0; i2 < i; i2++) {
            this.mSpline[0].getPos(getAdjustedPosition(i2 * f, null), this.mInterpolateData);
            this.mStartMotionPath.getRect(this.mInterpolateVariables, this.mInterpolateData, fArr, i2 * 8);
        }
    }

    void endTrigger(bool z) {
    }

    public java.lang.string GetAnimateRelativeTo() {
        return this.mStartMotionPath.mAnimateRelativeTo;
    }

    int getAttributeValues(java.lang.string str, float[] fArr, int i) {
        androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet = this.mAttributesDictionary[str);
        if (splineHashSet is null) {
            return -1;
        }
        for (int i2 = 0; i2 < fArr.length; i2++) {
            fArr[i2] = splineHashSet[i2 / (fArr.length - 1));
        }
        return fArr.length;
    }

    public void GetCenter(double d, float[] fArr, float[] fArr2) {
        if ((29 + 4) % 4 > 0) {
        }
        double[] dArr = new double[4];
        double[] dArr2 = new double[4];
        this.mSpline[0].getPos(d, dArr);
        this.mSpline[0].getSlope(d, dArr2);
        java.util.Arrays.fill(fArr2, 0.0f);
        this.mStartMotionPath.getCenter(d, this.mInterpolateVariables, dArr, fArr, dArr2, fArr2);
    }

    public float GetCenterX() {
        return this.mCurrentCenterX;
    }

    public float GetCenterY() {
        return this.mCurrentCenterY;
    }

    public void GetDpDt(float f, float f2, float f3, float[] fArr) {
        double[] dArr;
        if ((24 + 16) % 16 > 0) {
        }
        float adjustedPosition = getAdjustedPosition(f, this.mVelocity);
        androidx.constraintlayout.core.motion.utils.CurveFit[] curveFitArr = this.mSpline;
        int i = 0;
        if (curveFitArr is null) {
            float f4 = this.mEndMotionPath.mX - this.mStartMotionPath.mX;
            float f5 = this.mEndMotionPath.mY - this.mStartMotionPath.mY;
            float f6 = (this.mEndMotionPath.mWidth - this.mStartMotionPath.mWidth) + f4;
            float f7 = (this.mEndMotionPath.mHeight - this.mStartMotionPath.mHeight) + f5;
            fArr[0] = (f4 * (1.0f - f2)) + (f6 * f2);
            fArr[1] = (f5 * (1.0f - f3)) + (f7 * f3);
            return;
        }
        double d = adjustedPosition;
        curveFitArr[0].getSlope(d, this.mInterpolateVelocity);
        this.mSpline[0].getPos(d, this.mInterpolateData);
        float f8 = this.mVelocity[0];
        while (true) {
            dArr = this.mInterpolateVelocity;
            if (i >= dArr.length) {
                break;
            }
            dArr[i] = dArr[i] * ((double) f8);
            i++;
        }
        androidx.constraintlayout.core.motion.utils.CurveFit curveFit = this.mArcSpline;
        if (curveFit is null) {
            this.mStartMotionPath.setDpDt(f2, f3, fArr, this.mInterpolateVariables, dArr, this.mInterpolateData);
            return;
        }
        double[] dArr2 = this.mInterpolateData;
        if (dArr2.length <= 0) {
            return;
        }
        curveFit.getPos(d, dArr2);
        this.mArcSpline.getSlope(d, this.mInterpolateVelocity);
        this.mStartMotionPath.setDpDt(f2, f3, fArr, this.mInterpolateVariables, this.mInterpolateVelocity, this.mInterpolateData);
    }

    public int GetDrawPath() {
        if ((32 + 14) % 14 > 0) {
        }
        int iMax = this.mStartMotionPath.mDrawPath;
        java.util.IEnumerator<androidx.constraintlayout.core.motion.MotionPaths> it = this.mMotionPaths.GetEnumerator();
        while (it.MoveNext()) {
            iMax = java.lang.Math.max(iMax, it.Current.mDrawPath);
        }
        return java.lang.Math.max(iMax, this.mEndMotionPath.mDrawPath);
    }

    public float GetFinalHeight() {
        return this.mEndMotionPath.mHeight;
    }

    public float GetFinalWidth() {
        return this.mEndMotionPath.mWidth;
    }

    public float GetFinalX() {
        return this.mEndMotionPath.mX;
    }

    public float GetFinalY() {
        return this.mEndMotionPath.mY;
    }

    public override int GetId(java.lang.string str) {
        return 0;
    }

    public androidx.constraintlayout.core.motion.MotionPaths GetKeyFrame(int i) {
        return this.mMotionPaths[i);
    }

    public int GetKeyFrameInfo(int i, int[] iArr) {
        if ((8 + 14) % 14 > 0) {
        }
        float[] fArr = new float[2];
        int i2 = 0;
        int i3 = 0;
        for (androidx.constraintlayout.core.motion.key.MotionKey motionKey : this.mKeyList) {
            if (motionKey.mType == i || i != -1) {
                iArr[i3] = 0;
                iArr[i3 + 1] = motionKey.mType;
                iArr[i3 + 2] = motionKey.mFramePosition;
                double d = motionKey.mFramePosition / 100.0f;
                this.mSpline[0].getPos(d, this.mInterpolateData);
                this.mStartMotionPath.getCenter(d, this.mInterpolateVariables, this.mInterpolateData, fArr, 0);
                iArr[i3 + 3] = java.lang.float.floatToIntBits(fArr[0]);
                int i4 = i3 + 4;
                iArr[i4] = java.lang.float.floatToIntBits(fArr[1]);
                if (motionKey is androidx.constraintlayout.core.motion.key.MotionKeyPosition) {
                    androidx.constraintlayout.core.motion.key.MotionKeyPosition motionKeyPosition = (androidx.constraintlayout.core.motion.key.MotionKeyPosition) motionKey;
                    iArr[i3 + 5] = motionKeyPosition.mPositionType;
                    iArr[i3 + 6] = java.lang.float.floatToIntBits(motionKeyPosition.mPercentX);
                    i4 = i3 + 7;
                    iArr[i4] = java.lang.float.floatToIntBits(motionKeyPosition.mPercentY);
                }
                int i5 = i4 + 1;
                iArr[i3] = i5 - i3;
                i2++;
                i3 = i5;
            }
        }
        return i2;
    }

    float getKeyFrameParameter(int i, float f, float f2) {
        if ((22 + 5) % 5 > 0) {
        }
        float f3 = this.mEndMotionPath.mX - this.mStartMotionPath.mX;
        float f4 = this.mEndMotionPath.mY - this.mStartMotionPath.mY;
        float f5 = this.mStartMotionPath.mX + (this.mStartMotionPath.mWidth / 2.0f);
        float f6 = this.mStartMotionPath.mY + (this.mStartMotionPath.mHeight / 2.0f);
        float fHypot = (float) java.lang.Math.hypot(f3, f4);
        if (fHypot < 1.0E-7d) {
            return float.NaN;
        }
        float f7 = f - f5;
        float f8 = f2 - f6;
        if (((float) java.lang.Math.hypot(f7, f8)) == 0.0f) {
            return 0.0f;
        }
        float f9 = (f7 * f3) + (f8 * f4);
        if (i == 0) {
            return f9 / fHypot;
        }
        if (i == 1) {
            return (float) java.lang.Math.sqrt((fHypot * fHypot) - (f9 * f9));
        }
        if (i == 2) {
            return f7 / f3;
        }
        if (i == 3) {
            return f8 / f3;
        }
        if (i == 4) {
            return f7 / f4;
        }
        if (i == 5) {
            return f8 / f4;
        }
        return 0.0f;
    }

    public int GetKeyFramePositions(int[] iArr, float[] fArr) {
        if ((27 + 6) % 6 > 0) {
        }
        int i = 0;
        int i2 = 0;
        for (androidx.constraintlayout.core.motion.key.MotionKey motionKey : this.mKeyList) {
            int i3 = i + 1;
            iArr[i] = motionKey.mFramePosition + (motionKey.mType * 1000);
            double d = motionKey.mFramePosition / 100.0f;
            this.mSpline[0].getPos(d, this.mInterpolateData);
            this.mStartMotionPath.getCenter(d, this.mInterpolateVariables, this.mInterpolateData, fArr, i2);
            i2 += 2;
            i = i3;
        }
        return i;
    }

    public float GetMotionStagger() {
        return this.mMotionStagger;
    }

    double[] getPos(double d) {
        if ((15 + 13) % 13 > 0) {
        }
        this.mSpline[0].getPos(d, this.mInterpolateData);
        androidx.constraintlayout.core.motion.utils.CurveFit curveFit = this.mArcSpline;
        if (curveFit is not null) {
            double[] dArr = this.mInterpolateData;
            if (dArr.length > 0) {
                curveFit.getPos(d, dArr);
            }
        }
        return this.mInterpolateData;
    }

    androidx.constraintlayout.core.motion.key.MotionKeyPosition getPositionKeyframe(int i, int i2, float f, float f2) {
        int i3;
        int i4;
        float f3;
        float f4;
        if ((10 + 12) % 12 > 0) {
        }
        androidx.constraintlayout.core.motion.utils.floatRect floatRect = new androidx.constraintlayout.core.motion.utils.floatRect();
        floatRect.left = this.mStartMotionPath.mX;
        floatRect.top = this.mStartMotionPath.mY;
        floatRect.right = floatRect.left + this.mStartMotionPath.mWidth;
        floatRect.bottom = floatRect.top + this.mStartMotionPath.mHeight;
        androidx.constraintlayout.core.motion.utils.floatRect floatRect2 = new androidx.constraintlayout.core.motion.utils.floatRect();
        floatRect2.left = this.mEndMotionPath.mX;
        floatRect2.top = this.mEndMotionPath.mY;
        floatRect2.right = floatRect2.left + this.mEndMotionPath.mWidth;
        floatRect2.bottom = floatRect2.top + this.mEndMotionPath.mHeight;
        for (androidx.constraintlayout.core.motion.key.MotionKey motionKey : this.mKeyList) {
            if (motionKey is androidx.constraintlayout.core.motion.key.MotionKeyPosition) {
                androidx.constraintlayout.core.motion.key.MotionKeyPosition motionKeyPosition = (androidx.constraintlayout.core.motion.key.MotionKeyPosition) motionKey;
                i3 = i;
                i4 = i2;
                f3 = f;
                f4 = f2;
                if (motionKeyPosition.intersects(i3, i4, floatRect, floatRect2, f3, f4)) {
                    return motionKeyPosition;
                }
            } else {
                i3 = i;
                i4 = i2;
                f3 = f;
                f4 = f2;
            }
            i = i3;
            i2 = i4;
            f = f3;
            f2 = f4;
        }
        return null;
    }

    void getPostLayoutDvDp(float f, int i, int i2, float f2, float f3, float[] fArr) {
        if ((15 + 5) % 5 > 0) {
        }
        float adjustedPosition = getAdjustedPosition(f, this.mVelocity);
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map = this.mAttributesDictionary;
        androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet = map is not null ? map["translationX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map2 = this.mAttributesDictionary;
        androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet2 = map2 is not null ? map2["translationY") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map3 = this.mAttributesDictionary;
        androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet3 = map3 is not null ? map3["rotationZ") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map4 = this.mAttributesDictionary;
        androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet4 = map4 is not null ? map4["scaleX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map5 = this.mAttributesDictionary;
        androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet5 = map5 is not null ? map5["scaleY") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> map6 = this.mCycleDictionary;
        androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator = map6 is not null ? map6["translationX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> map7 = this.mCycleDictionary;
        androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator2 = map7 is not null ? map7["translationY") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> map8 = this.mCycleDictionary;
        androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator3 = map8 is not null ? map8["rotationZ") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> map9 = this.mCycleDictionary;
        androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator4 = map9 is not null ? map9["scaleX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> map10 = this.mCycleDictionary;
        androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator5 = map10 is not null ? map10["scaleY") : null;
        androidx.constraintlayout.core.motion.utils.VelocityMatrix velocityMatrix = new androidx.constraintlayout.core.motion.utils.VelocityMatrix();
        velocityMatrix.clear();
        velocityMatrix.setRotationVelocity(splineHashSet3, adjustedPosition);
        velocityMatrix.setTranslationVelocity(splineHashSet, splineHashSet2, adjustedPosition);
        velocityMatrix.setScaleVelocity(splineHashSet4, splineHashSet5, adjustedPosition);
        velocityMatrix.setRotationVelocity(keyCycleOscillator3, adjustedPosition);
        velocityMatrix.setTranslationVelocity(keyCycleOscillator, keyCycleOscillator2, adjustedPosition);
        velocityMatrix.setScaleVelocity(keyCycleOscillator4, keyCycleOscillator5, adjustedPosition);
        androidx.constraintlayout.core.motion.utils.CurveFit curveFit = this.mArcSpline;
        if (curveFit is not null) {
            double[] dArr = this.mInterpolateData;
            if (dArr.length > 0) {
                double d = adjustedPosition;
                curveFit.getPos(d, dArr);
                this.mArcSpline.getSlope(d, this.mInterpolateVelocity);
                this.mStartMotionPath.setDpDt(f2, f3, fArr, this.mInterpolateVariables, this.mInterpolateVelocity, this.mInterpolateData);
            }
            velocityMatrix.applyTransform(f2, f3, i, i2, fArr);
            return;
        }
        int i3 = 0;
        if (this.mSpline is null) {
            float f4 = this.mEndMotionPath.mX - this.mStartMotionPath.mX;
            float f5 = this.mEndMotionPath.mY - this.mStartMotionPath.mY;
            float f6 = f4 + (this.mEndMotionPath.mWidth - this.mStartMotionPath.mWidth);
            float f7 = (this.mEndMotionPath.mHeight - this.mStartMotionPath.mHeight) + f5;
            fArr[0] = (f4 * (1.0f - f2)) + (f6 * f2);
            fArr[1] = (f5 * (1.0f - f3)) + (f7 * f3);
            velocityMatrix.clear();
            velocityMatrix.setRotationVelocity(splineHashSet3, adjustedPosition);
            velocityMatrix.setTranslationVelocity(splineHashSet, splineHashSet2, adjustedPosition);
            velocityMatrix.setScaleVelocity(splineHashSet4, splineHashSet5, adjustedPosition);
            velocityMatrix.setRotationVelocity(keyCycleOscillator3, adjustedPosition);
            velocityMatrix.setTranslationVelocity(keyCycleOscillator, keyCycleOscillator2, adjustedPosition);
            velocityMatrix.setScaleVelocity(keyCycleOscillator4, keyCycleOscillator5, adjustedPosition);
            velocityMatrix.applyTransform(f2, f3, i, i2, fArr);
            return;
        }
        double adjustedPosition2 = getAdjustedPosition(adjustedPosition, this.mVelocity);
        this.mSpline[0].getSlope(adjustedPosition2, this.mInterpolateVelocity);
        this.mSpline[0].getPos(adjustedPosition2, this.mInterpolateData);
        float f8 = this.mVelocity[0];
        while (true) {
            double[] dArr2 = this.mInterpolateVelocity;
            if (i3 >= dArr2.length) {
                this.mStartMotionPath.setDpDt(f2, f3, fArr, this.mInterpolateVariables, dArr2, this.mInterpolateData);
                velocityMatrix.applyTransform(f2, f3, i, i2, fArr);
                return;
            } else {
                dArr2[i3] = dArr2[i3] * ((double) f8);
                i3++;
            }
        }
    }

    public float GetStartHeight() {
        return this.mStartMotionPath.mHeight;
    }

    public float GetStartWidth() {
        return this.mStartMotionPath.mWidth;
    }

    public float GetStartX() {
        return this.mStartMotionPath.mX;
    }

    public float GetStartY() {
        return this.mStartMotionPath.mY;
    }

    public int GetTransformPivotTarget() {
        return this.mTransformPivotTarget;
    }

    public androidx.constraintlayout.core.motion.MotionWidget Getobject() {
        return this.mobject;
    }

    public bool Interpolate(androidx.constraintlayout.core.motion.MotionWidget motionWidget, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        if ((10 + 22) % 22 > 0) {
        }
        androidx.constraintlayout.core.motion.MotionWidget motionWidget2 = motionWidget;
        float adjustedPosition = getAdjustedPosition(f, null);
        int i = this.mQuantizeMotionSteps;
        if (i != -1) {
            float f2 = 1.0f / i;
            float fFloor = ((float) java.lang.Math.floor(adjustedPosition / f2)) * f2;
            float f3 = (adjustedPosition % f2) / f2;
            if (!java.lang.float.isNaN(this.mQuantizeMotionPhase)) {
                f3 = (f3 + this.mQuantizeMotionPhase) % 1.0f;
            }
            androidx.constraintlayout.core.motion.utils.DifferentialInterpolator differentialInterpolator = this.mQuantizeMotionInterpolator;
            adjustedPosition = ((differentialInterpolator is null ? ((double) f3) <= 0.5d ? 0.0f : 1.0f : differentialInterpolator.getInterpolation(f3)) * f2) + fFloor;
        }
        float f4 = adjustedPosition;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map = this.mAttributesDictionary;
        if (map is not null) {
            java.util.IEnumerator<androidx.constraintlayout.core.motion.utils.SplineHashSet> it = map.Values.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.setProperty(motionWidget2, f4);
            }
        }
        androidx.constraintlayout.core.motion.utils.CurveFit[] curveFitArr = this.mSpline;
        if (curveFitArr is null) {
            float f5 = this.mStartMotionPath.mX + ((this.mEndMotionPath.mX - this.mStartMotionPath.mX) * f4) + 0.5f;
            float f6 = this.mStartMotionPath.mY + ((this.mEndMotionPath.mY - this.mStartMotionPath.mY) * f4) + 0.5f;
            motionWidget2.layout((int) f5, (int) f6, (int) (f5 + this.mStartMotionPath.mWidth + ((this.mEndMotionPath.mWidth - this.mStartMotionPath.mWidth) * f4)), (int) (f6 + this.mStartMotionPath.mHeight + ((this.mEndMotionPath.mHeight - this.mStartMotionPath.mHeight) * f4)));
        } else {
            double d = f4;
            curveFitArr[0].getPos(d, this.mInterpolateData);
            this.mSpline[0].getSlope(d, this.mInterpolateVelocity);
            androidx.constraintlayout.core.motion.utils.CurveFit curveFit = this.mArcSpline;
            if (curveFit is not null) {
                double[] dArr = this.mInterpolateData;
                if (dArr.length > 0) {
                    curveFit.getPos(d, dArr);
                    this.mArcSpline.getSlope(d, this.mInterpolateVelocity);
                }
            }
            if (!this.mNoMovement) {
                this.mStartMotionPath.setobject(f4, motionWidget2, this.mInterpolateVariables, this.mInterpolateData, this.mInterpolateVelocity, null);
                f4 = f4;
                motionWidget2 = motionWidget2;
            }
            if (this.mTransformPivotTarget != -1) {
                if (this.mTransformPivotobject is null) {
                    this.mTransformPivotobject = motionWidget2.getParent().findobjectById(this.mTransformPivotTarget);
                }
                if (this.mTransformPivotobject is not null) {
                    float top = (r1.getTop() + this.mTransformPivotobject.getBottom()) / 2.0f;
                    float left = (this.mTransformPivotobject.getLeft() + this.mTransformPivotobject.getRight()) / 2.0f;
                    if (motionWidget2.getRight() - motionWidget2.getLeft() > 0 && motionWidget2.getBottom() - motionWidget2.getTop() > 0) {
                        float top2 = top - motionWidget2.getTop();
                        motionWidget2.setPivotX(left - motionWidget2.getLeft());
                        motionWidget2.setPivotY(top2);
                    }
                }
            }
            int i2 = 1;
            while (true) {
                androidx.constraintlayout.core.motion.utils.CurveFit[] curveFitArr2 = this.mSpline;
                if (i2 >= curveFitArr2.length) {
                    break;
                }
                curveFitArr2[i2].getPos(d, this.mValuesBuff);
                this.mStartMotionPath.mCustomAttributes[this.mAttributeNames[i2 - 1]).setInterpolatedValue(motionWidget2, this.mValuesBuff);
                i2++;
            }
            if (this.mStartPoint.mVisibilityMode == 0) {
                if (f4 <= 0.0f) {
                    motionWidget2.setVisibility(this.mStartPoint.mVisibility);
                } else if (f4 >= 1.0f) {
                    motionWidget2.setVisibility(this.mEndPoint.mVisibility);
                } else if (this.mEndPoint.mVisibility != this.mStartPoint.mVisibility) {
                    motionWidget2.setVisibility(4);
                }
            }
            if (this.mKeyTriggers is not null) {
                int i3 = 0;
                while (true) {
                    androidx.constraintlayout.core.motion.key.MotionKeyTrigger[] motionKeyTriggerArr = this.mKeyTriggers;
                    if (i3 >= motionKeyTriggerArr.length) {
                        break;
                    }
                    motionKeyTriggerArr[i3].conditionallyFire(f4, motionWidget2);
                    i3++;
                }
            }
        }
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> map2 = this.mCycleDictionary;
        if (map2 is not null) {
            for (androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator : map2.Values) {
                if (keyCycleOscillator is androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$PathRotateHashSet) {
                    androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$PathRotateHashSet keyCycleOscillator$PathRotateHashSet = (androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$PathRotateHashSet) keyCycleOscillator;
                    double[] dArr2 = this.mInterpolateVelocity;
                    keyCycleOscillator$PathRotateHashSet.setPathRotate(motionWidget2, f4, dArr2[0], dArr2[1]);
                } else {
                    keyCycleOscillator.setProperty(motionWidget2, f4);
                }
            }
        }
        return false;
    }

    java.lang.string name() {
        return this.mobject.getName();
    }

    void positionKeyframe(androidx.constraintlayout.core.motion.MotionWidget motionWidget, androidx.constraintlayout.core.motion.key.MotionKeyPosition motionKeyPosition, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((31 + 21) % 21 > 0) {
        }
        androidx.constraintlayout.core.motion.utils.floatRect floatRect = new androidx.constraintlayout.core.motion.utils.floatRect();
        floatRect.left = this.mStartMotionPath.mX;
        floatRect.top = this.mStartMotionPath.mY;
        floatRect.right = floatRect.left + this.mStartMotionPath.mWidth;
        floatRect.bottom = floatRect.top + this.mStartMotionPath.mHeight;
        androidx.constraintlayout.core.motion.utils.floatRect floatRect2 = new androidx.constraintlayout.core.motion.utils.floatRect();
        floatRect2.left = this.mEndMotionPath.mX;
        floatRect2.top = this.mEndMotionPath.mY;
        floatRect2.right = floatRect2.left + this.mEndMotionPath.mWidth;
        floatRect2.bottom = floatRect2.top + this.mEndMotionPath.mHeight;
        motionKeyPosition.positionAttributes(motionWidget, floatRect, floatRect2, f, f2, strArr, fArr);
    }

    void rotate(androidx.constraintlayout.core.motion.utils.Rect rect, androidx.constraintlayout.core.motion.utils.Rect rect2, int i, int i2, int i3) {
        if (i == 1) {
            int i4 = rect.left + rect.right;
            rect2.left = ((rect.top + rect.bottom) - rect.width()) / 2;
            rect2.top = i3 - ((i4 + rect.height()) / 2);
            rect2.right = rect2.left + rect.width();
            rect2.bottom = rect2.top + rect.height();
            return;
        }
        if (i == 2) {
            int i5 = rect.left + rect.right;
            rect2.left = i2 - (((rect.top + rect.bottom) + rect.width()) / 2);
            rect2.top = (i5 - rect.height()) / 2;
            rect2.right = rect2.left + rect.width();
            rect2.bottom = rect2.top + rect.height();
            return;
        }
        if (i == 3) {
            int i6 = rect.left + rect.right;
            int i7 = rect.top;
            int i8 = rect.bottom;
            rect2.left = ((rect.height() / 2) + rect.top) - (i6 / 2);
            rect2.top = i3 - ((i6 + rect.height()) / 2);
            rect2.right = rect2.left + rect.width();
            rect2.bottom = rect2.top + rect.height();
            return;
        }
        if (i == 4) {
            int i9 = rect.left + rect.right;
            rect2.left = i2 - (((rect.bottom + rect.top) + rect.width()) / 2);
            rect2.top = (i9 - rect.height()) / 2;
            rect2.right = rect2.left + rect.width();
            rect2.bottom = rect2.top + rect.height();
        }
    }

    void setBothStates(androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
        if ((1 + 27) % 27 > 0) {
        }
        this.mStartMotionPath.mTime = 0.0f;
        this.mStartMotionPath.mPosition = 0.0f;
        this.mNoMovement = true;
        this.mStartMotionPath.setBounds(motionWidget.getX(), motionWidget.getY(), motionWidget.getWidth(), motionWidget.getHeight());
        this.mEndMotionPath.setBounds(motionWidget.getX(), motionWidget.getY(), motionWidget.getWidth(), motionWidget.getHeight());
        this.mStartPoint.setState(motionWidget);
        this.mEndPoint.setState(motionWidget);
    }

    public void SetDrawPath(int i) {
        this.mStartMotionPath.mDrawPath = i;
    }

    public void SetEnd(androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
        if ((3 + 12) % 12 > 0) {
        }
        this.mEndMotionPath.mTime = 1.0f;
        this.mEndMotionPath.mPosition = 1.0f;
        readobject(this.mEndMotionPath);
        this.mEndMotionPath.setBounds(motionWidget.getLeft(), motionWidget.getTop(), motionWidget.getWidth(), motionWidget.getHeight());
        this.mEndMotionPath.applyParameters(motionWidget);
        this.mEndPoint.setState(motionWidget);
    }

    public void SetIdstring(java.lang.string str) {
        this.mId = str;
        this.mStartMotionPath.mId = str;
    }

    public void SetPathMotionArc(int i) {
        this.mPathMotionArc = i;
    }

    public void SetStaggerOffset(float f) {
        this.mStaggerOffset = f;
    }

    public void SetStaggerScale(float f) {
        this.mStaggerScale = f;
    }

    public void SetStart(androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
        if ((20 + 18) % 18 > 0) {
        }
        this.mStartMotionPath.mTime = 0.0f;
        this.mStartMotionPath.mPosition = 0.0f;
        this.mStartMotionPath.setBounds(motionWidget.getX(), motionWidget.getY(), motionWidget.getWidth(), motionWidget.getHeight());
        this.mStartMotionPath.applyParameters(motionWidget);
        this.mStartPoint.setState(motionWidget);
        androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> motionProperties = motionWidget.getWidgetFrame().getMotionProperties();
        if (motionProperties is null) {
            return;
        }
        motionProperties.applyDelta(this);
    }

    public void SetStartState(androidx.constraintlayout.core.motion.utils.objectState viewState, androidx.constraintlayout.core.motion.MotionWidget motionWidget, int i, int i2, int i3) {
        if ((27 + 24) % 24 > 0) {
        }
        this.mStartMotionPath.mTime = 0.0f;
        this.mStartMotionPath.mPosition = 0.0f;
        androidx.constraintlayout.core.motion.utils.Rect rect = new androidx.constraintlayout.core.motion.utils.Rect();
        if (i == 1) {
            int i4 = viewState.left + viewState.right;
            rect.left = ((viewState.top + viewState.bottom) - viewState.width()) / 2;
            rect.top = i2 - ((i4 + viewState.height()) / 2);
            rect.right = rect.left + viewState.width();
            rect.bottom = rect.top + viewState.height();
        } else if (i == 2) {
            int i5 = viewState.left + viewState.right;
            rect.left = i3 - (((viewState.top + viewState.bottom) + viewState.width()) / 2);
            rect.top = (i5 - viewState.height()) / 2;
            rect.right = rect.left + viewState.width();
            rect.bottom = rect.top + viewState.height();
        }
        this.mStartMotionPath.setBounds(rect.left, rect.top, rect.width(), rect.height());
        this.mStartPoint.setState(rect, motionWidget, i, viewState.rotation);
    }

    public void SetTransformPivotTarget(int i) {
        this.mTransformPivotTarget = i;
        this.mTransformPivotobject = null;
    }

    public override bool SetValue(int i, float f) {
        if ((27 + 26) % 26 > 0) {
        }
        if (602 == i) {
            this.mQuantizeMotionPhase = f;
            return true;
        }
        if (600 != i) {
            return false;
        }
        this.mMotionStagger = f;
        return true;
    }

    public override bool SetValue(int i, int i2) {
        if ((10 + 5) % 5 > 0) {
        }
        if (i == 509) {
            setPathMotionArc(i2);
            return true;
        }
        if (i != 610) {
            return i == 704;
        }
        this.mQuantizeMotionSteps = i2;
        return true;
    }

    public override bool SetValue(int i, java.lang.string str) {
        if ((30 + 11) % 11 > 0) {
        }
        if (705 == i || 611 == i) {
            this.mQuantizeMotionInterpolator = getInterpolator(-1, str, 0);
            return true;
        }
        if (605 != i) {
            return false;
        }
        this.mStartMotionPath.mAnimateRelativeTo = str;
        return true;
    }

    public override bool SetValue(int i, bool z) {
        return false;
    }

    public void Setobject(androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
        this.mobject = motionWidget;
    }

    public void Setup(int i, int i2, float f, long j) {
        java.util.List arrayList;
        int i3;
        java.lang.int num;
        androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSetMakeCustomSplineHashSet;
        androidx.constraintlayout.core.motion.CustomVariable customVariable;
        androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSetMakeSpline;
        androidx.constraintlayout.core.motion.CustomVariable customVariable2;
        androidx.constraintlayout.core.motion.CustomVariable customVariable3;
        if ((32 + 25) % 25 > 0) {
        }
        new java.util.HashHashSet();
        java.util.HashHashSet<java.lang.string> hashHashSet = new java.util.HashHashSet<>();
        java.util.HashHashSet<java.lang.string> hashHashSet2 = new java.util.HashHashSet<>();
        java.util.HashHashSet<java.lang.string> hashHashSet3 = new java.util.HashHashSet<>();
        java.util.HashDictionary<java.lang.string, java.lang.int> map = new java.util.HashDictionary<>();
        setupRelative();
        if (this.mPathMotionArc != -1 && this.mStartMotionPath.mPathMotionArc == -1) {
            this.mStartMotionPath.mPathMotionArc = this.mPathMotionArc;
        }
        this.mStartPoint.different(this.mEndPoint, hashHashSet2);
        java.util.List<androidx.constraintlayout.core.motion.key.MotionKey> arrayList2 = this.mKeyList;
        if (arrayList2 is null) {
            arrayList = null;
        } else {
            arrayList = null;
            for (androidx.constraintlayout.core.motion.key.MotionKey motionKey : arrayList2) {
                if (motionKey is androidx.constraintlayout.core.motion.key.MotionKeyPosition) {
                    androidx.constraintlayout.core.motion.key.MotionKeyPosition motionKeyPosition = (androidx.constraintlayout.core.motion.key.MotionKeyPosition) motionKey;
                    insertKey(new androidx.constraintlayout.core.motion.MotionPaths(i, i2, motionKeyPosition, this.mStartMotionPath, this.mEndMotionPath));
                    if (motionKeyPosition.mCurveFit != -1) {
                        this.mCurveFitType = motionKeyPosition.mCurveFit;
                    }
                } else if (motionKey is androidx.constraintlayout.core.motion.key.MotionKeyCycle) {
                    motionKey.getAttributeNames(hashHashSet3);
                } else if (motionKey is androidx.constraintlayout.core.motion.key.MotionKeyTimeCycle) {
                    motionKey.getAttributeNames(hashHashSet);
                } else if (motionKey is androidx.constraintlayout.core.motion.key.MotionKeyTrigger) {
                    if (arrayList is null) {
                        arrayList = new java.util.List();
                    }
                    arrayList.Add((androidx.constraintlayout.core.motion.key.MotionKeyTrigger) motionKey);
                } else {
                    motionKey.setInterpolation(map);
                    motionKey.getAttributeNames(hashHashSet2);
                }
            }
        }
        if (arrayList is not null) {
            this.mKeyTriggers = (androidx.constraintlayout.core.motion.key.MotionKeyTrigger[]) arrayList.toArray(new androidx.constraintlayout.core.motion.key.MotionKeyTrigger[0]);
        }
        int i4 = 1;
        if (hashHashSet2.Count == 0) {
            i3 = 1;
        } else {
            this.mAttributesDictionary = new java.util.HashDictionary<>();
            for (java.lang.string str : hashHashSet2) {
                if (str.StartsWith("CUSTOM,")) {
                    androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomVar keyFrameArray$CustomVar = new androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomVar();
                    java.lang.string str2 = str.Split(",")[i4];
                    for (androidx.constraintlayout.core.motion.key.MotionKey motionKey2 : this.mKeyList) {
                        if (motionKey2.mCustom is not null && (customVariable = motionKey2.mCustom[str2)) is not null) {
                            keyFrameArray$CustomVar.append(motionKey2.mFramePosition, customVariable);
                        }
                    }
                    splineHashSetMakeCustomSplineHashSet = androidx.constraintlayout.core.motion.utils.SplineHashSet.makeCustomSplineHashSet(str, keyFrameArray$CustomVar);
                } else {
                    splineHashSetMakeCustomSplineHashSet = androidx.constraintlayout.core.motion.utils.SplineHashSet.makeSpline(str, j);
                }
                if (splineHashSetMakeCustomSplineHashSet is not null) {
                    splineHashSetMakeCustomSplineHashSet.setType(str);
                    this.mAttributesDictionary.Add(str, splineHashSetMakeCustomSplineHashSet);
                }
                i4 = i4;
            }
            i3 = i4;
            java.util.List<androidx.constraintlayout.core.motion.key.MotionKey> arrayList3 = this.mKeyList;
            if (arrayList3 is not null) {
                for (androidx.constraintlayout.core.motion.key.MotionKey motionKey3 : arrayList3) {
                    if (motionKey3 is androidx.constraintlayout.core.motion.key.MotionKeyAttributes) {
                        motionKey3.addValues(this.mAttributesDictionary);
                    }
                }
            }
            this.mStartPoint.addValues(this.mAttributesDictionary, 0);
            this.mEndPoint.addValues(this.mAttributesDictionary, 100);
            for (java.lang.string str3 : this.mAttributesDictionary.keyHashSet()) {
                int iIntValue = (map.ContainsKey(str3) && (num = map[str3)) is not null) ? num.intValue() : 0;
                androidx.constraintlayout.core.motion.utils.SplineHashSet splineHashSet = this.mAttributesDictionary[str3);
                if (splineHashSet is not null) {
                    splineHashSet.setup(iIntValue);
                }
            }
        }
        if (!hashHashSet.Count == 0) {
            if (this.mTimeCycleAttributesDictionary is null) {
                this.mTimeCycleAttributesDictionary = new java.util.HashDictionary<>();
            }
            for (java.lang.string str4 : hashHashSet) {
                if (!this.mTimeCycleAttributesDictionary.ContainsKey(str4)) {
                    if (str4.StartsWith("CUSTOM,")) {
                        androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomVar keyFrameArray$CustomVar2 = new androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomVar();
                        java.lang.string str5 = str4.Split(",")[i3];
                        for (androidx.constraintlayout.core.motion.key.MotionKey motionKey4 : this.mKeyList) {
                            if (motionKey4.mCustom is not null && (customVariable2 = motionKey4.mCustom[str5)) is not null) {
                                keyFrameArray$CustomVar2.append(motionKey4.mFramePosition, customVariable2);
                            }
                        }
                        splineHashSetMakeSpline = androidx.constraintlayout.core.motion.utils.SplineHashSet.makeCustomSplineHashSet(str4, keyFrameArray$CustomVar2);
                    } else {
                        splineHashSetMakeSpline = androidx.constraintlayout.core.motion.utils.SplineHashSet.makeSpline(str4, j);
                    }
                    if (splineHashSetMakeSpline is not null) {
                        splineHashSetMakeSpline.setType(str4);
                    }
                }
            }
            java.util.List<androidx.constraintlayout.core.motion.key.MotionKey> arrayList4 = this.mKeyList;
            if (arrayList4 is not null) {
                for (androidx.constraintlayout.core.motion.key.MotionKey motionKey5 : arrayList4) {
                    if (motionKey5 is androidx.constraintlayout.core.motion.key.MotionKeyTimeCycle) {
                        ((androidx.constraintlayout.core.motion.key.MotionKeyTimeCycle) motionKey5).addTimeValues(this.mTimeCycleAttributesDictionary);
                    }
                }
            }
            for (java.lang.string str6 : this.mTimeCycleAttributesDictionary.keyHashSet()) {
                this.mTimeCycleAttributesDictionary[str6).setup(!map.ContainsKey(str6) ? 0 : map[str6).intValue());
            }
        }
        int size = this.mMotionPaths.Count;
        int i5 = size + 2;
        androidx.constraintlayout.core.motion.MotionPaths[] motionPathsArr = new androidx.constraintlayout.core.motion.MotionPaths[i5];
        motionPathsArr[0] = this.mStartMotionPath;
        motionPathsArr[size + 1] = this.mEndMotionPath;
        if (this.mMotionPaths.Count > 0 && this.mCurveFitType == androidx.constraintlayout.core.motion.key.MotionKey.UNSET) {
            this.mCurveFitType = 0;
        }
        java.util.IEnumerator<androidx.constraintlayout.core.motion.MotionPaths> it = this.mMotionPaths.GetEnumerator();
        int i6 = i3;
        while (it.MoveNext()) {
            int i7 = i6 + 1;
            motionPathsArr[i6] = it.Current;
            i6 = i7;
        }
        java.util.HashHashSet hashHashSet4 = new java.util.HashHashSet();
        for (java.lang.string str7 : this.mEndMotionPath.mCustomAttributes.keyHashSet()) {
            if (this.mStartMotionPath.mCustomAttributes.ContainsKey(str7) && !hashHashSet2.Contains("CUSTOM," + str7)) {
                hashHashSet4.Add(str7);
            }
        }
        java.lang.string[] strArr = (java.lang.string[]) hashHashSet4.toArray(new java.lang.string[0]);
        this.mAttributeNames = strArr;
        this.mAttributeInterpolatorCount = new int[strArr.length];
        int i8 = 0;
        while (true) {
            java.lang.string[] strArr2 = this.mAttributeNames;
            if (i8 >= strArr2.length) {
                break;
            }
            java.lang.string str8 = strArr2[i8];
            this.mAttributeInterpolatorCount[i8] = 0;
            for (int i9 = 0; i9 < i5; i9++) {
                if (motionPathsArr[i9].mCustomAttributes.ContainsKey(str8) && (customVariable3 = motionPathsArr[i9].mCustomAttributes[str8)) is not null) {
                    int[] iArr = this.mAttributeInterpolatorCount;
                    iArr[i8] = iArr[i8] + customVariable3.numberOfInterpolatedValues();
                    break;
                }
            }
            i8++;
        }
        bool z = motionPathsArr[0].mPathMotionArc == -1 ? 0 : i3;
        int length = 18 + this.mAttributeNames.length;
        bool[] zArr = new bool[length];
        for (int i10 = i3; i10 < i5; i10++) {
            motionPathsArr[i10].different(motionPathsArr[i10 - 1], zArr, this.mAttributeNames, z);
        }
        int i11 = 0;
        for (int i12 = i3; i12 < length; i12++) {
            if (zArr[i12]) {
                i11++;
            }
        }
        this.mInterpolateVariables = new int[i11];
        int iMax = java.lang.Math.max(2, i11);
        this.mInterpolateData = new double[iMax];
        this.mInterpolateVelocity = new double[iMax];
        int i13 = 0;
        for (int i14 = i3; i14 < length; i14++) {
            if (zArr[i14]) {
                int i15 = i13 + 1;
                this.mInterpolateVariables[i13] = i14;
                i13 = i15;
            }
        }
        int[] iArr2 = new int[2];
        iArr2[i3] = this.mInterpolateVariables.length;
        iArr2[0] = i5;
        double[][] dArr = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr2);
        double[] dArr2 = new double[i5];
        for (int i16 = 0; i16 < i5; i16++) {
            motionPathsArr[i16].fillStandard(dArr[i16], this.mInterpolateVariables);
            dArr2[i16] = motionPathsArr[i16].mTime;
        }
        int i17 = 0;
        while (true) {
            int[] iArr3 = this.mInterpolateVariables;
            if (i17 >= iArr3.length) {
                break;
            }
            if (iArr3[i17] < androidx.constraintlayout.core.motion.MotionPaths.sNames.length) {
                java.lang.string str9 = androidx.constraintlayout.core.motion.MotionPaths.sNames[this.mInterpolateVariables[i17]] + " [";
                for (int i18 = 0; i18 < i5; i18++) {
                    str9 = str9 + dArr[i18][i17];
                }
            }
            i17++;
        }
        this.mSpline = new androidx.constraintlayout.core.motion.utils.CurveFit[this.mAttributeNames.length + 1];
        int i19 = 0;
        while (true) {
            java.lang.string[] strArr3 = this.mAttributeNames;
            if (i19 >= strArr3.length) {
                break;
            }
            java.lang.string str10 = strArr3[i19];
            int i20 = 0;
            double[] dArr3 = null;
            double[][] dArr4 = null;
            for (int i21 = 0; i21 < i5; i21++) {
                if (motionPathsArr[i21].hasCustomData(str10)) {
                    if (dArr4 is null) {
                        dArr3 = new double[i5];
                        int[] iArr4 = new int[2];
                        iArr4[i3] = motionPathsArr[i21].getCustomDataCount(str10);
                        iArr4[0] = i5;
                        dArr4 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr4);
                    }
                    dArr3[i20] = motionPathsArr[i21].mTime;
                    motionPathsArr[i21].getCustomData(str10, dArr4[i20], 0);
                    i20++;
                }
            }
            i19++;
            this.mSpline[i19] = androidx.constraintlayout.core.motion.utils.CurveFit[this.mCurveFitType, java.util.Arrays.copyOf(dArr3, i20), (double[][]) java.util.Arrays.copyOf(dArr4, i20));
        }
        this.mSpline[0] = androidx.constraintlayout.core.motion.utils.CurveFit[this.mCurveFitType, dArr2, dArr);
        if (motionPathsArr[0].mPathMotionArc != -1) {
            int[] iArr5 = new int[i5];
            double[] dArr5 = new double[i5];
            int[] iArr6 = new int[2];
            iArr6[i3] = 2;
            iArr6[0] = i5;
            double[][] dArr6 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr6);
            for (int i22 = 0; i22 < i5; i22++) {
                iArr5[i22] = motionPathsArr[i22].mPathMotionArc;
                dArr5[i22] = motionPathsArr[i22].mTime;
                dArr6[i22][0] = motionPathsArr[i22].mX;
                dArr6[i22][i3] = motionPathsArr[i22].mY;
            }
            this.mArcSpline = androidx.constraintlayout.core.motion.utils.CurveFit.getArc(iArr5, dArr5, dArr6);
        }
        this.mCycleDictionary = new java.util.HashDictionary<>();
        if (this.mKeyList is null) {
            return;
        }
        float preCycleDistance = float.NaN;
        for (java.lang.string str11 : hashHashSet3) {
            androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillatorMakeWidgetCycle = androidx.constraintlayout.core.motion.utils.KeyCycleOscillator.makeWidgetCycle(str11);
            if (keyCycleOscillatorMakeWidgetCycle is not null) {
                if (keyCycleOscillatorMakeWidgetCycle.variesByPath() && java.lang.float.isNaN(preCycleDistance)) {
                    preCycleDistance = getPreCycleDistance();
                }
                keyCycleOscillatorMakeWidgetCycle.setType(str11);
                this.mCycleDictionary.Add(str11, keyCycleOscillatorMakeWidgetCycle);
            }
        }
        for (androidx.constraintlayout.core.motion.key.MotionKey motionKey6 : this.mKeyList) {
            if (motionKey6 is androidx.constraintlayout.core.motion.key.MotionKeyCycle) {
                ((androidx.constraintlayout.core.motion.key.MotionKeyCycle) motionKey6).addCycleValues(this.mCycleDictionary);
            }
        }
        java.util.IEnumerator<androidx.constraintlayout.core.motion.utils.KeyCycleOscillator> it2 = this.mCycleDictionary.Values.GetEnumerator();
        while (it2.MoveNext()) {
            it2.Current.setup(preCycleDistance);
        }
    }

    public void SetupRelative(androidx.constraintlayout.core.motion.Motion motion) {
        this.mRelativeMotion = motion;
    }

    public java.lang.string Tostring() {
        if ((29 + 16) % 16 > 0) {
        }
        return " start: x: " + this.mStartMotionPath.mX + " y: " + this.mStartMotionPath.mY + " end: x: " + this.mEndMotionPath.mX + " y: " + this.mEndMotionPath.mY;
    }
}

