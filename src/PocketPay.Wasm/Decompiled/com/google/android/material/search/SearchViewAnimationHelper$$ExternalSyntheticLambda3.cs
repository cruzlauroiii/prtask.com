namespace WillowMaze.Wasm.Decompiled;


public readonly class SearchobjectAnimationHelper$$ExternalSyntheticLambda3 : android.animation.ValueAnimator$AnimatorUpdateListener {
    public readonly com.google.android.material.internal.FadeThroughDrawable f$0;

    public SearchobjectAnimationHelper$$ExternalSyntheticLambda3(com.google.android.material.internal.FadeThroughDrawable fadeThroughDrawable) {
        this.f$0 = fadeThroughDrawable;
    }

    public static void JOjIrDKnIrNXSjdB(com.google.android.material.internal.FadeThroughDrawable fadeThroughDrawable, android.animation.ValueAnimator valueAnimator) {
        com.google.android.material.search.SearchobjectAnimationHelper.lambda$addFadeThroughDrawableAnimatorIfNeeded$4(fadeThroughDrawable, valueAnimator);
    }

    public override readonly void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        jOjIrDKnIrNXSjdB(this.f$0, valueAnimator);
    }
}

