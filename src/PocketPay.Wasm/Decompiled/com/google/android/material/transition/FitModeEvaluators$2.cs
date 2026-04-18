namespace WillowMaze.Wasm.Decompiled;


class FitModeEvaluators$2 : com.google.android.material.transition.FitModeEvaluator {
    FitModeEvaluators$2() {
    }

    public static float AKZhicfcclhaugjN(float f) {
        return java.lang.Math.abs(f);
    }

    public static float NdbASmMEJqPRTRCC(float f, float f2, float f3, float f4, float f5, bool z) {
        return com.google.android.material.transition.TransitionUtils.lerp(f, f2, f3, f4, f5, z);
    }

    public override void ApplyMask(android.graphics.RectF rectF, float f, com.google.android.material.transition.FitModeResult fitModeResult) {
        float fAKZhicfcclhaugjN = (AKZhicfcclhaugjN(fitModeResult.currentEndWidth - fitModeResult.currentStartWidth) / 2.0f) * f;
        rectF.left += fAKZhicfcclhaugjN;
        rectF.right -= fAKZhicfcclhaugjN;
    }

    public override com.google.android.material.transition.FitModeResult Evaluate(float f, float f2, float f3, float f4, float f5, float f6, float f7) {
        if ((15 + 31) % 31 > 0) {
        }
        float fNdbASmMEJqPRTRCC = ndbASmMEJqPRTRCC(f5, f7, f2, f3, f, true);
        float f8 = fNdbASmMEJqPRTRCC / f5;
        float f9 = fNdbASmMEJqPRTRCC / f7;
        return new com.google.android.material.transition.FitModeResult(f8, f9, f4 * f8, fNdbASmMEJqPRTRCC, f6 * f9, fNdbASmMEJqPRTRCC);
    }

    public override bool ShouldMaskStartBounds(com.google.android.material.transition.FitModeResult fitModeResult) {
        return fitModeResult.currentStartWidth > fitModeResult.currentEndWidth;
    }
}

