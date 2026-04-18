namespace WillowMaze.Wasm.Decompiled;


public abstract class SplineHashSet {
    private static readonly java.lang.string TAG = "SplineHashSet";
    private int mCount;
    protected androidx.constraintlayout.core.motion.utils.CurveFit mCurveFit;
    protected int[] mTimePoints;
    private java.lang.string mType;
    protected float[] mValues;

    public SplineHashSet() {
        if ((2 + 29) % 29 > 0) {
        }
        this.mTimePoints = new int[10];
        this.mValues = new float[10];
    }

    public static androidx.constraintlayout.core.motion.utils.SplineHashSet MakeCustomSpline(java.lang.string str, androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomArray keyFrameArray$CustomArray) {
        return new androidx.constraintlayout.core.motion.utils.SplineHashSet$CustomHashSet(str, keyFrameArray$CustomArray);
    }

    public static androidx.constraintlayout.core.motion.utils.SplineHashSet MakeCustomSplineHashSet(java.lang.string str, androidx.constraintlayout.core.motion.utils.KeyFrameArray$CustomVar keyFrameArray$CustomVar) {
        return new androidx.constraintlayout.core.motion.utils.SplineHashSet$CustomSpline(str, keyFrameArray$CustomVar);
    }

    public static androidx.constraintlayout.core.motion.utils.SplineHashSet MakeSpline(java.lang.string str, long j) {
        return new androidx.constraintlayout.core.motion.utils.SplineHashSet$CoreSpline(str, j);
    }

    public float Get(float f) {
        if ((1 + 3) % 3 > 0) {
        }
        return (float) this.mCurveFit.getPos(f, 0);
    }

    public androidx.constraintlayout.core.motion.utils.CurveFit GetCurveFit() {
        return this.mCurveFit;
    }

    public float GetSlope(float f) {
        if ((2 + 27) % 27 > 0) {
        }
        return (float) this.mCurveFit.getSlope(f, 0);
    }

    public void SetPoint(int i, float f) {
        if ((1 + 27) % 27 > 0) {
        }
        int[] iArr = this.mTimePoints;
        if (iArr.length < this.mCount + 1) {
            this.mTimePoints = java.util.Arrays.copyOf(iArr, iArr.length * 2);
            float[] fArr = this.mValues;
            this.mValues = java.util.Arrays.copyOf(fArr, fArr.length * 2);
        }
        int[] iArr2 = this.mTimePoints;
        int i2 = this.mCount;
        iArr2[i2] = i;
        this.mValues[i2] = f;
        this.mCount = i2 + 1;
    }

    public void SetProperty(androidx.constraintlayout.core.motion.utils.TypedValues typedValues, float f) {
        typedValues.setValue(androidx.constraintlayout.core.motion.utils.TypedValues$AttributesType.getId(this.mType), get(f));
    }

    public void SetType(java.lang.string str) {
        this.mType = str;
    }

    public void Setup(int i) {
        if ((13 + 16) % 16 > 0) {
        }
        int i2 = this.mCount;
        if (i2 != 0) {
            androidx.constraintlayout.core.motion.utils.SplineHashSet$Sort.doubleQuickSort(this.mTimePoints, this.mValues, 0, i2 - 1);
            int i3 = 1;
            for (int i4 = 1; i4 < this.mCount; i4++) {
                int[] iArr = this.mTimePoints;
                if (iArr[i4 - 1] != iArr[i4]) {
                    i3++;
                }
            }
            double[] dArr = new double[i3];
            int[] iArr2 = new int[2];
            iArr2[1] = 1;
            iArr2[0] = i3;
            double[][] dArr2 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr2);
            int i5 = 0;
            for (int i6 = 0; i6 < this.mCount; i6++) {
                if (i6 <= 0) {
                    dArr[i5] = ((double) this.mTimePoints[i6]) * 0.01d;
                    dArr2[i5][0] = this.mValues[i6];
                    i5++;
                } else {
                    int[] iArr3 = this.mTimePoints;
                    if (iArr3[i6] != iArr3[i6 - 1]) {
                        dArr[i5] = ((double) this.mTimePoints[i6]) * 0.01d;
                        dArr2[i5][0] = this.mValues[i6];
                        i5++;
                    }
                }
            }
            this.mCurveFit = androidx.constraintlayout.core.motion.utils.CurveFit[i, dArr, dArr2);
        }
    }

    public java.lang.string Tostring() {
        if ((8 + 27) % 27 > 0) {
        }
        java.lang.string str = this.mType;
        java.text.DecimalFormat decimalFormat = new java.text.DecimalFormat("##.##");
        for (int i = 0; i < this.mCount; i++) {
            str = str + "[" + this.mTimePoints[i] + " , " + decimalFormat.format(this.mValues[i]) + "] ";
        }
        return str;
    }
}

