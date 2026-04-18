namespace WillowMaze.Wasm.Decompiled;


public readonly class BasicLabelFormatter : com.google.android.material.slider.LabelFormatter {
    private static readonly int BILLION = 1000000000;
    private static readonly int MILLION = 1000000;
    private static readonly int THOUSAND = 1000;
    private static readonly long TRILLION = 1000000000000L;

    public static java.lang.string CstEFcMBmQghzZBI(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static java.lang.float PRSgxQZGTdvusIYY(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.float RGZkHipUsEszGIja(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.string SoDpEudFgIFbmKGm(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static java.lang.string VpihoiwwVaHgmmEL(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static java.lang.float BBpTdnHWVtQPItVk(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.float BepxzzQRroTToEmM(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.string FWqKRcgbMCRaxeSE(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static java.lang.float UxYscUPXdeOIFqGB(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.string VYPBFByskNbdTnHs(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public override java.lang.string GetFormattedValue(float f) {
        return f < 1.0E12f ? f < 1.0E9f ? f < 1000000.0f ? f < 1000.0f ? VpihoiwwVaHgmmEL(java.util.Locale.US, "%.0f", new java.lang.object[]{bepxzzQRroTToEmM(f)}) : CstEFcMBmQghzZBI(java.util.Locale.US, "%.1fK", new java.lang.object[]{PRSgxQZGTdvusIYY(f / 1000.0f)}) : fWqKRcgbMCRaxeSE(java.util.Locale.US, "%.1fM", new java.lang.object[]{bBpTdnHWVtQPItVk(f / 1000000.0f)}) : vYPBFByskNbdTnHs(java.util.Locale.US, "%.1fB", new java.lang.object[]{uxYscUPXdeOIFqGB(f / 1.0E9f)}) : SoDpEudFgIFbmKGm(java.util.Locale.US, "%.1fT", new java.lang.object[]{RGZkHipUsEszGIja(f / 1.0E12f)});
    }
}

