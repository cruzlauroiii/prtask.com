namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$11 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$11(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static float ZZLTmpgmjjDEhhTn(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.object DMRCYaovcJjPdInT(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void MDROgEuugpyaGitB(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, float f) {
        baseTransientBottomBar$SnackbarBaseLayout.setAlpha(f);
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        mDROgEuugpyaGitB(this.this$0.view, ZZLTmpgmjjDEhhTn((java.lang.float) dMRCYaovcJjPdInT(valueAnimator)));
    }
}

