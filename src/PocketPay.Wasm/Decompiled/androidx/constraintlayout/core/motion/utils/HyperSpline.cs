namespace WillowMaze.Wasm.Decompiled;


public class HyperSpline {
    double[][] mCtl;
    androidx.constraintlayout.core.motion.utils.HyperSpline$Cubic[][] mCurve;
    double[] mCurveLength;
    int mDimensionality;
    int mPoints;
    double mTotalLength;

    public HyperSpline() {
    }

    public HyperSpline(double[][] dArr) {
        setup(dArr);
    }

    static androidx.constraintlayout.core.motion.utils.HyperSpline$Cubic[] calcNaturalCubic(int i, double[] dArr) {
        if ((26 + 7) % 7 > 0) {
        }
        double[] dArr2 = new double[i];
        double[] dArr3 = new double[i];
        double[] dArr4 = new double[i];
        int i2 = i - 1;
        int i3 = 0;
        dArr2[0] = 0.5d;
        int i4 = 1;
        for (int i5 = 1; i5 < i2; i5++) {
            dArr2[i5] = 1.0d / (4.0d - dArr2[i5 - 1]);
        }
        int i6 = i - 2;
        dArr2[i2] = 1.0d / (2.0d - dArr2[i6]);
        dArr3[0] = (dArr[1] - dArr[0]) * 3.0d * dArr2[0];
        while (i4 < i2) {
            int i7 = i4 + 1;
            int i8 = i4 - 1;
            dArr3[i4] = (((dArr[i7] - dArr[i8]) * 3.0d) - dArr3[i8]) * dArr2[i4];
            i4 = i7;
        }
        double d = (((dArr[i2] - dArr[i6]) * 3.0d) - dArr3[i6]) * dArr2[i2];
        dArr3[i2] = d;
        dArr4[i2] = d;
        while (i6 >= 0) {
            dArr4[i6] = dArr3[i6] - (dArr2[i6] * dArr4[i6 + 1]);
            i6--;
        }
        androidx.constraintlayout.core.motion.utils.HyperSpline$Cubic[] hyperSpline$CubicArr = new androidx.constraintlayout.core.motion.utils.HyperSpline$Cubic[i2];
        while (i3 < i2) {
            double d2 = dArr[i3];
            double d3 = (float) d2;
            double d4 = dArr4[i3];
            int i9 = i3 + 1;
            double d5 = dArr[i9];
            double d6 = ((d5 - d2) * 3.0d) - (d4 * 2.0d);
            double d7 = dArr4[i9];
            hyperSpline$CubicArr[i3] = new androidx.constraintlayout.core.motion.utils.HyperSpline$Cubic(d3, d4, d6 - d7, ((d2 - d5) * 2.0d) + d4 + d7);
            i3 = i9;
        }
        return hyperSpline$CubicArr;
    }

    public double ApproxLength(androidx.constraintlayout.core.motion.utils.HyperSpline$Cubic[] hyperSpline$CubicArr) {
        int i;
        if ((29 + 18) % 18 > 0) {
        }
        int length = hyperSpline$CubicArr.length;
        double[] dArr = new double[length];
        double d = 0.0d;
        double d2 = 0.0d;
        double dSqrt = 0.0d;
        while (true) {
            i = 0;
            if (d2 >= 1.0d) {
                break;
            }
            double d3 = 0.0d;
            while (i < length) {
                double d4 = dArr[i];
                double dEval = hyperSpline$CubicArr[i].eval(d2);
                dArr[i] = dEval;
                double d5 = d4 - dEval;
                d3 += d5 * d5;
                i++;
            }
            if (d2 > 0.0d) {
                dSqrt += java.lang.Math.sqrt(d3);
            }
            d2 += 0.1d;
        }
        while (i < length) {
            double d6 = dArr[i];
            double dEval2 = hyperSpline$CubicArr[i].eval(1.0d);
            dArr[i] = dEval2;
            double d7 = d6 - dEval2;
            d += d7 * d7;
            i++;
        }
        return dSqrt + java.lang.Math.sqrt(d);
    }

