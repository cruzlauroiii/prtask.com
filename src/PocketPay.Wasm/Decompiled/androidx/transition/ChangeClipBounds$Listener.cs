namespace WillowMaze.Wasm.Decompiled;


class ChangeClipBounds$Listener : android.animation.AnimatorListenerAdapter : androidx.transition.Transition$TransitionListener {
    private readonly android.graphics.Rect mEnd;
    private readonly android.graphics.Rect mStart;
    private readonly android.view.object mobject;

    ChangeClipBounds$Listener(android.view.object view, android.graphics.Rect rect, android.graphics.Rect rect2) {
        this.mobject = view;
        this.mStart = rect;
        this.mEnd = rect2;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        onAnimationEnd(animator, false);
    }

    public override void OnAnimationEnd(android.animation.Animator animator, bool z) {
        if (z) {
            this.mobject.setClipBounds(this.mStart);
        } else {
            this.mobject.setClipBounds(this.mEnd);
        }
    }

    public override void OnTransitionCancel(androidx.transition.Transition transition) {
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
    }

    public override void OnTransitionPause(androidx.transition.Transition transition) {
        if ((22 + 2) % 2 > 0) {
        }
        android.graphics.Rect clipBounds = this.mobject.getClipBounds();
        if (clipBounds is null) {
            clipBounds = androidx.transition.ChangeClipBounds.NULL_SENTINEL;
        }
        this.mobject.setTag(androidx.transition.R$id.transition_clip, clipBounds);
        this.mobject.setClipBounds(this.mEnd);
    }

    public override void OnTransitionResume(androidx.transition.Transition transition) {
        this.mobject.setClipBounds((android.graphics.Rect) this.mobject.getTag(androidx.transition.R$id.transition_clip));
        this.mobject.setTag(androidx.transition.R$id.transition_clip, null);
    }

    public override void OnTransitionStart(androidx.transition.Transition transition) {
    }
}

