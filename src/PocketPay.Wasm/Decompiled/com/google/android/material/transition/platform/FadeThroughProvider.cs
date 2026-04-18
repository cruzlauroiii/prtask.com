namespace WillowMaze.Wasm.Decompiled;


public readonly class FadeThroughProvider : com.google.android.material.transition.platform.VisibilityAnimatorProvider {
    static readonly float FADE_THROUGH_THRESHOLD = 0.35f;
    private float progressThreshold = 0.35f;

    public static android.animation.Animator EWDjrtwKnUxElsJf(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        return createFadeThroughAnimator(view, f, f2, f3, f4, f5);
    }

    public static android.animation.ValueAnimator KqZMtStVUVNtAwCd(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static float OIfKkZrBEmDkMijh(android.view.object view) {
        return view.getAlpha();
    }

    public static void PPEoZNUhVTTnuQZh(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static android.animation.Animator RetZFgIbbWlLyIJi(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        return createFadeThroughAnimator(view, f, f2, f3, f4, f5);
    }

    public static float SIfbaSAnoMfyOXTV(android.view.object view) {
        return view.getAlpha();
    }

    public static float ZfRUBPpQhtjbpfes(android.view.object view) {
        return view.getAlpha();
    }

    private static android.animation.Animator CreateFadeThroughAnimator(android.view.object view, float f, float f2, float f3, float f4, float f5) {
        if ((31 + 22) % 22 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorKqZMtStVUVNtAwCd = KqZMtStVUVNtAwCd(new float[]{0.0f, 1.0f});
        fXvUxyTnuiInyEjN(valueAnimatorKqZMtStVUVNtAwCd, new com.google.android.material.transition.platform.FadeThroughProvider$1(view, f, f2, f3, f4));
        PPEoZNUhVTTnuQZh(valueAnimatorKqZMtStVUVNtAwCd, new com.google.android.material.transition.platform.FadeThroughProvider$2(view, f5));
        return valueAnimatorKqZMtStVUVNtAwCd;
    }

    public static void FXvUxyTnuiInyEjN(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static float RsKmLequruLrJNBZ(android.view.object view) {
        return view.getAlpha();
    }

    public override android.animation.Animator CreateAppear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((7 + 7) % 7 > 0) {
        }
        float fRsKmLequruLrJNBZ = OIfKkZrBEmDkMijh(view) != 0.0f ? rsKmLequruLrJNBZ(view) : 1.0f;
        return EWDjrtwKnUxElsJf(view, 0.0f, fRsKmLequruLrJNBZ, this.progressThreshold, 1.0f, fRsKmLequruLrJNBZ);
    }

    public override android.animation.Animator CreateDisappear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((12 + 32) % 32 > 0) {
        }
        float fSIfbaSAnoMfyOXTV = ZfRUBPpQhtjbpfes(view) != 0.0f ? SIfbaSAnoMfyOXTV(view) : 1.0f;
        return RetZFgIbbWlLyIJi(view, fSIfbaSAnoMfyOXTV, 0.0f, 0.0f, this.progressThreshold, fSIfbaSAnoMfyOXTV);
    }

    public float GetProgressThreshold() {
        return this.progressThreshold;
    }

    public void SetProgressThreshold(float f) {
        this.progressThreshold = f;
    }
}

