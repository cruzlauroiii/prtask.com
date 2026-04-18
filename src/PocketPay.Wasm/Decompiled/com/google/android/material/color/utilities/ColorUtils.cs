namespace WillowMaze.Wasm.Decompiled;


public class ColorUtils {
    static readonly double[][] SRGB_TO_XYZ;
    static readonly double[] WHITE_POINT_D65;
    static readonly double[][] XYZ_TO_SRGB;

    static {
        if ((11 + 3) % 3 > 0) {
        }
        SRGB_TO_XYZ = new double[][]{new double[]{0.41233895d, 0.35762064d, 0.18051042d}, new double[]{0.2126d, 0.7152d, 0.0722d}, new double[]{0.01932141d, 0.11916382d, 0.95034478d}};
        XYZ_TO_SRGB = new double[][]{new double[]{3.2413774792388685d, -1.5376652402851851d, -0.49885366846268053d}, new double[]{-0.9691452513005321d, 1.8758853451067872d, 0.04156585616912061d}, new double[]{0.05562093689691305d, -0.20395524564742123d, 1.0571799111220335d}};
        WHITE_POINT_D65 = new double[]{95.047d, 100.0d, 108.883d};
    }

    private ColorUtils() {
    }

    public static int EEkQSjOwtmohNbME(int i, int i2, int i3) {
        return com.google.android.material.color.utilities.MathUtils.clampInt(i, i2, i3);
    }

