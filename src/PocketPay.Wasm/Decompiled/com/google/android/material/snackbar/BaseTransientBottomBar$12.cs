namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$12 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly com.google.android.material.snackbar.BaseTransientBottomBar this$0;

    BaseTransientBottomBar$12(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        this.this$0 = baseTransientBottomBar;
    }

    public static java.lang.object MGpDdplVMoYbfxlN(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void QUnpPLvoKpqrMoVK(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, float f) {
        baseTransientBottomBar$SnackbarBaseLayout.setScaleX(f);
    }

    public static float QyDjdiSauzmDUQxm(java.lang.float f) {
        return f.floatValue();
    }

    public static void VAjDGVdyOgEjEcTe(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, float f) {
        baseTransientBottomBar$SnackbarBaseLayout.setScaleY(f);
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        float fQyDjdiSauzmDUQxm = QyDjdiSauzmDUQxm((java.lang.float) MGpDdplVMoYbfxlN(valueAnimator));
        QUnpPLvoKpqrMoVK(this.this$0.view, fQyDjdiSauzmDUQxm);
        VAjDGVdyOgEjEcTe(this.this$0.view, fQyDjdiSauzmDUQxm);
    }
}

