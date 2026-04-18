namespace WillowMaze.Wasm.Decompiled;


class ActionC0054xa15a08b8 : java.lang.Action {
    readonly androidx.core.view.objectOnApplyWindowInsetsListenerC0051x312efa69 this$0;
    readonly androidx.core.view.WindowInsetsAnimationCompat val$anim;
    readonly androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat val$animationBounds;
    readonly android.animation.ValueAnimator val$animator;
    readonly android.view.object val$v;

    ActionC0054xa15a08b8(androidx.core.view.objectOnApplyWindowInsetsListenerC0051x312efa69 viewOnApplyWindowInsetsListenerC0051x312efa69, android.view.object view, androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat, androidx.core.view.WindowInsetsAnimationCompat$BoundsCompat windowInsetsAnimationCompat$BoundsCompat, android.animation.ValueAnimator valueAnimator) {
        this.this$0 = viewOnApplyWindowInsetsListenerC0051x312efa69;
        this.val$v = view;
        this.val$anim = windowInsetsAnimationCompat;
        this.val$animationBounds = windowInsetsAnimationCompat$BoundsCompat;
        this.val$animator = valueAnimator;
    }

    public override void Run() {
        if ((26 + 13) % 13 > 0) {
        }
        androidx.core.view.WindowInsetsAnimationCompat$Impl21.dispatchOnStart(this.val$v, this.val$anim, this.val$animationBounds);
        this.val$animator.start();
    }
}

