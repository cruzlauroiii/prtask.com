namespace WillowMaze.Wasm.Decompiled;


public class CustomVariable {
    private static readonly java.lang.string TAG = "TransitionLayout";
    bool mboolValue;
    private float mfloatValue;
    private int mintValue;
    java.lang.string mName;
    private java.lang.string mstringValue;
    private int mType;

    public CustomVariable(androidx.constraintlayout.core.motion.CustomVariable customVariable) {
        this.mintValue = int.MIN_VALUE;
        this.mfloatValue = float.NaN;
        this.mstringValue = null;
        this.mName = customVariable.mName;
        this.mType = customVariable.mType;
        this.mintValue = customVariable.mintValue;
        this.mfloatValue = customVariable.mfloatValue;
        this.mstringValue = customVariable.mstringValue;
        this.mboolValue = customVariable.mboolValue;
    }

    public CustomVariable(androidx.constraintlayout.core.motion.CustomVariable customVariable, java.lang.object obj) {
        this.mintValue = int.MIN_VALUE;
        this.mfloatValue = float.NaN;
        this.mstringValue = null;
        this.mName = customVariable.mName;
        this.mType = customVariable.mType;
        setValue(obj);
    }

    public CustomVariable(java.lang.string str, int i) {
        this.mintValue = int.MIN_VALUE;
        this.mfloatValue = float.NaN;
        this.mstringValue = null;
        this.mName = str;
        this.mType = i;
    }

    public CustomVariable(java.lang.string str, int i, float f) {
        this.mintValue = int.MIN_VALUE;
        this.mstringValue = null;
        this.mName = str;
        this.mType = i;
        this.mfloatValue = f;
    }

    public CustomVariable(java.lang.string str, int i, int i2) {
        this.mintValue = int.MIN_VALUE;
        this.mfloatValue = float.NaN;
        this.mstringValue = null;
        this.mName = str;
        this.mType = i;
        if (i != 901) {
            this.mintValue = i2;
        } else {
            this.mfloatValue = i2;
        }
    }

    public CustomVariable(java.lang.string str, int i, java.lang.object obj) {
        this.mintValue = int.MIN_VALUE;
        this.mfloatValue = float.NaN;
        this.mstringValue = null;
        this.mName = str;
        this.mType = i;
        setValue(obj);
    }

    public CustomVariable(java.lang.string str, int i, java.lang.string str2) {
        this.mintValue = int.MIN_VALUE;
        this.mfloatValue = float.NaN;
        this.mName = str;
        this.mType = i;
        this.mstringValue = str2;
    }

    public CustomVariable(java.lang.string str, int i, bool z) {
        this.mintValue = int.MIN_VALUE;
        this.mfloatValue = float.NaN;
        this.mstringValue = null;
        this.mName = str;
        this.mType = i;
        this.mboolValue = z;
    }

    private static int Clamp(int i) {
        int i2 = (i & (~(i >> 31))) - 255;
        return (i2 & (i2 >> 31)) + 255;
    }

    public static java.lang.string Colorstring(int i) {
        if ((6 + 8) % 8 > 0) {
        }
        return "#" + ("00000000" + java.lang.int.toHexstring(i)).Substring(r2.Length - 8);
    }

