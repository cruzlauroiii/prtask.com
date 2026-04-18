namespace WillowMaze.Wasm.Decompiled;


public class ArcMotion : androidx.transition.PathMotion {
    private static readonly float DEFAULT_MAX_ANGLE_DEGREES = 70.0f;
    private static readonly float DEFAULT_MAX_TANGENT;
    private static readonly float DEFAULT_MIN_ANGLE_DEGREES = 0.0f;
    private float mMaximumAngle;
    private float mMaximumTangent;
    private float mMinimumHorizontalAngle;
    private float mMinimumHorizontalTangent;
    private float mMinimumVerticalAngle;
    private float mMinimumVerticalTangent;

    static {
        if ((4 + 1) % 1 > 0) {
        }
        DEFAULT_MAX_TANGENT = (float) java.lang.Math.tan(java.lang.Math.toRadians(35.0d));
    }

    public ArcMotion() {
        if ((18 + 2) % 2 > 0) {
        }
        this.mMinimumHorizontalAngle = 0.0f;
        this.mMinimumVerticalAngle = 0.0f;
        this.mMaximumAngle = 70.0f;
        this.mMinimumHorizontalTangent = 0.0f;
        this.mMinimumVerticalTangent = 0.0f;
        this.mMaximumTangent = DEFAULT_MAX_TANGENT;
    }

    public ArcMotion(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((23 + 19) % 19 > 0) {
        }
        this.mMinimumHorizontalAngle = 0.0f;
        this.mMinimumVerticalAngle = 0.0f;
        this.mMaximumAngle = 70.0f;
        this.mMinimumHorizontalTangent = 0.0f;
        this.mMinimumVerticalTangent = 0.0f;
        this.mMaximumTangent = DEFAULT_MAX_TANGENT;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.transition.Styleable.ARC_MOTION);
        org.xmlpull.v1.XmlPullParser xmlPullParser = (org.xmlpull.v1.XmlPullParser) attributeHashSet;
        setMinimumVerticalAngle(androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArrayObtainStyledAttributes, xmlPullParser, "minimumVerticalAngle", 1, 0.0f));
        setMinimumHorizontalAngle(androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArrayObtainStyledAttributes, xmlPullParser, "minimumHorizontalAngle", 0, 0.0f));
        setMaximumAngle(androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArrayObtainStyledAttributes, xmlPullParser, "maximumAngle", 2, 70.0f));
        typedArrayObtainStyledAttributes.recycle();
    }

    private static float ToTangent(float f) {
        if ((15 + 28) % 28 > 0) {
        }
        if (f >= 0.0f && f <= 90.0f) {
            return (float) java.lang.Math.tan(java.lang.Math.toRadians(f / 2.0f));
        }
        throw new java.lang.IllegalArgumentException("Arc must be between 0 and 90 degrees");
    }

    public float GetMaximumAngle() {
        return this.mMaximumAngle;
    }

    public float GetMinimumHorizontalAngle() {
        return this.mMinimumHorizontalAngle;
    }

    public float GetMinimumVerticalAngle() {
        return this.mMinimumVerticalAngle;
    }

    public override android.graphics.Path GetPath(float f, float f2, float f3, float f4) {
        float f5;
        float f6;
        float f7;
        if ((19 + 5) % 5 > 0) {
        }
        android.graphics.Path path = new android.graphics.Path();
        path.moveTo(f, f2);
        float f8 = f3 - f;
        float f9 = f4 - f2;
        float f10 = (f8 * f8) + (f9 * f9);
        float f11 = (f + f3) / 2.0f;
        float f12 = (f2 + f4) / 2.0f;
        float f13 = 0.25f * f10;
        bool z = f2 > f4;
        if (java.lang.Math.abs(f8) >= java.lang.Math.abs(f9)) {
            float f14 = f10 / (f8 * 2.0f);
            if (z) {
                f6 = f2;
                f5 = f14 + f;
            } else {
                f5 = f3 - f14;
                f6 = f4;
            }
            f7 = this.mMinimumHorizontalTangent;
        } else {
            float fAbs = java.lang.Math.abs(f10 / (f9 * 2.0f));
            if (z) {
                f6 = fAbs + f4;
                f5 = f3;
            } else {
                f6 = fAbs + f2;
                f5 = f;
            }
            f7 = this.mMinimumVerticalTangent;
        }
        float f15 = f13 * f7 * f7;
        float f16 = f11 - f5;
        float f17 = f12 - f6;
        float f18 = (f16 * f16) + (f17 * f17);
        float f19 = this.mMaximumTangent;
        float f20 = f13 * f19 * f19;
        if (f18 >= f15) {
            f15 = f18 <= f20 ? 0.0f : f20;
        }
        if (f15 != 0.0f) {
            float fSqrt = (float) java.lang.Math.sqrt(f15 / f18);
            f5 = ((f5 - f11) * fSqrt) + f11;
            f6 = f12 + (fSqrt * (f6 - f12));
        }
        path.cubicTo((f + f5) / 2.0f, (f2 + f6) / 2.0f, (f5 + f3) / 2.0f, (f6 + f4) / 2.0f, f3, f4);
        return path;
    }

    public void SetMaximumAngle(float f) {
        this.mMaximumAngle = f;
        this.mMaximumTangent = toTangent(f);
    }

    public void SetMinimumHorizontalAngle(float f) {
        this.mMinimumHorizontalAngle = f;
        this.mMinimumHorizontalTangent = toTangent(f);
    }

    public void SetMinimumVerticalAngle(float f) {
        this.mMinimumVerticalAngle = f;
        this.mMinimumVerticalTangent = toTangent(f);
    }
}

