namespace WillowMaze.Wasm.Decompiled;


class MaterialContainerTransform$1 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly com.google.android.material.transition.MaterialContainerTransform this$0;
    readonly com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable val$transitionDrawable;

    MaterialContainerTransform$1(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform, com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        this.this$0 = materialContainerTransform;
        this.val$transitionDrawable = materialContainerTransform$TransitionDrawable;
    }

    public static float YDJtkMDTrGVejSjO(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedFraction();
    }

    public static void BtCkdROGLkHdpSax(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, float f) {
        com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable.access$200(materialContainerTransform$TransitionDrawable, f);
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        btCkdROGLkHdpSax(this.val$transitionDrawable, YDJtkMDTrGVejSjO(valueAnimator));
    }
}

