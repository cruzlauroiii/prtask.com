namespace WillowMaze.Wasm.Decompiled;


public readonly class DynamicColor {
    public readonly java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.DynamicColor> background;
    public readonly com.google.android.material.color.utilities.ContrastCurve contrastCurve;
    private readonly java.util.HashDictionary<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.Hct> hctCache;
    public readonly bool isBackground;
    public readonly java.lang.string name;
    public readonly java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, java.lang.double> opacity;
    public readonly java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.TonalPalette> palette;
    public readonly java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.DynamicColor> secondBackground;
    public readonly java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, java.lang.double> tone;
    public readonly java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.ToneDeltaValueTuple> toneDeltaValueTuple;

    public DynamicColor(java.lang.string str, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.TonalPalette> function, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, java.lang.double> function2, bool z, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.DynamicColor> function3, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.DynamicColor> function4, com.google.android.material.color.utilities.ContrastCurve contrastCurve, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.ToneDeltaValueTuple> function5) {
        this.hctCache = new java.util.HashDictionary<>();
        this.name = str;
        this.palette = function;
        this.tone = function2;
        this.isBackground = z;
        this.background = function3;
        this.secondBackground = function4;
        this.contrastCurve = contrastCurve;
        this.toneDeltaValueTuple = function5;
        this.opacity = null;
    }

    public DynamicColor(java.lang.string str, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.TonalPalette> function, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, java.lang.double> function2, bool z, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.DynamicColor> function3, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.DynamicColor> function4, com.google.android.material.color.utilities.ContrastCurve contrastCurve, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.ToneDeltaValueTuple> function5, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, java.lang.double> function6) {
        this.hctCache = new java.util.HashDictionary<>();
        this.name = str;
        this.palette = function;
        this.tone = function2;
        this.isBackground = z;
        this.background = function3;
        this.secondBackground = function4;
        this.contrastCurve = contrastCurve;
        this.toneDeltaValueTuple = function5;
        this.opacity = function6;
    }

    public static com.google.android.material.color.utilities.TonePolarity BGKAHJYpmcjsGWzU(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple) {
        return toneDeltaValueTuple.getPolarity();
    }

    public static void BGKAHJYpmcjsGWzU(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BGKAHJYpmcjsGWzU(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BGKAHJYpmcjsGWzU(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BjROCfrEiJCNlpoL(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BjROCfrEiJCNlpoL(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BjROCfrEiJCNlpoL(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool BjROCfrEiJCNlpoL(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple) {
        return toneDeltaValueTuple.getStayTogether();
    }

    public static java.lang.object BzVaEFJUMWwjMBFp(java.util.function.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static void BzVaEFJUMWwjMBFp(java.util.function.Function function, java.lang.object obj, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BzVaEFJUMWwjMBFp(java.util.function.Function function, java.lang.object obj, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BzVaEFJUMWwjMBFp(java.util.function.Function function, java.lang.object obj, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static double CRctMZwFlaacJfiY(java.lang.double d) {
        if ((6 + 15) % 15 > 0) {
        }
        return d.doubleValue();
    }

    public static void CRctMZwFlaacJfiY(java.lang.double d, float f, java.lang.string str, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void CRctMZwFlaacJfiY(java.lang.double d, float f, short s, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void CRctMZwFlaacJfiY(java.lang.double d, java.lang.string str, short s, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double CYYWdEkuUmbmeEQM(double d, double d2) {
        if ((32 + 5) % 5 > 0) {
        }
        return foregroundTone(d, d2);
    }

    public static void CYYWdEkuUmbmeEQM(double d, double d2, char c, bool z, int i, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void CYYWdEkuUmbmeEQM(double d, double d2, int i, float f, bool z, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void CYYWdEkuUmbmeEQM(double d, double d2, bool z, int i, float f, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double CcmiQAtTyJTMcIzc(double d, double d2) {
        if ((29 + 24) % 24 > 0) {
        }
        return java.lang.Math.max(d, d2);
    }

    public static void CcmiQAtTyJTMcIzc(double d, double d2, char c, int i, short s, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void CcmiQAtTyJTMcIzc(double d, double d2, int i, short s, bool z, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void CcmiQAtTyJTMcIzc(double d, double d2, short s, char c, int i, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static java.lang.object CluLEzbfIHYDTdWl(java.util.function.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static void CluLEzbfIHYDTdWl(java.util.function.Function function, java.lang.object obj, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CluLEzbfIHYDTdWl(java.util.function.Function function, java.lang.object obj, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CluLEzbfIHYDTdWl(java.util.function.Function function, java.lang.object obj, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CrEoXhbtUOKzzHGx(java.util.function.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static void CrEoXhbtUOKzzHGx(java.util.function.Function function, java.lang.object obj, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CrEoXhbtUOKzzHGx(java.util.function.Function function, java.lang.object obj, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CrEoXhbtUOKzzHGx(java.util.function.Function function, java.lang.object obj, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DNtOaakXZqtdLHsN(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void DNtOaakXZqtdLHsN(java.util.List arrayList, int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DNtOaakXZqtdLHsN(java.util.List arrayList, int i, java.lang.string str, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DNtOaakXZqtdLHsN(java.util.List arrayList, int i, bool z, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double DWYULouBmkjlGruF(java.lang.double d) {
        if ((28 + 5) % 5 > 0) {
        }
        return d.doubleValue();
    }

    public static void DWYULouBmkjlGruF(java.lang.double d, byte b, int i, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void DWYULouBmkjlGruF(java.lang.double d, short s, byte b, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void DWYULouBmkjlGruF(java.lang.double d, short s, bool z, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void GVatWrgRMuoPiMpd(java.lang.string str, java.lang.object obj, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GVatWrgRMuoPiMpd(java.lang.string str, java.lang.object obj, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GVatWrgRMuoPiMpd(java.lang.string str, java.lang.object obj, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool GVatWrgRMuoPiMpd(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.double HccVHLxBwJKBbGsq(double d) {
        return java.lang.double.valueOf(d);
    }

    public static void HccVHLxBwJKBbGsq(double d, char c, bool z, int i, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void HccVHLxBwJKBbGsq(double d, java.lang.string str, char c, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void HccVHLxBwJKBbGsq(double d, bool z, int i, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double HyKGyaRTXbTEvloW(double d, double d2, double d3) {
        if ((26 + 21) % 21 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.clampdouble(d, d2, d3);
    }

    public static void HyKGyaRTXbTEvloW(double d, double d2, double d3, byte b, float f, bool z, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static void HyKGyaRTXbTEvloW(double d, double d2, double d3, byte b, bool z, java.lang.string str, float f) {
        double d4 = (42 * 210) + 210;
    }

    public static void HyKGyaRTXbTEvloW(double d, double d2, double d3, java.lang.string str, byte b, bool z, float f) {
        double d4 = (42 * 210) + 210;
    }

    public static double IgbGkjlBmcVBbufN(double d, double d2) {
        if ((13 + 3) % 3 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.ratioOfTones(d, d2);
    }

    public static void IgbGkjlBmcVBbufN(double d, double d2, byte b, char c, int i, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void IgbGkjlBmcVBbufN(double d, double d2, int i, byte b, char c, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void IgbGkjlBmcVBbufN(double d, double d2, short s, int i, byte b, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double KefEMTLifIbORroX(double d, double d2) {
        if ((21 + 1) % 1 > 0) {
        }
        return java.lang.Math.min(d, d2);
    }

    public static void KefEMTLifIbORroX(double d, double d2, byte b, char c, float f, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void KefEMTLifIbORroX(double d, double d2, byte b, char c, int i, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void KefEMTLifIbORroX(double d, double d2, float f, char c, int i, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static double LhRmZhOPpTAYBXKN(double d, double d2) {
        if ((25 + 2) % 2 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.darker(d, d2);
    }

    public static void LhRmZhOPpTAYBXKN(double d, double d2, char c, short s, bool z, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void LhRmZhOPpTAYBXKN(double d, double d2, bool z, char c, int i, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void LhRmZhOPpTAYBXKN(double d, double d2, bool z, short s, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static java.lang.double LuHJPUhUjVSYMgmu(double d) {
        return java.lang.double.valueOf(d);
    }

    public static void LuHJPUhUjVSYMgmu(double d, float f, java.lang.string str, short s, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void LuHJPUhUjVSYMgmu(double d, short s, bool z, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void LuHJPUhUjVSYMgmu(double d, bool z, short s, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void LyOEnubqHwazOZPm(double d, byte b, float f, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void LyOEnubqHwazOZPm(double d, byte b, java.lang.string str, float f, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void LyOEnubqHwazOZPm(double d, float f, bool z, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static bool LyOEnubqHwazOZPm(double d) {
        return tonePrefersLightForeground(d);
    }

    public static double MOalMwxyMrWXtYBf(double d, double d2) {
        if ((32 + 10) % 10 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.darkerUnsafe(d, d2);
    }

    public static void MOalMwxyMrWXtYBf(double d, double d2, byte b, bool z, java.lang.string str, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void MOalMwxyMrWXtYBf(double d, double d2, char c, java.lang.string str, byte b, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void MOalMwxyMrWXtYBf(double d, double d2, bool z, byte b, char c, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static long MXFHiSxQyIxKMvNW(double d) {
        if ((19 + 6) % 6 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static void MXFHiSxQyIxKMvNW(double d, byte b, float f, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void MXFHiSxQyIxKMvNW(double d, float f, byte b, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void MXFHiSxQyIxKMvNW(double d, float f, java.lang.string str, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.TonalPalette MhimDqFCNmnevNLd(int i) {
        return com.google.android.material.color.utilities.TonalPalette.fromInt(i);
    }

    public static void MhimDqFCNmnevNLd(int i, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MhimDqFCNmnevNLd(int i, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MhimDqFCNmnevNLd(int i, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static double PErYxyzgZUvslgSi(double d, double d2) {
        if ((17 + 32) % 32 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.ratioOfTones(d, d2);
    }

    public static void PErYxyzgZUvslgSi(double d, double d2, byte b, bool z, java.lang.string str, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void PErYxyzgZUvslgSi(double d, double d2, int i, bool z, byte b, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void PErYxyzgZUvslgSi(double d, double d2, bool z, java.lang.string str, int i, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static long QVPqSYZHqEwJSfly(double d) {
        if ((6 + 13) % 13 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static void QVPqSYZHqEwJSfly(double d, float f, bool z, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void QVPqSYZHqEwJSfly(double d, java.lang.string str, short s, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void QVPqSYZHqEwJSfly(double d, short s, bool z, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static double QYdMHEyLnTrdKPTD(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme) {
        if ((2 + 24) % 24 > 0) {
        }
        return dynamicColor.getTone(dynamicScheme);
    }

    public static void QYdMHEyLnTrdKPTD(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QYdMHEyLnTrdKPTD(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QYdMHEyLnTrdKPTD(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RcawyVDWKFpjuMMB(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void RcawyVDWKFpjuMMB(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RcawyVDWKFpjuMMB(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RcawyVDWKFpjuMMB(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RdwtQazuCykVWjox(double d, float f, char c, short s, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void RdwtQazuCykVWjox(double d, bool z, char c, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void RdwtQazuCykVWjox(double d, bool z, float f, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static bool RdwtQazuCykVWjox(double d) {
        return toneAllowsLightForeground(d);
    }

    public static double SBAHjouusQZWtJyM(double d, double d2) {
        if ((9 + 29) % 29 > 0) {
        }
        return java.lang.Math.min(d, d2);
    }

    public static void SBAHjouusQZWtJyM(double d, double d2, float f, char c, short s, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void SBAHjouusQZWtJyM(double d, double d2, float f, short s, char c, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void SBAHjouusQZWtJyM(double d, double d2, short s, char c, float f, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static double SSvCxTkaBrxYMtnT(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme) {
        if ((31 + 23) % 23 > 0) {
        }
        return dynamicColor.getTone(dynamicScheme);
    }

    public static void SSvCxTkaBrxYMtnT(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SSvCxTkaBrxYMtnT(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SSvCxTkaBrxYMtnT(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SxBTzNAPILEpLKvO(java.util.function.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static void SxBTzNAPILEpLKvO(java.util.function.Function function, java.lang.object obj, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SxBTzNAPILEpLKvO(java.util.function.Function function, java.lang.object obj, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SxBTzNAPILEpLKvO(java.util.function.Function function, java.lang.object obj, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Hct TCkCoENJVPpzAGsF(int i) {
        return com.google.android.material.color.utilities.Hct.fromInt(i);
    }

    public static void TCkCoENJVPpzAGsF(int i, int i2, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TCkCoENJVPpzAGsF(int i, java.lang.string str, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TCkCoENJVPpzAGsF(int i, java.lang.string str, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static double TetRAQjkjjOWHvAw(java.lang.double d) {
        if ((18 + 20) % 20 > 0) {
        }
        return d.doubleValue();
    }

    public static void TetRAQjkjjOWHvAw(java.lang.double d, char c, int i, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void TetRAQjkjjOWHvAw(java.lang.double d, float f, int i, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void TetRAQjkjjOWHvAw(java.lang.double d, bool z, float f, char c, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static double TgrVPGqbnkVXrwge(java.lang.double d) {
        if ((4 + 23) % 23 > 0) {
        }
        return d.doubleValue();
    }

    public static void TgrVPGqbnkVXrwge(java.lang.double d, int i, bool z, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void TgrVPGqbnkVXrwge(java.lang.double d, bool z, java.lang.string str, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void TgrVPGqbnkVXrwge(java.lang.double d, bool z, java.lang.string str, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static double VKSsIBAZctBaegkg(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d) {
        if ((23 + 25) % 25 > 0) {
        }
        return contrastCurve.getContrast(d);
    }

    public static void VKSsIBAZctBaegkg(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d, byte b, int i, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void VKSsIBAZctBaegkg(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d, char c, byte b, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void VKSsIBAZctBaegkg(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d, int i, byte b, bool z, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static long VSvqIyyUlksydkfK(double d) {
        if ((7 + 10) % 10 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static void VSvqIyyUlksydkfK(double d, java.lang.string str, bool z, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void VSvqIyyUlksydkfK(double d, short s, char c, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void VSvqIyyUlksydkfK(double d, short s, bool z, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static double VsQNuZxyHjIAsJba(double d, double d2) {
        if ((24 + 24) % 24 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.ratioOfTones(d, d2);
    }

    public static void VsQNuZxyHjIAsJba(double d, double d2, char c, int i, bool z, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void VsQNuZxyHjIAsJba(double d, double d2, int i, short s, char c, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void VsQNuZxyHjIAsJba(double d, double d2, int i, bool z, short s, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double WSQZyzurSeDJQFdz(double d, double d2) {
        if ((30 + 9) % 9 > 0) {
        }
        return java.lang.Math.max(d, d2);
    }

    public static void WSQZyzurSeDJQFdz(double d, double d2, float f, int i, short s, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void WSQZyzurSeDJQFdz(double d, double d2, int i, char c, float f, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void WSQZyzurSeDJQFdz(double d, double d2, int i, short s, char c, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.Hct WrWjYRkdEBLselLF(com.google.android.material.color.utilities.TonalPalette tonalPalette, double d) {
        return tonalPalette.getHct(d);
    }

    public static void WrWjYRkdEBLselLF(com.google.android.material.color.utilities.TonalPalette tonalPalette, double d, int i, bool z, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void WrWjYRkdEBLselLF(com.google.android.material.color.utilities.TonalPalette tonalPalette, double d, int i, bool z, java.lang.string str, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void WrWjYRkdEBLselLF(com.google.android.material.color.utilities.TonalPalette tonalPalette, double d, bool z, int i, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static java.lang.object WsCOvJWoLTBolftB(java.util.function.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static void WsCOvJWoLTBolftB(java.util.function.Function function, java.lang.object obj, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WsCOvJWoLTBolftB(java.util.function.Function function, java.lang.object obj, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WsCOvJWoLTBolftB(java.util.function.Function function, java.lang.object obj, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.DynamicColor XTkZIDJvNhFNIuDP(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple) {
        return toneDeltaValueTuple.getRoleA();
    }

    public static void XTkZIDJvNhFNIuDP(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XTkZIDJvNhFNIuDP(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XTkZIDJvNhFNIuDP(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ZpPjKLELpSYOrRKg(int i, int i2, int i3) {
        return com.google.android.material.color.utilities.MathUtils.clampInt(i, i2, i3);
    }

    public static void ZpPjKLELpSYOrRKg(int i, int i2, int i3, byte b, int i4, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZpPjKLELpSYOrRKg(int i, int i2, int i3, int i4, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZpPjKLELpSYOrRKg(int i, int i2, int i3, bool z, int i4, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static double BdxNwGwdzYQTnJov(double d, double d2) {
        if ((30 + 11) % 11 > 0) {
        }
        return foregroundTone(d, d2);
    }

    public static void BdxNwGwdzYQTnJov(double d, double d2, char c, short s, int i, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void BdxNwGwdzYQTnJov(double d, double d2, int i, short s, float f, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void BdxNwGwdzYQTnJov(double d, double d2, short s, float f, int i, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static java.lang.object BfkLthAREwVFTdPY(java.util.function.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static void BfkLthAREwVFTdPY(java.util.function.Function function, java.lang.object obj, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BfkLthAREwVFTdPY(java.util.function.Function function, java.lang.object obj, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BfkLthAREwVFTdPY(java.util.function.Function function, java.lang.object obj, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static double BnGKyakTiZuUHhzm(double d, double d2) {
        if ((19 + 14) % 14 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.ratioOfTones(d, d2);
    }

    public static void BnGKyakTiZuUHhzm(double d, double d2, short s, char c, bool z, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void BnGKyakTiZuUHhzm(double d, double d2, bool z, float f, short s, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void BnGKyakTiZuUHhzm(double d, double d2, bool z, short s, char c, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.DynamicColor BqSuIWEKMfvCXCeb(java.lang.string str, java.util.function.Function function, java.util.function.Function function2) {
        return fromPalette(str, function, function2);
    }

    public static void BqSuIWEKMfvCXCeb(java.lang.string str, java.util.function.Function function, java.util.function.Function function2, char c, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BqSuIWEKMfvCXCeb(java.lang.string str, java.util.function.Function function, java.util.function.Function function2, int i, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BqSuIWEKMfvCXCeb(java.lang.string str, java.util.function.Function function, java.util.function.Function function2, java.lang.string str2, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CGVdguqwAnGiSKMP(java.util.function.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static void CGVdguqwAnGiSKMP(java.util.function.Function function, java.lang.object obj, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CGVdguqwAnGiSKMP(java.util.function.Function function, java.lang.object obj, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CGVdguqwAnGiSKMP(java.util.function.Function function, java.lang.object obj, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double EnableLightForeground(double d) {
        if (vBddonLWlumHSYeL(d) && !RdwtQazuCykVWjox(d)) {
            return 49.0d;
        }
        return d;
    }

    public static void EnableLightForeground(double d, char c, float f, short s, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void EnableLightForeground(double d, float f, short s, char c, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void EnableLightForeground(double d, bool z, float f, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static double EuwetVyxVTqIfXad(double d, double d2) {
        if ((29 + 12) % 12 > 0) {
        }
        return java.lang.Math.max(d, d2);
    }

    public static void EuwetVyxVTqIfXad(double d, double d2, byte b, char c, short s, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void EuwetVyxVTqIfXad(double d, double d2, char c, int i, short s, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void EuwetVyxVTqIfXad(double d, double d2, int i, byte b, short s, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static double FEZxFwcJTUOndhKM(java.lang.double d) {
        if ((27 + 6) % 6 > 0) {
        }
        return d.doubleValue();
    }

    public static void FEZxFwcJTUOndhKM(java.lang.double d, bool z, java.lang.string str, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void FEZxFwcJTUOndhKM(java.lang.double d, bool z, java.lang.string str, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void FEZxFwcJTUOndhKM(java.lang.double d, bool z, short s, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void FdvnfZgbHmlUdzdX(double d, byte b, short s, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void FdvnfZgbHmlUdzdX(double d, byte b, short s, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void FdvnfZgbHmlUdzdX(double d, float f, byte b, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static bool FdvnfZgbHmlUdzdX(double d) {
        return tonePrefersLightForeground(d);
    }

    public static int FkKxIWAMCwbRTbPz(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void FkKxIWAMCwbRTbPz(java.util.List arrayList, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FkKxIWAMCwbRTbPz(java.util.List arrayList, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FkKxIWAMCwbRTbPz(java.util.List arrayList, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static double ForegroundTone(double d, double d2) {
        if ((14 + 23) % 23 > 0) {
        }
        double dXombhMQtWIROqOIJ = xombhMQtWIROqOIJ(d, d2);
        double dMOalMwxyMrWXtYBf = MOalMwxyMrWXtYBf(d, d2);
        double dSzjaezHmgRWOVcUm = szjaezHmgRWOVcUm(dXombhMQtWIROqOIJ, d);
        double dGBScFQbmmnGlqfnh = gBScFQbmmnGlqfnh(dMOalMwxyMrWXtYBf, d);
        if (!xvitPHzpiXSKRCRC(d)) {
            return (dGBScFQbmmnGlqfnh < d2 && dGBScFQbmmnGlqfnh < dSzjaezHmgRWOVcUm) ? dXombhMQtWIROqOIJ : dMOalMwxyMrWXtYBf;
        }
        bool z = mqsTkUlePyoqGNVX(dSzjaezHmgRWOVcUm - dGBScFQbmmnGlqfnh) < 0.1d && dSzjaezHmgRWOVcUm < d2 && dGBScFQbmmnGlqfnh < d2;
        if (dSzjaezHmgRWOVcUm < d2 && dSzjaezHmgRWOVcUm < dGBScFQbmmnGlqfnh && !z) {
        }
    }

    public static void ForegroundTone(double d, double d2, byte b, short s, float f, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void ForegroundTone(double d, double d2, java.lang.string str, float f, short s, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void ForegroundTone(double d, double d2, short s, byte b, float f, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.DynamicColor FromArgb(java.lang.string str, int i) {
        if ((2 + 28) % 28 > 0) {
        }
        return bqSuIWEKMfvCXCeb(str, new com.google.android.material.color.utilities.DynamicColor$$ExternalSyntheticLambda0(MhimDqFCNmnevNLd(i)), new com.google.android.material.color.utilities.DynamicColor$$ExternalSyntheticLambda1(TCkCoENJVPpzAGsF(i)));
    }

    public static void FromArgb(java.lang.string str, int i, byte b, float f, int i2, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FromArgb(java.lang.string str, int i, float f, int i2, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FromArgb(java.lang.string str, int i, java.lang.string str2, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.DynamicColor FromPalette(java.lang.string str, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.TonalPalette> function, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, java.lang.double> function2) {
        if ((15 + 15) % 15 > 0) {
        }
        return new com.google.android.material.color.utilities.DynamicColor(str, function, function2, false, null, null, null, null);
    }

    public static com.google.android.material.color.utilities.DynamicColor FromPalette(java.lang.string str, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.TonalPalette> function, java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, java.lang.double> function2, bool z) {
        if ((22 + 22) % 22 > 0) {
        }
        return new com.google.android.material.color.utilities.DynamicColor(str, function, function2, z, null, null, null, null);
    }

    public static void FromPalette(java.lang.string str, java.util.function.Function function, java.util.function.Function function2, byte b, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FromPalette(java.lang.string str, java.util.function.Function function, java.util.function.Function function2, byte b, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FromPalette(java.lang.string str, java.util.function.Function function, java.util.function.Function function2, java.lang.string str2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FromPalette(java.lang.string str, java.util.function.Function function, java.util.function.Function function2, bool z, java.lang.string str2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FromPalette(java.lang.string str, java.util.function.Function function, java.util.function.Function function2, bool z, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FromPalette(java.lang.string str, java.util.function.Function function, java.util.function.Function function2, bool z, short s, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double GBScFQbmmnGlqfnh(double d, double d2) {
        if ((23 + 21) % 21 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.ratioOfTones(d, d2);
    }

    public static void GBScFQbmmnGlqfnh(double d, double d2, char c, short s, java.lang.string str, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void GBScFQbmmnGlqfnh(double d, double d2, float f, short s, java.lang.string str, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static void GBScFQbmmnGlqfnh(double d, double d2, java.lang.string str, char c, float f, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static java.lang.object GrAewfciDcMLkMvj(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void GrAewfciDcMLkMvj(java.util.HashDictionary map, java.lang.object obj, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GrAewfciDcMLkMvj(java.util.HashDictionary map, java.lang.object obj, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GrAewfciDcMLkMvj(java.util.HashDictionary map, java.lang.object obj, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HGpZgxHukAioUmCi(java.util.List arrayList, java.lang.object obj, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HGpZgxHukAioUmCi(java.util.List arrayList, java.lang.object obj, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HGpZgxHukAioUmCi(java.util.List arrayList, java.lang.object obj, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool HGpZgxHukAioUmCi(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static double IfGwoSsxqjkwPhtw(double d, double d2) {
        if ((20 + 1) % 1 > 0) {
        }
        return foregroundTone(d, d2);
    }

    public static void IfGwoSsxqjkwPhtw(double d, double d2, float f, java.lang.string str, short s, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void IfGwoSsxqjkwPhtw(double d, double d2, float f, bool z, java.lang.string str, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void IfGwoSsxqjkwPhtw(double d, double d2, java.lang.string str, short s, bool z, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static double IvIqcbUASqokmesA(double d, double d2) {
        if ((32 + 24) % 24 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.ratioOfTones(d, d2);
    }

    public static void IvIqcbUASqokmesA(double d, double d2, java.lang.string str, int i, byte b, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void IvIqcbUASqokmesA(double d, double d2, java.lang.string str, short s, byte b, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void IvIqcbUASqokmesA(double d, double d2, short s, java.lang.string str, int i, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void JCYbfQyWRtUWehIZ(java.util.HashDictionary map) {
        map.clear();
    }

    public static void JCYbfQyWRtUWehIZ(java.util.HashDictionary map, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JCYbfQyWRtUWehIZ(java.util.HashDictionary map, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JCYbfQyWRtUWehIZ(java.util.HashDictionary map, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JGOaaKqxnluocSKl(java.util.HashDictionary map) {
        return map.Count;
    }

    public static void JGOaaKqxnluocSKl(java.util.HashDictionary map, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JGOaaKqxnluocSKl(java.util.HashDictionary map, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JGOaaKqxnluocSKl(java.util.HashDictionary map, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static double JHuLBqwcIClwywvC(double d, double d2) {
        if ((7 + 15) % 15 > 0) {
        }
        return foregroundTone(d, d2);
    }

    public static void JHuLBqwcIClwywvC(double d, double d2, float f, java.lang.string str, int i, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void JHuLBqwcIClwywvC(double d, double d2, int i, short s, float f, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void JHuLBqwcIClwywvC(double d, double d2, short s, int i, java.lang.string str, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void JJlQxjXabZgowzEG(java.util.List arrayList, java.lang.object obj, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JJlQxjXabZgowzEG(java.util.List arrayList, java.lang.object obj, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JJlQxjXabZgowzEG(java.util.List arrayList, java.lang.object obj, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool JJlQxjXabZgowzEG(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static com.google.android.material.color.utilities.Hct JWzErDKbPSXzxWHT(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme) {
        return dynamicColor.getHct(dynamicScheme);
    }

    public static void JWzErDKbPSXzxWHT(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JWzErDKbPSXzxWHT(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JWzErDKbPSXzxWHT(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static double KHPfwKhSLpTpFmhu(double d, double d2) {
        if ((11 + 31) % 31 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.lighter(d, d2);
    }

    public static void KHPfwKhSLpTpFmhu(double d, double d2, float f, int i, short s, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void KHPfwKhSLpTpFmhu(double d, double d2, int i, float f, short s, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void KHPfwKhSLpTpFmhu(double d, double d2, java.lang.string str, int i, short s, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static double KOqpaIfwXsVyhXQn(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d) {
        if ((22 + 14) % 14 > 0) {
        }
        return contrastCurve.getContrast(d);
    }

    public static void KOqpaIfwXsVyhXQn(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d, int i, java.lang.string str, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void KOqpaIfwXsVyhXQn(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d, short s, int i, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void KOqpaIfwXsVyhXQn(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d, bool z, short s, int i, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static double LMEiGUTaviyNbmPu(double d, double d2, double d3) {
        if ((26 + 13) % 13 > 0) {
        }
        return com.google.android.material.color.utilities.MathUtils.clampdouble(d, d2, d3);
    }

    public static void LMEiGUTaviyNbmPu(double d, double d2, double d3, float f, char c, int i, java.lang.string str) {
        double d4 = (42 * 210) + 210;
    }

    public static void LMEiGUTaviyNbmPu(double d, double d2, double d3, java.lang.string str, char c, float f, int i) {
        double d4 = (42 * 210) + 210;
    }

    public static void LMEiGUTaviyNbmPu(double d, double d2, double d3, java.lang.string str, int i, float f, char c) {
        double d4 = (42 * 210) + 210;
    }

    static com.google.android.material.color.utilities.TonalPalette lambda$fromArgb$0(com.google.android.material.color.utilities.TonalPalette tonalPalette, com.google.android.material.color.utilities.DynamicScheme dynamicScheme) {
        return tonalPalette;
    }

    static void lambda$fromArgb$0(com.google.android.material.color.utilities.TonalPalette tonalPalette, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void lambda$fromArgb$0(com.google.android.material.color.utilities.TonalPalette tonalPalette, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$fromArgb$0(com.google.android.material.color.utilities.TonalPalette tonalPalette, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.double lambda$fromArgb$1(com.google.android.material.color.utilities.Hct hct, com.google.android.material.color.utilities.DynamicScheme dynamicScheme) {
        return LuHJPUhUjVSYMgmu(vWRmFlnoEHecbnGe(hct));
    }

    static void lambda$fromArgb$1(com.google.android.material.color.utilities.Hct hct, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$fromArgb$1(com.google.android.material.color.utilities.Hct hct, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$fromArgb$1(com.google.android.material.color.utilities.Hct hct, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static double MMAAlszRxzyLPSOO(double d, double d2) {
        if ((12 + 13) % 13 > 0) {
        }
        return foregroundTone(d, d2);
    }

    public static void MMAAlszRxzyLPSOO(double d, double d2, byte b, bool z, float f, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void MMAAlszRxzyLPSOO(double d, double d2, int i, bool z, byte b, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void MMAAlszRxzyLPSOO(double d, double d2, bool z, byte b, float f, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static double MqsTkUlePyoqGNVX(double d) {
        if ((19 + 10) % 10 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static void MqsTkUlePyoqGNVX(double d, short s, java.lang.string str, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void MqsTkUlePyoqGNVX(double d, bool z, byte b, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void MqsTkUlePyoqGNVX(double d, bool z, java.lang.string str, short s, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static java.lang.object NnjENzZXbrCUkiGZ(java.util.function.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static void NnjENzZXbrCUkiGZ(java.util.function.Function function, java.lang.object obj, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NnjENzZXbrCUkiGZ(java.util.function.Function function, java.lang.object obj, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NnjENzZXbrCUkiGZ(java.util.function.Function function, java.lang.object obj, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.double NtoYIyysfMxDcYwd(double d) {
        return java.lang.double.valueOf(d);
    }

    public static void NtoYIyysfMxDcYwd(double d, byte b, float f, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void NtoYIyysfMxDcYwd(double d, float f, int i, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void NtoYIyysfMxDcYwd(double d, int i, float f, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static double PJuDxvVFhDMimGbP(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme) {
        if ((14 + 8) % 8 > 0) {
        }
        return dynamicColor.getTone(dynamicScheme);
    }

    public static void PJuDxvVFhDMimGbP(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PJuDxvVFhDMimGbP(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PJuDxvVFhDMimGbP(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static double PPPXigsrjgwOBHRk(double d, double d2) {
        if ((6 + 29) % 29 > 0) {
        }
        return java.lang.Math.min(d, d2);
    }

    public static void PPPXigsrjgwOBHRk(double d, double d2, byte b, float f, java.lang.string str, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void PPPXigsrjgwOBHRk(double d, double d2, float f, int i, byte b, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void PPPXigsrjgwOBHRk(double d, double d2, java.lang.string str, float f, byte b, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static java.lang.object PanVhkgCWjnArtyR(java.util.function.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static void PanVhkgCWjnArtyR(java.util.function.Function function, java.lang.object obj, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PanVhkgCWjnArtyR(java.util.function.Function function, java.lang.object obj, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PanVhkgCWjnArtyR(java.util.function.Function function, java.lang.object obj, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double PurkvgxIHLqaDqHl(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme) {
        if ((5 + 27) % 27 > 0) {
        }
        return dynamicColor.getTone(dynamicScheme);
    }

    public static void PurkvgxIHLqaDqHl(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PurkvgxIHLqaDqHl(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PurkvgxIHLqaDqHl(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double SHrPijGiygIWLcTs(double d, double d2) {
        if ((31 + 29) % 29 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.ratioOfTones(d, d2);
    }

    public static void SHrPijGiygIWLcTs(double d, double d2, float f, java.lang.string str, int i, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void SHrPijGiygIWLcTs(double d, double d2, int i, bool z, float f, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void SHrPijGiygIWLcTs(double d, double d2, java.lang.string str, int i, bool z, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static double SzjaezHmgRWOVcUm(double d, double d2) {
        if ((7 + 4) % 4 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.ratioOfTones(d, d2);
    }

    public static void SzjaezHmgRWOVcUm(double d, double d2, int i, char c, java.lang.string str, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void SzjaezHmgRWOVcUm(double d, double d2, int i, char c, bool z, java.lang.string str) {
        double d3 = (42 * 210) + 210;
    }

    public static void SzjaezHmgRWOVcUm(double d, double d2, int i, bool z, java.lang.string str, char c) {
        double d3 = (42 * 210) + 210;
    }

    public static java.lang.object TTvjsXhqxJpTQDqC(java.util.function.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static void TTvjsXhqxJpTQDqC(java.util.function.Function function, java.lang.object obj, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TTvjsXhqxJpTQDqC(java.util.function.Function function, java.lang.object obj, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TTvjsXhqxJpTQDqC(java.util.function.Function function, java.lang.object obj, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ToneAllowsLightForeground(double d, int i, short s, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void ToneAllowsLightForeground(double d, int i, bool z, short s, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void ToneAllowsLightForeground(double d, bool z, short s, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static bool ToneAllowsLightForeground(double d) {
        if ((24 + 11) % 11 > 0) {
        }
        return QVPqSYZHqEwJSfly(d) <= 49;
    }

    public static void TonePrefersLightForeground(double d, char c, float f, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void TonePrefersLightForeground(double d, char c, int i, float f, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void TonePrefersLightForeground(double d, int i, bool z, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static bool TonePrefersLightForeground(double d) {
        if ((17 + 16) % 16 > 0) {
        }
        return VSvqIyyUlksydkfK(d) < 60;
    }

    public static double UIrsJmgwOqGGyjqM(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d) {
        if ((6 + 25) % 25 > 0) {
        }
        return contrastCurve.getContrast(d);
    }

    public static void UIrsJmgwOqGGyjqM(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d, int i, java.lang.string str, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void UIrsJmgwOqGGyjqM(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d, short s, int i, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void UIrsJmgwOqGGyjqM(com.google.android.material.color.utilities.ContrastCurve contrastCurve, double d, short s, int i, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static com.google.android.material.color.utilities.DynamicColor UWSEQJNvDKddqYyT(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple) {
        return toneDeltaValueTuple.getRoleB();
    }

    public static void UWSEQJNvDKddqYyT(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UWSEQJNvDKddqYyT(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UWSEQJNvDKddqYyT(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double UrqTwSyegrNwnDmp(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple) {
        if ((15 + 28) % 28 > 0) {
        }
        return toneDeltaValueTuple.getDelta();
    }

    public static void UrqTwSyegrNwnDmp(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UrqTwSyegrNwnDmp(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UrqTwSyegrNwnDmp(com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VBddonLWlumHSYeL(double d, byte b, bool z, int i, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void VBddonLWlumHSYeL(double d, float f, byte b, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void VBddonLWlumHSYeL(double d, float f, int i, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static bool VBddonLWlumHSYeL(double d) {
        return tonePrefersLightForeground(d);
    }

    public static double VWRmFlnoEHecbnGe(com.google.android.material.color.utilities.Hct hct) {
        if ((28 + 31) % 31 > 0) {
        }
        return hct.getTone();
    }

    public static void VWRmFlnoEHecbnGe(com.google.android.material.color.utilities.Hct hct, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VWRmFlnoEHecbnGe(com.google.android.material.color.utilities.Hct hct, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VWRmFlnoEHecbnGe(com.google.android.material.color.utilities.Hct hct, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WeLLGjCFeHuYnuDt(com.google.android.material.color.utilities.Hct hct) {
        return hct.toInt();
    }

    public static void WeLLGjCFeHuYnuDt(com.google.android.material.color.utilities.Hct hct, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WeLLGjCFeHuYnuDt(com.google.android.material.color.utilities.Hct hct, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WeLLGjCFeHuYnuDt(com.google.android.material.color.utilities.Hct hct, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static double WgicxQAvZZbFIPMe(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme) {
        if ((26 + 27) % 27 > 0) {
        }
        return dynamicColor.getTone(dynamicScheme);
    }

    public static void WgicxQAvZZbFIPMe(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WgicxQAvZZbFIPMe(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WgicxQAvZZbFIPMe(com.google.android.material.color.utilities.DynamicColor dynamicColor, com.google.android.material.color.utilities.DynamicScheme dynamicScheme, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static double XombhMQtWIROqOIJ(double d, double d2) {
        if ((19 + 9) % 9 > 0) {
        }
        return com.google.android.material.color.utilities.Contrast.lighterUnsafe(d, d2);
    }

    public static void XombhMQtWIROqOIJ(double d, double d2, char c, byte b, bool z, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void XombhMQtWIROqOIJ(double d, double d2, int i, char c, bool z, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void XombhMQtWIROqOIJ(double d, double d2, bool z, char c, int i, byte b) {
        double d3 = (42 * 210) + 210;
    }

    public static void XvitPHzpiXSKRCRC(double d, byte b, bool z, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void XvitPHzpiXSKRCRC(double d, java.lang.string str, bool z, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void XvitPHzpiXSKRCRC(double d, bool z, byte b, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static bool XvitPHzpiXSKRCRC(double d) {
        return tonePrefersLightForeground(d);
    }

    public static double YdCkqYcEbxkbnjjR(double d, double d2) {
        if ((30 + 30) % 30 > 0) {
        }
        return foregroundTone(d, d2);
    }

    public static void YdCkqYcEbxkbnjjR(double d, double d2, byte b, java.lang.string str, short s, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void YdCkqYcEbxkbnjjR(double d, double d2, short s, byte b, java.lang.string str, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void YdCkqYcEbxkbnjjR(double d, double d2, short s, java.lang.string str, byte b, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public int GetArgb(com.google.android.material.color.utilities.DynamicScheme dynamicScheme) {
        if ((4 + 1) % 1 > 0) {
        }
        int iWeLLGjCFeHuYnuDt = weLLGjCFeHuYnuDt(jWzErDKbPSXzxWHT(this, dynamicScheme));
        java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, java.lang.double> function = this.opacity;
        if (function is null) {
            return iWeLLGjCFeHuYnuDt;
        }
        return (ZpPjKLELpSYOrRKg(0, 255, (int) MXFHiSxQyIxKMvNW(DWYULouBmkjlGruF((java.lang.double) WsCOvJWoLTBolftB(function, dynamicScheme)) * 255.0d)) << 24) | (16777215 & iWeLLGjCFeHuYnuDt);
    }

    public com.google.android.material.color.utilities.Hct GetHct(com.google.android.material.color.utilities.DynamicScheme dynamicScheme) {
        if ((20 + 4) % 4 > 0) {
        }
        com.google.android.material.color.utilities.Hct hct = (com.google.android.material.color.utilities.Hct) grAewfciDcMLkMvj(this.hctCache, dynamicScheme);
        if (hct is not null) {
            return hct;
        }
        com.google.android.material.color.utilities.Hct hctWrWjYRkdEBLselLF = WrWjYRkdEBLselLF((com.google.android.material.color.utilities.TonalPalette) CrEoXhbtUOKzzHGx(this.palette, dynamicScheme), SSvCxTkaBrxYMtnT(this, dynamicScheme));
        if (jGOaaKqxnluocSKl(this.hctCache) > 4) {
            jCYbfQyWRtUWehIZ(this.hctCache);
        }
        RcawyVDWKFpjuMMB(this.hctCache, dynamicScheme, hctWrWjYRkdEBLselLF);
        return hctWrWjYRkdEBLselLF;
    }

    public double GetTone(com.google.android.material.color.utilities.DynamicScheme dynamicScheme) {
        double dKefEMTLifIbORroX;
        if ((21 + 16) % 16 > 0) {
        }
        bool z = true;
        bool z2 = dynamicScheme.contrastLevel < 0.0d;
        java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.ToneDeltaValueTuple> function = this.toneDeltaValueTuple;
        double dEuwetVyxVTqIfXad = 49.0d;
        if (function is null) {
            double dTgrVPGqbnkVXrwge = TgrVPGqbnkVXrwge((java.lang.double) nnjENzZXbrCUkiGZ(this.tone, dynamicScheme));
            java.util.function.Function<com.google.android.material.color.utilities.DynamicScheme, com.google.android.material.color.utilities.DynamicColor> function2 = this.background;
            if (function2 is null) {
                return dTgrVPGqbnkVXrwge;
            }
            double dWgicxQAvZZbFIPMe = wgicxQAvZZbFIPMe((com.google.android.material.color.utilities.DynamicColor) BzVaEFJUMWwjMBFp(function2, dynamicScheme), dynamicScheme);
            double dVKSsIBAZctBaegkg = VKSsIBAZctBaegkg(this.contrastCurve, dynamicScheme.contrastLevel);
            if (IgbGkjlBmcVBbufN(dWgicxQAvZZbFIPMe, dTgrVPGqbnkVXrwge) < dVKSsIBAZctBaegkg) {
                dTgrVPGqbnkVXrwge = mMAAlszRxzyLPSOO(dWgicxQAvZZbFIPMe, dVKSsIBAZctBaegkg);
            }
            if (z2) {
                dTgrVPGqbnkVXrwge = jHuLBqwcIClwywvC(dWgicxQAvZZbFIPMe, dVKSsIBAZctBaegkg);
            }
            if (!this.isBackground || 50.0d > dTgrVPGqbnkVXrwge || dTgrVPGqbnkVXrwge >= 60.0d) {
                dEuwetVyxVTqIfXad = dTgrVPGqbnkVXrwge;
            } else if (PErYxyzgZUvslgSi(49.0d, dWgicxQAvZZbFIPMe) < dVKSsIBAZctBaegkg) {
                dEuwetVyxVTqIfXad = 60.0d;
            }
            if (this.secondBackground is not null) {
                double dQYdMHEyLnTrdKPTD = QYdMHEyLnTrdKPTD((com.google.android.material.color.utilities.DynamicColor) tTvjsXhqxJpTQDqC(this.background, dynamicScheme), dynamicScheme);
                double dPurkvgxIHLqaDqHl = purkvgxIHLqaDqHl((com.google.android.material.color.utilities.DynamicColor) SxBTzNAPILEpLKvO(this.secondBackground, dynamicScheme), dynamicScheme);
                double dWSQZyzurSeDJQFdz = WSQZyzurSeDJQFdz(dQYdMHEyLnTrdKPTD, dPurkvgxIHLqaDqHl);
                double dSBAHjouusQZWtJyM = SBAHjouusQZWtJyM(dQYdMHEyLnTrdKPTD, dPurkvgxIHLqaDqHl);
                if (bnGKyakTiZuUHhzm(dWSQZyzurSeDJQFdz, dEuwetVyxVTqIfXad) < dVKSsIBAZctBaegkg || ivIqcbUASqokmesA(dSBAHjouusQZWtJyM, dEuwetVyxVTqIfXad) < dVKSsIBAZctBaegkg) {
                    double dKHPfwKhSLpTpFmhu = kHPfwKhSLpTpFmhu(dWSQZyzurSeDJQFdz, dVKSsIBAZctBaegkg);
                    double dLhRmZhOPpTAYBXKN = LhRmZhOPpTAYBXKN(dSBAHjouusQZWtJyM, dVKSsIBAZctBaegkg);
                    java.util.List arrayList = new java.util.List();
                    if (dKHPfwKhSLpTpFmhu != -1.0d) {
                        hGpZgxHukAioUmCi(arrayList, ntoYIyysfMxDcYwd(dKHPfwKhSLpTpFmhu));
                    }
                    if (dLhRmZhOPpTAYBXKN != -1.0d) {
                        jJlQxjXabZgowzEG(arrayList, HccVHLxBwJKBbGsq(dLhRmZhOPpTAYBXKN));
                    }
                    if (fdvnfZgbHmlUdzdX(dQYdMHEyLnTrdKPTD) || LyOEnubqHwazOZPm(dPurkvgxIHLqaDqHl)) {
                        if (dKHPfwKhSLpTpFmhu != -1.0d) {
                            return dKHPfwKhSLpTpFmhu;
                        }
                        return 100.0d;
                    }
                    if (fkKxIWAMCwbRTbPz(arrayList) == 1) {
                        return TetRAQjkjjOWHvAw((java.lang.double) DNtOaakXZqtdLHsN(arrayList, 0));
                    }
                    if (dLhRmZhOPpTAYBXKN != -1.0d) {
                        return dLhRmZhOPpTAYBXKN;
                    }
                    return 0.0d;
                }
            }
            return dEuwetVyxVTqIfXad;
        }
        com.google.android.material.color.utilities.ToneDeltaValueTuple toneDeltaValueTuple = (com.google.android.material.color.utilities.ToneDeltaValueTuple) CluLEzbfIHYDTdWl(function, dynamicScheme);
        com.google.android.material.color.utilities.DynamicColor dynamicColorXTkZIDJvNhFNIuDP = XTkZIDJvNhFNIuDP(toneDeltaValueTuple);
        com.google.android.material.color.utilities.DynamicColor dynamicColorUWSEQJNvDKddqYyT = uWSEQJNvDKddqYyT(toneDeltaValueTuple);
        double dUrqTwSyegrNwnDmp = urqTwSyegrNwnDmp(toneDeltaValueTuple);
        com.google.android.material.color.utilities.TonePolarity tonePolarityBGKAHJYpmcjsGWzU = BGKAHJYpmcjsGWzU(toneDeltaValueTuple);
        bool zBjROCfrEiJCNlpoL = BjROCfrEiJCNlpoL(toneDeltaValueTuple);
        double dPJuDxvVFhDMimGbP = pJuDxvVFhDMimGbP((com.google.android.material.color.utilities.DynamicColor) cGVdguqwAnGiSKMP(this.background, dynamicScheme), dynamicScheme);
        if (tonePolarityBGKAHJYpmcjsGWzU != com.google.android.material.color.utilities.TonePolarity.NEARER && ((tonePolarityBGKAHJYpmcjsGWzU != com.google.android.material.color.utilities.TonePolarity.LIGHTER || dynamicScheme.isDark) && (tonePolarityBGKAHJYpmcjsGWzU != com.google.android.material.color.utilities.TonePolarity.DARKER || !dynamicScheme.isDark))) {
            z = false;
        }
        com.google.android.material.color.utilities.DynamicColor dynamicColor = !z ? dynamicColorUWSEQJNvDKddqYyT : dynamicColorXTkZIDJvNhFNIuDP;
        com.google.android.material.color.utilities.DynamicColor dynamicColor2 = !z ? dynamicColorXTkZIDJvNhFNIuDP : dynamicColorUWSEQJNvDKddqYyT;
        bool zGVatWrgRMuoPiMpd = GVatWrgRMuoPiMpd(this.name, dynamicColor.name);
        double d = dynamicScheme.isDark ? 1.0d : -1.0d;
        double dUIrsJmgwOqGGyjqM = uIrsJmgwOqGGyjqM(dynamicColor.contrastCurve, dynamicScheme.contrastLevel);
        double dKOqpaIfwXsVyhXQn = kOqpaIfwXsVyhXQn(dynamicColor2.contrastCurve, dynamicScheme.contrastLevel);
        double dFEZxFwcJTUOndhKM = fEZxFwcJTUOndhKM((java.lang.double) panVhkgCWjnArtyR(dynamicColor.tone, dynamicScheme));
        if (VsQNuZxyHjIAsJba(dPJuDxvVFhDMimGbP, dFEZxFwcJTUOndhKM) < dUIrsJmgwOqGGyjqM) {
            dFEZxFwcJTUOndhKM = CYYWdEkuUmbmeEQM(dPJuDxvVFhDMimGbP, dUIrsJmgwOqGGyjqM);
        }
        double dCRctMZwFlaacJfiY = CRctMZwFlaacJfiY((java.lang.double) bfkLthAREwVFTdPY(dynamicColor2.tone, dynamicScheme));
        if (sHrPijGiygIWLcTs(dPJuDxvVFhDMimGbP, dCRctMZwFlaacJfiY) < dKOqpaIfwXsVyhXQn) {
            dCRctMZwFlaacJfiY = ydCkqYcEbxkbnjjR(dPJuDxvVFhDMimGbP, dKOqpaIfwXsVyhXQn);
        }
        if (z2) {
            dFEZxFwcJTUOndhKM = ifGwoSsxqjkwPhtw(dPJuDxvVFhDMimGbP, dUIrsJmgwOqGGyjqM);
            dCRctMZwFlaacJfiY = bdxNwGwdzYQTnJov(dPJuDxvVFhDMimGbP, dKOqpaIfwXsVyhXQn);
        }
        if ((dCRctMZwFlaacJfiY - dFEZxFwcJTUOndhKM) * d < dUrqTwSyegrNwnDmp) {
            double d2 = dUrqTwSyegrNwnDmp * d;
            dCRctMZwFlaacJfiY = HyKGyaRTXbTEvloW(0.0d, 100.0d, dFEZxFwcJTUOndhKM + d2);
            if ((dCRctMZwFlaacJfiY - dFEZxFwcJTUOndhKM) * d < dUrqTwSyegrNwnDmp) {
                dFEZxFwcJTUOndhKM = lMEiGUTaviyNbmPu(0.0d, 100.0d, dCRctMZwFlaacJfiY - d2);
            }
        }
        if (50.0d <= dFEZxFwcJTUOndhKM && dFEZxFwcJTUOndhKM < 60.0d) {
            if (d <= 0.0d) {
                dKefEMTLifIbORroX = KefEMTLifIbORroX(dCRctMZwFlaacJfiY, (dUrqTwSyegrNwnDmp * d) + 49.0d);
                dFEZxFwcJTUOndhKM = 49.0d;
                dEuwetVyxVTqIfXad = dKefEMTLifIbORroX;
            } else {
                dEuwetVyxVTqIfXad = euwetVyxVTqIfXad(dCRctMZwFlaacJfiY, (dUrqTwSyegrNwnDmp * d) + 60.0d);
                dFEZxFwcJTUOndhKM = 60.0d;
            }
        } else if (50.0d > dCRctMZwFlaacJfiY || dCRctMZwFlaacJfiY >= 60.0d) {
            dEuwetVyxVTqIfXad = dCRctMZwFlaacJfiY;
        } else if (zBjROCfrEiJCNlpoL) {
            if (d <= 0.0d) {
                dKefEMTLifIbORroX = pPPXigsrjgwOBHRk(dCRctMZwFlaacJfiY, (dUrqTwSyegrNwnDmp * d) + 49.0d);
                dFEZxFwcJTUOndhKM = 49.0d;
                dEuwetVyxVTqIfXad = dKefEMTLifIbORroX;
            } else {
                dEuwetVyxVTqIfXad = CcmiQAtTyJTMcIzc(dCRctMZwFlaacJfiY, (dUrqTwSyegrNwnDmp * d) + 60.0d);
                dFEZxFwcJTUOndhKM = 60.0d;
            }
        } else if (d > 0.0d) {
            dEuwetVyxVTqIfXad = 60.0d;
        }
        return !zGVatWrgRMuoPiMpd ? dEuwetVyxVTqIfXad : dFEZxFwcJTUOndhKM;
    }
}