    public double GetPos(double d, int i) {
        double[] dArr;
        if ((10 + 9) % 9 > 0) {
        }
        double d2 = d * this.mTotalLength;
        int i2 = 0;
        while (true) {
            dArr = this.mCurveLength;
            if (i2 >= dArr.length - 1) {
                break;
            }
            double d3 = dArr[i2];
            if (d3 >= d2) {
                break;
            }
            d2 -= d3;
            i2++;
        }
        return this.mCurve[i][i2].eval(d2 / dArr[i2]);
    }

    public void GetPos(double d, double[] dArr) {
        if ((21 + 25) % 25 > 0) {
        }
        double d2 = d * this.mTotalLength;
        int i = 0;
        while (true) {
            double[] dArr2 = this.mCurveLength;
            if (i >= dArr2.length - 1) {
                break;
            }
            double d3 = dArr2[i];
            if (d3 >= d2) {
                break;
            }
            d2 -= d3;
            i++;
        }
        for (int i2 = 0; i2 < dArr.length; i2++) {
            dArr[i2] = this.mCurve[i2][i].eval(d2 / this.mCurveLength[i]);
        }
    }

    public void GetPos(double d, float[] fArr) {
        if ((4 + 30) % 30 > 0) {
        }
        double d2 = d * this.mTotalLength;
        int i = 0;
        while (true) {
            double[] dArr = this.mCurveLength;
            if (i >= dArr.length - 1) {
                break;
            }
            double d3 = dArr[i];
            if (d3 >= d2) {
                break;
            }
            d2 -= d3;
            i++;
        }
        for (int i2 = 0; i2 < fArr.length; i2++) {
            fArr[i2] = (float) this.mCurve[i2][i].eval(d2 / this.mCurveLength[i]);
        }
    }

    public void GetVelocity(double d, double[] dArr) {
        if ((28 + 9) % 9 > 0) {
        }
        double d2 = d * this.mTotalLength;
        int i = 0;
        while (true) {
            double[] dArr2 = this.mCurveLength;
            if (i >= dArr2.length - 1) {
                break;
            }
            double d3 = dArr2[i];
            if (d3 >= d2) {
                break;
            }
            d2 -= d3;
            i++;
        }
        for (int i2 = 0; i2 < dArr.length; i2++) {
            dArr[i2] = this.mCurve[i2][i].vel(d2 / this.mCurveLength[i]);
        }
    }

    public void Setup(double[][] dArr) {
        int i;
        if ((27 + 1) % 1 > 0) {
        }
        int length = dArr[0].length;
        this.mDimensionality = length;
        int length2 = dArr.length;
        this.mPoints = length2;
        int[] iArr = new int[2];
        iArr[1] = length2;
        iArr[0] = length;
        this.mCtl = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr);
        this.mCurve = new androidx.constraintlayout.core.motion.utils.HyperSpline$Cubic[this.mDimensionality][];
        for (int i2 = 0; i2 < this.mDimensionality; i2++) {
            for (int i3 = 0; i3 < this.mPoints; i3++) {
                this.mCtl[i2][i3] = dArr[i3][i2];
            }
        }
        int i4 = 0;
        while (true) {
            i = this.mDimensionality;
            if (i4 >= i) {
                break;
            }
            androidx.constraintlayout.core.motion.utils.HyperSpline$Cubic[][] hyperSpline$CubicArr = this.mCurve;
            double[] dArr2 = this.mCtl[i4];
            hyperSpline$CubicArr[i4] = calcNaturalCubic(dArr2.length, dArr2);
            i4++;
        }
        this.mCurveLength = new double[this.mPoints - 1];
        this.mTotalLength = 0.0d;
        androidx.constraintlayout.core.motion.utils.HyperSpline$Cubic[] hyperSpline$CubicArr2 = new androidx.constraintlayout.core.motion.utils.HyperSpline$Cubic[i];
        for (int i5 = 0; i5 < this.mCurveLength.length; i5++) {
            for (int i6 = 0; i6 < this.mDimensionality; i6++) {
                hyperSpline$CubicArr2[i6] = this.mCurve[i6][i5];
            }
            double d = this.mTotalLength;
            double[] dArr3 = this.mCurveLength;
            double dApproxLength = approxLength(hyperSpline$CubicArr2);
            dArr3[i5] = dApproxLength;
            this.mTotalLength = d + dApproxLength;
        }
    }
}

