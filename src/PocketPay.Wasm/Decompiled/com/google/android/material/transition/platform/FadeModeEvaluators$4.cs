namespace WillowMaze.Wasm.Decompiled;


class FadeModeEvaluators$4 : com.google.android.material.transition.platform.FadeModeEvaluator {
    FadeModeEvaluators$4() {
    }

    public static int IcAFuBqwlGeyeQWo(int i, int i2, float f, float f2, float f3) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(i, i2, f, f2, f3);
    }

    public static com.google.android.material.transition.platform.FadeModeResult RGynEXswVXHFNQMp(int i, int i2) {
        return com.google.android.material.transition.platform.FadeModeResult.startOnTop(i, i2);
    }

    public static int VMmNOVLFDIrMeypR(int i, int i2, float f, float f2, float f3) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(i, i2, f, f2, f3);
    }

    public override com.google.android.material.transition.platform.FadeModeResult Evaluate(float f, float f2, float f3, float f4) {
        float f5 = ((f3 - f2) * f4) + f2;
        return RGynEXswVXHFNQMp(IcAFuBqwlGeyeQWo(255, 0, f2, f5, f), VMmNOVLFDIrMeypR(0, 255, f5, f3, f));
    }
}