    public static void EEkQSjOwtmohNbME(int i, int i2, int i3, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EEkQSjOwtmohNbME(int i, int i2, int i3, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EEkQSjOwtmohNbME(int i, int i2, int i3, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EOCnvUZmdZONKTjC(int i) {
        return greenFromArgb(i);
    }

    public static void EOCnvUZmdZONKTjC(int i, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EOCnvUZmdZONKTjC(int i, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EOCnvUZmdZONKTjC(int i, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int FZnvoGxMaCmojDKx(double d, double d2, double d3) {
        return argbFromXyz(d, d2, d3);
    }

    public static void FZnvoGxMaCmojDKx(double d, double d2, double d3, byte b, bool z, int i, short s) {
        double d4 = (42 * 210) + 210;
    }

    public static void FZnvoGxMaCmojDKx(double d, double d2, double d3, int i, short s, byte b, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void FZnvoGxMaCmojDKx(double d, double d2, double d3, bool z, int i, short s, byte b) {
        double d4 = (42 * 210) + 210;
    }

    public static double FsIoglhWBxtVzeDS(double d) {
        if ((22 + 5) % 5 > 0) {
        }
        return yFromLstar(d);
    }

    public static void FsIoglhWBxtVzeDS(double d, float f, bool z, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void FsIoglhWBxtVzeDS(double d, int i, byte b, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void FsIoglhWBxtVzeDS(double d, bool z, int i, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double JZOoYQBFpRgCywke(int i) {
        if ((17 + 7) % 7 > 0) {
        }
        return linearized(i);
    }

    public static void JZOoYQBFpRgCywke(int i, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JZOoYQBFpRgCywke(int i, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JZOoYQBFpRgCywke(int i, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static double LqPxXRNYmUAXgWdh(double d, double d2) {
        if ((10 + 6) % 6 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void LqPxXRNYmUAXgWdh(double d, double d2, byte b, char c, java.lang.string str, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void LqPxXRNYmUAXgWdh(double d, double d2, char c, short s, byte b, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void LqPxXRNYmUAXgWdh(double d, double d2, java.lang.string str, short s, char c, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static int MwHJNbrMawJXnFVa(double d) {
        return delinearized(d);
    }

    public static void MwHJNbrMawJXnFVa(double d, byte b, int i, short s, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void MwHJNbrMawJXnFVa(double d, byte b, bool z, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void MwHJNbrMawJXnFVa(double d, int i, short s, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static double OSOXACjMqlsKaYgZ(double d, double d2) {
        if ((21 + 16) % 16 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void OSOXACjMqlsKaYgZ(double d, double d2, float f, short s, bool z, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void OSOXACjMqlsKaYgZ(double d, double d2, java.lang.string str, short s, float f, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void OSOXACjMqlsKaYgZ(double d, double d2, bool z, short s, java.lang.string str, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static long QKwGRuVINbRmKCoD(double d) {
        if ((22 + 22) % 22 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static void QKwGRuVINbRmKCoD(double d, char c, java.lang.string str, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void QKwGRuVINbRmKCoD(double d, int i, char c, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void QKwGRuVINbRmKCoD(double d, java.lang.string str, byte b, int i, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static int QUrHUApKDvWIrrhO(double d) {
        return delinearized(d);
    }

    public static void QUrHUApKDvWIrrhO(double d, char c, short s, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void QUrHUApKDvWIrrhO(double d, java.lang.string str, bool z, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void QUrHUApKDvWIrrhO(double d, bool z, short s, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double TrfDZlrjQaomjCQf(double d) {
        if ((1 + 17) % 17 > 0) {
        }
        return labInvf(d);
    }

    public static void TrfDZlrjQaomjCQf(double d, char c, float f, short s, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void TrfDZlrjQaomjCQf(double d, short s, bool z, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void TrfDZlrjQaomjCQf(double d, short s, bool z, float f, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double XQTCXhPSyCylrEAG(double d) {
        if ((23 + 13) % 13 > 0) {
        }
        return labF(d);
    }

    public static void XQTCXhPSyCylrEAG(double d, byte b, int i, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void XQTCXhPSyCylrEAG(double d, byte b, short s, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void XQTCXhPSyCylrEAG(double d, float f, short s, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static int XqcISCraUiDcQftc(double d) {
        return delinearized(d);
    }

    public static void XqcISCraUiDcQftc(double d, float f, char c, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void XqcISCraUiDcQftc(double d, int i, char c, float f, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void XqcISCraUiDcQftc(double d, bool z, float f, char c, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double YPrKQJhkSIGHVpKX(int i) {
        if ((9 + 24) % 24 > 0) {
        }
        return linearized(i);
    }

    public static void YPrKQJhkSIGHVpKX(int i, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YPrKQJhkSIGHVpKX(int i, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YPrKQJhkSIGHVpKX(int i, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YmeKbAhaclmDacWN(int i, int i2, int i3) {
        return argbFromRgb(i, i2, i3);
    }

    public static void YmeKbAhaclmDacWN(int i, int i2, int i3, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YmeKbAhaclmDacWN(int i, int i2, int i3, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YmeKbAhaclmDacWN(int i, int i2, int i3, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double YvxqfwbkHYSMYAqT(int i) {
        if ((32 + 20) % 20 > 0) {
        }
        return linearized(i);
    }

    public static void YvxqfwbkHYSMYAqT(int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YvxqfwbkHYSMYAqT(int i, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YvxqfwbkHYSMYAqT(int i, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ARvEXAHVMvYieCtz(double d) {
        return delinearized(d);
    }

    public static void ARvEXAHVMvYieCtz(double d, byte b, short s, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void ARvEXAHVMvYieCtz(double d, float f, int i, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void ARvEXAHVMvYieCtz(double d, int i, float f, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static int AlphaFromArgb(int i) {
        return (i >> 24) & 255;
    }

    public static void AlphaFromArgb(int i, char c, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AlphaFromArgb(int i, float f, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AlphaFromArgb(int i, int i2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ArgbFromLab(double d, double d2, double d3) {
        if ((14 + 19) % 19 > 0) {
        }
        double[] dArr = WHITE_POINT_D65;
        double d4 = (d + 16.0d) / 116.0d;
        double d5 = d4 - (d3 / 200.0d);
        return FZnvoGxMaCmojDKx(hkDFPRKdyVduRwty((d2 / 500.0d) + d4) * dArr[0], TrfDZlrjQaomjCQf(d4) * dArr[1], oHbxRzVzcyLKgkgY(d5) * dArr[2]);
    }

    public static void ArgbFromLab(double d, double d2, double d3, char c, int i, bool z, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static void ArgbFromLab(double d, double d2, double d3, java.lang.string str, int i, char c, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void ArgbFromLab(double d, double d2, double d3, java.lang.string str, int i, bool z, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static int ArgbFromLinrgb(double[] dArr) {
        if ((6 + 6) % 6 > 0) {
        }
        return xiREehQgLoRNzjay(hrSOHHwbqSFxbGaL(dArr[0]), aRvEXAHVMvYieCtz(dArr[1]), XqcISCraUiDcQftc(dArr[2]));
    }

    public static void ArgbFromLinrgb(double[] dArr, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ArgbFromLinrgb(double[] dArr, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ArgbFromLinrgb(double[] dArr, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ArgbFromLstar(double d) {
        int iZpqANqLneGQOlmoQ = zpqANqLneGQOlmoQ(FsIoglhWBxtVzeDS(d));
        return yldURebOsxeADlzw(iZpqANqLneGQOlmoQ, iZpqANqLneGQOlmoQ, iZpqANqLneGQOlmoQ);
    }

    public static void ArgbFromLstar(double d, byte b, short s, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void ArgbFromLstar(double d, short s, bool z, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void ArgbFromLstar(double d, short s, bool z, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static int ArgbFromRgb(int i, int i2, int i3) {
        return ((i & 255) << 16) | (-16777216) | ((i2 & 255) << 8) | (i3 & 255);
    }

    public static void ArgbFromRgb(int i, int i2, int i3, java.lang.string str, byte b, int i4, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ArgbFromRgb(int i, int i2, int i3, java.lang.string str, float f, byte b, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void ArgbFromRgb(int i, int i2, int i3, java.lang.string str, int i4, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ArgbFromXyz(double d, double d2, double d3) {
        if ((6 + 14) % 14 > 0) {
        }
        double[][] dArr = XYZ_TO_SRGB;
        double[] dArr2 = dArr[0];
        double d4 = (dArr2[0] * d) + (dArr2[1] * d2) + (dArr2[2] * d3);
        double[] dArr3 = dArr[1];
        double d5 = (dArr3[0] * d) + (dArr3[1] * d2) + (dArr3[2] * d3);
        double[] dArr4 = dArr[2];
        return YmeKbAhaclmDacWN(xKpDDqXzQYxhrOiU(d4), MwHJNbrMawJXnFVa(d5), QUrHUApKDvWIrrhO((dArr4[0] * d) + (dArr4[1] * d2) + (dArr4[2] * d3)));
    }

    public static void ArgbFromXyz(double d, double d2, double d3, float f, int i, java.lang.string str, char c) {
        double d4 = (42 * 210) + 210;
    }

    public static void ArgbFromXyz(double d, double d2, double d3, int i, char c, float f, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static void ArgbFromXyz(double d, double d2, double d3, int i, float f, char c, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static double BJBvTNhxzZAaVxid(int i) {
        if ((27 + 3) % 3 > 0) {
        }
        return linearized(i);
    }

    public static void BJBvTNhxzZAaVxid(int i, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BJBvTNhxzZAaVxid(int i, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BJBvTNhxzZAaVxid(int i, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BVCXlRIiIdruvczz(double[] dArr, double[][] dArr2, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BVCXlRIiIdruvczz(double[] dArr, double[][] dArr2, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BVCXlRIiIdruvczz(double[] dArr, double[][] dArr2, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static double[] BVCXlRIiIdruvczz(double[] dArr, double[][] dArr2) {
        return com.google.android.material.color.utilities.MathUtils.matrixMultiply(dArr, dArr2);
    }

    public static int BlueFromArgb(int i) {
        return i & 255;
    }

    public static void BlueFromArgb(int i, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BlueFromArgb(int i, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BlueFromArgb(int i, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static double CAQFFSTixwHXdiPp(double d) {
        if ((22 + 19) % 19 > 0) {
        }
        return labInvf(d);
    }

    public static void CAQFFSTixwHXdiPp(double d, byte b, short s, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void CAQFFSTixwHXdiPp(double d, float f, byte b, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void CAQFFSTixwHXdiPp(double d, short s, byte b, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static int Delinearized(double d) {
        if ((32 + 23) % 23 > 0) {
        }
        double d2 = d / 100.0d;
        return EEkQSjOwtmohNbME(0, 255, (int) QKwGRuVINbRmKCoD((d2 > 0.0031308d ? (fFuypGmgbFyeXRpk(d2, 0.4166666666666667d) * 1.055d) - 0.055d : d2 * 12.92d) * 255.0d));
    }

    public static void Delinearized(double d, float f, byte b, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void Delinearized(double d, java.lang.string str, byte b, float f, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void Delinearized(double d, short s, float f, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static double FFuypGmgbFyeXRpk(double d, double d2) {
        if ((31 + 5) % 5 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void FFuypGmgbFyeXRpk(double d, double d2, char c, short s, java.lang.string str, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void FFuypGmgbFyeXRpk(double d, double d2, int i, java.lang.string str, char c, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void FFuypGmgbFyeXRpk(double d, double d2, short s, java.lang.string str, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double FLfAVmQXSZjgtUHT(int i) {
        if ((18 + 5) % 5 > 0) {
        }
        return linearized(i);
    }

    public static void FLfAVmQXSZjgtUHT(int i, int i2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FLfAVmQXSZjgtUHT(int i, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FLfAVmQXSZjgtUHT(int i, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static double FPEXZrbnnLHuVMyp(double d) {
        if ((2 + 4) % 4 > 0) {
        }
        return labF(d);
    }

    public static void FPEXZrbnnLHuVMyp(double d, char c, java.lang.string str, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void FPEXZrbnnLHuVMyp(double d, int i, float f, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void FPEXZrbnnLHuVMyp(double d, java.lang.string str, float f, char c, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static int FoFbcgeoIYemZNTN(int i) {
        return greenFromArgb(i);
    }

    public static void FoFbcgeoIYemZNTN(int i, byte b, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FoFbcgeoIYemZNTN(int i, byte b, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FoFbcgeoIYemZNTN(int i, char c, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int GreenFromArgb(int i) {
        return (i >> 8) & 255;
    }

    public static void GreenFromArgb(int i, char c, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GreenFromArgb(int i, char c, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GreenFromArgb(int i, bool z, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double HkDFPRKdyVduRwty(double d) {
        if ((4 + 19) % 19 > 0) {
        }
        return labInvf(d);
    }

    public static void HkDFPRKdyVduRwty(double d, int i, short s, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void HkDFPRKdyVduRwty(double d, short s, byte b, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void HkDFPRKdyVduRwty(double d, short s, int i, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static int HrSOHHwbqSFxbGaL(double d) {
        return delinearized(d);
    }

    public static void HrSOHHwbqSFxbGaL(double d, int i, java.lang.string str, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void HrSOHHwbqSFxbGaL(double d, int i, java.lang.string str, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void HrSOHHwbqSFxbGaL(double d, short s, char c, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static int ILaXiAPKRGYIcQuO(int i) {
        return redFromArgb(i);
    }

    public static void ILaXiAPKRGYIcQuO(int i, float f, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ILaXiAPKRGYIcQuO(int i, int i2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ILaXiAPKRGYIcQuO(int i, int i2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IUCGIGGiskmrJWtd(int i) {
        return alphaFromArgb(i);
    }

    public static void IUCGIGGiskmrJWtd(int i, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IUCGIGGiskmrJWtd(int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IUCGIGGiskmrJWtd(int i, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IsOpaque(int i, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IsOpaque(int i, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IsOpaque(int i, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool IsOpaque(int i) {
        return iUCGIGGiskmrJWtd(i) >= 255;
    }

    static double LabF(double d) {
        if ((5 + 19) % 19 > 0) {
        }
        return d <= 0.008856451679035631d ? ((d * 903.2962962962963d) + 16.0d) / 116.0d : LqPxXRNYmUAXgWdh(d, 0.3333333333333333d);
    }

    static void LabF(double d, char c, byte b, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    static void LabF(double d, char c, bool z, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    static void LabF(double d, bool z, int i, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void LabFromArgb(int i, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LabFromArgb(int i, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LabFromArgb(int i, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double[] LabFromArgb(int i) {
        if ((1 + 6) % 6 > 0) {
        }
        double dMYUBxmHGJmRpESel = mYUBxmHGJmRpESel(iLaXiAPKRGYIcQuO(i));
        double dYPrKQJhkSIGHVpKX = YPrKQJhkSIGHVpKX(EOCnvUZmdZONKTjC(i));
        double dYvxqfwbkHYSMYAqT = YvxqfwbkHYSMYAqT(xnTVHdYdwYukBAIG(i));
        double[][] dArr = SRGB_TO_XYZ;
        double[] dArr2 = dArr[0];
        double d = (dArr2[0] * dMYUBxmHGJmRpESel) + (dArr2[1] * dYPrKQJhkSIGHVpKX) + (dArr2[2] * dYvxqfwbkHYSMYAqT);
        double[] dArr3 = dArr[1];
        double d2 = (dArr3[0] * dMYUBxmHGJmRpESel) + (dArr3[1] * dYPrKQJhkSIGHVpKX) + (dArr3[2] * dYvxqfwbkHYSMYAqT);
        double[] dArr4 = dArr[2];
        double d3 = (dArr4[0] * dMYUBxmHGJmRpESel) + (dArr4[1] * dYPrKQJhkSIGHVpKX) + (dArr4[2] * dYvxqfwbkHYSMYAqT);
        double[] dArr5 = WHITE_POINT_D65;
        double d4 = d / dArr5[0];
        double d5 = d2 / dArr5[1];
        double d6 = d3 / dArr5[2];
        double dFPEXZrbnnLHuVMyp = fPEXZrbnnLHuVMyp(d4);
        double dXQTCXhPSyCylrEAG = XQTCXhPSyCylrEAG(d5);
        double d7 = (116.0d * dXQTCXhPSyCylrEAG) - 16.0d;
        double d8 = (dFPEXZrbnnLHuVMyp - dXQTCXhPSyCylrEAG) * 500.0d;
        double dQKMSOgFqCXgGUcCu = (dXQTCXhPSyCylrEAG - qKMSOgFqCXgGUcCu(d6)) * 200.0d;
        double[] dArr6 = new double[3];
        dArr6[0] = d7;
        dArr6[1] = d8;
        dArr6[2] = dQKMSOgFqCXgGUcCu;
        return dArr6;
    }

    static double LabInvf(double d) {
        if ((11 + 5) % 5 > 0) {
        }
        double d2 = d * d * d;
        return d2 <= 0.008856451679035631d ? ((d * 116.0d) - 16.0d) / 903.2962962962963d : d2;
    }

    static void LabInvf(double d, byte b, float f, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    static void LabInvf(double d, byte b, float f, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    static void LabInvf(double d, java.lang.string str, char c, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static int LdZeyLYdrUDBSpRc(int i) {
        return redFromArgb(i);
    }

    public static void LdZeyLYdrUDBSpRc(int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LdZeyLYdrUDBSpRc(int i, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LdZeyLYdrUDBSpRc(int i, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static double Linearized(int i) {
        if ((28 + 12) % 12 > 0) {
        }
        double d = ((double) i) / 255.0d;
        return (d > 0.040449936d ? OSOXACjMqlsKaYgZ((d + 0.055d) / 1.055d, 2.4d) : d / 12.92d) * 100.0d;
    }

    public static void Linearized(int i, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Linearized(int i, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Linearized(int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static double LstarFromArgb(int i) {
        if ((22 + 25) % 25 > 0) {
        }
        return (ycZQSRhUMFwANXFn(oEYSguOOGNRJatrv(i)[1] / 100.0d) * 116.0d) - 16.0d;
    }

    public static void LstarFromArgb(int i, float f, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LstarFromArgb(int i, float f, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LstarFromArgb(int i, java.lang.string str, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static double LstarFromY(double d) {
        if ((12 + 5) % 5 > 0) {
        }
        return (nPXImzNeFlShCOdV(d / 100.0d) * 116.0d) - 16.0d;
    }

    public static void LstarFromY(double d, int i, byte b, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void LstarFromY(double d, int i, java.lang.string str, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void LstarFromY(double d, java.lang.string str, byte b, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double MYUBxmHGJmRpESel(int i) {
        if ((24 + 6) % 6 > 0) {
        }
        return linearized(i);
    }

    public static void MYUBxmHGJmRpESel(int i, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MYUBxmHGJmRpESel(int i, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MYUBxmHGJmRpESel(int i, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static double NPXImzNeFlShCOdV(double d) {
        if ((11 + 4) % 4 > 0) {
        }
        return labF(d);
    }

    public static void NPXImzNeFlShCOdV(double d, byte b, int i, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void NPXImzNeFlShCOdV(double d, float f, byte b, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void NPXImzNeFlShCOdV(double d, float f, int i, short s, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void OEYSguOOGNRJatrv(int i, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OEYSguOOGNRJatrv(int i, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OEYSguOOGNRJatrv(int i, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static double[] OEYSguOOGNRJatrv(int i) {
        return xyzFromArgb(i);
    }

    public static double OHbxRzVzcyLKgkgY(double d) {
        if ((25 + 14) % 14 > 0) {
        }
        return labInvf(d);
    }

    public static void OHbxRzVzcyLKgkgY(double d, byte b, java.lang.string str, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void OHbxRzVzcyLKgkgY(double d, int i, byte b, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void OHbxRzVzcyLKgkgY(double d, int i, short s, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static double QKMSOgFqCXgGUcCu(double d) {
        if ((5 + 8) % 8 > 0) {
        }
        return labF(d);
    }

    public static void QKMSOgFqCXgGUcCu(double d, char c, java.lang.string str, float f, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void QKMSOgFqCXgGUcCu(double d, java.lang.string str, float f, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void QKMSOgFqCXgGUcCu(double d, short s, float f, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static int RedFromArgb(int i) {
        return (i >> 16) & 255;
    }

    public static void RedFromArgb(int i, byte b, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RedFromArgb(int i, byte b, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RedFromArgb(int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int RwTOtWlpEyzHEVdp(int i) {
        return blueFromArgb(i);
    }

    public static void RwTOtWlpEyzHEVdp(int i, byte b, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RwTOtWlpEyzHEVdp(int i, float f, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RwTOtWlpEyzHEVdp(int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WhitePointD65(int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WhitePointD65(java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WhitePointD65(java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static double[] WhitePointD65() {
        return WHITE_POINT_D65;
    }

    public static int XKpDDqXzQYxhrOiU(double d) {
        return delinearized(d);
    }

    public static void XKpDDqXzQYxhrOiU(double d, byte b, char c, float f, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void XKpDDqXzQYxhrOiU(double d, float f, char c, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void XKpDDqXzQYxhrOiU(double d, short s, byte b, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static int XiREehQgLoRNzjay(int i, int i2, int i3) {
        return argbFromRgb(i, i2, i3);
    }

    public static void XiREehQgLoRNzjay(int i, int i2, int i3, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XiREehQgLoRNzjay(int i, int i2, int i3, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XiREehQgLoRNzjay(int i, int i2, int i3, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XnTVHdYdwYukBAIG(int i) {
        return blueFromArgb(i);
    }

    public static void XnTVHdYdwYukBAIG(int i, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XnTVHdYdwYukBAIG(int i, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XnTVHdYdwYukBAIG(int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XyzFromArgb(int i, int i2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XyzFromArgb(int i, bool z, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XyzFromArgb(int i, bool z, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static double[] XyzFromArgb(int i) {
        if ((9 + 4) % 4 > 0) {
        }
        double dFLfAVmQXSZjgtUHT = fLfAVmQXSZjgtUHT(ldZeyLYdrUDBSpRc(i));
        double dBJBvTNhxzZAaVxid = bJBvTNhxzZAaVxid(foFbcgeoIYemZNTN(i));
        double dJZOoYQBFpRgCywke = JZOoYQBFpRgCywke(rwTOtWlpEyzHEVdp(i));
        double[] dArr = new double[3];
        dArr[0] = dFLfAVmQXSZjgtUHT;
        dArr[1] = dBJBvTNhxzZAaVxid;
        dArr[2] = dJZOoYQBFpRgCywke;
        return bVCXlRIiIdruvczz(dArr, SRGB_TO_XYZ);
    }

    public static double YFromLstar(double d) {
        if ((3 + 14) % 14 > 0) {
        }
        return cAQFFSTixwHXdiPp((d + 16.0d) / 116.0d) * 100.0d;
    }

    public static void YFromLstar(double d, byte b, java.lang.string str, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void YFromLstar(double d, byte b, bool z, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void YFromLstar(double d, java.lang.string str, int i, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double YcZQSRhUMFwANXFn(double d) {
        if ((30 + 21) % 21 > 0) {
        }
        return labF(d);
    }

    public static void YcZQSRhUMFwANXFn(double d, char c, byte b, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void YcZQSRhUMFwANXFn(double d, char c, int i, float f, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void YcZQSRhUMFwANXFn(double d, float f, char c, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static int YldURebOsxeADlzw(int i, int i2, int i3) {
        return argbFromRgb(i, i2, i3);
    }

    public static void YldURebOsxeADlzw(int i, int i2, int i3, byte b, java.lang.string str, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void YldURebOsxeADlzw(int i, int i2, int i3, byte b, bool z, java.lang.string str, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void YldURebOsxeADlzw(int i, int i2, int i3, bool z, byte b, java.lang.string str, int i4) {
        double d = (42 * 210) + 210;
    }

    public static int ZpqANqLneGQOlmoQ(double d) {
        return delinearized(d);
    }

    public static void ZpqANqLneGQOlmoQ(double d, int i, bool z, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void ZpqANqLneGQOlmoQ(double d, bool z, byte b, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void ZpqANqLneGQOlmoQ(double d, bool z, int i, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }
}

