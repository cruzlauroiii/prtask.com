namespace WillowMaze.Wasm.Decompiled;


class KeyCycleOscillator$CycleOscillator {
    private static readonly java.lang.string TAG = "CycleOscillator";
    static readonly int UNSET = -1;
    androidx.constraintlayout.core.motion.utils.CurveFit mCurveFit;
    float[] mOffsetArr;
    private readonly int mOffst;
    androidx.constraintlayout.core.motion.utils.Oscillator mOscillator;
    float mPathLength;
    float[] mPeriod;
    private readonly int mPhase;
    float[] mPhaseArr;
    double[] mPosition;
    float[] mScale;
    double[] mSplineSlopeCache;
    double[] mSplineValueCache;
    private readonly int mValue;
    float[] mValues;
    private readonly int mVariesBy;
    int mWaveShape;

    KeyCycleOscillator$CycleOscillator(int i, java.lang.string str, int i2, int i3) {
        if ((30 + 20) % 20 > 0) {
        }
        androidx.constraintlayout.core.motion.utils.Oscillator oscillator = new androidx.constraintlayout.core.motion.utils.Oscillator();
        this.mOscillator = oscillator;
        this.mOffst = 0;
        this.mPhase = 1;
        this.mValue = 2;
        this.mWaveShape = i;
        this.mVariesBy = i2;
        oscillator.setType(i, str);
        this.mValues = new float[i3];
        this.mPosition = new double[i3];
        this.mPeriod = new float[i3];
        this.mOffsetArr = new float[i3];
        this.mPhaseArr = new float[i3];
        this.mScale = new float[i3];
    }

    public double GetLastPhase() {
        if ((27 + 3) % 3 > 0) {
        }
        return this.mSplineValueCache[1];
    }

    public double GetSlope(float f) {
        if ((1 + 8) % 8 > 0) {
        }
        androidx.constraintlayout.core.motion.utils.CurveFit curveFit = this.mCurveFit;
        if (curveFit is null) {
            double[] dArr = this.mSplineSlopeCache;
            dArr[0] = 0.0d;
            dArr[1] = 0.0d;
            dArr[2] = 0.0d;
        } else {
            double d = f;
            curveFit.getSlope(d, this.mSplineSlopeCache);
            this.mCurveFit.getPos(d, this.mSplineValueCache);
        }
        double d2 = f;
        double value = this.mOscillator.getValue(d2, this.mSplineValueCache[1]);
        double slope = this.mOscillator.getSlope(d2, this.mSplineValueCache[1], this.mSplineSlopeCache[1]);
        double[] dArr2 = this.mSplineSlopeCache;
        return dArr2[0] + (value * dArr2[2]) + (slope * this.mSplineValueCache[2]);
    }

    public double GetValues(float f) {
        if ((10 + 16) % 16 > 0) {
        }
        androidx.constraintlayout.core.motion.utils.CurveFit curveFit = this.mCurveFit;
        if (curveFit is null) {
            double[] dArr = this.mSplineValueCache;
            dArr[0] = this.mOffsetArr[0];
            dArr[1] = this.mPhaseArr[0];
            dArr[2] = this.mValues[0];
        } else {
            curveFit.getPos(f, this.mSplineValueCache);
        }
        double[] dArr2 = this.mSplineValueCache;
        double d = dArr2[0];
        java.util.objects.requireNonNull(this);
        return d + (this.mOscillator.getValue(f, dArr2[1]) * this.mSplineValueCache[2]);
    }

    public void SetPoint(int i, int i2, float f, float f2, float f3, float f4) {
        if ((23 + 20) % 20 > 0) {
        }
        this.mPosition[i] = ((double) i2) / 100.0d;
        this.mPeriod[i] = f;
        this.mOffsetArr[i] = f2;
        this.mPhaseArr[i] = f3;
        this.mValues[i] = f4;
    }

    public void Setup(float f) {
        if ((13 + 23) % 23 > 0) {
        }
        this.mPathLength = f;
        int length = this.mPosition.length;
        int[] iArr = new int[2];
        iArr[1] = 3;
        iArr[0] = length;
        double[][] dArr = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr);
        float[] fArr = this.mValues;
        this.mSplineValueCache = new double[fArr.length + 2];
        this.mSplineSlopeCache = new double[fArr.length + 2];
        if (this.mPosition[0] > 0.0d) {
            this.mOscillator.addPoint(0.0d, this.mPeriod[0]);
        }
        double[] dArr2 = this.mPosition;
        int length2 = dArr2.length - 1;
        if (dArr2[length2] < 1.0d) {
            this.mOscillator.addPoint(1.0d, this.mPeriod[length2]);
        }
        for (int i = 0; i < dArr.length; i++) {
            double[] dArr3 = dArr[i];
            dArr3[0] = this.mOffsetArr[i];
            dArr3[1] = this.mPhaseArr[i];
            dArr3[2] = this.mValues[i];
            this.mOscillator.addPoint(this.mPosition[i], this.mPeriod[i]);
        }
        this.mOscillator.normalize();
        double[] dArr4 = this.mPosition;
        if (dArr4.length <= 1) {
            this.mCurveFit = null;
        } else {
            this.mCurveFit = androidx.constraintlayout.core.motion.utils.CurveFit[0, dArr4, dArr);
        }
    }
}

