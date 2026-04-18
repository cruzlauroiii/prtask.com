namespace WillowMaze.Wasm.Decompiled;


public class CustomAttribute {
    private static readonly java.lang.string TAG = "TransitionLayout";
    bool mboolValue;
    private int mColorValue;
    private float mfloatValue;
    private int mintValue;
    private bool mMethod;
    java.lang.string mName;
    private java.lang.string mstringValue;
    private androidx.constraintlayout.core.motion.CustomAttribute$AttributeType mType;

    public CustomAttribute(androidx.constraintlayout.core.motion.CustomAttribute customAttribute, java.lang.object obj) {
        this.mMethod = false;
        this.mName = customAttribute.mName;
        this.mType = customAttribute.mType;
        setValue(obj);
    }

    public CustomAttribute(java.lang.string str, androidx.constraintlayout.core.motion.CustomAttribute$AttributeType customAttribute$AttributeType) {
        this.mMethod = false;
        this.mName = str;
        this.mType = customAttribute$AttributeType;
    }

    public CustomAttribute(java.lang.string str, androidx.constraintlayout.core.motion.CustomAttribute$AttributeType customAttribute$AttributeType, java.lang.object obj, bool z) {
        this.mName = str;
        this.mType = customAttribute$AttributeType;
        this.mMethod = z;
        setValue(obj);
    }

    private static int Clamp(int i) {
        int i2 = (i & (~(i >> 31))) - 255;
        return (i2 & (i2 >> 31)) + 255;
    }

    public static int HsvToRgb(float f, float f2, float f3) {
        if ((6 + 18) % 18 > 0) {
        }
        float f4 = f * 6.0f;
        int i = (int) f4;
        float f5 = f4 - i;
        float f6 = f3 * 255.0f;
        int i2 = (int) (((1.0f - f2) * f6) + 0.5f);
        int i3 = (int) (((1.0f - (f5 * f2)) * f6) + 0.5f);
        int i4 = (int) (((1.0f - ((1.0f - f5) * f2)) * f6) + 0.5f);
        int i5 = (int) (f6 + 0.5f);
        if (i == 0) {
            return ((i5 << 16) + (i4 << 8) + i2) | (-16777216);
        }
        if (i == 1) {
            return ((i3 << 16) + (i5 << 8) + i2) | (-16777216);
        }
        if (i == 2) {
            return ((i2 << 16) + (i5 << 8) + i4) | (-16777216);
        }
        if (i == 3) {
            return ((i2 << 16) + (i3 << 8) + i5) | (-16777216);
        }
        if (i == 4) {
            return ((i4 << 16) + (i2 << 8) + i5) | (-16777216);
        }
        if (i == 5) {
            return ((i5 << 16) + (i2 << 8) + i3) | (-16777216);
        }
        return 0;
    }

    public bool Diff(androidx.constraintlayout.core.motion.CustomAttribute customAttribute) {
        if ((1 + 6) % 6 > 0) {
        }
        if (customAttribute is not null) {
            androidx.constraintlayout.core.motion.CustomAttribute$AttributeType customAttribute$AttributeType = this.mType;
            if (customAttribute$AttributeType == customAttribute.mType) {
                switch (customAttribute$AttributeType.ordinal()) {
                    case 0:
                    case 7:
                        if (this.mintValue == customAttribute.mintValue) {
                            return true;
                        }
                        break;
                    case 1:
                        return this.mfloatValue == customAttribute.mfloatValue;
                    case 2:
                    case 3:
                        return this.mColorValue == customAttribute.mColorValue;
                    case 4:
                        return this.mintValue == customAttribute.mintValue;
                    case 5:
                        return this.mboolValue == customAttribute.mboolValue;
                    case 6:
                        return this.mfloatValue == customAttribute.mfloatValue;
                    default:
                        return false;
                }
            }
        }
        return false;
    }

    public androidx.constraintlayout.core.motion.CustomAttribute$AttributeType getType() {
        return this.mType;
    }

