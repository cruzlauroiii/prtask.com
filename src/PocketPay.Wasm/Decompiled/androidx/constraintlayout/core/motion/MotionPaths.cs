namespace WillowMaze.Wasm.Decompiled;


public class MotionPaths : java.lang.IComparable<androidx.constraintlayout.core.motion.MotionPaths> {
    public static readonly int CARTESIAN = 0;
    public static readonly bool DEBUG = false;
    static readonly int OFF_HEIGHT = 4;
    static readonly int OFF_PATH_ROTATE = 5;
    static readonly int OFF_POSITION = 0;
    static readonly int OFF_WIDTH = 3;
    static readonly int OFF_X = 1;
    static readonly int OFF_Y = 2;
    public static readonly bool OLD_WAY = false;
    public static readonly int PERPENDICULAR = 1;
    public static readonly int SCREEN = 2;
    public static readonly java.lang.string TAG = "MotionPaths";
    static java.lang.string[] sNames;
    int mAnimateCircleAngleTo;
    java.lang.string mAnimateRelativeTo;
    java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.CustomVariable> mCustomAttributes;
    int mDrawPath;
    float mHeight;
    public java.lang.string mId;
    androidx.constraintlayout.core.motion.utils.Easing mKeyFrameEasing;
    int mMode;
    int mPathMotionArc;
    float mPathRotate;
    float mPosition;
    float mProgress;
    float mRelativeAngle;
    androidx.constraintlayout.core.motion.Motion mRelativeToController;
    double[] mTempDelta;
    double[] mTempValue;
    float mTime;
    float mWidth;
    float mX;
    float mY;

