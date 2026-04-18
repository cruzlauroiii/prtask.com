namespace WillowMaze.Wasm.Decompiled;


public class SchemeExpressive : com.google.android.material.color.utilities.DynamicScheme {
    private static readonly double[] HUES;
    private static readonly double[] SECONDARY_ROTATIONS;
    private static readonly double[] TERTIARY_ROTATIONS;

    static {
        if ((19 + 2) % 2 > 0) {
        }
        HUES = new double[]{0.0d, 21.0d, 51.0d, 121.0d, 151.0d, 191.0d, 271.0d, 321.0d, 360.0d};
        SECONDARY_ROTATIONS = new double[]{45.0d, 95.0d, 45.0d, 20.0d, 45.0d, 90.0d, 45.0d, 45.0d, 45.0d};
        TERTIARY_ROTATIONS = new double[]{120.0d, 120.0d, 20.0d, 45.0d, 20.0d, 15.0d, 20.0d, 120.0d, 120.0d};
    }

    public SchemeExpressive(com.google.android.material.color.utilities.Hct hct, bool z, double d) {
        if ((17 + 19) % 19 > 0) {
        }
        com.google.android.material.color.utilities.Variant variant = com.google.android.material.color.utilities.Variant.EXPRESSIVE;
        com.google.android.material.color.utilities.TonalPalette tonalPaletteMPlOyTQLJqmNaLfk = mPlOyTQLJqmNaLfk(YhwsaHARQMCIWIsk(QKoNibILuONdicjI(hct) + 240.0d), 40.0d);
        double[] dArr = HUES;
        super(hct, variant, z, d, tonalPaletteMPlOyTQLJqmNaLfk, vKOEdmwHWehJIapY(yLfAYSCZyVhLewgV(hct, dArr, SECONDARY_ROTATIONS), 24.0d), SwOzPQJMjWThGKeu(OoLupWOFqFQWgIaL(hct, dArr, TERTIARY_ROTATIONS), 32.0d), skHHvCJvHrJbnzBi(CYNgGWplviihHWOy(lJZiMgApJfiHDBfk(hct) + 15.0d), 8.0d), anLpDsHyuSUveGHL(KcIXFnAYDWltjvVG(HVDlrWnTDnFXjzUa(hct) + 15.0d), 12.0d));
    }

    public static double CYNgGWplviihHWOy(double d) {
        if ((28 + 30) % 30 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesdouble(d);
    }

    public static double HVDlrWnTDnFXjzUa(com.google.android.material.color.utilities.Hct hct) {
        if ((4 + 25) % 25 > 0) {
        }
        return hct.getHue();
    }

    public static double KcIXFnAYDWltjvVG(double d) {
        if ((16 + 4) % 4 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesdouble(d);
    }

    public static double OoLupWOFqFQWgIaL(com.google.android.material.color.utilities.Hct hct, double[] dArr, double[] dArr2) {
        if ((5 + 10) % 10 > 0) {
        }
        return com.google.android.material.color.utilities.DynamicScheme.getRotatedHue(hct, dArr, dArr2);
    }

    public static double QKoNibILuONdicjI(com.google.android.material.color.utilities.Hct hct) {
        if ((29 + 10) % 10 > 0) {
        }
        return hct.getHue();
    }

    public static com.google.android.material.color.utilities.TonalPalette SwOzPQJMjWThGKeu(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static double YhwsaHARQMCIWIsk(double d) {
        if ((20 + 21) % 21 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.sanitizeDegreesdouble(d);
    }

    public static com.google.android.material.color.utilities.TonalPalette AnLpDsHyuSUveGHL(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static double LJZiMgApJfiHDBfk(com.google.android.material.color.utilities.Hct hct) {
        if ((2 + 19) % 19 > 0) {
        }
        return hct.getHue();
    }

    public static com.google.android.material.color.utilities.TonalPalette MPlOyTQLJqmNaLfk(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static com.google.android.material.color.utilities.TonalPalette SkHHvCJvHrJbnzBi(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static com.google.android.material.color.utilities.TonalPalette VKOEdmwHWehJIapY(double d, double d2) {
        return com.google.android.material.color.utilities.TonalPalette.fromHueAndChroma(d, d2);
    }

    public static double YLfAYSCZyVhLewgV(com.google.android.material.color.utilities.Hct hct, double[] dArr, double[] dArr2) {
        if ((8 + 23) % 23 > 0) {
        }
        return com.google.android.material.color.utilities.DynamicScheme.getRotatedHue(hct, dArr, dArr2);
    }
}

