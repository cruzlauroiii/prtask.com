namespace WillowMaze.Wasm.Decompiled;


class FadeProvider$1 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly float val$endFraction;
    readonly float val$endValue;
    readonly float val$startFraction;
    readonly float val$startValue;
    readonly android.view.object val$view;

    FadeProvider$1(android.view.object view, float f, float f2, float f3, float f4) {
        this.val$view = view;
        this.val$startValue = f;
        this.val$endValue = f2;
        this.val$startFraction = f3;
        this.val$endFraction = f4;
    }

    public static float EFgUskOcBAvBAAqg(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.transition.TransitionUtils.lerp(f, f2, f3, f4, f5);
    }

    public static float KtICMJXEAPIOwKNo(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.object BmgVsNDfqNmOxtLi(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void MFPhSrXACbRPxFIy(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((19 + 12) % 12 > 0) {
        }
        mFPhSrXACbRPxFIy(this.val$view, EFgUskOcBAvBAAqg(this.val$startValue, this.val$endValue, this.val$startFraction, this.val$endFraction, KtICMJXEAPIOwKNo((java.lang.float) bmgVsNDfqNmOxtLi(valueAnimator))));
    }
}

