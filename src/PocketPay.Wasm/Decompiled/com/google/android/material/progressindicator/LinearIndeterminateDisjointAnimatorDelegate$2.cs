namespace WillowMaze.Wasm.Decompiled;


class LinearIndeterminateDisjointAnimatorDelegate$2 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate this$0;

    LinearIndeterminateDisjointAnimatorDelegate$2(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate) {
        this.this$0 = linearIndeterminateDisjointAnimatorDelegate;
    }

    public static void LYAqSskEvBSwIbMJ(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable) {
        animatable2Compat$AnimationCallback.onAnimationEnd(drawable);
    }

    public static void LYAqSskEvBSwIbMJ(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LYAqSskEvBSwIbMJ(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LYAqSskEvBSwIbMJ(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NprvchGJvGvtJIEu(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate) {
        linearIndeterminateDisjointAnimatorDelegate.cancelAnimatorImmediately();
    }

    public static void NprvchGJvGvtJIEu(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NprvchGJvGvtJIEu(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NprvchGJvGvtJIEu(com.google.android.material.progressindicator.LinearIndeterminateDisjointAnimatorDelegate linearIndeterminateDisjointAnimatorDelegate, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OlvmxYsgmODsZkyH(android.animation.AnimatorListenerAdapter animatorListenerAdapter, android.animation.Animator animator) {
        super.onAnimationEnd(animator);
    }

    public static void OlvmxYsgmODsZkyH(android.animation.AnimatorListenerAdapter animatorListenerAdapter, android.animation.Animator animator, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OlvmxYsgmODsZkyH(android.animation.AnimatorListenerAdapter animatorListenerAdapter, android.animation.Animator animator, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OlvmxYsgmODsZkyH(android.animation.AnimatorListenerAdapter animatorListenerAdapter, android.animation.Animator animator, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        olvmxYsgmODsZkyH(this, animator);
        nprvchGJvGvtJIEu(this.this$0);
        if (this.this$0.animatorCompleteCallback is null) {
            return;
        }
        LYAqSskEvBSwIbMJ(this.this$0.animatorCompleteCallback, this.this$0.drawable);
    }
}

