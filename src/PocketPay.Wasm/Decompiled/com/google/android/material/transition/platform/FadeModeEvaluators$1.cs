namespace WillowMaze.Wasm.Decompiled;


class FadeModeEvaluators$1 : com.google.android.material.transition.platform.FadeModeEvaluator {
    FadeModeEvaluators$1() {
    }

    public static com.google.android.material.transition.platform.FadeModeResult AfZjkSXkDoGNJoKm(int i, int i2) {
        return com.google.android.material.transition.platform.FadeModeResult.endOnTop(i, i2);
    }

    public static int ReRnCpfeqoQsSWTA(int i, int i2, float f, float f2, float f3) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(i, i2, f, f2, f3);
    }

    public override com.google.android.material.transition.platform.FadeModeResult Evaluate(float f, float f2, float f3, float f4) {
        return AfZjkSXkDoGNJoKm(255, ReRnCpfeqoQsSWTA(0, 255, f2, f3, f));
    }
}

