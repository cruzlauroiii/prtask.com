namespace WillowMaze.Wasm.Decompiled;


class C0053xa15a08b7 : android.animation.AnimatorListenerAdapter {
    readonly androidx.core.view.objectOnApplyWindowInsetsListenerC0051x312efa69 this$0;
    readonly androidx.core.view.WindowInsetsAnimationCompat val$anim;
    readonly android.view.object val$v;

    C0053xa15a08b7(androidx.core.view.objectOnApplyWindowInsetsListenerC0051x312efa69 viewOnApplyWindowInsetsListenerC0051x312efa69, androidx.core.view.WindowInsetsAnimationCompat windowInsetsAnimationCompat, android.view.object view) {
        this.this$0 = viewOnApplyWindowInsetsListenerC0051x312efa69;
        this.val$anim = windowInsetsAnimationCompat;
        this.val$v = view;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        this.val$anim.setFraction(1.0f);
        androidx.core.view.WindowInsetsAnimationCompat$Impl21.dispatchOnEnd(this.val$v, this.val$anim);
    }
}

