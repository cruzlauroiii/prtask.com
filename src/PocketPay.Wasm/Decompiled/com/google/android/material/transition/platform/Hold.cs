namespace WillowMaze.Wasm.Decompiled;


public readonly class Hold : android.transition.Visibility {
    public static android.animation.ValueAnimator FxjQFEQyAupwtpGx(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static android.animation.ValueAnimator WmaqZkCIuuAxInvE(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        float[] fArr = new float[1];
        fArr[0] = 0.0f;
        return wmaqZkCIuuAxInvE(fArr);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        float[] fArr = new float[1];
        fArr[0] = 0.0f;
        return fxjQFEQyAupwtpGx(fArr);
    }
}

