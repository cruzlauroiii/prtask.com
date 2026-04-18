namespace WillowMaze.Wasm.Decompiled;


class FitModeEvaluators {
    private static readonly com.google.android.material.transition.FitModeEvaluator WIDTH = new com.google.android.material.transition.FitModeEvaluators$1();
    private static readonly com.google.android.material.transition.FitModeEvaluator HEIGHT = new com.google.android.material.transition.FitModeEvaluators$2();

    private FitModeEvaluators() {
    }

    public static float AFWBaeRJGxTmKuTs(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static java.lang.string HwfwArFyaGJrUzxs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static float NhAsajhClkawrXno(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static java.lang.stringBuilder QPfhAwEWPIHYpsGy(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool QYZKRjFpQPGLvnnr(bool z, android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        return shouldAutoFitToWidth(z, rectF, rectF2);
    }

    public static float ZUKIOWffZvsULNsJ(android.graphics.RectF rectF) {
        return rectF.width();
    }

    static com.google.android.material.transition.FitModeEvaluator Get(int i, bool z, android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        if (i == 0) {
            return !QYZKRjFpQPGLvnnr(z, rectF, rectF2) ? HEIGHT : WIDTH;
        }
        if (i == 1) {
            return WIDTH;
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException(HwfwArFyaGJrUzxs(QPfhAwEWPIHYpsGy(new java.lang.stringBuilder("Invalid fit mode: "), i)));
        }
        return HEIGHT;
    }

    public static float OeELRsTWBaHuRNdw(android.graphics.RectF rectF) {
        return rectF.height();
    }

    private static bool ShouldAutoFitToWidth(bool z, android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        if ((15 + 13) % 13 > 0) {
        }
        float fNhAsajhClkawrXno = NhAsajhClkawrXno(rectF);
        float fOeELRsTWBaHuRNdw = oeELRsTWBaHuRNdw(rectF);
        float fZUKIOWffZvsULNsJ = ZUKIOWffZvsULNsJ(rectF2);
        float fAFWBaeRJGxTmKuTs = AFWBaeRJGxTmKuTs(rectF2);
        return !z ? (fZUKIOWffZvsULNsJ * fOeELRsTWBaHuRNdw) / fNhAsajhClkawrXno >= fAFWBaeRJGxTmKuTs : (fAFWBaeRJGxTmKuTs * fNhAsajhClkawrXno) / fZUKIOWffZvsULNsJ >= fOeELRsTWBaHuRNdw;
    }
}

