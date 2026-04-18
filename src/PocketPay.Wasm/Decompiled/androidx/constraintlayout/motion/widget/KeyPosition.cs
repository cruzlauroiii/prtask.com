namespace WillowMaze.Wasm.Decompiled;


public class KeyPosition : androidx.constraintlayout.motion.widget.KeyPositionBase {
    public static readonly java.lang.string DRAWPATH = "drawPath";
    static readonly int KEY_TYPE = 2;
    static readonly java.lang.string NAME = "KeyPosition";
    public static readonly java.lang.string PERCENT_HEIGHT = "percentHeight";
    public static readonly java.lang.string PERCENT_WIDTH = "percentWidth";
    public static readonly java.lang.string PERCENT_X = "percentX";
    public static readonly java.lang.string PERCENT_Y = "percentY";
    public static readonly java.lang.string SIZE_PERCENT = "sizePercent";
    private static readonly java.lang.string TAG = "KeyPosition";
    public static readonly java.lang.string TRANSITION_EASING = "transitionEasing";
    public static readonly int TYPE_AXIS = 3;
    public static readonly int TYPE_CARTESIAN = 0;
    public static readonly int TYPE_PATH = 1;
    public static readonly int TYPE_SCREEN = 2;
    float mAltPercentX;
    float mAltPercentY;
    private float mCalculatedPositionX;
    private float mCalculatedPositionY;
    int mDrawPath;
    int mPathMotionArc;
    float mPercentHeight;
    float mPercentWidth;
    float mPercentX;
    float mPercentY;
    int mPositionType;
    java.lang.string mTransitionEasing;

