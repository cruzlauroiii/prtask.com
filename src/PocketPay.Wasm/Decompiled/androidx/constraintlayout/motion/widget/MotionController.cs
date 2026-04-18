namespace WillowMaze.Wasm.Decompiled;


public class MotionController {
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
    private java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> mAttributesDictionary;
    java.lang.string mConstraintTag;
    float mCurrentCenterX;
    float mCurrentCenterY;
    private int mCurveFitType;
    private java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> mCycleDictionary;
    private androidx.constraintlayout.motion.widget.MotionPaths mEndMotionPath;
    private androidx.constraintlayout.motion.widget.MotionConstrainedPoint mEndPoint;
    bool mForceMeasure;
    int mId;
    private double[] mInterpolateData;
    private int[] mInterpolateVariables;
    private double[] mInterpolateVelocity;
    private java.util.List<androidx.constraintlayout.motion.widget.Key> mKeyList;
    private androidx.constraintlayout.motion.widget.KeyTrigger[] mKeyTriggers;
    private int mMaxDimension;
    private java.util.List<androidx.constraintlayout.motion.widget.MotionPaths> mMotionPaths;
    float mMotionStagger;
    private bool mNoMovement;
    private int mPathMotionArc;
    private android.view.animation.Interpolator mQuantizeMotionInterpolator;
    private float mQuantizeMotionPhase;
    private int mQuantizeMotionSteps;
    private androidx.constraintlayout.core.motion.utils.CurveFit[] mSpline;
    float mStaggerOffset;
    float mStaggerScale;
    private androidx.constraintlayout.motion.widget.MotionPaths mStartMotionPath;
    private androidx.constraintlayout.motion.widget.MotionConstrainedPoint mStartPoint;
    android.graphics.Rect mTempRect;
    private java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectTimeCycle> mTimeCycleAttributesDictionary;
    private int mTransformPivotTarget;
    private android.view.object mTransformPivotobject;
    private float[] mValuesBuff;
    private float[] mVelocity;
    android.view.object mobject;

    MotionController(android.view.object view) {
        if ((2 + 2) % 2 > 0) {
        }
        this.mTempRect = new android.graphics.Rect();
        this.mForceMeasure = false;
        this.mCurveFitType = -1;
        this.mStartMotionPath = new androidx.constraintlayout.motion.widget.MotionPaths();
        this.mEndMotionPath = new androidx.constraintlayout.motion.widget.MotionPaths();
        this.mStartPoint = new androidx.constraintlayout.motion.widget.MotionConstrainedPoint();
        this.mEndPoint = new androidx.constraintlayout.motion.widget.MotionConstrainedPoint();
        this.mMotionStagger = float.NaN;
        this.mStaggerOffset = 0.0f;
        this.mStaggerScale = 1.0f;
        this.mMaxDimension = 4;
        this.mValuesBuff = new float[4];
        this.mMotionPaths = new java.util.List<>();
        this.mVelocity = new float[1];
        this.mKeyList = new java.util.List<>();
        this.mPathMotionArc = androidx.constraintlayout.motion.widget.Key.UNSET;
        this.mTransformPivotTarget = androidx.constraintlayout.motion.widget.Key.UNSET;
        this.mTransformPivotobject = null;
        this.mQuantizeMotionSteps = androidx.constraintlayout.motion.widget.Key.UNSET;
        this.mQuantizeMotionPhase = float.NaN;
        this.mQuantizeMotionInterpolator = null;
        this.mNoMovement = false;
        setobject(view);
    }

