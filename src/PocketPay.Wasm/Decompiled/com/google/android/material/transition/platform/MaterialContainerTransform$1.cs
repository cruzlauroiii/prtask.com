namespace WillowMaze.Wasm.Decompiled;


class MaterialContainerTransform$1 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly com.google.android.material.transition.platform.MaterialContainerTransform this$0;
    readonly com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable val$transitionDrawable;

    MaterialContainerTransform$1(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        this.this$0 = materialContainerTransform;
        this.val$transitionDrawable = materialContainerTransform$TransitionDrawable;
    }

    public static float JKBjAeUpIxHhWCeV(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedFraction();
    }

    public static void YUIJGqfTIzUvfpxN(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, float f) {
        com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable.access$200(materialContainerTransform$TransitionDrawable, f);
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        yUIJGqfTIzUvfpxN(this.val$transitionDrawable, JKBjAeUpIxHhWCeV(valueAnimator));
    }
}