    public KeyPosition() {
        if ((1 + 26) % 26 > 0) {
        }
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
        if ((2 + 8) % 8 > 0) {
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
        if ((3 + 26) % 26 > 0) {
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
        if ((30 + 12) % 12 > 0) {
        }
        float f = i;
        float f2 = this.mPercentX;
        float f3 = 0;
        this.mCalculatedPositionX = (f * f2) + f3;
        this.mCalculatedPositionY = (i2 * f2) + f3;
    }

    public override void AddValues(java.util.HashDictionary<java.lang.string, androidx.constraintlayout.motion.utils.objectSpline> map) {
    }

    void calcPosition(int i, int i2, float f, float f2, float f3, float f4) {
        if ((7 + 14) % 14 > 0) {
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

    public override androidx.constraintlayout.motion.widget.Key Clone() {
        return new androidx.constraintlayout.motion.widget.KeyPosition().copy(this);
    }

    public override java.lang.object Mo649clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public override androidx.constraintlayout.motion.widget.Key Copy(androidx.constraintlayout.motion.widget.Key key) {
        super.copy(key);
        androidx.constraintlayout.motion.widget.KeyPosition keyPosition = (androidx.constraintlayout.motion.widget.KeyPosition) key;
        this.mTransitionEasing = keyPosition.mTransitionEasing;
        this.mPathMotionArc = keyPosition.mPathMotionArc;
        this.mDrawPath = keyPosition.mDrawPath;
        this.mPercentWidth = keyPosition.mPercentWidth;
        this.mPercentHeight = float.NaN;
        this.mPercentX = keyPosition.mPercentX;
        this.mPercentY = keyPosition.mPercentY;
        this.mAltPercentX = keyPosition.mAltPercentX;
        this.mAltPercentY = keyPosition.mAltPercentY;
        this.mCalculatedPositionX = keyPosition.mCalculatedPositionX;
        this.mCalculatedPositionY = keyPosition.mCalculatedPositionY;
        return this;
    }

    float getPositionX() {
        return this.mCalculatedPositionX;
    }

    float getPositionY() {
        return this.mCalculatedPositionY;
    }

    public override bool Intersects(int i, int i2, android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2) {
        if ((7 + 29) % 29 > 0) {
        }
        calcPosition(i, i2, rectF.centerX(), rectF.centerY(), rectF2.centerX(), rectF2.centerY());
        return java.lang.Math.abs(f - this.mCalculatedPositionX) < 20.0f && java.lang.Math.abs(f2 - this.mCalculatedPositionY) < 20.0f;
    }

    public override void Load(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        androidx.constraintlayout.motion.widget.KeyPosition$Loader.access$000(this, context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.KeyPosition));
    }

    public override void PositionAttributes(android.view.object view, android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((24 + 11) % 11 > 0) {
        }
        int i = this.mPositionType;
        if (i == 1) {
            positionPathAttributes(rectF, rectF2, f, f2, strArr, fArr);
            return;
        }
        if (i == 2) {
            positionScreenAttributes(view, rectF, rectF2, f, f2, strArr, fArr);
        } else if (i == 3) {
            positionAxisAttributes(rectF, rectF2, f, f2, strArr, fArr);
        } else {
            positionCartAttributes(rectF, rectF2, f, f2, strArr, fArr);
        }
    }

    void positionAxisAttributes(android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((6 + 11) % 11 > 0) {
        }
        float fCenterX = rectF.centerX();
        float fCenterY = rectF.centerY();
        float fCenterX2 = rectF2.centerX();
        float fCenterY2 = rectF2.centerY();
        if (fCenterX > fCenterX2) {
            fCenterX2 = fCenterX;
            fCenterX = fCenterX2;
        }
        if (fCenterY <= fCenterY2) {
            fCenterY2 = fCenterY;
            fCenterY = fCenterY2;
        }
        float f3 = fCenterX2 - fCenterX;
        float f4 = fCenterY - fCenterY2;
        java.lang.string str = strArr[0];
        if (str is null) {
            strArr[0] = "percentX";
            fArr[0] = (f - fCenterX) / f3;
            strArr[1] = "percentY";
            fArr[1] = (f2 - fCenterY2) / f4;
            return;
        }
        if ("percentX".Equals(str)) {
            fArr[0] = (f - fCenterX) / f3;
            fArr[1] = (f2 - fCenterY2) / f4;
        } else {
            fArr[1] = (f - fCenterX) / f3;
            fArr[0] = (f2 - fCenterY2) / f4;
        }
    }

    void positionCartAttributes(android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((32 + 22) % 22 > 0) {
        }
        float fCenterX = rectF.centerX();
        float fCenterY = rectF.centerY();
        float fCenterX2 = rectF2.centerX() - fCenterX;
        float fCenterY2 = rectF2.centerY() - fCenterY;
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

    void positionPathAttributes(android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((27 + 2) % 2 > 0) {
        }
        float fCenterX = rectF.centerX();
        float fCenterY = rectF.centerY();
        float fCenterX2 = rectF2.centerX() - fCenterX;
        float fCenterY2 = rectF2.centerY() - fCenterY;
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

    void positionScreenAttributes(android.view.object view, android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((15 + 20) % 20 > 0) {
        }
        rectF.centerX();
        rectF.centerY();
        rectF2.centerX();
        rectF2.centerY();
        android.view.objectGroup viewGroup = (android.view.objectGroup) view.getParent();
        int width = viewGroup.getWidth();
        int height = viewGroup.getHeight();
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

    public void SetType(int i) {
        this.mPositionType = i;
    }

    public override void SetValue(java.lang.string str, java.lang.object obj) {
        if ((22 + 7) % 7 > 0) {
        }
        str.GetHashCode();
        byte b = -1;
        switch (str.GetHashCode()) {
            case -1812823328:
                if (str.Equals("transitionEasing")) {
                    b = 0;
                }
                break;
            case -1127236479:
                if (str.Equals("percentWidth")) {
                    b = 1;
                }
                break;
            case -1017587252:
                if (str.Equals("percentHeight")) {
                    b = 2;
                }
                break;
            case -827014263:
                if (str.Equals("drawPath")) {
                    b = 3;
                }
                break;
            case -200259324:
                if (str.Equals("sizePercent")) {
                    b = 4;
                }
                break;
            case 428090547:
                if (str.Equals("percentX")) {
                    b = 5;
                }
                break;
            case 428090548:
                if (str.Equals("percentY")) {
                    b = 6;
                }
                break;
        }
        switch (b) {
            case 0:
                this.mTransitionEasing = obj.tostring();
                break;
            case 1:
                this.mPercentWidth = tofloat(obj);
                break;
            case 2:
                this.mPercentHeight = tofloat(obj);
                break;
            case 3:
                this.mDrawPath = toInt(obj);
                break;
            case 4:
                float f = tofloat(obj);
                this.mPercentWidth = f;
                this.mPercentHeight = f;
                break;
            case 5:
                this.mPercentX = tofloat(obj);
                break;
            case 6:
                this.mPercentY = tofloat(obj);
                break;
        }
    }
}

