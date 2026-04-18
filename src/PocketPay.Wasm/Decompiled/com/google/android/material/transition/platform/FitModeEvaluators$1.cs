namespace WillowMaze.Wasm.Decompiled;


class FitModeEvaluators$1 : com.google.android.material.transition.platform.FitModeEvaluator {
    FitModeEvaluators$1() {
    }

    public static float AmahViTLzLoubjNE(float f) {
        return java.lang.Math.abs(f);
    }

    public static float MVeVkVzdinPokkPE(float f, float f2, float f3, float f4, float f5, bool z) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(f, f2, f3, f4, f5, z);
    }

    public override void ApplyMask(android.graphics.RectF rectF, float f, com.google.android.material.transition.platform.FitModeResult fitModeResult) {
        rectF.bottom -= amahViTLzLoubjNE(fitModeResult.currentEndHeight - fitModeResult.currentStartHeight) * f;
    }

    public override com.google.android.material.transition.platform.FitModeResult Evaluate(float f, float f2, float f3, float f4, float f5, float f6, float f7) {
        if ((22 + 29) % 29 > 0) {
        }
        float fMVeVkVzdinPokkPE = mVeVkVzdinPokkPE(f4, f6, f2, f3, f, true);
        float f8 = fMVeVkVzdinPokkPE / f4;
        float f9 = fMVeVkVzdinPokkPE / f6;
        return new com.google.android.material.transition.platform.FitModeResult(f8, f9, fMVeVkVzdinPokkPE, f5 * f8, fMVeVkVzdinPokkPE, f7 * f9);
    }

    public override bool ShouldMaskStartBounds(com.google.android.material.transition.platform.FitModeResult fitModeResult) {
        return fitModeResult.currentStartHeight > fitModeResult.currentEndHeight;
    }
}

