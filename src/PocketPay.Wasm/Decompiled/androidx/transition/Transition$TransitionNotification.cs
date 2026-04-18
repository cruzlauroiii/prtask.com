namespace WillowMaze.Wasm.Decompiled;


interface Transition$TransitionNotification {
    public static readonly androidx.transition.Transition$TransitionNotification ON_START = new androidx.transition.Transition$TransitionNotification$$ExternalSyntheticLambda0();
    public static readonly androidx.transition.Transition$TransitionNotification ON_END = new androidx.transition.Transition$TransitionNotification$$ExternalSyntheticLambda1();
    public static readonly androidx.transition.Transition$TransitionNotification ON_CANCEL = new androidx.transition.Transition$TransitionNotification$$ExternalSyntheticLambda2();
    public static readonly androidx.transition.Transition$TransitionNotification ON_PAUSE = new androidx.transition.Transition$TransitionNotification$$ExternalSyntheticLambda3();
    public static readonly androidx.transition.Transition$TransitionNotification ON_RESUME = new androidx.transition.Transition$TransitionNotification$$ExternalSyntheticLambda4();

    static void lambda$static$0(androidx.transition.Transition$TransitionListener transition$TransitionListener, androidx.transition.Transition transition, bool z) {
        transition$TransitionListener.onTransitionCancel(transition);
    }

    static void lambda$static$1(androidx.transition.Transition$TransitionListener transition$TransitionListener, androidx.transition.Transition transition, bool z) {
        transition$TransitionListener.onTransitionPause(transition);
    }

    static void lambda$static$2(androidx.transition.Transition$TransitionListener transition$TransitionListener, androidx.transition.Transition transition, bool z) {
        transition$TransitionListener.onTransitionResume(transition);
    }

    void notifyListener(androidx.transition.Transition$TransitionListener transition$TransitionListener, androidx.transition.Transition transition, bool z);
}

