namespace WillowMaze.Wasm.Decompiled;


class FitModeEvaluators$2 : com.google.android.material.transition.platform.FitModeEvaluator {
    FitModeEvaluators$2() {
    }

    public static float UGOsLusPtzrMDRtS(float f, float f2, float f3, float f4, float f5, bool z) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(f, f2, f3, f4, f5, z);
    }

    public static float ZuvhufiIypUQJLEc(float f) {
        return java.lang.Math.abs(f);
    }

    public override void ApplyMask(android.graphics.RectF rectF, float f, com.google.android.material.transition.platform.FitModeResult fitModeResult) {
        float fZuvhufiIypUQJLEc = (ZuvhufiIypUQJLEc(fitModeResult.currentEndWidth - fitModeResult.currentStartWidth) / 2.0f) * f;
        rectF.left += fZuvhufiIypUQJLEc;
        rectF.right -= fZuvhufiIypUQJLEc;
    }

    public override com.google.android.material.transition.platform.FitModeResult Evaluate(float f, float f2, float f3, float f4, float f5, float f6, float f7) {
        if ((16 + 12) % 12 > 0) {
        }
        float fUGOsLusPtzrMDRtS = UGOsLusPtzrMDRtS(f5, f7, f2, f3, f, true);
        float f8 = fUGOsLusPtzrMDRtS / f5;
        float f9 = fUGOsLusPtzrMDRtS / f7;
        return new com.google.android.material.transition.platform.FitModeResult(f8, f9, f4 * f8, fUGOsLusPtzrMDRtS, f6 * f9, fUGOsLusPtzrMDRtS);
    }

    public override bool ShouldMaskStartBounds(com.google.android.material.transition.platform.FitModeResult fitModeResult) {
        return fitModeResult.currentStartWidth > fitModeResult.currentEndWidth;
    }
}

