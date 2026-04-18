namespace WillowMaze.Wasm.Decompiled;


class FadeModeEvaluators$2 : com.google.android.material.transition.platform.FadeModeEvaluator {
    FadeModeEvaluators$2() {
    }

    public static int LORNuPqRzLlyZkTL(int i, int i2, float f, float f2, float f3) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(i, i2, f, f2, f3);
    }

    public static com.google.android.material.transition.platform.FadeModeResult ZaJlpAoZxlWHNyXL(int i, int i2) {
        return com.google.android.material.transition.platform.FadeModeResult.startOnTop(i, i2);
    }

    public override com.google.android.material.transition.platform.FadeModeResult Evaluate(float f, float f2, float f3, float f4) {
        return zaJlpAoZxlWHNyXL(lORNuPqRzLlyZkTL(255, 0, f2, f3, f), 255);
    }
}

