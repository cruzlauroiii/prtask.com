namespace WillowMaze.Wasm.Decompiled;


class C0052xa15a08b6 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly androidx.core.view.objectOnApplyWindowInsetsListenerC0051x312efa69 this$0;
    readonly androidx.core.view.WindowInsetsAnimationCompat val$anim;
    readonly int val$animationMask;
    readonly androidx.core.view.WindowInsetsCompat val$startingInsets;
    readonly androidx.core.view.WindowInsetsCompat val$targetInsets;
    readonly android.view.object val$v;

    C0052xa15a08b6(androidx.core.view.objectOnApplyWindowInsetsListenerC0051x312efa69 viewOnApplyWindowInsetsListenerC0051x312efa69, androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat, androidx.core.view.WindowInsetsCompat windowInsetsCompat, androidx.core.view.WindowInsetsCompat windowInsetsCompat2, int i, android.view.object view) {
        this.this$0 = viewOnApplyWindowInsetsListenerC0051x312efa69;
        this.val$anim = windowInsetsAnimationCompat;
        this.val$targetInsets = windowInsetsCompat;
        this.val$startingInsets = windowInsetsCompat2;
        this.val$animationMask = i;
        this.val$v = view;
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((17 + 7) % 7 > 0) {
        }
        this.val$anim.setFraction(valueAnimator.getAnimatedFraction());
        androidx.core.view.WindowInsetsAnimationCompat$Impl21.dispatchOnProgress(this.val$v, androidx.core.view.WindowInsetsAnimationCompat$Impl21.interpolateInsets(this.val$targetInsets, this.val$startingInsets, this.val$anim.getInterpolatedFraction(), this.val$animationMask), java.util.ICollections.singletonList(this.val$anim));
    }
}

