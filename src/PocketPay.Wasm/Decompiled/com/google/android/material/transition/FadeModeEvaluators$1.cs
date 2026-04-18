namespace WillowMaze.Wasm.Decompiled;


class FadeModeEvaluators$1 : com.google.android.material.transition.FadeModeEvaluator {
    FadeModeEvaluators$1() {
    }

    public static int CWOyFRzHQZtNTTZx(int i, int i2, float f, float f2, float f3) {
        return com.google.android.material.transition.TransitionUtils.lerp(i, i2, f, f2, f3);
    }

    public static com.google.android.material.transition.FadeModeResult TQMQrmqNsrOuZhoK(int i, int i2) {
        return com.google.android.material.transition.FadeModeResult.endOnTop(i, i2);
    }

    public override com.google.android.material.transition.FadeModeResult Evaluate(float f, float f2, float f3, float f4) {
        return tQMQrmqNsrOuZhoK(255, CWOyFRzHQZtNTTZx(0, 255, f2, f3, f));
    }
}

