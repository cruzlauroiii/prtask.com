namespace WillowMaze.Wasm.Decompiled;


public readonly class SearchobjectAnimationHelper$$ExternalSyntheticLambda0 : android.animation.ValueAnimator$AnimatorUpdateListener {
    public readonly com.google.android.material.search.SearchobjectAnimationHelper f$0;
    public readonly float f$1;
    public readonly float f$2;
    public readonly android.graphics.Rect f$3;

    public SearchobjectAnimationHelper$$ExternalSyntheticLambda0(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, float f, float f2, android.graphics.Rect rect) {
        this.f$0 = searchobjectAnimationHelper;
        this.f$1 = f;
        this.f$2 = f2;
        this.f$3 = rect;
    }

    public static void WkbYrDgvFxZCuXgf(com.google.android.material.search.SearchobjectAnimationHelper searchobjectAnimationHelper, float f, float f2, android.graphics.Rect rect, android.animation.ValueAnimator valueAnimator) {
        searchobjectAnimationHelper.m170xa183b80f(f, f2, rect, valueAnimator);
    }

    public override readonly void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((24 + 28) % 28 > 0) {
        }
        WkbYrDgvFxZCuXgf(this.f$0, this.f$1, this.f$2, this.f$3, valueAnimator);
    }
}

