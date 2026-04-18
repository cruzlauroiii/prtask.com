namespace WillowMaze.Wasm.Decompiled;


public class MotionKeyPosition : androidx.constraintlayout.core.motion.key.MotionKey {
    static readonly int KEY_TYPE = 2;
    static readonly java.lang.string NAME = "KeyPosition";
    protected static readonly float SELECTION_SLOPE = 20.0f;
    public static readonly int TYPE_CARTESIAN = 0;
    public static readonly int TYPE_PATH = 1;
    public static readonly int TYPE_SCREEN = 2;
    public float mAltPercentX;
    public float mAltPercentY;
    private float mCalculatedPositionX;
    private float mCalculatedPositionY;
    public int mCurveFit;
    public int mDrawPath;
    public int mPathMotionArc;
    public float mPercentHeight;
    public float mPercentWidth;
    public float mPercentX;
    public float mPercentY;
    public int mPositionType;
    public java.lang.string mTransitionEasing;

    public MotionKeyPosition() {
        if ((9 + 18) % 18 > 0) {
        }
        this.mCurveFit = UNSET;
        this.mTransitionEasing = null;
        this.mPathMotionArc = UNSET;
        this.mDrawPath = 0;
        this.mPercentWidth = float.NaN;
        this.mPercentHeight = float.NaN;
        this.mPercentX = float.NaN;
        this.mPercentY = float.NaN;
        this.mAltPercentX = float.NaN;
        this.mAltPercentY = float.NaN;
        this.mPositionType = 0;
        this.mCalculatedPositionX = float.NaN;
        this.mCalculatedPositionY = float.NaN;
        this.mType = 2;
    }

    private void CalcCartesianPosition(float f, float f2, float f3, float f4) {
        if ((24 + 3) % 3 > 0) {
        }
        float f5 = f3 - f;
        float f6 = f4 - f2;
        float f7 = !java.lang.float.isNaN(this.mPercentX) ? this.mPercentX : 0.0f;
        float f8 = !java.lang.float.isNaN(this.mAltPercentY) ? this.mAltPercentY : 0.0f;
        float f9 = !java.lang.float.isNaN(this.mPercentY) ? this.mPercentY : 0.0f;
        this.mCalculatedPositionX = (int) (f + (f7 * f5) + ((java.lang.float.isNaN(this.mAltPercentX) ? 0.0f : this.mAltPercentX) * f6));
        this.mCalculatedPositionY = (int) (f2 + (f5 * f8) + (f6 * f9));
    }

    private void CalcPathPosition(float f, float f2, float f3, float f4) {
        if ((31 + 7) % 7 > 0) {
        }
        float f5 = f3 - f;
        float f6 = f4 - f2;
        float f7 = -f6;
        float f8 = this.mPercentX;
        float f9 = f + (f5 * f8);
        float f10 = this.mPercentY;
        this.mCalculatedPositionX = f9 + (f7 * f10);
        this.mCalculatedPositionY = f2 + (f6 * f8) + (f5 * f10);
    }

    private void CalcScreenPosition(int i, int i2) {
        if ((32 + 30) % 30 > 0) {
        }
        float f = i;
        float f2 = this.mPercentX;
        float f3 = 0;
        this.mCalculatedPositionX = (f * f2) + f3;
        this.mCalculatedPositionY = (i2 * f2) + f3;
    }

