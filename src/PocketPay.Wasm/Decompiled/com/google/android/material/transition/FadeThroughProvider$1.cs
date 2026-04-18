namespace WillowMaze.Wasm.Decompiled;


class FadeThroughProvider$1 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly float val$endFraction;
    readonly float val$endValue;
    readonly float val$startFraction;
    readonly float val$startValue;
    readonly android.view.object val$view;

    FadeThroughProvider$1(android.view.object view, float f, float f2, float f3, float f4) {
        this.val$view = view;
        this.val$startValue = f;
        this.val$endValue = f2;
        this.val$startFraction = f3;
        this.val$endFraction = f4;
    }

    public static float AQhyrIdZJUqqjhry(java.lang.float f) {
        return f.floatValue();
    }

    public static float ThGAGNrRcCtnmjDC(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.transition.TransitionUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void GkNasvEMGnvqZjwW(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static java.lang.object XBnPVBrqcLtlkfTF(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((16 + 30) % 30 > 0) {
        }
        gkNasvEMGnvqZjwW(this.val$view, ThGAGNrRcCtnmjDC(this.val$startValue, this.val$endValue, this.val$startFraction, this.val$endFraction, AQhyrIdZJUqqjhry((java.lang.float) xBnPVBrqcLtlkfTF(valueAnimator))));
    }
}

