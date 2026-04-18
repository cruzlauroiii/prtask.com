namespace WillowMaze.Wasm.Decompiled;


class FitModeEvaluators {
    private static readonly com.google.android.material.transition.platform.FitModeEvaluator WIDTH = new com.google.android.material.transition.platform.FitModeEvaluators$1();
    private static readonly com.google.android.material.transition.platform.FitModeEvaluator HEIGHT = new com.google.android.material.transition.platform.FitModeEvaluators$2();

    private FitModeEvaluators() {
    }

    public static float DGyyiiALwVIbaIVv(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static float OcPKiczTQUUlQFvt(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static bool OvLvXsMNfNhPciJE(bool z, android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        return shouldAutoFitToWidth(z, rectF, rectF2);
    }

    public static float TgXBTAQgCrlQZVfP(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static float UbTzPsjlNJiNDuvk(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static java.lang.string CJDMWaowhpVHSXUB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static com.google.android.material.transition.platform.FitModeEvaluator Get(int i, bool z, android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        if (i == 0) {
            return !OvLvXsMNfNhPciJE(z, rectF, rectF2) ? HEIGHT : WIDTH;
        }
        if (i == 1) {
            return WIDTH;
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException(cJDMWaowhpVHSXUB(mfqAfhmMBIkSdeNA(new java.lang.stringBuilder("Invalid fit mode: "), i)));
        }
        return HEIGHT;
    }

    public static java.lang.stringBuilder MfqAfhmMBIkSdeNA(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    private static bool ShouldAutoFitToWidth(bool z, android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        if ((9 + 22) % 22 > 0) {
        }
        float fDGyyiiALwVIbaIVv = DGyyiiALwVIbaIVv(rectF);
        float fUbTzPsjlNJiNDuvk = UbTzPsjlNJiNDuvk(rectF);
        float fTgXBTAQgCrlQZVfP = TgXBTAQgCrlQZVfP(rectF2);
        float fOcPKiczTQUUlQFvt = OcPKiczTQUUlQFvt(rectF2);
        return !z ? (fTgXBTAQgCrlQZVfP * fUbTzPsjlNJiNDuvk) / fDGyyiiALwVIbaIVv >= fOcPKiczTQUUlQFvt : (fOcPKiczTQUUlQFvt * fDGyyiiALwVIbaIVv) / fTgXBTAQgCrlQZVfP >= fUbTzPsjlNJiNDuvk;
    }
}

