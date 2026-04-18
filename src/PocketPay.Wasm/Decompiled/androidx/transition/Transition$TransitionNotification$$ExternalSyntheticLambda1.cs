namespace WillowMaze.Wasm.Decompiled;


public readonly class Transition$TransitionNotification$$ExternalSyntheticLambda1 : androidx.transition.Transition$TransitionNotification {
    public override readonly void NotifyListener(androidx.transition.Transition$TransitionListener transition$TransitionListener, androidx.transition.Transition transition, bool z) {
        transition$TransitionListener.onTransitionEnd(transition, z);
    }
}

