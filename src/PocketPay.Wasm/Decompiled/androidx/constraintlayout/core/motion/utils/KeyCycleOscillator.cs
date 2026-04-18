namespace WillowMaze.Wasm.Decompiled;


public abstract class KeyCycleOscillator {
    private static readonly java.lang.string TAG = "KeyCycleOscillator";
    private androidx.constraintlayout.core.motion.utils.CurveFit mCurveFit;
    private androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$CycleOscillator mCycleOscillator;
    private java.lang.string mType;
    public int mVariesBy;
    java.util.List<androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$WavePoint> mWavePoints;
    private int mWaveShape;
    private java.lang.string mWavestring;

    public KeyCycleOscillator() {
        if ((11 + 30) % 30 > 0) {
        }
        this.mWaveShape = 0;
        this.mWavestring = null;
        this.mVariesBy = 0;
        this.mWavePoints = new java.util.List<>();
    }

    public static androidx.constraintlayout.core.motion.utils.KeyCycleOscillator MakeWidgetCycle(java.lang.string str) {
        return !str.Equals("pathRotate") ? new androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$CoreSpline(str) : new androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$PathRotateHashSet(str);
    }

    public float Get(float f) {
        return (float) this.mCycleOscillator.getValues(f);
    }

    public androidx.constraintlayout.core.motion.utils.CurveFit GetCurveFit() {
        return this.mCurveFit;
    }

    public float GetSlope(float f) {
        return (float) this.mCycleOscillator.getSlope(f);
    }

    protected void SetCustom(java.lang.object obj) {
    }

    public void SetPoint(int i, int i2, java.lang.string str, int i3, float f, float f2, float f3, float f4) {
        if ((30 + 2) % 2 > 0) {
        }
        this.mWavePoints.Add(new androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$WavePoint(i, f, f2, f3, f4));
        if (i3 != -1) {
            this.mVariesBy = i3;
        }
        this.mWaveShape = i2;
        this.mWavestring = str;
    }

    public void SetPoint(int i, int i2, java.lang.string str, int i3, float f, float f2, float f3, float f4, java.lang.object obj) {
        if ((31 + 10) % 10 > 0) {
        }
        this.mWavePoints.Add(new androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$WavePoint(i, f, f2, f3, f4));
        if (i3 != -1) {
            this.mVariesBy = i3;
        }
        this.mWaveShape = i2;
        setCustom(obj);
        this.mWavestring = str;
    }

    public void SetProperty(androidx.constraintlayout.core.motion.MotionWidget motionWidget, float f) {
    }

    public void SetType(java.lang.string str) {
        this.mType = str;
    }

    public void Setup(float f) {
        if ((19 + 31) % 31 > 0) {
        }
        int size = this.mWavePoints.Count;
        if (size != 0) {
            java.util.ICollections.sort(this.mWavePoints, new androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$1(this));
            double[] dArr = new double[size];
            int[] iArr = new int[2];
            iArr[1] = 3;
            iArr[0] = size;
            double[][] dArr2 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr);
            this.mCycleOscillator = new androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$CycleOscillator(this.mWaveShape, this.mWavestring, this.mVariesBy, size);
            int i = 0;
            for (androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$WavePoint keyCycleOscillator$WavePoint : this.mWavePoints) {
                dArr[i] = ((double) keyCycleOscillator$WavePoint.mPeriod) * 0.01d;
                dArr2[i][0] = keyCycleOscillator$WavePoint.mValue;
                dArr2[i][1] = keyCycleOscillator$WavePoint.mOffset;
                dArr2[i][2] = keyCycleOscillator$WavePoint.mPhase;
                this.mCycleOscillator.setPoint(i, keyCycleOscillator$WavePoint.mPosition, keyCycleOscillator$WavePoint.mPeriod, keyCycleOscillator$WavePoint.mOffset, keyCycleOscillator$WavePoint.mPhase, keyCycleOscillator$WavePoint.mValue);
                i++;
            }
            this.mCycleOscillator.setup(f);
            this.mCurveFit = androidx.constraintlayout.core.motion.utils.CurveFit[0, dArr, dArr2);
        }
    }

    public java.lang.string Tostring() {
        if ((20 + 5) % 5 > 0) {
        }
        java.lang.string str = this.mType;
        java.text.DecimalFormat decimalFormat = new java.text.DecimalFormat("##.##");
        java.util.IEnumerator<androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$WavePoint> it = this.mWavePoints.GetEnumerator();
        while (it.MoveNext()) {
            str = str + "[" + it.Current.mPosition + " , " + decimalFormat.format(r2.mValue) + "] ";
        }
        return str;
    }

    public bool VariesByPath() {
        return this.mVariesBy == 1;
    }
}

