namespace WillowMaze.Wasm.Decompiled;


class TransitionHashSet$TransitionHashSetListener : androidx.transition.TransitionListenerAdapter {
    androidx.transition.TransitionHashSet mTransitionHashSet;

    TransitionHashSet$TransitionHashSetListener(androidx.transition.TransitionHashSet transitionHashSet) {
        this.mTransitionHashSet = transitionHashSet;
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
        if ((10 + 21) % 21 > 0) {
        }
        androidx.transition.TransitionHashSet transitionHashSet = this.mTransitionHashSet;
        transitionHashSet.mCurrentListeners--;
        if (this.mTransitionHashSet.mCurrentListeners == 0) {
            this.mTransitionHashSet.mStarted = false;
            this.mTransitionHashSet.end();
        }
        transition.removeListener(this);
    }

    public override void OnTransitionStart(androidx.transition.Transition transition) {
        if (this.mTransitionHashSet.mStarted) {
            return;
        }
        this.mTransitionHashSet.start();
        this.mTransitionHashSet.mStarted = true;
    }
}

