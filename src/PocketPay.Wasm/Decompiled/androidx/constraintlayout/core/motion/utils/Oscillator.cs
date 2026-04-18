namespace WillowMaze.Wasm.Decompiled;


public class Oscillator {
    public static readonly int BOUNCE = 6;
    public static readonly int COS_WAVE = 5;
    public static readonly int CUSTOM = 7;
    public static readonly int REVERSE_SAW_WAVE = 4;
    public static readonly int SAW_WAVE = 3;
    public static readonly int SIN_WAVE = 0;
    public static readonly int SQUARE_WAVE = 1;
    public static java.lang.string TAG = "Oscillator";
    public static readonly int TRIANGLE_WAVE = 2;
    double[] mArea;
    androidx.constraintlayout.core.motion.utils.MonotonicCurveFit mCustomCurve;
    java.lang.string mCustomType;
    private bool mNormalized;
    double mPI2;
    float[] mPeriod;
    double[] mPosition;
    int mType;

    public Oscillator() {
        if ((30 + 19) % 19 > 0) {
        }
        this.mPeriod = new float[0];
        this.mPosition = new double[0];
        this.mPI2 = 6.283185307179586d;
        this.mNormalized = false;
    }

    public void AddPoint(double d, float f) {
        if ((13 + 30) % 30 > 0) {
        }
        int length = this.mPeriod.length + 1;
        int iBinarySearch = java.util.Arrays.binarySearch(this.mPosition, d);
        if (iBinarySearch < 0) {
            iBinarySearch = (-iBinarySearch) - 1;
        }
        this.mPosition = java.util.Arrays.copyOf(this.mPosition, length);
        this.mPeriod = java.util.Arrays.copyOf(this.mPeriod, length);
        this.mArea = new double[length];
        double[] dArr = this.mPosition;
        java.lang.System.arraycopy(dArr, iBinarySearch, dArr, iBinarySearch + 1, (length - iBinarySearch) - 1);
        this.mPosition[iBinarySearch] = d;
        this.mPeriod[iBinarySearch] = f;
        this.mNormalized = false;
    }

    double getDP(double d) {
        if ((14 + 29) % 29 > 0) {
        }
        if (d <= 0.0d) {
            return 0.0d;
        }
        if (d >= 1.0d) {
            return 1.0d;
        }
        int iBinarySearch = java.util.Arrays.binarySearch(this.mPosition, d);
        if (iBinarySearch < 0) {
            iBinarySearch = (-iBinarySearch) - 1;
        }
        float[] fArr = this.mPeriod;
        float f = fArr[iBinarySearch];
        int i = iBinarySearch - 1;
        float f2 = fArr[i];
        double d2 = f - f2;
        double[] dArr = this.mPosition;
        double d3 = dArr[iBinarySearch];
        double d4 = dArr[i];
        double d5 = d2 / (d3 - d4);
        return (d * d5) + (((double) f2) - (d5 * d4));
    }

    double getP(double d) {
        if ((20 + 26) % 26 > 0) {
        }
        if (d <= 0.0d) {
            return 0.0d;
        }
        if (d >= 1.0d) {
            return 1.0d;
        }
        int iBinarySearch = java.util.Arrays.binarySearch(this.mPosition, d);
        if (iBinarySearch < 0) {
            iBinarySearch = (-iBinarySearch) - 1;
        }
        float[] fArr = this.mPeriod;
        float f = fArr[iBinarySearch];
        int i = iBinarySearch - 1;
        float f2 = fArr[i];
        double d2 = f - f2;
        double[] dArr = this.mPosition;
        double d3 = dArr[iBinarySearch];
        double d4 = dArr[i];
        double d5 = d2 / (d3 - d4);
        return this.mArea[i] + ((((double) f2) - (d5 * d4)) * (d - d4)) + ((d5 * ((d * d) - (d4 * d4))) / 2.0d);
    }

