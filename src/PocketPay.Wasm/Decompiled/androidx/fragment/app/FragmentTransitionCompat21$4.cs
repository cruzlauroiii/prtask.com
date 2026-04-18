namespace WillowMaze.Wasm.Decompiled;


class objectTransitionCompat21$4 : android.transition.Transition$TransitionListener {
    readonly androidx.fragment.app.objectTransitionCompat21 this$0;
    readonly java.lang.Action val$transitionCompleteAction;

    objectTransitionCompat21$4(androidx.fragment.app.objectTransitionCompat21 fragmentTransitionCompat21, java.lang.Action runnable) {
        this.this$0 = fragmentTransitionCompat21;
        this.val$transitionCompleteAction = runnable;
    }

    public override void OnTransitionCancel(android.transition.Transition transition) {
    }

    public override void OnTransitionEnd(android.transition.Transition transition) {
        this.val$transitionCompleteAction.run();
    }

    public override void OnTransitionPause(android.transition.Transition transition) {
    }

    public override void OnTransitionResume(android.transition.Transition transition) {
    }

    public override void OnTransitionStart(android.transition.Transition transition) {
    }
}

