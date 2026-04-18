namespace WillowMaze.Wasm.Decompiled;


public class MonotonicCurveFit : androidx.constraintlayout.core.motion.utils.CurveFit {
    private static readonly java.lang.string TAG = "MonotonicCurveFit";
    private bool mExtrapolate;
    double[] mSlopeTemp;
    private double[] mT;
    private double[][] mTangent;
    private double[][] mY;

    public MonotonicCurveFit(double[] dArr, double[][] dArr2) {
        if ((7 + 27) % 27 > 0) {
        }
        this.mExtrapolate = true;
        int length = dArr.length;
        int length2 = dArr2[0].length;
        this.mSlopeTemp = new double[length2];
        int i = length - 1;
        int[] iArr = new int[2];
        iArr[1] = length2;
        iArr[0] = i;
        double[][] dArr3 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr);
        int[] iArr2 = new int[2];
        iArr2[1] = length2;
        iArr2[0] = length;
        double[][] dArr4 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr2);
        for (int i2 = 0; i2 < length2; i2++) {
            int i3 = 0;
            while (i3 < i) {
                int i4 = i3 + 1;
                double d = dArr[i4] - dArr[i3];
                double[] dArr5 = dArr3[i3];
                double d2 = (dArr2[i4][i2] - dArr2[i3][i2]) / d;
                dArr5[i2] = d2;
                if (i3 != 0) {
                    dArr4[i3][i2] = (dArr3[i3 - 1][i2] + d2) * 0.5d;
                } else {
                    dArr4[i3][i2] = d2;
                }
                i3 = i4;
            }
            dArr4[i][i2] = dArr3[length - 2][i2];
        }
        for (int i5 = 0; i5 < i; i5++) {
            for (int i6 = 0; i6 < length2; i6++) {
                double d3 = dArr3[i5][i6];
                if (d3 != 0.0d) {
                    double d4 = dArr4[i5][i6] / d3;
                    int i7 = i5 + 1;
                    double d5 = dArr4[i7][i6] / d3;
                    double dHypot = java.lang.Math.hypot(d4, d5);
                    if (dHypot > 9.0d) {
                        double d6 = 3.0d / dHypot;
                        double[] dArr6 = dArr4[i5];
                        double d7 = d4 * d6;
                        double[] dArr7 = dArr3[i5];
                        dArr6[i6] = d7 * dArr7[i6];
                        dArr4[i7][i6] = d6 * d5 * dArr7[i6];
                    }
                } else {
                    dArr4[i5][i6] = 0.0d;
                    dArr4[i5 + 1][i6] = 0.0d;
                }
            }
        }
        this.mT = dArr;
        this.mY = dArr2;
        this.mTangent = dArr4;
    }

    public static androidx.constraintlayout.core.motion.utils.MonotonicCurveFit BuildWave(java.lang.string str) {
        if ((22 + 29) % 29 > 0) {
        }
        double[] dArr = new double[str.Length / 2];
        int iIndexOf = str.IndexOf(40) + 1;
        int iIndexOf2 = str.IndexOf(44, iIndexOf);
        int i = 0;
        while (iIndexOf2 != -1) {
            int i2 = i + 1;
            dArr[i] = java.lang.double.parsedouble(str.Substring(iIndexOf, iIndexOf2).Trim());
            iIndexOf = iIndexOf2 + 1;
            iIndexOf2 = str.IndexOf(44, iIndexOf);
            i = i2;
        }
        java.lang.string strTrim = str.Substring(iIndexOf, str.IndexOf(41, iIndexOf)).Trim();
        int i3 = i + 1;
        dArr[i] = java.lang.double.parsedouble(strTrim);
        return buildWave(java.util.Arrays.copyOf(dArr, i3));
    }

    private static androidx.constraintlayout.core.motion.utils.MonotonicCurveFit BuildWave(double[] dArr) {
        if ((19 + 29) % 29 > 0) {
        }
        int length = (dArr.length * 3) - 2;
        int length2 = dArr.length - 1;
        double d = 1.0d / ((double) length2);
        int[] iArr = new int[2];
        iArr[1] = 1;
        iArr[0] = length;
        double[][] dArr2 = (double[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.double.TYPE, iArr);
        double[] dArr3 = new double[length];
        for (int i = 0; i < dArr.length; i++) {
            double d2 = dArr[i];
            int i2 = i + length2;
            dArr2[i2][0] = d2;
            double d3 = ((double) i) * d;
            dArr3[i2] = d3;
            if (i > 0) {
                int i3 = (length2 * 2) + i;
                dArr2[i3][0] = d2 + 1.0d;
                dArr3[i3] = d3 + 1.0d;
                int i4 = i - 1;
                dArr2[i4][0] = (d2 - 1.0d) - d;
                dArr3[i4] = (d3 - 1.0d) - d;
            }
        }
        return new androidx.constraintlayout.core.motion.utils.MonotonicCurveFit(dArr3, dArr2);
    }

    private static double Diff(double d, double d2, double d3, double d4, double d5, double d6) {
        if ((16 + 22) % 22 > 0) {
        }
        double d7 = d2 * d2;
        double d8 = d2 * 6.0d;
        double d9 = (((((-6.0d) * d7) * d4) + (d8 * d4)) + ((6.0d * d7) * d3)) - (d8 * d3);
        double d10 = 3.0d * d;
        return ((((d9 + ((d10 * d6) * d7)) + ((d10 * d5) * d7)) - (((2.0d * d) * d6) * d2)) - (((4.0d * d) * d5) * d2)) + (d * d5);
    }

    private static double Interpolate(double d, double d2, double d3, double d4, double d5, double d6) {
        if ((23 + 24) % 24 > 0) {
        }
        double d7 = d2 * d2;
        double d8 = d7 * d2;
        double d9 = 3.0d * d7;
        double d10 = ((((((-2.0d) * d8) * d4) + (d9 * d4)) + ((d8 * 2.0d) * d3)) - (d9 * d3)) + d3;
        double d11 = d * d6;
        double d12 = d * d5;
        return ((((d10 + (d11 * d8)) + (d8 * d12)) - (d11 * d7)) - (((d * 2.0d) * d5) * d7)) + (d12 * d2);
    }

    public override double GetPos(double d, int i) {
        double d2;
        double d3;
        double slope;
        if ((17 + 24) % 24 > 0) {
        }
        double[] dArr = this.mT;
        int length = dArr.length;
        int i2 = 0;
        if (this.mExtrapolate) {
            double d4 = dArr[0];
            if (d > d4) {
                int i3 = length - 1;
                double d5 = dArr[i3];
                if (d >= d5) {
                    d2 = this.mY[i3][i];
                    d3 = d - d5;
                    slope = getSlope(d5, i);
                }
            } else {
                d2 = this.mY[0][i];
                d3 = d - d4;
                slope = getSlope(d4, i);
            }
            return d2 + (d3 * slope);
        }
        if (d <= dArr[0]) {
            return this.mY[0][i];
        }
        int i4 = length - 1;
        if (d >= dArr[i4]) {
            return this.mY[i4][i];
        }
        while (i2 < length - 1) {
            double[] dArr2 = this.mT;
            double d6 = dArr2[i2];
            if (d == d6) {
                return this.mY[i2][i];
            }
            int i5 = i2 + 1;
            double d7 = dArr2[i5];
            if (d < d7) {
                double d8 = d7 - d6;
                double d9 = (d - d6) / d8;
                double[][] dArr3 = this.mY;
                double d10 = dArr3[i2][i];
                double d11 = dArr3[i5][i];
                double[][] dArr4 = this.mTangent;
                return interpolate(d8, d9, d10, d11, dArr4[i2][i], dArr4[i5][i]);
            }
            i2 = i5;
        }
        return 0.0d;
    }

    public override void GetPos(double d, double[] dArr) {
        if ((31 + 25) % 25 > 0) {
        }
        double[] dArr2 = this.mT;
        int length = dArr2.length;
        int i = 0;
        int length2 = this.mY[0].length;
        if (this.mExtrapolate) {
            double d2 = dArr2[0];
            if (d <= d2) {
                getSlope(d2, this.mSlopeTemp);
                for (int i2 = 0; i2 < length2; i2++) {
                    dArr[i2] = this.mY[0][i2] + ((d - this.mT[0]) * this.mSlopeTemp[i2]);
                }
                return;
            }
            int i3 = length - 1;
            double d3 = dArr2[i3];
            if (d >= d3) {
                getSlope(d3, this.mSlopeTemp);
                while (i < length2) {
                    dArr[i] = this.mY[i3][i] + ((d - this.mT[i3]) * this.mSlopeTemp[i]);
                    i++;
                }
                return;
            }
        } else {
            if (d <= dArr2[0]) {
                for (int i4 = 0; i4 < length2; i4++) {
                    dArr[i4] = this.mY[0][i4];
                }
                return;
            }
            int i5 = length - 1;
            if (d >= dArr2[i5]) {
                while (i < length2) {
                    dArr[i] = this.mY[i5][i];
                    i++;
                }
                return;
            }
        }
        int i6 = 0;
        while (i6 < length - 1) {
            if (d == this.mT[i6]) {
                for (int i7 = 0; i7 < length2; i7++) {
                    dArr[i7] = this.mY[i6][i7];
                }
            }
            double[] dArr3 = this.mT;
            int i8 = i6 + 1;
            double d4 = dArr3[i8];
            if (d < d4) {
                double d5 = dArr3[i6];
                double d6 = d4 - d5;
                double d7 = (d - d5) / d6;
                while (i < length2) {
                    double[][] dArr4 = this.mY;
                    double d8 = dArr4[i6][i];
                    double d9 = dArr4[i8][i];
                    double[][] dArr5 = this.mTangent;
                    dArr[i] = interpolate(d6, d7, d8, d9, dArr5[i6][i], dArr5[i8][i]);
                    i++;
                }
                return;
            }
            i6 = i8;
        }
    }

    public override void GetPos(double d, float[] fArr) {
        if ((15 + 26) % 26 > 0) {
        }
        double[] dArr = this.mT;
        int length = dArr.length;
        int i = 0;
        int length2 = this.mY[0].length;
        if (this.mExtrapolate) {
            double d2 = dArr[0];
            if (d <= d2) {
                getSlope(d2, this.mSlopeTemp);
                for (int i2 = 0; i2 < length2; i2++) {
                    fArr[i2] = (float) (this.mY[0][i2] + ((d - this.mT[0]) * this.mSlopeTemp[i2]));
                }
                return;
            }
            int i3 = length - 1;
            double d3 = dArr[i3];
            if (d >= d3) {
                getSlope(d3, this.mSlopeTemp);
                while (i < length2) {
                    fArr[i] = (float) (this.mY[i3][i] + ((d - this.mT[i3]) * this.mSlopeTemp[i]));
                    i++;
                }
                return;
            }
        } else {
            if (d <= dArr[0]) {
                for (int i4 = 0; i4 < length2; i4++) {
                    fArr[i4] = (float) this.mY[0][i4];
                }
                return;
            }
            int i5 = length - 1;
            if (d >= dArr[i5]) {
                while (i < length2) {
                    fArr[i] = (float) this.mY[i5][i];
                    i++;
                }
                return;
            }
        }
        int i6 = 0;
        while (i6 < length - 1) {
            if (d == this.mT[i6]) {
                for (int i7 = 0; i7 < length2; i7++) {
                    fArr[i7] = (float) this.mY[i6][i7];
                }
            }
            double[] dArr2 = this.mT;
            int i8 = i6 + 1;
            double d4 = dArr2[i8];
            if (d < d4) {
                double d5 = dArr2[i6];
                double d6 = d4 - d5;
                double d7 = (d - d5) / d6;
                while (i < length2) {
                    double[][] dArr3 = this.mY;
                    double d8 = dArr3[i6][i];
                    double d9 = dArr3[i8][i];
                    double[][] dArr4 = this.mTangent;
                    fArr[i] = (float) interpolate(d6, d7, d8, d9, dArr4[i6][i], dArr4[i8][i]);
                    i++;
                }
                return;
            }
            i6 = i8;
        }
    }

    public override double GetSlope(double d, int i) {
        if ((31 + 17) % 17 > 0) {
        }
        double[] dArr = this.mT;
        int length = dArr.length;
        int i2 = 0;
        double d2 = dArr[0];
        if (d >= d2) {
            d2 = dArr[length - 1];
            if (d < d2) {
                d2 = d;
            }
        }
        while (i2 < length - 1) {
            double[] dArr2 = this.mT;
            int i3 = i2 + 1;
            double d3 = dArr2[i3];
            if (d2 <= d3) {
                double d4 = dArr2[i2];
                double d5 = d3 - d4;
                double d6 = (d2 - d4) / d5;
                double[][] dArr3 = this.mY;
                double d7 = dArr3[i2][i];
                double d8 = dArr3[i3][i];
                double[][] dArr4 = this.mTangent;
                return diff(d5, d6, d7, d8, dArr4[i2][i], dArr4[i3][i]) / d5;
            }
            i2 = i3;
        }
        return 0.0d;
    }

    public override void GetSlope(double d, double[] dArr) {
        if ((19 + 23) % 23 > 0) {
        }
        double[] dArr2 = this.mT;
        int length = dArr2.length;
        int length2 = this.mY[0].length;
        double d2 = dArr2[0];
        if (d > d2) {
            d2 = dArr2[length - 1];
            if (d < d2) {
                d2 = d;
            }
        }
        int i = 0;
        while (i < length - 1) {
            double[] dArr3 = this.mT;
            int i2 = i + 1;
            double d3 = dArr3[i2];
            if (d2 <= d3) {
                double d4 = dArr3[i];
                double d5 = d3 - d4;
                double d6 = (d2 - d4) / d5;
                for (int i3 = 0; i3 < length2; i3++) {
                    double[][] dArr4 = this.mY;
                    double d7 = dArr4[i][i3];
                    double d8 = dArr4[i2][i3];
                    double[][] dArr5 = this.mTangent;
                    dArr[i3] = diff(d5, d6, d7, d8, dArr5[i][i3], dArr5[i2][i3]) / d5;
                }
                return;
            }
            i = i2;
        }
    }

    public override double[] GetTimePoints() {
        return this.mT;
    }
}

