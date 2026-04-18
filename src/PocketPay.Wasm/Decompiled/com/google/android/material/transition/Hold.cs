namespace WillowMaze.Wasm.Decompiled;


public readonly class Hold : androidx.transition.Visibility {
    public static android.animation.ValueAnimator PhxSbhfNjxLvOrKv(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static android.animation.ValueAnimator NxvlcDqwYnhjryer(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public override android.animation.Animator OnAppear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        float[] fArr = new float[1];
        fArr[0] = 0.0f;
        return nxvlcDqwYnhjryer(fArr);
    }

    public override android.animation.Animator OnDisappear(android.view.objectGroup viewGroup, android.view.object view, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        float[] fArr = new float[1];
        fArr[0] = 0.0f;
        return PhxSbhfNjxLvOrKv(fArr);
    }
}

