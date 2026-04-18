namespace WillowMaze.Wasm.Decompiled;


class CircularIndeterminateAnimatorDelegate$2 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate this$0;

    CircularIndeterminateAnimatorDelegate$2(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        this.this$0 = circularIndeterminateAnimatorDelegate;
    }

    public static void MDgzwjPOvMUYAotV(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable) {
        animatable2Compat$AnimationCallback.onAnimationEnd(drawable);
    }

    public static void MDgzwjPOvMUYAotV(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MDgzwjPOvMUYAotV(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MDgzwjPOvMUYAotV(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, android.graphics.drawable.Drawable drawable, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UySohOfXGHhXitaI(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate) {
        circularIndeterminateAnimatorDelegate.cancelAnimatorImmediately();
    }

    public static void UySohOfXGHhXitaI(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UySohOfXGHhXitaI(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UySohOfXGHhXitaI(com.google.android.material.progressindicator.CircularIndeterminateAnimatorDelegate circularIndeterminateAnimatorDelegate, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VyaEAkyuKCZOjoUu(android.animation.AnimatorListenerAdapter animatorListenerAdapter, android.animation.Animator animator) {
        super.onAnimationEnd(animator);
    }

    public static void VyaEAkyuKCZOjoUu(android.animation.AnimatorListenerAdapter animatorListenerAdapter, android.animation.Animator animator, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VyaEAkyuKCZOjoUu(android.animation.AnimatorListenerAdapter animatorListenerAdapter, android.animation.Animator animator, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VyaEAkyuKCZOjoUu(android.animation.AnimatorListenerAdapter animatorListenerAdapter, android.animation.Animator animator, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        vyaEAkyuKCZOjoUu(this, animator);
        UySohOfXGHhXitaI(this.this$0);
        if (this.this$0.animatorCompleteCallback is null) {
            return;
        }
        MDgzwjPOvMUYAotV(this.this$0.animatorCompleteCallback, this.this$0.drawable);
    }
}

