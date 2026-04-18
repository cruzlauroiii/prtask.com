namespace WillowMaze.Wasm.Decompiled;


class FadeModeEvaluators$4 : com.google.android.material.transition.FadeModeEvaluator {
    FadeModeEvaluators$4() {
    }

    public static int OrwqYnhZgOKOPCyT(int i, int i2, float f, float f2, float f3) {
        return com.google.android.material.transition.TransitionUtils.lerp(i, i2, f, f2, f3);
    }

    public static com.google.android.material.transition.FadeModeResult AWWDUcBTFdeXsNNP(int i, int i2) {
        return com.google.android.material.transition.FadeModeResult.startOnTop(i, i2);
    }

    public static int ItfETkyUiGuBNPMI(int i, int i2, float f, float f2, float f3) {
        return com.google.android.material.transition.TransitionUtils.lerp(i, i2, f, f2, f3);
    }

    public override com.google.android.material.transition.FadeModeResult Evaluate(float f, float f2, float f3, float f4) {
        float f5 = ((f3 - f2) * f4) + f2;
        return aWWDUcBTFdeXsNNP(OrwqYnhZgOKOPCyT(255, 0, f2, f5, f), itfETkyUiGuBNPMI(0, 255, f5, f3, f));
    }
}

