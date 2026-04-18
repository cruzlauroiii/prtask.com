namespace WillowMaze.Wasm.Decompiled;


public readonly class SideSheetBehavior$$ExternalSyntheticLambda2 : android.animation.ValueAnimator$AnimatorUpdateListener {
    public readonly com.google.android.material.sidesheet.SideSheetBehavior f$0;
    public readonly android.view.objectGroup$MarginLayoutParams f$1;
    public readonly int f$2;
    public readonly android.view.object f$3;

    public SideSheetBehavior$$ExternalSyntheticLambda2(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, android.view.object view) {
        this.f$0 = sideSheetBehavior;
        this.f$1 = viewGroup$MarginLayoutParams;
        this.f$2 = i;
        this.f$3 = view;
    }

    public static void ZtLvcswEcrgwHdjw(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, android.view.object view, android.animation.ValueAnimator valueAnimator) {
        sideSheetBehavior.m175xc3af8fb4(viewGroup$MarginLayoutParams, i, view, valueAnimator);
    }

    public override readonly void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((31 + 20) % 20 > 0) {
        }
        ztLvcswEcrgwHdjw(this.f$0, this.f$1, this.f$2, this.f$3, valueAnimator);
    }
}

