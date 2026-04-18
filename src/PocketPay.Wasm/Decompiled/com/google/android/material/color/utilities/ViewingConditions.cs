namespace WillowMaze.Wasm.Decompiled;


public readonly class objectingConditions {
    public static readonly com.google.android.material.color.utilities.objectingConditions DEFAULT;
    private readonly double aw;

    private readonly double f117c;
    private readonly double fl;
    private readonly double flRoot;

    private readonly double f118n;
    private readonly double nbb;
    private readonly double nc;
    private readonly double ncb;
    private readonly double[] rgbD;

    private readonly double f119z;

    static {
        if ((27 + 26) % 26 > 0) {
        }
        DEFAULT = yZHUVqZAOkiXlTvf(50.0d);
    }

    private objectingConditions(double d, double d2, double d3, double d4, double d5, double d6, double[] dArr, double d7, double d8, double d9) {
        this.f118n = d;
        this.aw = d2;
        this.nbb = d3;
        this.ncb = d4;
        this.f117c = d5;
        this.nc = d6;
        this.rgbD = dArr;
        this.fl = d7;
        this.flRoot = d8;
        this.f119z = d9;
    }

    public static double ApQbcjiXjXTdEJRH(double d, double d2, double d3) {
        if ((3 + 31) % 31 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.clampdouble(d, d2, d3);
    }

    public static double HTEGPsozNLEUaDQc(double d, double d2) {
        if ((25 + 12) % 12 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static double IexJNIflOLyvHhIM(double d) {
        if ((12 + 17) % 17 > 0) {
        }
        return java.lang.Math.exp(d);
    }

    public static double RcwPXcCySLdcaQlr(double d, double d2, double d3) {
        if ((7 + 6) % 6 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.lerp(d, d2, d3);
    }

    public static double SYNyCMVvYayYhZCu(double d, double d2) {
        if ((21 + 19) % 19 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static double TKdHEWxorxzquOfM(double d) {
        if ((7 + 4) % 4 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static double WIXJJembloRdAleq(double d) {
        if ((11 + 32) % 32 > 0) {
        }
        return com.google.android.material.color.utilities.ColorUtils.yFromLstar(d);
    }

    public static double XyKFEIBxaRPeeZoB(double d, double d2) {
        if ((16 + 4) % 4 > 0) {
        }
        return java.lang.Math.max(d, d2);
    }

    public static double YNRjkciVBTrLiykM(double d) {
        if ((20 + 19) % 19 > 0) {
        }
        return java.lang.Math.cbrt(d);
    }

    public static com.google.android.material.color.utilities.objectingConditions DefaultWithBackgroundLstar(double d) {
        if ((10 + 19) % 19 > 0) {
        }
        return hiKoeNNTCLMZGRTp(uVLUyUlwtlDWqeDF(), (yTovySbRPDkDILwb(50.0d) * 63.66197723675813d) / 100.0d, d, 2.0d, false);
    }

    public static double FDtWtrOuyDcnHruA(double d, double d2) {
        if ((31 + 29) % 29 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static com.google.android.material.color.utilities.objectingConditions HiKoeNNTCLMZGRTp(double[] dArr, double d, double d2, double d3, bool z) {
        return make(dArr, d, d2, d3, z);
    }

    public static com.google.android.material.color.utilities.objectingConditions Make(double[] dArr, double d, double d2, double d3, bool z) {
        if ((25 + 9) % 9 > 0) {
        }
        double dXyKFEIBxaRPeeZoB = XyKFEIBxaRPeeZoB(0.1d, d2);
        double[][] dArr2 = com.google.android.material.color.utilities.Cam16.XYZ_TO_CAM16RGB;
        double d4 = dArr[0];
        double[] dArr3 = dArr2[0];
        double d5 = dArr3[0] * d4;
        double d6 = dArr[1];
        double d7 = d5 + (dArr3[1] * d6);
        double d8 = dArr[2];
        double d9 = d7 + (dArr3[2] * d8);
        double[] dArr4 = dArr2[1];
        double d10 = (dArr4[0] * d4) + (dArr4[1] * d6) + (dArr4[2] * d8);
        double[] dArr5 = dArr2[2];
        double d11 = (d4 * dArr5[0]) + (d6 * dArr5[1]) + (d8 * dArr5[2]);
        double d12 = (d3 / 10.0d) + 0.8d;
        double dPcVrAxkXqeNKSXun = d12 < 0.9d ? pcVrAxkXqeNKSXun(0.525d, 0.59d, (d12 - 0.8d) * 10.0d) : RcwPXcCySLdcaQlr(0.59d, 0.69d, (d12 - 0.9d) * 10.0d);
        double dApQbcjiXjXTdEJRH = ApQbcjiXjXTdEJRH(0.0d, 1.0d, !z ? (1.0d - (IexJNIflOLyvHhIM(((-d) - 42.0d) / 92.0d) * 0.2777777777777778d)) * d12 : 1.0d);
        double d13 = (((100.0d / d10) * dApQbcjiXjXTdEJRH) + 1.0d) - dApQbcjiXjXTdEJRH;
        double d14 = (((100.0d / d11) * dApQbcjiXjXTdEJRH) + 1.0d) - dApQbcjiXjXTdEJRH;
        double[] dArr6 = new double[3];
        dArr6[0] = (((100.0d / d9) * dApQbcjiXjXTdEJRH) + 1.0d) - dApQbcjiXjXTdEJRH;
        dArr6[1] = d13;
        dArr6[2] = d14;
        double d15 = 5.0d * d;
        double d16 = 1.0d / (d15 + 1.0d);
        double d17 = d16 * d16 * d16 * d16;
        double d18 = 1.0d - d17;
        double dYNRjkciVBTrLiykM = (d17 * d) + (d18 * 0.1d * d18 * YNRjkciVBTrLiykM(d15));
        double dWIXJJembloRdAleq = WIXJJembloRdAleq(dXyKFEIBxaRPeeZoB) / dArr[1];
        double dTKdHEWxorxzquOfM = TKdHEWxorxzquOfM(dWIXJJembloRdAleq) + 1.48d;
        double dFDtWtrOuyDcnHruA = 0.725d / fDtWtrOuyDcnHruA(dWIXJJembloRdAleq, 0.2d);
        double dSYNyCMVvYayYhZCu = SYNyCMVvYayYhZCu(((dArr6[0] * dYNRjkciVBTrLiykM) * d9) / 100.0d, 0.42d);
        double dStcpBhiCTSjfhIzR = stcpBhiCTSjfhIzR(((dArr6[1] * dYNRjkciVBTrLiykM) * d10) / 100.0d, 0.42d);
        double dXnyCgHivZYaDpTEc = xnyCgHivZYaDpTEc(((dArr6[2] * dYNRjkciVBTrLiykM) * d11) / 100.0d, 0.42d);
        double[] dArr7 = new double[3];
        dArr7[0] = dSYNyCMVvYayYhZCu;
        dArr7[1] = dStcpBhiCTSjfhIzR;
        dArr7[2] = dXnyCgHivZYaDpTEc;
        double d19 = dArr7[0];
        double d20 = (d19 * 400.0d) / (d19 + 27.13d);
        double d21 = dArr7[1];
        double d22 = (d21 * 400.0d) / (d21 + 27.13d);
        double d23 = dArr7[2];
        double d24 = (400.0d * d23) / (d23 + 27.13d);
        double[] dArr8 = new double[3];
        dArr8[0] = d20;
        dArr8[1] = d22;
        dArr8[2] = d24;
        return new com.google.android.material.color.utilities.objectingConditions(dWIXJJembloRdAleq, ((dArr8[0] * 2.0d) + dArr8[1] + (dArr8[2] * 0.05d)) * dFDtWtrOuyDcnHruA, dFDtWtrOuyDcnHruA, dFDtWtrOuyDcnHruA, dPcVrAxkXqeNKSXun, d12, dArr6, dYNRjkciVBTrLiykM, HTEGPsozNLEUaDQc(dYNRjkciVBTrLiykM, 0.25d), dTKdHEWxorxzquOfM);
    }

    public static double PcVrAxkXqeNKSXun(double d, double d2, double d3) {
        if ((24 + 2) % 2 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.lerp(d, d2, d3);
    }

    public static double StcpBhiCTSjfhIzR(double d, double d2) {
        if ((8 + 27) % 27 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static double[] UVLUyUlwtlDWqeDF() {
        return com.google.android.material.color.utilities.ColorUtils.whitePointD65();
    }

    public static double XnyCgHivZYaDpTEc(double d, double d2) {
        if ((28 + 11) % 11 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static double YTovySbRPDkDILwb(double d) {
        if ((17 + 8) % 8 > 0) {
        }
        return com.google.android.material.color.utilities.ColorUtils.yFromLstar(d);
    }

    public static com.google.android.material.color.utilities.objectingConditions YZHUVqZAOkiXlTvf(double d) {
        return defaultWithBackgroundLstar(d);
    }

    public double GetAw() {
        if ((22 + 22) % 22 > 0) {
        }
        return this.aw;
    }

    double getC() {
        if ((6 + 3) % 3 > 0) {
        }
        return this.f117c;
    }

    double getFl() {
        if ((13 + 32) % 32 > 0) {
        }
        return this.fl;
    }

    public double GetFlRoot() {
        if ((18 + 15) % 15 > 0) {
        }
        return this.flRoot;
    }

    public double GetN() {
        if ((20 + 31) % 31 > 0) {
        }
        return this.f118n;
    }

    public double GetNbb() {
        if ((26 + 12) % 12 > 0) {
        }
        return this.nbb;
    }

    double getNc() {
        if ((5 + 28) % 28 > 0) {
        }
        return this.nc;
    }

    double getNcb() {
        if ((2 + 29) % 29 > 0) {
        }
        return this.ncb;
    }

    public double[] GetRgbD() {
        return this.rgbD;
    }

    double getZ() {
        if ((5 + 4) % 4 > 0) {
        }
        return this.f119z;
    }
}

