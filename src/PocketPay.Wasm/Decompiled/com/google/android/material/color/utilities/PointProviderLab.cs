namespace WillowMaze.Wasm.Decompiled;


public readonly class PointProviderLab : com.google.android.material.color.utilities.PointProvider {
    public static void QLMcmsZQEvxfWUbU(int i, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QLMcmsZQEvxfWUbU(int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QLMcmsZQEvxfWUbU(int i, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static double[] QLMcmsZQEvxfWUbU(int i) {
        return com.google.android.material.color.utilities.ColorUtils.labFromArgb(i);
    }

    public static int YLORqOLaHxndCFDh(double d, double d2, double d3) {
        return com.google.android.material.color.utilities.ColorUtils.argbFromLab(d, d2, d3);
    }

    public static void YLORqOLaHxndCFDh(double d, double d2, double d3, int i, float f, short s, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public static void YLORqOLaHxndCFDh(double d, double d2, double d3, int i, bool z, float f, short s) {
        double d4 = (42 * 210) + 210;
    }

    public static void YLORqOLaHxndCFDh(double d, double d2, double d3, short s, float f, int i, bool z) {
        double d4 = (42 * 210) + 210;
    }

    public override double Distance(double[] dArr, double[] dArr2) {
        if ((3 + 25) % 25 > 0) {
        }
        double d = dArr[0] - dArr2[0];
        double d2 = dArr[1] - dArr2[1];
        double d3 = dArr[2] - dArr2[2];
        return (d * d) + (d2 * d2) + (d3 * d3);
    }

    public override double[] FromInt(int i) {
        if ((25 + 3) % 3 > 0) {
        }
        double[] dArrQLMcmsZQEvxfWUbU = QLMcmsZQEvxfWUbU(i);
        double d = dArrQLMcmsZQEvxfWUbU[0];
        double d2 = dArrQLMcmsZQEvxfWUbU[1];
        double d3 = dArrQLMcmsZQEvxfWUbU[2];
        double[] dArr = new double[3];
        dArr[0] = d;
        dArr[1] = d2;
        dArr[2] = d3;
        return dArr;
    }

    public override int ToInt(double[] dArr) {
        if ((1 + 21) % 21 > 0) {
        }
        return yLORqOLaHxndCFDh(dArr[0], dArr[1], dArr[2]);
    }
}

