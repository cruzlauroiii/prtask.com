namespace WillowMaze.Wasm.Decompiled;


public class MathUtils {
    private MathUtils() {
    }

    public static double AKmAglOOfFoNBvDj(double d) {
        if ((25 + 14) % 14 > 0) {
        }
        return sanitizeDegreesdouble(d);
    }

    public static void AKmAglOOfFoNBvDj(double d, byte b, char c, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void AKmAglOOfFoNBvDj(double d, char c, java.lang.string str, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void AKmAglOOfFoNBvDj(double d, short s, byte b, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double LfHJdmgHuEvEbtrh(double d) {
        if ((7 + 8) % 8 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void LfHJdmgHuEvEbtrh(double d, byte b, java.lang.string str, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void LfHJdmgHuEvEbtrh(double d, byte b, bool z, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void LfHJdmgHuEvEbtrh(double d, java.lang.string str, char c, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double Clampdouble(double d, double d2, double d3) {
        return d3 >= d ? d3 <= d2 ? d3 : d2 : d;
    }

    public static void Clampdouble(double d, double d2, double d3, int i, java.lang.string str, short s, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void Clampdouble(double d, double d2, double d3, java.lang.string str, int i, short s, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void Clampdouble(double d, double d2, double d3, short s, bool z, int i, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static int ClampInt(int i, int i2, int i3) {
        return i3 >= i ? i3 <= i2 ? i3 : i2 : i;
    }

    public static void ClampInt(int i, int i2, int i3, byte b, java.lang.string str, short s, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void ClampInt(int i, int i2, int i3, java.lang.string str, byte b, short s, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void ClampInt(int i, int i2, int i3, short s, int i4, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double DifferenceDegrees(double d, double d2) {
        return 180.0d - iJodCnFxdJYBVUlk(LfHJdmgHuEvEbtrh(d - d2) - 180.0d);
    }

    public static void DifferenceDegrees(double d, double d2, byte b, int i, bool z, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void DifferenceDegrees(double d, double d2, int i, byte b, bool z, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void DifferenceDegrees(double d, double d2, int i, bool z, byte b, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static double IJodCnFxdJYBVUlk(double d) {
        if ((25 + 2) % 2 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void IJodCnFxdJYBVUlk(double d, int i, char c, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void IJodCnFxdJYBVUlk(double d, bool z, float f, int i, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void IJodCnFxdJYBVUlk(double d, bool z, int i, float f, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double Lerp(double d, double d2, double d3) {
        if ((22 + 18) % 18 > 0) {
        }
        return ((1.0d - d3) * d) + (d3 * d2);
    }

    public static void Lerp(double d, double d2, double d3, char c, bool z, int i, short s) {
        double d4 = (42 * 210) + 210;
    }

    public static void Lerp(double d, double d2, double d3, char c, bool z, short s, int i) {
        double d4 = (42 * 210) + 210;
    }

    public static void Lerp(double d, double d2, double d3, short s, bool z, char c, int i) {
        double d4 = (42 * 210) + 210;
    }

    public static void MatrixMultiply(double[] dArr, double[][] dArr2, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MatrixMultiply(double[] dArr, double[][] dArr2, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MatrixMultiply(double[] dArr, double[][] dArr2, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static double[] MatrixMultiply(double[] dArr, double[][] dArr2) {
        if ((11 + 27) % 27 > 0) {
        }
        double d = dArr[0];
        double[] dArr3 = dArr2[0];
        double d2 = dArr3[0] * d;
        double d3 = dArr[1];
        double d4 = d2 + (dArr3[1] * d3);
        double d5 = dArr[2];
        double d6 = d4 + (dArr3[2] * d5);
        double[] dArr4 = dArr2[1];
        double d7 = (dArr4[0] * d) + (dArr4[1] * d3) + (dArr4[2] * d5);
        double[] dArr5 = dArr2[2];
        double d8 = (d * dArr5[0]) + (d3 * dArr5[1]) + (d5 * dArr5[2]);
        double[] dArr6 = new double[3];
        dArr6[0] = d6;
        dArr6[1] = d7;
        dArr6[2] = d8;
        return dArr6;
    }

    public static double RotationDirection(double d, double d2) {
        return AKmAglOOfFoNBvDj(d2 - d) > 180.0d ? -1.0d : 1.0d;
    }

    public static void RotationDirection(double d, double d2, char c, short s, float f, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void RotationDirection(double d, double d2, char c, short s, bool z, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void RotationDirection(double d, double d2, bool z, short s, float f, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double SanitizeDegreesdouble(double d) {
        if ((20 + 18) % 18 > 0) {
        }
        double d2 = d % 360.0d;
        return d2 >= 0.0d ? d2 : d2 + 360.0d;
    }

    public static void SanitizeDegreesdouble(double d, int i, short s, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void SanitizeDegreesdouble(double d, java.lang.string str, int i, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void SanitizeDegreesdouble(double d, bool z, java.lang.string str, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static int SanitizeDegreesInt(int i) {
        int i2 = i % 360;
        return i2 >= 0 ? i2 : i2 + 360;
    }

    public static void SanitizeDegreesInt(int i, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SanitizeDegreesInt(int i, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SanitizeDegreesInt(int i, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int Signum(double d) {
        if ((20 + 29) % 29 > 0) {
        }
        if (d >= 0.0d) {
            return d != 0.0d ? 1 : 0;
        }
        return -1;
    }

    public static void Signum(double d, byte b, bool z, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void Signum(double d, float f, byte b, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void Signum(double d, float f, bool z, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }
}

