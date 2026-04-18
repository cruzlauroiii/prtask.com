namespace WillowMaze.Wasm.Decompiled;


class ActionBarOverlayLayout$2 : java.lang.Action {
    readonly androidx.appcompat.widget.ActionBarOverlayLayout this$0;

    ActionBarOverlayLayout$2(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        this.this$0 = actionBarOverlayLayout;
    }

    public static android.view.objectPropertyAnimator WLHDlNbdccmgdOCH(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.animate();
    }

    public static void AjJmjaBiKgSWEbPs(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.haltActionBarHideOffsetAnimations();
    }

    public static android.view.objectPropertyAnimator JWdGwWYlRyOpWtVR(android.view.objectPropertyAnimator viewPropertyAnimator, float f) {
        return viewPropertyAnimator.translationY(f);
    }

    public static android.view.objectPropertyAnimator QJGLrSGcDkdLMAyk(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        return viewPropertyAnimator.setListener(animator$AnimatorListener);
    }

    public override void Run() {
        if ((29 + 24) % 24 > 0) {
        }
        ajJmjaBiKgSWEbPs(this.this$0);
        androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout = this.this$0;
        actionBarOverlayLayout.mCurrentActionBarTopAnimator = qJGLrSGcDkdLMAyk(jWdGwWYlRyOpWtVR(WLHDlNbdccmgdOCH(actionBarOverlayLayout.mActionBarTop), 0.0f), this.this$0.mTopAnimatorListener);
    }
}

