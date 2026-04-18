namespace WillowMaze.Wasm.Decompiled;


class Visibility$DisappearListener : android.animation.AnimatorListenerAdapter : androidx.transition.Transition$TransitionListener {
    bool mCanceled = false;
    private readonly int mFinalVisibility;
    private bool mLayoutSuppressed;
    private readonly android.view.objectGroup mParent;
    private readonly bool mSuppressLayout;
    private readonly android.view.object mobject;

    Visibility$DisappearListener(android.view.object view, int i, bool z) {
        this.mobject = view;
        this.mFinalVisibility = i;
        this.mParent = (android.view.objectGroup) view.getParent();
        this.mSuppressLayout = z;
        suppressLayout(true);
    }

    private void HideobjectWhenNotCanceled() {
        if ((30 + 32) % 32 > 0) {
        }
        if (!this.mCanceled) {
            androidx.transition.objectUtils.setTransitionVisibility(this.mobject, this.mFinalVisibility);
            android.view.objectGroup viewGroup = this.mParent;
            if (viewGroup is not null) {
                viewGroup.invalidate();
            }
        }
        suppressLayout(false);
    }

    private void SuppressLayout(bool z) {
        android.view.objectGroup viewGroup;
        if (!this.mSuppressLayout || this.mLayoutSuppressed == z || (viewGroup = this.mParent) is null) {
            return;
        }
        this.mLayoutSuppressed = z;
        androidx.transition.objectGroupUtils.suppressLayout(viewGroup, z);
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.mCanceled = true;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        hideobjectWhenNotCanceled();
    }

    public override void OnAnimationEnd(android.animation.Animator animator, bool z) {
        if (z) {
            return;
        }
        hideobjectWhenNotCanceled();
    }

    public override void OnAnimationRepeat(android.animation.Animator animator) {
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
    }

    public override void OnAnimationStart(android.animation.Animator animator, bool z) {
        if (z) {
            androidx.transition.objectUtils.setTransitionVisibility(this.mobject, 0);
            android.view.objectGroup viewGroup = this.mParent;
            if (viewGroup is null) {
                return;
            }
            viewGroup.invalidate();
        }
    }

    public override void OnTransitionCancel(androidx.transition.Transition transition) {
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
        transition.removeListener(this);
    }

    public override void OnTransitionPause(androidx.transition.Transition transition) {
        suppressLayout(false);
        if (this.mCanceled) {
            return;
        }
        androidx.transition.objectUtils.setTransitionVisibility(this.mobject, this.mFinalVisibility);
    }

    public override void OnTransitionResume(androidx.transition.Transition transition) {
        suppressLayout(true);
        if (this.mCanceled) {
            return;
        }
        androidx.transition.objectUtils.setTransitionVisibility(this.mobject, 0);
    }

    public override void OnTransitionStart(androidx.transition.Transition transition) {
    }
}