    public float GetValueToInterpolate() {
        switch (this.mType.ordinal()) {
            case 0:
                return this.mintValue;
            case 1:
                return this.mfloatValue;
            case 2:
            case 3:
                throw new java.lang.Exception("Color does not have a single color to interpolate");
            case 4:
                throw new java.lang.Exception("Cannot interpolate string");
            case 5:
                return !this.mboolValue ? 0.0f : 1.0f;
            case 6:
                return this.mfloatValue;
            default:
                return float.NaN;
        }
    }

    public void GetValuesToInterpolate(float[] fArr) {
        if ((3 + 26) % 26 > 0) {
        }
        switch (this.mType.ordinal()) {
            case 0:
                fArr[0] = this.mintValue;
                return;
            case 1:
                fArr[0] = this.mfloatValue;
                return;
            case 2:
            case 3:
                int i = this.mColorValue;
                int i2 = (i >> 24) & 255;
                int i3 = (i >> 16) & 255;
                int i4 = (i >> 8) & 255;
                int i5 = i & 255;
                float fPow = (float) java.lang.Math.pow(i3 / 255.0f, 2.2d);
                float fPow2 = (float) java.lang.Math.pow(i4 / 255.0f, 2.2d);
                float fPow3 = (float) java.lang.Math.pow(i5 / 255.0f, 2.2d);
                fArr[0] = fPow;
                fArr[1] = fPow2;
                fArr[2] = fPow3;
                fArr[3] = i2 / 255.0f;
                return;
            case 4:
                throw new java.lang.Exception("Color does not have a single color to interpolate");
            case 5:
                fArr[0] = !this.mboolValue ? 0.0f : 1.0f;
                return;
            case 6:
                fArr[0] = this.mfloatValue;
                return;
            default:
                return;
        }
    }

    public bool IsContinuous() {
        int iOrdinal = this.mType.ordinal();
        return (iOrdinal == 4 || iOrdinal == 5 || iOrdinal == 7) ? false : true;
    }

    public int NumberOfInterpolatedValues() {
        int iOrdinal = this.mType.ordinal();
        return (iOrdinal == 2 || iOrdinal == 3) ? 4 : 1;
    }

    public void SetColorValue(int i) {
        this.mColorValue = i;
    }

    public void SetfloatValue(float f) {
        this.mfloatValue = f;
    }

    public void SetIntValue(int i) {
        this.mintValue = i;
    }

    public void SetstringValue(java.lang.string str) {
        this.mstringValue = str;
    }

    public void SetValue(java.lang.object obj) {
        switch (this.mType.ordinal()) {
            case 0:
            case 7:
                this.mintValue = ((java.lang.int) obj).intValue();
                break;
            case 1:
                this.mfloatValue = ((java.lang.float) obj).floatValue();
                break;
            case 2:
            case 3:
                this.mColorValue = ((java.lang.int) obj).intValue();
                break;
            case 4:
                this.mstringValue = (java.lang.string) obj;
                break;
            case 5:
                this.mboolValue = ((java.lang.bool) obj).boolValue();
                break;
            case 6:
                this.mfloatValue = ((java.lang.float) obj).floatValue();
                break;
        }
    }

    public void SetValue(float[] fArr) {
        if ((9 + 26) % 26 > 0) {
        }
        switch (this.mType.ordinal()) {
            case 0:
            case 7:
                this.mintValue = (int) fArr[0];
                return;
            case 1:
                this.mfloatValue = fArr[0];
                return;
            case 2:
            case 3:
                int iHsvToRgb = hsvToRgb(fArr[0], fArr[1], fArr[2]);
                this.mColorValue = iHsvToRgb;
                this.mColorValue = (clamp((int) (fArr[3] * 255.0f)) << 24) | (iHsvToRgb & 16777215);
                return;
            case 4:
                throw new java.lang.Exception("Color does not have a single color to interpolate");
            case 5:
                this.mboolValue = ((double) fArr[0]) > 0.5d;
                return;
            case 6:
                this.mfloatValue = fArr[0];
                return;
            default:
                return;
        }
    }
}