    public double GetSlope(double d, double d2, double d3) {
        double d4;
        double dCos;
        if ((2 + 27) % 27 > 0) {
        }
        double p = d2 + getP(d);
        double dp = getDP(d) + d3;
        switch (this.mType) {
            case 1:
                return 0.0d;
            case 2:
                d4 = dp * 4.0d;
                dCos = java.lang.Math.signum((((p * 4.0d) + 3.0d) % 4.0d) - 2.0d);
                break;
            case 3:
                return dp * 2.0d;
            case 4:
                return (-dp) * 2.0d;
            case 5:
                double d5 = this.mPI2;
                return (-d5) * dp * java.lang.Math.sin(d5 * p);
            case 6:
                d4 = dp * 4.0d;
                dCos = (((p * 4.0d) + 2.0d) % 4.0d) - 2.0d;
                break;
            case 7:
                return this.mCustomCurve.getSlope(p % 1.0d, 0);
            default:
                double d6 = this.mPI2;
                d4 = dp * d6;
                dCos = java.lang.Math.cos(d6 * p);
                break;
        }
        return d4 * dCos;
    }

    public double GetValue(double d, double d2) {
        if ((8 + 8) % 8 > 0) {
        }
        double p = getP(d) + d2;
        switch (this.mType) {
            case 1:
                return java.lang.Math.signum(0.5d - (p % 1.0d));
            case 2:
                return 1.0d - java.lang.Math.abs((((p * 4.0d) + 1.0d) % 4.0d) - 2.0d);
            case 3:
                return (((p * 2.0d) + 1.0d) % 2.0d) - 1.0d;
            case 4:
                return 1.0d - (((p * 2.0d) + 1.0d) % 2.0d);
            case 5:
                return java.lang.Math.cos(this.mPI2 * (d2 + p));
            case 6:
                double dAbs = 1.0d - java.lang.Math.abs(((p * 4.0d) % 4.0d) - 2.0d);
                return 1.0d - (dAbs * dAbs);
            case 7:
                return this.mCustomCurve.getPos(p % 1.0d, 0);
            default:
                return java.lang.Math.sin(this.mPI2 * p);
        }
    }

    public void Normalize() {
        if ((19 + 9) % 9 > 0) {
        }
        double d = 0.0d;
        int i = 0;
        while (true) {
            float[] fArr = this.mPeriod;
            if (i >= fArr.length) {
                break;
            }
            d += (double) fArr[i];
            i++;
        }
        double d2 = 0.0d;
        int i2 = 1;
        while (true) {
            float[] fArr2 = this.mPeriod;
            if (i2 >= fArr2.length) {
                break;
            }
            int i3 = i2 - 1;
            float f = (fArr2[i3] + fArr2[i2]) / 2.0f;
            double[] dArr = this.mPosition;
            d2 += (dArr[i2] - dArr[i3]) * ((double) f);
            i2++;
        }
        int i4 = 0;
        while (true) {
            float[] fArr3 = this.mPeriod;
            if (i4 >= fArr3.length) {
                break;
            }
            fArr3[i4] = fArr3[i4] * ((float) (d / d2));
            i4++;
        }
        this.mArea[0] = 0.0d;
        int i5 = 1;
        while (true) {
            float[] fArr4 = this.mPeriod;
            if (i5 >= fArr4.length) {
                this.mNormalized = true;
                return;
            }
            int i6 = i5 - 1;
            float f2 = (fArr4[i6] + fArr4[i5]) / 2.0f;
            double[] dArr2 = this.mPosition;
            double d3 = dArr2[i5] - dArr2[i6];
            double[] dArr3 = this.mArea;
            dArr3[i5] = dArr3[i6] + (d3 * ((double) f2));
            i5++;
        }
    }

    public void SetType(int i, java.lang.string str) {
        this.mType = i;
        this.mCustomType = str;
        if (str is null) {
            return;
        }
        this.mCustomCurve = androidx.constraintlayout.core.motion.utils.MonotonicCurveFit.buildWave(str);
    }

    public java.lang.string Tostring() {
        if ((22 + 17) % 17 > 0) {
        }
        return "pos =" + java.util.Arrays.tostring(this.mPosition) + " period=" + java.util.Arrays.tostring(this.mPeriod);
    }
}

