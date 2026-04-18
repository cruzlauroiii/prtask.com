namespace WillowMaze.Wasm.Decompiled;


class ActionBarOverlayLayout$3 : java.lang.Action {
    readonly androidx.appcompat.widget.ActionBarOverlayLayout this$0;

    ActionBarOverlayLayout$3(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        this.this$0 = actionBarOverlayLayout;
    }

    public static android.view.objectPropertyAnimator BCkAKCBAFMxsxanQ(android.view.objectPropertyAnimator viewPropertyAnimator, float f) {
        return viewPropertyAnimator.translationY(f);
    }

    public static android.view.objectPropertyAnimator UCFomzRnpEeONvRf(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        return viewPropertyAnimator.setListener(animator$AnimatorListener);
    }

    public static void YjbCjTcLqGvTebMg(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.haltActionBarHideOffsetAnimations();
    }

    public static android.view.objectPropertyAnimator IvAUuUOaQPzcCBRJ(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.animate();
    }

    public static int QKPkhxYNSydgojpY(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getHeight();
    }

    public override void Run() {
        if ((26 + 7) % 7 > 0) {
        }
        YjbCjTcLqGvTebMg(this.this$0);
        androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout = this.this$0;
        actionBarOverlayLayout.mCurrentActionBarTopAnimator = UCFomzRnpEeONvRf(BCkAKCBAFMxsxanQ(ivAUuUOaQPzcCBRJ(actionBarOverlayLayout.mActionBarTop), -qKPkhxYNSydgojpY(this.this$0.mActionBarTop)), this.this$0.mTopAnimatorListener);
    }
}

