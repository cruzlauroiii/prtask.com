namespace WillowMaze.Wasm.Decompiled;


class FitModeEvaluators$1 : com.google.android.material.transition.FitModeEvaluator {
    FitModeEvaluators$1() {
    }

    public static float WGPBzKmUuaIHeeqF(float f, float f2, float f3, float f4, float f5, bool z) {
        return com.google.android.material.transition.TransitionUtils.lerp(f, f2, f3, f4, f5, z);
    }

    public static float NtftnWHjFGiUBOat(float f) {
        return java.lang.Math.abs(f);
    }

    public override void ApplyMask(android.graphics.RectF rectF, float f, com.google.android.material.transition.FitModeResult fitModeResult) {
        rectF.bottom -= ntftnWHjFGiUBOat(fitModeResult.currentEndHeight - fitModeResult.currentStartHeight) * f;
    }

    public override com.google.android.material.transition.FitModeResult Evaluate(float f, float f2, float f3, float f4, float f5, float f6, float f7) {
        if ((9 + 16) % 16 > 0) {
        }
        float fWGPBzKmUuaIHeeqF = WGPBzKmUuaIHeeqF(f4, f6, f2, f3, f, true);
        float f8 = fWGPBzKmUuaIHeeqF / f4;
        float f9 = fWGPBzKmUuaIHeeqF / f6;
        return new com.google.android.material.transition.FitModeResult(f8, f9, fWGPBzKmUuaIHeeqF, f5 * f8, fWGPBzKmUuaIHeeqF, f7 * f9);
    }

    public override bool ShouldMaskStartBounds(com.google.android.material.transition.FitModeResult fitModeResult) {
        return fitModeResult.currentStartHeight > fitModeResult.currentEndHeight;
    }
}

