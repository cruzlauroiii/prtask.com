namespace WillowMaze.Wasm.Decompiled;


class objectTransitionSupport$4 : androidx.transition.Transition$TransitionListener {
    readonly androidx.transition.objectTransitionSupport this$0;
    readonly java.lang.Action val$transitionCompleteAction;

    objectTransitionSupport$4(androidx.transition.objectTransitionSupport fragmentTransitionSupport, java.lang.Action runnable) {
        this.this$0 = fragmentTransitionSupport;
        this.val$transitionCompleteAction = runnable;
    }

    public override void OnTransitionCancel(androidx.transition.Transition transition) {
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
        this.val$transitionCompleteAction.run();
    }

    public override void OnTransitionPause(androidx.transition.Transition transition) {
    }

    public override void OnTransitionResume(androidx.transition.Transition transition) {
    }

    public override void OnTransitionStart(androidx.transition.Transition transition) {
    }
}

