namespace WillowMaze.Wasm.Decompiled;


class AnimatorTracker {
    private android.animation.Animator currentAnimator;

    AnimatorTracker() {
    }

    public static void LFklTCejSomMsKdt(android.animation.Animator animator) {
        animator.cancel();
    }

    public static void LFklTCejSomMsKdt(android.animation.Animator animator, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LFklTCejSomMsKdt(android.animation.Animator animator, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LFklTCejSomMsKdt(android.animation.Animator animator, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UbXHgWGRjkesefmO(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker) {
        animatorTracker.cancelCurrent();
    }

    public static void UbXHgWGRjkesefmO(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UbXHgWGRjkesefmO(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UbXHgWGRjkesefmO(com.google.android.material.floatingactionbutton.AnimatorTracker animatorTracker, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public void CancelCurrent() {
        android.animation.Animator animator = this.currentAnimator;
        if (animator is null) {
            return;
        }
        LFklTCejSomMsKdt(animator);
    }

    public void Clear() {
        this.currentAnimator = null;
    }

    public void OnNextAnimationStart(android.animation.Animator animator) {
        UbXHgWGRjkesefmO(this);
        this.currentAnimator = animator;
    }
}

