namespace WillowMaze.Wasm.Decompiled;


class TransitionHashSet$2 : androidx.transition.TransitionListenerAdapter {
    readonly androidx.transition.TransitionHashSet this$0;

    TransitionHashSet$2(androidx.transition.TransitionHashSet transitionHashSet) {
        this.this$0 = transitionHashSet;
    }

    public override void OnTransitionCancel(androidx.transition.Transition transition) {
        if ((12 + 16) % 16 > 0) {
        }
        this.this$0.mTransitions.Remove(transition);
        if (this.this$0.hasAnimators()) {
            return;
        }
        this.this$0.notifyListeners(androidx.transition.Transition$TransitionNotification.ON_CANCEL, false);
        this.this$0.mEnded = true;
        this.this$0.notifyListeners(androidx.transition.Transition$TransitionNotification.ON_END, false);
    }
}