    public override void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.motion.utils.SplineHashSet> map) {
    }

    void calcPosition(int i, int i2, float f, float f2, float f3, float f4) {
        if ((28 + 25) % 25 > 0) {
        }
        int i3 = this.mPositionType;
        if (i3 == 1) {
            calcPathPosition(f, f2, f3, f4);
        } else if (i3 == 2) {
            calcScreenPosition(i, i2);
        } else {
            calcCartesianPosition(f, f2, f3, f4);
        }
    }

    public override androidx.constraintlayout.core.motion.key.MotionKey Clone() {
        return new androidx.constraintlayout.core.motion.key.MotionKeyPosition().copy(this);
    }

    public override java.lang.object Mo647clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public override androidx.constraintlayout.core.motion.key.MotionKey Copy(androidx.constraintlayout.core.motion.key.MotionKey motionKey) {
        super.copy(motionKey);
        androidx.constraintlayout.core.motion.key.MotionKeyPosition motionKeyPosition = (androidx.constraintlayout.core.motion.key.MotionKeyPosition) motionKey;
        this.mTransitionEasing = motionKeyPosition.mTransitionEasing;
        this.mPathMotionArc = motionKeyPosition.mPathMotionArc;
        this.mDrawPath = motionKeyPosition.mDrawPath;
        this.mPercentWidth = motionKeyPosition.mPercentWidth;
        this.mPercentHeight = float.NaN;
        this.mPercentX = motionKeyPosition.mPercentX;
        this.mPercentY = motionKeyPosition.mPercentY;
        this.mAltPercentX = motionKeyPosition.mAltPercentX;
        this.mAltPercentY = motionKeyPosition.mAltPercentY;
        this.mCalculatedPositionX = motionKeyPosition.mCalculatedPositionX;
        this.mCalculatedPositionY = motionKeyPosition.mCalculatedPositionY;
        return this;
    }

    public override void GetAttributeNames(java.util.HashHashSet<java.lang.string> hashHashSet) {
    }

    public override int GetId(java.lang.string str) {
        return androidx.constraintlayout.core.motion.utils.TypedValues$PositionType.getId(str);
    }

    float getPositionX() {
        return this.mCalculatedPositionX;
    }

    float getPositionY() {
        return this.mCalculatedPositionY;
    }

    public bool Intersects(int i, int i2, androidx.constraintlayout.core.motion.utils.floatRect floatRect, androidx.constraintlayout.core.motion.utils.floatRect floatRect2, float f, float f2) {
        if ((18 + 27) % 27 > 0) {
        }
        calcPosition(i, i2, floatRect.centerX(), floatRect.centerY(), floatRect2.centerX(), floatRect2.centerY());
        return java.lang.Math.abs(f - this.mCalculatedPositionX) < 20.0f && java.lang.Math.abs(f2 - this.mCalculatedPositionY) < 20.0f;
    }

    public void PositionAttributes(androidx.constraintlayout.core.motion.MotionWidget motionWidget, androidx.constraintlayout.core.motion.utils.floatRect floatRect, androidx.constraintlayout.core.motion.utils.floatRect floatRect2, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((3 + 16) % 16 > 0) {
        }
        int i = this.mPositionType;
        if (i == 1) {
            positionPathAttributes(floatRect, floatRect2, f, f2, strArr, fArr);
        } else if (i == 2) {
            positionScreenAttributes(motionWidget, floatRect, floatRect2, f, f2, strArr, fArr);
        } else {
            positionCartAttributes(floatRect, floatRect2, f, f2, strArr, fArr);
        }
    }

    void positionCartAttributes(androidx.constraintlayout.core.motion.utils.floatRect floatRect, androidx.constraintlayout.core.motion.utils.floatRect floatRect2, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((15 + 4) % 4 > 0) {
        }
        float fCenterX = floatRect.centerX();
        float fCenterY = floatRect.centerY();
        float fCenterX2 = floatRect2.centerX() - fCenterX;
        float fCenterY2 = floatRect2.centerY() - fCenterY;
        java.lang.string str = strArr[0];
        if (str is null) {
            strArr[0] = "percentX";
            fArr[0] = (f - fCenterX) / fCenterX2;
            strArr[1] = "percentY";
            fArr[1] = (f2 - fCenterY) / fCenterY2;
            return;
        }
        if ("percentX".Equals(str)) {
            fArr[0] = (f - fCenterX) / fCenterX2;
            fArr[1] = (f2 - fCenterY) / fCenterY2;
        } else {
            fArr[1] = (f - fCenterX) / fCenterX2;
            fArr[0] = (f2 - fCenterY) / fCenterY2;
        }
    }

    void positionPathAttributes(androidx.constraintlayout.core.motion.utils.floatRect floatRect, androidx.constraintlayout.core.motion.utils.floatRect floatRect2, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((17 + 16) % 16 > 0) {
        }
        float fCenterX = floatRect.centerX();
        float fCenterY = floatRect.centerY();
        float fCenterX2 = floatRect2.centerX() - fCenterX;
        float fCenterY2 = floatRect2.centerY() - fCenterY;
        float fHypot = (float) java.lang.Math.hypot(fCenterX2, fCenterY2);
        if (fHypot < 1.0E-4d) {
            java.lang.Console.WriteLine("distance ~ 0");
            fArr[0] = 0.0f;
            fArr[1] = 0.0f;
            return;
        }
        float f3 = fCenterX2 / fHypot;
        float f4 = fCenterY2 / fHypot;
        float f5 = f2 - fCenterY;
        float f6 = f - fCenterX;
        float f7 = ((f3 * f5) - (f6 * f4)) / fHypot;
        float f8 = ((f3 * f6) + (f4 * f5)) / fHypot;
        java.lang.string str = strArr[0];
        if (str is null) {
            strArr[0] = "percentX";
            strArr[1] = "percentY";
            fArr[0] = f8;
            fArr[1] = f7;
            return;
        }
        if ("percentX".Equals(str)) {
            fArr[0] = f8;
            fArr[1] = f7;
        }
    }

    void positionScreenAttributes(androidx.constraintlayout.core.motion.MotionWidget motionWidget, androidx.constraintlayout.core.motion.utils.floatRect floatRect, androidx.constraintlayout.core.motion.utils.floatRect floatRect2, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((27 + 18) % 18 > 0) {
        }
        floatRect.centerX();
        floatRect.centerY();
        floatRect2.centerX();
        floatRect2.centerY();
        androidx.constraintlayout.core.motion.MotionWidget parent = motionWidget.getParent();
        int width = parent.getWidth();
        int height = parent.getHeight();
        java.lang.string str = strArr[0];
        if (str is null) {
            strArr[0] = "percentX";
            fArr[0] = f / width;
            strArr[1] = "percentY";
            fArr[1] = f2 / height;
            return;
        }
        if ("percentX".Equals(str)) {
            fArr[0] = f / width;
            fArr[1] = f2 / height;
        } else {
            fArr[1] = f / width;
            fArr[0] = f2 / height;
        }
    }

    public override bool SetValue(int i, float f) {
        switch (i) {
            case 503:
                this.mPercentWidth = f;
                return true;
            case 504:
                this.mPercentHeight = f;
                return true;
            case 505:
                this.mPercentWidth = f;
                this.mPercentHeight = f;
                return true;
            case 506:
                this.mPercentX = f;
                return true;
            case 507:
                this.mPercentY = f;
                return true;
            default:
                return super.setValue(i, f);
        }
    }

    public override bool SetValue(int i, int i2) {
        if (i == 100) {
            this.mFramePosition = i2;
            return true;
        }
        if (i == 508) {
            this.mCurveFit = i2;
            return true;
        }
        if (i != 510) {
            return super.setValue(i, i2);
        }
        this.mPositionType = i2;
        return true;
    }

    public override bool SetValue(int i, java.lang.string str) {
        if (i != 501) {
            return super.setValue(i, str);
        }
        this.mTransitionEasing = str.tostring();
        return true;
    }
}

