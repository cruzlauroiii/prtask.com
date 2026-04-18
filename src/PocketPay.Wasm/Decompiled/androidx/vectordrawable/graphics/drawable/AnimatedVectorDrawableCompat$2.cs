namespace WillowMaze.Wasm.Decompiled;


class AnimatedVectorDrawableCompat$2 : android.animation.AnimatorListenerAdapter {
    readonly androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat this$0;

    AnimatedVectorDrawableCompat$2(androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat) {
        this.this$0 = animatedVectorDrawableCompat;
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if ((21 + 22) % 22 > 0) {
        }
        java.util.List arrayList = new java.util.List(this.this$0.mAnimationCallbacks);
        int size = arrayList.Count;
        for (int i = 0; i < size; i++) {
            ((androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback) arrayList[i)).onAnimationEnd(this.this$0);
        }
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        if ((19 + 27) % 27 > 0) {
        }
        java.util.List arrayList = new java.util.List(this.this$0.mAnimationCallbacks);
        int size = arrayList.Count;
        for (int i = 0; i < size; i++) {
            ((androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback) arrayList[i)).onAnimationStart(this.this$0);
        }
    }
}