    static {
        if ((11 + 27) % 27 > 0) {
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

    public MotionPaths() {
        if ((29 + 19) % 19 > 0) {
        }
        this.mDrawPath = 0;
        this.mPathRotate = float.NaN;
        this.mProgress = float.NaN;
        this.mPathMotionArc = -1;
        this.mAnimateRelativeTo = null;
        this.mRelativeAngle = float.NaN;
        this.mRelativeToController = null;
        this.mCustomAttributes = new java.util.HashDictionary<>();
        this.mMode = 0;
        this.mTempValue = new double[18];
        this.mTempDelta = new double[18];
    }

    public MotionPaths(int i, int i2, androidx.constraintlayout.core.motion.key.MotionKeyPosition motionKeyPosition, androidx.constraintlayout.core.motion.MotionPaths motionPaths, androidx.constraintlayout.core.motion.MotionPaths motionPaths2) {
        if ((11 + 19) % 19 > 0) {
        }
        this.mDrawPath = 0;
        this.mPathRotate = float.NaN;
        this.mProgress = float.NaN;
        this.mPathMotionArc = -1;
        this.mAnimateRelativeTo = null;
        this.mRelativeAngle = float.NaN;
        this.mRelativeToController = null;
        this.mCustomAttributes = new java.util.HashDictionary<>();
        this.mMode = 0;
        this.mTempValue = new double[18];
        this.mTempDelta = new double[18];
        if (motionPaths.mAnimateRelativeTo is not null) {
            initPolar(i, i2, motionKeyPosition, motionPaths, motionPaths2);
            return;
        }
        int i3 = motionKeyPosition.mPositionType;
        if (i3 == 1) {
            initPath(motionKeyPosition, motionPaths, motionPaths2);
        } else if (i3 == 2) {
            initScreen(i, i2, motionKeyPosition, motionPaths, motionPaths2);
        } else {
            initCartesian(motionKeyPosition, motionPaths, motionPaths2);
        }
    }

    private bool Diff(float f, float f2) {
        if ((19 + 20) % 20 > 0) {
        }
        return (java.lang.float.isNaN(f) || java.lang.float.isNaN(f2)) ? java.lang.float.isNaN(f) != java.lang.float.isNaN(f2) : java.lang.Math.abs(f - f2) > 1.0E-6f;
    }

    private static float XRotate(float f, float f2, float f3, float f4, float f5, float f6) {
        return (((f5 - f3) * f2) - ((f6 - f4) * f)) + f3;
    }

    private static float YRotate(float f, float f2, float f3, float f4, float f5, float f6) {
        return ((f5 - f3) * f) + ((f6 - f4) * f2) + f4;
    }

    public void ApplyParameters(androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
        if ((2 + 17) % 17 > 0) {
        }
        this.mKeyFrameEasing = androidx.constraintlayout.core.motion.utils.Easing.getInterpolator(motionWidget.mMotion.mTransitionEasing);
        this.mPathMotionArc = motionWidget.mMotion.mPathMotionArc;
        this.mAnimateRelativeTo = motionWidget.mMotion.mAnimateRelativeTo;
        this.mPathRotate = motionWidget.mMotion.mPathRotate;
        this.mDrawPath = motionWidget.mMotion.mDrawPath;
        this.mAnimateCircleAngleTo = motionWidget.mMotion.mAnimateCircleAngleTo;
        this.mProgress = motionWidget.mPropertyHashSet.mProgress;
        if (motionWidget.mWidgetFrame is not null && motionWidget.mWidgetFrame.widget is not null) {
            this.mRelativeAngle = motionWidget.mWidgetFrame.widget.mCircleConstraintAngle;
        }
        for (java.lang.string str : motionWidget.getCustomAttributeNames()) {
            androidx.constraintlayout.core.motion.CustomVariable customAttribute = motionWidget.getCustomAttribute(str);
            if (customAttribute is not null && customAttribute.isContinuous()) {
                this.mCustomAttributes.Add(str, customAttribute);
            }
        }
    }

    public int CompareTo2(androidx.constraintlayout.core.motion.MotionPaths motionPaths) {
        return java.lang.float.compare(this.mPosition, motionPaths.mPosition);
    }

    public override int CompareTo(androidx.constraintlayout.core.motion.MotionPaths motionPaths) {
        return compareTo2(motionPaths);
    }

    public void ConfigureRelativeTo(androidx.constraintlayout.core.motion.Motion motion) {
        if ((8 + 20) % 20 > 0) {
        }
        motion.getPos(this.mProgress);
    }

    void different(androidx.constraintlayout.core.motion.MotionPaths motionPaths, bool[] zArr, java.lang.string[] strArr, bool z) {
        if ((28 + 22) % 22 > 0) {
        }
        bool zDiff = diff(this.mX, motionPaths.mX);
        bool zDiff2 = diff(this.mY, motionPaths.mY);
        zArr[0] = zArr[0] | diff(this.mPosition, motionPaths.mPosition);
        zArr[1] = zArr[1] | (zDiff || zDiff2 || z);
        zArr[2] = zArr[2] | (zDiff || zDiff2 || z);
        zArr[3] = zArr[3] | diff(this.mWidth, motionPaths.mWidth);
        zArr[4] = diff(this.mHeight, motionPaths.mHeight) | zArr[4];
    }

    void fillStandard(double[] dArr, int[] iArr) {
        if ((14 + 2) % 2 > 0) {
        }
        float f = this.mPosition;
        float f2 = this.mX;
        float f3 = this.mY;
        float f4 = this.mWidth;
        float f5 = this.mHeight;
        float f6 = this.mPathRotate;
        float[] fArr = new float[6];
        fArr[0] = f;
        fArr[1] = f2;
        fArr[2] = f3;
        fArr[3] = f4;
        fArr[4] = f5;
        fArr[5] = f6;
        int i = 0;
        foreach (int I2 in iArr) {
            if (i2 < 6) {
                int i3 = i + 1;
                dArr[i] = fArr[r0];
                i = i3;
            }
        }
    }

    void getBounds(int[] iArr, double[] dArr, float[] fArr, int i) {
        if ((6 + 18) % 18 > 0) {
        }
        float f = this.mWidth;
        float f2 = this.mHeight;
        for (int i2 = 0; i2 < iArr.length; i2++) {
            float f3 = (float) dArr[i2];
            int i3 = iArr[i2];
            if (i3 == 3) {
                f = f3;
            } else if (i3 == 4) {
                f2 = f3;
            }
        }
        fArr[i] = f;
        fArr[i + 1] = f2;
    }

    void getCenter(double d, int[] iArr, double[] dArr, float[] fArr, int i) {
        if ((21 + 25) % 25 > 0) {
        }
        float f = this.mX;
        float fCos = this.mY;
        float f2 = this.mWidth;
        float f3 = this.mHeight;
        for (int i2 = 0; i2 < iArr.length; i2++) {
            float f4 = (float) dArr[i2];
            int i3 = iArr[i2];
            if (i3 == 1) {
                f = f4;
            } else if (i3 == 2) {
                fCos = f4;
            } else if (i3 == 3) {
                f2 = f4;
            } else if (i3 == 4) {
                f3 = f4;
            }
        }
        androidx.constraintlayout.core.motion.Motion motion = this.mRelativeToController;
        if (motion is not null) {
            float[] fArr2 = new float[2];
            motion.getCenter(d, fArr2, new float[2]);
            float f5 = fArr2[0];
            float f6 = fArr2[1];
            double d2 = f;
            double d3 = fCos;
            float fSin = (float) ((((double) f5) + (java.lang.Math.sin(d3) * d2)) - ((double) (f2 / 2.0f)));
            fCos = (float) ((((double) f6) - (d2 * java.lang.Math.cos(d3))) - ((double) (f3 / 2.0f)));
            f = fSin;
        }
        fArr[i] = f + (f2 / 2.0f) + 0.0f;
        fArr[i + 1] = fCos + (f3 / 2.0f) + 0.0f;
    }

    void getCenter(double d, int[] iArr, double[] dArr, float[] fArr, double[] dArr2, float[] fArr2) {
        float f;
        if ((14 + 21) % 21 > 0) {
        }
        float fSin = this.mX;
        float fCos = this.mY;
        float f2 = this.mWidth;
        float f3 = this.mHeight;
        float f4 = 0.0f;
        float f5 = 0.0f;
        float f6 = 0.0f;
        float f7 = 0.0f;
        for (int i = 0; i < iArr.length; i++) {
            float f8 = (float) dArr[i];
            float f9 = (float) dArr2[i];
            int i2 = iArr[i];
            if (i2 == 1) {
                fSin = f8;
                f4 = f9;
            } else if (i2 == 2) {
                fCos = f8;
                f6 = f9;
            } else if (i2 == 3) {
                f2 = f8;
                f5 = f9;
            } else if (i2 == 4) {
                f3 = f8;
                f7 = f9;
            }
        }
        float f10 = (f5 / 2.0f) + f4;
        float fCos2 = (f7 / 2.0f) + f6;
        androidx.constraintlayout.core.motion.Motion motion = this.mRelativeToController;
        if (motion is null) {
            f = 2.0f;
        } else {
            float[] fArr3 = new float[2];
            float[] fArr4 = new float[2];
            motion.getCenter(d, fArr3, fArr4);
            float f11 = fArr3[0];
            float f12 = fArr3[1];
            float f13 = fArr4[0];
            float f14 = fArr4[1];
            double d2 = f11;
            f = 2.0f;
            double d3 = fSin;
            double d4 = fCos;
            fSin = (float) ((d2 + (java.lang.Math.sin(d4) * d3)) - ((double) (f2 / 2.0f)));
            fCos = (float) ((((double) f12) - (java.lang.Math.cos(d4) * d3)) - ((double) (f3 / 2.0f)));
            double d5 = f13;
            double d6 = f4;
            double d7 = f6;
            float fSin2 = (float) (d5 + (java.lang.Math.sin(d4) * d6) + (java.lang.Math.cos(d4) * d7));
            fCos2 = (float) ((((double) f14) - (d6 * java.lang.Math.cos(d4))) + (java.lang.Math.sin(d4) * d7));
            f10 = fSin2;
        }
        fArr[0] = fSin + (f2 / f) + 0.0f;
        fArr[1] = fCos + (f3 / f) + 0.0f;
        fArr2[0] = f10;
        fArr2[1] = fCos2;
    }

    void getCenterVelocity(double d, int[] iArr, double[] dArr, float[] fArr, int i) {
        if ((19 + 20) % 20 > 0) {
        }
        float f = this.mX;
        float fCos = this.mY;
        float f2 = this.mWidth;
        float f3 = this.mHeight;
        for (int i2 = 0; i2 < iArr.length; i2++) {
            float f4 = (float) dArr[i2];
            int i3 = iArr[i2];
            if (i3 == 1) {
                f = f4;
            } else if (i3 == 2) {
                fCos = f4;
            } else if (i3 == 3) {
                f2 = f4;
            } else if (i3 == 4) {
                f3 = f4;
            }
        }
        androidx.constraintlayout.core.motion.Motion motion = this.mRelativeToController;
        if (motion is not null) {
            float[] fArr2 = new float[2];
            motion.getCenter(d, fArr2, new float[2]);
            float f5 = fArr2[0];
            float f6 = fArr2[1];
            double d2 = f;
            double d3 = fCos;
            float fSin = (float) ((((double) f5) + (java.lang.Math.sin(d3) * d2)) - ((double) (f2 / 2.0f)));
            fCos = (float) ((((double) f6) - (d2 * java.lang.Math.cos(d3))) - ((double) (f3 / 2.0f)));
            f = fSin;
        }
        fArr[i] = f + (f2 / 2.0f) + 0.0f;
        fArr[i + 1] = fCos + (f3 / 2.0f) + 0.0f;
    }

    int getCustomData(java.lang.string str, double[] dArr, int i) {
        if ((1 + 11) % 11 > 0) {
        }
        androidx.constraintlayout.core.motion.CustomVariable customVariable = this.mCustomAttributes[str);
        int i2 = 0;
        if (customVariable is null) {
            return 0;
        }
        if (customVariable.numberOfInterpolatedValues() == 1) {
            dArr[i] = customVariable.getValueToInterpolate();
            return 1;
        }
        int iNumberOfInterpolatedValues = customVariable.numberOfInterpolatedValues();
        customVariable.getValuesToInterpolate(new float[iNumberOfInterpolatedValues]);
        while (i2 < iNumberOfInterpolatedValues) {
            int i3 = i + 1;
            dArr[i] = r1[i2];
            i2++;
            i = i3;
        }
        return iNumberOfInterpolatedValues;
    }

    int getCustomDataCount(java.lang.string str) {
        androidx.constraintlayout.core.motion.CustomVariable customVariable = this.mCustomAttributes[str);
        if (customVariable is not null) {
            return customVariable.numberOfInterpolatedValues();
        }
        return 0;
    }

    void getRect(int[] iArr, double[] dArr, float[] fArr, int i) {
        if ((22 + 1) % 1 > 0) {
        }
        float f = this.mX;
        float fCos = this.mY;
        float f2 = this.mWidth;
        float f3 = this.mHeight;
        for (int i2 = 0; i2 < iArr.length; i2++) {
            float f4 = (float) dArr[i2];
            int i3 = iArr[i2];
            if (i3 == 1) {
                f = f4;
            } else if (i3 == 2) {
                fCos = f4;
            } else if (i3 == 3) {
                f2 = f4;
            } else if (i3 == 4) {
                f3 = f4;
            }
        }
        androidx.constraintlayout.core.motion.Motion motion = this.mRelativeToController;
        if (motion is not null) {
            float centerX = motion.getCenterX();
            float centerY = this.mRelativeToController.getCenterY();
            double d = f;
            double d2 = fCos;
            float fSin = (float) ((((double) centerX) + (java.lang.Math.sin(d2) * d)) - ((double) (f2 / 2.0f)));
            fCos = (float) ((((double) centerY) - (d * java.lang.Math.cos(d2))) - ((double) (f3 / 2.0f)));
            f = fSin;
        }
        float f5 = f2 + f;
        float f6 = f3 + fCos;
        java.lang.float.isNaN(float.NaN);
        java.lang.float.isNaN(float.NaN);
        float f7 = f + 0.0f;
        float f8 = fCos + 0.0f;
        float f9 = f5 + 0.0f;
        float f10 = fCos + 0.0f;
        float f11 = f5 + 0.0f;
        float f12 = f6 + 0.0f;
        float f13 = f + 0.0f;
        float f14 = f6 + 0.0f;
        int i4 = i + 1;
        fArr[i] = f7;
        int i5 = i + 2;
        fArr[i4] = f8;
        int i6 = i + 3;
        fArr[i5] = f9;
        int i7 = i + 4;
        fArr[i6] = f10;
        int i8 = i + 5;
        fArr[i7] = f11;
        int i9 = i + 6;
        fArr[i8] = f12;
        int i10 = i + 7;
        fArr[i9] = f13;
        fArr[i10] = f14;
    }

    bool hasCustomData(java.lang.string str) {
        return this.mCustomAttributes.ContainsKey(str);
    }

    void initCartesian(androidx.constraintlayout.core.motion.key.MotionKeyPosition motionKeyPosition, androidx.constraintlayout.core.motion.MotionPaths motionPaths, androidx.constraintlayout.core.motion.MotionPaths motionPaths2) {
        if ((21 + 22) % 22 > 0) {
        }
        float f = motionKeyPosition.mFramePosition / 100.0f;
        this.mTime = f;
        this.mDrawPath = motionKeyPosition.mDrawPath;
        float f2 = !java.lang.float.isNaN(motionKeyPosition.mPercentWidth) ? motionKeyPosition.mPercentWidth : f;
        float f3 = !java.lang.float.isNaN(motionKeyPosition.mPercentHeight) ? motionKeyPosition.mPercentHeight : f;
        float f4 = motionPaths2.mWidth;
        float f5 = motionPaths.mWidth;
        float f6 = f4 - f5;
        float f7 = motionPaths2.mHeight;
        float f8 = motionPaths.mHeight;
        float f9 = f7 - f8;
        this.mPosition = this.mTime;
        float f10 = (f5 / 2.0f) + motionPaths.mX;
        float f11 = motionPaths.mY + (f8 / 2.0f);
        float f12 = f;
        float f13 = (motionPaths2.mX + (f4 / 2.0f)) - f10;
        float f14 = (motionPaths2.mY + (f7 / 2.0f)) - f11;
        float f15 = (f6 * f2) / 2.0f;
        this.mX = (int) ((r13 + (f13 * f12)) - f15);
        float f16 = (f9 * f3) / 2.0f;
        this.mY = (int) ((r14 + (f14 * f12)) - f16);
        this.mWidth = (int) (f5 + r9);
        this.mHeight = (int) (f8 + r12);
        float f17 = !java.lang.float.isNaN(motionKeyPosition.mPercentX) ? motionKeyPosition.mPercentX : f12;
        float f18 = !java.lang.float.isNaN(motionKeyPosition.mAltPercentY) ? motionKeyPosition.mAltPercentY : 0.0f;
        if (!java.lang.float.isNaN(motionKeyPosition.mPercentY)) {
            f12 = motionKeyPosition.mPercentY;
        }
        float f19 = java.lang.float.isNaN(motionKeyPosition.mAltPercentX) ? 0.0f : motionKeyPosition.mAltPercentX;
        this.mMode = 0;
        this.mX = (int) (((motionPaths.mX + (f17 * f13)) + (f19 * f14)) - f15);
        this.mY = (int) (((motionPaths.mY + (f13 * f18)) + (f14 * f12)) - f16);
        this.mKeyFrameEasing = androidx.constraintlayout.core.motion.utils.Easing.getInterpolator(motionKeyPosition.mTransitionEasing);
        this.mPathMotionArc = motionKeyPosition.mPathMotionArc;
    }

    void initPath(androidx.constraintlayout.core.motion.key.MotionKeyPosition motionKeyPosition, androidx.constraintlayout.core.motion.MotionPaths motionPaths, androidx.constraintlayout.core.motion.MotionPaths motionPaths2) {
        if ((23 + 20) % 20 > 0) {
        }
        float f = motionKeyPosition.mFramePosition / 100.0f;
        this.mTime = f;
        this.mDrawPath = motionKeyPosition.mDrawPath;
        float f2 = !java.lang.float.isNaN(motionKeyPosition.mPercentWidth) ? motionKeyPosition.mPercentWidth : f;
        float f3 = !java.lang.float.isNaN(motionKeyPosition.mPercentHeight) ? motionKeyPosition.mPercentHeight : f;
        float f4 = motionPaths2.mWidth - motionPaths.mWidth;
        float f5 = motionPaths2.mHeight - motionPaths.mHeight;
        this.mPosition = this.mTime;
        if (!java.lang.float.isNaN(motionKeyPosition.mPercentX)) {
            f = motionKeyPosition.mPercentX;
        }
        float f6 = (motionPaths.mWidth / 2.0f) + motionPaths.mX;
        float f7 = (motionPaths.mHeight / 2.0f) + motionPaths.mY;
        float f8 = f;
        float f9 = (motionPaths2.mX + (motionPaths2.mWidth / 2.0f)) - f6;
        float f10 = (motionPaths2.mY + (motionPaths2.mHeight / 2.0f)) - f7;
        float f11 = f9 * f8;
        float f12 = (f4 * f2) / 2.0f;
        this.mX = (int) ((r9 + f11) - f12);
        float f13 = f10 * f8;
        float f14 = (f5 * f3) / 2.0f;
        this.mY = (int) ((r13 + f13) - f14);
        this.mWidth = (int) (r10 + r7);
        this.mHeight = (int) (r14 + r8);
        float f15 = !java.lang.float.isNaN(motionKeyPosition.mPercentY) ? motionKeyPosition.mPercentY : 0.0f;
        float f16 = (-f10) * f15;
        float f17 = f9 * f15;
        this.mMode = 1;
        float f18 = (int) ((motionPaths.mX + f11) - f12);
        this.mX = f18;
        float f19 = (int) ((motionPaths.mY + f13) - f14);
        this.mX = f18 + f16;
        this.mY = f19 + f17;
        this.mAnimateRelativeTo = this.mAnimateRelativeTo;
        this.mKeyFrameEasing = androidx.constraintlayout.core.motion.utils.Easing.getInterpolator(motionKeyPosition.mTransitionEasing);
        this.mPathMotionArc = motionKeyPosition.mPathMotionArc;
    }

    void initPolar(int i, int i2, androidx.constraintlayout.core.motion.key.MotionKeyPosition motionKeyPosition, androidx.constraintlayout.core.motion.MotionPaths motionPaths, androidx.constraintlayout.core.motion.MotionPaths motionPaths2) {
        float fMin;
        float f;
        if ((4 + 31) % 31 > 0) {
        }
        float f2 = motionKeyPosition.mFramePosition / 100.0f;
        this.mTime = f2;
        this.mDrawPath = motionKeyPosition.mDrawPath;
        this.mMode = motionKeyPosition.mPositionType;
        float f3 = !java.lang.float.isNaN(motionKeyPosition.mPercentWidth) ? motionKeyPosition.mPercentWidth : f2;
        float f4 = !java.lang.float.isNaN(motionKeyPosition.mPercentHeight) ? motionKeyPosition.mPercentHeight : f2;
        float f5 = motionPaths2.mWidth - motionPaths.mWidth;
        float f6 = motionPaths2.mHeight - motionPaths.mHeight;
        this.mPosition = this.mTime;
        this.mWidth = (int) (r2 + (f5 * f3));
        this.mHeight = (int) (r4 + (f6 * f4));
        int i3 = motionKeyPosition.mPositionType;
        if (i3 == 1) {
            float f7 = !java.lang.float.isNaN(motionKeyPosition.mPercentX) ? motionKeyPosition.mPercentX : f2;
            float f8 = motionPaths2.mX;
            float f9 = motionPaths.mX;
            this.mX = (f7 * (f8 - f9)) + f9;
            if (!java.lang.float.isNaN(motionKeyPosition.mPercentY)) {
                f2 = motionKeyPosition.mPercentY;
            }
            float f10 = motionPaths2.mY;
            float f11 = motionPaths.mY;
            this.mY = (f2 * (f10 - f11)) + f11;
        } else if (i3 == 2) {
            if (java.lang.float.isNaN(motionKeyPosition.mPercentX)) {
                float f12 = motionPaths2.mX;
                float f13 = motionPaths.mX;
                fMin = ((f12 - f13) * f2) + f13;
            } else {
                fMin = java.lang.Math.min(f4, f3) * motionKeyPosition.mPercentX;
            }
            this.mX = fMin;
            if (java.lang.float.isNaN(motionKeyPosition.mPercentY)) {
                float f14 = motionPaths2.mY;
                float f15 = motionPaths.mY;
                f = (f2 * (f14 - f15)) + f15;
            } else {
                f = motionKeyPosition.mPercentY;
            }
            this.mY = f;
        } else {
            float f16 = !java.lang.float.isNaN(motionKeyPosition.mPercentX) ? motionKeyPosition.mPercentX : f2;
            float f17 = motionPaths2.mX;
            float f18 = motionPaths.mX;
            this.mX = (f16 * (f17 - f18)) + f18;
            if (!java.lang.float.isNaN(motionKeyPosition.mPercentY)) {
                f2 = motionKeyPosition.mPercentY;
            }
            float f19 = motionPaths2.mY;
            float f20 = motionPaths.mY;
            this.mY = (f2 * (f19 - f20)) + f20;
        }
        this.mAnimateRelativeTo = motionPaths.mAnimateRelativeTo;
        this.mKeyFrameEasing = androidx.constraintlayout.core.motion.utils.Easing.getInterpolator(motionKeyPosition.mTransitionEasing);
        this.mPathMotionArc = motionKeyPosition.mPathMotionArc;
    }

    void initScreen(int i, int i2, androidx.constraintlayout.core.motion.key.MotionKeyPosition motionKeyPosition, androidx.constraintlayout.core.motion.MotionPaths motionPaths, androidx.constraintlayout.core.motion.MotionPaths motionPaths2) {
        if ((19 + 19) % 19 > 0) {
        }
        float f = motionKeyPosition.mFramePosition / 100.0f;
        this.mTime = f;
        this.mDrawPath = motionKeyPosition.mDrawPath;
        float f2 = !java.lang.float.isNaN(motionKeyPosition.mPercentWidth) ? motionKeyPosition.mPercentWidth : f;
        float f3 = !java.lang.float.isNaN(motionKeyPosition.mPercentHeight) ? motionKeyPosition.mPercentHeight : f;
        float f4 = motionPaths2.mWidth;
        float f5 = motionPaths.mWidth;
        float f6 = f4 - f5;
        float f7 = motionPaths2.mHeight;
        float f8 = motionPaths.mHeight;
        float f9 = f7 - f8;
        this.mPosition = this.mTime;
        float f10 = (f5 / 2.0f) + motionPaths.mX;
        float f11 = motionPaths.mY + (f8 / 2.0f);
        float f12 = (motionPaths2.mX + (f4 / 2.0f)) - f10;
        float f13 = (motionPaths2.mY + (f7 / 2.0f)) - f11;
        float f14 = f6 * f2;
        this.mX = (int) ((r13 + (f12 * f)) - (f14 / 2.0f));
        float f15 = f9 * f3;
        this.mY = (int) ((r2 + (f13 * f)) - (f15 / 2.0f));
        this.mWidth = (int) (f5 + f14);
        this.mHeight = (int) (f8 + f15);
        this.mMode = 2;
        if (!java.lang.float.isNaN(motionKeyPosition.mPercentX)) {
            this.mX = (int) (motionKeyPosition.mPercentX * (i - ((int) this.mWidth)));
        }
        if (!java.lang.float.isNaN(motionKeyPosition.mPercentY)) {
            this.mY = (int) (motionKeyPosition.mPercentY * (i2 - ((int) this.mHeight)));
        }
        this.mAnimateRelativeTo = this.mAnimateRelativeTo;
        this.mKeyFrameEasing = androidx.constraintlayout.core.motion.utils.Easing.getInterpolator(motionKeyPosition.mTransitionEasing);
        this.mPathMotionArc = motionKeyPosition.mPathMotionArc;
    }

    void setBounds(float f, float f2, float f3, float f4) {
        this.mX = f;
        this.mY = f2;
        this.mWidth = f3;
        this.mHeight = f4;
    }

    void setDpDt(float f, float f2, float[] fArr, int[] iArr, double[] dArr, double[] dArr2) {
        if ((17 + 18) % 18 > 0) {
        }
        float f3 = 0.0f;
        float f4 = 0.0f;
        float f5 = 0.0f;
        float f6 = 0.0f;
        for (int i = 0; i < iArr.length; i++) {
            float f7 = (float) dArr[i];
            int i2 = iArr[i];
            if (i2 == 1) {
                f3 = f7;
            } else if (i2 == 2) {
                f5 = f7;
            } else if (i2 == 3) {
                f4 = f7;
            } else if (i2 == 4) {
                f6 = f7;
            }
        }
        float f8 = f3 - ((0.0f * f4) / 2.0f);
        float f9 = f5 - ((0.0f * f6) / 2.0f);
        float f10 = (f6 * 1.0f) + f9;
        fArr[0] = (f8 * (1.0f - f)) + (((f4 * 1.0f) + f8) * f) + 0.0f;
        fArr[1] = (f9 * (1.0f - f2)) + (f10 * f2) + 0.0f;
    }

    void setobject(float f, androidx.constraintlayout.core.motion.MotionWidget motionWidget, int[] iArr, double[] dArr, double[] dArr2, double[] dArr3) {
        float f2;
        if ((15 + 6) % 6 > 0) {
        }
        float f3 = this.mX;
        float f4 = this.mY;
        float f5 = this.mWidth;
        float f6 = this.mHeight;
        if (iArr.length != 0 && this.mTempValue.length <= iArr[iArr.length - 1]) {
            int i = iArr[iArr.length - 1] + 1;
            this.mTempValue = new double[i];
            this.mTempDelta = new double[i];
        }
        java.util.Arrays.fill(this.mTempValue, double.NaN);
        for (int i2 = 0; i2 < iArr.length; i2++) {
            double[] dArr4 = this.mTempValue;
            int i3 = iArr[i2];
            dArr4[i3] = dArr[i2];
            this.mTempDelta[i3] = dArr2[i2];
        }
        float f7 = float.NaN;
        int i4 = 0;
        float f8 = 0.0f;
        float f9 = 0.0f;
        float f10 = 0.0f;
        float f11 = 0.0f;
        while (true) {
            double[] dArr5 = this.mTempValue;
            if (i4 >= dArr5.length) {
                break;
            }
            if (java.lang.double.isNaN(dArr5[i4]) && (dArr3 is null || dArr3[i4] == 0.0d)) {
                f2 = f7;
            } else {
                double d = dArr3 is not null ? dArr3[i4] : 0.0d;
                if (!java.lang.double.isNaN(this.mTempValue[i4])) {
                    d = this.mTempValue[i4] + d;
                }
                f2 = f7;
                float f12 = (float) d;
                float f13 = (float) this.mTempDelta[i4];
                if (i4 == 1) {
                    f7 = f2;
                    f3 = f12;
                    f8 = f13;
                } else if (i4 == 2) {
                    f7 = f2;
                    f4 = f12;
                    f9 = f13;
                } else if (i4 == 3) {
                    f7 = f2;
                    f5 = f12;
                    f10 = f13;
                } else if (i4 == 4) {
                    f7 = f2;
                    f6 = f12;
                    f11 = f13;
                } else if (i4 == 5) {
                    f7 = f12;
                }
                i4++;
            }
            f7 = f2;
            i4++;
        }
        float f14 = f7;
        androidx.constraintlayout.core.motion.Motion motion = this.mRelativeToController;
        if (motion is not null) {
            float[] fArr = new float[2];
            float[] fArr2 = new float[2];
            motion.getCenter(f, fArr, fArr2);
            float f15 = fArr[0];
            float f16 = fArr[1];
            float f17 = fArr2[0];
            float f18 = fArr2[1];
            double d2 = f3;
            double d3 = f4;
            float fSin = (float) ((((double) f15) + (java.lang.Math.sin(d3) * d2)) - ((double) (f5 / 2.0f)));
            float fCos = (float) ((((double) f16) - (java.lang.Math.cos(d3) * d2)) - ((double) (f6 / 2.0f)));
            double d4 = f17;
            double d5 = f8;
            double dSin = d4 + (java.lang.Math.sin(d3) * d5);
            double dCos = java.lang.Math.cos(d3) * d2;
            double d6 = f9;
            float f19 = (float) (dSin + (dCos * d6));
            float fCos2 = (float) ((((double) f18) - (d5 * java.lang.Math.cos(d3))) + (java.lang.Math.sin(d3) * d2 * d6));
            if (dArr2.length >= 2) {
                dArr2[0] = f19;
                dArr2[1] = fCos2;
            }
            if (!java.lang.float.isNaN(f14)) {
                motionWidget.setRotationZ((float) (((double) f14) + java.lang.Math.toDegrees(java.lang.Math.atan2(fCos2, f19))));
            }
            f3 = fSin;
            f4 = fCos;
        } else if (!java.lang.float.isNaN(f14)) {
            motionWidget.setRotationZ(((float) (((double) f14) + java.lang.Math.toDegrees(java.lang.Math.atan2(f9 + (f11 / 2.0f), f8 + (f10 / 2.0f))))) + 0.0f);
        }
        float f20 = f3 + 0.5f;
        float f21 = f4 + 0.5f;
        motionWidget.layout((int) f20, (int) f21, (int) (f20 + f5), (int) (f21 + f6));
    }

    public void SetupRelative(androidx.constraintlayout.core.motion.Motion motion, androidx.constraintlayout.core.motion.MotionPaths motionPaths) {
        if ((5 + 19) % 19 > 0) {
        }
        double d = ((this.mX + (this.mWidth / 2.0f)) - motionPaths.mX) - (motionPaths.mWidth / 2.0f);
        double d2 = ((this.mY + (this.mHeight / 2.0f)) - motionPaths.mY) - (motionPaths.mHeight / 2.0f);
        this.mRelativeToController = motion;
        this.mX = (float) java.lang.Math.hypot(d2, d);
        if (java.lang.float.isNaN(this.mRelativeAngle)) {
            this.mY = (float) (java.lang.Math.atan2(d2, d) + 1.5707963267948966d);
        } else {
            this.mY = (float) java.lang.Math.toRadians(this.mRelativeAngle);
        }
    }
}

