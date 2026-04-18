namespace WillowMaze.Wasm.Decompiled;


protected class ScrollingTabContainerobject$VisibilityAnimListener : android.animation.AnimatorListenerAdapter {
    private bool mCanceled = false;
    private int mFinalVisibility;
    readonly androidx.appcompat.widget.ScrollingTabContainerobject this$0;

    protected ScrollingTabContainerobject$VisibilityAnimListener(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        this.this$0 = scrollingTabContainerobject;
    }

    public static void CbgxakoXRJCuVekZ(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setVisibility(i);
    }

    public static void MgeRWNpeRmfDBqOc(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setVisibility(i);
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.mCanceled = true;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if (this.mCanceled) {
            return;
        }
        this.this$0.mVisibilityAnim = null;
        mgeRWNpeRmfDBqOc(this.this$0, this.mFinalVisibility);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        cbgxakoXRJCuVekZ(this.this$0, 0);
        this.mCanceled = false;
    }

    public androidx.appcompat.widget.ScrollingTabContainerobject$VisibilityAnimListener withFinalVisibility(android.view.objectPropertyAnimator viewPropertyAnimator, int i) {
        this.mFinalVisibility = i;
        this.this$0.mVisibilityAnim = viewPropertyAnimator;
        return this;
    }
}

