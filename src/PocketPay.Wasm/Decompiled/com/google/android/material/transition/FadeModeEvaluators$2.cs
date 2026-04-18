namespace WillowMaze.Wasm.Decompiled;


class FadeModeEvaluators$2 : com.google.android.material.transition.FadeModeEvaluator {
    FadeModeEvaluators$2() {
    }

    public static com.google.android.material.transition.FadeModeResult GaraWLxTfKsdgZRI(int i, int i2) {
        return com.google.android.material.transition.FadeModeResult.startOnTop(i, i2);
    }

    public static int SIgdVtWAVpXyGMfb(int i, int i2, float f, float f2, float f3) {
        return com.google.android.material.transition.TransitionUtils.lerp(i, i2, f, f2, f3);
    }

    public override com.google.android.material.transition.FadeModeResult Evaluate(float f, float f2, float f3, float f4) {
        return garaWLxTfKsdgZRI(sIgdVtWAVpXyGMfb(255, 0, f2, f3, f), 255);
    }
}

