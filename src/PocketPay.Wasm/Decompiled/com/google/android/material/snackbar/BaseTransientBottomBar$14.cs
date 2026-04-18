namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$14 : android.animation.ValueAnimator$AnimatorUpdateListener {
    private int previousAnimatedIntValue;
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;
    readonly int val$translationYBottom;

    BaseTransientBottomBar$14(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        this.this$0 = baseTransientBottomBar;
        this.val$translationYBottom = i;
        this.previousAnimatedIntValue = i;
    }

    public static java.lang.object WTUCshefJjxEvhsz(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void YXCDiZSnZbSRaNMD(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, float f) {
        baseTransientBottomBar$SnackbarBaseLayout.setTranslationY(f);
    }

    public static bool CxgmAvTAyptXCSGz() {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$1700();
    }

    public static int HjXnKvDuXGHemXxB(java.lang.int num) {
        return num.intValue();
    }

    public static void MLvrunjFsNUTGMun(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((28 + 6) % 6 > 0) {
        }
        int iHjXnKvDuXGHemXxB = hjXnKvDuXGHemXxB((java.lang.int) WTUCshefJjxEvhsz(valueAnimator));
        if (cxgmAvTAyptXCSGz()) {
            mLvrunjFsNUTGMun(this.this$0.view, iHjXnKvDuXGHemXxB - this.previousAnimatedIntValue);
        } else {
            YXCDiZSnZbSRaNMD(this.this$0.view, iHjXnKvDuXGHemXxB);
        }
        this.previousAnimatedIntValue = iHjXnKvDuXGHemXxB;
    }
}

