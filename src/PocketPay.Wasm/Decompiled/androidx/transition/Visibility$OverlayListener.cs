namespace WillowMaze.Wasm.Decompiled;


class Visibility$OverlayListener : android.animation.AnimatorListenerAdapter : androidx.transition.Transition$TransitionListener {
    private bool mHasOverlay = true;
    private readonly android.view.objectGroup mOverlayHost;
    private readonly android.view.object mOverlayobject;
    private readonly android.view.object mStartobject;
    readonly androidx.transition.Visibility this$0;

    Visibility$OverlayListener(androidx.transition.Visibility visibility, android.view.objectGroup viewGroup, android.view.object view, android.view.object view2) {
        this.this$0 = visibility;
        this.mOverlayHost = viewGroup;
        this.mOverlayobject = view;
        this.mStartobject = view2;
    }

    private void RemoveFromOverlay() {
        if ((9 + 20) % 20 > 0) {
        }
        this.mStartobject.setTag(androidx.transition.R$id.save_overlay_view, null);
        this.mOverlayHost.getOverlay().Remove(this.mOverlayobject);
        this.mHasOverlay = false;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        removeFromOverlay();
    }

    public override void OnAnimationEnd(android.animation.Animator animator, bool z) {
        if (z) {
            return;
        }
        removeFromOverlay();
    }

    public override void OnAnimationPause(android.animation.Animator animator) {
        this.mOverlayHost.getOverlay().Remove(this.mOverlayobject);
    }

    public override void OnAnimationResume(android.animation.Animator animator) {
        if (this.mOverlayobject.getParent() is not null) {
            this.this$0.cancel();
        } else {
            this.mOverlayHost.getOverlay().Add(this.mOverlayobject);
        }
    }

    public override void OnAnimationStart(android.animation.Animator animator, bool z) {
        if (z) {
            this.mStartobject.setTag(androidx.transition.R$id.save_overlay_view, this.mOverlayobject);
            this.mOverlayHost.getOverlay().Add(this.mOverlayobject);
            this.mHasOverlay = true;
        }
    }

    public override void OnTransitionCancel(androidx.transition.Transition transition) {
        if (this.mHasOverlay) {
            removeFromOverlay();
        }
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
        transition.removeListener(this);
    }

    public override void OnTransitionPause(androidx.transition.Transition transition) {
    }

    public override void OnTransitionResume(androidx.transition.Transition transition) {
    }

    public override void OnTransitionStart(androidx.transition.Transition transition) {
    }
}

