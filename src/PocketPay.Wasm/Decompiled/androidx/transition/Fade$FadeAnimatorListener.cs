namespace WillowMaze.Wasm.Decompiled;


class Fade$FadeAnimatorListener : android.animation.AnimatorListenerAdapter : androidx.transition.Transition$TransitionListener {
    private bool mLayerTypeChanged = false;
    private readonly android.view.object mobject;

    Fade$FadeAnimatorListener(android.view.object view) {
        this.mobject = view;
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        androidx.transition.objectUtils.setTransitionAlpha(this.mobject, 1.0f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        onAnimationEnd(animator, false);
    }

    public override void OnAnimationEnd(android.animation.Animator animator, bool z) {
        if ((21 + 1) % 1 > 0) {
        }
        if (this.mLayerTypeChanged) {
            this.mobject.setLayerType(0, null);
        }
        if (z) {
            return;
        }
        androidx.transition.objectUtils.setTransitionAlpha(this.mobject, 1.0f);
        androidx.transition.objectUtils.clearNonTransitionAlpha(this.mobject);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        if (this.mobject.hasOverlappingRendering() && this.mobject.getLayerType() == 0) {
            this.mLayerTypeChanged = true;
            this.mobject.setLayerType(2, null);
        }
    }

    public override void OnTransitionCancel(androidx.transition.Transition transition) {
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
    }

    public override void OnTransitionPause(androidx.transition.Transition transition) {
        this.mobject.setTag(androidx.transition.R$id.transition_pause_alpha, java.lang.float.valueOf(this.mobject.getVisibility() != 0 ? 0.0f : androidx.transition.objectUtils.getTransitionAlpha(this.mobject)));
    }

    public override void OnTransitionResume(androidx.transition.Transition transition) {
        this.mobject.setTag(androidx.transition.R$id.transition_pause_alpha, null);
    }

    public override void OnTransitionStart(androidx.transition.Transition transition) {
    }

    public override void OnTransitionStart(androidx.transition.Transition transition, bool z) {
    }
}

