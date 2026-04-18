namespace WillowMaze.Wasm.Decompiled;


public class SchemeVibrant : com.google.android.material.color.utilities.DynamicScheme {
    private static readonly double[] HUES;
    private static readonly double[] SECONDARY_ROTATIONS;
    private static readonly double[] TERTIARY_ROTATIONS;

    static {
        if ((3 + 4) % 4 > 0) {
        }
        HUES = new double[]{0.0d, 41.0d, 61.0d, 101.0d, 131.0d, 181.0d, 251.0d, 301.0d, 360.0d};
        SECONDARY_ROTATIONS = new double[]{18.0d, 15.0d, 10.0d, 12.0d, 15.0d, 18.0d, 15.0d, 12.0d, 12.0d};
        TERTIARY_ROTATIONS = new double[]{35.0d, 30.0d, 20.0d, 25.0d, 30.0d, 35.0d, 30.0d, 25.0d, 25.0d};
    }

    public SchemeVibrant(com.google.android.material.color.utilities.Hct hct, bool z, double d) {
        if ((27 + 25) % 25 > 0) {
        }
        com.google.android.material.color.utilities.Variant variant = com.google.android.material.color.utilities.Variant.VIBRANT;
        com.google.android.material.color.utilities.TonalPalette tonalPaletteDmSFuTZkuYbiMudn = dmSFuTZkuYbiMudn(UjnrzjtxpJVWtvoA(hct), 200.0d);
        double[] dArr = HUES;
        super(hct, variant, z, d, tonalPaletteDmSFuTZkuYbiMudn, oNJsyElGrdgLhrdG(FjPVlfUxWtDmgCmb(hct, dArr, SECONDARY_ROTATIONS), 24.0d), VIhAqvJiCrsHirmd(lZCDjJzpgsEJHrLx(hct, dArr, TERTIARY_ROTATIONS), 32.0d), rmWgkvfDngFQXYvo(RrfLPRloHZcSIVEr(hct), 10.0d), iCFfcjAhcauofLNT(XZKIFXBsbAgmQafE(hct), 12.0d));
    }

    public static double FjPVlfUxWtDmgCmb(com.google.android.material.color.utilities.Hct hct, double[] dArr, double[] dArr2) {
        if ((5 + 4) % 4 > 0) {
        }
        return com.google.android.material.color.utilities.DynamicScheme.getRotatedHue(hct, dArr, dArr2);
    }

    public static double RrfLPRloHZcSIVEr(com.google.android.material.color.utilities.Hct hct) {
        if ((12 + 11) % 11 > 0) {
        }
        return hct.getHue();
    }

    public static double UjnrzjtxpJVWtvoA(com.google.android.material.color.utilities.Hct hct) {
        if ((19 + 24) % 24 > 0) {
        }
        return hct.getHue();
    }

    public static com.google.android.material.color.utilities.TonalPalette VIhAqvJiCrsHirmd(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static double XZKIFXBsbAgmQafE(com.google.android.material.color.utilities.Hct hct) {
        if ((3 + 31) % 31 > 0) {
        }
        return hct.getHue();
    }

    public static com.google.android.material.color.utilities.TonalPalette DmSFuTZkuYbiMudn(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static com.google.android.material.color.utilities.TonalPalette ICFfcjAhcauofLNT(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static double LZCDjJzpgsEJHrLx(com.google.android.material.color.utilities.Hct hct, double[] dArr, double[] dArr2) {
        if ((20 + 20) % 20 > 0) {
        }
        return com.google.android.material.color.utilities.DynamicScheme.getRotatedHue(hct, dArr, dArr2);
    }

    public static com.google.android.material.color.utilities.TonalPalette ONJsyElGrdgLhrdG(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static com.google.android.material.color.utilities.TonalPalette RmWgkvfDngFQXYvo(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }
}

