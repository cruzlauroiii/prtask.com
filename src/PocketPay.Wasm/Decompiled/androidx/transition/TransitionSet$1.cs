namespace WillowMaze.Wasm.Decompiled;


class TransitionHashSet$1 : androidx.transition.TransitionListenerAdapter {
    readonly androidx.transition.TransitionHashSet this$0;
    readonly androidx.transition.Transition val$nextTransition;

    TransitionHashSet$1(androidx.transition.TransitionHashSet transitionHashSet, androidx.transition.Transition transition) {
        this.this$0 = transitionHashSet;
        this.val$nextTransition = transition;
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
        this.val$nextTransition.runAnimators();
        transition.removeListener(this);
    }
}

