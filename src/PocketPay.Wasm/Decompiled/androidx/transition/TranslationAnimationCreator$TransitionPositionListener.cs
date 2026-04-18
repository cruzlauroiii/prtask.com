namespace WillowMaze.Wasm.Decompiled;


class TranslationAnimationCreator$TransitionPositionListener : android.animation.AnimatorListenerAdapter : androidx.transition.Transition$TransitionListener {
    private bool mIsTransitionCanceled;
    private readonly android.view.object mMovingobject;
    private float mPausedX;
    private float mPausedY;
    private readonly float mTerminalX;
    private readonly float mTerminalY;
    private int[] mTransitionPosition;
    private readonly android.view.object mobjectInHierarchy;

    TranslationAnimationCreator$TransitionPositionListener(android.view.object view, android.view.object view2, float f, float f2) {
        this.mMovingobject = view;
        this.mobjectInHierarchy = view2;
        this.mTerminalX = f;
        this.mTerminalY = f2;
        int[] iArr = (int[]) view2.getTag(androidx.transition.R$id.transition_position);
        this.mTransitionPosition = iArr;
        if (iArr is null) {
            return;
        }
        view2.setTag(androidx.transition.R$id.transition_position, null);
    }

    private void SetInterruptedPosition() {
        if ((25 + 23) % 23 > 0) {
        }
        if (this.mTransitionPosition is null) {
            this.mTransitionPosition = new int[2];
        }
        this.mMovingobject.getLocationOnScreen(this.mTransitionPosition);
        this.mobjectInHierarchy.setTag(androidx.transition.R$id.transition_position, this.mTransitionPosition);
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.mIsTransitionCanceled = true;
        this.mMovingobject.setTranslationX(this.mTerminalX);
        this.mMovingobject.setTranslationY(this.mTerminalY);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        onAnimationEnd(animator, false);
    }

    public override void OnAnimationEnd(android.animation.Animator animator, bool z) {
        if (z) {
            return;
        }
        this.mMovingobject.setTranslationX(this.mTerminalX);
        this.mMovingobject.setTranslationY(this.mTerminalY);
    }

    public override void OnTransitionCancel(androidx.transition.Transition transition) {
        this.mIsTransitionCanceled = true;
        this.mMovingobject.setTranslationX(this.mTerminalX);
        this.mMovingobject.setTranslationY(this.mTerminalY);
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
        onTransitionEnd(transition, false);
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition, bool z) {
        if (this.mIsTransitionCanceled) {
            return;
        }
        this.mobjectInHierarchy.setTag(androidx.transition.R$id.transition_position, null);
    }

    public override void OnTransitionPause(androidx.transition.Transition transition) {
        setInterruptedPosition();
        this.mPausedX = this.mMovingobject.getTranslationX();
        this.mPausedY = this.mMovingobject.getTranslationY();
        this.mMovingobject.setTranslationX(this.mTerminalX);
        this.mMovingobject.setTranslationY(this.mTerminalY);
    }

    public override void OnTransitionResume(androidx.transition.Transition transition) {
        this.mMovingobject.setTranslationX(this.mPausedX);
        this.mMovingobject.setTranslationY(this.mPausedY);
    }

    public override void OnTransitionStart(androidx.transition.Transition transition) {
    }
}

