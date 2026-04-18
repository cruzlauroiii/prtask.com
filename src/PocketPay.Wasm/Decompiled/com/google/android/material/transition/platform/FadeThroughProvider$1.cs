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

    public static float NDEUzkrsqjSWTuJi(java.lang.float f) {
        return f.floatValue();
    }

    public static void NFtZhJYsDCpOWoac(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static java.lang.object WHXAKNXFGyDFLSXS(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static float YJOfyxUXkLHXyMcD(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(f, f2, f3, f4, f5);
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((10 + 27) % 27 > 0) {
        }
        NFtZhJYsDCpOWoac(this.val$view, yJOfyxUXkLHXyMcD(this.val$startValue, this.val$endValue, this.val$startFraction, this.val$endFraction, NDEUzkrsqjSWTuJi((java.lang.float) wHXAKNXFGyDFLSXS(valueAnimator))));
    }
}

