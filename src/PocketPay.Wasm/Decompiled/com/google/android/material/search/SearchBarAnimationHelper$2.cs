namespace WillowMaze.Wasm.Decompiled;


class SearchBarAnimationHelper$2 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.search.SearchBarAnimationHelper this$0;
    readonly android.view.object val$centerobject;
    readonly android.animation.Animator val$secondaryobjectAnimator;

    SearchBarAnimationHelper$2(com.google.android.material.search.SearchBarAnimationHelper searchBarAnimationHelper, android.view.object view, android.animation.Animator animator) {
        this.this$0 = searchBarAnimationHelper;
        this.val$centerobject = view;
        this.val$secondaryobjectAnimator = animator;
    }

    public static void SvuhfAAfYbqKwdAx(android.animation.Animator animator) {
        animator.start();
    }

    public static void SvuhfAAfYbqKwdAx(android.animation.Animator animator, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SvuhfAAfYbqKwdAx(android.animation.Animator animator, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SvuhfAAfYbqKwdAx(android.animation.Animator animator, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HCUVWLbTfhlHdMuH(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void HCUVWLbTfhlHdMuH(android.view.object view, int i, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HCUVWLbTfhlHdMuH(android.view.object view, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HCUVWLbTfhlHdMuH(android.view.object view, int i, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        hCUVWLbTfhlHdMuH(this.val$centerobject, 8);
        SvuhfAAfYbqKwdAx(this.val$secondaryobjectAnimator);
    }
}

