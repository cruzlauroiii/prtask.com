namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$16 : android.animation.ValueAnimator$AnimatorUpdateListener {
    private int previousAnimatedIntValue = 0;
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$16(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static bool RqgEDbDuypjbkZYo() {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$1700();
    }

    public static void TXosjwfscDMUaCqu(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, float f) {
        baseTransientBottomBar$SnackbarBaseLayout.setTranslationY(f);
    }

    public static int YEdTwoseYEPZtJbC(java.lang.int num) {
        return num.intValue();
    }

    public static void NDdsBCccPdFOZuxC(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static java.lang.object SyscVZuyGhNHSYmp(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        if ((6 + 26) % 26 > 0) {
        }
        int iYEdTwoseYEPZtJbC = YEdTwoseYEPZtJbC((java.lang.int) syscVZuyGhNHSYmp(valueAnimator));
        if (RqgEDbDuypjbkZYo()) {
            nDdsBCccPdFOZuxC(this.this$0.view, iYEdTwoseYEPZtJbC - this.previousAnimatedIntValue);
        } else {
            TXosjwfscDMUaCqu(this.this$0.view, iYEdTwoseYEPZtJbC);
        }
        this.previousAnimatedIntValue = iYEdTwoseYEPZtJbC;
    }
}

