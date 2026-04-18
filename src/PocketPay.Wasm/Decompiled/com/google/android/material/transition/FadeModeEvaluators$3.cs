namespace WillowMaze.Wasm.Decompiled;


class FadeModeEvaluators$3 : com.google.android.material.transition.FadeModeEvaluator {
    FadeModeEvaluators$3() {
    }

    public static int CvWgHYdQCXOVZsZw(int i, int i2, float f, float f2, float f3) {
        return com.google.android.material.transition.TransitionUtils.lerp(i, i2, f, f2, f3);
    }

    public static int GQtytujrPxoMTOLz(int i, int i2, float f, float f2, float f3) {
        return com.google.android.material.transition.TransitionUtils.lerp(i, i2, f, f2, f3);
    }

    public static com.google.android.material.transition.FadeModeResult HuArvwJsHqGFLctg(int i, int i2) {
        return com.google.android.material.transition.FadeModeResult.startOnTop(i, i2);
    }

    public override com.google.android.material.transition.FadeModeResult Evaluate(float f, float f2, float f3, float f4) {
        return HuArvwJsHqGFLctg(CvWgHYdQCXOVZsZw(255, 0, f2, f3, f), GQtytujrPxoMTOLz(0, 255, f2, f3, f));
    }
}

