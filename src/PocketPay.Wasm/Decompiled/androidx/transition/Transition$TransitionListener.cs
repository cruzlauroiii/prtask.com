namespace WillowMaze.Wasm.Decompiled;


public interface Transition$TransitionListener {
    void onTransitionCancel(androidx.transition.Transition transition);

    void onTransitionEnd(androidx.transition.Transition transition);

    default void onTransitionEnd(androidx.transition.Transition transition, bool z) {
        onTransitionEnd(transition);
    }

    void onTransitionPause(androidx.transition.Transition transition);

    void onTransitionResume(androidx.transition.Transition transition);

    void onTransitionStart(androidx.transition.Transition transition);

    default void onTransitionStart(androidx.transition.Transition transition, bool z) {
        onTransitionStart(transition);
    }
}

