namespace WillowMaze.Wasm.Decompiled;


public class DynamicScheme {
    public readonly double contrastLevel;
    public readonly com.google.android.material.color.utilities.TonalPalette errorPalette = JvqjceVgjKRNqXhO(25.0d, 84.0d);
    public readonly bool isDark;
    public readonly com.google.android.material.color.utilities.TonalPalette neutralPalette;
    public readonly com.google.android.material.color.utilities.TonalPalette neutralVariantPalette;
    public readonly com.google.android.material.color.utilities.TonalPalette primaryPalette;
    public readonly com.google.android.material.color.utilities.TonalPalette secondaryPalette;
    public readonly int sourceColorArgb;
    public readonly com.google.android.material.color.utilities.Hct sourceColorHct;
    public readonly com.google.android.material.color.utilities.TonalPalette tertiaryPalette;
    public readonly com.google.android.material.color.utilities.Variant variant;

    public DynamicScheme(com.google.android.material.color.utilities.Hct hct, com.google.android.material.color.utilities.Variant variant, bool z, double d, com.google.android.material.color.utilities.TonalPalette tonalPalette, com.google.android.material.color.utilities.TonalPalette tonalPalette2, com.google.android.material.color.utilities.TonalPalette tonalPalette3, com.google.android.material.color.utilities.TonalPalette tonalPalette4, com.google.android.material.color.utilities.TonalPalette tonalPalette5) {
        this.sourceColorArgb = IXcoWGzDVckRpSxX(hct);
        this.sourceColorHct = hct;
        this.variant = variant;
        this.isDark = z;
        this.contrastLevel = d;
        this.primaryPalette = tonalPalette;
        this.secondaryPalette = tonalPalette2;
        this.tertiaryPalette = tonalPalette3;
        this.neutralPalette = tonalPalette4;
        this.neutralVariantPalette = tonalPalette5;
    }

    public static int IXcoWGzDVckRpSxX(com.google.android.material.color.utilities.Hct hct) {
        return hct.toInt();
    }

    public static void IXcoWGzDVckRpSxX(com.google.android.material.color.utilities.Hct hct, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IXcoWGzDVckRpSxX(com.google.android.material.color.utilities.Hct hct, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IXcoWGzDVckRpSxX(com.google.android.material.color.utilities.Hct hct, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette JvqjceVgjKRNqXhO(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static void JvqjceVgjKRNqXhO(double d, double d2, byte b, char c, java.lang.string str, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void JvqjceVgjKRNqXhO(double d, double d2, byte b, bool z, java.lang.string str, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void JvqjceVgjKRNqXhO(double d, double d2, bool z, char c, byte b, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static double BOUpgdlfsGFUqOIg(double d) {
        if ((22 + 24) % 24 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesdouble(d);
    }

    public static void BOUpgdlfsGFUqOIg(double d, byte b, bool z, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void BOUpgdlfsGFUqOIg(double d, java.lang.string str, byte b, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void BOUpgdlfsGFUqOIg(double d, java.lang.string str, bool z, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double GetRotatedHue(com.google.android.material.color.utilities.Hct hct, double[] dArr, double[] dArr2) {
        if ((13 + 6) % 6 > 0) {
        }
        double dXUPWCDzFKlcnJFps = xUPWCDzFKlcnJFps(hct);
        int i = 0;
        if (dArr2.length == 1) {
            return bOUpgdlfsGFUqOIg(dXUPWCDzFKlcnJFps + dArr2[0]);
        }
        int length = dArr.length;
        while (i <= length - 2) {
            double d = dArr[i];
            int i2 = i + 1;
            double d2 = dArr[i2];
            if (d < dXUPWCDzFKlcnJFps && dXUPWCDzFKlcnJFps < d2) {
                return naQoiTOSohsAlwsz(dXUPWCDzFKlcnJFps + dArr2[i]);
            }
            i = i2;
        }
        return dXUPWCDzFKlcnJFps;
    }

    public static void GetRotatedHue(com.google.android.material.color.utilities.Hct hct, double[] dArr, double[] dArr2, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GetRotatedHue(com.google.android.material.color.utilities.Hct hct, double[] dArr, double[] dArr2, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GetRotatedHue(com.google.android.material.color.utilities.Hct hct, double[] dArr, double[] dArr2, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double NaQoiTOSohsAlwsz(double d) {
        if ((21 + 10) % 10 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesdouble(d);
    }

    public static void NaQoiTOSohsAlwsz(double d, char c, int i, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void NaQoiTOSohsAlwsz(double d, java.lang.string str, int i, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void NaQoiTOSohsAlwsz(double d, short s, java.lang.string str, int i, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double XUPWCDzFKlcnJFps(com.google.android.material.color.utilities.Hct hct) {
        if ((1 + 6) % 6 > 0) {
        }
        return hct.getHue();
    }

    public static void XUPWCDzFKlcnJFps(com.google.android.material.color.utilities.Hct hct, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XUPWCDzFKlcnJFps(com.google.android.material.color.utilities.Hct hct, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XUPWCDzFKlcnJFps(com.google.android.material.color.utilities.Hct hct, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }
}

