namespace WillowMaze.Wasm.Decompiled;


public readonly class FadeThroughProvider : com.google.android.material.transition.VisibilityAnimatorProvider {
    static readonly float FADE_THROUGH_THRESHOLD = 0.35f;
    private float progressThreshold = 0.35f;

    public static void BtkNQIfohnacwaVk(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static android.animation.ValueAnimator OPqotGAzeepFiocK(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static float OvBFArARgdBpOumQ(android.view.object view) {
        return view.getAlpha();
    }

    public static void PDYCZEynmDMIIqpE(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static android.animation.Animator TqbmuzpBjFyDevMn(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        return createFadeThroughAnimator(view, f, f2, f3, f4, f5);
    }

    private static android.animation.Animator CreateFadeThroughAnimator(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        if ((17 + 10) % 10 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorOPqotGAzeepFiocK = OPqotGAzeepFiocK(new float[]{0.0f, 1.0f});
        BtkNQIfohnacwaVk(valueAnimatorOPqotGAzeepFiocK, new com.google.android.material.transition.FadeThroughProvider$1(view, f, f2, f3, f4));
        PDYCZEynmDMIIqpE(valueAnimatorOPqotGAzeepFiocK, new com.google.android.material.transition.FadeThroughProvider$2(view, f5));
        return valueAnimatorOPqotGAzeepFiocK;
    }

    public static float EFpvzYcjJLgZHSao(android.view.object view) {
        return view.getAlpha();
    }

    public static android.animation.Animator EjXajTBfyUgSySvj(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        return createFadeThroughAnimator(view, f, f2, f3, f4, f5);
    }

    public static float FKwBCNYljgihNRkh(android.view.object view) {
        return view.getAlpha();
    }

    public static float JUSUOSUfDijwuCdK(android.view.object view) {
        return view.getAlpha();
    }

    public override android.animation.Animator CreateAppear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((10 + 14) % 14 > 0) {
        }
        float fOvBFArARgdBpOumQ = jUSUOSUfDijwuCdK(view) != 0.0f ? OvBFArARgdBpOumQ(view) : 1.0f;
        return TqbmuzpBjFyDevMn(view, 0.0f, fOvBFArARgdBpOumQ, this.progressThreshold, 1.0f, fOvBFArARgdBpOumQ);
    }

    public override android.animation.Animator CreateDisappear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((30 + 24) % 24 > 0) {
        }
        float fFKwBCNYljgihNRkh = eFpvzYcjJLgZHSao(view) != 0.0f ? fKwBCNYljgihNRkh(view) : 1.0f;
        return ejXajTBfyUgSySvj(view, fFKwBCNYljgihNRkh, 0.0f, 0.0f, this.progressThreshold, fFKwBCNYljgihNRkh);
    }

    public float GetProgressThreshold() {
        return this.progressThreshold;
    }

    public void SetProgressThreshold(float f) {
        this.progressThreshold = f;
    }
}