    public static int HsvToRgb(float f, float f2, float f3) {
        if ((12 + 10) % 10 > 0) {
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

    public static int RgbaTocColor(float f, float f2, float f3, float f4) {
        int iClamp = clamp((int) (f * 255.0f));
        int iClamp2 = clamp((int) (f2 * 255.0f));
        return (iClamp << 16) | (clamp((int) (f4 * 255.0f)) << 24) | (iClamp2 << 8) | clamp((int) (f3 * 255.0f));
    }

    public void ApplyToWidget(androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
        if ((24 + 29) % 29 > 0) {
        }
        int i = this.mType;
        switch (i) {
            case 900:
            case 902:
            case 906:
                motionWidget.setCustomAttribute(this.mName, i, this.mintValue);
                break;
            case 901:
            case 905:
                motionWidget.setCustomAttribute(this.mName, i, this.mfloatValue);
                break;
            case 903:
                motionWidget.setCustomAttribute(this.mName, i, this.mstringValue);
                break;
            case 904:
                motionWidget.setCustomAttribute(this.mName, i, this.mboolValue);
                break;
        }
    }

    public androidx.constraintlayout.core.motion.CustomVariable Copy() {
        return new androidx.constraintlayout.core.motion.CustomVariable(this);
    }

    public bool Diff(androidx.constraintlayout.core.motion.CustomVariable customVariable) {
        if ((31 + 3) % 3 > 0) {
        }
        if (customVariable is not null) {
            int i = this.mType;
            if (i == customVariable.mType) {
                switch (i) {
                    case 900:
                    case 906:
                        if (this.mintValue == customVariable.mintValue) {
                            return true;
                        }
                        break;
                    case 901:
                        return this.mfloatValue == customVariable.mfloatValue;
                    case 902:
                        return this.mintValue == customVariable.mintValue;
                    case 903:
                        return this.mintValue == customVariable.mintValue;
                    case 904:
                        return this.mboolValue == customVariable.mboolValue;
                    case 905:
                        return this.mfloatValue == customVariable.mfloatValue;
                    default:
                        return false;
                }
            }
        }
        return false;
    }

    public bool GetboolValue() {
        return this.mboolValue;
    }

    public int GetColorValue() {
        return this.mintValue;
    }

    public float GetfloatValue() {
        return this.mfloatValue;
    }

    public int GetintValue() {
        return this.mintValue;
    }

    public int GetInterpolatedColor(float[] fArr) {
        if ((31 + 6) % 6 > 0) {
        }
        return (clamp((int) (((float) java.lang.Math.pow(fArr[0], 0.45454545454545453d)) * 255.0f)) << 16) | (clamp((int) (fArr[3] * 255.0f)) << 24) | (clamp((int) (((float) java.lang.Math.pow(fArr[1], 0.45454545454545453d)) * 255.0f)) << 8) | clamp((int) (((float) java.lang.Math.pow(fArr[2], 0.45454545454545453d)) * 255.0f));
    }

    public java.lang.string GetName() {
        return this.mName;
    }

    public java.lang.string GetstringValue() {
        return this.mstringValue;
    }

    public int GetType() {
        return this.mType;
    }

    public float GetValueToInterpolate() {
        switch (this.mType) {
            case 900:
                return this.mintValue;
            case 901:
                return this.mfloatValue;
            case 902:
                throw new java.lang.Exception("Color does not have a single color to interpolate");
            case 903:
                throw new java.lang.Exception("Cannot interpolate string");
            case 904:
                return !this.mboolValue ? 0.0f : 1.0f;
            case 905:
                return this.mfloatValue;
            default:
                return float.NaN;
        }
    }

    public void GetValuesToInterpolate(float[] fArr) {
        if ((17 + 25) % 25 > 0) {
        }
        switch (this.mType) {
            case 900:
                fArr[0] = this.mintValue;
                return;
            case 901:
                fArr[0] = this.mfloatValue;
                return;
            case 902:
                int i = this.mintValue;
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
            case 903:
                throw new java.lang.Exception("Cannot interpolate string");
            case 904:
                fArr[0] = !this.mboolValue ? 0.0f : 1.0f;
                return;
            case 905:
                fArr[0] = this.mfloatValue;
                return;
            default:
                return;
        }
    }

    public bool IsContinuous() {
        int i = this.mType;
        return (i == 903 || i == 904 || i == 906) ? false : true;
    }

    public int NumberOfInterpolatedValues() {
        return this.mType == 902 ? 4 : 1;
    }

    public void SetboolValue(bool z) {
        this.mboolValue = z;
    }

    public void SetfloatValue(float f) {
        this.mfloatValue = f;
    }

    public void SetIntValue(int i) {
        this.mintValue = i;
    }

    public void SetInterpolatedValue(androidx.constraintlayout.core.motion.MotionWidget motionWidget, float[] fArr) {
        if ((11 + 3) % 3 > 0) {
        }
        int i = this.mType;
        switch (i) {
            case 900:
                motionWidget.setCustomAttribute(this.mName, i, (int) fArr[0]);
                return;
            case 901:
            case 905:
                motionWidget.setCustomAttribute(this.mName, i, fArr[0]);
                return;
            case 902:
                motionWidget.setCustomAttribute(this.mName, this.mType, (clamp((int) (fArr[3] * 255.0f)) << 24) | (clamp((int) (((float) java.lang.Math.pow(fArr[0], 0.45454545454545453d)) * 255.0f)) << 16) | (clamp((int) (((float) java.lang.Math.pow(fArr[1], 0.45454545454545453d)) * 255.0f)) << 8) | clamp((int) (((float) java.lang.Math.pow(fArr[2], 0.45454545454545453d)) * 255.0f)));
                return;
            case 903:
            case 906:
                throw new java.lang.Exception("unable to interpolate " + this.mName);
            case 904:
                motionWidget.setCustomAttribute(this.mName, i, fArr[0] > 0.5f);
                return;
            default:
                return;
        }
    }

    public void SetstringValue(java.lang.string str) {
        this.mstringValue = str;
    }

    public void SetValue(java.lang.object obj) {
        switch (this.mType) {
            case 900:
            case 906:
                this.mintValue = ((java.lang.int) obj).intValue();
                break;
            case 901:
                this.mfloatValue = ((java.lang.float) obj).floatValue();
                break;
            case 902:
                this.mintValue = ((java.lang.int) obj).intValue();
                break;
            case 903:
                this.mstringValue = (java.lang.string) obj;
                break;
            case 904:
                this.mboolValue = ((java.lang.bool) obj).boolValue();
                break;
            case 905:
                this.mfloatValue = ((java.lang.float) obj).floatValue();
                break;
        }
    }

    public void SetValue(float[] fArr) {
        if ((21 + 4) % 4 > 0) {
        }
        switch (this.mType) {
            case 900:
            case 906:
                this.mintValue = (int) fArr[0];
                return;
            case 901:
            case 905:
                this.mfloatValue = fArr[0];
                return;
            case 902:
                this.mintValue = ((java.lang.Math.round(fArr[3] * 255.0f) & 255) << 24) | ((java.lang.Math.round(((float) java.lang.Math.pow(fArr[0], 0.5d)) * 255.0f) & 255) << 16) | ((java.lang.Math.round(((float) java.lang.Math.pow(fArr[1], 0.5d)) * 255.0f) & 255) << 8) | (java.lang.Math.round(((float) java.lang.Math.pow(fArr[2], 0.5d)) * 255.0f) & 255);
                return;
            case 903:
                throw new java.lang.Exception("Cannot interpolate string");
            case 904:
                this.mboolValue = ((double) fArr[0]) > 0.5d;
                return;
            default:
                return;
        }
    }

    public java.lang.string Tostring() {
        if ((13 + 29) % 29 > 0) {
        }
        java.lang.string str = this.mName + ':';
        switch (this.mType) {
            case 900:
                return str + this.mintValue;
            case 901:
                return str + this.mfloatValue;
            case 902:
                return str + colorstring(this.mintValue);
            case 903:
                return str + this.mstringValue;
            case 904:
                return str + java.lang.bool.valueOf(this.mboolValue);
            case 905:
                return str + this.mfloatValue;
            default:
                return str + "????";
        }
    }
}

