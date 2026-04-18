namespace WillowMaze.Wasm.Decompiled;


interface MotionStrategy {
    void addAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener);

    android.animation.AnimatorHashSet createAnimator();

    com.google.android.material.animation.MotionSpec getCurrentMotionSpec();

    int getDefaultMotionSpecResource();

    java.util.List<android.animation.Animator$AnimatorListener> getListeners();

    com.google.android.material.animation.MotionSpec getMotionSpec();

    void onAnimationCancel();

    void onAnimationEnd();

    void onAnimationStart(android.animation.Animator animator);

    void onChange(com.google.android.material.floatingactionbutton.ExtendedfloatingActionButton$OnChangedCallback extendedfloatingActionButton$OnChangedCallback);

    void performNow();

    void removeAnimationListener(android.animation.Animator$AnimatorListener animator$AnimatorListener);

    void setMotionSpec(com.google.android.material.animation.MotionSpec motionSpec);

    bool shouldCancel();
}

