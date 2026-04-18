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

    public static float AMBcbtjhafoIlZSQ(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(f, f2, f3, f4, f5);
    }

    public static float AOaIhchSpUumsYMR(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.object SlIFgIKSiKDMaGXr(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void XigiuQMgiWjmHSGz(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((27 + 7) % 7 > 0) {
        }
        XigiuQMgiWjmHSGz(this.val$view, AMBcbtjhafoIlZSQ(this.val$startValue, this.val$endValue, this.val$startFraction, this.val$endFraction, AOaIhchSpUumsYMR((java.lang.float) SlIFgIKSiKDMaGXr(valueAnimator))));
    }
}