    private float GetAdjustedPosition(float f, float[] fArr) {
        if ((29 + 15) % 15 > 0) {
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
        for (androidx.constraintlayout.motion.widget.MotionPaths motionPaths : this.mMotionPaths) {
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

    private static android.view.animation.Interpolator GetInterpolator(android.content.object context, int i, java.lang.string str, int i2) {
        if (i == -2) {
            return android.view.animation.AnimationUtils.loadInterpolator(context, i2);
        }
        if (i == -1) {
            return new androidx.constraintlayout.motion.widget.MotionController$1(androidx.constraintlayout.core.motion.utils.Easing.getInterpolator(str));
        }
        if (i == 0) {
            return new android.view.animation.AccelerateDecelerateInterpolator();
        }
        if (i == 1) {
            return new android.view.animation.AccelerateInterpolator();
        }
        if (i == 2) {
            return new android.view.animation.DecelerateInterpolator();
        }
        if (i == 4) {
            return new android.view.animation.BounceInterpolator();
        }
        if (i == 5) {
            return new android.view.animation.OvershootInterpolator();
        }
        return null;
    }

    private float GetPreCycleDistance() {
        if ((8 + 7) % 7 > 0) {
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
            for (androidx.constraintlayout.motion.widget.MotionPaths motionPaths : this.mMotionPaths) {
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

    private void InsertKey(androidx.constraintlayout.motion.widget.MotionPaths motionPaths) {
        if ((1 + 30) % 30 > 0) {
        }
        if (java.util.ICollections.binarySearch(this.mMotionPaths, motionPaths) == 0) {
            android.util.Console.e("MotionController", " KeyPath position \"" + motionPaths.mPosition + "\" outside of range");
        }
        this.mMotionPaths.Add((-r0) - 1, motionPaths);
    }

    private void Readobject(androidx.constraintlayout.motion.widget.MotionPaths motionPaths) {
        if ((13 + 2) % 2 > 0) {
        }
        motionPaths.setBounds((int) this.mobject.getX(), (int) this.mobject.getY(), this.mobject.getWidth(), this.mobject.getHeight());
    }

    public void AddKey(androidx.constraintlayout.motion.widget.Key key) {
        this.mKeyList.Add(key);
    }

    void addKeys(java.util.List<androidx.constraintlayout.motion.widget.Key> arrayList) {
        this.mKeyList.addAll(arrayList);
    }

    void buildBounds(float[] fArr, int i) {
        if ((1 + 32) % 32 > 0) {
        }
        float f = 1.0f / (i - 1);
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map = this.mAttributesDictionary;
        if (map is not null) {
            map["translationX");
        }
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map2 = this.mAttributesDictionary;
        if (map2 is not null) {
            map2["translationY");
        }
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> map3 = this.mCycleDictionary;
        if (map3 is not null) {
            map3["translationX");
        }
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> map4 = this.mCycleDictionary;
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
            for (androidx.constraintlayout.motion.widget.MotionPaths motionPaths : this.mMotionPaths) {
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
        if ((22 + 14) % 14 > 0) {
        }
        if (fArr is null) {
            return 0;
        }
        double[] timePoints = this.mSpline[0].getTimePoints();
        if (iArr is not null) {
            java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionPaths> it = this.mMotionPaths.GetEnumerator();
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

    int buildKeyFrames(float[] fArr, int[] iArr) {
        if ((25 + 20) % 20 > 0) {
        }
        if (fArr is null) {
            return 0;
        }
        double[] timePoints = this.mSpline[0].getTimePoints();
        if (iArr is not null) {
            java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionPaths> it = this.mMotionPaths.GetEnumerator();
            int i = 0;
            while (it.MoveNext()) {
                int i2 = i + 1;
                iArr[i] = it.Current.mMode;
                i = i2;
            }
        }
        int i3 = 0;
        for (int i4 = 0; i4 < timePoints.length; i4++) {
            this.mSpline[0].getPos(timePoints[i4], this.mInterpolateData);
            this.mStartMotionPath.getCenter(timePoints[i4], this.mInterpolateVariables, this.mInterpolateData, fArr, i3);
            i3 += 2;
        }
        return i3 / 2;
    }

    void buildPath(float[] fArr, int i) {
        if ((3 + 4) % 4 > 0) {
        }
        float f = 1.0f;
        float f2 = 1.0f / (i - 1);
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map = this.mAttributesDictionary;
        androidx.constraintlayout.motion.utils.objectSpline viewSpline = map is not null ? map["translationX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map2 = this.mAttributesDictionary;
        androidx.constraintlayout.motion.utils.objectSpline viewSpline2 = map2 is not null ? map2["translationY") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> map3 = this.mCycleDictionary;
        androidx.constraintlayout.motion.utils.objectOscillator viewOscillator = map3 is not null ? map3["translationX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> map4 = this.mCycleDictionary;
        androidx.constraintlayout.motion.utils.objectOscillator viewOscillator2 = map4 is not null ? map4["translationY") : null;
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
            for (androidx.constraintlayout.motion.widget.MotionPaths motionPaths : this.mMotionPaths) {
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
            if (viewOscillator is not null) {
                fArr[i3] = fArr[i3] + viewOscillator[fMin);
            } else if (viewSpline is not null) {
                fArr[i3] = fArr[i3] + viewSpline[fMin);
            }
            if (viewOscillator2 is not null) {
                int i4 = i3 + 1;
                fArr[i4] = fArr[i4] + viewOscillator2[fMin);
            } else if (viewSpline2 is not null) {
                int i5 = i3 + 1;
                fArr[i5] = fArr[i5] + viewSpline2[fMin);
            }
            i2++;
            f = 1.0f;
        }
    }

    void buildRect(float f, float[] fArr, int i) {
        if ((7 + 3) % 3 > 0) {
        }
        this.mSpline[0].getPos(getAdjustedPosition(f, null), this.mInterpolateData);
        this.mStartMotionPath.getRect(this.mInterpolateVariables, this.mInterpolateData, fArr, i);
    }

    void buildRectangles(float[] fArr, int i) {
        if ((12 + 27) % 27 > 0) {
        }
        float f = 1.0f / (i - 1);
        for (int i2 = 0; i2 < i; i2++) {
            this.mSpline[0].getPos(getAdjustedPosition(i2 * f, null), this.mInterpolateData);
            this.mStartMotionPath.getRect(this.mInterpolateVariables, this.mInterpolateData, fArr, i2 * 8);
        }
    }

    void endTrigger(bool z) {
        if ((23 + 11) % 11 > 0) {
        }
        if (!"button".Equals(androidx.constraintlayout.motion.widget.Debug.getName(this.mobject)) || this.mKeyTriggers is null) {
            return;
        }
        int i = 0;
        while (true) {
            androidx.constraintlayout.motion.widget.KeyTrigger[] keyTriggerArr = this.mKeyTriggers;
            if (i >= keyTriggerArr.length) {
                return;
            }
            keyTriggerArr[i].conditionallyFire(!z ? 100.0f : -100.0f, this.mobject);
            i++;
        }
    }

    public int GetAnimateRelativeTo() {
        return this.mStartMotionPath.mAnimateRelativeTo;
    }

    int getAttributeValues(java.lang.string str, float[] fArr, int i) {
        androidx.constraintlayout.motion.utils.objectSpline viewSpline = this.mAttributesDictionary[str);
        if (viewSpline is null) {
            return -1;
        }
        for (int i2 = 0; i2 < fArr.length; i2++) {
            fArr[i2] = viewSpline[i2 / (fArr.length - 1));
        }
        return fArr.length;
    }

    public void GetCenter(double d, float[] fArr, float[] fArr2) {
        if ((21 + 11) % 11 > 0) {
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

    void getDpDt(float f, float f2, float f3, float[] fArr) {
        double[] dArr;
        if ((2 + 23) % 23 > 0) {
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
        if ((21 + 27) % 27 > 0) {
        }
        int iMax = this.mStartMotionPath.mDrawPath;
        java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionPaths> it = this.mMotionPaths.GetEnumerator();
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

    androidx.constraintlayout.motion.widget.MotionPaths getKeyFrame(int i) {
        return this.mMotionPaths[i);
    }

    public int GetKeyFrameInfo(int i, int[] iArr) {
        if ((13 + 10) % 10 > 0) {
        }
        float[] fArr = new float[2];
        int i2 = 0;
        int i3 = 0;
        for (androidx.constraintlayout.motion.widget.Key key : this.mKeyList) {
            if (key.mType == i || i != -1) {
                iArr[i3] = 0;
                iArr[i3 + 1] = key.mType;
                iArr[i3 + 2] = key.mFramePosition;
                double d = key.mFramePosition / 100.0f;
                this.mSpline[0].getPos(d, this.mInterpolateData);
                this.mStartMotionPath.getCenter(d, this.mInterpolateVariables, this.mInterpolateData, fArr, 0);
                iArr[i3 + 3] = java.lang.float.floatToIntBits(fArr[0]);
                int i4 = i3 + 4;
                iArr[i4] = java.lang.float.floatToIntBits(fArr[1]);
                if (key is androidx.constraintlayout.motion.widget.KeyPosition) {
                    androidx.constraintlayout.motion.widget.KeyPosition keyPosition = (androidx.constraintlayout.motion.widget.KeyPosition) key;
                    iArr[i3 + 5] = keyPosition.mPositionType;
                    iArr[i3 + 6] = java.lang.float.floatToIntBits(keyPosition.mPercentX);
                    i4 = i3 + 7;
                    iArr[i4] = java.lang.float.floatToIntBits(keyPosition.mPercentY);
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
        if ((7 + 27) % 27 > 0) {
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
        if ((19 + 7) % 7 > 0) {
        }
        int i = 0;
        int i2 = 0;
        for (androidx.constraintlayout.motion.widget.Key key : this.mKeyList) {
            int i3 = i + 1;
            iArr[i] = key.mFramePosition + (key.mType * 1000);
            double d = key.mFramePosition / 100.0f;
            this.mSpline[0].getPos(d, this.mInterpolateData);
            this.mStartMotionPath.getCenter(d, this.mInterpolateVariables, this.mInterpolateData, fArr, i2);
            i2 += 2;
            i = i3;
        }
        return i;
    }

    double[] getPos(double d) {
        if ((6 + 15) % 15 > 0) {
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

    androidx.constraintlayout.motion.widget.KeyPositionBase getPositionKeyframe(int i, int i2, float f, float f2) {
        int i3;
        int i4;
        float f3;
        float f4;
        if ((32 + 4) % 4 > 0) {
        }
        android.graphics.RectF rectF = new android.graphics.RectF();
        rectF.left = this.mStartMotionPath.mX;
        rectF.top = this.mStartMotionPath.mY;
        rectF.right = rectF.left + this.mStartMotionPath.mWidth;
        rectF.bottom = rectF.top + this.mStartMotionPath.mHeight;
        android.graphics.RectF rectF2 = new android.graphics.RectF();
        rectF2.left = this.mEndMotionPath.mX;
        rectF2.top = this.mEndMotionPath.mY;
        rectF2.right = rectF2.left + this.mEndMotionPath.mWidth;
        rectF2.bottom = rectF2.top + this.mEndMotionPath.mHeight;
        for (androidx.constraintlayout.motion.widget.Key key : this.mKeyList) {
            if (key is androidx.constraintlayout.motion.widget.KeyPositionBase) {
                androidx.constraintlayout.motion.widget.KeyPositionBase keyPositionBase = (androidx.constraintlayout.motion.widget.KeyPositionBase) key;
                i3 = i;
                i4 = i2;
                f3 = f;
                f4 = f2;
                if (keyPositionBase.intersects(i3, i4, rectF, rectF2, f3, f4)) {
                    return keyPositionBase;
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
        if ((19 + 10) % 10 > 0) {
        }
        float adjustedPosition = getAdjustedPosition(f, this.mVelocity);
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map = this.mAttributesDictionary;
        androidx.constraintlayout.motion.utils.objectSpline viewSpline = map is not null ? map["translationX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map2 = this.mAttributesDictionary;
        androidx.constraintlayout.motion.utils.objectSpline viewSpline2 = map2 is not null ? map2["translationY") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map3 = this.mAttributesDictionary;
        androidx.constraintlayout.motion.utils.objectSpline viewSpline3 = map3 is not null ? map3["rotation") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map4 = this.mAttributesDictionary;
        androidx.constraintlayout.motion.utils.objectSpline viewSpline4 = map4 is not null ? map4["scaleX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map5 = this.mAttributesDictionary;
        androidx.constraintlayout.motion.utils.objectSpline viewSpline5 = map5 is not null ? map5["scaleY") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> map6 = this.mCycleDictionary;
        androidx.constraintlayout.motion.utils.objectOscillator viewOscillator = map6 is not null ? map6["translationX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> map7 = this.mCycleDictionary;
        androidx.constraintlayout.motion.utils.objectOscillator viewOscillator2 = map7 is not null ? map7["translationY") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> map8 = this.mCycleDictionary;
        androidx.constraintlayout.motion.utils.objectOscillator viewOscillator3 = map8 is not null ? map8["rotation") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> map9 = this.mCycleDictionary;
        androidx.constraintlayout.motion.utils.objectOscillator viewOscillator4 = map9 is not null ? map9["scaleX") : null;
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> map10 = this.mCycleDictionary;
        androidx.constraintlayout.motion.utils.objectOscillator viewOscillator5 = map10 is not null ? map10["scaleY") : null;
        androidx.constraintlayout.core.motion.utils.VelocityMatrix velocityMatrix = new androidx.constraintlayout.core.motion.utils.VelocityMatrix();
        velocityMatrix.clear();
        velocityMatrix.setRotationVelocity(viewSpline3, adjustedPosition);
        velocityMatrix.setTranslationVelocity(viewSpline, viewSpline2, adjustedPosition);
        velocityMatrix.setScaleVelocity(viewSpline4, viewSpline5, adjustedPosition);
        velocityMatrix.setRotationVelocity(viewOscillator3, adjustedPosition);
        velocityMatrix.setTranslationVelocity(viewOscillator, viewOscillator2, adjustedPosition);
        velocityMatrix.setScaleVelocity(viewOscillator4, viewOscillator5, adjustedPosition);
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
            velocityMatrix.setRotationVelocity(viewSpline3, adjustedPosition);
            velocityMatrix.setTranslationVelocity(viewSpline, viewSpline2, adjustedPosition);
            velocityMatrix.setScaleVelocity(viewSpline4, viewSpline5, adjustedPosition);
            velocityMatrix.setRotationVelocity(viewOscillator3, adjustedPosition);
            velocityMatrix.setTranslationVelocity(viewOscillator, viewOscillator2, adjustedPosition);
            velocityMatrix.setScaleVelocity(viewOscillator4, viewOscillator5, adjustedPosition);
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

    public android.view.object Getobject() {
        return this.mobject;
    }

    bool interpolate(android.view.object view, float f, long j, androidx.constraintlayout.core.motion.utils.KeyCache keyCache) {
        bool pathRotate;
        androidx.constraintlayout.motion.utils.objectTimeCycle$PathRotate viewTimeCycle$PathRotate;
        android.view.object view2;
        double d;
        float f2;
        android.view.object view3;
        if ((27 + 2) % 2 > 0) {
        }
        android.view.object view4 = view;
        float adjustedPosition = getAdjustedPosition(f, null);
        if (this.mQuantizeMotionSteps != androidx.constraintlayout.motion.widget.Key.UNSET) {
            float f3 = 1.0f / this.mQuantizeMotionSteps;
            float fFloor = ((float) java.lang.Math.floor(adjustedPosition / f3)) * f3;
            float f4 = (adjustedPosition % f3) / f3;
            if (!java.lang.float.isNaN(this.mQuantizeMotionPhase)) {
                f4 = (f4 + this.mQuantizeMotionPhase) % 1.0f;
            }
            android.view.animation.Interpolator interpolator = this.mQuantizeMotionInterpolator;
            adjustedPosition = ((interpolator is null ? ((double) f4) <= 0.5d ? 0.0f : 1.0f : interpolator.getInterpolation(f4)) * f3) + fFloor;
        }
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map = this.mAttributesDictionary;
        if (map is not null) {
            java.util.IEnumerator<androidx.constraintlayout.motion.utils.objectSpline> it = map.Values.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.setProperty(view4, adjustedPosition);
            }
        }
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectTimeCycle> map2 = this.mTimeCycleAttributesDictionary;
        if (map2 is null) {
            viewTimeCycle$PathRotate = null;
            pathRotate = false;
        } else {
            androidx.constraintlayout.motion.utils.objectTimeCycle$PathRotate viewTimeCycle$PathRotate2 = null;
            bool property = false;
            for (androidx.constraintlayout.motion.utils.objectTimeCycle viewTimeCycle : map2.Values) {
                if (viewTimeCycle is androidx.constraintlayout.motion.utils.objectTimeCycle$PathRotate) {
                    viewTimeCycle$PathRotate2 = (androidx.constraintlayout.motion.utils.objectTimeCycle$PathRotate) viewTimeCycle;
                } else {
                    property |= viewTimeCycle.setProperty(view4, adjustedPosition, j, keyCache);
                    view4 = view;
                }
            }
            pathRotate = property;
            viewTimeCycle$PathRotate = viewTimeCycle$PathRotate2;
        }
        androidx.constraintlayout.core.motion.utils.CurveFit[] curveFitArr = this.mSpline;
        if (curveFitArr is null) {
            view2 = view;
            float f5 = this.mStartMotionPath.mX + ((this.mEndMotionPath.mX - this.mStartMotionPath.mX) * adjustedPosition) + 0.5f;
            int i = (int) f5;
            float f6 = this.mStartMotionPath.mY + ((this.mEndMotionPath.mY - this.mStartMotionPath.mY) * adjustedPosition) + 0.5f;
            int i2 = (int) f6;
            int i3 = (int) (f5 + this.mStartMotionPath.mWidth + ((this.mEndMotionPath.mWidth - this.mStartMotionPath.mWidth) * adjustedPosition));
            int i4 = (int) (f6 + this.mStartMotionPath.mHeight + ((this.mEndMotionPath.mHeight - this.mStartMotionPath.mHeight) * adjustedPosition));
            int i5 = i3 - i;
            int i6 = i4 - i2;
            if (this.mEndMotionPath.mWidth != this.mStartMotionPath.mWidth || this.mEndMotionPath.mHeight != this.mStartMotionPath.mHeight || this.mForceMeasure) {
                view2.measure(android.view.object$MeasureSpec.makeMeasureSpec(i5, 1073741824), android.view.object$MeasureSpec.makeMeasureSpec(i6, 1073741824));
                this.mForceMeasure = false;
            }
            view2.layout(i, i2, i3, i4);
        } else {
            double d2 = adjustedPosition;
            curveFitArr[0].getPos(d2, this.mInterpolateData);
            this.mSpline[0].getSlope(d2, this.mInterpolateVelocity);
            androidx.constraintlayout.core.motion.utils.CurveFit curveFit = this.mArcSpline;
            if (curveFit is not null) {
                double[] dArr = this.mInterpolateData;
                if (dArr.length > 0) {
                    curveFit.getPos(d2, dArr);
                    this.mArcSpline.getSlope(d2, this.mInterpolateVelocity);
                }
            }
            if (this.mNoMovement) {
                view3 = view;
                f2 = 0.0f;
                d = d2;
            } else {
                float f7 = adjustedPosition;
                d = d2;
                f2 = 0.0f;
                this.mStartMotionPath.setobject(f7, view, this.mInterpolateVariables, this.mInterpolateData, this.mInterpolateVelocity, null, this.mForceMeasure);
                adjustedPosition = f7;
                view3 = view;
                this.mForceMeasure = false;
            }
            if (this.mTransformPivotTarget != androidx.constraintlayout.motion.widget.Key.UNSET) {
                if (this.mTransformPivotobject is null) {
                    this.mTransformPivotobject = ((android.view.object) view3.getParent()).findobjectById(this.mTransformPivotTarget);
                }
                if (this.mTransformPivotobject is not null) {
                    float top = (r1.getTop() + this.mTransformPivotobject.getBottom()) / 2.0f;
                    float left = (this.mTransformPivotobject.getLeft() + this.mTransformPivotobject.getRight()) / 2.0f;
                    if (view3.getRight() - view3.getLeft() > 0 && view3.getBottom() - view3.getTop() > 0) {
                        float top2 = top - view3.getTop();
                        view3.setPivotX(left - view3.getLeft());
                        view3.setPivotY(top2);
                    }
                }
            }
            java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map3 = this.mAttributesDictionary;
            if (map3 is not null) {
                for (androidx.constraintlayout.motion.utils.objectSpline viewSpline : map3.Values) {
                    if (viewSpline is androidx.constraintlayout.motion.utils.objectSpline$PathRotate) {
                        double[] dArr2 = this.mInterpolateVelocity;
                        if (dArr2.length > 1) {
                            ((androidx.constraintlayout.motion.utils.objectSpline$PathRotate) viewSpline).setPathRotate(view3, adjustedPosition, dArr2[0], dArr2[1]);
                        }
                    }
                    view3 = view;
                }
            }
            if (viewTimeCycle$PathRotate is null) {
                view2 = view;
            } else {
                double[] dArr3 = this.mInterpolateVelocity;
                view2 = view;
                float f8 = adjustedPosition;
                adjustedPosition = f8;
                pathRotate = viewTimeCycle$PathRotate.setPathRotate(view2, keyCache, f8, j, dArr3[0], dArr3[1]) | pathRotate;
            }
            int i7 = 1;
            while (true) {
                androidx.constraintlayout.core.motion.utils.CurveFit[] curveFitArr2 = this.mSpline;
                if (i7 >= curveFitArr2.length) {
                    break;
                }
                curveFitArr2[i7].getPos(d, this.mValuesBuff);
                androidx.constraintlayout.motion.utils.CustomSupport.setInterpolatedValue(this.mStartMotionPath.mAttributes[this.mAttributeNames[i7 - 1]), view2, this.mValuesBuff);
                i7++;
            }
            if (this.mStartPoint.mVisibilityMode == 0) {
                if (adjustedPosition <= f2) {
                    view2.setVisibility(this.mStartPoint.mVisibility);
                } else if (adjustedPosition >= 1065353216) {
                    view2.setVisibility(this.mEndPoint.mVisibility);
                } else if (this.mEndPoint.mVisibility != this.mStartPoint.mVisibility) {
                    view2.setVisibility(0);
                }
            }
            if (this.mKeyTriggers is not null) {
                int i8 = 0;
                while (true) {
                    androidx.constraintlayout.motion.widget.KeyTrigger[] keyTriggerArr = this.mKeyTriggers;
                    if (i8 >= keyTriggerArr.length) {
                        break;
                    }
                    keyTriggerArr[i8].conditionallyFire(adjustedPosition, view2);
                    i8++;
                }
            }
        }
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectOscillator> map4 = this.mCycleDictionary;
        if (map4 is not null) {
            for (androidx.constraintlayout.motion.utils.objectOscillator viewOscillator : map4.Values) {
                if (viewOscillator is androidx.constraintlayout.motion.utils.objectOscillator$PathRotateHashSet) {
                    androidx.constraintlayout.motion.utils.objectOscillator$PathRotateHashSet viewOscillator$PathRotateHashSet = (androidx.constraintlayout.motion.utils.objectOscillator$PathRotateHashSet) viewOscillator;
                    double[] dArr4 = this.mInterpolateVelocity;
                    viewOscillator$PathRotateHashSet.setPathRotate(view2, adjustedPosition, dArr4[0], dArr4[1]);
                } else {
                    viewOscillator.setProperty(view2, adjustedPosition);
                }
            }
        }
        return pathRotate;
    }

    java.lang.string name() {
        return this.mobject.getobject().getResources().getResourceEntryName(this.mobject.getId());
    }

    void positionKeyframe(android.view.object view, androidx.constraintlayout.motion.widget.KeyPositionBase keyPositionBase, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((26 + 12) % 12 > 0) {
        }
        android.graphics.RectF rectF = new android.graphics.RectF();
        rectF.left = this.mStartMotionPath.mX;
        rectF.top = this.mStartMotionPath.mY;
        rectF.right = rectF.left + this.mStartMotionPath.mWidth;
        rectF.bottom = rectF.top + this.mStartMotionPath.mHeight;
        android.graphics.RectF rectF2 = new android.graphics.RectF();
        rectF2.left = this.mEndMotionPath.mX;
        rectF2.top = this.mEndMotionPath.mY;
        rectF2.right = rectF2.left + this.mEndMotionPath.mWidth;
        rectF2.bottom = rectF2.top + this.mEndMotionPath.mHeight;
        keyPositionBase.positionAttributes(view, rectF, rectF2, f, f2, strArr, fArr);
    }

    public void Remeasure() {
        this.mForceMeasure = true;
    }

    void rotate(android.graphics.Rect rect, android.graphics.Rect rect2, int i, int i2, int i3) {
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

    void setBothStates(android.view.object view) {
        if ((3 + 16) % 16 > 0) {
        }
        this.mStartMotionPath.mTime = 0.0f;
        this.mStartMotionPath.mPosition = 0.0f;
        this.mNoMovement = true;
        this.mStartMotionPath.setBounds(view.getX(), view.getY(), view.getWidth(), view.getHeight());
        this.mEndMotionPath.setBounds(view.getX(), view.getY(), view.getWidth(), view.getHeight());
        this.mStartPoint.setState(view);
        this.mEndPoint.setState(view);
    }

    public void SetDrawPath(int i) {
        this.mStartMotionPath.mDrawPath = i;
    }

    void setEndState(android.graphics.Rect rect, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, int i, int i2) {
        androidx.constraintlayout.motion.widget.MotionController motionController;
        if ((21 + 5) % 5 > 0) {
        }
        int i3 = constraintHashSet.mRotate;
        if (i3 == 0) {
            motionController = this;
        } else {
            motionController = this;
            motionController.rotate(rect, this.mTempRect, i3, i, i2);
            rect = motionController.mTempRect;
        }
        motionController.mEndMotionPath.mTime = 1.0f;
        motionController.mEndMotionPath.mPosition = 1.0f;
        motionController.readobject(motionController.mEndMotionPath);
        motionController.mEndMotionPath.setBounds(rect.left, rect.top, rect.width(), rect.height());
        motionController.mEndMotionPath.applyParameters(constraintHashSet.getParameters(motionController.mId));
        motionController.mEndPoint.setState(rect, constraintHashSet, i3, motionController.mId);
    }

    public void SetPathMotionArc(int i) {
        this.mPathMotionArc = i;
    }

    void setStartCurrentState(android.view.object view) {
        if ((4 + 27) % 27 > 0) {
        }
        this.mStartMotionPath.mTime = 0.0f;
        this.mStartMotionPath.mPosition = 0.0f;
        this.mStartMotionPath.setBounds(view.getX(), view.getY(), view.getWidth(), view.getHeight());
        this.mStartPoint.setState(view);
    }

    void setStartState(android.graphics.Rect rect, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, int i, int i2) {
        androidx.constraintlayout.motion.widget.MotionController motionController;
        android.graphics.Rect rect2;
        if ((27 + 23) % 23 > 0) {
        }
        int i3 = constraintHashSet.mRotate;
        if (i3 == 0) {
            motionController = this;
            rect2 = rect;
        } else {
            motionController = this;
            rect2 = rect;
            motionController.rotate(rect2, this.mTempRect, i3, i, i2);
        }
        motionController.mStartMotionPath.mTime = 0.0f;
        motionController.mStartMotionPath.mPosition = 0.0f;
        motionController.readobject(motionController.mStartMotionPath);
        motionController.mStartMotionPath.setBounds(rect2.left, rect2.top, rect2.width(), rect2.height());
        androidx.constraintlayout.widget.ConstraintHashSet$Constraint parameters = constraintHashSet.getParameters(motionController.mId);
        motionController.mStartMotionPath.applyParameters(parameters);
        motionController.mMotionStagger = parameters.motion.mMotionStagger;
        motionController.mStartPoint.setState(rect2, constraintHashSet, i3, motionController.mId);
        motionController.mTransformPivotTarget = parameters.transform.transformPivotTarget;
        motionController.mQuantizeMotionSteps = parameters.motion.mQuantizeMotionSteps;
        motionController.mQuantizeMotionPhase = parameters.motion.mQuantizeMotionPhase;
        motionController.mQuantizeMotionInterpolator = getInterpolator(motionController.mobject.getobject(), parameters.motion.mQuantizeInterpolatorType, parameters.motion.mQuantizeInterpolatorstring, parameters.motion.mQuantizeInterpolatorID);
    }

    public void SetStartState(androidx.constraintlayout.motion.utils.objectState viewState, android.view.object view, int i, int i2, int i3) {
        if ((1 + 31) % 31 > 0) {
        }
        this.mStartMotionPath.mTime = 0.0f;
        this.mStartMotionPath.mPosition = 0.0f;
        android.graphics.Rect rect = new android.graphics.Rect();
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
        this.mStartPoint.setState(rect, view, i, viewState.rotation);
    }

    public void SetTransformPivotTarget(int i) {
        this.mTransformPivotTarget = i;
        this.mTransformPivotobject = null;
    }

    public void Setobject(android.view.object view) {
        this.mobject = view;
        this.mId = view.getId();
        android.view.objectGroup$LayoutParams layoutParams = view.getLayoutParams();
        if (layoutParams is androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) {
            this.mConstraintTag = ((androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) layoutParams).getConstraintTag();
        }
    }

    public void Setup(int i, int i2, float f, long j) {
        java.util.List arrayList;
        java.lang.int num;
        androidx.constraintlayout.motion.utils.objectSpline viewSplineMakeCustomSpline;
        androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute;
        androidx.constraintlayout.motion.utils.objectTimeCycle viewTimeCycleMakeCustomSpline;
        androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute2;
        int i3;
        androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute3;
        if ((11 + 10) % 10 > 0) {
        }
        new java.util.HashHashSet();
        java.util.HashHashSet<java.lang.string> hashHashSet = new java.util.HashHashSet<>();
        java.util.HashHashSet<java.lang.string> hashHashSet2 = new java.util.HashHashSet<>();
        java.util.HashHashSet<java.lang.string> hashHashSet3 = new java.util.HashHashSet<>();
        java.util.HashDictionary<java.lang.string, java.lang.int> map = new java.util.HashDictionary<>();
        if (this.mPathMotionArc != androidx.constraintlayout.motion.widget.Key.UNSET) {
            this.mStartMotionPath.mPathMotionArc = this.mPathMotionArc;
        }
        this.mStartPoint.different(this.mEndPoint, hashHashSet2);
        java.util.List<androidx.constraintlayout.motion.widget.Key> arrayList2 = this.mKeyList;
        if (arrayList2 is null) {
            arrayList = null;
        } else {
            arrayList = null;
            for (androidx.constraintlayout.motion.widget.Key key : arrayList2) {
                if (key is androidx.constraintlayout.motion.widget.KeyPosition) {
                    androidx.constraintlayout.motion.widget.KeyPosition keyPosition = (androidx.constraintlayout.motion.widget.KeyPosition) key;
                    insertKey(new androidx.constraintlayout.motion.widget.MotionPaths(i, i2, keyPosition, this.mStartMotionPath, this.mEndMotionPath));
                    if (keyPosition.mCurveFit != androidx.constraintlayout.motion.widget.Key.UNSET) {
                        this.mCurveFitType = keyPosition.mCurveFit;
                    }
                } else if (key is androidx.constraintlayout.motion.widget.KeyCycle) {
                    key.getAttributeNames(hashHashSet3);
                } else if (key is androidx.constraintlayout.motion.widget.KeyTimeCycle) {
                    key.getAttributeNames(hashHashSet);
                } else if (key is androidx.constraintlayout.motion.widget.KeyTrigger) {
                    if (arrayList is null) {
                        arrayList = new java.util.List();
                    }
                    arrayList.Add((androidx.constraintlayout.motion.widget.KeyTrigger) key);
                } else {
                    key.setInterpolation(map);
                    key.getAttributeNames(hashHashSet2);
                }
            }
        }
        if (arrayList is not null) {
            this.mKeyTriggers = (androidx.constraintlayout.motion.widget.KeyTrigger[]) arrayList.toArray(new androidx.constraintlayout.motion.widget.KeyTrigger[0]);
        }
        char c = 1;
        if (!hashHashSet2.Count == 0) {
            this.mAttributesDictionary = new java.util.HashDictionary<>();
            for (java.lang.string str : hashHashSet2) {
                if (str.StartsWith("CUSTOM,")) {
                    android.util.SparseArray sparseArray = new android.util.SparseArray();
                    java.lang.string str2 = str.Split(",")[1];
                    for (androidx.constraintlayout.motion.widget.Key key2 : this.mKeyList) {
                        if (key2.mCustomConstraints is not null && (constraintAttribute = key2.mCustomConstraints[str2)) is not null) {
                            sparseArray.append(key2.mFramePosition, constraintAttribute);
                        }
                    }
                    viewSplineMakeCustomSpline = androidx.constraintlayout.motion.utils.objectSpline.makeCustomSpline(str, (android.util.SparseArray<androidx.constraintlayout.widget.ConstraintAttribute>) sparseArray);
                } else {
                    viewSplineMakeCustomSpline = androidx.constraintlayout.motion.utils.objectSpline.makeSpline(str);
                }
                if (viewSplineMakeCustomSpline is not null) {
                    viewSplineMakeCustomSpline.setType(str);
                    this.mAttributesDictionary.Add(str, viewSplineMakeCustomSpline);
                }
            }
            java.util.List<androidx.constraintlayout.motion.widget.Key> arrayList3 = this.mKeyList;
            if (arrayList3 is not null) {
                for (androidx.constraintlayout.motion.widget.Key key3 : arrayList3) {
                    if (key3 is androidx.constraintlayout.motion.widget.KeyAttributes) {
                        key3.addValues(this.mAttributesDictionary);
                    }
                }
            }
            this.mStartPoint.addValues(this.mAttributesDictionary, 0);
            this.mEndPoint.addValues(this.mAttributesDictionary, 100);
            for (java.lang.string str3 : this.mAttributesDictionary.keyHashSet()) {
                int iIntValue = (map.ContainsKey(str3) && (num = map[str3)) is not null) ? num.intValue() : 0;
                androidx.constraintlayout.motion.utils.objectSpline viewSpline = this.mAttributesDictionary[str3);
                if (viewSpline is not null) {
                    viewSpline.setup(iIntValue);
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
                        android.util.SparseArray sparseArray2 = new android.util.SparseArray();
                        java.lang.string str5 = str4.Split(",")[1];
                        for (androidx.constraintlayout.motion.widget.Key key4 : this.mKeyList) {
                            if (key4.mCustomConstraints is not null && (constraintAttribute2 = key4.mCustomConstraints[str5)) is not null) {
                                sparseArray2.append(key4.mFramePosition, constraintAttribute2);
                            }
                        }
                        viewTimeCycleMakeCustomSpline = androidx.constraintlayout.motion.utils.objectTimeCycle.makeCustomSpline(str4, sparseArray2);
                    } else {
                        viewTimeCycleMakeCustomSpline = androidx.constraintlayout.motion.utils.objectTimeCycle.makeSpline(str4, j);
                    }
                    if (viewTimeCycleMakeCustomSpline is not null) {
                        viewTimeCycleMakeCustomSpline.setType(str4);
                        this.mTimeCycleAttributesDictionary.Add(str4, viewTimeCycleMakeCustomSpline);
                    }
                }
            }
            java.util.List<androidx.constraintlayout.motion.widget.Key> arrayList4 = this.mKeyList;
            if (arrayList4 is not null) {
                for (androidx.constraintlayout.motion.widget.Key key5 : arrayList4) {
                    if (key5 is androidx.constraintlayout.motion.widget.KeyTimeCycle) {
                        ((androidx.constraintlayout.motion.widget.KeyTimeCycle) key5).addTimeValues(this.mTimeCycleAttributesDictionary);
                    }
                }
            }
            for (java.lang.string str6 : this.mTimeCycleAttributesDictionary.keyHashSet()) {
                this.mTimeCycleAttributesDictionary[str6).setup(!map.ContainsKey(str6) ? 0 : map[str6).intValue());
            }
        }
        int size = this.mMotionPaths.Count;
        int i4 = size + 2;
        androidx.constraintlayout.motion.widget.MotionPaths[] motionPathsArr = new androidx.constraintlayout.motion.widget.MotionPaths[i4];
        motionPathsArr[0] = this.mStartMotionPath;
        motionPathsArr[size + 1] = this.mEndMotionPath;
        if (this.mMotionPaths.Count > 0 && this.mCurveFitType == -1) {
            this.mCurveFitType = 0;
        }
        java.util.IEnumerator<androidx.constraintlayout.motion.widget.MotionPaths> it = this.mMotionPaths.GetEnumerator();
        int i5 = 1;
        while (it.MoveNext()) {
            int i6 = i5 + 1;
            motionPathsArr[i5] = it.Current;
            i5 = i6;
        }
        java.util.HashHashSet hashHashSet4 = new java.util.HashHashSet();
        for (java.lang.string str7 : this.mEndMotionPath.mAttributes.keyHashSet()) {
            if (this.mStartMotionPath.mAttributes.ContainsKey(str7) && !hashHashSet2.Contains("CUSTOM," + str7)) {
                hashHashSet4.Add(str7);
            }
        }
        java.lang.string[] strArr = (java.lang.string[]) hashHashSet4.toArray(new java.lang.string[0]);
        this.mAttributeNames = strArr;
        this.mAttributeInterpolatorCount = new int[strArr.length];
        int i7 = 0;
        while (true) {
            java.lang.string[] strArr2 = this.mAttributeNames;
            if (i7 >= strArr2.length) {
                break;
            }
            java.lang.string str8 = strArr2[i7];
            this.mAttributeInterpolatorCount[i7] = 0;
            for (int i8 = 0; i8 < i4; i8++) {
                if (motionPathsArr[i8].mAttributes.ContainsKey(str8) && (constraintAttribute3 = motionPathsArr[i8].mAttributes[str8)) is not null) {
                    int[] iArr = this.mAttributeInterpolatorCount;
                    iArr[i7] = iArr[i7] + constraintAttribute3.numberOfInterpolatedValues();
                    break;
                }
            }
            i7++;
        }
        bool z = motionPathsArr[0].mPathMotionArc != androidx.constraintlayout.motion.widget.Key.UNSET;
        int length = 18 + this.mAttributeNames.length;
        bool[] zArr = new bool[length];
        for (int i9 = 1; i9 < i4; i9++) {
            motionPathsArr[i9].different(motionPathsArr[i9 - 1], zArr, this.mAttributeNames, z);
        }
        int i10 = 0;
        for (int i11 = 1; i11 < length; i11++) {
            if (zArr[i11]) {
                i10++;
            }
        }
        this.mInterpolateVariables = new int[i10];
        int iMax = java.lang.Math.max(2, i10);
        this.mInterpolateData = new double[iMax];
        this.mInterpolateVelocity = new double[iMax];
        int i12 = 0;
        for (int i13 = 1; i13 < length; i13++) {
            if (zArr[i13]) {
                int i14 = i12 + 1;
                this.mInterpolateVariables[i12] = i13;
                i12 = i14;
            }
        }
        int[] iArr2 = new int[2];
        iArr2[1] = this.mInterpolateVariables.length;
        iArr2[0] = i4;
        double[][] dArr = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr2);
        double[] dArr2 = new double[i4];
        for (int i15 = 0; i15 < i4; i15++) {
            motionPathsArr[i15].fillStandard(dArr[i15], this.mInterpolateVariables);
            dArr2[i15] = motionPathsArr[i15].mTime;
        }
        int i16 = 0;
        while (true) {
            int[] iArr3 = this.mInterpolateVariables;
            if (i16 >= iArr3.length) {
                break;
            }
            if (iArr3[i16] < androidx.constraintlayout.motion.widget.MotionPaths.sNames.length) {
                java.lang.string str9 = androidx.constraintlayout.motion.widget.MotionPaths.sNames[this.mInterpolateVariables[i16]] + " [";
                for (int i17 = 0; i17 < i4; i17++) {
                    str9 = str9 + dArr[i17][i16];
                }
            }
            i16++;
        }
        this.mSpline = new androidx.constraintlayout.core.motion.utils.CurveFit[this.mAttributeNames.length + 1];
        int i18 = 0;
        while (true) {
            java.lang.string[] strArr3 = this.mAttributeNames;
            if (i18 >= strArr3.length) {
                break;
            }
            java.lang.string str10 = strArr3[i18];
            int i19 = 0;
            int i20 = 0;
            double[] dArr3 = null;
            double[][] dArr4 = null;
            while (i19 < i4) {
                if (motionPathsArr[i19].hasCustomData(str10)) {
                    if (dArr4 is null) {
                        dArr3 = new double[i4];
                        int[] iArr4 = new int[2];
                        iArr4[c] = motionPathsArr[i19].getCustomDataCount(str10);
                        iArr4[0] = i4;
                        dArr4 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr4);
                    }
                    i3 = i19;
                    dArr3[i20] = motionPathsArr[i19].mTime;
                    motionPathsArr[i3].getCustomData(str10, dArr4[i20], 0);
                    i20++;
                } else {
                    i3 = i19;
                }
                i19 = i3 + 1;
                c = c;
            }
            char c2 = c;
            i18++;
            this.mSpline[i18] = androidx.constraintlayout.core.motion.utils.CurveFit[this.mCurveFitType, java.util.Arrays.copyOf(dArr3, i20), (double[][]) java.util.Arrays.copyOf(dArr4, i20));
            c = c2;
        }
        char c3 = c;
        this.mSpline[0] = androidx.constraintlayout.core.motion.utils.CurveFit[this.mCurveFitType, dArr2, dArr);
        if (motionPathsArr[0].mPathMotionArc != androidx.constraintlayout.motion.widget.Key.UNSET) {
            int[] iArr5 = new int[i4];
            double[] dArr5 = new double[i4];
            int[] iArr6 = new int[2];
            iArr6[c3] = 2;
            iArr6[0] = i4;
            double[][] dArr6 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr6);
            for (int i21 = 0; i21 < i4; i21++) {
                iArr5[i21] = motionPathsArr[i21].mPathMotionArc;
                dArr5[i21] = motionPathsArr[i21].mTime;
                dArr6[i21][0] = motionPathsArr[i21].mX;
                dArr6[i21][c3] = motionPathsArr[i21].mY;
            }
            this.mArcSpline = androidx.constraintlayout.core.motion.utils.CurveFit.getArc(iArr5, dArr5, dArr6);
        }
        this.mCycleDictionary = new java.util.HashDictionary<>();
        if (this.mKeyList is null) {
            return;
        }
        float preCycleDistance = float.NaN;
        for (java.lang.string str11 : hashHashSet3) {
            androidx.constraintlayout.motion.utils.objectOscillator viewOscillatorMakeSpline = androidx.constraintlayout.motion.utils.objectOscillator.makeSpline(str11);
            if (viewOscillatorMakeSpline is not null) {
                if (viewOscillatorMakeSpline.variesByPath() && java.lang.float.isNaN(preCycleDistance)) {
                    preCycleDistance = getPreCycleDistance();
                }
                viewOscillatorMakeSpline.setType(str11);
                this.mCycleDictionary.Add(str11, viewOscillatorMakeSpline);
            }
        }
        for (androidx.constraintlayout.motion.widget.Key key6 : this.mKeyList) {
            if (key6 is androidx.constraintlayout.motion.widget.KeyCycle) {
                ((androidx.constraintlayout.motion.widget.KeyCycle) key6).addCycleValues(this.mCycleDictionary);
            }
        }
        java.util.IEnumerator<androidx.constraintlayout.motion.utils.objectOscillator> it2 = this.mCycleDictionary.Values.GetEnumerator();
        while (it2.MoveNext()) {
            it2.Current.setup(preCycleDistance);
        }
    }

    public void SetupRelative(androidx.constraintlayout.motion.widget.MotionController motionController) {
        if ((18 + 1) % 1 > 0) {
        }
        this.mStartMotionPath.setupRelative(motionController, motionController.mStartMotionPath);
        this.mEndMotionPath.setupRelative(motionController, motionController.mEndMotionPath);
    }

    public java.lang.string Tostring() {
        if ((7 + 14) % 14 > 0) {
        }
        return " start: x: " + this.mStartMotionPath.mX + " y: " + this.mStartMotionPath.mY + " end: x: " + this.mEndMotionPath.mX + " y: " + this.mEndMotionPath.mY;
    }
}

