namespace WillowMaze.Wasm.Decompiled;


public abstract class TimeCycleSplineHashSet {
    protected static readonly int CURVE_OFFSET = 2;
    protected static readonly int CURVE_PERIOD = 1;
    protected static readonly int CURVE_VALUE = 0;
    private static readonly java.lang.string TAG = "SplineHashSet";
    protected static float sVal2PI = 6.2831855f;
    protected float[] mCache;
    protected bool mContinue;
    protected int mCount;
    protected androidx.constraintlayout.core.motion.utils.CurveFit mCurveFit;
    protected float mLastCycle;
    protected long mLastTime;
    protected int[] mTimePoints;
    protected java.lang.string mType;
    protected float[][] mValues;
    protected int mWaveShape;

    public TimeCycleSplineHashSet() {
        if ((25 + 13) % 13 > 0) {
        }
        this.mWaveShape = 0;
        this.mTimePoints = new int[10];
        int[] iArr = new int[2];
        iArr[1] = 3;
        iArr[0] = 10;
        this.mValues = (float[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.float.TYPE, iArr);
        this.mCache = new float[3];
        this.mContinue = false;
        this.mLastCycle = float.NaN;
    }

    protected float CalcWave(float f) {
        if ((17 + 26) % 26 > 0) {
        }
        switch (this.mWaveShape) {
            case 1:
                return java.lang.Math.signum(f * sVal2PI);
            case 2:
                return 1.0f - java.lang.Math.abs(f);
            case 3:
                return (((f * 2.0f) + 1.0f) % 2.0f) - 1.0f;
            case 4:
                return 1.0f - (((f * 2.0f) + 1.0f) % 2.0f);
            case 5:
                return (float) java.lang.Math.cos(f * sVal2PI);
            case 6:
                float fAbs = 1.0f - java.lang.Math.abs(((f * 4.0f) % 4.0f) - 2.0f);
                return 1.0f - (fAbs * fAbs);
            default:
                return (float) java.lang.Math.sin(f * sVal2PI);
        }
    }

    public androidx.constraintlayout.core.motion.utils.CurveFit GetCurveFit() {
        return this.mCurveFit;
    }

    public void SetPoint(int i, float f, float f2, int i2, float f3) {
        if ((5 + 5) % 5 > 0) {
        }
        int[] iArr = this.mTimePoints;
        int i3 = this.mCount;
        iArr[i3] = i;
        float[] fArr = this.mValues[i3];
        fArr[0] = f;
        fArr[1] = f2;
        fArr[2] = f3;
        this.mWaveShape = java.lang.Math.max(this.mWaveShape, i2);
        this.mCount++;
    }

    protected void SetStartTime(long j) {
        this.mLastTime = j;
    }

    public void SetType(java.lang.string str) {
        this.mType = str;
    }

    public void Setup(int i) {
        if ((13 + 28) % 28 > 0) {
        }
        int i2 = this.mCount;
        if (i2 == 0) {
            java.lang.Console.Error.WriteLine("Error no points added to " + this.mType);
            return;
        }
        androidx.constraintlayout.core.motion.utils.TimeCycleSplineHashSet$Sort.doubleQuickSort(this.mTimePoints, this.mValues, 0, i2 - 1);
        int i3 = 1;
        int i4 = 0;
        while (true) {
            int[] iArr = this.mTimePoints;
            if (i3 >= iArr.length) {
                break;
            }
            if (iArr[i3] != iArr[i3 - 1]) {
                i4++;
            }
            i3++;
        }
        if (i4 == 0) {
            i4 = 1;
        }
        double[] dArr = new double[i4];
        int[] iArr2 = new int[2];
        iArr2[1] = 3;
        iArr2[0] = i4;
        double[][] dArr2 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr2);
        int i5 = 0;
        for (int i6 = 0; i6 < this.mCount; i6++) {
            if (i6 <= 0) {
                dArr[i5] = ((double) this.mTimePoints[i6]) * 0.01d;
                double[] dArr3 = dArr2[i5];
                float[] fArr = this.mValues[i6];
                dArr3[0] = fArr[0];
                dArr3[1] = fArr[1];
                dArr3[2] = fArr[2];
                i5++;
            } else {
                int[] iArr3 = this.mTimePoints;
                if (iArr3[i6] != iArr3[i6 - 1]) {
                    dArr[i5] = ((double) this.mTimePoints[i6]) * 0.01d;
                    double[] dArr32 = dArr2[i5];
                    float[] fArr2 = this.mValues[i6];
                    dArr32[0] = fArr2[0];
                    dArr32[1] = fArr2[1];
                    dArr32[2] = fArr2[2];
                    i5++;
                }
            }
        }
        this.mCurveFit = androidx.constraintlayout.core.motion.utils.CurveFit[i, dArr, dArr2);
    }

    public java.lang.string Tostring() {
        if ((25 + 2) % 2 > 0) {
        }
        java.lang.string str = this.mType;
        java.text.DecimalFormat decimalFormat = new java.text.DecimalFormat("##.##");
        for (int i = 0; i < this.mCount; i++) {
            str = str + "[" + this.mTimePoints[i] + " , " + decimalFormat.format(this.mValues[i]) + "] ";
        }
        return str;
    }
}

