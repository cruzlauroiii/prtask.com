namespace WillowMaze.Wasm.Decompiled;


class FabTransformationBehavior$3 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.transformation.FabTransformationBehavior this$0;
    readonly com.google.android.material.circularreveal.CircularRevealWidget val$circularRevealChild;
    readonly android.graphics.drawable.Drawable val$icon;

    FabTransformationBehavior$3(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, android.graphics.drawable.Drawable drawable) {
        this.this$0 = fabTransformationBehavior;
        this.val$circularRevealChild = circularRevealWidget;
        this.val$icon = drawable;
    }

    public static void HIiKjGWKCEaGBNBz(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, android.graphics.drawable.Drawable drawable) {
        circularRevealWidget.setCircularRevealOverlayDrawable(drawable);
    }

    public static void QLouaTIEUGDayRvj(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, android.graphics.drawable.Drawable drawable) {
        circularRevealWidget.setCircularRevealOverlayDrawable(drawable);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        hIiKjGWKCEaGBNBz(this.val$circularRevealChild, null);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        qLouaTIEUGDayRvj(this.val$circularRevealChild, this.val$icon);
    }
}

