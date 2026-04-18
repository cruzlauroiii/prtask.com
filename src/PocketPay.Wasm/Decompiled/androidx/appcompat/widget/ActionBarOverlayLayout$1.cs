namespace WillowMaze.Wasm.Decompiled;


class ActionBarOverlayLayout$1 : android.animation.AnimatorListenerAdapter {
    readonly androidx.appcompat.widget.ActionBarOverlayLayout this$0;

    ActionBarOverlayLayout$1(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        this.this$0 = actionBarOverlayLayout;
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.this$0.mCurrentActionBarTopAnimator = null;
        this.this$0.mAnimatingForFling = false;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        this.this$0.mCurrentActionBarTopAnimator = null;
        this.this$0.mAnimatingForFling = false;
    }
}

