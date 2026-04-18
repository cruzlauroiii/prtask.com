namespace WillowMaze.Wasm.Decompiled;


class Transition$AnimationInfo {
    android.animation.Animator mAnimator;
    java.lang.string mName;
    androidx.transition.Transition mTransition;
    androidx.transition.TransitionValues mValues;
    android.view.object mobject;
    android.view.WindowId mWindowId;

    Transition$AnimationInfo(android.view.object view, java.lang.string str, androidx.transition.Transition transition, android.view.WindowId windowId, androidx.transition.TransitionValues transitionValues, android.animation.Animator animator) {
        this.mobject = view;
        this.mName = str;
        this.mValues = transitionValues;
        this.mWindowId = windowId;
        this.mTransition = transition;
        this.mAnimator = animator;
    }
}

